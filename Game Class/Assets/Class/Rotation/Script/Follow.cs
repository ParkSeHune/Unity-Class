using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public GameObject Character;

    void Update()
    {
                              //�ڱ� �ڽ��� ��ġ, ĳ������ ��ġ > 10
        if (Vector3.Distance(transform.position, Character.transform.position) >= 5)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            //LookAt : ����� �ٶ󺸵��� �ϴ� �Լ�
            transform.LookAt(Character.transform);
        }

    }
}
