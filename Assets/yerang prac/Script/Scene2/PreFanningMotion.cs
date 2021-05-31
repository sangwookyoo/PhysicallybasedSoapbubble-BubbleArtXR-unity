using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFanningMotion : MonoBehaviour {
	[Header("GameObject For Bubble Tool")]
	[Tooltip("속도가 특정 실수값 이상인지 검사 할 오젝트")]
	public GameObject go;
	private bool isAllExtended = false;
	private bool isFanning = false;

	public void Detected(){isAllExtended = true;}
	public void UnDetected(){isAllExtended = false;}

	public void CheckVelocity(){
		if (go.GetComponent<Rigidbody> ().velocity.magnitude >= 0.8f && isFanning == false) {
			Debug.Log ("Fanning Motion is Detected");
			isFanning = true;
			
		} else if (go.GetComponent<Rigidbody> ().velocity.magnitude < 0.8f && isFanning == true) {
			isFanning = false;
			
		}
	}

	void Update(){
		if(isAllExtended==true){
			CheckVelocity();
		}
	
	}
	
}