using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 형식 매개변수 T
// 매개변수에 따라 선택하는 함수가 달라짐

public class Abc<T>
{
    public T var;
    public T[] array;

}


public class Test_Parameter : MonoBehaviour
{
    Abc<string> a;
    Abc<float> b;

    // 형식 매개변수를 이용하여 함수 생성
    // 불특정 타입의 매개변수를 받을때 사용
    // where T : class 사용하여 제약조건을 설정
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
        //a.array = new string[1]; // 생성
        //a.array[0] = "abc";

        //b.var = 4.5f;
        //b.array = new float[1]; // 생성
        //b.array[0] = 5.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
