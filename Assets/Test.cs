using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {

	public GameObject cube;
	public Text text;

	string helloWorld = "Hello World!";
	int counter = 0;

	// Use this for initialization
	void Start () {
		Debug.Log (helloWorld);

		text.text = "Peanut Butter";
	}
	
	// Update is called once per frame
	void Update () {
		counter++;

		Debug.Log (counter);

		float x = cube.transform.position.x;
		float y = cube.transform.position.y;
		cube.transform.position = new Vector3 (x + 0.1f, y + 0.1f, 2);

	}
}
