using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleController : MonoBehaviour
{
    [SerializeField]
    private float maxSpeed = 200f;

    [SerializeField]
    private float power = 5f;

    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private Transform shotPoint;

    [SerializeField]
    private float timeBtwShots;

    [SerializeField]
    private float startTimeBtwShots;

    private Rigidbody2D rb;

    public void Move(float horizontalInput, float verticalInput)
    {
        // move
        rb
            .AddForce(new Vector2(horizontalInput * power,
                verticalInput * power));

        // limit speed
        if (rb.velocity.magnitude > maxSpeed)
            rb.velocity = rb.velocity.normalized * maxSpeed;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                Instantiate(bullet, shotPoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
