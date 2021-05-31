using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{

    public GameObject child_;//hoop

    public bool active;
    public float c_count = 0;
    public GameObject smallstraw;
    public GameObject bigstraw;
    public GameObject tube;
    public GameObject bubble3;
    public GameObject spline3;
    Create_Big create_Big = new Create_Big();
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
        bigstraw.SetActive(false);
        tube.SetActive(false);
        bubble3 = GameObject.Find("1.3bubhead(Clone)");
        spline3 = GameObject.Find("BigSpline(Clone)");

        Destroy(spline3);
        Destroy(bubble3);
    }
    public void unclicked()
    {

    }

}