using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tube_model2 : MonoBehaviour
{
    public int blendShapeCount;
    public SkinnedMeshRenderer skinnedMeshRenderer;             // Morpher를 담당하는 컴포넌트를 저장할 변수
    public Mesh skinnedMesh;                                    // Morpher를 담당하는 컴포넌트에 있는 Morpher의 메쉬
    public float blend1 = 0f;                                   // 가로
    public float blend2 = 0f;                                   // 세로
    public float blend3 = 0f;                                   // 흔들림1
    public float blend4 = 50f;                                   // 흔들림2
    public float blend5 = 100f;                                   // 흔들림3
    public float blendSpeed1 = 1f;
    public float blendSpeed2 = 1.5f;

    public int num;

    public bool check1 = true;
    public bool check2 = true;
    public bool check3 = false;
    void Awake()
    {
        skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        skinnedMesh = GetComponent<SkinnedMeshRenderer>().sharedMesh;
    }

    void Start()
    {
        blendShapeCount = skinnedMesh.blendShapeCount;          // Morpher의 가지수(현재는 가로길이와 세로 흔들림 두가지임)
        num = 100;
        blendSpeed1 = 2f;
        blendSpeed2 = 2f;
    }

    void Update()
    {
        if (blend1 < num)
        {
            // 가로
            skinnedMeshRenderer.SetBlendShapeWeight(0, blend1);
            blend1 += blendSpeed1;
        }
        if (blend2 < num)
        {
            // 세로
            skinnedMeshRenderer.SetBlendShapeWeight(1, blend2);
            blend2 += blendSpeed1;
            
        }
        else
        {
            Destroy(this);
            gameObject.GetComponent<ReCreate>().enabled = true;
            gameObject.GetComponent<Deformer>().enabled = true;
            gameObject.GetComponent<SpeedControl>().enabled = true;
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            Create_Tube.check = true;
  
        }
        if(check1 == true) // 흔들림1
        {
            if (blend3 < num)
            {
                skinnedMeshRenderer.SetBlendShapeWeight(2, blend3);
                blend3 += blendSpeed2;
            }
            else
                check1 = false;
        }
        else
        {
            if (blend3 > 0)
            {
                skinnedMeshRenderer.SetBlendShapeWeight(2, blend3);
                blend3 -= blendSpeed2;
            }
            else
                check1 = true;
        }
        if (check2 == true) // 흔들림2
        {
            if (blend4 < num)
            {
                skinnedMeshRenderer.SetBlendShapeWeight(3, blend4);
                blend4 += blendSpeed2;
            }
            else
                check2 = false;
        }
        else
        {
            if (blend3 > 0)
            {
                skinnedMeshRenderer.SetBlendShapeWeight(3, blend4);
                blend4 -= blendSpeed2;
            }
            else
                check2 = true;
        }
        if (check3 == true) // 흔들림3
        {
            if (blend5 < num)
            {
                skinnedMeshRenderer.SetBlendShapeWeight(4, blend5);
                blend5 += blendSpeed2;
            }
            else
                check3 = false;
        }
        else
        {
            if (blend5 > 0)
            {
                skinnedMeshRenderer.SetBlendShapeWeight(4, blend5);
                blend5 -= blendSpeed2;
            }
            else
                check3 = true;
        }
    }
}
