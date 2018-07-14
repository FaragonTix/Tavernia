using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public GameObject Menu;
    public bool z=false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (z == false)
            {
                z = true;
            }
            else
            {
                z = false;
            }

                Menu.gameObject.SetActive(z);
            }
           
        }
    

  public  void Exit()
    {
        Application.Quit();
    }
	public void cont()
	{
		Menu.gameObject.SetActive (false);
		z = false;
	}

}

       
    

  

