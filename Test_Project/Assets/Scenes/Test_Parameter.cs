using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� �Ű����� T
// �Ű������� ���� �����ϴ� �Լ��� �޶���

public class Abc<T>
{
    public T var;
    public T[] array;

}


public class Test_Parameter : MonoBehaviour
{
    Abc<string> a;
    Abc<float> b;

    // ���� �Ű������� �̿��Ͽ� �Լ� ����
    // ��Ư�� Ÿ���� �Ű������� ������ ���
    // where T : class ����Ͽ� ���������� ����
    void Print<T>(T value) 
    {
        print(value);
    }

    

    // Start is called before the first frame update
    void Start()
    {
        Print<string>("abc");
        Print<int>(4);

        //a.var = "abc";
        //a.array = new string[1]; // ����
        //a.array[0] = "abc";

        //b.var = 4.5f;
        //b.array = new float[1]; // ����
        //b.array[0] = 5.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
