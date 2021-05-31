using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isActiveVuforia : MonoBehaviour {
	[Header("For Checking AR Object's Activation")]
	public Collider col;
	private bool onOff=false;
	public GameObject canvas;
	//[Header("Referenced script for Scanning test")]
	//[Tooltip("It's in the 'Main Camera' Object.")]

	void Start(){
		col = gameObject.GetComponent<Collider> ();
	}
	void Update(){
		if (col.enabled&&onOff==false) {
			onOff = true;
			canvas.SetActive (true);
		} 
		else if(!col.enabled){
			onOff = false;
			canvas.SetActive (false);
		}
	}
}