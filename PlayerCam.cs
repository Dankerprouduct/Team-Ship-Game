using UnityEngine;
using System.Collections;

public class PlayerCam : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveCamera(Vector3 rotation)
    {
        //transform.rotation = transform.rotation * Quaternion.Euler(rotation);
       // cam.transform.localEulerAngles = new Vector3(currentCameraRotationX, 0f, 0f);
       // transform.localEulerAngles = new Vector3(rotation, 0f, 0f); 
    }
}
