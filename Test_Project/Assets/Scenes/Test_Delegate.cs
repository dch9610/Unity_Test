using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Delegate : MonoBehaviour
{
    // ��������Ʈ
    // ���� �Լ����� �ѱ����� �־ �����Ҽ� ����
    public delegate void ChainFunction(int value);
    // �̺�Ʈ�� ����� ��쿡�� �������� ����
    // ChainFunction chain;

    // �̺�Ʈ
    // �ٸ� ��� Ŭ������ ���ؼ� �Լ��� �߰���Ű�� �ѹ��� ȣ�Ⱑ��
    // static���� �����Ͽ��� ������ �ٸ� Ŭ�������� ���� ���� ����
    public static event ChainFunction Onstart;
    

    int power;
    int defence;

    public void SetPower(int value)
    {
        power += value;
        print("power�� ����" + value + "��ŭ �����߽��ϴ�. �� power�� �� = " + power);
    }

    public void SetDefence(int value)
    {
        defence += value;
        print("defence�� ����" + value + "��ŭ �����߽��ϴ�. �� defence�� �� = " + defence);
    }

    // Start is called before the first frame update
    void Start()
    {
        // LevelUp �Ҷ����� �ɷ�ġ�� ����ϰ� ����
        // ������ �ϳ��� �Լ��� �־����
        //chain += SetPower;
        //chain += SetDefence;

        //chain -= SetDefence;

        //if (chain != null)
        //{
        //    chain(5);
        //}

        Onstart += SetPower;
        Onstart += SetDefence;


    }

    // ������ ������ ȣ��ǰ���
    private void OnDisable()
    {
        Onstart(5);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
