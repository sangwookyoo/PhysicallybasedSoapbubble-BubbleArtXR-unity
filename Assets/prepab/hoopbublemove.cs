using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoopbublemove : MonoBehaviour
{
    public Transform target; // 따라갈 타겟의 트랜스 폼
    public float speed;
    public float relativeHeigth = 2f; // 높이 즉 y값
    public float zDistance = 2f;// z값 나는 사실 필요 없었다.
    public float xDistance = 2f; // x값
    public float dampSpeed = 2;  // 따라가는 속도 짧으면 타겟과 같이 움직인다
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 newPos = target.position + new Vector3(xDistance, relativeHeigth, -zDistance);
        // 타겟 포지선에 해당 위치를 더해.. 즉 타겟 주변에 위치할 위치를 담는다.. 일정의 거리를 구하는 방법
        transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * dampSpeed);
        //그 둘 사이의 값을 더해 보정한다. 이렇게 되면 멀어지면 따라간다.
    }
}
