using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;

public class objpicker : MonoBehaviour {
  // public Outline cl1 = new Outline();
    void Start()
    {
        this.gameObject.GetComponent<Outline>().enabled = false;
    }
    void OnMouseEnter()
    {
        this.gameObject.GetComponent<Outline>().enabled = true;
     //   cl1.eraseRenderer=true;

    }
    void OnMouseExit()
    {
        this.gameObject.GetComponent<Outline>().enabled = false;
    }
}
