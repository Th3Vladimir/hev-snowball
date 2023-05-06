using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 startPoint;
    private LineRenderer lineRenderer;
    private Rigidbody2D rb;
    private float currentLineLength = 0f;

    [SerializeField]
    float maxPower;
    [SerializeField]
    float maxVelocity = 0.1f;
    [SerializeField]
    float maxLineLength = 5f;

    void Start()
    {
        lineRenderer = gameObject.GetComponent<LineRenderer>();
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        lineRenderer.positionCount = 2;
        
        lineRenderer.startColor = Color.cyan;
        lineRenderer.endColor = Color.cyan;

        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && rb.velocity.magnitude < maxVelocity)
        {
            isDragging = true;
            lineRenderer.enabled = true;
            startPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            lineRenderer.SetPosition(0, transform.position);
        }

        if (Input.GetMouseButton(0) && isDragging)
        {
            Vector3 currentPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentPoint.z = 0;

            // Limit the line length
            if (Vector3.Distance(transform.position, currentPoint) > maxLineLength)
            {
                currentPoint = transform.position + (currentPoint - transform.position).normalized * maxLineLength;
            }
            currentLineLength = Vector3.Distance(transform.position, currentPoint);

            lineRenderer.SetPosition(1, currentPoint);
        }

        if (Input.GetMouseButtonUp(0) && isDragging)
        {
            isDragging = false;
            Vector3 endPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            
            Vector2 direction = (endPoint - startPoint).normalized;
            Vector2 force = -direction * ( (currentLineLength/maxLineLength) * maxPower);
            rb.AddForce(force, ForceMode2D.Impulse);
            Debug.Log($"force y: {force.y}, x {force.x}"); /*if the Y or X are near the maxPower value its works fine*/
            lineRenderer.SetPosition(1, transform.position);
            if (lineRenderer.enabled)
            {
                lineRenderer.enabled = false;
            }
        }
    }
}
