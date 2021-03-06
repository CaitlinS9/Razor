﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.CodeAnalysis.Host;

namespace Microsoft.CodeAnalysis.Razor
{
    public abstract class RazorIndentationFactsService : ILanguageService
    {
        public abstract int? GetDesiredIndentation(RazorSyntaxTree syntaxTree, int previousLineEnd, Func<int, string> lineProvider, int indentSize, int tabSize);
    }
}
