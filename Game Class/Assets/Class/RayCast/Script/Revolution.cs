using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    public GameObject origin;
    public float speed;

    void Update()
    {
        transform.RotateAround(origin.transform.position, Vector3.down, speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            speed += 10;
        }

        if (speed >= 500)
        {
            speed = 10;
        }
    }


}
