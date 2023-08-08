using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initUI : MonoBehaviour
{
    public GameObject initUIx;
    public GameObject UIHUD;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;//pausado
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void iniciarJogo()
    {
        Time.timeScale = 1; //nao pausado
        initUIx.SetActive(false); //desativa interface inicial
        UIHUD.SetActive(true);
       

    }
}
