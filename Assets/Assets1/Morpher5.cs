using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morpher5 : MonoBehaviour {

    public int blendShapeCount;
    public SkinnedMeshRenderer skinnedMeshRenderer;             // Morpher를 담당하는 컴포넌트를 저장할 변수
    public Mesh skinnedMesh;                                    // Morpher를 담당하는 컴포넌트에 있는 Morpher의 메쉬
    public float blend1 = 0f;                                   // 가로1
    public float blend2 = 0f;                                   // 세로 불림1
    public static float blend3 = 0f;                                   // 세로 불림2
    public float blendSpeed1 = 1f;
    public float blendSpeed2 = 5f;

    public int num;
    
    void Awake()
    {
        skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        skinnedMesh = GetComponent<SkinnedMeshRenderer>().sharedMesh;
    }

    void Start()
    {
        blendShapeCount = skinnedMesh.blendShapeCount;          // Morpher의 가지수(현재는 가로길이와 세로 흔들림 두가지임)
        num = Random.Range(37, 100);
        //this.transform.position = new Vector3(((21.05f-2.92f) * Morpher6.min/100)+2.92f, 0f, 0f);
        //Debug.Log(Morpher6.min);
        //Debug.Log(((21.05f - 2.92f) * Morpher6.min / 100) + 2.92f);
    }

    void Update()
    {
        if (long_Morpher.blend1 >= long_Morpher.min)
        {
            if (blend2 < num)
            {
                // 가로 1 조절
                skinnedMeshRenderer.SetBlendShapeWeight(0, blend1);
                blend1 += blendSpeed1;
                // 불림 조절
                skinnedMeshRenderer.SetBlendShapeWeight(1, blend2);
                blend2 += blendSpeed1;
            }
            else
            {
                skinnedMeshRenderer.SetBlendShapeWeight(2, blend3);
                blend3 += blendSpeed1;

                CreateBubble.check = true;

                Destroy(this.gameObject);

                //blend1 = 0;
                //blend2 = 0;
                //num = Random.Range(37, 100);
            }
        }
    }
}
