using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 예외처리, action, func 사용하기 위함
using System;

public class Test_Exception : MonoBehaviour
{
    int a = 5;
    int b = 0;
    int c;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            c = a / b;
        }
        // catch는 여러개 작성가능
        // 0으로 나누는 경우 예외처리
        catch(DivideByZeroException ie)
        {
            print(ie);
            b = 1;
            c = a / b;
         
        }
        // Null값 
        catch(NullReferenceException ie)
        {

        }

        // 오류의 상관없이 최종의 결과
        finally
        {
            print(c);
        }

        // 오류를 일부러 발생시킴
        throw new Exception("일부러 오류를 발생시킴");
    }

    
}
