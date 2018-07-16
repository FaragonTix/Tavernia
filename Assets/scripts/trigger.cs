using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using cakeslice;

public class trigger : MonoBehaviour {
    public GameObject des;
    public GameObject textb;
    public bool tgd;
    public GameObject tgholder;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (tgd == true)
            {
                GameObject hh = Resources.Load("benchh", typeof(GameObject)) as GameObject;
                tgholder.GetComponent<invenory>().inv1 = hh;
                Destroy(des);
                tgd = false;
            }
        }
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            textb.GetComponent<Text>().text = "Нажмите Е чтобы убить.";
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

