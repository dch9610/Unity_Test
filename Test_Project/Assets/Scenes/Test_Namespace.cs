using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lee; // ���� namespace�� �ҷ���

// namespace
// ����, ���� ������Ʈ, �ܺ� ���̺귯���� �ߺ������� �ذ��ϱ� ���� ���
// Ŭ�������� ���Ƶ� namespace���� �ٸ��� ������ �ߺ����� �ذ�
namespace Lee
{
    // ���� Ŭ���� ���� ����Ұ��
    // using�� ����ϰ��� �ϴ� namespace�� Ȯ���� �����������
    // or ���� Ŭ�������� ����������
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

            // bool Ÿ�� �Լ�
            public bool IsLike()
            {
                // 0�� �ƴ� ���� �����ϸ� True�� ��ȯ
                return like != 0;
            }
        }
    }
}


public class Test_Namespace : MonoBehaviour
{

    // ����� ������ �������
    // using�� Lee.Study�θ� ���� ��� Study �ȿ� �ִ� �Լ� C�� �ҷ��� 
    // using�� Lee�θ� ���� ��� Lee.C�� C �Լ� ȣ��
    Lee.C Lee;
    Lee.Study.C Lee2;

    // Start is called before the first frame update
    void Start()
    {
        // ����
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
