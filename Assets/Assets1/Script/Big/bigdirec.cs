using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class bigdirec : MonoBehaviour
{

    

    private float time = 0f;
    private float wait=1f;
    public Transform _target;

    public bool _touch = false;

    public float dampSpeed = 10;  // 따라가는 속도





    // Update is called once per frame

    void Update()
    {

        if (_touch == true) FollowTarget();

    }

    private void OnTriggerEnter(Collider col)

    {

        if (col.tag == "1")

        {







            _touch = true;

        }

    }





    void FollowTarget()

    {
        time += Time.deltaTime;
        // Gets a vector that points from the player's position to the target's.

        var heading = _target.position - this.transform.position;



        // 거리가 멀어지면 실행

        //if (heading.sqrMagnitude > 0.05)

        //{
            if (time > wait)
            {
                // Target is within range.

                transform.position = Vector3.Lerp(transform.position, _target.position, Time.deltaTime * dampSpeed);

                transform.LookAt(_target);
                time = 0;
            }
        //}

        // 방향을 봄
        //if (time >= wait)
        //{
            //transform.LookAt(_target);
            //time = 0;
        //}
    }

}
