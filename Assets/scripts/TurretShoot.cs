using UnityEngine;
using System.Collections;

public class TurretShoot : MonoBehaviour {
    [SerializeField] private GameObject Bullet;
    private bool IsFirering = false;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (IsFirering == false)
        {
            StartCoroutine(Shoot());
            
        }
    }

    IEnumerator Shoot()
    {
        IsFirering = true;
        yield return new WaitForSeconds(2);
        Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        IsFirering = false;
    }

}
