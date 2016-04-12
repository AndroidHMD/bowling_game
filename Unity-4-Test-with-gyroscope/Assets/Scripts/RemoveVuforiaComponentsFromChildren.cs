using UnityEngine;
using System.Collections;

public class RemoveVuforiaComponentsFromChildren : MonoBehaviour {
	public GameObject targetsParent;

	void Start () {
		if (targetsParent == null) {
			targetsParent = GameObject.Find ("ChildTargets");
		}

		int count = 0;

		foreach (Transform childTransform in targetsParent.transform)
		{
			if (childTransform != transform)
			{
				// childTransform is a child
				var child = childTransform.gameObject;

				var childMaskOutBehaviour = child.GetComponent<Vuforia.MaskOutBehaviour>();
				var childMeshRenderer = child.GetComponent<MeshRenderer>();
				var childMeshFilter = child.GetComponent<MeshFilter>();

				Destroy(childMaskOutBehaviour);
				Destroy(childMeshRenderer);
				Destroy(childMeshFilter);

				++count;
			}
		}

		Debug.Log ("Removed " + count + " MaskOutBehaviours from children");
	}
}