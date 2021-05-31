using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class PlusTest : MonoBehaviour
{
    //현재 시리얼 포트 연동이 다른 방법인데 뭐가 나은지 아직 모르겠음 고민중
    SerialPort sp = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One); //set Serial port
    int val = 0;
    float speed = 20.0f;
    public ParticleSystem Bubbleparticle_1;
    //public GameObject bubbleparticle_2;


    private bool smallstraw_ = false;
    private bool bigstraw_ = false;
    private bool tube_ = false;
    private bool hoop_ = false;
    private bool stop_ = false;

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
        yield return new WaitForSeconds(1.0f);
        Bubbleparticle_1.Stop();
        blow = false;
    }

    public void VibToggle(string data)
    {
        bool VibState = false;

        // 진동 상태값 불러오기
        switch (data)
        {
            case "S":                       // 작은빨대
                VibState = smallstraw_;
                break;
            case "B":                       // 큰빨대
                VibState = bigstraw_;
                break;
            case "T":                       // 튜브
                VibState = tube_;
                break;
            case "H":                       // 후프
                VibState = hoop_;
                break;
            case "O":
                VibState = stop_;
                break;
        }

        // 포트 연결
        if (!sp.IsOpen)
        {
            sp.Open();
        }

        // 진동 온
        if (VibState == false)
        {
            sp.Write(data);
            VibState = !VibState;

            //Invoke("WaitSec", 1f);
        }

        //진동 해제
        //Invoke("WaitSec", 0.5f); // 0.5초 뒤 진동 해제

    }


}
