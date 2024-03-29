using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Spin : MonoBehaviour
{
     private float mouseMove;
    
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
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

        transform.Rotate(Vector3.up, mouseMove * Time.deltaTime);

    }

    public void Tourner(InputAction.CallbackContext context)
    {
        mouseMove = context.ReadValue<float>();
    }
}
