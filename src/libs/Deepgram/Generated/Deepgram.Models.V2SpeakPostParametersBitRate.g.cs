#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V2SpeakPostParametersBitRate : global::System.IEquatable<V2SpeakPostParametersBitRate>
    {
        /// <summary>
        /// Encoding - mp3(default). Supported bitrates - 8000, 16000, 24000, 32000, 40000, 48000(default) bps.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V2SpeakPostParametersBitRate0? V2SpeakPostParametersBitRate0 { get; init; }
#else
        public global::Deepgram.V2SpeakPostParametersBitRate0? V2SpeakPostParametersBitRate0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersBitRate0))]
#endif
        public bool IsV2SpeakPostParametersBitRate0 => V2SpeakPostParametersBitRate0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersBitRate0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V2SpeakPostParametersBitRate0? value)
        {
            value = V2SpeakPostParametersBitRate0;
            return IsV2SpeakPostParametersBitRate0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V2SpeakPostParametersBitRate0 PickV2SpeakPostParametersBitRate0() => IsV2SpeakPostParametersBitRate0
            ? V2SpeakPostParametersBitRate0!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersBitRate0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public int? V2SpeakPostParametersBitRateVariant2 { get; init; }
#else
        public int? V2SpeakPostParametersBitRateVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersBitRateVariant2))]
#endif
        public bool IsV2SpeakPostParametersBitRateVariant2 => V2SpeakPostParametersBitRateVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersBitRateVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out int? value)
        {
            value = V2SpeakPostParametersBitRateVariant2;
            return IsV2SpeakPostParametersBitRateVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public int PickV2SpeakPostParametersBitRateVariant2() => IsV2SpeakPostParametersBitRateVariant2
            ? V2SpeakPostParametersBitRateVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersBitRateVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public int? V2SpeakPostParametersBitRateVariant3 { get; init; }
#else
        public int? V2SpeakPostParametersBitRateVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersBitRateVariant3))]
