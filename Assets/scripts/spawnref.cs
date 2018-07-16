using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnref : MonoBehaviour {
    public GameObject obj;
    public Transform place;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            
           Instantiate(obj, place.position, place.rotation);
            Destroy(this.gameObject);
        }
    }
	
}
