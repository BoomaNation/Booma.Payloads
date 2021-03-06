﻿using Booma.Payloads.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Booma.Payloads.Instance
{
	/// <summary>
	/// Indicates the response result.
	/// </summary>
	public enum PlayerSpawnResponseCode : byte
	{
		/// <summary>
		/// Represents an unknown <see cref="BoomaPayloadMessageType.PlayerSpawnResponse"/> state.
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Represents that the <see cref="BoomaPayloadMessageType.PlayerSpawnRequest"/> was successful.
		/// </summary>
		Success = 1,

		//TODO: Add future potential response results. I can't think of any now
	}
}
