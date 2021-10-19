using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}
public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float speed;
    private Rigidbody rig;
    public Boundary boundary;
    [Header("Shooting")]
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;
    // Start is called before the first frame update
    void Start()
    {
       rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical,-5);
        rig.velocity = movement * speed;
        rig.position = new Vector3(Mathf.Clamp(rig.position.x, boundary.xMin, boundary.xMax), Mathf.Clamp(rig.position.y, boundary.yMin, boundary.yMax),-5);

        if(Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }
}

