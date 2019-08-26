using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInitializer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject plane = GameObject.Find("Plane");
        GameObject openingScreen = GameObject.Find("OpeningScreen");
        GameObject destinationList = GameObject.Find("DestinationList");
        GameObject journeyScreen = GameObject.Find("JourneyScreen");
        plane.gameObject.active = true;
        openingScreen.gameObject.active = true;
        destinationList.gameObject.active = false;
        journeyScreen.gameObject.active = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
