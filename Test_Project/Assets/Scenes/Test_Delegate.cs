using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Delegate : MonoBehaviour
{
    // 델리게이트
    // 만든 함수들을 한군데에 넣어서 관리할수 있음
    public delegate void ChainFunction(int value);
    // 이벤트를 사용할 경우에는 선언하지 않음
    // ChainFunction chain;

    // 이벤트
    // 다른 모든 클래스에 관해서 함수를 추가시키고 한번에 호출가능
    // static으로 지정하였기 때문에 다른 클래스에서 쉽게 접근 가능
    public static event ChainFunction Onstart;
    

    int power;
    int defence;

    public void SetPower(int value)
    {
        power += value;
        print("power의 값이" + value + "만큼 증가했습니다. 총 power의 값 = " + power);
    }

    public void SetDefence(int value)
    {
        defence += value;
        print("defence의 값이" + value + "만큼 증가했습니다. 총 defence의 값 = " + defence);
    }

    // Start is called before the first frame update
    void Start()
    {
        // LevelUp 할때마다 능력치를 향상하고 싶음
        // 참조할 하나의 함수는 있어야함
        //chain += SetPower;
        //chain += SetDefence;

        //chain -= SetDefence;

        //if (chain != null)
        //{
        //    chain(5);
        //}

        Onstart += SetPower;
        Onstart += SetDefence;


    }

    // 게임이 꺼질때 호출되게함
    private void OnDisable()
    {
        Onstart(5);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
