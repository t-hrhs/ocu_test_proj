using UnityEngine;
using System;
using System.Collections;

public class BallManager {
	private static String[] ball_prefabs = {"Prefab/Ball"};
	// static  method
	//  make ball_objects
	public static Ball make_ball_object_by_position (Vector3 position)  {
		GameObject ball_obj = GameObject.Instantiate (
			Resources.Load (ball_prefabs[0]),
			position,
			Quaternion.identity
		) as GameObject;
		return ball_obj.GetComponent<Ball> ();
	}
	/*public static GameObject make_ball_objects ()  {
		// to be implemented
	}*/
}
