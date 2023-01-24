using System;
using UnityEngine;

public class GroundCheck : MonoBehaviour {
    [SerializeField] private Vector2 groundCheckOffset;
    [SerializeField] private Vector2 groundCheckSize;
    [SerializeField] private LayerMask layerMask;

    public bool IsGrounded => BoxCast();

    private bool BoxCast() {
        return Physics2D.BoxCast(origin: (Vector2)transform.position + groundCheckOffset, size: groundCheckSize, 
            direction: Vector2.down, angle: 0, distance: groundCheckSize.magnitude, layerMask: layerMask);
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position + (Vector3)groundCheckOffset, 
            new Vector3(groundCheckSize.x, groundCheckSize.y, 1));
    }
}