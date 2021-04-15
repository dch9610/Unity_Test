using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �߻��Լ��� ����ϰ� �Ǹ� class�� abstract�� �����������
abstract public class Test_Inheritance : MonoBehaviour
{
    // ��ӹ��� Ŭ���������� ����ϰ� �� : protected
    protected string humanName;
    protected int humanAge;


    // �Լ��� ��� ����
    // �ڽ�Ŭ�������� �ٽ� ���ǰ� �����ϵ��� ���� �Լ��� �������
    protected virtual void Info()
    {
        print("���� �ΰ��Դϴ�.");
    }

    // �߻��Լ�
    // �θ�Ŭ�������� �ݵ�� �ش� �Լ��� ������ ��
    // �ڽ�Ŭ�������� �Լ��� �ϼͽ��Ѷ�� ����
    abstract protected void Name();
}

