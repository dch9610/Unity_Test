using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Lambda : MonoBehaviour
{

    int a = 5;
    int b = 6;

    int sum;

    // Add�� �����ϸ� ������ Back�� ����ǹǷ� ���Ӽ� ����
    // �̸� �ذ��ϱ� ���� ��������Ʈ�� ���
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

    // ���� �Ű����� ���
    delegate void MyDelegate<T>(T a, T b);
    MyDelegate<int> myDelegate;

    // Start is called before the first frame update
    void Start()
    {
        //myDelegate = Add;

        //// ���� �޼��� (��������Ʈ������ ȣ�Ⱑ��)
        //myDelegate += delegate () { print(sum); };

        //// ���ٽ� (int a) => return a; : �Ű����� a�� �ް�, �� a�� ��ȯ�ϴ� ���ٽ�
        //myDelegate += () => print(sum);

        //myDelegate += Back;

        // ���� �Ű������� ����� delegate �̿�
        myDelegate += (int a, int b) => print(a + b);



        myDelegate(3,5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
