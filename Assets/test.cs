using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
	static float ie=-0.01f;
	// Use this for initialization
	void Start () {
		transform.position = new Vector3(0,1,1);
	}
	
	// Update is called once per frame
	void Update () {
		ie=ie*(-1);
		for (int i = 0;i<10; i++){
			transform.position = new Vector3(0,i*ie,0);
		}
	}
}
