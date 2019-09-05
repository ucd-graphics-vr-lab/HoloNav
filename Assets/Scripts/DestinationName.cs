using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationName : MonoBehaviour {

    //public Transform target;
    private string destinyName;
    public GameObject uiControl;

    // Start is called before the first frame update
    void Start()
    {
        GameObject uiControl = GameObject.Find("UI");
    }

    // Update is called once per frame
    void Update()
    {
        UIControl uiScript = uiControl.GetComponent<UIControl>();
        destinyName = uiScript.destinyName;
        this.GetComponent<TextMesh>().text = destinyName;
    }
}
