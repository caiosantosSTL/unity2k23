using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suitePrefab : MonoBehaviour
{
    // codigo de trocar objeto com a tecla T
    public GameObject[] prefabs = new GameObject[3];
    public static int currentIndex = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < prefabs.Length; i++)
        {

            Debug.Log("--> "+prefabs[i].name);
            prefabs[i].GetComponent<Renderer>().material.color = new Color(0.0f, 0.5f, 0.4f);
            //prefabs[i].SetActive(false);
            // desativa todos
            prefabs[i].GetComponent<changeColor>().enabled = false;
            prefabs[i].GetComponent<move>().enabled = false;
            // ativa o primeiro
            // ...

        }

        prefabs[currentIndex].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            //prefabs[currentIndex].SetActive(false); // desativa o antigo
            prefabs[currentIndex].GetComponent<changeColor>().enabled = false;
            prefabs[currentIndex].GetComponent<move>().enabled = false;
            currentIndex += 1;

            if(currentIndex == prefabs.Length) // se o numero maior que a largura do array
            {
                currentIndex = 0;
            }

            float[] randolx = new float[3];
            randolx[0] = Random.Range(0.5f, 1.0f);
            randolx[1] = Random.Range(0.5f, 1.0f);
            randolx[2] = Random.Range(0.5f, 1.0f);
            //prefabs[currentIndex].SetActive(true); // ativa o novo
            prefabs[currentIndex].GetComponent<Renderer>().material.color = new Color(randolx[0], randolx[1], randolx[2]);
            prefabs[currentIndex].GetComponent<changeColor>().enabled = true;
            prefabs[currentIndex].GetComponent<move>().enabled = true;



        }


    }
}
