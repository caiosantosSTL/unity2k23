using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixFPS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 25;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
