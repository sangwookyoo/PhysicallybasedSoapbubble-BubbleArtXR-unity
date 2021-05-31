

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.Threading;
using UnityEngine.UI;

// 물건을 잡았을 때 진동
public class Vibrationtest : MonoBehaviour
{

    SerialPort sp = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One); //set Serial port

    




    private bool smallstraw_ = false;
    private bool bigstraw_ = false;
    private bool tube_ = false;
    private bool hoop_ = false;
    private bool stop_ = false;

    public Text OnTextscript;


    public void VibToggle(string data)
    {
        bool VibState = false;

        // 진동 상태값 불러오기
        switch (data)
        {
            case "S":                       // 작은빨대
                VibState = smallstraw_;
                //Invoke("WaitSec", 1f);

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
        //Invoke("WaitSec", 1f); // 0.5초 뒤 진동 해제

        /* 소문자 안써서 일단 뺌
        else if (VibState)
        {
            serial.Write(data.ToLower());
            VibState = !VibState;
        }
        */
    }

    //진동해제
    void WaitSec(string data)
    {
        bool VibState = false;

        // 진동 상태값 불러오기
        switch (data)
        {
            case "O":                       
                VibState = smallstraw_;     // 작은빨대
                VibState = bigstraw_;       // 큰빨대
                VibState = tube_;           // 튜브
                VibState = hoop_;           // 후프
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

        }
    }

    void TextOn()
    {
        OnTextscript.text = "Vib On";
    }

    /*
    public void OnApplicationQuit()
    {
        serial.Close();
    }
    */

}