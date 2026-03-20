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
        public global::Deepgram.ReadV1RequestUrl? Url { get; init; }
#else
        public global::Deepgram.ReadV1RequestUrl? Url { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Url))]
#endif
        public bool IsUrl => Url != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.ReadV1RequestText? Text { get; init; }
#else
        public global::Deepgram.ReadV1RequestText? Text { get; }
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
        public static implicit operator ReadV1Request(global::Deepgram.ReadV1RequestUrl value) => new ReadV1Request((global::Deepgram.ReadV1RequestUrl?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.ReadV1RequestUrl?(ReadV1Request @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public ReadV1Request(global::Deepgram.ReadV1RequestUrl? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReadV1Request(global::Deepgram.ReadV1RequestText value) => new ReadV1Request((global::Deepgram.ReadV1RequestText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.ReadV1RequestText?(ReadV1Request @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ReadV1Request(global::Deepgram.ReadV1RequestText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ReadV1Request(
            global::Deepgram.ReadV1RequestUrl? url,
            global::Deepgram.ReadV1RequestText? text
            )
        {
            Url = url;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object ??
            Url as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Url?.ToString() ??
            Text?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUrl && !IsText || !IsUrl && IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.ReadV1RequestUrl?, TResult>? url = null,
            global::System.Func<global::Deepgram.ReadV1RequestText?, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUrl && url != null)
            {
                return url(Url!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.ReadV1RequestUrl?>? url = null,
            global::System.Action<global::Deepgram.ReadV1RequestText?>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUrl)
            {
                url?.Invoke(Url!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Url,
                typeof(global::Deepgram.ReadV1RequestUrl),
                Text,
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
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.ReadV1RequestUrl?>.Default.Equals(Url, other.Url) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.ReadV1RequestText?>.Default.Equals(Text, other.Text) 
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
