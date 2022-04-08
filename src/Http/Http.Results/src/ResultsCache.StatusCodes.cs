// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// <auto-generated />

#nullable enable

using System.CodeDom.Compiler;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Microsoft.AspNetCore.Http;

[GeneratedCode("TextTemplatingFileGenerator", "")]
internal partial class ResultsCache
{
    private static Status? _status101SwitchingProtocols;
    private static Status? _status102Processing;
    private static Status? _status200OK;
    private static Status? _status201Created;
    private static Status? _status202Accepted;
    private static Status? _status203NonAuthoritative;
    private static Status? _status204NoContent;
    private static Status? _status205ResetContent;
    private static Status? _status206PartialContent;
    private static Status? _status207MultiStatus;
    private static Status? _status208AlreadyReported;
    private static Status? _status226IMUsed;
    private static Status? _status300MultipleChoices;
    private static Status? _status301MovedPermanently;
    private static Status? _status302Found;
    private static Status? _status303SeeOther;
    private static Status? _status304NotModified;
    private static Status? _status305UseProxy;
    private static Status? _status306SwitchProxy;
    private static Status? _status307TemporaryRedirect;
    private static Status? _status308PermanentRedirect;
    private static Status? _status400BadRequest;
    private static Status? _status401Unauthorized;
    private static Status? _status402PaymentRequired;
    private static Status? _status403Forbidden;
    private static Status? _status404NotFound;
    private static Status? _status405MethodNotAllowed;
    private static Status? _status406NotAcceptable;
    private static Status? _status407ProxyAuthenticationRequired;
    private static Status? _status408RequestTimeout;
    private static Status? _status409Conflict;
    private static Status? _status410Gone;
    private static Status? _status411LengthRequired;
    private static Status? _status412PreconditionFailed;
    private static Status? _status413RequestEntityTooLarge;
    private static Status? _status414RequestUriTooLong;
    private static Status? _status415UnsupportedMediaType;
    private static Status? _status416RequestedRangeNotSatisfiable;
    private static Status? _status417ExpectationFailed;
    private static Status? _status418ImATeapot;
    private static Status? _status419AuthenticationTimeout;
    private static Status? _status421MisdirectedRequest;
    private static Status? _status422UnprocessableEntity;
    private static Status? _status423Locked;
    private static Status? _status424FailedDependency;
    private static Status? _status426UpgradeRequired;
    private static Status? _status428PreconditionRequired;
    private static Status? _status429TooManyRequests;
    private static Status? _status431RequestHeaderFieldsTooLarge;
    private static Status? _status451UnavailableForLegalReasons;
    private static Status? _status500InternalServerError;
    private static Status? _status501NotImplemented;
    private static Status? _status502BadGateway;
    private static Status? _status503ServiceUnavailable;
    private static Status? _status504GatewayTimeout;
    private static Status? _status505HttpVersionNotsupported;
    private static Status? _status506VariantAlsoNegotiates;
    private static Status? _status507InsufficientStorage;
    private static Status? _status508LoopDetected;
    private static Status? _status510NotExtended;
    private static Status? _status511NetworkAuthenticationRequired;

