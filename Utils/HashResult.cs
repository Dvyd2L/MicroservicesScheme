﻿using Helpers.Interfaces;

namespace Helpers;

public record HashResult(string Hash, byte[] Salt) : IHashResult;
