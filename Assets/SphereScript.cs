using UnityEngine;
using System.Collections;

public class SphereScript : MonoBehaviour {

	// Use this for initialization
	public float speed = 4.0f;
	public GameObject gameObject;

	void Start () {
		Vector3 diff = transform.position - gameObject.transform.position;
		diff.Normalize (); //diff(カメラからみた箱の位置)を正規化(長さを位置にする)
		GetComponent<Rigidbody> ().velocity = diff * speed;
	}

	// Update is called once per frame
	void Update () {

	}
}