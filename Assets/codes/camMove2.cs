using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMove2 : MonoBehaviour
{
    public Transform target;
    public float followSpeed = 5.0f;
    public float rotateSpeed = 100.0f;
    public float smoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position; // Pos do alvo da camera
        targetPosition.y += 5.0f; // eleva cam acima do alvo
        // Calc nova pos da camera em suave
        Vector3 newPosition = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        //atualiza pos da camera
        transform.position = newPosition;

        transform.position = Vector3.Lerp(transform.position, target.position, followSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, rotateSpeed * Time.deltaTime);
    }
}
