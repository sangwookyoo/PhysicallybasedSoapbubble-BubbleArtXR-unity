using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// mainB 일때는 작은 빨대 진동을 위한 씬 전환
// mainV 일때는 진동 OFF를 위한 씬 전환
public class SceneChange : MonoBehaviour
{
    public void ChangeSecondScene()
    {
        SceneManager.LoadScene("main");
    }

    public void ChSenV()
    {
        SceneManager.LoadScene("mainVib");
    }

    public void ChSenS()
    {
        SceneManager.LoadScene("mainSmall");
    }

    public void ChSenB()
    {
        SceneManager.LoadScene("mainBig");
    }

    public void ChSenT()
    {
        SceneManager.LoadScene("mainTube");
    }
}
