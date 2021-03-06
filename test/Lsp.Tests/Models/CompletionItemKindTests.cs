﻿using System;
using FluentAssertions;
using Newtonsoft.Json;
using OmniSharp.Extensions.LanguageServer.Models;
using Xunit;

namespace Lsp.Tests.Models
{
    public class CompletionItemKindTests
    {
        [Theory, JsonFixture]
        public void SimpleTest(string expected)
        {
            var model = CompletionItemKind.Color;
            var result = Fixture.SerializeObject(model);

            result.Should().Be(expected);

            var deresult = JsonConvert.DeserializeObject<CompletionItemKind>(expected);
            deresult.ShouldBeEquivalentTo(model);
        }
    }
}
