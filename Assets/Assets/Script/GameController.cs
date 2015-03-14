using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	OVRPose pose;
	private int count;
	// Use this for initialization
	void Start () {
		pose = OVRManager.display.GetHeadPose();
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = pose.position;
		//Debug.Log (position.x);
	}

	//fixed update
	void  FixedUpdate () {
		//make_ball_object_by_position
		count++;
		//shot the ball 1/100loop
		if (count % 100 == 0)  {
			Ball ball = BallManager.make_ball_object_by_position (new Vector3(0,3,0));
			ball.random_shoot();
		}
	}
}
