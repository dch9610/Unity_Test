using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMaker : MonoBehaviour
{
    private float spawn_time = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Spawn Ballet
        spawn_time += Time.deltaTime;

        if (spawn_time > 1.0f)
        {
            spawn_time = 0.0f;
            print("ÃÑ¾Ë¹ß»ç");
        }
    }
}

