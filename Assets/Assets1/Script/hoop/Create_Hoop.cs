using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Hoop : MonoBehaviour
{
    public GameObject bubble1;
    public Transform left;
    public Transform right;
    public GameObject hoop_model;
    public GameObject parent;

    private int count;
    //private int num;
    private float x, y, z;
    private GameObject project;
    Vector3 position;   //후프의 이동후 좌표
    Vector3 h_position1; // 후프의 이동전(비눗방울 생성) 좌표
    public static bool check;
    public void Destroy()
    {
        Destroy(project, 10);
    }
    public void CoordinateDifference() //좌표값들의 차이
    {
        x = hoop_model.transform.position.x - h_position1.x; //후프의 이동후 위치와 비눗방울이 생성된 위치의 차이
        y = hoop_model.transform.position.y - h_position1.y;
        z = hoop_model.transform.position.z - h_position1.z;
        //Debug.Log(Mathf.Abs(x));
        // Debug.Log(Mathf.Abs(y));
        // Debug.Log(Mathf.Abs(z));
    }
    public void L()  //왼쪽으로로 비눗방울이 생성
    {
        position = new Vector3(left.transform.position.x, left.transform.position.y, left.transform.position.z);
        project = Instantiate(bubble1, position, left.transform.rotation) as GameObject;
        h_position1 = position;
        //Debug.Log("비눗방울 생성 좌표 = " + h_position1.x + h_position1.y + h_position1.z);
        //Debug.Log("이동 후 좌표 = " + hoop_model.position.x + hoop_model.position.y + hoop_model.position.z);
    }
    public void R() //오른쪽으로 비눗방울이 생성
    {
        position = new Vector3(right.transform.position.x, right.transform.position.y, right.transform.position.z);
        project = Instantiate(bubble1, position, right.transform.rotation) as GameObject;
        h_position1 = position;
        //Debug.Log("좌표 = " + h_position1.x + h_position1.y + h_position1.z);
        // Debug.Log("이동 후 좌표 = " + hoop_model.position.x + hoop_model.position.y + hoop_model.position.z);
    }
    // Start is called before the first frame updateb trgu
    void Start()
    {
        check = true;
        count = 0;
        //num = 1;        
        //h_position1 = hoop_model.transform.position;  
    }
    void Update()
    {
        if (parent.GetComponent<Rigidbody>().velocity.magnitude >= 0.1f)
            Debug.Log(parent.GetComponent<Rigidbody>().velocity.magnitude);

        {
            if (check == true)
            {
                if (Mathf.Abs(x) > Mathf.Abs(y) && Mathf.Abs(x) > Mathf.Abs(z))
                {
                    if (hoop_model.transform.position.x > h_position1.x) //이전 비눗방울 생성위치보다 후프의 포지션이 크면 왼쪽으로 비눗방울 생성
                    {


                        R();

                        if (parent.GetComponent<Rigidbody>().velocity.magnitude >= 0.1f && parent.GetComponent<Rigidbody>().velocity.magnitude < 0.4f)
                        {
                            bubble1.transform.localScale = new Vector3(4f, 4f, 4f);
                        }
                        else if (parent.GetComponent<Rigidbody>().velocity.magnitude >= 0.4f && parent.GetComponent<Rigidbody>().velocity.magnitude < 0.8f)
                        {
                            bubble1.transform.localScale = new Vector3(4f, 4f, 5f);
                        }
                        else if (parent.GetComponent<Rigidbody>().velocity.magnitude >= 0.8f)
                        {
                            bubble1.transform.localScale = new Vector3(4f, 4f, 6f);
                        }

                        //CoordinateDifference();
                        Destroy();
                        count++;
                        check = false;

                    }
                    else
                    {
                        if (parent.GetComponent<Rigidbody>().velocity.magnitude >= 0.1f && parent.GetComponent<Rigidbody>().velocity.magnitude < 0.4f)
                        {
                            bubble1.transform.localScale = new Vector3(4f, 4f, 4f);
                        }
                        else if (parent.GetComponent<Rigidbody>().velocity.magnitude >= 0.4f && parent.GetComponent<Rigidbody>().velocity.magnitude < 0.8f)
                        {
                            bubble1.transform.localScale = new Vector3(4f, 4f, 5f);
                        }
                        else if (parent.GetComponent<Rigidbody>().velocity.magnitude >= 0.8f)
                        {
                            bubble1.transform.localScale = new Vector3(4f, 4f, 6f);
                        }
                        L();
                        Destroy();
                        count++;
                        check = false;
                    }
                }
                else if (Mathf.Abs(y) > Mathf.Abs(z) && Mathf.Abs(y) > Mathf.Abs(x))
                {
                    if (hoop_model.transform.position.y > h_position1.y)
                    {
                        L();
                        if (parent.GetComponent<Rigidbody>().velocity.magnitude >= 0.1f && parent.GetComponent<Rigidbody>().velocity.magnitude < 0.4f)
                        {
                            bubble1.transform.localScale = new Vector3(4f, 4f, 4f);
                        }
                        else if (parent.GetComponent<Rigidbody>().velocity.magnitude >= 0.4f && parent.GetComponent<Rigidbody>().velocity.magnitude < 0.8f)
                        {
                            bubble1.transform.localScale = new Vector3(4f, 4f, 5f);
                        }
                        else if (parent.GetComponent<Rigidbody>().velocity.magnitude >= 0.8f)
                        {
                            bubble1.transform.localScale = new Vector3(4f, 4f, 6f);
                        }
                        Destroy();
                        count++;
                        check = false;
                    }
                    else
                    {
                        R();
                        if (parent.GetComponent<Rigidbody>().velocity.magnitude >= 0.1f && parent.GetComponent<Rigidbody>().velocity.magnitude < 0.4f)
                        {
                            bubble1.transform.localScale = new Vector3(4f, 4f, 4f);
                        }
                        else if (parent.GetComponent<Rigidbody>().velocity.magnitude >= 0.4f && parent.GetComponent<Rigidbody>().velocity.magnitude < 0.8f)
                        {
                            bubble1.transform.localScale = new Vector3(4f, 4f, 5f);
                        }
                        else if (parent.GetComponent<Rigidbody>().velocity.magnitude >= 0.8f)
                        {
                            bubble1.transform.localScale = new Vector3(4f, 4f, 6f);
                        }
                        //CoordinateDifference();
                        Destroy();
                        count++;
                        check = false;
                    }
                }
                else
                {
                    if (hoop_model.transform.position.z > h_position1.z)
                    {
                        R();
                        if (parent.GetComponent<Rigidbody>().velocity.magnitude >= 0.1f && parent.GetComponent<Rigidbody>().velocity.magnitude < 0.4f)
                        {
                            bubble1.transform.localScale = new Vector3(4f, 4f, 4f);
                        }
                        else if (parent.GetComponent<Rigidbody>().velocity.magnitude >= 0.4f && parent.GetComponent<Rigidbody>().velocity.magnitude < 0.8f)
                        {
                            bubble1.transform.localScale = new Vector3(4f, 4f, 5f);
                        }
                        else if (parent.GetComponent<Rigidbody>().velocity.magnitude >= 0.8f)
                        {
                            bubble1.transform.localScale = new Vector3(4f, 4f, 6f);
                        }
                        //CoordinateDifference();
                        Destroy();
                        count++;
                        check = false;
                    }
                    else
                    {
                        L();
                        if (parent.GetComponent<Rigidbody>().velocity.magnitude >= 0.1f && parent.GetComponent<Rigidbody>().velocity.magnitude < 0.4f)
                        {
                            bubble1.transform.localScale = new Vector3(4f, 4f, 4f);
                        }
                        else if (parent.GetComponent<Rigidbody>().velocity.magnitude >= 0.4f && parent.GetComponent<Rigidbody>().velocity.magnitude < 0.8f)
                        {
                            bubble1.transform.localScale = new Vector3(4f, 4f, 5f);
                        }
                        else if (parent.GetComponent<Rigidbody>().velocity.magnitude >= 0.8f)
                        {
                            bubble1.transform.localScale = new Vector3(4f, 4f, 6f);
                        }
                        //CoordinateDifference();                   
                        count++;
                        check = false;
                    }
                }
                count++;
                check = false;
            }
        }
    }
}