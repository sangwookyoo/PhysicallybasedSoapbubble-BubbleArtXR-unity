using UnityEngine;

public class SplineWalker : MonoBehaviour {

    //

    private float p = 0.00125f;//공기 밀도
  //  public float v = 1f;//비눗방울의 속도
    private float c = 0.47f;//공기저항계수
    private float r = 4.4f; //반지름
    private float g = 9.8f;//중력가속도
    public GameObject sphere;
    public GameObject straw;
    //

       
    public BezierSpline[] spline = new BezierSpline[]{};

    
    //public GameObject upspline;
    //public GameObject downspline;

    //private BezierSpline[] spline;

    private float duration=0.5f;

	public bool lookForward;
   
	public SplineWalkerMode mode;

    public int range_end=0;

	public float progress=0;
    private float progress_2 = 0;
	private bool goingForward = true;
    public int ran;
    public Vector3 position;
    private bool IsStop = false;
    private float scale = 0f;
    private GameObject obj;
    private int ranRL = 0;
    private void Start()
    {
        scale = Random.Range(10, 20);

        spline = (BezierSpline[])FindObjectsOfType(typeof(BezierSpline));
        //Debug.Log("GUITexture object found: " + spline);
        obj = gameObject;
        Vector3 euler = straw.transform.rotation.eulerAngles;
        range_end = spline.Length;
        //Debug.Log(range_end);
        ran = Random.Range(0, 10000)%(range_end - 1);
        ranRL = Random.Range(1, 12);    
        spline[ran].transform.position = sphere.transform.position;
        //spline[ran].transform.Rotate(0,0,euler.z+scale,Space.Self);
        scale = scale /10f;

        spline[ran].transform.localScale = new Vector3(scale,scale,scale);
        
    }
    private void FixedUpdate () { 
        
        float V = 4 / 3 * (Mathf.PI * r * r * r);//비눗방울의 부피
        //Debug.Log("V:"+V);
        float M = p * V; //비눗방울의 질량
        //Debug.Log("M:"+M);
        float A = 2 * Mathf.PI * r * r;//비눗방울의 단면적
        //Debug.Log("A:"+A);
        float D = c * A * duration * duration / (2 * M);//비눗방울의ewrw 공기저항가속도
        float sin = Mathf.Sin(spline[ran].GetDirection(progress).x);
        float acel = M * g *sin ;
        if (acel == 0)
            Destroy(obj);

        if (goingForward) {
			progress += Time.deltaTime * duration;
			if (progress > 1f) {
               // Debug.Log(progress);
                Destroy(obj);

            }
            else if(progress < 0f)
            {
                Debug.Log(progress);
                Destroy(obj);
            }
        }
        else {
			progress -= Time.deltaTime / duration;
			if (progress < 0f)
            {
                Debug.Log(progress);
                Destroy(obj);
            }
		}
     if (IsStop == false)
        {
            position = spline[ran].GetPoint(progress);
           transform.position = position;
            if (progress == 1f)
                IsStop = true;
        }
        if (ranRL < 2)
        {
           // Vector3 PS = new Vector3(0, 0, duration*ranRL*2 * Time.deltaTime);
           // spline[ran].transform.position += PS*2;
           // Debug.Log(spline[ran].transform.position);
        }
         else if (ranRL>10&&ranRL < 12)
        {
           // Vector3 PS = new Vector3(0, 0, duration*ranRL * Time.deltaTime);
           // spline[ran].transform.position -= PS*2;
        }
        if (lookForward) {
            
            
            //transform.LookAt(position + spline[ran].GetDirection(progress));
		}
         if(progress ==1f)
        {
            
            //Destroy(obj);
           // Vector3 position_2 = spline[ran].GetPoint(progress) - spline[ran].GetPoint(progress_2);
           // position += position_2;
            //Debug.Log(position.x);
            //Debug.Log(goingForward);
            //gravity -= 9.8f * Time.deltaTime/10;
           //position.y += gravity + D - acel;
           // transform.position = position;
            


        }
        duration = duration - (D / 1000) + (acel / 10000);
    }
}
