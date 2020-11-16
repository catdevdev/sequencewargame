using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParametersJoystick : MonoBehaviour
{

    public GameObject DestroEffect;

    public int health;

    public int team = 0;

    private void Update()
    {
        if (health <= 0)
        {
            Instantiate(DestroEffect, transform.position, transform.rotation);
            Destroy (gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
