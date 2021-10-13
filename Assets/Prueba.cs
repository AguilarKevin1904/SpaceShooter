using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
       rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movimiento = new Vector2(0,10); 
        if(Input.GetKeyDown("w"))
        {
            Debug.Log("Holi");
            rigidbody2D.AddForce(movimiento);
        }
    }
}
