using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Operator : MonoBehaviour
{
    int a = 10;
    int b = 3;
    int c = 0;
    bool d = false;
    bool e;
    bool f;
    
    // �⺻������ +,-,*,/,%, = (���Կ�����)
    // ++, -- ���� ������ ����[�� ���� �ڵ� ����], ����[���ڵ� ���� �� ����]
    // ���� ������ ==, <=, >=, <, >, !=
    // ��Ʈ ������ &(and), |(or), ^(xor), ~(not)
        // 00001010
        // 00001100 &
        // 00001000 �� ����� ����

    // Start is called before the first frame update
    void Start()
    {
        //print(a + b);
        //print(a / b);
        //print(a % b); // ������ ��

        //a = a + b; // ���� ������
        //a += b; // ���� ���� ������
        //print(a);

        //// ������ 1�� ������
        //print(c++); // 0�� ��µ� ���� c�ǰ��� ����� 1�� ������
        //print(++c); // +1�� �Ȱ��� ���

        d = (a >= b); // ���迬����
        e = (a != b) && (a==b); // �� ������ && (and), || (or)
        f = !(a == b); // �������� ! (not)
        print(d);
        print(e);
        print(f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
