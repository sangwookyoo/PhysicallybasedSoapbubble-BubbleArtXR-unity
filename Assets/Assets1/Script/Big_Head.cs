using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Big_Head : MonoBehaviour
{
    
    
    public int blendShapeCount;
    public SkinnedMeshRenderer skinnedMeshRenderer;             // Morpher를 담당하는 컴포넌트를 저장할 변수
    public Mesh skinnedMesh;                                    // Morpher를 담당하는 컴포넌트에 있는 Morpher의 메쉬
    public float blend1 = 0f;                                   // 뒤
    public float blend2 = 0f;                                   // 앞
    public float blendSpeed1 = 1f;
    public float blendSpeed2 = 1f;

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
        blendSpeed1 = 1f;
        blendSpeed2 = 1f;
        //this.transform.position = new Vector3(((21.05f - 2.92f) * Big_long.num / 100) + 2.92f, 0f, 0f);
    }

    void FixedUpdate()
    {

            if (blend2 < num)
            {
                while (blend2 < num)
                {
                // 앞
                    skinnedMeshRenderer.SetBlendShapeWeight(1, blend2);
                    blend2 += blendSpeed2;
                }
            }
            else
            {
                /*while(blend1<100)
                {
                    skinnedMeshRenderer.SetBlendShapeWeight(0, blend1);
                    blend1 += blendSpeed1;
                }*/
                Create_Big.check = true;
              //  gameObject.GetComponent<ReCreate>().enabled = true;
            gameObject.GetComponent<SplineWalker>().enabled = true;
                //gameObject.GetComponent<Deformer>().enabled = true;
                
            Destroy(this);
            }
        
    }
    
}
