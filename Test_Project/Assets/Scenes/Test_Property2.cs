using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Property2 : MonoBehaviour
{

    // 자신의 연봉 검색 가능
    Test_Property mySalary = new Test_Property();

    // Start is called before the first frame update
    void Start()
    {
        
        print(mySalary.SalaryP);
        
       
    }

}
