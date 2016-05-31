using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

    [SerializeField]
    private GameObject Bullet;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown("space"))
        {
         Instantiate(Bullet, new Vector3(transform.position.x + 1.2f, transform.position.y, transform.position.z), Quaternion.identity);
        }
	}
}
