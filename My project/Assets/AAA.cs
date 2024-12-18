using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AAA : CubeScript
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E)) transform.Rotate(0, 0, 1 * speed * Time.deltaTime);
    }
}
