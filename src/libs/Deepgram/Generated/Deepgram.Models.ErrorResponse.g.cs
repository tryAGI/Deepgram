#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ErrorResponse : global::System.IEquatable<ErrorResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.ErrorResponseTextError? Text { get; init; }
#else
        public global::Deepgram.ErrorResponseTextError? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.ErrorResponseTextError? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.ErrorResponseLegacyError? ErrorResponseLegacyError { get; init; }
#else
        public global::Deepgram.ErrorResponseLegacyError? ErrorResponseLegacyError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ErrorResponseLegacyError))]
#endif
        public bool IsErrorResponseLegacyError => ErrorResponseLegacyError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickErrorResponseLegacyError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.ErrorResponseLegacyError? value)
        {
            value = ErrorResponseLegacyError;
            return IsErrorResponseLegacyError;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.ErrorResponseModernError? ErrorResponseModernError { get; init; }
#else
        public global::Deepgram.ErrorResponseModernError? ErrorResponseModernError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ErrorResponseModernError))]
#endif
        public bool IsErrorResponseModernError => ErrorResponseModernError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickErrorResponseModernError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.ErrorResponseModernError? value)
        {
            value = ErrorResponseModernError;
            return IsErrorResponseModernError;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ErrorResponse(global::Deepgram.ErrorResponseTextError value) => new ErrorResponse((global::Deepgram.ErrorResponseTextError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.ErrorResponseTextError?(ErrorResponse @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ErrorResponse(global::Deepgram.ErrorResponseTextError? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ErrorResponse(global::Deepgram.ErrorResponseLegacyError value) => new ErrorResponse((global::Deepgram.ErrorResponseLegacyError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.ErrorResponseLegacyError?(ErrorResponse @this) => @this.ErrorResponseLegacyError;

        /// <summary>
        /// 
        /// </summary>
        public ErrorResponse(global::Deepgram.ErrorResponseLegacyError? value)
        {
            ErrorResponseLegacyError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ErrorResponse(global::Deepgram.ErrorResponseModernError value) => new ErrorResponse((global::Deepgram.ErrorResponseModernError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.ErrorResponseModernError?(ErrorResponse @this) => @this.ErrorResponseModernError;

        /// <summary>
        /// 
        /// </summary>
        public ErrorResponse(global::Deepgram.ErrorResponseModernError? value)
        {
            ErrorResponseModernError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ErrorResponse(
            global::Deepgram.ErrorResponseTextError? text,
            global::Deepgram.ErrorResponseLegacyError? errorResponseLegacyError,
            global::Deepgram.ErrorResponseModernError? errorResponseModernError
            )
        {
            Text = text;
            ErrorResponseLegacyError = errorResponseLegacyError;
            ErrorResponseModernError = errorResponseModernError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ErrorResponseModernError as object ??
            ErrorResponseLegacyError as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ErrorResponseLegacyError?.ToString() ??
            ErrorResponseModernError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsErrorResponseLegacyError && !IsErrorResponseModernError || !IsText && IsErrorResponseLegacyError && !IsErrorResponseModernError || !IsText && !IsErrorResponseLegacyError && IsErrorResponseModernError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.ErrorResponseTextError, TResult>? text = null,
            global::System.Func<global::Deepgram.ErrorResponseLegacyError, TResult>? errorResponseLegacyError = null,
            global::System.Func<global::Deepgram.ErrorResponseModernError, TResult>? errorResponseModernError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsErrorResponseLegacyError && errorResponseLegacyError != null)
            {
                return errorResponseLegacyError(ErrorResponseLegacyError!);
            }
            else if (IsErrorResponseModernError && errorResponseModernError != null)
            {
                return errorResponseModernError(ErrorResponseModernError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.ErrorResponseTextError>? text = null,

            global::System.Action<global::Deepgram.ErrorResponseLegacyError>? errorResponseLegacyError = null,

            global::System.Action<global::Deepgram.ErrorResponseModernError>? errorResponseModernError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsErrorResponseLegacyError)
            {
                errorResponseLegacyError?.Invoke(ErrorResponseLegacyError!);
            }
            else if (IsErrorResponseModernError)
            {
                errorResponseModernError?.Invoke(ErrorResponseModernError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.ErrorResponseTextError>? text = null,
            global::System.Action<global::Deepgram.ErrorResponseLegacyError>? errorResponseLegacyError = null,
            global::System.Action<global::Deepgram.ErrorResponseModernError>? errorResponseModernError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsErrorResponseLegacyError)
            {
                errorResponseLegacyError?.Invoke(ErrorResponseLegacyError!);
            }
            else if (IsErrorResponseModernError)
            {
                errorResponseModernError?.Invoke(ErrorResponseModernError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Deepgram.ErrorResponseTextError),
                ErrorResponseLegacyError,
                typeof(global::Deepgram.ErrorResponseLegacyError),
                ErrorResponseModernError,
                typeof(global::Deepgram.ErrorResponseModernError),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ErrorResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.ErrorResponseTextError?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.ErrorResponseLegacyError?>.Default.Equals(ErrorResponseLegacyError, other.ErrorResponseLegacyError) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.ErrorResponseModernError?>.Default.Equals(ErrorResponseModernError, other.ErrorResponseModernError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ErrorResponse obj1, ErrorResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ErrorResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ErrorResponse obj1, ErrorResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ErrorResponse o && Equals(o);
        }
    }
}
