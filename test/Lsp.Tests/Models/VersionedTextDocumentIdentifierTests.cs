﻿using System;
using FluentAssertions;
using Newtonsoft.Json;
using OmniSharp.Extensions.LanguageServer.Models;
using Xunit;

namespace Lsp.Tests.Models
{
    public class VersionedTextDocumentIdentifierTests
    {
        [Theory, JsonFixture]
        public void SimpleTest(string expected)
        {
            var model = new VersionedTextDocumentIdentifier() {
                Uri = new Uri("file:///abc/123.cs"),
                Version = 12
            };
            var result = Fixture.SerializeObject(model);

            result.Should().Be(expected);

            var deresult = JsonConvert.DeserializeObject<VersionedTextDocumentIdentifier>(expected);
            deresult.ShouldBeEquivalentTo(model);
        }
    }
}
