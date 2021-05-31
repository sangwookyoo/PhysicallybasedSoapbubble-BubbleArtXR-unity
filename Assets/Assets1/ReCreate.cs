using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ReCreate : MonoBehaviour
{
    // Start is called before the first frame update
    public SkinnedMeshRenderer skinnedMeshRenderer;
    private Material bubblemat;
    public Mesh cloneMesh;
    public Mesh mesh;
    void Start()
    {
        skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        bubblemat = skinnedMeshRenderer.material;
        skinnedMeshRenderer.material = bubblemat;

        cloneMesh = new Mesh();
        skinnedMeshRenderer.BakeMesh(cloneMesh);
        //cloneMesh = GetComponent<SkinnedMeshRenderer>().sharedMesh;
        //Debug.Log(cloneMesh.vertices[200]);
        GetComponent<MeshFilter>().mesh = mesh = new Mesh();


        mesh.vertices = cloneMesh.vertices;
        mesh.normals = cloneMesh.normals;
        mesh.triangles = cloneMesh.triangles;
        mesh.uv = cloneMesh.uv;
        gameObject.AddComponent<MeshRenderer>();
        gameObject.GetComponent<MeshRenderer>().material = bubblemat;
        Destroy(skinnedMeshRenderer);
        Destroy(GetComponent<Animator>());


        //MeshUtility.Optimize(mesh);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
