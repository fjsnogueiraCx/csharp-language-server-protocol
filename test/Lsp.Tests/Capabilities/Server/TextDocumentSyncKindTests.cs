﻿using System;
using FluentAssertions;
using Newtonsoft.Json;
using OmniSharp.Extensions.LanguageServer.Capabilities.Server;
using Xunit;

namespace Lsp.Tests.Capabilities.Server
{
    public class TextDocumentSyncKindTests
    {
        [Theory, JsonFixture]
        public void SimpleTest(string expected)
        {
            var model = TextDocumentSyncKind.Full;
            var result = Fixture.SerializeObject(model);

            result.Should().Be(expected);

            var deresult = JsonConvert.DeserializeObject<TextDocumentSyncKind>(expected);
            deresult.ShouldBeEquivalentTo(model);
        }
    }
}
