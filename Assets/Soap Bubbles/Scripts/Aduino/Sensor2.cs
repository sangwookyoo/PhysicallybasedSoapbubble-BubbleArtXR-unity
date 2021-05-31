using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.IO.Ports;
using System;

/* 데이터 그대로 string으로 입력받는 스크립트 */

public class Sensor2 : MonoBehaviour
{
    //SerialPort m_SerialPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One); //set Serial port
    SerialPort s_port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One); //set Serial port

    //int val = 0;
    //float speed = 20.0f;
    public GameObject bubbleparticle;
    string SensorValue;

    //public SerialPort s_port = GameObject.Find("serial").GetComponent<SerialC>().serial;

    void Start()
    {
        //s_port = GameObject.Find("serial").GetComponent<SerialC>().serial;
        //불러들인 데이터 모두 읽는 부분

        s_port.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceived);

        s_port.Open();
    }

    void Update()
    {
        try
        {
            if (s_port.IsOpen)
            {

                SensorValue = s_port.ReadLine();
                s_port.ReadTimeout = 30;
                Debug.Log(SensorValue);
                //int num = Int32.Parse(SensorValue);
                //Debug.Log(num);

                /*
                if (num > 5)
                {
                    Bubbleparticle.Play();
                }
                else
                {
                    Bubbleparticle.Stop();
                }
                */

            }
        }
        catch (TimeoutException e) //주르륵 에러뜨는거 방지용
        {
            //Debug.Log(e);
        }
    }

    //불러들인 데이터 읽기 설정
    private void SerialDataReceived(object sender, SerialDataReceivedEventArgs args)
    {
        SerialPort s_port = (SerialPort)sender;
        string Data = s_port.ReadExisting();

        Debug.Log("Data Received Finish");
        Debug.Log(Data);
    }
}
