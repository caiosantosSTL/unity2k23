using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if(suitePrefab.currentIndex == 0)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }else if (suitePrefab.currentIndex == 1)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
            }else if (suitePrefab.currentIndex == 2)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
            
        }
    }
}
