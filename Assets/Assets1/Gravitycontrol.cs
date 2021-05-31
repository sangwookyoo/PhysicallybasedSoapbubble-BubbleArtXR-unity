using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravitycontrol : MonoBehaviour
{
    public Rigidbody rb;
    private float p = 0.00125f;//공기 밀도
    private float c = 0.47f;//공기저항계수
    private float r = 10f; //반지름
    private float g = 9.8f;//중력가속도
    private float num = 0;
    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(10, 30);
        num /= 10;
        rb = gameObject.GetComponent<Rigidbody>();
        rb.useGravity = true;
        //rb.velocity = new Vector3(0, 0.1f, num/5);

    }

    // Update is called once per frame
    void Update()
    {
        float V = (4 * Mathf.PI * r * r * r) / 3;//비눗방울의 부피 4186.667
        float M = p * V; //비눗방울의 질량 5.234
        float A = 2 * Mathf.PI * r * r;//비눗방울의 단면적 314
        Vector3 Fd = new Vector3(0, -c * A * rb.velocity.y * rb.velocity.y / (2 * M), 0);
        //비눗방울의 공기저항가속도
        //rb.velocity -= Fd;//  * Time.deltaTime*num;
        // transform.Rotate(new Vector3(1, 0, 0), 1);
        Physics.gravity = new Vector3(0, -0.5f, 0);
    }
}
