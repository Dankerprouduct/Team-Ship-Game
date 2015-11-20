using UnityEngine;
using System.Collections;

public class ConsoleControls : MonoBehaviour {

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
    bool inCollider; 
    CharacterContoller character;
    CannonControls cannonContrl; 
    ShipControls shipControl;
    // Use this for initialization
    void Start()
    {
       // controlType = new ConsoleType();
        if (this.tag == "Navigation")
        {
            shipControl = GetComponent<ShipControls>();
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    public bool hasCannon; 
         

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            character = other.GetComponent<CharacterContoller>(); 
            //Debug.Log("in consle");
            inCollider = true; 
            if (Input.GetKeyDown(KeyCode.F))
            {
                switch (controlType)
                {
                    case ConsoleType.Cannon1:
                        {
                            cannonContrl = GetComponent<CannonControls>();
                            cannonContrl.InControl();
                            character.FreezePlayer();
                            break;
                        }
                    case ConsoleType.Cannon2:
                        {
                            cannonContrl = GetComponent<CannonControls>();
                            cannonContrl.InControl();
                            character.FreezePlayer();
                            break;
                        }
                    case ConsoleType.Cannon3:
                        {
                            cannonContrl = GetComponent<CannonControls>();
                            cannonContrl.InControl();
                            character.FreezePlayer();
                            break;
                        }
                    case ConsoleType.Cannon4:
                        {
                            cannonContrl = GetComponent<CannonControls>();
                            cannonContrl.InControl();
                            character.FreezePlayer();
                            break;
                        }
                    case ConsoleType.Cannon5:
                        {
                            cannonContrl = GetComponent<CannonControls>();
                            cannonContrl.InControl();
                            character.FreezePlayer();
                            break;
                        }
                    case ConsoleType.Cannon6:
                        {
                            cannonContrl = GetComponent<CannonControls>();
                            cannonContrl.InControl();
                            character.FreezePlayer();
                            break;
                        }
                    case ConsoleType.Cannon7:
                        {
                            cannonContrl = GetComponent<CannonControls>();
                            cannonContrl.InControl();
                            character.FreezePlayer();
                            break;
                        }
                    case ConsoleType.Cannon8:
                        {
                            cannonContrl = GetComponent<CannonControls>();
                            cannonContrl.InControl();
                            character.FreezePlayer();
                            break;
                        }
                    case ConsoleType.ShipControl:
                        {
                            /*
                            if (shipControl.GetState() == false)
                            {
                                //Debug.Log("frozen"); 
                                // ship camera not turning back off after its been on
                                shipControl.ShipInControl();
                                character.FreezePlayer();

                            }
                            */
                            shipControl.ShipInControl();
                            character.FreezePlayer();
                            break;
                        }

                }
            }
        }
    }
    
    void OnGUI()
    {
        if (inCollider)
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 100, 25), "Press F to Use"); 
        }
        
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            inCollider = false; 

            switch (controlType)
            {
                case ConsoleType.Cannon1:
                    {

                        break;
                    }
                case ConsoleType.Cannon2:
                    {
                        
                        break;
                    }
                case ConsoleType.Cannon3:
                    {

                        break;
                    }
                case ConsoleType.Cannon4:
                    {

                        break;
                    }
                case ConsoleType.Cannon5:
                    {

                        break;
                    }
                case ConsoleType.Cannon6:
                    {

                        break; 
                    }
                case ConsoleType.Cannon7:
                    {

                        break;
                    }
                case ConsoleType.Cannon8:
                    {

                        break;
                    }
                case ConsoleType.ShipControl:
                    {

                        break; 
                    }
            }
        }
    }


}
