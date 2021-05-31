using UnityEngine;
using UnityEditor;

[RequireComponent(typeof(MeshFilter))]
public class Deformer : MonoBehaviour
{

    public float springForce = 20f;                                             // 가속도 보정
    public float damping = 5f;                                                  // 반발력

    //-----------
    public float max = 2f;//반지름 최댓값
    public float acel;//가속도
    public float sur = 25f;//표면장력
    public float m;//질량
    public float p;//내외부 압력차
    public float v;//부피
    public float n = 0.0125f;//공기의 밀도
    private float rad;
                              //------------
    public Mesh deformingMesh;                                                         // 변형 후 메쉬를 저장하는 변수
    Vector3[] originalVertices, displacedVertices;                              // 기존에 있던 점의 위치를 저장하는 배열, 변동된 점의 위치를 저장하는 배열
    Vector3[] vertexVelocities;                                 // 각 점의 이동속도 저장 배열
    float uniformScale = 10f;
    MeshCollider meshcollider;
    Vector3 center;

    void Start()
    { // 각 변수 초기화

        p = 4 * sur / max;  //비눗방울 내,외부 압력차 계산
        v = 4 * Mathf.PI * max * max * max / 3; // 부피계산
        m = n * v;                  //질량 계산

        //Debug.Log(m);


        deformingMesh = GetComponent<MeshFilter>().mesh;            //비눗방울의 메쉬 복사
        originalVertices = deformingMesh.vertices;                  //비눗방울의 버텍스 복사 -> 읽기용으로 처음 비눗방울의 크기나 반지름을 계산하기 위함 
        displacedVertices = new Vector3[originalVertices.Length];   //위에 만든 버텍스의 길이를 가진 새로운 배열 생성 --> 움직임을 저장하기 위함
        vertexVelocities = new Vector3[originalVertices.Length];    //위와 같은 길이로 각 버텍스의 속도를 저장하기 위함
        for (int i = 0; i < originalVertices.Length; i++)           
        {
            displacedVertices[i] = originalVertices[i];             //원본을 복사
        }

        Rigidbody rb = GetComponent<Rigidbody>();                   //리지드바디
        //com = Vector3.zero;
        meshcollider = GetComponent<MeshCollider>();                //콜라이더
        rad = (displacedVertices[0]-displacedVertices[displacedVertices.Length-1]).magnitude/2;
        //0번 버텍스의 길이계산

        center = originalVertices[0] + originalVertices[originalVertices.Length - 1];       //비눗방울의 중심점 계산
        center = center / 2;                                                                //..
        rb.centerOfMass = center;                                                           //centerofmass는 무게중심인데 이걸 변경하면 오브젝트의 gizmo가 변경되고 상대좌표가 (0,0,0)으로 바뀜
        //center = rb.centerOfMass;
    }

    void Update()
    {
        uniformScale = transform.localScale.x;                              //외부에서 충돌처리 관련된 힘의 비율 조정(적당히 조절하면됨)
        for (int i = 0; i < displacedVertices.Length; i++)
        {    //점의 개수만큼 점의 이동 계산을 반복
            UpdateVertex(i);
            //displacedVertices[i] = SmoothFilter.hcFilter(deformingMesh.vertices, displacedVertices, deformingMesh.triangles, 0.0f, 0.5f);
        }
        deformingMesh.vertices = displacedVertices;             //콜라이더의 모양을 변경시키기 위함
        //deformingMesh.RecalculateNormals();                     //메쉬의 노멀벡터를 재계산한다.
        meshcollider.sharedMesh = null;                         //
        //meshcollider.sharedMesh = deformingMesh;                //메쉬콜라이더는 원래 처음의 모습으로 고정이지만 그것을 비눗방울 모양대로 계속 계산해줌
    }

    void UpdateVertex(int i)
    {                                 // 점의 이동을 담당하는 함수

       
        Vector3 velocity = vertexVelocities[i];                 //기존 점 속도 저장
        Vector3 displacement = originalVertices[i]-center;      //각 버텍스의 이동방향 --> 각 버텍스의 법선벡터
        //Rigidbody rb = GetComponent<Rigidbody>();


        Vector3 rp = center - displacedVertices[i];             //아래 공식을 위함
        float r = rp.magnitude;                                 //무게중심과 버텍스와의 길이

        float rd = Mathf.Abs(r-rad)*2;                          //처음 모양에서 멀리 이동할수록(움직임의 폭이 클수록) 감속하기 위한 변수

        if (r > rad)                                            //각 버텍스의 가속도 계산
            acel = p * m ;
        else if (r < rad)
            acel = -p * m;
        else
            acel = 0;

        //displacement *= uniformScale;
        //Debug.Log(rd);
        velocity -= acel * displacement * Time.deltaTime*rd/100;   //가속도를 속도로 바꿈 
        //velocity *= 1f - damping * Time.deltaTime;
        velocity *= (1f - (Time.deltaTime));                        //시간이 감에 따라 출렁이는 속도 감소
        vertexVelocities[i] = velocity;                             //필요하지만 큰 의미없음
        //Debug.Log(displacement);
        displacedVertices[i] += velocity * (Time.deltaTime );       //궁금하면 바꿔보면 암
        //for (i = 0; i < displacedVertices.Length; i++)
        {
            //AddForceToVertex(i, displacedVertices[i], velocity.magnitude);
        }
    }

    public void AddDeformingForce(Vector3 point, float force)
    {//구를 변형시키는 힘의 변화를 체크하는 함수(각각의 꼭지점에 변형력을 개별적으로 적용할것)
        point = transform.InverseTransformPoint(point);         //눌리는 시점 (립모션과 연동하여 손으로 바꿔볼것)
        for (int i = 0; i < displacedVertices.Length; i++)
        {
            AddForceToVertex(i, point, force);
        }
    }

    void AddForceToVertex(int i, Vector3 point, float force)
    { //힘으로 부터 속도를 구하는 함수
        Vector3 pointToVertex = displacedVertices[i] - point;   //힘이 적용된 부분부터 각점까지의 거리 계산
        pointToVertex *= uniformScale;
        //float attenuatedForce = force * (Mathf.Log(pointToVertex.magnitude))/(2*Mathf.PI);//감쇠힘 계산
        float attenuatedForce = force / (2 * Mathf.PI * (pointToVertex.magnitude + 1));//감쇠힘 계산
        float velocity = attenuatedForce * Time.deltaTime;      //속도 값 계산
        //vertexVelocities[i] -= originalVertices[i].normalized * velocity;
        displacedVertices[i] -= originalVertices[i].normalized * velocity;//정규화를 통한 방향 계산
    }

}