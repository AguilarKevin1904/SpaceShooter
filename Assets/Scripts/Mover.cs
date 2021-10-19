using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Rigidbody rig;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rig.velocity = transform.up * speed;
    }
}
