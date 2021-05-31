using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGravity : MonoBehaviour
{
    float time;
    float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        float dMove = Time.deltaTime * speed;
        if (time < 2)
        {
            transform.Translate(Vector3.up * dMove) ;
        }
        else if (time > 2 && time < 3)
        {
            transform.Translate(Vector3.down * dMove * 2);
        }
        else if(time >= 3 && time <4)
        {
            transform.Translate(Vector3.up * dMove);
        }
        else if(time >= 4)
        {
            transform.Translate(Vector3.down * dMove * 2);
        }
    }
}
