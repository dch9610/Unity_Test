using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  : �ڿ� ����ϰ����ϴ� ���ϸ��� ����
// �������� �����ؾ���
public class Test_Inheritance2 : Test_Inheritance
{
    string schoolName;
    // Start is called before the first frame update
    void Start()
    {
        schoolName = "�λ���б�";
        humanName = "��âȯ";
        humanAge = 26;

        Info();
        Name();
        
    }
    
    // �θ� Ŭ������ �Լ� ������
    protected override void Info()
    {
        // �θ� Ŭ������ �Լ��� ����Ŵ
        base.Info();
        print("���� �л��Դϴ�.");
    }


    protected override void Name()
    {
        print(humanName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
