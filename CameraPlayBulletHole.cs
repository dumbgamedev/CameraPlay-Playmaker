// DumbGameDev
// Eric Vander Wal

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Camera Play")]
	[Tooltip("Camera play effect")]
	public class CameraPlayBulletHole : FsmStateAction
	{
		
		public FsmBool customize;
		
		[ActionSection("Customize")]
		[HasFloatSlider(0,1)]
		public FsmFloat floatX;
		[HasFloatSlider(0,1)]
		public FsmFloat floatY;
		public FsmFloat size;
		public FsmFloat time;
		
		public override void Reset()
		{
			customize = false;
			floatX = 0.5f;
			floatY = 0.5f;
			size = 1f;
			time = 1f;
		}

		public override void OnEnter()
		{

			if(!customize.Value)
			{
				CameraPlay.BulletHole();
				
			}

			else
			{
				CameraPlay.BulletHole(floatX.Value, floatY.Value, time.Value, size.Value);
				
			}

			Finish();
			
		}
		
	}
}