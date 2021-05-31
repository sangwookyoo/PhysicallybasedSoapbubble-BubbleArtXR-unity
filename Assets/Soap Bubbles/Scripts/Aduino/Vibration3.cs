using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.Threading;

public class Vibration : MonoBehaviour
{

    public SerialPort arduSerialPort; //시리얼 포트 전달
    public GameObject Sstraw;
    public GameObject Bstraw;
    public GameObject TubeObject;
    public GameObject HoopObject;

    void Start()
    {
        SerialPort sp = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One); //set Serial port
        //Thread.Sleep(1000);
    }

    //bool ONOFF = false;
    // Update is called once per frame

    void Update()
    {
        if (Sstraw.activeSelf == true) //만약 작은빨대가 on 상태라면
        {
            arduSerialPort.Write("3"); //연결된 시리얼포트로 "3"의 값을 전달

            //Thread.Sleep(1000);
        }
        else if (Bstraw.activeSelf == true)
        {
            arduSerialPort.Write("4"); //연결된 시리얼포트로 "4"의 값을 전달

            //Thread.Sleep(1000);
        }
        else if (TubeObject.activeSelf == true)
        {
            arduSerialPort.Write("2"); //연결된 시리얼포트로 "2"의 값을 전달

            //Thread.Sleep(1000);
        }
        else if (HoopObject.activeSelf == true)
        {
            arduSerialPort.Write("1"); //연결된 시리얼포트로 "1"의 값을 전달

            //Thread.Sleep(1000);
        }

    }

}