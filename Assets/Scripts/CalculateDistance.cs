using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateDistance : MonoBehaviour {

    //public Transform target;
    private GameObject mainCamera;
    private GameObject Cursor;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("MixedRealityCamera");
        Cursor = GameObject.Find("DefaultCursor");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 heading = Cursor.transform.position - mainCamera.transform.position;
        float distance = Vector3.Dot(heading, mainCamera.transform.forward);
        distance = (float)System.Math.Round(distance, 2);
        Debug.Log(distance);
        Debug.Log(mainCamera.transform.position);
    }
}
