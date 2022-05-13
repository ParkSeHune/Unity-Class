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
        Debug.Log("Start �Լ��Դϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);

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

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * Time.deltaTime;
        }
    }
}
