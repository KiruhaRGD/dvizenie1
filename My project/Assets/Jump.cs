using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : CubeScript
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q)) Dvizenie(0, 1, 0);
        if (Input.GetKeyUp(KeyCode.Q)) transform.position = new Vector3(3, 0, 0);
    }
}
