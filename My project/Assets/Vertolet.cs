using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertolet : CubeScript
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T)) transform.Rotate(0, 1 * speed * Time.deltaTime, 0);
    }
}
