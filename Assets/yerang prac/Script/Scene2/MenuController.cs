using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController: MonoBehaviour {
	[Header("GameObject for Tool menu")]
	public GameObject menu;							//부모 메뉴 (Empty)
	public GameObject Main;						//자식 메뉴 1
	public GameObject Tool;                        //자식 메뉴 
	public GameObject BackgroundMenu;               //배경 메뉴
	public GameObject ColorMenu;                    //컬러 메뉴
	public GameObject palm;

	//private float beforeAngle = 0f;					//1회차의 palm x방향 지역 각도
	private float nowAngleX = 0f;					//현재 palm의 x방향 지역 각도
	private float cumulativeAngleSum = 0f;			//누적 각도 합 값
	private float cumulativeAngle = 0f;				//평균각
	//private float beforeAngleX = 0f;
	private float firstAngleX = 0f;
	private int cumulativeCount = 0;				//MenuOpen 횟수 (누적 횟수)
	private float pauseTime = 0.3f;					//pause 시간 (너무 빨리 뜨면 콜라이더 충돌 문제 발생. 일부러 지연을 둠.)
	private float settingAngle = 0f;				//실제로 대입해줄 오일러 각 (지역각도값으로 계산한 각)

	public void ActiveMenu (){
		if (Main.gameObject.activeSelf == false && Tool.gameObject.activeSelf == false && BackgroundMenu.gameObject.activeSelf == false && ColorMenu.gameObject.activeSelf == false) {
			//StartCoroutine (PauseOneSec ());
			//Debug.Log("cumulativeAngle : "+cumulativeAngle);
			if (cumulativeCount == 0)
				firstAngleX = 180 - palm.transform.rotation.eulerAngles.x;
			nowAngleX = 180 - palm.transform.rotation.eulerAngles.x;
			//cumulativeAngleSum += nowAngleX;
			//Debug.Log ("firstAngle : "+firstAngleX);
			//Debug.Log ("nowAngle : "+nowAngleX);
			if (cumulativeCount == 1) {
				settingAngle = (firstAngleX + nowAngleX)/2;
				cumulativeAngle += settingAngle;
				//Debug.Log("settingAngle : "+settingAngle);
				menu.transform.rotation = Quaternion.Euler (settingAngle, 180-palm.transform.rotation.eulerAngles.y, -180+palm.transform.rotation.eulerAngles.z);	//각 변경
				//menu.transform.localEulerAngles = Quaternion.Euler(settingAngle, 0, 0);
			}

			if (cumulativeCount > 1) {
				//cumulativeAngle = cumulativeAngleSum / (cumulativeCount+1);
				Debug.Log("settingAngle : "+settingAngle);
				settingAngle = (nowAngleX + firstAngleX + cumulativeAngle)/(cumulativeCount+1);
				cumulativeAngle += settingAngle;
				//각도 변경 방법은 3가지가 있음.
				//menu.transform.Rotate (new Vector3(settingAngle, 0, 0));  //오일러 각 변경
				menu.transform.rotation = Quaternion.Euler (settingAngle, 180-palm.transform.rotation.eulerAngles.y, -180+palm.transform.rotation.eulerAngles.z);	//각 변경
				//menu.transform.rotation = Quaternion.AngleAxis(settingAngle,Vector3.right);	//쿼터니언 각 변경
			}
			cumulativeCount++;
			StartCoroutine (PauseTwoSec ());	//일시 정지 및 메뉴 띄우기
		} 
		else if (Main.gameObject.activeSelf == true|| Tool.gameObject.activeSelf == true || BackgroundMenu.gameObject.activeSelf == true || ColorMenu.gameObject.activeSelf == true) {
			Main.gameObject.SetActive(false);
			Tool.gameObject.SetActive(false);
			BackgroundMenu.gameObject.SetActive(false);
			ColorMenu.gameObject.SetActive(false);
		}
	}

	public void OpenSelect(){
		Main.gameObject.SetActive(false);
		Tool.gameObject.SetActive(true);
		BackgroundMenu.gameObject.SetActive(false);
		ColorMenu.gameObject.SetActive(false);
	}
    public void OpenMenu()
    {
		Main.gameObject.SetActive(true);
		Tool.gameObject.SetActive(false);
		BackgroundMenu.gameObject.SetActive(false);
		ColorMenu.gameObject.SetActive(false);
	}
	public void OpenBackgroundMenu()
	{
		Main.gameObject.SetActive(false);
		Tool.gameObject.SetActive(false);
		BackgroundMenu.gameObject.SetActive(true);
		ColorMenu.gameObject.SetActive(false);
	}
	public void OpenColorMenu()
	{
		Main.gameObject.SetActive(false);
		Tool.gameObject.SetActive(false);
		BackgroundMenu.gameObject.SetActive(false);
		ColorMenu.gameObject.SetActive(true);
	}
	public void CloseMenu(){
		Main.gameObject.SetActive(false);
		Tool.gameObject.SetActive(false);
		BackgroundMenu.gameObject.SetActive(false);
		ColorMenu.gameObject.SetActive(false);
	}
	public void Quit(){
		Application.Quit();
	}

	IEnumerator PauseTwoSec(){
		yield return new WaitForSeconds(pauseTime);
		Main.gameObject.SetActive(true);
	}
	IEnumerator PauseOneSec(){
		yield return new WaitForSeconds(pauseTime);
		//For Testing
		//Debug.Log("cumulativeAngle : "+cumulativeAngle);
		//Debug.Log("LeftHandFigure : " +LeftHandFigure.transform.rotation.eulerAngles.x);
		//Debug.Log ("palmAngle : " + palm.transform.rotation.eulerAngles.x); //절대각도
		//Debug.Log ("nowAngle : "+ (180 - palm.transform.rotation.eulerAngles.x)); //상대각도
	}

	//두 벡터 사이의 각도 구하기. (0° ~ 360°)
	public static float CalculateAngle(Vector3 from, Vector3 to)
	{    
		return Quaternion.FromToRotation(Vector3.up, to - from).eulerAngles.z;
	}
}
