using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigate : MonoBehaviour {
    public GameObject mainCamera;
    public GameObject theUIControl;

	// Use this for initialization
	void Start () {
        GameObject mainCamera = GameObject.Find("MixedRealityCamera");
        GameObject theUIControl = GameObject.Find("UI");
        UIControl uiControl = theUIControl.GetComponent<UIControl>();
    }
	
	// Update is called once per frame
	void Update () {
        
        //uiControl.destiny.transform;
	}
}
