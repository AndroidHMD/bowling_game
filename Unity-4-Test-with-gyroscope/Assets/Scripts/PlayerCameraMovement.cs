using UnityEngine;
using System.Collections;

public class PlayerCameraMovement : MonoBehaviour {
	public Transform cameraTransform;
	/*
	public PhotonView photonView;
	
	static int DisableChildMeshRenderers(GameObject parent)
	{
		int disabledCount = 0;
		
		foreach (Transform childTransform in parent.transform) {
			if (childTransform == parent.transform) {
				continue;
			}
			
			childTransform.gameObject.GetComponent<MeshRenderer>().enabled = false;
			++disabledCount;
			
			disabledCount += DisableChildMeshRenderers(childTransform.gameObject);
		}
		
		return disabledCount;
	}
	
	void Start () {
		cameraTransform = GameObject.FindGameObjectWithTag("CameraAR").transform;
	}
	
	void Update () {
		if (photonView.isMine) {
			int disabledCount = DisableChildMeshRenderers(gameObject);
			
			transform.position = cameraTransform.position;
			transform.rotation = cameraTransform.rotation;
		} else {
			gameObject.GetComponent<MeshRenderer>().enabled = true;
		}
	}
	*/
}
