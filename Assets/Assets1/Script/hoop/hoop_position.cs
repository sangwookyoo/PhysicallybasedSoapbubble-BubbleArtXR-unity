using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoop_position : MonoBehaviour
{
    public GameObject parent_;
    public GameObject child_;
    float count;
    // Start is called before the first frame update
    private void Awake()
    {
        position();
    }
    void Start()
    {
        child_.SetActive(false);
    }

    // Update is called once per frame
    void position()
    {
        
        child_.transform.rotation = Quaternion.Euler(90,90,0);
        child_.transform.position = new Vector3(parent_.transform.position.x + 0.15f, parent_.transform.position.y-0.03f, parent_.transform.position.z - 0.03f);
    }
}
