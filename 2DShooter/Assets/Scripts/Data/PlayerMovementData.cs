using UnityEngine;

public class PlayerMovementData : MonoBehaviour {

    [SerializeField]
    protected float walkSpeed = 10; // How fast I'll walk.

    [SerializeField]
    protected float jumpHeight = 5; // How high I'll jump.

    [SerializeField]
    protected float walkSpeedDivider = 30; // Usually not going to edit this so I'll pass a default.
}
