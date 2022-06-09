using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControlA : MonoBehaviour
{
    public float speed = 1.0f;
    public float mouseSpeed = 100.0f;
    float mX = 0.0f;
    float mY = 0.0f;

    CharacterController characterController;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(x, 0, z);

        characterController.Move(direction.normalized * speed * Time.deltaTime);

        transform.Rotate(0f, Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime, 0, Space.World);

        ////ȸ�� �� ������ ���콺 �Է� ����ŭ �̸� ������Ų��
        //float mouseX = Input.GetAxis("Mouse X");
        //float mouseY = Input.GetAxis("Mouse Y");
        //
        //mX += mouseX * mouseSpeed * Time.deltaTime;
        //mY += mouseY * mouseSpeed * Time.deltaTime;
        //
        ////ȸ�� �������� ��ü�� ȸ����Ų��
        //// r = r0 + vt
        //
        //transform.eulerAngles = new Vector3(-mY, mX, 0);
    }
}
