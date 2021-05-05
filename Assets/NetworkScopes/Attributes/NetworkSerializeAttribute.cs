using System;

namespace NetworkScopes
{
	public enum NetworkSerializeType
	{
		/// <summary>
		/// Generates serialization code for public fields, or any fields with the 'SerializeField' attribute.
		/// </summary>
		SerializableFields,
	}

	public class NetworkSerializeAttribute : Attribute
	{
		public NetworkSerializeType serializeType;

		public NetworkSerializeAttribute(NetworkSerializeType serializeType = NetworkSerializeType.SerializableFields)
		{
			this.serializeType = serializeType;
		}
	}
}