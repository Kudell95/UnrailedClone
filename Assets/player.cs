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
            StartCoroutine(FindItemsToPickup(hitcolliders));
        // }
        
    }


    IEnumerator FindItemsToPickup(Collider[] hits)
    {   
        
        int i=0;
        while (i < hits.Length)
        {
            Debug.Log("Item Found - " + hits[i].gameObject.name);
            i++;
            yield return null;
        }


        yield return 0;
       
    }

}
