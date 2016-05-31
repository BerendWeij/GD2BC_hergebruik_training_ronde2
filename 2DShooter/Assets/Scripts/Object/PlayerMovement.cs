using UnityEngine;

public class PlayerMovement : PlayerMovementData {

    void Move(bool forward, bool backward, bool jump) {
        if (forward && backward) {
            forward = backward = false;
        }

        if (forward) {
            transform.position += transform.right * (walkSpeed / walkSpeedDivider);
        } else if (backward) {
            transform.position += -transform.right * (walkSpeed / walkSpeedDivider);
        }
    }
}