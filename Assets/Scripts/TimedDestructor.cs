using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestructor : MonoBehaviour
{
    // Start is called before the first frame update

    public float WaitTime = 1.5f;
    void Start()
    {
        Destroy(gameObject, WaitTime);
    }

    // Update is called once per frame
      
    
}
