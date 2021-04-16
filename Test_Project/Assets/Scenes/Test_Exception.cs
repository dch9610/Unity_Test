using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ����ó��, action, func ����ϱ� ����
using System;

public class Test_Exception : MonoBehaviour
{
    int a = 5;
    int b = 0;
    int c;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            c = a / b;
        }
        // catch�� ������ �ۼ�����
        // 0���� ������ ��� ����ó��
        catch(DivideByZeroException ie)
        {
            print(ie);
            b = 1;
            c = a / b;
         
        }
        // Null�� 
        catch(NullReferenceException ie)
        {

        }

        // ������ ������� ������ ���
        finally
        {
            print(c);
        }

        // ������ �Ϻη� �߻���Ŵ
        throw new Exception("�Ϻη� ������ �߻���Ŵ");
    }

    
}
