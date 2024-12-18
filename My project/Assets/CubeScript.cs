using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) Dvizenie(-1, 0, 0);
        if (Input.GetKey(KeyCode.D)) Dvizenie(1, 0, 0);
        if (Input.GetKey(KeyCode.W)) Dvizenie(0, 0, 1);
        if (Input.GetKey(KeyCode.S)) Dvizenie(0, 0, -1);
    }
    public void Dvizenie(int x, int y, int z) 
    {
        transform.position += new Vector3(x, y, z) * speed * Time.deltaTime;
    }
}
