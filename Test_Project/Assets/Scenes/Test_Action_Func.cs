using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Test_Action_Func : MonoBehaviour
{
    // void�� ��� Action ���
    delegate void MyDelegate<T1, T2>(T1 a, T2 b);
    MyDelegate<int, int> myDelegate;

    // System�� �̸� ���ǵǾ� �ֱ� ������ ���� ���� �ۼ����� �ʾƵ� ��
    Action<int, int> myDelegate2;

    Func<int, int, string> myDelegate3;

    // Start is called before the first frame update
    void Start()
    {
        myDelegate2 = (int x, int y) => print( x + y);
        myDelegate2(1, 5);

        myDelegate3 = (int a, int b) => { int sum = a + b; return sum + "�� ����"; };
        myDelegate3(3, 5);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
