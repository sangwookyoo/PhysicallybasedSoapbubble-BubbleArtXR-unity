using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tube_model1 : MonoBehaviour
{
    public int blendShapeCount;
    public SkinnedMeshRenderer skinnedMeshRenderer;             // Morpher를 담당하는 컴포넌트를 저장할 변수
    public Mesh skinnedMesh;                                    // Morpher를 담당하는 컴포넌트에 있는 Morpher의 메쉬
    public float blend1 = 0f;                                   // 불려나옴
    public float blendSpeed1 = 1f;

    public int num;

    void Awake()
    {

        skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        skinnedMesh = GetComponent<SkinnedMeshRenderer>().sharedMesh;
    }

    void Start()
    {
        blendShapeCount = skinnedMesh.blendShapeCount;          // Morpher의 가지수(현재는 가로길이와 세로 흔들림 두가지임)
        num = Random.Range(70,100);
        blendSpeed1 = 2f;
    }

    void Update()
    {
        if (blend1 < num)
        {
            // 불려나옴
            skinnedMeshRenderer.SetBlendShapeWeight(0, blend1);
            blend1 += blendSpeed1;
        }
        else
        {
 
            Create_Tube.check = true;
            gameObject.GetComponent<ReCreate>().enabled = true;
            gameObject.GetComponent<Deformer>().enabled = true;
            gameObject.GetComponent<SpeedControl>().enabled = true;
            gameObject.GetComponent<Rigidbody>().useGravity = true;

            Destroy(this);
        }

    }
}
