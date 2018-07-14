using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;
using UnityEngine.UI;

public class objpicker : MonoBehaviour {
  // public Outline cl1 = new Outline();
    public GameObject tb;
    void Start()
    {
        this.gameObject.GetComponent<cakeslice.Outline>().enabled = false;
    }
    void OnMouseEnter()
    {
        this.gameObject.GetComponent<cakeslice.Outline>().enabled = true;
     //   cl1.eraseRenderer=true;

    }
    void OnMouseExit()
    {
        this.gameObject.GetComponent<cakeslice.Outline>().enabled = false;
    }
    void OnMouseDown()
    {
       tb.GetComponent<Text>().text = "Это бутылка";
        // this.gameObject.SetActive(false);
    }
}
