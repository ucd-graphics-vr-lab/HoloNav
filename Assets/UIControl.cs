using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour {
    public GameObject openingScreen;
    private void Start()
    {
        openingScreen = GameObject.Find("OpeningScreen");
    }
    public void setDestination()
    {
        openingScreen.SetActive(false);
    }
}
