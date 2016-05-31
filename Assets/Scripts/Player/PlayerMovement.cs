using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    public void MoveLeft()
    {
        transform.Translate(Vector2.left * _movementSpeed * Time.deltaTime);
    }

    public void MoveRight()
    {
        transform.Translate(Vector2.right * _movementSpeed * Time.deltaTime);
    }
}