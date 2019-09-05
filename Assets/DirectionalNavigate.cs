using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalNavigate : MonoBehaviour {

    public Transform destiny;
    public GameObject uiControl;

    // Use this for initialization
    void Start () {
        GameObject uiControl = GameObject.Find("UI");
    }
	
	// Update is called once per frame
	void Update () {
        UIControl uiScript = uiControl.GetComponent<UIControl>();
        destiny = uiScript.destiny.transform;
        this.transform.LookAt(destiny);
    }
}
