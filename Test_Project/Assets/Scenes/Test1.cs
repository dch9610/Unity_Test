using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// class명과 스크립트 파일명이 일치해야함
// class는 그릇이라고 생각하면 됨
public class Test1 : MonoBehaviour
{
    // 변수 선언
    // integer 정수 자료형 (-20억 + 20억) - 4바이트
    // short 정수 자료형 (-30,000 ~ 30,000) - 2바이트
    // long 정수 자료형 - 8바이트
    // sbyte 정수 자료형 (-128 ~ 128) - 1바이트
    // byte 정수 자료형 (0 ~ 255) - 1바이트
    int x = 100;
    int y = 100;
    


    // 오차 정도 (float > double > decimal)
    // float 실수 자료형 (뒤에 f를 써줘야함) 오차의 정도로 나눔 
    // double 실수 자료형 
    // decimal 실수 자료형 (뒤에 m을 써줘야함)

    // 문자 자료형
    // string 문자 자료형 (문자열 저장가능 "")
    // char 문자 자료형 (한글자만 저장 '')
    string s = "asaskdwokd";
    


    int a = 100;
    float b = 100.14f;
    string c;
    string d = "10990";
    int e;

    float sum;

    // short (-3만 ~ 3만) ushort는 음수 값이 없음
   
    // bool (True, False의 값만 가짐)


    // Start is called before the first frame update
    void Start()
    {
        sum = a + b;
        c = a.ToString(); // int -> string으로 변환
        e = int.Parse(d); // string -> int로 변환
        print(e);
        print(sum);
        print(c);
        print(-sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
