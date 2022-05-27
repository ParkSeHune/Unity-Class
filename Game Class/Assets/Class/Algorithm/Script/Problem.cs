using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Problem : MonoBehaviour
{
    public Text answer;

    string value = "과잉수 입니다.";

    public int variable = 20;
    public int result = 0;
    
    /*
    private void Start()
    {
        for (int i = 0; i < variable.Length / 2; i++)
        {
            if (variablepi == varible[variable.Lenth - 1 - i])
            {

            }
        }
    }
    */

    //과잉수 알고리즘
    /*
    private void Start()
    {
        for (int i = 1; i < variable; i++)
        {
            if (variable % i == 0)
            {
                result += i;
            }
        }

        if (result > variable)
        {
            value = "과잉수입니다.";
        }
        else
        {
            value = "과잉수가 아닙니다.";
        }

        answer.text = value;
    }
    */
}
