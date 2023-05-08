using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostEffect : MonoBehaviour
{

    public float boostMultiplier = 2.0f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collided with booster");
        Rigidbody2D ballRb = other.GetComponent<Rigidbody2D>();
        float currentSpeed = ballRb.velocity.magnitude;
        ballRb.velocity = ballRb.velocity.normalized * currentSpeed * boostMultiplier;
    }


}
