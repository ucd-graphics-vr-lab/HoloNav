using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationName : MonoBehaviour {

    private string destinyName;
    public GameObject uiControl;

	// Use this for initialization
	void Start () {
        GameObject uiControl = GameObject.Find("MixedRealityCamera");
	}
	
	// Update is called once per frame
	void Update () {
        UIControl uiScript = uiControl.GetComponent<UIControl>();
        destinyName = uiScript.destinyName;
        this.GetComponent<TextMesh>().text = destinyName;
	}
}
