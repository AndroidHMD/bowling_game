using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardboardTriggerEvent : MonoBehaviour {

	public Cardboard myCardboard;
	private GameObject projectile;
	private List<GameObject> myBowlingBalls = new List<GameObject>();

	void Start() {
		// Disable screen dimming:
		Screen.sleepTimeout = SleepTimeout.NeverSleep;

		projectile = GameObject.FindGameObjectWithTag("projectile");
	} 

	void Update () {
		//True for only one frame
		if(myCardboard.Triggered) {
			Debug.Log("Button was clicked");
			 sendNewBall();
		}
		foreach (GameObject ball in myBowlingBalls) {
			if (ball.transform.position.magnitude < 60) {
				ball.transform.position += ball.transform.forward * 5;
			} 
			else {
				myBowlingBalls.Remove (ball);
			}
		}
	}

	void sendNewBall(){
		GameObject player = GameObject.FindGameObjectWithTag("player");
		GameObject newBall = Instantiate (projectile) as GameObject;
		newBall.transform.position = player.transform.position;
		newBall.transform.rotation = player.transform.rotation;
		myBowlingBalls.Add (newBall);

	}
}

