using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeNear : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
            Camera.current.nearClipPlane = 0.4f;

    }
}
