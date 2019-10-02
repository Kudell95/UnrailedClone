using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{

    public float moveSpeed;
    Vector3 movement;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

        movement = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        
        Debug.Log(movement.magnitude);
        transform.Translate(movement*Time.deltaTime*moveSpeed, Space.World);
        
    }
}