    internal static Status StatusCode(int statusCode)
    {
        if (statusCode is (< 100) or (> 599))
        {
            // No HTTP status code assigned outside the 100..599 range
            // so, it will not be available in the cache
            return new Status(statusCode);
        }

        return statusCode switch
        {
            StatusCodes.Status101SwitchingProtocols => _status101SwitchingProtocols ??= new(StatusCodes.Status101SwitchingProtocols),
            StatusCodes.Status102Processing => _status102Processing ??= new(StatusCodes.Status102Processing),
            StatusCodes.Status200OK => _status200OK ??= new(StatusCodes.Status200OK),
            StatusCodes.Status201Created => _status201Created ??= new(StatusCodes.Status201Created),
            StatusCodes.Status202Accepted => _status202Accepted ??= new(StatusCodes.Status202Accepted),
            StatusCodes.Status203NonAuthoritative => _status203NonAuthoritative ??= new(StatusCodes.Status203NonAuthoritative),
            StatusCodes.Status204NoContent => _status204NoContent ??= new(StatusCodes.Status204NoContent),
            StatusCodes.Status205ResetContent => _status205ResetContent ??= new(StatusCodes.Status205ResetContent),
            StatusCodes.Status206PartialContent => _status206PartialContent ??= new(StatusCodes.Status206PartialContent),
            StatusCodes.Status207MultiStatus => _status207MultiStatus ??= new(StatusCodes.Status207MultiStatus),
            StatusCodes.Status208AlreadyReported => _status208AlreadyReported ??= new(StatusCodes.Status208AlreadyReported),
            StatusCodes.Status226IMUsed => _status226IMUsed ??= new(StatusCodes.Status226IMUsed),
            StatusCodes.Status300MultipleChoices => _status300MultipleChoices ??= new(StatusCodes.Status300MultipleChoices),
            StatusCodes.Status301MovedPermanently => _status301MovedPermanently ??= new(StatusCodes.Status301MovedPermanently),
            StatusCodes.Status302Found => _status302Found ??= new(StatusCodes.Status302Found),
            StatusCodes.Status303SeeOther => _status303SeeOther ??= new(StatusCodes.Status303SeeOther),
            StatusCodes.Status304NotModified => _status304NotModified ??= new(StatusCodes.Status304NotModified),
            StatusCodes.Status305UseProxy => _status305UseProxy ??= new(StatusCodes.Status305UseProxy),
            StatusCodes.Status306SwitchProxy => _status306SwitchProxy ??= new(StatusCodes.Status306SwitchProxy),
            StatusCodes.Status307TemporaryRedirect => _status307TemporaryRedirect ??= new(StatusCodes.Status307TemporaryRedirect),
            StatusCodes.Status308PermanentRedirect => _status308PermanentRedirect ??= new(StatusCodes.Status308PermanentRedirect),
            StatusCodes.Status400BadRequest => _status400BadRequest ??= new(StatusCodes.Status400BadRequest),
            StatusCodes.Status401Unauthorized => _status401Unauthorized ??= new(StatusCodes.Status401Unauthorized),
            StatusCodes.Status402PaymentRequired => _status402PaymentRequired ??= new(StatusCodes.Status402PaymentRequired),
            StatusCodes.Status403Forbidden => _status403Forbidden ??= new(StatusCodes.Status403Forbidden),
            StatusCodes.Status404NotFound => _status404NotFound ??= new(StatusCodes.Status404NotFound),
            StatusCodes.Status405MethodNotAllowed => _status405MethodNotAllowed ??= new(StatusCodes.Status405MethodNotAllowed),
            StatusCodes.Status406NotAcceptable => _status406NotAcceptable ??= new(StatusCodes.Status406NotAcceptable),
            StatusCodes.Status407ProxyAuthenticationRequired => _status407ProxyAuthenticationRequired ??= new(StatusCodes.Status407ProxyAuthenticationRequired),
            StatusCodes.Status408RequestTimeout => _status408RequestTimeout ??= new(StatusCodes.Status408RequestTimeout),
            StatusCodes.Status409Conflict => _status409Conflict ??= new(StatusCodes.Status409Conflict),
            StatusCodes.Status410Gone => _status410Gone ??= new(StatusCodes.Status410Gone),
            StatusCodes.Status411LengthRequired => _status411LengthRequired ??= new(StatusCodes.Status411LengthRequired),
            StatusCodes.Status412PreconditionFailed => _status412PreconditionFailed ??= new(StatusCodes.Status412PreconditionFailed),
            StatusCodes.Status413RequestEntityTooLarge => _status413RequestEntityTooLarge ??= new(StatusCodes.Status413RequestEntityTooLarge),
            StatusCodes.Status414RequestUriTooLong => _status414RequestUriTooLong ??= new(StatusCodes.Status414RequestUriTooLong),
            StatusCodes.Status415UnsupportedMediaType => _status415UnsupportedMediaType ??= new(StatusCodes.Status415UnsupportedMediaType),
            StatusCodes.Status416RequestedRangeNotSatisfiable => _status416RequestedRangeNotSatisfiable ??= new(StatusCodes.Status416RequestedRangeNotSatisfiable),
            StatusCodes.Status417ExpectationFailed => _status417ExpectationFailed ??= new(StatusCodes.Status417ExpectationFailed),
            StatusCodes.Status418ImATeapot => _status418ImATeapot ??= new(StatusCodes.Status418ImATeapot),
            StatusCodes.Status419AuthenticationTimeout => _status419AuthenticationTimeout ??= new(StatusCodes.Status419AuthenticationTimeout),
            StatusCodes.Status421MisdirectedRequest => _status421MisdirectedRequest ??= new(StatusCodes.Status421MisdirectedRequest),
            StatusCodes.Status422UnprocessableEntity => _status422UnprocessableEntity ??= new(StatusCodes.Status422UnprocessableEntity),
            StatusCodes.Status423Locked => _status423Locked ??= new(StatusCodes.Status423Locked),
            StatusCodes.Status424FailedDependency => _status424FailedDependency ??= new(StatusCodes.Status424FailedDependency),
            StatusCodes.Status426UpgradeRequired => _status426UpgradeRequired ??= new(StatusCodes.Status426UpgradeRequired),
            StatusCodes.Status428PreconditionRequired => _status428PreconditionRequired ??= new(StatusCodes.Status428PreconditionRequired),
            StatusCodes.Status429TooManyRequests => _status429TooManyRequests ??= new(StatusCodes.Status429TooManyRequests),
            StatusCodes.Status431RequestHeaderFieldsTooLarge => _status431RequestHeaderFieldsTooLarge ??= new(StatusCodes.Status431RequestHeaderFieldsTooLarge),
            StatusCodes.Status451UnavailableForLegalReasons => _status451UnavailableForLegalReasons ??= new(StatusCodes.Status451UnavailableForLegalReasons),
            StatusCodes.Status500InternalServerError => _status500InternalServerError ??= new(StatusCodes.Status500InternalServerError),
            StatusCodes.Status501NotImplemented => _status501NotImplemented ??= new(StatusCodes.Status501NotImplemented),
            StatusCodes.Status502BadGateway => _status502BadGateway ??= new(StatusCodes.Status502BadGateway),
            StatusCodes.Status503ServiceUnavailable => _status503ServiceUnavailable ??= new(StatusCodes.Status503ServiceUnavailable),
            StatusCodes.Status504GatewayTimeout => _status504GatewayTimeout ??= new(StatusCodes.Status504GatewayTimeout),
            StatusCodes.Status505HttpVersionNotsupported => _status505HttpVersionNotsupported ??= new(StatusCodes.Status505HttpVersionNotsupported),
            StatusCodes.Status506VariantAlsoNegotiates => _status506VariantAlsoNegotiates ??= new(StatusCodes.Status506VariantAlsoNegotiates),
            StatusCodes.Status507InsufficientStorage => _status507InsufficientStorage ??= new(StatusCodes.Status507InsufficientStorage),
            StatusCodes.Status508LoopDetected => _status508LoopDetected ??= new(StatusCodes.Status508LoopDetected),
            StatusCodes.Status510NotExtended => _status510NotExtended ??= new(StatusCodes.Status510NotExtended),
            StatusCodes.Status511NetworkAuthenticationRequired => _status511NetworkAuthenticationRequired ??= new(StatusCodes.Status511NetworkAuthenticationRequired),
            _ => new Status(statusCode),
        };
    }
}
