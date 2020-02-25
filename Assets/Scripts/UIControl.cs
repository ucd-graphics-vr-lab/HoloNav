using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour {

    public GameObject plane, openingScreen, journeyScreen, destinationList, backButton, spatialMapping, anchorOne, anchorTwo, anchorThree, anchorFour, anchorFive, destiny = null, mainCamera, wayArrow, turnAround;
    public string destinyName;

    // Use this for initialization
    void Start () {
        plane = GameObject.Find("Plane");
        openingScreen = GameObject.Find("OpeningScreen");
        destinationList = GameObject.Find("DestinationList");
        journeyScreen = GameObject.Find("JourneyScreen");
        backButton = GameObject.Find("Back");
        anchorOne = GameObject.Find("AnchorOne");
        anchorTwo = GameObject.Find("AnchorTwo");
        anchorThree = GameObject.Find("AnchorThree");
        anchorFour = GameObject.Find("AnchorFour");
        anchorFive = GameObject.Find("AnchorFive");
        wayArrow = GameObject.Find("Waypoint Arrow");
        turnAround = GameObject.Find("TurnAround");
        mainCamera = GameObject.Find("MixedRealityCamera");
        spatialMapping = GameObject.Find("SpatialMapping");
        plane.gameObject.active = true;
        openingScreen.gameObject.active = true;
        spatialMapping.gameObject.active = false;
        destinationList.gameObject.active = false;
        journeyScreen.gameObject.active = false;
        anchorOne.gameObject.active = false;
        anchorTwo.gameObject.active = false;
        anchorThree.gameObject.active = false;
        anchorFour.gameObject.active = false;
        anchorFive.gameObject.active = false;
        wayArrow.gameObject.active = false;
        turnAround.gameObject.active = false;        
    }
	
	public void setDestination()
    {
        openingScreen.gameObject.active = false;
        destinationList.gameObject.active = true;
        backButton.gameObject.active = true;
    }
    public void backUp()
    {
        plane.gameObject.active = true;
        openingScreen.active = true;
        destinationList.gameObject.active = false;
        journeyScreen.gameObject.active = false;
        spatialMapping.gameObject.active = false;
        anchorOne.gameObject.active = false;
        anchorTwo.gameObject.active = false;
        anchorThree.gameObject.active = false;
        anchorFour.gameObject.active = false;
        anchorFive.gameObject.active = false;
    }
    public void settings()
    {
        plane.gameObject.active = false;
        openingScreen.gameObject.active = false;
        spatialMapping.gameObject.active = true;
        backButton.gameObject.active = true;
        anchorOne.gameObject.active = true;
        anchorTwo.gameObject.active = true;
        anchorThree.gameObject.active = true;
        anchorFour.gameObject.active = true;
        anchorFive.gameObject.active = true;
    }
    public void AnchorOne()
    {
        plane.gameObject.active = false;
        openingScreen.gameObject.active = false;
        destinationList.gameObject.active = false;
        journeyScreen.gameObject.active = true;
        anchorOne.gameObject.active = true;
        wayArrow.gameObject.active = true;
        destiny = anchorOne;
        destinyName = "Anchor One";
    }
    public void AnchorTwo()
    {
        plane.gameObject.active = false;
        openingScreen.gameObject.active = false;
        destinationList.gameObject.active = false;
        journeyScreen.gameObject.active = true;
        anchorTwo.gameObject.active = true;
        wayArrow.gameObject.active = true;
        destiny = anchorTwo;
        destinyName = "Anchor Two";
    }
    public void AnchorThree()
    {
        plane.gameObject.active = false;
        openingScreen.gameObject.active = false;
        destinationList.gameObject.active = false;
        journeyScreen.gameObject.active = true;
        anchorThree.gameObject.active = true;
        wayArrow.gameObject.active = true;
        destiny = anchorThree;
        destinyName = "Anchor Three";
    }
    public void AnchorFour()
    {
        plane.gameObject.active = false;
        openingScreen.gameObject.active = false;
        destinationList.gameObject.active = false;
        journeyScreen.gameObject.active = true;
        anchorFour.gameObject.active = true;
        wayArrow.gameObject.active = true;
        destiny = anchorFour;
        destinyName = "Anchor Four";
    }
    public void AnchorFive()
    {
        plane.gameObject.active = false;
        openingScreen.gameObject.active = false;
        destinationList.gameObject.active = false;
        journeyScreen.gameObject.active = true;
        anchorFive.gameObject.active = true;
        wayArrow.gameObject.active = true;
        destiny = anchorFive;
        destinyName = "Anchor Five";
    }
    public void exitNavigation()
    {
        plane.gameObject.active = true;
        openingScreen.gameObject.active = true;
        anchorOne.gameObject.active = false;
        anchorTwo.gameObject.active = false;
        anchorThree.gameObject.active = false;
        anchorFour.gameObject.active = false;
        anchorFive.gameObject.active = false;
        journeyScreen.gameObject.active = false;
        wayArrow.gameObject.active = false;
    }
}
