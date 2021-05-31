using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCh2 : MonoBehaviour
{
    // mainB 일때는 작은 빨대 진동을 위한 씬 전환
    // mainV 일때는 진동 OFF를 위한 씬 전환
    public void ChSen()
    {
        SceneManager.LoadScene("mainS");
    }

}
