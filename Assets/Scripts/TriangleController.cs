using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriangleController : MonoBehaviour
{
    [SerializeField]
    public float maxSpeed = 200f;

    [SerializeField]
    public float power = 5f;

    [SerializeField]
    public GameObject bullet;

    [SerializeField]
    private Transform shotPoint;

    [SerializeField]
    public float timeBtwShots;

    [SerializeField]
    private float startTimeBtwShots;

    private Rigidbody2D rb;

    [SerializeField]
    GameObject nicknameLabel;

    GameObject instantiatedNicknameLabel;

    public string nickName = "123";

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

    public void Fire()
    {
        if (timeBtwShots <= 0)
        {
            // bullet.GetComponent<Bullet>().team;
            Instantiate(bullet, shotPoint.position, transform.rotation);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        instantiatedNicknameLabel =
            Instantiate(nicknameLabel,
            transform.position,
            Quaternion.Euler(new Vector3(0, 0, 0)));

        GameObject label =
            instantiatedNicknameLabel.transform.Find("Text").gameObject;
        TextMeshProUGUI t = label.GetComponent<TextMeshProUGUI>();
        t.text = nickName;
    }

    int a = 100;

    private void FixedUpdate()
    {
        instantiatedNicknameLabel.transform.position = transform.position;
    }
}
