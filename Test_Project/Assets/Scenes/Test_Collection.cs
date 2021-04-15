using System.Collections; // 누군가 만들어놓은 클래스를 사용하기 위해 선언
using System.Collections.Generic;
using UnityEngine;

public class Test_Collection : MonoBehaviour
{
    
    int[] exp = new int[5] { 1, 2, 3, 4, 5 };
    // 컬렉션 : 리스트, 큐, 스택, 해시테이블, 딕셔너리, 어레이리스트

    // ArrayList
    // 아무 자료형이나 입력가능
    // 연산을 자주 수행함으로 과부하가 걸릴 수 있음
    ArrayList arrayList = new ArrayList();

    // List
    // <자료형>
    // 선언한 자료형만 입력가능
    List<int> list = new List<int>();

    // HasTable
    // 특정 값을 찾기 위해서 지정한 키값으로 접근해야함
    Hashtable hashTable = new Hashtable();

    // Dictionary
    // 해쉬테이블과 동일하나 자료형을 명시해야함
    Dictionary<string, int> dictionary = new Dictionary<string, int>();

    // Queue 
    // 선입선출, FIFO
    // 예시) 포션제작 대기줄 
    Queue<int> queue = new Queue<int>();

    // Stack 
    // 후입 선출, LIFO
    // 예시) 요리게임 설거지 그릇
    Stack<int> stack = new Stack<int>();

    // Start is called before the first frame update
    void Start()
    {
        // ArrayList
        // 만든 클래스에 .Add라는 메서드를 호출해서 사용
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add("가나다라");
        arrayList.Add(4.5);

        // 인덱스 위치에 값을 넣어줌
        arrayList.Insert(1, 1.5);

        //// 특정값을 입력하여 제거
        //arrayList.Remove("가나다라");
        //// 인덱스 번호를 이용하여 제거
        //arrayList.RemoveAt(3);
        //// 입력한 인덱스 부터 삭제할 범위를 지정
        //arrayList.RemoveRange(1, 3);
        //// 입력한 값 모두 삭제
        //arrayList.Clear();

        // 값 수정
        arrayList[3] = 4;

        // 특정 값이 있는지 확인 .Contains()
        // bool 타입
        // print(arrayList.Contains("가나다라"));
        // print(arrayList.Count); // arrayList 값의 갯수를 출력 .Length랑 같은 의미

        for (int i = 0; i < arrayList.Count; i++)
        {
            // print(arrayList[i]);
        }

        // HashTable
        hashTable.Add("만",  10000);
        hashTable.Add("백만",  1000000);
        hashTable.Add(50,  "1억");

        //print(hashTable["만"]);
        //print(hashTable[50]);


        // Dictonary
        dictionary.Add("만", 10000);
        // print(dictionary["만"]);


        // Queue
        // 값 넣기 : .Enqueue(지정한 자료형에 맞는 값)
        queue.Enqueue(5);
        queue.Enqueue(10);
        // 값 빼기 : .Dequeue()
        //if (queue.Count!=0)
        //    print(queue.Dequeue());
        //if (queue.Count!=0)
        //    print(queue.Dequeue());
        //if (queue.Count!=0)
        //    print(queue.Dequeue());

        // Stack
        // 값 넣기 : .Push
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // 값 빼기 : .Pop
        if (stack.Count != 0)
            print(stack.Pop());
        if (stack.Count != 0)
            print(stack.Pop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
