using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut_Bubble : MonoBehaviour
{
    public Material capMaterial;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] gameObjects = Cut_Mesh.Cut(gameObject, transform.position, Vector3.down, capMaterial);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
