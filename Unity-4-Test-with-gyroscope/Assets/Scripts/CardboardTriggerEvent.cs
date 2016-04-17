using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardboardTriggerEvent : MonoBehaviour {

	public Cardboard myCardboard;
	public GameObject projectile;
	private List<GameObject> myBowlingBalls = new List<GameObject>();
    private float rollingVelocity = 10;

	void Start() {

	} 

	void Update () {
		//True for only one frame
		if(myCardboard.Triggered) {
			Debug.Log("Button was clicked");
			 sendNewBall();
		}

		foreach (GameObject ball in myBowlingBalls) {
            float dis = Vector3.Distance(myCardboard.transform.position, ball.transform.position);
            if (dis < 60) {
                float move = rollingVelocity * Time.deltaTime;
                ball.transform.Translate(transform.forward * move);
                
			} 
			else {
				myBowlingBalls.Remove (ball);
                Destroy(gameObject);
			}
		}

    }

	void sendNewBall(){
        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        //GameObject newBall = Instantiate (projectile) as GameObject;
        //newBall.transform.position = myCardboard.transform.position;
        //newBall.transform.rotation = Cardboard.SDK.HeadPose.Orientation;

        Instantiate(projectile, myCardboard.transform.position, Cardboard.SDK.HeadPose.Orientation);
        myBowlingBalls.Add (projectile);

	}
}
