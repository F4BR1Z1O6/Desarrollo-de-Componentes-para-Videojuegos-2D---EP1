using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunner : MonoBehaviour
{
    public float speed = 5;
    public float cameraOffsetX = 5;
    public float jumpForce = 5;
    private Rigidbody2D rb;
    private Transform camTrf;
    private Vector2 startPos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        camTrf = GameObject.Find("Main Camera").GetComponent<Transform>();
        startPos = transform.position;
    }

    void Update()
    {
        camTrf.position = new Vector3(transform.position.x + cameraOffsetX, camTrf.position.y, -10);
        rb.velocity = new Vector2(speed, rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }

    public void Reset()
    {
        transform.position = startPos;
    }
}
