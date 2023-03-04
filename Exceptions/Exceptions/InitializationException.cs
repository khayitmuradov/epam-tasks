﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Exceptions;

public class InitializationException : Exception
{
	public InitializationException() { }
	public InitializationException(string message) : base(message) { }
	public InitializationException(string message, Exception inner) : base(message, inner) { }
}
