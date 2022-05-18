using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLerp : MonoBehaviour
{

    public GameObject point;
    public float speed;

    void Update()
    {
        transform.position = Vector3.Lerp
            (
                transform.position,
                point.transform.position,
                speed * Time.deltaTime
            );
    }
}
