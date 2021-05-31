using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject smallstraw;
    public GameObject bigstraw;
    public GameObject hoop;
    public GameObject tube;
    public GameObject menu1;
    //public GameObject menu2;

    public void touch()
    {
        Debug.Log("터치했습니다");

        smallstraw.SetActive(false);
        hoop.SetActive(false);
        bigstraw.SetActive(false);
        tube.SetActive(false);
        menu1.SetActive(false);
        //menu2.SetActive(false);
    }
}
