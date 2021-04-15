using System.Collections; // ������ �������� Ŭ������ ����ϱ� ���� ����
using System.Collections.Generic;
using UnityEngine;

public class Test_Collection : MonoBehaviour
{
    
    int[] exp = new int[5] { 1, 2, 3, 4, 5 };
    // �÷��� : ����Ʈ, ť, ����, �ؽ����̺�, ��ųʸ�, ��̸���Ʈ

    // ArrayList
    // �ƹ� �ڷ����̳� �Է°���
    // ������ ���� ���������� �����ϰ� �ɸ� �� ����
    ArrayList arrayList = new ArrayList();

    // List
    // <�ڷ���>
    // ������ �ڷ����� �Է°���
    List<int> list = new List<int>();

    // HasTable
    // Ư�� ���� ã�� ���ؼ� ������ Ű������ �����ؾ���
    Hashtable hashTable = new Hashtable();

    // Dictionary
    // �ؽ����̺�� �����ϳ� �ڷ����� ����ؾ���
    Dictionary<string, int> dictionary = new Dictionary<string, int>();

    // Queue 
    // ���Լ���, FIFO
    // ����) �������� ����� 
    Queue<int> queue = new Queue<int>();

    // Stack 
    // ���� ����, LIFO
    // ����) �丮���� ������ �׸�
    Stack<int> stack = new Stack<int>();

    // Start is called before the first frame update
    void Start()
    {
        // ArrayList
        // ���� Ŭ������ .Add��� �޼��带 ȣ���ؼ� ���
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add("�����ٶ�");
        arrayList.Add(4.5);

        // �ε��� ��ġ�� ���� �־���
        arrayList.Insert(1, 1.5);

        //// Ư������ �Է��Ͽ� ����
        //arrayList.Remove("�����ٶ�");
        //// �ε��� ��ȣ�� �̿��Ͽ� ����
        //arrayList.RemoveAt(3);
        //// �Է��� �ε��� ���� ������ ������ ����
        //arrayList.RemoveRange(1, 3);
        //// �Է��� �� ��� ����
        //arrayList.Clear();

        // �� ����
        arrayList[3] = 4;

        // Ư�� ���� �ִ��� Ȯ�� .Contains()
        // bool Ÿ��
        // print(arrayList.Contains("�����ٶ�"));
        // print(arrayList.Count); // arrayList ���� ������ ��� .Length�� ���� �ǹ�

        for (int i = 0; i < arrayList.Count; i++)
        {
            // print(arrayList[i]);
        }

        // HashTable
        hashTable.Add("��",  10000);
        hashTable.Add("�鸸",  1000000);
        hashTable.Add(50,  "1��");

        //print(hashTable["��"]);
        //print(hashTable[50]);


        // Dictonary
        dictionary.Add("��", 10000);
        // print(dictionary["��"]);


        // Queue
        // �� �ֱ� : .Enqueue(������ �ڷ����� �´� ��)
        queue.Enqueue(5);
        queue.Enqueue(10);
        // �� ���� : .Dequeue()
        //if (queue.Count!=0)
        //    print(queue.Dequeue());
        //if (queue.Count!=0)
        //    print(queue.Dequeue());
        //if (queue.Count!=0)
        //    print(queue.Dequeue());

        // Stack
        // �� �ֱ� : .Push
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // �� ���� : .Pop
        if (stack.Count != 0)
            print(stack.Pop());
        if (stack.Count != 0)
            print(stack.Pop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
