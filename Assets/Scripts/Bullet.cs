using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    public float lifetime;

    public float distance;

    public int damage;

    public LayerMask whatIsSolid;

    public int team = 0;

    private void Update()
    {
        RaycastHit2D hitInfo =
            Physics2D
                .Raycast(transform.position,
                transform.up,
                distance,
                whatIsSolid);
        if (hitInfo.collider != null)
        {
            if (
                hitInfo.collider.CompareTag("Hit") &&
                hitInfo.collider.GetComponent<ParametersJoystick>().team != team
            )
            {
                hitInfo
                    .collider
                    .GetComponent<ParametersJoystick>()
                    .TakeDamage(damage);
            }
            Destroy (gameObject);
        }

        // Move
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
