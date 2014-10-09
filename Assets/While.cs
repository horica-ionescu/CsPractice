using UnityEngine;
using System.Collections;

public class While : MonoBehaviour {

	int cupsInTheSink = 4;

	//Debug.Log ("Hello!");

	// Use this for initialization
	void Start () 
	{
		if (cupsInTheSink == 4)
			Debug.Log ("Am I getting a hang of this?");

		while (cupsInTheSink > 0) 
		{
			Debug.Log ("I've washed a cup!");
			cupsInTheSink--;
		}
		if (cupsInTheSink == 0)
			Debug.Log ("Maybe i can do this");
	}

	/*
	// Update is called once per frame
	void Update () {
	
	}
	*/
}
