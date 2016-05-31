using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class PlayerWeapons : MonoBehaviour
{
    private IWeapon[] _weapons;
    private IWeapon _currentWeapon;
    public IWeapon CurrentWeapon
    {
        get
        {
            return _currentWeapon;
        }
    }

	// Use this for initialization
	void Start()
	{
        _weapons = GetComponents<IWeapon>();
        Debug.Log(_weapons.Length);
        _currentWeapon = _weapons[0];
	}

    public void SwitchWeapon()
    {
        _currentWeapon = _weapons[Random.Range(0, _weapons.Length)];
    }
}