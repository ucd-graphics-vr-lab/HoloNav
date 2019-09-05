using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity;

public class AnchorScript : MonoBehaviour {

    public WorldAnchorManager worldAnchorManager;

	// Use this for initialization
	void Start () {
        AnchorIt();
	}
	
	public void AnchorIt()
    {
        worldAnchorManager.AttachAnchor(this.gameObject);
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    public void ReleaseAnchor()
    {
        worldAnchorManager.RemoveAnchor(this.gameObject);
        this.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}
