using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour {

    public GameObject plane;
    public GameObject openingScreen;
    public GameObject journeyScreen;
    public GameObject debugObjects;
    public GameObject pageList;
    public GameObject aContent, bContent, cContent, dContent, eContent, backButton;

    // Use this for initialization
    void Start () {
        plane = GameObject.Find("Plane");
        openingScreen = GameObject.Find("OpeningScreen");
        journeyScreen = GameObject.Find("JourneyScreen");
        debugObjects = GameObject.Find("DebugObjects");
        pageList = GameObject.Find("Pages");
        aContent = GameObject.Find("aContent");
        bContent = GameObject.Find("bContent");
        cContent = GameObject.Find("cContent");
        dContent = GameObject.Find("dContent");
        eContent = GameObject.Find("eContent");
        backButton = GameObject.Find("Back");
        plane.gameObject.active = true;
        openingScreen.gameObject.active = true;
        pageList.gameObject.active = false;
        aContent.gameObject.active = false;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;
        journeyScreen.gameObject.active = false;
        debugObjects.gameObject.active = false;
	}

    public void setDestination()
    {
        openingScreen.gameObject.active = false;
        pageList.gameObject.active = true;
        aContent.gameObject.active = true;

    }
    public void debugMode()
    {
        openingScreen.gameObject.active = false;
        debugObjects.gameObject.active = true;
        backButton.gameObject.active = true;
    }
    public void backUp()
    {
        openingScreen.active = true;
        aContent.gameObject.active = false;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;
        pageList.gameObject.active = false;
        journeyScreen.gameObject.active = false;
        debugObjects.gameObject.active = false;
    }
    public void aCon()
    {
        aContent.gameObject.active = true;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;

    }
    public void bCon()
    {
        bContent.gameObject.active = true;
        aContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;

    }
    public void cCon()
    {
        cContent.gameObject.active = true;
        bContent.gameObject.active = false;
        aContent.gameObject.active = false;
        dContent.gameObject.active = false;
        eContent.gameObject.active = false;

    }
    public void dCon()
    {
        dContent.gameObject.active = true;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        aContent.gameObject.active = false;
        eContent.gameObject.active = false;

    }
    public void eCon()
    {
        eContent.gameObject.active = true;
        bContent.gameObject.active = false;
        cContent.gameObject.active = false;
        dContent.gameObject.active = false;
        aContent.gameObject.active = false;

    }
}
