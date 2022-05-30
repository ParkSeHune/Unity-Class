using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    public void SceneSetting(string name)
    {
        //씬 이동 함수
        //매개 변수로 씬의 이름을 문자열로 설정
        SceneManager.LoadScene(name);
    }
}
