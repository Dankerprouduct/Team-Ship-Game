using UnityEngine;
using System.Collections;

public class ShipControls : MonoBehaviour {

    float velocityX;
    float velocityY;
    float velocityZ;

    float rotationX;
    float rotationY;
    float rotationZ;

    public float shipUpwardTrust = .001f; 
    Rigidbody rigidBody;
    float force = 100000;
    bool shipControl = false; 
	// Use this for initialization
	void Start ()
    {

        rigidBody = transform.parent.transform.parent.GetComponent<Rigidbody>(); 

        Debug.Log(rigidBody.name); 
	}
	
	// Update is called once per frame
	void Update ()
    {
        //rigidBody.velocity += new Vector3(0, shipUpwardTrust, 0);
        if (shipControl)
        {
            Movement();
           // Debug.Log(rigidBody.velocity.magnitude); 
        } 
	}
    void OnGUI()
    {
        velocityX = Round(rigidBody.velocity.x, 1);
        velocityY = Round(rigidBody.velocity.y, 1);
        velocityZ = Round(rigidBody.velocity.z, 1);

        rotationX = Round(transform.rotation.x, 1);
        rotationY = Round(transform.rotation.y, 1);
        rotationZ = Round(transform.rotation.z, 1); 

        if (shipControl)
        {
            GUI.Label(new Rect(10, 10, 200, 50), "Rotation: { X:" + rotationX.ToString()+ " Y: "+rotationY.ToString()+" Z: "+ rotationZ.ToString() + " }");
            GUI.Label(new Rect(10, 60, 200, 50), "Velocity: { X: " + velocityX.ToString() + " Y: " + velocityY.ToString() + " Z: " + velocityZ.ToString() + " }"); 
        }
    }
    public static float Round(float value, int digits)
    {
        float mult = Mathf.Pow(10.0f, (float)digits);
        return Mathf.Round(value * mult) / mult;
    }
    void Movement()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
           // shipControl = !shipControl; 
        }
        
        if (shipControl)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rigidBody.AddForce(Vector3.forward * -force * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rigidBody.AddForce(Vector3.forward * force * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rigidBody.transform.Rotate(Vector3.back * -5f * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rigidBody.transform.Rotate(Vector3.back * 5f * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.E))
            {
                
                rigidBody.transform.Rotate((1 * 5f * Time.deltaTime),(1 * 5f * Time.deltaTime),(1 * 5 * Time.deltaTime));
            }
            if (Input.GetKey(KeyCode.Q))
            {
                
                rigidBody.transform.Rotate((-1) * 5f * Time.deltaTime, (-1 * 5f * Time.deltaTime), (-1 * 5f * Time.deltaTime));
            }

            if (Input.GetKey(KeyCode.L))
            {
                rigidBody.transform.Rotate(transform.right * 5 * Time.deltaTime); 
            }
            if (Input.GetKey(KeyCode.K))
            {
                rigidBody.transform.Rotate(transform.right * -5 * Time.deltaTime); 
            }
        }

        
    }
    
    public void ShipInControl()
    {
        shipControl = !shipControl;
        Debug.Log("Ship enabled:" + shipControl); 
        transform.FindChild("Ship Camera").GetComponent<Camera>().enabled = shipControl;  
    }
    public bool GetState()
    {
        return shipControl; 
    }
}
