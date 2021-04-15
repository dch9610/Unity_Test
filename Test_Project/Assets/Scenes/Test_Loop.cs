using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Loop : MonoBehaviour
{
    int num = 0;


    // Start is called before the first frame update
    void Start()
    {
        // (반복할 변수; 범위; 증가량;) 다 있을 필요는 없음 대신 ;는 있어야함
        // 반복횟수가 명확할때
        //for (int i=0; i<10; i+=2)
        //{
        //    num = i;
        //    print(num);
            
        //}

        //for( ; ; )
        //{
        //    num++;
        //    if (num%2 == 0)
        //        continue; // 해당 회차를 끝냄, 다음회차 시작
            
        //    print(num);

        //    if (num > 10)
        //        break; // 첫번째 반복문 탈출, 조건문 탈출
        //}


        // while (조건)
        // 반복횟수가 명확하지 않을때
        //while (num<10)
        //{
        //    num++;
        //    print(num);
        //}


        // do while
        // 1회차는 실행하고 나서 조건을 확인, 조건이 맞지 않는 경우 1회차만 실행하고 반복문 탈출
        //do
        //{
        //    num++;
        //    print(num);
        //}
        //while (num < 10);


        // foreach
        string text = "가나다라마바사";

        // text 데이터를 쪼개서 a라는 변수에 하나씩 담음
        foreach(char a in text)
        {
            print(a);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
