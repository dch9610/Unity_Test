using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Conditional : MonoBehaviour
{
    int input = 11;
    int num = 10;

    bool result;


    // Start is called before the first frame update
    void Start()
    {

        // If�� ���
        if (input > num)
        {
            print("input�� ���� num���� �۽��ϴ�.");
        }

        else if (input < num)
        {
            print("input�� ���� num���� �۽��ϴ�.");
        }

        else
        {
            print("input�� ���� num�����ϴ�.");
        }

        // Switch ���
        switch (input)
        {

            case 10: // : ���
                print("input�� ���� 10�Դϴ�.");
                break;
            case 11: // : ���
                print("input�� ���� 11�Դϴ�.");
                break;
            case 12: // : ���
                print("input�� ���� 12�Դϴ�.");
                break;
            default:
                print("�� ���� ���");
                break;
        }

        // ���ڿ��� ��밡��
        string input1 = "������";

        switch (input1)
        {

            case "��": // : ���
                print("input�� ���� '��'�Դϴ�");
                break;
            case "��": // : ���
                print("input�� ���� '��'�Դϴ�.");
                break;
            case "������": // : ���
                print("input�� ���� '������'�Դϴ�.");
                break;
            default:
                print("�� ���� ���");
                break;
        }

        // ���� ������
        int temp = input == num ? 50 : 100; // ������ true ��� 50�� ���� false�� ��� 100�� ��
        print(temp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
