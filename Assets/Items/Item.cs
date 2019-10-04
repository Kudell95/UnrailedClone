using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    float gridSize;
    Vector3 currentpos;
    // Start is called before the first frame update
    void Start()
    {
        gridSize = Constants.gridsize;
    }

    // Update is called once per frame
    
    void Update()
    {
        currentpos = transform.position;

        transform.position = new Vector3(Mathf.Floor(currentpos.x / gridSize) * gridSize, 0.5f, Mathf.Floor(currentpos.z / gridSize) * gridSize);
    }
}
