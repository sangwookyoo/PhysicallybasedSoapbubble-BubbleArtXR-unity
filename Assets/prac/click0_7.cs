

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click0_7 : MonoBehaviour
{

    public GameObject child_;//0.7

    public bool active;
    public float c_count = 0;
    public GameObject bigstraw;
    public GameObject hoop;
    public GameObject tube;

    private void Start()
    {
        active = false;

    }
    // Start is called before the first frame update
    public void clicked()
    {
        Debug.Log("클릭되었습니다.");
        child_.SetActive(true);
        hoop.SetActive(false);
        bigstraw.SetActive(false);
        tube.SetActive(false);
    }
    
}
