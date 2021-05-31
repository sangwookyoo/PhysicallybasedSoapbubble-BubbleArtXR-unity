using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Morpher8 : MonoBehaviour {

    public int blendShapeCount;
    public SkinnedMeshRenderer skinnedMeshRenderer;             // Morpher를 담당하는 컴포넌트를 저장할 변수
    public Mesh skinnedMesh;         // Morpher를 담당하는 컴포넌트에 있는 Morpher의 메쉬
    public Mesh cloneMesh;
    public float blend1 = 0f;                                   // 앞
    public float blend2 = 0f;                                   // 뒤
    public float blendSpeed1 = 1f;
    public float blendSpeed2 = 5f;
    private bool door=true;
    public int num;
    private Mesh mesh;
    private ChangeVertices changeVertices;
    public GameObject clone;
   // private Vector3[] vertices;
    private Vector3[] normals;
    private int[] triangles;
    private Vector2[] uv;
    //private Mesh originalmesh;
    private Material bubblemat;

    void Awake()
    {
        skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        skinnedMesh = GetComponent<SkinnedMeshRenderer>().sharedMesh;
        bubblemat = skinnedMeshRenderer.material;
    }

    void Start()
    {
        blendShapeCount = skinnedMesh.blendShapeCount;          // Morpher의 가지수(현재는 가로길이와 세로 흔들림 두가지임)
        num = Random.Range(37, 50);
        //this.transform.position = new Vector3(-0.044f, 0.09f, 0f);
    }

    void Update()
    {
        if (long_Morpher.blend1 < long_Morpher.min)
        {
            if (long_Morpher.min >= 70 && long_Morpher.min < 80)
                transform.Translate(Vector3.back * 4.62f * Time.deltaTime);
            else if (long_Morpher.min >= 80 && long_Morpher.min < 90)
                transform.Translate(Vector3.back * 4.7f * Time.deltaTime);
            else if (long_Morpher.min >= 90 && long_Morpher.min <= 100)
                transform.Translate(Vector3.back * 4.8f * Time.deltaTime);
        }
        else
        {

            if (blend1 < num)
            {
            // 앞조절
            
            skinnedMeshRenderer.SetBlendShapeWeight(1, blend1);
                blend1 += blendSpeed2;
            
           
        }
            else
            {
            if (blend2 < 100) {
                // 뒷조절
                skinnedMeshRenderer.SetBlendShapeWeight(0, blend2);
                blend2 += blendSpeed2;
            }
            else
            {
                if(door==true)
                {
                    gameObject.GetComponent<SplineWalker>().enabled = true;
                    cloneMesh = new Mesh();
                    skinnedMeshRenderer.BakeMesh(cloneMesh);
                    //cloneMesh = GetComponent<SkinnedMeshRenderer>().sharedMesh;
                    //Debug.Log(cloneMesh.vertices[200]);
                    GetComponent<MeshFilter>().mesh = mesh = new Mesh();
                    
                    
                    mesh.vertices =cloneMesh.vertices;
                    mesh.normals = cloneMesh.normals;

                    mesh.triangles = cloneMesh.triangles;
                    mesh.uv = cloneMesh.uv;
                    gameObject.AddComponent<MeshRenderer>();
                    gameObject.GetComponent<MeshRenderer>().material = bubblemat;
                    Destroy(skinnedMeshRenderer);
                    

                    //MeshUtility.Optimize(mesh);
                    gameObject.GetComponent<Deformer>().enabled=true;
                    
                    door = false;
                }
            }
                //blend1 = 0;
                //blend2 = 0;
                //num = Random.Range(37, 100);
            }
        }
    }
}
