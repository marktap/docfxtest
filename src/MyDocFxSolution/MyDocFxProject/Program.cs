namespace MyDocFxProject
{
	/// <summary>
	/// My class Program summary v2
	/// </summary>
	/// 
	/// <remarks>
	/// My class Program remarks v2
	/// </remarks>
	/// 
	public class Program
	{
		/// <summary>
		/// My Main method summary v2
		/// </summary>
		/// 
		/// <remarks>
		/// My Main method remarks v2
		/// </remarks>
		/// 
		/// <param name="args">Command line arguments</param>
		public static void Main(string[] args)
		{
			System.Console.WriteLine("Hello: " + Add(1, 2));
		}

		/**
		 * 
		 * <summary>
		 * My Add summary
		 * </summary>
		 * 
		 * <param name="a">addend 1</param>
		 * <param name="b">addend 2</param>
		 * <returns>sum of a and b</returns>
		 * 
		 **/
		public static int Add(int a, int b)
		{
			return a + b;
		}
	}
}