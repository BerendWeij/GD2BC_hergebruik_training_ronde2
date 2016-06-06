using UnityEngine;
using System.Collections;

public class TowerShoot : MonoBehaviour
{
    [SerializeField]private GameObject _bullet;
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
        GameObject bullet = Instantiate(_bullet, _muzzle.position, _muzzle.rotation) as GameObject;
        Bullet bulletInfo = bullet.GetComponent<Bullet>();
        bulletInfo.Range = 50f;
        bulletInfo.Damage = 5f;
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