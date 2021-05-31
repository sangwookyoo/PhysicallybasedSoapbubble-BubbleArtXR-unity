using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class ChangeVertices : MonoBehaviour
{


    private Mesh mesh;
    public Mesh originalmesh;
    private Vector3[] vertices;
    private Vector3[] normals;
    private int[] triangles;
    private Vector2[] uv;
   // public GameObject bubble;

    private void Awake()
    {
        Generate();
    }

    public void Generate()
    {

        originalmesh = GetComponent<MeshFilter>().mesh;
        //originalmesh = morph.GetComponent<MeshFilter>().mesh;
       
        Destroy(this);
        Debug.Log("destroy");

        GetComponent<MeshFilter>().mesh = mesh = new Mesh();
     
        mesh.name = "Procedural Sphere";
        CreateVertices();

        // CreateColliders();
    }

    private void CreateVertices()
    {
 
        vertices = originalmesh.vertices;
        normals = originalmesh.normals;
        triangles = originalmesh.triangles;
        uv = originalmesh.uv;
        //originalmesh.Clear();

       

        mesh.vertices = vertices;
        mesh.normals = normals;
 
        mesh.triangles = triangles;
        mesh.uv = uv;
    }

    private void CreateColliders()
    {
        gameObject.AddComponent<SphereCollider>();
    }

}