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

    //프로그래머스 1단계

    //완벽한 문자열 판별하기
    /*
    //1. 문자열을 입력합니다.
    //숫자가 들어가면 "완전한 문자열이 아닙니다."
    //문자열만 들어가면 "완전한 문자열 입니다."

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
            answer.text = "완벽한 문자열 입니다.";
        }
        else
        {
            answer.text = "완벽한 문자열이 아닙니다.";
        }
    }
     
    */

    //중복되지 않는 랜덤 값
    /*
    
    
    //1 ~ 6 랜덤 난수값 생성
    //배열 형태로 값 저장
    //배열의 값이 5로 설정

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


    //과잉수 알고리즘
    /*
     
    public Text answer;

    string value = "과잉수 입니다.";

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
