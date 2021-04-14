using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_fun : MonoBehaviour
{
    // 변수 선언
    int intValue;
    int intValue2;

    float floatValue = 10.5f;
    float floatValue2 = 20.5f;
    float floatValue3 = 30.5f;
    float floatValue4 = 40.5f;

    // float -> int로 바꾸는 함수 생성
    // _parametet : python *argc 와 같은 개념
    // = '디폴트값 생성' : 디폴트는 뒤쪽에 와야함 
    // void 아무값이나 반환가능
    void FloatToInt(float _parameter, float _parmeter2, string _stringParm = "test")
    {

        intValue = (int)(_parameter + _parmeter2);
        print(intValue);
        print(_stringParm);
    }

    // int : int값을 반환 return값이 있어야함
    int FloatToInt2(float _parameter, float _parameter2)
    {
        // Multuplay 함수 호출
        return Multiplay((int)(_parameter + _parameter2));
    }

    int Multiplay(int _parameter)
    {
        return _parameter * _parameter;
    }

    // Start is called before the first frame update
    void Start()
    {
        FloatToInt(floatValue, floatValue2);
        print(FloatToInt2(floatValue3, floatValue4));
        

    }

    // Update is called once per frame
    void Update()
    {
     
      
    }
}
