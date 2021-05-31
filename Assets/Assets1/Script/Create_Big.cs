using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Big : MonoBehaviour
{
    public GameObject bubble;
    public GameObject bubble2;
    public GameObject bubble3;
    public GameObject spline;
    public GameObject spline2;
    public GameObject spline3;
    public static bool check;
    public float power;
    public float btime = 0f;
    public bool des;
    public bool delete;
    public GameObject createpos;
    public Transform parent;
    private float wait = 0.07f;
    private float distance;
    
    public void b_create()
    {
        spline2 = Instantiate(spline, createpos.transform.position, transform.rotation ) as GameObject;
        
        bubble2 = Instantiate(bubble, createpos.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;

        
        Destroy(spline2,20);
        Destroy(bubble2, 3);
    }
    public void b_destroy()
    {
        bubble3 = GameObject.Find("1.3bubhead(Clone)"); 
        spline3 = GameObject.Find("BigSpline(Clone)");
        
        Destroy(spline3);
        Destroy(bubble3);
    }
    // Start is called before the first frame update
    void Start()
    {
        des = false;
        check = true;
        power = 0.1f;
        delete = true;
        createpos.gameObject.SetActive(false);
    }
    //new Vector3(((0.77f + 2.27f) * Big_long.num / 100f) - 1.85f, 0f, -0.7f)
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.P))
        {
            btime += Time.deltaTime;
            if (btime > wait)
            {
                b_create();
             
                btime = 0;
                createpos.gameObject.SetActive(true);
            }
            
          
        }
        if (Input.GetKey(KeyCode.S))
        {
            //createpos.gameObject.SetActive(false);
            b_destroy();
        }
    }
}
