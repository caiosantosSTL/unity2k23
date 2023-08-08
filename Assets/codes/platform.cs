using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public float speed = 0.3f;
    public float distance = 1.0f;
    private Vector3 startPosition;
    GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startPosition + new Vector3(0, Mathf.Sin(Time.time * speed) * distance, 0);


    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "Player")
        {
            collisionInfo.gameObject.transform.parent = transform;
        }
    }

    private void OnCollisionExit(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "Player")
        {
            collisionInfo.gameObject.transform.parent = null;
        }
    }
}
