using UnityEngine;
using System.Collections;

public class RocketCamera : MonoBehaviour {

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
        if (GetComponent<Camera>().enabled)
        {
            control = true;
        }
        else
        {
            control = false; 
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        if (control)
        {
            if (controlType == ConsoleType.Cannon1)
            {
                GUI.Label(new Rect(10, 10, 150, 50), "Cannon 1 is Enabled"); 
            }
            if (controlType == ConsoleType.Cannon2)
            {
                GUI.Label(new Rect(10, 10, 150, 50), "Cannon 2 is Enabled"); 
            }
            if (controlType == ConsoleType.Cannon3)
            {
                GUI.Label(new Rect(10, 10, 150, 50), "Cannon 3 is Enabled");
            }
            if (controlType == ConsoleType.Cannon4)
            {
                GUI.Label(new Rect(10, 10, 150, 50), "Cannon 4 is Enabled");
            }
            if (controlType == ConsoleType.Cannon5)
            {
                GUI.Label(new Rect(10, 10, 150, 50), "Cannon 5 is Enabled");
            }
            if (controlType == ConsoleType.Cannon6)
            {
                GUI.Label(new Rect(10, 10, 150, 50), "Cannon 6 is Enabled");
            }
            if (controlType == ConsoleType.Cannon7)
            {
                GUI.Label(new Rect(10, 10, 150, 50), "Cannon 7 is Enabled");
            }
            if (controlType == ConsoleType.Cannon8)
            {
                GUI.Label(new Rect(10, 10, 150, 50), "Cannon 8 is Enabled"); 
            }
        }
    }
}
