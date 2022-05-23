using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{

    public int Health = 100;
    public float speed;
    Rigidbody rigid;
    Vector3 dir;
    bool condition;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //if (Health <= 0)
        //{
        //    gameObject.SetActive(false);
        //}

        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space) && condition == true)
        {
            rigid.AddForce(new Vector3(0, 250, 0));
        }

    }

    private void FixedUpdate()
    {
        rigid.MovePosition(rigid.position + dir * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌");
    }

    private void OnCollisionStay(Collision collision)
    {
        condition = true;
        Debug.Log("충돌둥");
    }

    private void OnCollisionExit(Collision collision)
    {
        condition = false;
        Debug.Log("충돌 벗어남");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("감지");
        gameObject.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("감지중");
        //Health--;

    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("감지벗어남");
    }

}
