﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.VisualStudio.Text;

namespace Microsoft.VisualStudio.LanguageServices.Razor
{
    // ----------------------------------------------------------------------------------------------------
    // NOTE: This is only here for VisualStudio binary compatibility. This type should not be used; instead
    // use the Microsoft.CodeAnalysis.Razor variant from Microsoft.CodeAnalysis.Razor.Workspaces
    // ----------------------------------------------------------------------------------------------------
    public abstract class RazorSyntaxFactsService
    {
        public abstract IReadOnlyList<ClassifiedSpan> GetClassifiedSpans(RazorSyntaxTree syntaxTree);

        public abstract IReadOnlyList<TagHelperSpan> GetTagHelperSpans(RazorSyntaxTree syntaxTree);

        public abstract int? GetDesiredIndentation(RazorSyntaxTree syntaxTree, ITextSnapshot syntaxTreeSnapshot, ITextSnapshotLine line, int indentSize, int tabSize);
    }
}
