using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostEffect : MonoBehaviour
{
     [SerializeField] float boostMultiplier = 3.0f;
    [SerializeField]
    float sizeDecrease = 0.5f;
    private bool isApplied = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collided with booster");
        Rigidbody2D ballRb = other.GetComponent<Rigidbody2D>();
        Transform ballTrans = other.gameObject.GetComponent<Transform>();
        float currentSpeed = ballRb.velocity.magnitude;
        ballRb.velocity = ballRb.velocity.normalized * currentSpeed * boostMultiplier;
        ballTrans.localScale *= sizeDecrease;
        isApplied = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isApplied = false;
    }
}

