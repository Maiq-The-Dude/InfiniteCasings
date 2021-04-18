namespace InfiniteCasings
{
	public class Hooks
	{
		public Hooks()
		{
			Hook();
		}

		public void Dispose()
		{
			Unhook();
		}

		private void Hook()
		{
			On.FistVR.FVRSceneSettings.Start += FVRSceneSettings_Start;
		}

		private void Unhook()
		{
			On.FistVR.FVRSceneSettings.Start -= FVRSceneSettings_Start;
		}

		private void FVRSceneSettings_Start(On.FistVR.FVRSceneSettings.orig_Start orig, FistVR.FVRSceneSettings self)
		{
			orig(self);

			self.ForcesCasingDespawn = false;
		}
	}	
}
