using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateDistance : MonoBehaviour {

    //public Transform target;
    private GameObject mainCamera;
    public GameObject destiny;
    public GameObject uiControl;
    UIControl uiScript;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("MixedRealityCamera");
        GameObject uiControl = GameObject.Find("UI");
        uiScript = uiControl.GetComponent<UIControl>();
    }

    // Update is called once per frame
    void Update()
    {
        destiny = uiScript.destiny;
        Vector3 heading = destiny.transform.position - mainCamera.transform.position;
        float distance = Vector3.Dot(heading, mainCamera.transform.forward);
        distance = (float)System.Math.Round(distance, 2);
        this.GetComponent<TextMesh>().text = distance.ToString() + "m";
    }
}