using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakingMotion : MonoBehaviour {
	[Header("GameObject For Bubble Tool")]
	[Tooltip("속도가 특정 실수값 이상인지 검사 할 오젝트")]
	public GameObject go;
	private bool isAllUnExtended = false;
	private bool isFanning = false;
	public GameObject tt1;
	public void Detected(){isAllUnExtended = true; Debug.Log("Rock Detected");}
	public void UnDetected(){isAllUnExtended = false; Debug.Log("Rock UnDetected");}

	public void CheckVelocity(){
		if (go.GetComponent<Rigidbody> ().velocity.magnitude >= 2f && isFanning == false) {
			Debug.Log ("Shacking Motion is Detected");
			isFanning = true;
		} else if (go.GetComponent<Rigidbody> ().velocity.magnitude < 2f && isFanning == true) {
			isFanning = false;
			Debug.Log("Shacking Motion is UnDetected");
		}
	}

	void Update(){
		if(isAllUnExtended==true){
			CheckVelocity();
		}
	}
}