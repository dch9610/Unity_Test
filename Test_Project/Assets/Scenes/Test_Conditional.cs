using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Conditional : MonoBehaviour
{
    int input = 11;
    int num = 10;

    bool result;


    // Start is called before the first frame update
    void Start()
    {

        // If문 사용
        if (input > num)
        {
            print("input의 값이 num보다 작습니다.");
        }

        else if (input < num)
        {
            print("input의 값이 num보다 작습니다.");
        }

        else
        {
            print("input의 값이 num같습니다.");
        }

        // Switch 사용
        switch (input)
        {

            case 10: // : 사용
                print("input의 값이 10입니다.");
                break;
            case 11: // : 사용
                print("input의 값이 11입니다.");
                break;
            case 12: // : 사용
                print("input의 값이 12입니다.");
                break;
            default:
                print("그 외의 경우");
                break;
        }

        // 문자열도 사용가능
        string input1 = "가나다";

        switch (input1)
        {

            case "가": // : 사용
                print("input의 값이 '가'입니다");
                break;
            case "나": // : 사용
                print("input의 값이 '나'입니다.");
                break;
            case "가나다": // : 사용
                print("input의 값이 '가나다'입니다.");
                break;
            default:
                print("그 외의 경우");
                break;
        }

        // 삼항 연산자
        int temp = input == num ? 50 : 100; // 조건이 true 경우 50이 들어가고 false일 경우 100이 들어감
        print(temp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
