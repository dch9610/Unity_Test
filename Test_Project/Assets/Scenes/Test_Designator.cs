using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// cs 파일명이랑 클래스명이 같아야함
public class Test_Designator : MonoBehaviour
{

    int a = 5; // 멤버 변수, 전역 변수

    void Abc1()
    {
        // 함수가 실행됬을때만 존재함
        int a = 5;
        a = 6; // 지역변수 값으로 지정 (지역변수가 우선순위가 높음)

        int b = 5; //지역변수
        print(b);
    }

    void Abc2(float _parameter)
    {

    }

    // 접근 지정자
    // private : 해당 클래스에서만 변수를 접근



    // 다른 클래스 호출함
    Test2 a1 = new Test2();
    Test2 a2 = new Test2();
    Test2 a3 = new Test2();
  
    void Abc3()
    {
        // aaa.d = 5; // 사용 불가 (private)
        a1.e = 5; // 사용 가능 (public)
        a2.e = 15; // 사용 가능 (public)
        a3.e = 25; // 사용 가능 (public)

        Test2.f = 100;

        print(a1.e);
        print(a2.e);
        print(a3.e);
        print(Test2.f);
    }

    // Start is called before the first frame update
    void Start()
    {
        Abc3();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class Test2
{
    private int d;
    public int e;
    public static int f; //공유자원, 정적변수 

    // 함수도 동일하게 적용
    public void Abc4()
    {

    }

    // 
    private void Abc5()
    {

    }

}