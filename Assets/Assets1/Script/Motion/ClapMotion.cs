using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClapMotion : MonoBehaviour {
	public GameObject leftHand;
	public GameObject rightHand;
	private float distance;
	private bool onClap;
	public GameObject bubble;
	public GameObject Camera;
	float randomX;
	float randomY;
	float Speed;
	GameObject bubble2;
	new Vector3 pos;
	
	void Start(){
		onClap = false;
		pos = new Vector3(Camera.transform.position.x, Camera.transform.position.y, Camera.transform.position.z + 0.5f);
		Speed = 0.0001f;
		Physics.gravity = new Vector3(0, -0.001F, 0);
	}

	void Update(){
		Physics.gravity = new Vector3(0, -0.001F, 0);
		randomX = Random.Range(-11.33f, -10.7f);
		randomY = Random.Range(3213.289f, 3213.468f);
		//BubbleMove();
		CheckDistance();

	}

	public void CheckDistance(){
		distance = Vector3.Distance (leftHand.transform.position, rightHand.transform.position);
		if (distance <= 0.04f && onClap==false) {
			Debug.Log ("박수");
			onClap = true;

			bubble2 = Instantiate(bubble, new Vector3(randomX, randomY, Camera.transform.position.z + 0.5f), Quaternion.identity) as GameObject;
			
			bubble2.gameObject.SetActive(true);
			
			//Destroy(bubble2, 10);
			
		} else if (distance > 0.04f && onClap == true) {
			onClap = false;
		}
	}
	
}