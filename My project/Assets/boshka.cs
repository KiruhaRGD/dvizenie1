using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boshka : CubeScript
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R)) transform.localScale += new Vector3(1, 1, 1) * speed * Time.deltaTime;
    }
}
