using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Big_long : MonoBehaviour
{
    public int blendShapeCount;
    public SkinnedMeshRenderer skinnedMeshRenderer;             // Morpher를 담당하는 컴포넌트를 저장할 변수
    public Mesh skinnedMesh;                                    // Morpher를 담당하는 컴포넌트에 있는 Morpher의 메쉬
    public static float blend1 = 0f;                                   // 가로1
    public float blend2 = 0f;                                   // 세로1
    public float blend3 = 0f;                                   // 세로2
    public float blendSpeed1 = 1f;
    public float blendSpeed2 = 5f;

    public static int num;

    public bool check1;
    public bool check2;

    void Awake()
    {
        skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        skinnedMesh = GetComponent<SkinnedMeshRenderer>().sharedMesh;
    }

    void Start()
    {
        blendShapeCount = skinnedMesh.blendShapeCount;          // Morpher의 가지수(현재는 가로길이와 세로 흔들림 두가지임)
        //num = 100;
        num = Random.Range(40, 100);
        blendSpeed1 = 5f;
        blendSpeed2 = 3f;
        blend3 = 50;
        check1 = true;
        check2 = true;
    }

    void Update()
    {
        Create_Big create = GameObject.Find("Create").GetComponent<Create_Big>();
        if (blend1 < num)
        {
            // 가로 1 조절
            skinnedMeshRenderer.SetBlendShapeWeight(0, blend1);
            blend1 += (blendSpeed1 -= 0.004f);
        }
        if (check1 == true)
        {
            if (blend2 < 30)
            {
                // 세로 조절
                skinnedMeshRenderer.SetBlendShapeWeight(1, blend2);
                blend2 += blendSpeed2;
            }
            else
            {
                check1 = false;
            }
        }
        else
        {
            if (blend2 > 0)
            {
                // 세로 조절
                skinnedMeshRenderer.SetBlendShapeWeight(1, blend2);
                blend2 -= blendSpeed2;
            }
            else
            {
                check1 = true;
            }
        }
        if (check2 == true)
        {
            if (blend3 > 0)
            {
                // 세로 조절
                skinnedMeshRenderer.SetBlendShapeWeight(2, blend3);
                blend3 -= blendSpeed2;
            }
            else
            {
                check2 = false;
            }
        }
        else
        {
            if (blend3 < 30)
            {
                // 세로 조절
                skinnedMeshRenderer.SetBlendShapeWeight(2, blend3);
                blend3 += blendSpeed2;
            }
            else
            {
                check2 = true;
            }
        }
        //if (create.delete == false)
        //{
        //    Destroy(gameObject);
        //}
    }
}
