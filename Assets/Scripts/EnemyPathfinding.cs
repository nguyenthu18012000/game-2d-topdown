using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyPathfinding : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    private Rigidbody2D rb;
    private Vector2 moveDir;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveDir * moveSpeed * Time.fixedDeltaTime);
    }

    public void moveTo(Vector2 targetPosition)
    {
        moveDir = targetPosition;
        //Vector2 currentPosition = rb.position;
        //moveDir = (targetPosition - currentPosition).normalized;
        //// Optionally, you can add logic to stop moving when close to the target
        //if (Vector2.Distance(currentPosition, targetPosition) < 0.1f)
        //{
        //    moveDir = Vector2.zero; // Stop moving when close enough
        //}
    }
}
