using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// class��� ��ũ��Ʈ ���ϸ��� ��ġ�ؾ���
// class�� �׸��̶�� �����ϸ� ��
public class Test1 : MonoBehaviour
{
    // ���� ����
    // integer ���� �ڷ��� (-20�� + 20��) - 4����Ʈ
    // short ���� �ڷ��� (-30,000 ~ 30,000) - 2����Ʈ
    // long ���� �ڷ��� - 8����Ʈ
    // sbyte ���� �ڷ��� (-128 ~ 128) - 1����Ʈ
    // byte ���� �ڷ��� (0 ~ 255) - 1����Ʈ
    int x = 100;
    int y = 100;
    


    // ���� ���� (float > double > decimal)
    // float �Ǽ� �ڷ��� (�ڿ� f�� �������) ������ ������ ���� 
    // double �Ǽ� �ڷ��� 
    // decimal �Ǽ� �ڷ��� (�ڿ� m�� �������)

    // ���� �ڷ���
    // string ���� �ڷ��� (���ڿ� ���尡�� "")
    // char ���� �ڷ��� (�ѱ��ڸ� ���� '')
    string s = "asaskdwokd";
    


    int a = 100;
    float b = 100.14f;
    string c;
    string d = "10990";
    int e;

    float sum;

    // short (-3�� ~ 3��) ushort�� ���� ���� ����
   
    // bool (True, False�� ���� ����)


    // Start is called before the first frame update
    void Start()
    {
        sum = a + b;
        c = a.ToString(); // int -> string���� ��ȯ
        e = int.Parse(d); // string -> int�� ��ȯ
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
