using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(GroundCheck))]
public class PlayerJump : MonoBehaviour {
    private Rigidbody2D _rb;
    private GroundCheck _groundCheck;
    [SerializeField] private float jumpForce;

    private void Start() {
        _rb = GetComponent<Rigidbody2D>();
        _groundCheck = GetComponent<GroundCheck>();
    }

    private void Update() {
        if (!Input.GetKeyDown(KeyCode.Space)) return;
        
        if (!_groundCheck.IsGrounded) return;

        Jump();
    }

    private void Jump() {
        _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}