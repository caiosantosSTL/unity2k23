using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Transform tsf;

    public float jumpForce = 10f;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    public float moveSpeed = 5f;
    public float rotateSpeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        tsf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // movement 2
        if (Input.GetKey(KeyCode.W)){
            //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
            tsf.Translate(new Vector3(0, 0, moveSpeed) * Time.deltaTime);//frente
        }
        if (Input.GetKey(KeyCode.LeftShift)){ // bust
            //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
            tsf.Translate(new Vector3(0, 0, moveSpeed) * Time.deltaTime);//frente
        }
        if(Input.GetKey(KeyCode.S)){
            //transform.position -= Vector3.forward * moveSpeed * Time.deltaTime;
            tsf.Translate(new Vector3(0, 0, -moveSpeed) * Time.deltaTime);//tras
        }

        // rotate
        if(Input.GetKey(KeyCode.A)){
            //transform.Rotate(Vector3.down, rotateSpeed * Time.deltaTime);
            tsf.transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);//dir
        }
        if(Input.GetKey(KeyCode.D)){
            //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
            tsf.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);//esq
        }
    }
}
