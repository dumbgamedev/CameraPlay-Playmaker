// DumbGameDev
// Eric Vander Wal


using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Camera Play")]
	[Tooltip("Camera play effect")]
	public class CameraPlayGlitch : FsmStateAction
	{
		
		public FsmInt glitchVersion;
		[HasFloatSlider(0.5f,10f)]
		public FsmFloat effectLength;

		public override void Reset()
		{
			glitchVersion = 1;
			effectLength = 1f;
		}

		public override void OnEnter()
		{

			if(glitchVersion.Value == 1)
			{
				CameraPlay.Glitch(effectLength.Value);
				
			}
			
			
			if(glitchVersion.Value == 2)
			{
				CameraPlay.Glitch2(effectLength.Value);
				
			}
			
			else
			{
				CameraPlay.Glitch3(effectLength.Value);
				
			}
			
			Finish();
			
		}
		
	}
}