/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Vibration2 : MonoBehaviour
{
    public GameObject smallstraw_;
    public GameObject bigstraw_;
    public GameObject tube_;
    public GameObject hoop_;

    public enum PortNumber
    {
        COM1, COM2, COM3, COM4,
        COM5, COM6, COM7, COM8,
        COM9, COM10, COM11, COM12,
        COM13, COM14, COM15, COM16
    }

    private SerialPort serial;

    [SerializeField]
    private PortNumber portNumber = PortNumber.COM3;
    [SerializeField]
    private string baudRate = "9600";



    // Start is called before the first frame update
    void Start()
    {
        serial = new SerialPort(portNumber.ToString(), int.Parse(baudRate), Parity.None, 8, StopBits.One);
        serial.Open();
        serial.ReadTimeout = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (serial.IsOpen)
        {
            try
            {
                BtnParticle(serial.ReadByte());
            }
            catch (System.TimeoutException e)
            {
                Debug.Log(e);
                throw;
            }
            //GameObject.Find("ArduinoState").GetComponent<Text>
        }
    }

    void BtnParticle(int Number)
    {
        Debug.Log(Number);

        if (smallstraw_.activeSelf == true) //만약 작은빨대가 on 상태라면
        {
            arduSerialPort.Write("3"); //연결된 시리얼포트로 "3"의 값을 전달

            //Thread.Sleep(1000);
        }
        if (bigstraw_.activeSelf == true)
        {
            arduSerialPort.Write("4"); //연결된 시리얼포트로 "4"의 값을 전달

            //Thread.Sleep(1000);
        }
        if (tube_.activeSelf == true)
        {
            arduSerialPort.Write("2"); //연결된 시리얼포트로 "2"의 값을 전달

            //Thread.Sleep(1000);
        }
        if (hoop_.activeSelf == true)
        {
            arduSerialPort.Write("1"); //연결된 시리얼포트로 "1"의 값을 전달

            //Thread.Sleep(1000);
        }
    }
}
*/
