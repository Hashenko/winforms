﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.Office;

/// <summary>
///  MSO Component registration advise flags <see cref="msocstate" />
/// </summary>
[Flags]
internal enum msocadvf : uint
{
    Modal = 1,
    RedrawOff = 2,
    WarningsOff = 4,
    Recording = 8
}
