using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Test_Action_Func : MonoBehaviour
{
    // void인 경우 Action 사용
    delegate void MyDelegate<T1, T2>(T1 a, T2 b);
    MyDelegate<int, int> myDelegate;

    // System에 미리 정의되어 있기 때문에 위와 같이 작성하지 않아도 됨
    Action<int, int> myDelegate2;

    Func<int, int, string> myDelegate3;

    // Start is called before the first frame update
    void Start()
    {
        myDelegate2 = (int x, int y) => print( x + y);
        myDelegate2(1, 5);

        myDelegate3 = (int a, int b) => { int sum = a + b; return sum + "이 리턴"; };
        myDelegate3(3, 5);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
