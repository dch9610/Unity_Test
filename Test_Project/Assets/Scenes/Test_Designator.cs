using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// cs ���ϸ��̶� Ŭ�������� ���ƾ���
public class Test_Designator : MonoBehaviour
{

    int a = 5; // ��� ����, ���� ����

    void Abc1()
    {
        // �Լ��� ������������ ������
        int a = 5;
        a = 6; // �������� ������ ���� (���������� �켱������ ����)

        int b = 5; //��������
        print(b);
    }

    void Abc2(float _parameter)
    {

    }

    // ���� ������
    // private : �ش� Ŭ���������� ������ ����



    // �ٸ� Ŭ���� ȣ����
    Test2 a1 = new Test2();
    Test2 a2 = new Test2();
    Test2 a3 = new Test2();
  
    void Abc3()
    {
        // aaa.d = 5; // ��� �Ұ� (private)
        a1.e = 5; // ��� ���� (public)
        a2.e = 15; // ��� ���� (public)
        a3.e = 25; // ��� ���� (public)

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
    public static int f; //�����ڿ�, �������� 

    // �Լ��� �����ϰ� ����
    public void Abc4()
    {

    }

    // 
    private void Abc5()
    {

    }

}