using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Problem : MonoBehaviour
{
    public Text answer;
    public string input;
    public bool condition;
    public int[] array;

    //���α׷��ӽ� 1�ܰ�

    //�Ϻ��� ���ڿ� �Ǻ��ϱ�
    /*
    //1. ���ڿ��� �Է��մϴ�.
    //���ڰ� ���� "������ ���ڿ��� �ƴմϴ�."
    //���ڿ��� ���� "������ ���ڿ� �Դϴ�."

    public Text answer;
    public string input;
    public bool condition;


    public void Update()
    {

        if (answer.text.Length != 0) return;

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 48; j < 58; j++)
            {
                if (input[i] == (char)j)
                {
                    condition = true;
                }
            }
        }

        if (condition == false)
        {
            answer.text = "�Ϻ��� ���ڿ� �Դϴ�.";
        }
        else
        {
            answer.text = "�Ϻ��� ���ڿ��� �ƴմϴ�.";
        }
    }
     
    */

    //�ߺ����� �ʴ� ���� ��
    /*
    
    
    //1 ~ 6 ���� ������ ����
    //�迭 ���·� �� ����
    //�迭�� ���� 5�� ����

    public Text answer;
    public string input;
    public int[] array;

    private void Start()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(1, 6);

            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    i--;
                }
            }
        }

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

    
    }
    */


    //���׼� �˰���
    /*
     
    public Text answer;

    string value = "���׼� �Դϴ�.";

    public int variable = 20;
    public int result = 0;
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
