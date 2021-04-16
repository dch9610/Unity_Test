using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Property : MonoBehaviour
{
    // 프로퍼티 (속성)
    // 스패너 모양
    private int salary;
    private int bonus = 10;

    // salary 값 변경
    // 은닉성 보장
    //private void SetSalary(int value)
    //{
    //    salary = value;

    //}

    //// salary값 읽기
    //public int GetSalary()
    //{
    //    return salary;
    //}

    // 프로퍼티를 이용하여 함수 생성
    // 읽기 get, 쓰기 set 함수 내용 반드시 value를 사용
    public int SalaryP { get { return salary ; } private set { if (value < 0) salary = 10; else salary = value; } }

    // 자동완성 프로퍼티
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
