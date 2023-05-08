using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowEffect : MonoBehaviour
{
    [SerializeField] float frictionForce = 5.0f;

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("collided with snow");

        Rigidbody2D ballRb = collision.gameObject.GetComponent<Rigidbody2D>();
        ballRb.AddForce(-ballRb.velocity.normalized * frictionForce);
    }
}
