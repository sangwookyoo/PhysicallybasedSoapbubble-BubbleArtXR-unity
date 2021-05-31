using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoop1 : MonoBehaviour
{
    public int blendShapeCount;
    public SkinnedMeshRenderer skinnedMeshRenderer;             // Morpher를 담당하는 컴포넌트를 저장할 변수
    public Mesh skinnedMesh;                                    // Morpher를 담당하는 컴포넌트에 있는 Morpher의 메쉬
    public float blend1 = 0f;                                   // 가로1
    public float blend2 = 0f;                                   // 세로1
    public float blendSpeed1 = 1f;
    public float blendSpeed2 = 0.5f;
    public int num1;
    public int num3;

    void Awake()
    {
        skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        skinnedMesh = GetComponent<SkinnedMeshRenderer>().sharedMesh;
    }

    void Start()
    {
        blendShapeCount = skinnedMesh.blendShapeCount;          // Morpher의 가지수(현재는 가로길이와 세로 흔들림 두가지임)
        //num = 100;
        blend1 = 100; //비눗방울이 나오는 속도
        blend2 = 0;  //기존 수치는 0이였다. 비눗방울이 나오는속도
        num1 = 0;
        num3 = 100; //b2와의 차이만큼 빨리 나오고 좀더 원형에 가까워진다.
        blendSpeed1 = 2f;
        blendSpeed2 = 2f; 
        
    }

    void Update()
    {
        
        if (blend1 > num1)
        {
            // 가로 1 조절
            skinnedMeshRenderer.SetBlendShapeWeight(0, blend1);
            blend1 -= blendSpeed1;
        }
        
        if (blend2 < num3)
        {
            // 세로 조절
            skinnedMeshRenderer.SetBlendShapeWeight(1, blend2);
            blend2 += blendSpeed2;
        }
        
        else
        {
            gameObject.GetComponent<ReCreate>().enabled = true;
            gameObject.GetComponent<Deformer1>().enabled = true; //비눗방울의 줄어들었다커졌다 움직임 스크립트

            gameObject.GetComponent<Gravitycontrol>().enabled = true;
            
            Create_Hoop.check = true;
            Destroy(this);
        }
        
    }
}
