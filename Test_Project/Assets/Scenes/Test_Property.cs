using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Property : MonoBehaviour
{
    // ������Ƽ (�Ӽ�)
    // ���г� ���
    private int salary;
    private int bonus = 10;

    // salary �� ����
    // ���м� ����
    //private void SetSalary(int value)
    //{
    //    salary = value;

    //}

    //// salary�� �б�
    //public int GetSalary()
    //{
    //    return salary;
    //}

    // ������Ƽ�� �̿��Ͽ� �Լ� ����
    // �б� get, ���� set �Լ� ���� �ݵ�� value�� ���
    public int SalaryP { get { return salary ; } private set { if (value < 0) salary = 10; else salary = value; } }

    // �ڵ��ϼ� ������Ƽ
    public int Bonus { get; set; }


    // Start is called before the first frame update
    void Start()
    {
        SalaryP = 15;
        print(SalaryP);
        // print(Bonus);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
