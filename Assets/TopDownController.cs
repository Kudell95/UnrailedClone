    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{

    public float moveSpeed;
    Vector3 movement;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        movement = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        
        // Debug.Log(movement.magnitude);
        // transform.Translate(movement*Time.deltaTime*moveSpeed, Space.World);

        rb.MovePosition(transform.position + (movement * (Time.deltaTime * moveSpeed)));

        
    }
}
