using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Lambda : MonoBehaviour
{

    int a = 5;
    int b = 6;

    int sum;

    // Add를 실행하면 무조건 Back이 실행되므로 종속성 문제
    // 이를 해결하기 위해 델리게이트를 사용
    void Add()
    {
        sum = a + b;
        
    }

    void Back()
    {
        sum = 0;
    }

    //delegate void MyDelegate();
    //MyDelegate myDelegate;

    // 형식 매개변수 사용
    delegate void MyDelegate<T>(T a, T b);
    MyDelegate<int> myDelegate;

    // Start is called before the first frame update
    void Start()
    {
        //myDelegate = Add;

        //// 무명 메서드 (델리게이트에서만 호출가능)
        //myDelegate += delegate () { print(sum); };

        //// 람다식 (int a) => return a; : 매개변수 a를 받고, 그 a를 반환하는 람다식
        //myDelegate += () => print(sum);

        //myDelegate += Back;

        // 형식 매개변수를 사용한 delegate 이용
        myDelegate += (int a, int b) => print(a + b);



        myDelegate(3,5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
