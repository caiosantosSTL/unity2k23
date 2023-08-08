using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colectible : MonoBehaviour
{
    private int scoreAdd = 1;
    private static int currentScore;
    public Text scoreT;
    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
        scoreT.text = ""+ currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "kolektis")
        {
            GetComponent<Renderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
            Destroy(gameObject, 3f);

            currentScore += scoreAdd;
            scoreT.text = "" + currentScore.ToString();
            print("-- "+ currentScore);
        }

    }
}