#endif
        public bool IsV2SpeakPostParametersBitRateVariant3 => V2SpeakPostParametersBitRateVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersBitRateVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out int? value)
        {
            value = V2SpeakPostParametersBitRateVariant3;
            return IsV2SpeakPostParametersBitRateVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public int PickV2SpeakPostParametersBitRateVariant3() => IsV2SpeakPostParametersBitRateVariant3
            ? V2SpeakPostParametersBitRateVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersBitRateVariant3' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2SpeakPostParametersBitRate(global::Deepgram.V2SpeakPostParametersBitRate0 value) => new V2SpeakPostParametersBitRate((global::Deepgram.V2SpeakPostParametersBitRate0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V2SpeakPostParametersBitRate0?(V2SpeakPostParametersBitRate @this) => @this.V2SpeakPostParametersBitRate0;

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersBitRate(global::Deepgram.V2SpeakPostParametersBitRate0? value)
        {
            V2SpeakPostParametersBitRate0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2SpeakPostParametersBitRate FromV2SpeakPostParametersBitRate0(global::Deepgram.V2SpeakPostParametersBitRate0? value) => new V2SpeakPostParametersBitRate(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2SpeakPostParametersBitRate(int value) => new V2SpeakPostParametersBitRate((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(V2SpeakPostParametersBitRate @this) => @this.V2SpeakPostParametersBitRateVariant2;

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersBitRate(int? value)
        {
            V2SpeakPostParametersBitRateVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2SpeakPostParametersBitRate FromV2SpeakPostParametersBitRateVariant2(int? value) => new V2SpeakPostParametersBitRate(value);

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersBitRate(
            global::Deepgram.V2SpeakPostParametersBitRate0? v2SpeakPostParametersBitRate0,
            int? v2SpeakPostParametersBitRateVariant2,
            int? v2SpeakPostParametersBitRateVariant3
            )
        {
            V2SpeakPostParametersBitRate0 = v2SpeakPostParametersBitRate0;
            V2SpeakPostParametersBitRateVariant2 = v2SpeakPostParametersBitRateVariant2;
            V2SpeakPostParametersBitRateVariant3 = v2SpeakPostParametersBitRateVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V2SpeakPostParametersBitRateVariant3 as object ??
            V2SpeakPostParametersBitRateVariant2 as object ??
            V2SpeakPostParametersBitRate0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V2SpeakPostParametersBitRate0?.ToValueString() ??
            V2SpeakPostParametersBitRateVariant2?.ToString() ??
            V2SpeakPostParametersBitRateVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV2SpeakPostParametersBitRate0 && !IsV2SpeakPostParametersBitRateVariant2 && !IsV2SpeakPostParametersBitRateVariant3 || !IsV2SpeakPostParametersBitRate0 && IsV2SpeakPostParametersBitRateVariant2 && !IsV2SpeakPostParametersBitRateVariant3 || !IsV2SpeakPostParametersBitRate0 && !IsV2SpeakPostParametersBitRateVariant2 && IsV2SpeakPostParametersBitRateVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.V2SpeakPostParametersBitRate0?, TResult>? v2SpeakPostParametersBitRate0 = null,
            global::System.Func<int?, TResult>? v2SpeakPostParametersBitRateVariant2 = null,
            global::System.Func<int?, TResult>? v2SpeakPostParametersBitRateVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2SpeakPostParametersBitRate0 && v2SpeakPostParametersBitRate0 != null)
            {
                return v2SpeakPostParametersBitRate0(V2SpeakPostParametersBitRate0!);
            }
            else if (IsV2SpeakPostParametersBitRateVariant2 && v2SpeakPostParametersBitRateVariant2 != null)
            {
                return v2SpeakPostParametersBitRateVariant2(V2SpeakPostParametersBitRateVariant2!);
            }
            else if (IsV2SpeakPostParametersBitRateVariant3 && v2SpeakPostParametersBitRateVariant3 != null)
            {
                return v2SpeakPostParametersBitRateVariant3(V2SpeakPostParametersBitRateVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.V2SpeakPostParametersBitRate0?>? v2SpeakPostParametersBitRate0 = null,

            global::System.Action<int?>? v2SpeakPostParametersBitRateVariant2 = null,

            global::System.Action<int?>? v2SpeakPostParametersBitRateVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2SpeakPostParametersBitRate0)
            {
                v2SpeakPostParametersBitRate0?.Invoke(V2SpeakPostParametersBitRate0!);
            }
            else if (IsV2SpeakPostParametersBitRateVariant2)
            {
                v2SpeakPostParametersBitRateVariant2?.Invoke(V2SpeakPostParametersBitRateVariant2!);
            }
            else if (IsV2SpeakPostParametersBitRateVariant3)
            {
                v2SpeakPostParametersBitRateVariant3?.Invoke(V2SpeakPostParametersBitRateVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.V2SpeakPostParametersBitRate0?>? v2SpeakPostParametersBitRate0 = null,
            global::System.Action<int?>? v2SpeakPostParametersBitRateVariant2 = null,
            global::System.Action<int?>? v2SpeakPostParametersBitRateVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2SpeakPostParametersBitRate0)
            {
                v2SpeakPostParametersBitRate0?.Invoke(V2SpeakPostParametersBitRate0!);
            }
            else if (IsV2SpeakPostParametersBitRateVariant2)
            {
                v2SpeakPostParametersBitRateVariant2?.Invoke(V2SpeakPostParametersBitRateVariant2!);
            }
            else if (IsV2SpeakPostParametersBitRateVariant3)
            {
                v2SpeakPostParametersBitRateVariant3?.Invoke(V2SpeakPostParametersBitRateVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V2SpeakPostParametersBitRate0,
                typeof(global::Deepgram.V2SpeakPostParametersBitRate0),
                V2SpeakPostParametersBitRateVariant2,
                typeof(int),
                V2SpeakPostParametersBitRateVariant3,
                typeof(int),
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
        public bool Equals(V2SpeakPostParametersBitRate other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V2SpeakPostParametersBitRate0?>.Default.Equals(V2SpeakPostParametersBitRate0, other.V2SpeakPostParametersBitRate0) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(V2SpeakPostParametersBitRateVariant2, other.V2SpeakPostParametersBitRateVariant2) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(V2SpeakPostParametersBitRateVariant3, other.V2SpeakPostParametersBitRateVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V2SpeakPostParametersBitRate obj1, V2SpeakPostParametersBitRate obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V2SpeakPostParametersBitRate>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V2SpeakPostParametersBitRate obj1, V2SpeakPostParametersBitRate obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V2SpeakPostParametersBitRate o && Equals(o);
        }
    }
}
