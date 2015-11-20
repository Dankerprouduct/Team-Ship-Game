using UnityEngine;
using System.Collections;

public class CannonControls : MonoBehaviour {


    public enum ConsoleType
    {
        ShipControl,
        Cannon1,
        Cannon2,
        Cannon3,
        Cannon4,
        Cannon5,
        Cannon6,
        Cannon7,
        Cannon8
    }
    public ConsoleType controlType;
    bool control; 
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Movement(); 
	    
	}

    void Movement()
    {
        if (control)
        {
            if (Input.GetKey(KeyCode.F))
            {
                control = false; 
            }
        }
    }

    public void InControl()
    {
        control = !control;
        Debug.Log(control); 
        
        transform.GetChild(0).transform.GetChild(2).GetComponent<Camera>().enabled = control;
    }
    

    public bool GetState()
    {
        return control; 
    }

}
