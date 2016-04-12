using UnityEngine;
using System.Collections;

public class SunRotation : MonoBehaviour {
	void Update () {
		var eulerAngles = transform.localEulerAngles;
		eulerAngles.y += 100 * Time.deltaTime;

		transform.localEulerAngles = eulerAngles;
	}
}
