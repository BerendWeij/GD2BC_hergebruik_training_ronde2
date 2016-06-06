using UnityEngine;
using System.Collections;

public class MiniGun : MonoBehaviour, IWeapon
{
                    private Weapon      _weapon;
    [SerializeField]private GameObject  _bullet;
    [SerializeField]private Transform   _muzzle;
                    private int         _maxAmmo;

    void Start()
	{
        _weapon.damage      =   10f;
        _weapon.range       =   100f;
        _weapon.reloadTime  =   3f;
        _weapon.ammo        =   200;
        _weapon.weaponName  =   "Mini Gun";
        _maxAmmo            =   _weapon.ammo;
    }

    public void Shoot()
    {
        if (_weapon.ammo > 0)
        {
            Debug.Log("Shooting: " + _weapon.weaponName);
            GameObject bullet = Instantiate(_bullet, _muzzle.position, Quaternion.identity) as GameObject;
            Bullet bulletInfo = bullet.GetComponent<Bullet>();
            bulletInfo.Range = _weapon.range;
            bulletInfo.Damage = _weapon.damage;
            _weapon.ammo -= 1;
        }
        else
        {
            Debug.Log(_weapon.weaponName + " has to Reload!");
        }
    }

    public IEnumerator Reload()
    {
        Debug.Log("Reloading: " + _weapon.weaponName);
        yield return new WaitForSeconds(_weapon.reloadTime);
        _weapon.ammo = _maxAmmo;
    }
}