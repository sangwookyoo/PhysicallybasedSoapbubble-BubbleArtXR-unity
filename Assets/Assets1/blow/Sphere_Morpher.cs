using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sphere_Morpher : MonoBehaviour
{

    public int blendShapeCount;
    public SkinnedMeshRenderer skinnedMeshRenderer;             // Morpher를 담당하는 컴포넌트를 저장할 변수
    public Mesh skinnedMesh;                                    // Morpher를 담당하는 컴포넌트에 있는 Morpher의 메쉬
    public float blend1 = 0f;                                   // 앞
    public float blend2 = 0f;                                   // 뒤
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
        blendSpeed2 = 1f;
        //this.transform.position = new Vector3(-0.044f, 0.09f, 0f);
    }

    void FixedUpdate()
    {
        //if (Morpher6.blend1 < Morpher6.min)
        //{
        //    if (Morpher6.min >= 70 && Morpher6.min < 80)
        //        transform.Translate(Vector3.back * 0.183f * Time.deltaTime);
        //    else if (Morpher6.min >= 80 && Morpher6.min < 90)
        //        transform.Translate(Vector3.back * 0.183f * Time.deltaTime);
        //    else if (Morpher6.min >= 90 && Morpher6.min <= 100)
        //        transform.Translate(Vector3.back * 0.183f * Time.deltaTime);
        //}
        //else
        //{

        if (blend1 < num)
        {
            // 앞조절
            while (blend1 < num)
            {
                skinnedMeshRenderer.SetBlendShapeWeight(1, blend1);
                blend1 += blendSpeed2;
            }
            //Debug.Log(blend1);
        }
        else
        {

                // 뒷조절
                while (blend2 < 100)
                {
                    skinnedMeshRenderer.SetBlendShapeWeight(0, blend2);
                    blend2 += blendSpeed2;
                }
                CreateBubble.check = true;
               



 
                gameObject.GetComponent<SplineWalker>().enabled = true;     //처음에 컴포넌트는 실행되지 않도록 설정해놓았기때문에 true로
                gameObject.GetComponent<ReCreate>().enabled = true;         //바꾸면 그때부터 스크립트가 실행됨
                //gameObject.GetComponent<Deformer>().enabled = true;
                Destroy(this);



        }

    }
}
