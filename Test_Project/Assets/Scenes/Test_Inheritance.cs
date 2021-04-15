using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 추상함수를 사용하게 되면 class도 abstract로 선언해줘야함
abstract public class Test_Inheritance : MonoBehaviour
{
    // 상속받은 클래스에서만 사용하게 함 : protected
    protected string humanName;
    protected int humanAge;


    // 함수도 상속 가능
    // 자식클래스에서 다시 정의가 가능하도록 가상 함수로 만들어줌
    protected virtual void Info()
    {
        print("나는 인간입니다.");
    }

    // 추상함수
    // 부모클래스에서 반드시 해당 함수를 만들라고 함
    // 자식클래스에서 함수를 완셩시켜라고 해줌
    abstract protected void Name();
}

