using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class long_Morpher : MonoBehaviour
{

    public int blendShapeCount;
    public SkinnedMeshRenderer skinnedMeshRenderer;             // Morpher를 담당하는 컴포넌트를 저장할 변수
    public Mesh skinnedMesh;                                    // Morpher를 담당하는 컴포넌트에 있는 Morpher의 메쉬
    public static float blend1 = 0f;                            // 가로1
    public float blend3 = 0f;                                   // 세로1
    public float blend4 = 50f;                                  // 세로2
    public float blend5 = 100f;                                 // 세로3
    public float blendSpeed1 = 1f;
    public float blendSpeed2 = 5f;
    public bool blendTwoCount = false;
    public bool blend3Count = true;
    public bool blend4Count = true;
    public int max;
    public static int min;
    public static bool start = false;


    void Awake()
    {
        skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        skinnedMesh = GetComponent<SkinnedMeshRenderer>().sharedMesh;
    }

    void Start()
    {
        blendShapeCount = skinnedMesh.blendShapeCount;          // Morpher의 가지수(현재는 가로길이와 세로 흔들림 두가지임)
        max = 100;
        min = Random.Range(70, 100);

        blendSpeed1 = 10f;
        blendSpeed2 = 10f;
    }

    void Update()
    {

        CreateBubble create = GameObject.Find("CreateBubble").GetComponent<CreateBubble>();
        if (blendShapeCount >= 2)
        {
            if (blend1 < min)
            {
                //가로 1 조절
                skinnedMeshRenderer.SetBlendShapeWeight(0, blend1);
                blend1 += blendSpeed1;
                blendSpeed1 += 0.01f;
                // 세로 1 조절
                if (blendTwoCount == false)
                {
                    skinnedMeshRenderer.SetBlendShapeWeight(1, blend3);
                    blend3 += blendSpeed2;

                    if (blend3 >= 100f)
                    {
                        blendTwoCount = true;
                    }
                }

                else
                {
                    skinnedMeshRenderer.SetBlendShapeWeight(1, blend3);
                    blend3 -= blendSpeed2;

                    if (blend3 <= 0f)
                    {
                        blendTwoCount = false;
                    }
                }
                //세로2 조절
                if (blend3Count == false)
                {
                    skinnedMeshRenderer.SetBlendShapeWeight(2, blend4);
                    blend4 += blendSpeed2;

                    if (blend4 >= 100f)
                    {
                        blend3Count = true;
                    }
                }

                else
                {
                    skinnedMeshRenderer.SetBlendShapeWeight(2, blend4);
                    blend4 -= blendSpeed2;

                    if (blend4 <= 0f)
                    {
                        blend3Count = false;
                    }
                }
                //세로3 조절
                if (blend4Count == false)
                {
                    skinnedMeshRenderer.SetBlendShapeWeight(3, blend5);
                    blend5 += blendSpeed2;

                    if (blend5 >= 100f)
                    {
                        blend4Count = true;
                    }
                }

                else
                {
                    skinnedMeshRenderer.SetBlendShapeWeight(3, blend5);
                    blend5 -= blendSpeed2;

                    if (blend5 <= 0f)
                    {
                        blend4Count = false;
                    }
                }
            }
            else
            {
                //세로1조절
                if (blendTwoCount == false)
                {
                    skinnedMeshRenderer.SetBlendShapeWeight(1, blend3);
                    blend3 += blendSpeed2;

                    if (blend3 >= 100f)
                    {
                        blendTwoCount = true;
                    }
                }

                else
                {
                    skinnedMeshRenderer.SetBlendShapeWeight(1, blend3);
                    blend3 -= blendSpeed2;

                    if (blend3 <= 0f)
                    {
                        blendTwoCount = false;
                    }
                }
                //세로2 조절
                if (blend3Count == false)
                {
                    skinnedMeshRenderer.SetBlendShapeWeight(2, blend4);
                    blend4 += blendSpeed2;

                    if (blend4 >= 100f)
                    {
                        blend3Count = true;
                    }
                }

                else
                {
                    skinnedMeshRenderer.SetBlendShapeWeight(2, blend4);
                    blend4 -= blendSpeed2;

                    if (blend4 <= 0f)
                    {
                        blend3Count = false;
                    }
                }
                //세로3 조절
                if (blend4Count == false)
                {
                    skinnedMeshRenderer.SetBlendShapeWeight(3, blend5);
                    blend5 += blendSpeed2;

                    if (blend5 >= 100f)
                    {
                        blend4Count = true;
                    }
                }

                else
                {
                    skinnedMeshRenderer.SetBlendShapeWeight(3, blend5);
                    blend5 -= blendSpeed2;

                    if (blend5 <= 0f)
                    {
                        blend4Count = false;
                    }
                }
            }
        }
        if (create.delete == false)
        {
            Destroy(gameObject);
        }
    }
}
