using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class SensorT : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One); //set Serial port
    int val = 0;
    //public ParticleSystem Bubbleparticle_1;

    public GameObject bubble;
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
                bubble = Instantiate(bubble, createpos.transform.position, createpos.transform.rotation) as GameObject;
                StartCoroutine("GoWind");
            }
        }
    }


    bool blow;

    IEnumerator GoWind()
    {
        blow = true;
        //bubble.gameObject.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        //bubble.gameObject.SetActive(false);
        blow = false;
    }

        /*
            // 10 이상의 값을 받으면 비눗방울이 나옴
            if (val > 10)
            {
                bubble = Instantiate(bubble, createpos.transform.position, createpos.transform.rotation) as GameObject;
                //Destroy(bubble, 5);
                Invoke("WaitSec", 3f);
            }

        }

        void WaitSec()
        {
            bubble.gameObject.SetActive(false);
            //Debug.Log("1초 지남");
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
        */

    }
