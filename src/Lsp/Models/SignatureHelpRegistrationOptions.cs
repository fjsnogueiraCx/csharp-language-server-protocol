﻿namespace OmniSharp.Extensions.LanguageServer.Models
{
    public class SignatureHelpRegistrationOptions : TextDocumentRegistrationOptions, ISignatureHelpOptions
    {
        /// <summary>
        /// The characters that trigger signature help
        /// automatically.
        /// </summary>
        public Container<string> TriggerCharacters { get; set; }
    }
}