using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake 함수입니다.");       
    }

    // Start is called before the first frame update
    void Start()
    {
        /*
        int x = 60;
        int y = 48;

        int result = 0;

        for (int i = 1; i <= x && i <= y; i++)
        {
            if (x % i == 0 && y % i == 0)
            {
                result = i;
            }
        }
        */

        //Debug.Log(result);
        Debug.Log("Start 함수입니다.");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update 함수입니다.");
    }
}
