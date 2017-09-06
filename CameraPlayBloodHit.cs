// DumbGameDev
// Eric Vander Wal

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Camera Play")]
	[Tooltip("Camera play effect")]
	public class CameraPlayBloodHit : FsmStateAction
	{
		
		public FsmBool customize;
		
		[ActionSection("Customize")]
		public FsmColor color;
		public FsmFloat time;
		public FsmFloat distance;
		
		
		
		public override void Reset()
		{
			customize = false;
			color = Color.red;
			time = 1f;
			distance = 1f;
		}

		public override void OnEnter()
		{

			if(!customize.Value)
			{
				CameraPlay.BloodHit();
				
			}

			else
			{
				CameraPlay.BloodHit(color.Value, time.Value, distance.Value);
				
			}

			Finish();
			
		}
		
	}
}