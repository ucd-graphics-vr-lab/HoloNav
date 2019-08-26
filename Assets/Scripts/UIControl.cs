using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour {

    public GameObject openingScreen;
    public GameObject destinationList;

    private void Start()
    {
        openingScreen = GameObject.Find("OpeningScreen");
        destinationList = GameObject.Find("DestinationList");
    }

    public void setDestination()
    {
        openingScreen.gameObject.active = false;
        destinationList.gameObject.active = true;
    }	
}
