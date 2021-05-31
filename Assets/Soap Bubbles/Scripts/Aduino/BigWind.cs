using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class BigWind : MonoBehaviour
{
    //현재 시리얼 포트 연동이 다른 방법인데 뭐가 나은지 아직 모르겠음 고민중
    //SerialPort sp = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One); //set Serial port
    int val = 0;
    float speed = 20.0f;
    public ParticleSystem Bubbleparticle_2;
    //public GameObject bubbleparticle_2;

    SerialC spScript;

    private void Awake()
    {
        spScript = GameObject.Find("sp").GetComponent<SerialC>();
    }

    


    public void FixedUpdate()
    {
        if (spScript.sp.IsOpen)
        {
            try
            {
                val = spScript.sp.ReadByte();
                Debug.Log(val);
            }
            catch (System.Exception) { }
        }

        // 10 이상의 값을 받으면 비눗방울이 나옴
        if (val > 10)
        {
            if (blow == false)
            {
                Bubbleparticle_2.Play();
                StartCoroutine("GoWind");
            }
        }
    }

    //코루틴
    bool blow;

    IEnumerator GoWind()
    {
        blow = true;
        yield return new WaitForSeconds(1.0f);
        Bubbleparticle_2.Stop();
        blow = false;
    }

}