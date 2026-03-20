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
#if NET6_0_OR_GREATER
        public global::Deepgram.ErrorResponseLegacyError? Legacy { get; init; }
#else
        public global::Deepgram.ErrorResponseLegacyError? Legacy { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Legacy))]
#endif
        public bool IsLegacy => Legacy != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.ErrorResponseModernError? Modern { get; init; }
#else
        public global::Deepgram.ErrorResponseModernError? Modern { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Modern))]
#endif
        public bool IsModern => Modern != null;
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
        public static implicit operator global::Deepgram.ErrorResponseLegacyError?(ErrorResponse @this) => @this.Legacy;

        /// <summary>
        /// 
        /// </summary>
        public ErrorResponse(global::Deepgram.ErrorResponseLegacyError? value)
        {
            Legacy = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ErrorResponse(global::Deepgram.ErrorResponseModernError value) => new ErrorResponse((global::Deepgram.ErrorResponseModernError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.ErrorResponseModernError?(ErrorResponse @this) => @this.Modern;

        /// <summary>
        /// 
        /// </summary>
        public ErrorResponse(global::Deepgram.ErrorResponseModernError? value)
        {
            Modern = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ErrorResponse(
            global::Deepgram.ErrorResponseTextError? text,
            global::Deepgram.ErrorResponseLegacyError? legacy,
            global::Deepgram.ErrorResponseModernError? modern
            )
        {
            Text = text;
            Legacy = legacy;
            Modern = modern;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Modern as object ??
            Legacy as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Legacy?.ToString() ??
            Modern?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsLegacy && !IsModern || !IsText && IsLegacy && !IsModern || !IsText && !IsLegacy && IsModern;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.ErrorResponseTextError?, TResult>? text = null,
            global::System.Func<global::Deepgram.ErrorResponseLegacyError?, TResult>? legacy = null,
            global::System.Func<global::Deepgram.ErrorResponseModernError?, TResult>? modern = null,
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
            else if (IsLegacy && legacy != null)
            {
                return legacy(Legacy!);
            }
            else if (IsModern && modern != null)
            {
                return modern(Modern!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.ErrorResponseTextError?>? text = null,
            global::System.Action<global::Deepgram.ErrorResponseLegacyError?>? legacy = null,
            global::System.Action<global::Deepgram.ErrorResponseModernError?>? modern = null,
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
            else if (IsLegacy)
            {
                legacy?.Invoke(Legacy!);
            }
            else if (IsModern)
            {
                modern?.Invoke(Modern!);
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
                Legacy,
                typeof(global::Deepgram.ErrorResponseLegacyError),
                Modern,
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
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.ErrorResponseLegacyError?>.Default.Equals(Legacy, other.Legacy) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.ErrorResponseModernError?>.Default.Equals(Modern, other.Modern) 
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
