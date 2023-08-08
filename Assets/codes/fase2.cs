using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fase2 : MonoBehaviour
{
    public string sceneToLoad;
    GameObject gobj;



    // Start is called before the first frame update
    void Start()
    {
        gobj = GameObject.FindWithTag("portal");
        //gobj = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if (other.gameObject == gobj)
        {
            SceneManager.LoadScene(sceneToLoad);

            //gobj.transform.SetPosition(new Vector3(0,0,0));
        }
    }
}
