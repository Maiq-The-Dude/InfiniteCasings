using Deli.Setup;

namespace InfiniteCasings
{
	public class InfiniteCasings : DeliBehaviour
	{
		private readonly Hooks _hooks;

		public InfiniteCasings()
		{
			_hooks = new Hooks();
		}

		private void OnDestroy()
		{
			_hooks?.Dispose();
		}
	}
}