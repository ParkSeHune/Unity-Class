using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake �Լ��Դϴ�.");       
    }

    // Start is called before the first frame update
    void Start()
    {
        //�̸�, ���� ����, ���ʸ��� �ݺ�
        InvokeRepeating("AutoMove", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CancelInvoke("AutoMove");
        }
    }
    public void AutoMove()
    {
        transform.position = new Vector3
            (
            Random.Range(0, 5),
            0,
            Random.Range(0, 5)
            );

        Debug.Log("�����մϴ�.");
    }

}
