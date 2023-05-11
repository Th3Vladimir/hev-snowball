using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForAnim : MonoBehaviour
{
    private Animator animator;
    private Collider2D collider;
    private bool isPassable = true;
    // Start is called before the first frame update

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        collider = GetComponent<Collider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected");
        animator.SetTrigger("Touched");
    }

}