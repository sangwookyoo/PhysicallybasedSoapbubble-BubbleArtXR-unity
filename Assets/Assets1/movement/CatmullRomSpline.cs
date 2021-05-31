using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatmullRomSpline : MonoBehaviour
{

    public Transform[] controlPointsList;

    public bool isLooping = false;


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;

        for(int i=0;i<controlPointsList.Length;i++)
        {
            if((i==0||i==controlPointsList.Length-2||i==controlPointsList.Length-1)&&!isLooping)
            {
                continue;
            }

            DisplayCatmullRomSpline(i);
        }
    }
    void DisplayCatmullRomSpline(int pos)
    {
        Vector3 p0 = controlPointsList[ClampListPos(pos - 1)].position;
        Vector3 p1 = controlPointsList[pos].position;
        Vector3 p2 = controlPointsList[ClampListPos(pos + 1)].position;
        Vector3 p3 = controlPointsList[ClampListPos(pos + 2)].position;

        Vector3 lastPos = p1;

        float resolution = 0.2f;

        int loops = Mathf.FloorToInt(1f / resolution);

        for(int i=1;i<=loops;i++)
        {
            float t = i * resolution;

            Vector3 newPos = GetCatmullRomPosition(t, p0, p1, p2, p3);

            Gizmos.DrawLine(lastPos, newPos);

            lastPos = newPos;
        }
    }
    int ClampListPos(int pos)
    {
        if(pos<0)
        {
            pos = controlPointsList.Length - 1;

        }
        if(pos>controlPointsList.Length)
        {
            pos = 1;
        }
        else if(pos> controlPointsList.Length -1)
        {
            pos = 0;
        }
        return pos;
    }
    Vector3 GetCatmullRomPosition(float t,Vector3 p0,Vector3 p1, Vector3 p2,Vector3 p3)
    {
        Vector3 a = 2f * p1;
        Vector3 b = p2 - p0;
        Vector3 c = 2f * p0 - 5f * p1 + 4f * p2 - p3;
        Vector3 d = -p0 + 3f * p1 - 3f * p2 + p3;

        Vector3 pos = 0.5f * (a + (b * t) + (c * t * t) + (d * t * t * t));

        return pos;
    }
}
