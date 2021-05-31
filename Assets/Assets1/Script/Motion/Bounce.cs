using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public ParticleSystem ParticleLauncher;
    public GameObject go;
    public Rigidbody rb;
    private float distance;
    public bool isBounce = false;
    float BounceCase;
    // Start is called before the first frame update
    void Start()
    {
        go = GameObject.Find("rightpalm");
        go.GetComponent<Rigidbody>();
        rb = gameObject.GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, go.transform.position);
        //Debug.Log(distance);
        //Debug.Log(go.GetComponent<Rigidbody>().velocity.magnitude);
        if (distance <= 0.07f && go.GetComponent<Rigidbody>().velocity.magnitude < 0.1f)
        {
            isBounce = true;
            GetComponent<SphereCollider>().isTrigger = false;
        }
        else if (distance <= 0.07f && go.GetComponent<Rigidbody>().velocity.magnitude > 0.1f)
        {
            BounceCase = Random.Range(0, 2);

            if (BounceCase == 0)
            {
                isBounce = true;
            }
            else if (BounceCase == 1)
            {
                ParticleLauncher.Play();
                ParticleLauncher.transform.parent = null;
                //Destroy(gameObject);
                gameObject.SetActive(false);
            }
        }
        if (isBounce == true)
        {
            transform.Translate(Vector3.Reflect((transform.position - go.transform.position), transform.forward) * Time.deltaTime * 1.1f);
            // transform.Translate(Vector3.up * Time.deltaTime * 0.1f);
            Debug.Log("Bounce success;");
        }
        if (distance > 0.14f && isBounce == true)
        {
            isBounce = false;
            GetComponent<SphereCollider>().isTrigger = true;
            // rb.useGravity = true;
            //Physics.gravity = new Vector3(0, -0.5f, 0);
        }

    }
}
