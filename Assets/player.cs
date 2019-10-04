using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int strength;
    List<Item> itemsInHand = new List<Item>();
    // Start is called before the first frame update
    
    public Transform itemHolder;
    public float OverlapSpheresize = 1f;
    Collider[] hitcolliders;

    public LayerMask layer;

    GameObject closestObject;

    void Update(){
        
        hitcolliders = Physics.OverlapSphere(itemHolder.position, OverlapSpheresize, layer);

        // int i = 0;
        // while (i < hitcolliders.Length)
        // {
        //     Debug.Log("Item Found - " + hitcolliders[i].gameObject.name);
        //     i++;
        // }



        // if(hitcolliders.Length > 0)
        // {

            if(hitcolliders.Length > 0)
            {
                StartCoroutine(FindItemsToPickup(hitcolliders));
            }



            if(hitcolliders.Length == 0 && closestObject != null)
            {
                closestObject.GetComponent<Renderer>().material.color = new Color(0.45f,0.32f,0.2f, 1);
                closestObject = null;
            }

            if(closestObject != null)
            {
                
                closestObject.GetComponent<Renderer>().material.color = Color.white;
            }
        // }
        
    }


    IEnumerator FindItemsToPickup(Collider[] hits)
    {   
        
        int i=0;
        while (i < hits.Length)
        {
            Debug.Log(i + "Item Found - " + hits.Length);
            
            

            if(closestObject == null)
            {
                closestObject = hits[i].gameObject;
            }

            if(Vector3.Distance(transform.position, hits[i].transform.position) < Vector3.Distance(transform.position, closestObject.transform.position))
            {
                closestObject = hits[i].gameObject;

            }

            

            hits[i].gameObject.GetComponent<Renderer>().material.color = new Color(0.45f,0.32f,0.2f, 1);
                
            


            i++;

            yield return null;
        }


        yield return 0;
       
    }

}
