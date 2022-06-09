using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public GameObject Character;

    void Update()
    {
                              //자기 자신의 위치, 캐릭터의 위치 > 10
        if (Vector3.Distance(transform.position, Character.transform.position) >= 5)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            //LookAt : 대상을 바라보도록 하는 함수
            transform.LookAt(Character.transform);
        }

    }
}
