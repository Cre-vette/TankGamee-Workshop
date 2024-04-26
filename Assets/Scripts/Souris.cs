using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Souris : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void OnDisable()
    {
        Cursor.visible = false;
    }
}
