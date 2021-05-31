using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBubble : MonoBehaviour
{
    public GameObject bubble;
    public GameObject bubble2;
    public GameObject spline;
    public GameObject spline2;
    public static bool check;
    public float power;
    public float btime = 0f;
    public bool delete = true;
    public Transform create;
    public GameObject Long;
    private float wait = 0.07f;
    public GameObject bubble3;
    public GameObject spline3;

    public ParticleSystem particleLauncher;
    // Start is called before the first frame update
    void Start()
    {
        //check = true;
        power = 0.5f;
        
    }
    public void b_create()
    {
        spline2 = Instantiate(spline, create.transform.position, transform.rotation) as GameObject;
        bubble2 = Instantiate(bubble, create.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        Destroy(spline2, 20);
        Destroy(bubble2, 3);
        Instantiate(particleLauncher, bubble2.transform.position, Quaternion.identity);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            Long.gameObject.SetActive(true);
            
            btime += Time.deltaTime;
            if (btime > wait)
            {
                b_create();
                btime = 0;
                
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            Long.gameObject.SetActive(false);
            bubble3 = GameObject.Find("strow(Clone)");
            spline3 = GameObject.Find("SmallSpline(Clone)");
            Destroy(spline3);
            Destroy(bubble3);
        }
       
    }
}
