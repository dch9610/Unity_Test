using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 인덱서
// MonoBehaviour를 상속받지 않았기 때문에 print를 사용할 수 없음
// Debug.Log로 출력
public class Record
{
    public int[] temp = new int[5];

    // 인덱서 선언
    // this : 해당 클래스를 지칭하는 예약어
    // 프로퍼티와 동일하게 구성
    public int this[int index]
    {
        get
        {
            if (index >= temp.Length)
            {
                Debug.Log("인덱스가 너무 큽니다.");
                return 0;
            }
            else
            {

                return temp[index];
            }
        }
        set { if (index >= temp.Length) Debug.Log("인덱스가 큽니다"); else temp[index] = value; }
    }
}




public class Test_Indexer : MonoBehaviour
{
    Record record = new Record();

    // Start is called before the first frame update
    void Start()
    {
        this.record[5] = 5; // 배열의 길이를 넘어가므로 get Debug.Log가 출력
        this.record[4] = 6; // 값 저장

        print(this.record[35]); // 인덱스가 너무 큽니다와 0을 출력
        print(this.record[4]);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
