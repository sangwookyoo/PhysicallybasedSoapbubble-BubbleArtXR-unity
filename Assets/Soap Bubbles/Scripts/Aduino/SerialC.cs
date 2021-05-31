using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.Threading;
using System;
using System.Collections;

// 물건을 잡았을 때 진동
public class SerialC : MonoBehaviour
{
    //public SerialPort serial = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One); //set Serial port
    //public SerialPort sp = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One); //set Serial port
    public SerialPort sp = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One); //set Serial port
    //sp = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);

    void Start()
    {
        sp.Open(); //Serial port open
        sp.ReadTimeout = 1; //set Serial timeout
    }

    /*
    public enum PortNumber
    {
        COM1, COM2, COM3, COM4,
        COM5, COM6, COM7, COM8,
        COM9, COM10, COM11, COM12,
        COM13, COM14, COM15, COM16
    }

    public static SerialPort sp;

    [SerializeField]
    private PortNumber portNumber = PortNumber.COM3;
    [SerializeField]
    private string baudRate = "9600";


    private bool smallstraw_ = false;
    private bool bigstraw_ = false;
    private bool tube_ = false;
    private bool hoop_ = false;
    private bool stop_ = false;

    //public float LimitTime = 2;

    void Start()
    {
        sp = new SerialPort(portNumber.ToString(), int.Parse(baudRate));
    }
    */
}