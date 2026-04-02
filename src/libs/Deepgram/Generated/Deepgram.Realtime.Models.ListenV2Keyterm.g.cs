#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Keyterm prompting can improve recognition of specialized terminology.<br/>
    /// Pass multiple keyterm query parameters to boost multiple keyterms.
    /// </summary>
    public readonly partial struct ListenV2Keyterm : global::System.IEquatable<ListenV2Keyterm>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ListenV2KeytermVariant1 { get; init; }
#else
        public string? ListenV2KeytermVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenV2KeytermVariant1))]
#endif
        public bool IsListenV2KeytermVariant1 => ListenV2KeytermVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? ListenV2KeytermVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? ListenV2KeytermVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenV2KeytermVariant2))]
#endif
        public bool IsListenV2KeytermVariant2 => ListenV2KeytermVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2Keyterm(string value) => new ListenV2Keyterm((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ListenV2Keyterm @this) => @this.ListenV2KeytermVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2Keyterm(string? value)
        {
            ListenV2KeytermVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListenV2Keyterm(
            string? listenV2KeytermVariant1,
            global::System.Collections.Generic.IList<string>? listenV2KeytermVariant2
            )
        {
            ListenV2KeytermVariant1 = listenV2KeytermVariant1;
            ListenV2KeytermVariant2 = listenV2KeytermVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ListenV2KeytermVariant2 as object ??
            ListenV2KeytermVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ListenV2KeytermVariant1?.ToString() ??
            ListenV2KeytermVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsListenV2KeytermVariant1 && !IsListenV2KeytermVariant2 || !IsListenV2KeytermVariant1 && IsListenV2KeytermVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? listenV2KeytermVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? listenV2KeytermVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListenV2KeytermVariant1 && listenV2KeytermVariant1 != null)
            {
                return listenV2KeytermVariant1(ListenV2KeytermVariant1!);
            }
            else if (IsListenV2KeytermVariant2 && listenV2KeytermVariant2 != null)
            {
                return listenV2KeytermVariant2(ListenV2KeytermVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? listenV2KeytermVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? listenV2KeytermVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListenV2KeytermVariant1)
            {
                listenV2KeytermVariant1?.Invoke(ListenV2KeytermVariant1!);
            }
            else if (IsListenV2KeytermVariant2)
            {
                listenV2KeytermVariant2?.Invoke(ListenV2KeytermVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ListenV2KeytermVariant1,
                typeof(string),
                ListenV2KeytermVariant2,
                typeof(global::System.Collections.Generic.IList<string>),
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
        public bool Equals(ListenV2Keyterm other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ListenV2KeytermVariant1, other.ListenV2KeytermVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(ListenV2KeytermVariant2, other.ListenV2KeytermVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ListenV2Keyterm obj1, ListenV2Keyterm obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListenV2Keyterm>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ListenV2Keyterm obj1, ListenV2Keyterm obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListenV2Keyterm o && Equals(o);
        }
    }
}
