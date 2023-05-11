using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForAnim : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected");
        animator.SetTrigger("Touched");
    }
}
