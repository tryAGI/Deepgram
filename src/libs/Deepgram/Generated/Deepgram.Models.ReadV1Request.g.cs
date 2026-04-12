#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ReadV1Request : global::System.IEquatable<ReadV1Request>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.ReadV1RequestUrl? ReadV1RequestUrl { get; init; }
#else
        public global::Deepgram.ReadV1RequestUrl? ReadV1RequestUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReadV1RequestUrl))]
#endif
        public bool IsReadV1RequestUrl => ReadV1RequestUrl != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.ReadV1RequestText? ReadV1RequestText { get; init; }
#else
        public global::Deepgram.ReadV1RequestText? ReadV1RequestText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReadV1RequestText))]
#endif
        public bool IsReadV1RequestText => ReadV1RequestText != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReadV1Request(global::Deepgram.ReadV1RequestUrl value) => new ReadV1Request((global::Deepgram.ReadV1RequestUrl?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.ReadV1RequestUrl?(ReadV1Request @this) => @this.ReadV1RequestUrl;

        /// <summary>
        /// 
        /// </summary>
        public ReadV1Request(global::Deepgram.ReadV1RequestUrl? value)
        {
            ReadV1RequestUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReadV1Request(global::Deepgram.ReadV1RequestText value) => new ReadV1Request((global::Deepgram.ReadV1RequestText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.ReadV1RequestText?(ReadV1Request @this) => @this.ReadV1RequestText;

        /// <summary>
        /// 
        /// </summary>
        public ReadV1Request(global::Deepgram.ReadV1RequestText? value)
        {
            ReadV1RequestText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ReadV1Request(
            global::Deepgram.ReadV1RequestUrl? readV1RequestUrl,
            global::Deepgram.ReadV1RequestText? readV1RequestText
            )
        {
            ReadV1RequestUrl = readV1RequestUrl;
            ReadV1RequestText = readV1RequestText;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ReadV1RequestText as object ??
            ReadV1RequestUrl as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ReadV1RequestUrl?.ToString() ??
            ReadV1RequestText?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReadV1RequestUrl && !IsReadV1RequestText || !IsReadV1RequestUrl && IsReadV1RequestText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.ReadV1RequestUrl?, TResult>? readV1RequestUrl = null,
            global::System.Func<global::Deepgram.ReadV1RequestText?, TResult>? readV1RequestText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReadV1RequestUrl && readV1RequestUrl != null)
            {
                return readV1RequestUrl(ReadV1RequestUrl!);
            }
            else if (IsReadV1RequestText && readV1RequestText != null)
            {
                return readV1RequestText(ReadV1RequestText!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.ReadV1RequestUrl?>? readV1RequestUrl = null,
            global::System.Action<global::Deepgram.ReadV1RequestText?>? readV1RequestText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReadV1RequestUrl)
            {
                readV1RequestUrl?.Invoke(ReadV1RequestUrl!);
            }
            else if (IsReadV1RequestText)
            {
                readV1RequestText?.Invoke(ReadV1RequestText!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ReadV1RequestUrl,
                typeof(global::Deepgram.ReadV1RequestUrl),
                ReadV1RequestText,
                typeof(global::Deepgram.ReadV1RequestText),
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
        public bool Equals(ReadV1Request other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.ReadV1RequestUrl?>.Default.Equals(ReadV1RequestUrl, other.ReadV1RequestUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.ReadV1RequestText?>.Default.Equals(ReadV1RequestText, other.ReadV1RequestText) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ReadV1Request obj1, ReadV1Request obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReadV1Request>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ReadV1Request obj1, ReadV1Request obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReadV1Request o && Equals(o);
        }
    }
}
