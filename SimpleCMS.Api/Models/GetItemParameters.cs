﻿using Newtonsoft.Json;

namespace SimpleCMS.Api.Models {

	/// <summary>
	/// The main GetItemParameters class
	/// </summary>
	/// <remarks>
	/// Is used to wrap query parameters of some /api/entity requests
	/// </remarks>
	public class GetItemParameters {

		/// <summary>
		/// Entity name or SQL table table
		/// </summary>
		/// <value></value>
		[JsonProperty]
		public string Entity { get; set; }

		/// <summary>
		/// Unique Id of entity item
		/// </summary>
		/// <value></value>
		[JsonProperty]
		public int Id { get; set; }

	}

}
