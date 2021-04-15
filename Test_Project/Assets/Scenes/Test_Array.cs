using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Array : MonoBehaviour
{
    // 배열 선언 []
    // 변수의 집합체, 배열의 크기는 한번 고정되면 바꿀수 없음, 인덱스가 중요

    // 1차원 배열
    int[] exp = { 50, 100, 150, 200, 250, 300 };
    int[] array = new int[10]; // 배열의 크기만 지정

    // 2차원 배열
    int[,] array2 = { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 } };

    // 3차원 배열
    // 2차원 배열이 2개
    int[,,] array3 = { { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 } }, { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 } } };

    // Start is called before the first frame update
    void Start()
    {
        exp[5] = 500; // 값 변경 가능
        print(exp[5]);

        // exp[6] = 1000; // 추가는 불가능, 배열은 처음 크기를 잘 설정해야함

        print(exp.Length); // 배열 원소의 갯수를 나타냄
        
        for (int i=0; i<exp.Length; i++)
        {
            print(exp[i]);
        }

        print(array2[1, 3]); // 40 출력
        print(array2[0, 1]); // 2 출력

        print(array3[1, 1, 2]); // 30 출력
        print(array3[0, 0, 3]); // 4 출력

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
