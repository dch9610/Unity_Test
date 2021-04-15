using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Struct�� ��Ÿ��;

// Class�� �ּ�Ÿ��;



// ����ü���� ���� �Է��Ҽ� ����
// ���� �Է��ϱ� ���ؼ��� public���� �����ϰų� �Լ��� ȣ���Ͽ� ���
// ���ſ��� class�� ������ ������ struct�� ���
// struct�� ������ (��ӺҰ�)
// ����ϴ� ���� : 
public struct C
{
    public int a;
    public int b;
    public int c;
    public int d;

    public void GetA(int value)
    {
        a = value;
    }

    // ������
    // ���� ������ �ݺ��۾��� �ٿ���
    // class or struct�� ������ �̸����� ����
    public C(int _a, int _b, int _c, int _d)
    {
        a = _a; b = _b; c = _c; d = _d;
    }

}

// enum �����ϴ�.
// �ٸ� ���� �����ʵ��� �ϴ� �������� ���� ����
public enum item
{
    Weapon,
    Shield,
    Potion,
}

public class Test_Structure : MonoBehaviour
{

    // ����ü ����
    C Lee;

    // ������ �̿�
    // ����� ������ ���ÿ� ���� ���� �� ����
    C Lee2 = new C(1, 2, 3, 4);

    // Class�� ������ ��� ������ ������ �����������
    // C Lee = new C();

    // enum ����
    item item;

    // Start is called before the first frame update
    void Start()
    {
        // ����ü ���
        Lee.a = 5;
        Lee.GetA(5);
        print(Lee.a);
        // �����ڸ� �̿��Ͽ� ���
        print(Lee2.a);

        // enum
        item = item.Weapon;
        item = item.Shield;

        print(item);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
