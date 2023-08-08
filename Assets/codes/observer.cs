using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class observer : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //calc direc do heroi em relac do observer
        /*Vector3 direction = target.position - transform.position;
        direction.Normalize();

        //calc angulo entre heroi e frente observer
        float angle = Vector3.Angle(direction, transform.forward);

        //se angulo for maior determidao limiar =, gire observer em direcao ao heroi
        if(angle > 0.01f){
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotationSpeed * Time.deltaTime);
        }*/

        // ----------------- area limit
        // calc a distancia entre observer e heroi
        float distance = Vector3.Distance(target.position, transform.position);
        //print("val distancia - " + distance);

        //se a distancia for menor que determinado limiar gire observe a heroi
        if(distance < 20f){
            Vector3 direction = target.position - transform.position;
            direction.Normalize();

            float angle = Vector3.Angle(direction, transform.forward);

            if(angle > 0.01f){
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotationSpeed * Time.deltaTime);
            }
        }

        
    }
}
