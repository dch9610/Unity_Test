using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Delegate2 : MonoBehaviour
{
    // Test_Delegate���� ChainFuction�� ���鶧 int value�� ����߱� ������ ��ġ�ؾ���
    public void Abc(int value)
    {
        print(value + "���� �����߽��ϴ�.");
    }

    // Start is called before the first frame update
    void Start()
    {
        // �̺�Ʈ�� ���
        // Test_Delegate Ŭ���� Onstart�� Abc�Լ��� �߰�
        Test_Delegate.Onstart += Abc;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
