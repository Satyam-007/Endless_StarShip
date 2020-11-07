using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroll : MonoBehaviour {

	public GameObject protag12;

	private Vector3 offset;

	void Start () {
		offset = transform.position - protag12.transform.position;
		
	}
	
	void Update () {
		transform.position = protag12.transform.position + offset;
		
	}
}
