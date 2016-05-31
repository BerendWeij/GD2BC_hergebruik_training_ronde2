using UnityEngine;
using System.Collections;

public class TurretBullet : MonoBehaviour {
    [SerializeField]
    private int lifetime = 5;
    private float speed = 0.5f;
    // Use this for initialization
    void Start()
    {

    }

    void Awake()
    {
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.forward * speed);
    }
}