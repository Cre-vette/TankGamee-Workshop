using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float launchSpeed = 75.0f;
    public GameObject objectPrefab;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKey(KeyCode.E)){
            SpawnObject();
        }
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
