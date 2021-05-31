using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigcreatepos : MonoBehaviour
{
    public Transform obj1;
    public Transform obj2;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = transform.forward;
        //obj2.position = obj1.position;
        obj2.rotation = Quaternion.Euler(new Vector3(obj1.rotation.x+90, obj1.rotation.y, obj1.rotation.z+90));
        //Quaternion rotation = Quaternion.identity;
        //rotation.eulerAngles = new Vector3(obj1.rotation.x, obj1.rotation.y, obj1.rotation.z);
        //obj2.rotation = Quaternion.Euler(rotation.x, rotation.y,rotation.z);
       
    }
}
