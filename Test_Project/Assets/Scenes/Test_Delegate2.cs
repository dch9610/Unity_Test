using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Delegate2 : MonoBehaviour
{
    // Test_Delegate에서 ChainFuction을 만들때 int value를 사용했기 때문에 일치해야함
    public void Abc(int value)
    {
        print(value + "값이 증가했습니다.");
    }

    // Start is called before the first frame update
    void Start()
    {
        // 이벤트인 경우
        // Test_Delegate 클래스 Onstart에 Abc함수를 추가
        Test_Delegate.Onstart += Abc;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
