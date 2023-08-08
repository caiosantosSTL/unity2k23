using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeDestroy : MonoBehaviour
{
    public float destroyTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyCountdown());

        IEnumerator DestroyCountdown(){
            yield return new WaitForSeconds(destroyTime);

            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
