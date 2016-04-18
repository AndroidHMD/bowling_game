using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardboardTriggerEvent : MonoBehaviour {

	public Cardboard myCardboard;
	public GameObject projectile;
	//private List<GameObject> myBowlingBalls = new List<GameObject>();
    private float rollingForce = 500;

	void Start() {

	} 

	void Update () {
		//True for only one frame
		if(myCardboard.Triggered) {
			Debug.Log("Button was clicked");

			GameObject tempBall;
			//tempBall = Instantiate (projectile, myCardboard.transform.position, Cardboard.SDK.HeadPose.Orientation) as GameObject;
			tempBall = Instantiate (projectile, transform.position, transform.rotation) as GameObject;

			Rigidbody tempBody;
			tempBody = tempBall.GetComponent<Rigidbody> ();

			float move = rollingForce * Time.deltaTime;
			tempBody.AddForce (tempBall.transform.forward * rollingForce);

			//Destroy ball after 10 seconds
			Destroy (tempBall, 8);

		}


    }

}

