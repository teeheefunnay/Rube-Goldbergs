using UnityEngine;
using System.Collections;

public class CameraTriggerClass : MonoBehaviour {

	public int camNumber;

	public cameracontrollerclass controller;

	void OnTriggerEnter(Collider other){

		controller.DeactivateCameras();
		controller.activateCamera(camNumber);

	}
}
	