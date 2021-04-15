using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Struct는 값타입;

// Class는 주소타입;



// 구조체에는 값을 입력할수 없음
// 값을 입력하기 위해서는 public으로 선언하거나 함수를 호출하여 사용
// 과거에는 class가 없었기 때문에 struct를 사용
// struct는 구버전 (상속불가)
// 사용하는 이유 : 
public struct C
{
    public int a;
    public int b;
    public int c;
    public int d;

    public void GetA(int value)
    {
        a = value;
    }

    // 생성자
    // 변수 생성의 반복작업을 줄여줌
    // class or struct랑 동일한 이름으로 생성
    public C(int _a, int _b, int _c, int _d)
    {
        a = _a; b = _b; c = _c; d = _d;
    }

}

// enum 열거하다.
// 다른 값이 들어가지않도록 하는 선택지와 같은 개념
public enum item
{
    Weapon,
    Shield,
    Potion,
}

public class Test_Structure : MonoBehaviour
{

    // 구조체 선언
    C Lee;

    // 생성자 이용
    // 선언과 생성과 동시에 값을 넣을 수 있음
    C Lee2 = new C(1, 2, 3, 4);

    // Class로 선언할 경우 참조할 공간을 생성해줘야함
    // C Lee = new C();

    // enum 선언
    item item;

    // Start is called before the first frame update
    void Start()
    {
        // 구조체 사용
        Lee.a = 5;
        Lee.GetA(5);
        print(Lee.a);
        // 생성자를 이용하여 출력
        print(Lee2.a);

        // enum
        item = item.Weapon;
        item = item.Shield;

        print(item);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
