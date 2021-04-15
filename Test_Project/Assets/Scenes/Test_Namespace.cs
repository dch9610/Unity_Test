using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lee; // 만든 namespace를 불러옴

// namespace
// 협업, 대형 프로젝트, 외부 라이브러리를 중복문제를 해결하기 위해 사용
// 클래스명이 같아도 namespace명이 다르기 때문에 중복문제 해결
namespace Lee
{
    // 같은 클래스 명을 사용할경우
    // using에 사용하고자 하는 namespace를 확실히 선언해줘야함
    // or 시작 클래스에서 명시해줘야함
    public class C
    {
        public int subscribe;
    }

    namespace Study
    {
        public class C
        {
            int like;

            public void SetLike(int value)
            {
                like = value;
            }

            // bool 타입 함수
            public bool IsLike()
            {
                // 0이 아닌 값이 존재하면 True로 반환
                return like != 0;
            }
        }
    }
}


public class Test_Namespace : MonoBehaviour
{

    // 선언과 생성을 해줘야함
    // using을 Lee.Study로만 했을 경우 Study 안에 있는 함수 C를 불러옴 
    // using을 Lee로만 했을 경우 Lee.C로 C 함수 호출
    Lee.C Lee;
    Lee.Study.C Lee2;

    // Start is called before the first frame update
    void Start()
    {
        // 생성
        Lee = new Lee.C();
        Lee.subscribe = 5;
        print(Lee.subscribe);

        Lee2 = new Lee.Study.C();
        Lee2.SetLike(2);
        print(Lee2.IsLike());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
