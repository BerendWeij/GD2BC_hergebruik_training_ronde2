using UnityEngine;
using System.Collections;

public static class ArrayExtension {
	public static T GetRandomInArray<T>(this T[] array) {
		int temp = Random.Range (0, array.Length);
		return array [temp];
	}
}
