using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Spin : MonoBehaviour
{
     private float move;
    
    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.A)){
            transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E)){
            transform.Rotate(Vector3.up, -spinSpeed * Time.deltaTime);
        }
        */

        transform.Rotate(Vector3.up, move * Time.deltaTime);

    }

    public void Tourner(InputAction.CallbackContext context)
    {
        move = context.ReadValue<float>();

        Debug.Log("tourner : " + move);
    }
}
