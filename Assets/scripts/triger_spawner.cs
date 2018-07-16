using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;
using UnityEngine.UI;
public class triger_spawner : MonoBehaviour {
    public bool tgd;
    public GameObject invholder;
    public GameObject textb;
    public Transform place;
    public GameObject obj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (tgd == true)
            {
                Destroy(this.gameObject);
                obj = invholder.GetComponent<invenory>().inv1;
              Instantiate(obj, place.position, place.rotation);
            }
        }
    }
         void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            textb.GetComponent<Text>().text = "Нажмите Е чтобы поставить.";
            tgd = true;
        }
    }
    void OnTriggerExit(Collider col)
        {
            if (col.CompareTag("Player"))
            {
                textb.GetComponent<Text>().text = "";
                tgd = false;
            }
	}
}
