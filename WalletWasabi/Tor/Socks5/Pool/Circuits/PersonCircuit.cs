using WalletWasabi.Crypto.Randomness;

namespace WalletWasabi.Tor.Socks5.Pool.Circuits
{
	/// <summary>
	/// Tor circuit for a set of HTTP requests where we don't mind that
	/// HTTP requests can be identified as belonging to a single entity (i.e. user).
	/// </summary>
	/// <remarks>Useful for Alices and Bobs.</remarks>
	public class PersonCircuit : ICircuit
	{
		public PersonCircuit()
		{
			Name = RandomString.CapitalAlphaNumeric(21);
		}
		public string Name { get; }

		/// <inheritdoc/>
		public override string ToString()
		{
			return $"[{nameof(PersonCircuit)}: {Name}]";
		}
	}
}
