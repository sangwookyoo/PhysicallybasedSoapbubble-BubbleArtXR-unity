using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuidePageControl : MonoBehaviour {
	public GameObject menu;
	public GameObject mainButton;

	public void ActiveMenu (){
		menu.gameObject.SetActive (true);
		mainButton.gameObject.SetActive (false);
		Debug.Log ("Menu Open");
	}
	public void DeactiveMenu(){
			menu.gameObject.SetActive(false);
		mainButton.gameObject.SetActive (true);
			Debug.Log("Menu Close");
	}
}
