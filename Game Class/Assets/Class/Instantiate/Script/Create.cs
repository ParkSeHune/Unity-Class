using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{

    public GameObject obj;

    void Start()
    {
        for (int i = 1; i <= 3; i++)
        {
            Instantiate(obj, new Vector3(3 * i, 0, 0), Quaternion.identity);
        }

        // (생성할 게임 오브젝트, 위치, 회전)
        // Quaternion.identity == 회전값을 0, 0, 0으로 초기화하는 것을 의미
        // Instantiate(obj, new Vector3(0, 0, 0), Quaternion.identity);
    }

    void Update()
    {
        
    }
}
