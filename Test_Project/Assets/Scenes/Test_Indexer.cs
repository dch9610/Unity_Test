using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �ε���
// MonoBehaviour�� ��ӹ��� �ʾұ� ������ print�� ����� �� ����
// Debug.Log�� ���
public class Record
{
    public int[] temp = new int[5];

    // �ε��� ����
    // this : �ش� Ŭ������ ��Ī�ϴ� �����
    // ������Ƽ�� �����ϰ� ����
    public int this[int index]
    {
        get
        {
            if (index >= temp.Length)
            {
                Debug.Log("�ε����� �ʹ� Ů�ϴ�.");
                return 0;
            }
            else
            {

                return temp[index];
            }
        }
        set { if (index >= temp.Length) Debug.Log("�ε����� Ů�ϴ�"); else temp[index] = value; }
    }
}




public class Test_Indexer : MonoBehaviour
{
    Record record = new Record();

    // Start is called before the first frame update
    void Start()
    {
        this.record[5] = 5; // �迭�� ���̸� �Ѿ�Ƿ� get Debug.Log�� ���
        this.record[4] = 6; // �� ����

        print(this.record[35]); // �ε����� �ʹ� Ů�ϴٿ� 0�� ���
        print(this.record[4]);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
