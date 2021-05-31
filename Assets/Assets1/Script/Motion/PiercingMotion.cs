using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiercingMotion : MonoBehaviour {

	RaycastHit hit;
	float MaxDis = 0.02f;
	private GameObject test;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{


		Debug.DrawRay(transform.position, transform.forward * MaxDis, Color.blue, 0.1f);
		if (Physics.Raycast(transform.position, transform.forward, out hit, MaxDis))
		{
			if (hit.collider.gameObject.tag == "Bubble")
			{
				//hit.transform.GetComponent<MeshRenderer>().material.color = Color.red;
				Debug.Log("piercing secess");

				Destroy(hit.transform.gameObject);
			}
		}

	}
	/*
	[Header("Function Status")]
	public bool motionStatus;								// HandMotion 상태 확인 변수. Extended Finger Detector로 제어됨.

	private GameObject handObject;							// 해당 손의 Collider를 갖는 GameObject.
	private List<Transform> handColList;					// 해당 손의 모든 Collider GameObject. List로 받은 Raw Data.
	private Dictionary<string, Transform> fingerColDict;	// 해당 손의 Finger GameObjects. Dictionary<Key, Value> 모르면 공부할 것.
	private Transform palm;									// 해당 손의 Palm GameObject.
	private bool isRightHand;								// 우측 손, 좌측 손 판단 변수.

	public void OnPiercingMotion() {
		motionStatus = true;
		Debug.Log ("PiercingMotion is ready.");
		fingerColDict = GetInteractionHand ();
	}

	public void OffPiercingMotion() {
		motionStatus = false;
		Debug.Log ("PiercingMotion is unready.");
		handColList.Clear();
		fingerColDict.Clear();
	}

	Dictionary<string, Transform> GetInteractionHand() {

		fingerColDict = new Dictionary<string, Transform> ();
		handColList = new List<Transform> ();

		if(isRightHand == true)
		{
			handObject = GameObject.Find ("Right Interaction Hand Contact Bones");
			foreach (Transform child in handObject.transform) {
				handColList.Add (child);
			}
		}
		else
		{
			handObject = GameObject.Find ("Left Interaction Hand Contact Bones");
			foreach (Transform child in handObject.transform) {
				handColList.Add (child);
			}
		}

		int colArrayIdx = 0;

		foreach (Transform colObject in handColList) {
			int fingerColIdx = colArrayIdx % 3 + 1;
			if (colArrayIdx < 3) {											// Thumb's GameObjects
				fingerColDict.Add ("Thumb" + fingerColIdx, colObject);
			} else if (colArrayIdx >= 3 && colArrayIdx < 6) {				// Index's GameObjects
				fingerColDict.Add ("Index" + fingerColIdx, colObject);
			} else if (colArrayIdx >= 6 && colArrayIdx < 9) {				// Middle's GameObjects
				fingerColDict.Add ("Middle" + fingerColIdx, colObject);
			} else if (colArrayIdx >= 9 && colArrayIdx < 12) {				// Ring's GameObjects
				fingerColDict.Add ("Ring" + fingerColIdx, colObject);
			} else if (colArrayIdx >= 12 && colArrayIdx < 15) {				// Pinky's GameObjects
				fingerColDict.Add ("Pinky" + fingerColIdx, colObject);
			} else {
				palm = colObject;
			}
			colArrayIdx++;
		}

		return fingerColDict;
	}

	void Awake() {
		if(this.gameObject.name.Contains("Right"))
		{
			isRightHand = true;
			Debug.Log ("RHandObject is on.");
		}
		else if(this.gameObject.name.Contains("Right"))
		{
			isRightHand = false;
			Debug.Log ("LHandObject is on.");
		}
		else
		{
			Debug.LogError ("This GameObject is not HandGameObject");
		}
	}

	void Update() {
		if (isRightHand != null && motionStatus == true) {
			// 여기서부터 Finger Direction Detector과 응용해서 하면 될 듯.
			// On Activate에 boolean형 스위치 변수 넣고,
			// 이 스크립트에서 해당 boolean형 스위치가 true이고, Bubble과 거리가 n일때 버블 터트리기 하면
			// 원하는 motion이 구현될 것 같음.

		}
	}
	*/
}
