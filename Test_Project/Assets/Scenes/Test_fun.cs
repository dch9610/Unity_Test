using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_fun : MonoBehaviour
{
    // ���� ����
    int intValue;
    int intValue2;

    float floatValue = 10.5f;
    float floatValue2 = 20.5f;
    float floatValue3 = 30.5f;
    float floatValue4 = 40.5f;

    // float -> int�� �ٲٴ� �Լ� ����
    // _parametet : python *argc �� ���� ����
    // = '����Ʈ�� ����' : ����Ʈ�� ���ʿ� �;��� 
    // void �ƹ����̳� ��ȯ����
    void FloatToInt(float _parameter, float _parmeter2, string _stringParm = "test")
    {

        intValue = (int)(_parameter + _parmeter2);
        print(intValue);
        print(_stringParm);
    }

    // int : int���� ��ȯ return���� �־����
    int FloatToInt2(float _parameter, float _parameter2)
    {
        // Multuplay �Լ� ȣ��
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
