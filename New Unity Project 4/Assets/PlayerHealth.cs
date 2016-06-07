using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	private int _health = 20;
	public int health{get{ return _health; } set{this._health = value;}}
}
