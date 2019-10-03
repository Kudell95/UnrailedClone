using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    Vector3 lookPos;
    public float speed;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
            if(Vector3.Distance(hit.point, transform.position) > 1)
            {
                lookPos =   hit.point - this.transform.position;
                lookPos.y = 0;
                Quaternion lookrot = Quaternion.LookRotation(lookPos);
                transform.transform.rotation = Quaternion.Slerp(transform.rotation, lookrot, Time.deltaTime * speed);

            }
                       
        }
        
    }
}
