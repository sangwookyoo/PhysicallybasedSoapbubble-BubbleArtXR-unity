using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapMotion : MonoBehaviour
{
    public GameObject go;
    RaycastHit hit;
    float MaxDis = 0.05f;
    private GameObject test;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(go.GetComponent<Rigidbody>().velocity.magnitude);

        Debug.DrawRay(transform.position, transform.forward * MaxDis, Color.blue, 0.01f);
        if (Physics.Raycast(transform.position, transform.forward, out hit, MaxDis))
        {
            if(hit.collider.gameObject.tag == "Bubble" ) {
                //hit.transform.GetComponent<MeshRenderer>().material.color = Color.red;
                Debug.Log("성공");
               
                hit.transform.position = new Vector3(transform.position.x + 0.02f, transform.position.y, transform.position.z + 0.03f);
                hit.transform.parent = transform;
               
                hit.rigidbody.isKinematic = true;
            }
           // else if(go.GetComponent<Rigidbody>().velocity.magnitude > 0.5)
           // {
            //    hit.transform.parent = null;
            //}
        }

    }
    
}