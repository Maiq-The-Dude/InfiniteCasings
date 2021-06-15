using BepInEx;

namespace InfiniteCasings
{
	[BepInPlugin("maiq.InfiniteCasings", "InfiniteCasings", "1.1.0")]
	[BepInProcess("h3vr.exe")]
	public class InfiniteCasings : BaseUnityPlugin
	{
		public InfiniteCasings()
		{
			Hook();
		}

		private void OnDestroy()
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