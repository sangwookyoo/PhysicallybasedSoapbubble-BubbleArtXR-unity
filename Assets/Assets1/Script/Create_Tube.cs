using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Tube : MonoBehaviour
{
    public GameObject bubble;
    public GameObject bubble2;
    public static bool check;
    public GameObject createpos;
    public bool create;
    private int count = 0;
    private float btime = 0f;
    private float wait = 1f;
    // Start is called before the first frame update
    void Start()
    {
        check = true;
        count = 0;
        create = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            btime += Time.deltaTime;
            if (create == true)
            {
                bubble2 = Instantiate(bubble, createpos.transform.position, createpos.transform.rotation) as GameObject;
                Destroy(bubble2, 5);
                create = false;
                if (btime > wait)
                {
                    bubble2 = Instantiate(bubble, createpos.transform.position, createpos.transform.rotation) as GameObject;
                    Destroy(bubble2, 5);
                    btime = 0;

                }
            }
            else if (create == false)
            {
                if (btime > wait)
                {
                    bubble2 = Instantiate(bubble, createpos.transform.position, createpos.transform.rotation) as GameObject;
                    Destroy(bubble2, 5);
                    btime = 0;

                }
            }

        }

    }
}
