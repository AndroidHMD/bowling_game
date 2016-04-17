using UnityEngine;

namespace Vuforia
{
	public class LostTracking : MonoBehaviour
	{
		public Cardboard myCardboard;
		public Camera myCamera;


		#region PRIVATE_MEMBER_VARIABLES

		private Transform lastTransform;

		#endregion // PRIVATE_MEMBER_VARIABLES

		void update ()
		{
			var rot = Cardboard.SDK.HeadPose.Orientation;
			if (myCardboard.TrackingFound) 
			{
				lastTransform = myCardboard.transform;
				//lastTransform = myCamera.transform;

				Debug.Log("FoundTracking");
			}
			else //!myCardboard.TrackingFound
			{
				transform.position = lastTransform.position;
				transform.rotation = rot;

				Debug.Log("LostTracking");
			}

		}
	}
}

