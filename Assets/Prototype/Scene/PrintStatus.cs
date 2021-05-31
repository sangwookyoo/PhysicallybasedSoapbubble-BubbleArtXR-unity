using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintStatus : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PrintingStatus(){
		Debug.Log ("물체를 잡았다.");
	}

	void OnCollisionEnter(Collision col){
		if(col.collider.name == "Contact Fingerbone")
			Debug.Log ("충돌!");
	}
}
