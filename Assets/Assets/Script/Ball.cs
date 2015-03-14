using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void random_shoot()  {
		float random_vx_postion =  Random.Range(-5,5);
		this.shoot (random_vx_postion );
	}

	public void shoot (float vx) {
		this.GetComponent<Rigidbody>().velocity = new Vector3 (vx,4,-2);
	}
}
