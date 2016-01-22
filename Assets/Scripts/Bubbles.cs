using UnityEngine;
using System.Collections;

public class Bubbles : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().sortingLayerName = "bubbles";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
