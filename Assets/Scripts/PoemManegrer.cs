using UnityEngine;
using System.Collections;

public class PoemManegrer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Hello World");
		GetComponent<TextMesh> ().text = "Grand Canyon\nby: SGW\nBuilt with patience of endless time\nYears erode and shapes define\nLayers yield their counted age\nEyes can see but cannot gauge\nStand agape with awe inspired\nImage reads of life transpired\nCliffs reach out to touch the sky\nPaths lead down where rivers lie\nColors, shapes and shadows meld\nHere, a place forever held\nWalk away yet never part\nBody leaves but not the heart";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
