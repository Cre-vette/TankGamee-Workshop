using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Canon : MonoBehaviour
{
    public float launchSpeed = 75.0f;
    public GameObject objectPrefab;
    public float delaiEntreTirs = 0.5f;
    private float tempsDernierTir;
    


    void Start()
    {
        tempsDernierTir = -delaiEntreTirs;
    }


    public void Inputshoot(InputAction.CallbackContext context)
    {

        if (Time.time - tempsDernierTir >= delaiEntreTirs)
        {
            SpawnObject();
            tempsDernierTir = Time.time;
        }
    }


    void Update()
    {
      
        
    }

    void SpawnObject(){
        Vector3 spawnPosition = transform.position;
        Quaternion spawnRotation = Quaternion.identity;
        

        Vector3 localXDirection = transform.TransformDirection(Vector3.forward);
        Vector3 velocity = localXDirection * launchSpeed;
        //Instantiate Object
        GameObject newObject = Instantiate(objectPrefab, spawnPosition, spawnRotation);

        Rigidbody rb = newObject.GetComponent<Rigidbody>();
        rb.velocity = velocity;

    }
    
}
