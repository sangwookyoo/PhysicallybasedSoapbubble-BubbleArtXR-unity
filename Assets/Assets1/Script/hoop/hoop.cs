using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class hoop : MonoBehaviour
{
    public int blendShapeCount;
    public SkinnedMeshRenderer skinnedMeshRenderer;             // Morpher를 담당하는 컴포넌트를 저장할 변수
    public Mesh skinnedMesh;                                    // Morpher를 담당하는 컴포넌트에 있는 Morpher의 메쉬
    public float blend1 = 0f;                                   // 가로1
    public float blend2 = 0f;                                   // 세로1
    public float blend3 = 0f;                                   // 흔들림3
    public float blend4 = 0f;                                   // 흔들림1
    public float blend5 = 0f;                                   // 흔들림2
    public float blendSpeed1 = 1f;
    public float blendSpeed2 = 2f;
    public float blendSpeed3 = 2f;

    public bool check1 = true;
    public bool check2 = true;
    public bool check3 = false;
    public bool check4 = true;

    public static int num1;
    public int num2;
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
        num1 = Random.Range(70, 100);
        num2 = 10;
        num3 = Random.Range(50, 70);
        blendSpeed1 = 0.5f;
        blendSpeed2 = 1f;
        blendSpeed3 = 0.5f;
        blend1 = 10;
        blend2 = 0;
        blend3 = 0;
        blend4 = num2/2;
        blend5 = num2;
        check4 = false;
    }

    void Update()
    {
        if (blend1>= 0)
        {
            // 가로 1 조절
            skinnedMeshRenderer.SetBlendShapeWeight(0, blend1);
            blend1 -= blendSpeed1;
        }
        else
        {
            check4 = true;
            Create_Hoop.check = true;
        }
        if (check4 == true)
        {
            if (blend2 < num3)
            {
                // 세로 조절
                skinnedMeshRenderer.SetBlendShapeWeight(1, blend2);
                blend2 += blendSpeed2;
            }
            else
            {
                gameObject.GetComponent<ReCreate>().enabled = true;
                gameObject.GetComponent<Deformer1>().enabled = true;
                Destroy(this);
            }

            check4 = false;
        //}
        //if (check1 == true)
        //{
        //    if (blend3 < num2) 
        //    {
        //        // 흔들림3 조절
        //        skinnedMeshRenderer.SetBlendShapeWeight(2, blend3);
        //        blend3 += blendSpeed3;
        //    }
        //    else
        //        check1 = false;
        //}
        //else
        //{
        //    if (blend3 > 0)
        //    {
        //        // 흔들림3 조절
        //        skinnedMeshRenderer.SetBlendShapeWeight(2, blend3);
        //        blend3 -= blendSpeed3;
        //    }
        //    else
        //        check1 = true;
        //}
        //if (check2 == true)
        //{
        //    if (blend4 < num2)
        //    {
        //        // 흔들림1 조절
        //        skinnedMeshRenderer.SetBlendShapeWeight(3, blend4);
        //        blend4 += blendSpeed3;
        //    }
        //    else
        //        check2 = false;
        //}
        //else
        //{
        //    if (blend4 > 0)
        //    {
        //        // 흔들림1 조절
        //        skinnedMeshRenderer.SetBlendShapeWeight(3, blend4);
        //        blend4 -= blendSpeed3;
        //    }
        //    else
        //        check2 = true;
        //}
        //if (check3 == true)
        //{
        //    if (blend5 < num2)
        //    {
        //        // 흔들림2 조절
        //        skinnedMeshRenderer.SetBlendShapeWeight(4, blend5);
        //        blend5 += blendSpeed3;
        //    }
        //    else
        //        check3 = false;
        //}
        //else
        //{
        //    if (blend5 > 0)
        //    {
        //        // 흔들림2 조절
        //        skinnedMeshRenderer.SetBlendShapeWeight(4, blend5);
        //        blend5 -= blendSpeed3;
        //    }
        //    else
        //        check3 = true;
        }
    }
}
*/