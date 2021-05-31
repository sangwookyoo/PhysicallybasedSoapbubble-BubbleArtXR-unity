//////////////////튜브 스피드//////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedControl : MonoBehaviour
{
    public Rigidbody rb;
    private float p = 0.00125f;//공기 밀도
    private float c = 0.47f;//공기저항계수
    private float r = 10f; //반지름
    private float g = 9.8f;//중력가속도
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0f, 0.1f);
        rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(speed, speed, speed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float V = (4 * Mathf.PI * r * r * r) / 3;//비눗방울의 부피
        float M = p * V; //비눗방울의 질량
        float A = 2 * Mathf.PI * r * r;//비눗방울의 단면적
        Vector3 Drag = new Vector3(c * A * rb.velocity.x * rb.velocity.x / (2 * M), -c * A * rb.velocity.y * rb.velocity.y / (2 * M), c * A * rb.velocity.z * rb.velocity.z / (2 * M));
        //비눗방울의 공기저항가속도
        rb.velocity -= Drag/100*Time.deltaTime*speed;
        
    }
}
