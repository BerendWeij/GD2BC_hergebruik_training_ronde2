using UnityEngine;
using System.Collections;

public class TowerShoot : MonoBehaviour
{
    [SerializeField]private Transform _bullet;
    [SerializeField]private Transform _muzzle;
    private bool _isShooting = true;
    [SerializeField]private float _shootDelay;
	// Use this for initialization
	void Start()
	{
        StartCoroutine(TowerShooting());
	}
	
	void ShootTower()
	{
        Instantiate(_bullet, _muzzle.position, _muzzle.rotation);
	}

    IEnumerator TowerShooting()
    {
        while (_isShooting)
        {
            ShootTower();
            yield return new WaitForSeconds(_shootDelay);
        }
    }
}