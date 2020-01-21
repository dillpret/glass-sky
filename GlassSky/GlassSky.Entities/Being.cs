namespace GlassSky.Entities
{
	public abstract class Being
	{
		public string DisplayName { get; set; }

		public Environment Environment { get; set; }

		public Brain Brain { get; set; }

		public abstract void Tick();
	}
}
