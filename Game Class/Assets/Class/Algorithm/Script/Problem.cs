using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Problem : MonoBehaviour
{
    public Text answer;

    string value = "���׼� �Դϴ�.";

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

    //���׼� �˰���
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
            value = "���׼��Դϴ�.";
        }
        else
        {
            value = "���׼��� �ƴմϴ�.";
        }

        answer.text = value;
    }
    */
}
