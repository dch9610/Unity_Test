using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Array : MonoBehaviour
{
    // �迭 ���� []
    // ������ ����ü, �迭�� ũ��� �ѹ� �����Ǹ� �ٲܼ� ����, �ε����� �߿�

    // 1���� �迭
    int[] exp = { 50, 100, 150, 200, 250, 300 };
    int[] array = new int[10]; // �迭�� ũ�⸸ ����

    // 2���� �迭
    int[,] array2 = { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 } };

    // 3���� �迭
    // 2���� �迭�� 2��
    int[,,] array3 = { { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 } }, { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 } } };

    // Start is called before the first frame update
    void Start()
    {
        exp[5] = 500; // �� ���� ����
        print(exp[5]);

        // exp[6] = 1000; // �߰��� �Ұ���, �迭�� ó�� ũ�⸦ �� �����ؾ���

        print(exp.Length); // �迭 ������ ������ ��Ÿ��
        
        for (int i=0; i<exp.Length; i++)
        {
            print(exp[i]);
        }

        print(array2[1, 3]); // 40 ���
        print(array2[0, 1]); // 2 ���

        print(array3[1, 1, 2]); // 30 ���
        print(array3[0, 0, 3]); // 4 ���

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
