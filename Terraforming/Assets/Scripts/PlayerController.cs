using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{


    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        transform.Translate(-5*Time.deltaTime, 0f, Input.GetAxis("Horizontal")*5*Time.deltaTime);
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            gameObject.SetActive(false);
        }
    }
}