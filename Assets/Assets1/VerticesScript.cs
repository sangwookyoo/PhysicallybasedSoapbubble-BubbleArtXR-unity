using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticesScript : MonoBehaviour
{
    
    private Rigidbody rb;//무게중심 불러올 클래스
    private Vector3 com;//무게중심
    private float runtime = 0;
    //---------------------가정값-------------------------------------------------------------------------------
    private float surfacetension = 25.0f;//표면장력(가정)
    //private float a = 2.63f;//초당 지름 증가량(얇은 빨대 3.4초 기준)
    private float max = 4.4f;//반 지름 최대값
    private float n = 0.00125f;//공기의 밀도(비눗방울 액체의 무게는 제외-너무 양이 적음)
    private float C = 0.47f;
    private float F = 1;//외력인데 아직 안넣음
    //------------------------------------------------------------------------------------------------------------------------------------

    private float p;//내,외부 압력차
    private float r;//중심점과 버텍스의 거리
    private float v;//부피
    private float m;//질량
    private float speed;//버텍스 속도
    private float acel;//가속도
    private float brake;//감속값 
    private float A = 0;//단면적

    // Start is called before the first frame update
    void Awake()
    {
        int i=0;
        p = 4 * surfacetension / max;//내,외부 압력차
        v = 4 * Mathf.PI * Mathf.Pow(max, 3)/3;//부피
        m = n * v/10;//질량(kg->g)
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;//각 버텍스 좌표
        while (i < vertices.Length)
        {

            vertices[i] += vertices[i].normalized * (max+3);
            i++;
        }
        mesh.vertices = vertices;
        mesh.RecalculateBounds();

        A = 2 * Mathf.PI * max * max;
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float runtime = 0;

        rb = GetComponent<Rigidbody>();
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;//각 버텍스 좌표
        
        com = rb.centerOfMass;//무게중심
        runtime = Time.deltaTime;
        int i = 0;
        float[] bvertices = new float[515];
        //Debug.Log(vertices.Length);
        


        
        while (i < vertices.Length)
        {
  
            r = Mathf.Sqrt(Mathf.Pow((rb.centerOfMass.x - vertices[i].x),2)+ Mathf.Pow((rb.centerOfMass.y - vertices[i].y), 2)
                +Mathf.Pow((rb.centerOfMass.z - vertices[i].z), 2));//무게중심과 버텍스의 거리
            
            if (r > max)
            {

                acel = (-surfacetension) * m ;//가속도(dyne *질량=가속도)
               
            }
            else if (r < max)
            {
                
                acel = p * m;
            }
            else
            {
                acel = 0;
            }
            
            if (speed > 0)
                acel -= brake;

            speed = bvertices[i]+acel*runtime;
            bvertices[i] = speed;//이전 속도 재설정

            vertices[i] += vertices[i].normalized * speed;
          i++;

        }
        Debug.Log("압력차:" + p + "중심점과의 거리:" + r + "부피:" + v + "질량:" + m + "버텍스의 가속도:" + acel + "속도:" + speed + "감속도:" + brake);

        mesh.vertices = vertices;
        mesh.RecalculateBounds();



        


    }


}

    