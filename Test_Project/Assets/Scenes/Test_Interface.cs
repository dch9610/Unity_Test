using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �߻� �޼���� �߻� Ŭ���� ����
abstract public class A : MonoBehaviour
{
    public int a;
    abstract public void Abc();

}

// �������̽��� ����ϸ� ���� ����� ����
// ù���ڴ� �빮�ڷ� ���
interface ITest
{
    // ���� ����, ���� ��� ����
    void Bbc();

    // �Լ�, ������Ƽ, �ε���, �̺�Ʈ�� ��
    // ���������� �ȵ�
}

// �������̽����� ��Ӱ���


// A Ŭ������ ���
// �ϳ��� ��� ���� �� ������ �������̽��� ����ϸ� ���� ����� ����
public class Test_Interface : A, ITest
{
    // ��ӹ��� �߻� AŬ������ �߻��Լ��� Abc�� ���������
    public override void Abc()
    {
        a = 5;
        print(a);
    }

    // �������̽��� override�� ����
    public void Bbc()
    {
        print("bb");
    }

    // Start is called before the first frame update
    void Start()
    {
        Abc();
        Bbc();
    }

}
