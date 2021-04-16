using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 추상 메서드와 추상 클래스 생성
abstract public class A : MonoBehaviour
{
    public int a;
    abstract public void Abc();

}

// 인터페이스를 사용하면 다중 상속이 가능
// 첫글자는 대문자로 사용
interface ITest
{
    // 뼈대 제공, 다중 상속 가능
    void Bbc();

    // 함수, 프로퍼티, 인덱서, 이벤트만 들어감
    // 변수지정은 안됨
}

// 인터페이스끼리 상속가능


// A 클래스를 상속
// 하나만 상속 받을 수 있으나 인터페이스를 사용하면 다중 상속이 가능
public class Test_Interface : A, ITest
{
    // 상속받은 추상 A클래스의 추상함수인 Abc를 생성줘야함
    public override void Abc()
    {
        a = 5;
        print(a);
    }

    // 인터페이스는 override가 없음
    public void Bbc()
    {
        print("bb");
    }

    // Start is called before the first frame update
    void Start()
    {
        Abc();
        Bbc();
    }

}
