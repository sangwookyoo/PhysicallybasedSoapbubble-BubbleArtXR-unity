using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolButtonManager : MonoBehaviour {
	//[Header("인스펙터 뷰에서 단락 나누기")]

	// public variable
	[Header("GameObject For Bubble Tool")]
	[Tooltip("사용될 버블 아트 도구 게임 오브젝트를 할당하는 공간")]
	public GameObject bubbleArtTool;
	[Tooltip("Bubble Art Tool 게임 오브젝트의 이름을 저장하는 변수. 자동 할당되므로, 수정 금지")]
	public string toolName;

	// private variable
	private Transform spwanSpot;
	private GameObject previousTool;
	private GameObject initedTool;

	void Awake () {
		spwanSpot = GameObject.Find ("SpawnSpot").transform;
		toolName = bubbleArtTool.name;
	}


	public void Setting(){
		if (spwanSpot == null) {							// 1. SpwanSpot가 없을 경우
			Debug.LogError ("Spwan spot is Null.");
		}
		else {												// 2. SpwanSpot의 있을 경우
			if (GameObject.FindWithTag ("Tool") == null) {	// 2-1. Tool tag를 가진 게임 오브젝트가 없는 경우
				
				// spwanSpot 위치에 도구 생성 및 (clone)을 삭제하기 위해 네이밍.
				initedTool = (GameObject) Instantiate (bubbleArtTool, spwanSpot.position, spwanSpot.rotation);
				initedTool.name = toolName;
			}
			else {											// 2-2. Tool tag를 가진 게임 오브젝트가 있는 경우
				previousTool = GameObject.FindWithTag ("Tool");
				Debug.Log ("PreviousTool is " + previousTool.name);

				if (previousTool.name.Equals (toolName)) {	// 2-2-1. Previous Tool = 지금 선택한 도구인 경우
					Debug.Log ("You selected same tool");
				}
				else {										// 2-2-2. Previous Tool != 지금 선택한 도구인 경우

					// 이전에 사용한 도구 제거 및 spwanSpot 위치에 도구 생성 및 (clone)을 삭제하기 위해 네이밍.
					Destroy (previousTool);
					initedTool = (GameObject) Instantiate (bubbleArtTool, spwanSpot.position, spwanSpot.rotation);
					initedTool.name = toolName;
				}
			}

		}

	}

}
