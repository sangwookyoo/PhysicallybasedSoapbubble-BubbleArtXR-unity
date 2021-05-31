using UnityEngine;

//[RequireComponent(typeof(MeshFilter))]
public class MeshDeformer : MonoBehaviour {

	public float springForce = 20f;                                             // 가속도 보정
	public float damping = 5f;                                                  // 반발력

    //-----------
    public float max = 4.4f;//반지름 최댓값
    public float acel;//가속도
    public float sur = 2.5f;//표면장력
    public float m;//질량
    public float p;//내외부 압력차
    public float v;//부피
    public float n = 0.00125f;//공기의 밀도
    //------------
	public Mesh deformingMesh;                                                         // 변형 후 메쉬를 저장하는 변수
	Vector3[] originalVertices, displacedVertices;                              // 기존에 있던 점의 위치를 저장하는 배열, 변동된 점의 위치를 저장하는 배열
    Vector3[] vertexVelocities;                                 // 각 점의 이동속도 저장 배열
    float uniformScale = 10f;
    Vector3 center;
 

    void Start () { // 각 변수 초기화

        p = 4 * sur / max;
        v = 4 * Mathf.PI * max * max * max / 3;
        m = n * v;

        //Debug.Log(m);


        deformingMesh = GetComponent<MeshFilter>().mesh;
        
        originalVertices = deformingMesh.vertices;
        
        displacedVertices = new Vector3[originalVertices.Length];
        //Debug.Log(displacedVertices.Length);
        
        for (int i = 0; i < originalVertices.Length; i++) {
			displacedVertices[i] = originalVertices[i];
		}
		vertexVelocities = new Vector3[originalVertices.Length];
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 com = rb.centerOfMass;//무게중심이 항상 0으로 잡힘-애니메이션으로 이동시에도 변화하는지 확인필요
        //com = Vector3.zero;
        center = originalVertices[0] + originalVertices[originalVertices.Length-1];
        center = center / 2;
        //Debug.Log(center);
        
    }

	void Update () {
		uniformScale = transform.localScale.x;
        
        for (int i = 0; i < displacedVertices.Length; i++) {    //점의 개수만큼 점의 이동 계산을 반복
           // Debug.Log("9");
            UpdateVertex(i);
		}
		deformingMesh.vertices = displacedVertices;
		deformingMesh.RecalculateNormals();                     //메쉬의 노멀벡터를 재계산한다.

   
    }

	void UpdateVertex (int i) {                                 // 점의 이동을 담당하는 함수
		Vector3 velocity = vertexVelocities[i];                 //기존 점 속도 저장
        Vector3 displacement = originalVertices[i]-center;
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 com = rb.centerOfMass;//무게중심이 항상 0으로 잡힘-애니메이션으로 이동시에도 변화하는지 확인필요
        com = Vector3.zero;
        
        Vector3 rp = center-displacedVertices[i];
        float r = rp.magnitude;//무게중심과 버텍스와의 길이
        float rd = (center - originalVertices[0]).magnitude;
        //Debug.Log(i);
        //Debug.Log(r);
        //Debug.Log(displacedVertices[i]);
        
       
        
        if (r > rd) 
            acel = sur * m;
        else if (r < rd)
            acel = -p * m;
        else
            acel = 0;
        
        //displacement *= uniformScale;
        velocity -= acel * displacement * Time.deltaTime;
        //velocity *= 1f - damping * Time.deltaTime;
        velocity *= (1f - (2*Time.deltaTime));
        vertexVelocities[i] = velocity;
        //Debug.Log(displacement);
        displacedVertices[i] += velocity * (Time.deltaTime*uniformScale);
 

    }

	public void AddDeformingForce (Vector3 point, float force)
    {//구를 변형시키는 힘의 변화를 체크하는 함수(각각의 꼭지점에 변형력을 개별적으로 적용할것)
        point = transform.InverseTransformPoint(point);         //눌리는 시점 (립모션과 연동하여 손으로 바꿔볼것)
        for (int i = 0; i < displacedVertices.Length; i++)
        {
            AddForceToVertex(i, point, force);
        }
    }

	void AddForceToVertex (int i, Vector3 point, float force) { //힘으로 부터 속도를 구하는 함수
        Vector3 pointToVertex = displacedVertices[i] - point;   //힘이 적용된 부분부터 각점까지의 거리 계산
		pointToVertex *= uniformScale;
        //float attenuatedForce = force * (Mathf.Log(pointToVertex.magnitude))/(2*Mathf.PI);//감쇠힘 계산
        float attenuatedForce = force/(2*Mathf.PI*(pointToVertex.magnitude+1));//감쇠힘 계산
        float velocity = attenuatedForce * Time.deltaTime;      //속도 값 계산
		vertexVelocities[i] += pointToVertex.normalized * velocity;//정규화를 통한 방향 계산
	}
            
}