using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalNavigate : MonoBehaviour {

    public Transform destinyNav;
    public GameObject uiControl;
    public Vector3 originalArrow;
    
    // Use this for initialization
    void Start () {
        GameObject uiControl = GameObject.Find("UI");
        destinyNav = null;
        
    }
	
	// Update is called once per frame
	void Update () {
        UIControl uiScript = uiControl.GetComponent<UIControl>();
        //destiny = new Vector3(this.transform.position.x, uiScript.destiny.transform.position.y, this.transform.position.z);
        destinyNav = uiScript.destiny.transform;
        Vector3 originalArrow = this.transform.eulerAngles;
        this.transform.LookAt(destinyNav.transform.position, -Vector3.up);
        Vector3 newArrow = this.transform.eulerAngles;
        this.transform.eulerAngles = new Vector3(originalArrow.x, newArrow.y, originalArrow.z);
    }
}
