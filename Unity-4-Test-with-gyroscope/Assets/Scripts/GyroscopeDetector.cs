using UnityEngine;
using System.Collections;

public class GyroscopeDetector : MonoBehaviour {
	public CardboardHead head;
	void Start () {
		if (Input.gyro.enabled) {
			head.trackRotation = true;
		} else {
			head.trackRotation = false;
		}
	}
}
