using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetil : MonoBehaviour
{

    public GameObject projectilePrefab;
    public float projectileForce = 10f;
    public float fireRate = 1f; // taxa de fogo

    private float timeSinceLastShot = 0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastShot += Time.deltaTime;

        //verifica o botao de tiro pressionad e o tempo de tiro
        if(Input.GetKey(KeyCode.F) && timeSinceLastShot >= fireRate){
            // cria instancia prefab
            GameObject projetil = Instantiate(projectilePrefab, transform.position, transform.rotation);

            // add forca ao projetil
            projetil.GetComponent<Rigidbody>().AddForce(transform.forward * projectileForce, ForceMode.VelocityChange);

            timeSinceLastShot = 0f;



        }
    }
}
