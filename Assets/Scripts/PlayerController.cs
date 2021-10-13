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
    private Rigidbody2D rig;
    public float speed;
    public Boundary boundary;
    // Start is called before the first frame update
    void Start()
    {
       rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rig.velocity = movement * speed;
        rig.position = new Vector2(Mathf.Clamp(rig.position.x, boundary.xMin, boundary.xMax), Mathf.Clamp(rig.position.y, boundary.yMin, boundary.yMax));
    }
}

