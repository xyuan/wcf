// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.ComponentModel;

namespace System.ServiceModel.Security.Tokens
{
    public enum X509KeyIdentifierClauseType
    {
        Any = 0,
        Thumbprint = 1,
        IssuerSerial = 2,
        SubjectKeyIdentifier = 3,
        RawDataKeyIdentifier = 4
    }

    internal static class X509SecurityTokenReferenceStyleHelper
    {
        public static bool IsDefined(X509KeyIdentifierClauseType value)
        {
            return (value == X509KeyIdentifierClauseType.Any
                || value == X509KeyIdentifierClauseType.IssuerSerial
                || value == X509KeyIdentifierClauseType.SubjectKeyIdentifier
                || value == X509KeyIdentifierClauseType.Thumbprint
                || value == X509KeyIdentifierClauseType.RawDataKeyIdentifier);
        }

        public static void Validate(X509KeyIdentifierClauseType value)
        {
            if (!IsDefined(value))
            {
                throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new InvalidEnumArgumentException("value", (int)value,
                    typeof(X509KeyIdentifierClauseType)));
            }
        }
    }
}
