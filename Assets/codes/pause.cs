using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    bool pausado = false;
    public GameObject UIPause;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && pausado == false)
        {
            Time.timeScale = 0;//pausado
            pausado = true;
            UIPause.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.P) && pausado == true)
        {
            Time.timeScale = 1;//nao pausado
            pausado = false;
            UIPause.SetActive(false);

        }
    }
}
