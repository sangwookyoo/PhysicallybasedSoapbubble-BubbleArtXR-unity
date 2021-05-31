using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class WindSensorTest : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One); //set Serial port
    int val = 0;
    public ParticleSystem Bubbleparticle_1;
    public ParticleSystem Bubbleparticle_2;

    void Start()
    {
        sp.Open(); //Serial port open
        sp.ReadTimeout = 1; //set Serial timeout
        //StartCoroutine(GoWind());
    }

    public void BlowStraw(string num)
    {

        switch (num)
        {
            case "SG":                       // 작은빨대
                if (val > 10)
                {
                    if (blow == false)
                    {
                        Bubbleparticle_1.Play();
                        StartCoroutine("GoWind");
                    }
                }
                break;
            case "BG":                       // 큰빨대
                if (val > 10)
                {
                    if (blow == false)
                    {
                        Bubbleparticle_2.Play();
                        StartCoroutine("GoWind");
                    }
                }
                break;
        }

        if (sp.IsOpen)
        {
            //sp.Open();
            try
            {
                val = sp.ReadByte();
                Debug.Log(val);
            }
            catch (System.Exception) { }
        }

    }

    //코루틴
    bool blow;

    IEnumerator GoWind()
    {
        blow = true;
        //yield return new WaitForSeconds(1.0f);
        Bubbleparticle_1.Stop();
        Bubbleparticle_2.Stop();
        yield return new WaitForSeconds(1.0f);
        blow = false;
    }

}