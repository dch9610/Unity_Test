using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Loop : MonoBehaviour
{
    int num = 0;


    // Start is called before the first frame update
    void Start()
    {
        // (�ݺ��� ����; ����; ������;) �� ���� �ʿ�� ���� ��� ;�� �־����
        // �ݺ�Ƚ���� ��Ȯ�Ҷ�
        //for (int i=0; i<10; i+=2)
        //{
        //    num = i;
        //    print(num);
            
        //}

        //for( ; ; )
        //{
        //    num++;
        //    if (num%2 == 0)
        //        continue; // �ش� ȸ���� ����, ����ȸ�� ����
            
        //    print(num);

        //    if (num > 10)
        //        break; // ù��° �ݺ��� Ż��, ���ǹ� Ż��
        //}


        // while (����)
        // �ݺ�Ƚ���� ��Ȯ���� ������
        //while (num<10)
        //{
        //    num++;
        //    print(num);
        //}


        // do while
        // 1ȸ���� �����ϰ� ���� ������ Ȯ��, ������ ���� �ʴ� ��� 1ȸ���� �����ϰ� �ݺ��� Ż��
        //do
        //{
        //    num++;
        //    print(num);
        //}
        //while (num < 10);


        // foreach
        string text = "�����ٶ󸶹ٻ�";

        // text �����͸� �ɰ��� a��� ������ �ϳ��� ����
        foreach(char a in text)
        {
            print(a);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
