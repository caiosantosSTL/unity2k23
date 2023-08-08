using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    private Transform tsf;

    public float jumpForce = 10f;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    Rigidbody rb;
    public float moveSpeed = 5f;
    public float rotateSpeed = 100.0f;
    public Transform resetPos;


    // Start is called before the first frame update
    void Start()
    {
        tsf = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        // movement
        //float horizontalInput = Input.GetAxis("Horizontal");
        /*float verticalInput = Input.GetAxis("Vertical");
        transform.position = transform.position + new Vector3(0f, 0f, verticalInput) * moveSpeed * Time.deltaTime;*/

        LayerMask tagMask = LayerMask.GetMask("land");

        RaycastHit hit = new RaycastHit();

        if (Physics.Raycast(transform.position, transform.forward, out hit, 1.3f, tagMask))
        {
            if (Input.GetKey(KeyCode.W))
            {
                //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
                tsf.Translate(new Vector3(0, 0, -moveSpeed) * Time.deltaTime);//frente

            }
            //print("toc");
        } 

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

        //left right lateral
        if(Input.GetKey(KeyCode.Q)){
            tsf.Translate(new Vector3(moveSpeed,0, 0) * Time.deltaTime);//dir
        }
        if(Input.GetKey(KeyCode.E)){
            tsf.Translate(new Vector3(-moveSpeed,0, 0) * Time.deltaTime);//esq
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


        // jump
         if(Input.GetButtonDown("Jump") && isGrounded()){
             rb.velocity = Vector3.up * jumpForce;
         }

         if(rb.velocity.y < 0){
             rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
         }else if(rb.velocity.y > 0 && !Input.GetButton("Jump")){
             rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
         }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "reset")
        {
            gameObject.transform.position = resetPos.position;
        }        
    }


    bool isGrounded(){
        return Physics.Raycast(transform.position, -Vector3.up, 1.1f);
    }
}
