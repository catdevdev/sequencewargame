using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserController : MonoBehaviour
{
    [SerializeField]
    public float maxSpeed = 200f;

    [SerializeField]
    public float power = 5f;

    [SerializeField]
    public GameObject bullet;

    public Transform shotPoint;

    private float timeBtwShots;

    public float startTimeBtwShots;

    public Rigidbody2D rb;

    private void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // rb.AddForce(new Vector2(horizontalInput, verticalInput), ForceMode2D.Impulse);
        // transform.position = transform.position + new Vector3(horizontalInput * 2 * Time.deltaTime, verticalInput * 2 * Time.deltaTime, 0);
        rb
            .AddForce(new Vector2(horizontalInput * power,
                verticalInput * power));

        if (rb.velocity.magnitude > maxSpeed)
            rb.velocity = rb.velocity.normalized * maxSpeed;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
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
