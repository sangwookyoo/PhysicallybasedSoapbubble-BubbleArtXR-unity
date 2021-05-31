using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanningMotion : MonoBehaviour
{

    public GameObject go;
    RaycastHit[] hit1;
    float MaxDis = 0.2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(go.GetComponent<Rigidbody>().velocity.magnitude);
        Debug.DrawRay(transform.position, -transform.forward * MaxDis, Color.blue, 0.01f);
        hit1 = Physics.RaycastAll(transform.position, -transform.forward, MaxDis);
        
            if (go.GetComponent<Rigidbody>().velocity.magnitude >= 0.8f)
            {
                gameObject.GetComponent<BoxCollider>().enabled = true;
                Debug.Log("Fanning Motion is Detected");
               
               
            }
            else if (go.GetComponent<Rigidbody>().velocity.magnitude < 0.8f)
            {
                gameObject.GetComponent<BoxCollider>().enabled = false;
                //Debug.Log("Fanning Motion is UnDetected");
            }
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bubble")
        {
            other.GetComponent<SphereCollider>().isTrigger = false;
            
        }
    }
}