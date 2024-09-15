﻿using System;

namespace Todoit.Core.ApiClients;

public class HttpException : Exception
{
	public HttpException() : base() { }

	public HttpException(string message) : base(message) { }

	public HttpException(string message, Exception innerException) : base(message, innerException) { }

	public HttpException(int statusCode)
	{
		StatusCode = statusCode;
	}

	public HttpException(int statusCode, string message) : this(message)
	{
		StatusCode = statusCode;
	}

	public int StatusCode { get; set; }
}
