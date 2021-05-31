using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicktube : MonoBehaviour
{

    public GameObject child_;//hoop

    public bool active;
    public float c_count = 0;
    public GameObject smallstraw;
    public GameObject bigstraw;
    public GameObject hoop;
    

    private void Start()
    {
        active = false;

    }
    // Start is called before the first frame update
    public void clicked()
    {
        Debug.Log("클릭되었습니다.");
        child_.SetActive(true);
        smallstraw.SetActive(false);
        hoop.SetActive(false);
        bigstraw.SetActive(false);
    }
    public void unclicked()
    {

    }

}
