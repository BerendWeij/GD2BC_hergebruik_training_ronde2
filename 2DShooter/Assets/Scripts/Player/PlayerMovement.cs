using UnityEngine;

public class PlayerMovement : PlayerMovementData {

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(bool forward, bool backward, bool jump) {
        if (forward && backward) {
            forward = backward = false;
        }

        if (forward) {
            transform.position += transform.right * (walkSpeed / walkSpeedDivider);
        } else if (backward) {
            transform.position += -transform.right * (walkSpeed / walkSpeedDivider);
        }

        if (jump && touchingGround) {
            rb.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Ground") {
            touchingGround = true;
        }
    }

    void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Ground") {
            touchingGround = false;
        }
    }
}