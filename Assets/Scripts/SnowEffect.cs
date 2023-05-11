using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowEffect : MonoBehaviour
{
    [SerializeField]
    float frictionForce = 5.0f;

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log("collided with snow");

        Rigidbody2D ballRb = collision.gameObject.GetComponent<Rigidbody2D>();
        Transform ballTrans = collision.gameObject.GetComponent<Transform>();

        if (ballRb != null)
            ballRb.AddForce(-ballRb.velocity.normalized * frictionForce);

        if (ballTrans != null && ballRb.velocity.magnitude > 0.1f)
            ballTrans.localScale += new Vector3(0.0025f, 0.0025f, 0.0025f);
    }
}
