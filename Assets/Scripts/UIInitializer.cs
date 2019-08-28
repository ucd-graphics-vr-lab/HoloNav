using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInitializer : MonoBehaviour {

    public GameObject plane;
    public GameObject openingScreen;
    public GameObject destinationList;
    public GameObject journeyScreen;
    public GameObject debugObjects;

    // Use this for initialization
    void Start () {
        plane = GameObject.Find("Plane");
        openingScreen = GameObject.Find("OpeningScreen");
        destinationList = GameObject.Find("DestinationList");
        journeyScreen = GameObject.Find("JourneyScreen");
        debugObjects = GameObject.Find("DebugObjects");
        plane.gameObject.active = true;
        openingScreen.gameObject.active = true;
        destinationList.gameObject.active = false;
        journeyScreen.gameObject.active = false;
        debugObjects.gameObject.active = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
