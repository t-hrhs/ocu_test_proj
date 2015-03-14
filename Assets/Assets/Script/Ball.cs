using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private float base_y_v = 0.5f;
	private float base_z_v = -2;
	private float out_z_position = -5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.z <= this.out_z_position) {
			Destroy(this.gameObject);
		}
	}

	public void random_shoot()  {
		float random_vx_postion =  Random.Range(-0.1f,0.1f);
		this.shoot (random_vx_postion );
	}

	public void shoot (float vx) {
		Vector3 temp = new Vector3 (vx,this.base_y_v,this.base_z_v);
		Vector3 basic_vector = temp.normalized;
		float random_speed_abs = Random.Range (5,7) * temp.magnitude;

		this.GetComponent<Rigidbody>().velocity = new Vector3 (
			basic_vector.x * random_speed_abs,
			this.base_y_v,
			basic_vector.z * random_speed_abs
		);
	}
}
