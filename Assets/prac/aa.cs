using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Leap;

public class aa : MonoBehaviour {
 Controller m_controller;

 // 오브젝트 및 카메라 변수 생성
 GameObject m_objModel;
 GameObject m_objCamera;

 // 카메라 줌과 오브젝트 회전 벡터 변수 생성 
 Vector3 m_vCameraZoom;
 Vector3 m_vModelRotation;
 Vector3 m_vModelTranslate;
 // Use this for initialization
 void Start () {
  // 컨트롤러 초기화
  m_controller = new Controller();

  // 오브젝트 변수 초기화
  m_objModel = GameObject.Find("클론입니다");
  m_objCamera = GameObject.Find("Main Camera");
  // 카메라 줌과 오브젝트 회전 벡터 변수 초기화 
  //m_vCameraZoom = new Vector3(0,0,0);
 // m_vModelRotation = new Vector3(0,0,0);
 }
 
 // Update is called once per frame
 void Update () {
        if (m_objModel != null)
        {
            Debug.Log ("오브젝트가 있습니다.");
        }
      
  // 현재 및 이전 프레임 로드
  Frame fCurFrame = m_controller.Frame();
  Frame fPreFrame = m_controller.Frame(1);

  // 현재 및 이전 프레임에 들어오는 첫번째 손 찾기
  Hand hCurHand = fCurFrame.Hands [0];
  Hand hPreHand = fPreFrame.Hands [0];

  //손의 손가락 찾기


  // 회전 및 줌 정도
        m_vModelRotation.x = hPreHand.PalmPosition.y - hCurHand.PalmPosition.y;
        m_vModelRotation.y = hPreHand.PalmPosition.x - hCurHand.PalmPosition.x;
        //m_vCameraZoom.z = (hPreHand.PalmPosition.z - hCurHand.PalmPosition.z)/20;

        // 좌우 움직임 및 줌 정도
        m_vModelTranslate.y = hCurHand.PalmPosition.y - hPreHand.PalmPosition.y;
        m_vModelTranslate.x = hCurHand.PalmPosition.x - hPreHand.PalmPosition.x;
        // m_vModelRotation.z = hPreHand.PalmPosition.z - hCurHand.PalmPosition.z;
        //m_vCameraZoom.z = (hPreHand.PalmPosition.z - hCurHand.PalmPosition.z)/20;


        // 오브젝트 컨트롤
        m_objModel.transform.Translate(m_vModelTranslate / 100, Space.World);
        
        m_objModel.transform.Rotate(m_vModelRotation, Space.World);

  if(m_objModel.transform.position.z > 10)
  {
   m_objCamera.transform.position = new Vector3(0,0,9);
  }
  else if(m_objModel.transform.position.z < -10)
  {
   m_objCamera.transform.position = new Vector3(0,0,-9);
  }
  else
  {
   m_objCamera.transform.Translate(m_vCameraZoom, Space.World);
  }
 }
}