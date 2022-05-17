using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public GameObject target;
    private float spead = 1.0f;

    private MeshRenderer render;
    private void Start()
    {
        render = GetComponent<MeshRenderer>();
    }
   
    void Update()
    {
        transform.position = Vector3.MoveTowards
            (
                transform.position,
                target.transform.position,
                spead * Time.deltaTime
            );

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Invoke("Paint", 3);
        }
    }

   
    public void Paint()
    {
        //0 ~ 2
        int value = Random.Range(0, 3);

        switch (value)
        {
            case 0:
                render.material.color = Color.green;
                break;
            case 1:
                render.material.color = Color.red;
                break;
            case 2:
                render.material.color = Color.black;
                break;
        }
    }
}
