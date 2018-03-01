using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameJam : MonoBehaviour {
    //string message = "Hello World! I know this stuff";
    int counter = 0;

    public GameObject cube;
    public Text text;

	// Use this for initialization
	void Start () {
        //Debug.Log(message);
        text.text= "peanut butter";
	}

    // Update is called once per frame
    void Update()
    {
        counter++;
        Debug.Log(counter);

        //changes the cube position to those axis values
        //vector3 uses the x, y and z axis
        //cube.transform.position = new Vector3(2,2,2);

        //this will allow you to find the x-axis only
        float x = cube.transform.position.x;
        cube.transform.position = new Vector3(x+2,2,2);
    }
}
