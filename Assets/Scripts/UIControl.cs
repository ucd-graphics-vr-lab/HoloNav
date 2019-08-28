using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour {

    public GameObject openingScreen;
    public GameObject destinationLists;
    public GameObject debugobjects;

    private void Start()
    {
        openingScreen = GameObject.Find("OpeningScreen");
        destinationLists = GameObject.Find("DestinationList");
    }

    public void setDestination()
    {
        openingScreen.gameObject.active = false;
        destinationLists.gameObject.active = true;
    }	
    public void debugMode()
    {
        openingScreen.gameObject.active = false;
        debugobjects.gameObject.active = true;
    }
}
