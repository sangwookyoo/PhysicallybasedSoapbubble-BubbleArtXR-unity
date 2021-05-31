using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class TubeSensor : MonoBehaviour
{
    //SerialPort sp = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One); //set Serial port

    public enum PortNumber
    {
        COM1, COM2, COM3, COM4,
        COM5, COM6, COM7, COM8,
        COM9, COM10, COM11, COM12,
        COM13, COM14, COM15, COM16
    }

    private SerialPort sp;

    [SerializeField]
    private PortNumber portNumber = PortNumber.COM3;
    [SerializeField]
    private string baudRate = "9600";

    int val = 0;

    public GameObject bubble;
    public GameObject bubble2;
    public static bool check;
    public GameObject createpos;
    public bool create;
    private int count = 0;
    private float btime = 0f;
    private float wait = 1f;

    void Start()
    {
        sp.Open(); //Serial port open
        sp.ReadTimeout = 1; //set Serial timeout

        check = true;
        count = 0;
        create = true;
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

        if (val > 10)
        {
            if (blow == false)
            {
                bubble2 = Instantiate(bubble, createpos.transform.position, createpos.transform.rotation) as GameObject;
                StartCoroutine("GoWind");
            }
        }
    }


    bool blow;

    IEnumerator GoWind()
    {
        blow = true;
        yield return new WaitForSeconds(5.0f);
        blow = false;
    }

}
