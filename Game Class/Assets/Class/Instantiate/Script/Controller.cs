using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(x, 0, z);

        transform.Translate(dir.normalized * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += new Vector3
                (
                transform.position.x,
                3,
                transform.position.z
                );
        }
    }

}
