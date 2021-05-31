using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class Sensor : MonoBehaviour
{
    //현재 시리얼 포트 연동이 다른 방법인데 뭐가 나은지 아직 모르겠음 고민중
    SerialPort sp = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One); //set Serial port

    
    private string baudRate = "9600";

    int val = 0;
    float speed = 20.0f;
    public ParticleSystem Bubbleparticle_1;
    //public GameObject bubbleparticle_2;

    //private SerialPort sp = GameObject.Find("serial").GetComponent<SerialC>().serial;


    void Start()
    {
        sp.Open(); //Serial port open
        sp.ReadTimeout = 1; //set Serial timeout
    }

    void FixedUpdate()
    {
        if (sp.IsOpen)
        {
            try
            {
                val = sp.ReadByte();
                Debug.Log(val);
            }
            catch (System.Exception) { }
        }

        // 10 이상의 값을 받으면 비눗방울이 나옴
        if (val > 10)
        {
            if (blow == false)
            {
                Bubbleparticle_1.Play();
                StartCoroutine("GoWind");
            }
        }
    }

    bool blow;

    IEnumerator GoWind()
    {
        blow = true;
        yield return new WaitForSeconds(0.5f);
        Bubbleparticle_1.Stop();
        blow = false;
    }

}
