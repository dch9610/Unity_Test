using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  : 뒤에 상속하고자하는 파일명을 써줌
// 허용범위를 지정해야함
public class Test_Inheritance2 : Test_Inheritance
{
    string schoolName;
    // Start is called before the first frame update
    void Start()
    {
        schoolName = "부산대학교";
        humanName = "이창환";
        humanAge = 26;

        Info();
        Name();
        
    }
    
    // 부모 클래스의 함수 재정의
    protected override void Info()
    {
        // 부모 클래스의 함수를 가리킴
        base.Info();
        print("나는 학생입니다.");
    }


    protected override void Name()
    {
        print(humanName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
