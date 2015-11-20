using UnityEngine;
using System.Collections;

public class CharacterContoller : MonoBehaviour {

    public float personalGravity = .01f; 
    bool frozen = false; 
    float cameraLimit = 85; 
    float currentCameraRotaion = 0f; 
    public float mouseSensitivity = 3f;
    float stamina = 15; 
    float yRotation;
    float xRotation;
    bool canRun; 
    float speed = 10; 
    Vector3 rotationX;
    Vector3 rotationY; 
    Rigidbody rigidBody;
    Quaternion originalRotation;
    //PlayerCam cam;
    Camera cam;
    Rigidbody ship; 
	// Use this for initialization
	void Start ()
    {
        ship = transform.parent.GetComponent<Rigidbody>();
        rigidBody = GetComponent<Rigidbody>();
        rotationX = Vector3.zero;
        cam = transform.GetChild(0).GetComponent<Camera>();
        if (rigidBody)
            rigidBody.freezeRotation = true;
        originalRotation = transform.localRotation;
    }
	
	// Update is called once per frame
	void Update ()
    {
        
        if (!frozen)
        {
            CameraMovement();
            Movement();
        }
	}
    void Movement()
    {
        float _xMov = Input.GetAxisRaw("Horizontal");
        float _zMov = Input.GetAxisRaw("Vertical");

        rigidBody.velocity = ship.velocity - new Vector3(0, ship.velocity.y - .001f,0); 
        rigidBody.angularDrag = ship.angularDrag;
        rigidBody.angularVelocity = ship.angularVelocity.normalized;
        

        Vector3 _movHorizontal = transform.right * _xMov;
        Vector3 _movVertical = transform.forward * _zMov;

        // Final movement vector
        Vector3 velocity = (_movHorizontal + _movVertical).normalized * speed;

        if (velocity != Vector3.zero)
        {
            rigidBody.MovePosition(rigidBody.position + velocity * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            CheckStamina(); 
            if (canRun)
            {
                speed = 20;
                stamina -= (3 * Time.deltaTime);
            }
           // Debug.Log(stamina); 
        }
        else
        {
            CheckStamina();
            stamina += (3 * Time.deltaTime); 
            speed = 10; 
        }

       

    }
    void CheckStamina()
    {
        if(stamina >= 15)
        {
            stamina = 15; 
        }

        if (stamina > 0)
        {
            canRun = true;
        }
        
        if (stamina <= 0)
        {
            canRun = false;
        }
    }
    void CameraMovement()
    {
        xRotation = Input.GetAxisRaw("Mouse X");
        rotationX = new Vector3(0, xRotation, 0) * mouseSensitivity;

        rigidBody.MoveRotation(rigidBody.rotation * Quaternion.Euler(rotationX));
       // rigidBody.MoveRotation((ship.rotation * rigidBody.rotation) * Quaternion.Euler(rotationX));

        yRotation = Input.GetAxisRaw("Mouse Y");
        //rotationY = new Vector3(0, yRotation, 0) * mouseSensitivity;
        float camRot = yRotation * mouseSensitivity;

        currentCameraRotaion -= camRot;
        currentCameraRotaion = Mathf.Clamp(currentCameraRotaion, -cameraLimit, cameraLimit);
        cam.transform.localEulerAngles = new Vector3(currentCameraRotaion, 0f, 0f);
    }
    public void FreezePlayer()
    {
        rigidBody.isKinematic = !frozen;
        Debug.Log(frozen); 
        frozen = !frozen;
        transform.GetChild(0).GetComponent<Camera>().enabled = !frozen;
        Debug.Log("camera is: " + frozen); 
    }
    public bool CurrentState()
    {

        return frozen; 
    }
}
