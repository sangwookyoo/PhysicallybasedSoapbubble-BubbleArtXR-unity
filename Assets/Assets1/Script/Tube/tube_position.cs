using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tube_position : MonoBehaviour
{
    public GameObject child_;
    public GameObject parent_;
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
        child_.transform.rotation = Quaternion.Euler(0, 270, 0);
        child_.transform.position = new Vector3(parent_.transform.position.x + 0.05f, parent_.transform.position.y-0.04f, parent_.transform.position.z -0.04f );
    }
}