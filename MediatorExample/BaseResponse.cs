using System;
namespace MediatorExample
{
	public abstract class BaseResponse
	{
		public bool IsSuccess { get; set; }

		public IDictionary<string, string[]>? ValidationErrors { get; set; }

		public string? Message { get; set; }
	}
}

