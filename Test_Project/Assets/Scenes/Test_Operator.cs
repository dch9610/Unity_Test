using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Operator : MonoBehaviour
{
    int a = 10;
    int b = 3;
    int c = 0;
    bool d = false;
    bool e;
    bool f;
    
    // 기본연산자 +,-,*,/,%, = (대입연산자)
    // ++, -- 증감 연산자 전위[선 연산 코드 실행], 후위[선코드 실행 후 연산]
    // 관계 연산자 ==, <=, >=, <, >, !=
    // 비트 연산자 &(and), |(or), ^(xor), ~(not)
        // 00001010
        // 00001100 &
        // 00001000 의 결과가 나옴

    // Start is called before the first frame update
    void Start()
    {
        //print(a + b);
        //print(a / b);
        //print(a % b); // 나머지 값

        //a = a + b; // 대입 연산자
        //a += b; // 복합 대입 연산자
        //print(a);

        //// 무조건 1만 더해줌
        //print(c++); // 0이 출력됨 먼저 c의값을 출력후 1을 더해줌
        //print(++c); // +1이 된값이 출력

        d = (a >= b); // 관계연산자
        e = (a != b) && (a==b); // 논리 연산자 && (and), || (or)
        f = !(a == b); // 논리연산자 ! (not)
        print(d);
        print(e);
        print(f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
