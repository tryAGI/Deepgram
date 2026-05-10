#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1SpeakPostParametersBitRate : global::System.IEquatable<V1SpeakPostParametersBitRate>
    {
        /// <summary>
        /// Encoding - mp3(default). Supported bitrates - 32000, 48000(default) bps.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1SpeakPostParametersBitRate0? V1SpeakPostParametersBitRate0 { get; init; }
#else
        public global::Deepgram.V1SpeakPostParametersBitRate0? V1SpeakPostParametersBitRate0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersBitRate0))]
#endif
        public bool IsV1SpeakPostParametersBitRate0 => V1SpeakPostParametersBitRate0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersBitRate0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V1SpeakPostParametersBitRate0? value)
        {
            value = V1SpeakPostParametersBitRate0;
            return IsV1SpeakPostParametersBitRate0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V1SpeakPostParametersBitRate0 PickV1SpeakPostParametersBitRate0() => IsV1SpeakPostParametersBitRate0
            ? V1SpeakPostParametersBitRate0!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1SpeakPostParametersBitRate0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? V1SpeakPostParametersBitRateVariant2 { get; init; }
#else
        public double? V1SpeakPostParametersBitRateVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersBitRateVariant2))]
#endif
        public bool IsV1SpeakPostParametersBitRateVariant2 => V1SpeakPostParametersBitRateVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersBitRateVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = V1SpeakPostParametersBitRateVariant2;
            return IsV1SpeakPostParametersBitRateVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public double PickV1SpeakPostParametersBitRateVariant2() => IsV1SpeakPostParametersBitRateVariant2
            ? V1SpeakPostParametersBitRateVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1SpeakPostParametersBitRateVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? V1SpeakPostParametersBitRateVariant3 { get; init; }
#else
        public double? V1SpeakPostParametersBitRateVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersBitRateVariant3))]
#endif
        public bool IsV1SpeakPostParametersBitRateVariant3 => V1SpeakPostParametersBitRateVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersBitRateVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = V1SpeakPostParametersBitRateVariant3;
            return IsV1SpeakPostParametersBitRateVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public double PickV1SpeakPostParametersBitRateVariant3() => IsV1SpeakPostParametersBitRateVariant3
            ? V1SpeakPostParametersBitRateVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1SpeakPostParametersBitRateVariant3' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersBitRate(global::Deepgram.V1SpeakPostParametersBitRate0 value) => new V1SpeakPostParametersBitRate((global::Deepgram.V1SpeakPostParametersBitRate0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1SpeakPostParametersBitRate0?(V1SpeakPostParametersBitRate @this) => @this.V1SpeakPostParametersBitRate0;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersBitRate(global::Deepgram.V1SpeakPostParametersBitRate0? value)
        {
            V1SpeakPostParametersBitRate0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V1SpeakPostParametersBitRate FromV1SpeakPostParametersBitRate0(global::Deepgram.V1SpeakPostParametersBitRate0? value) => new V1SpeakPostParametersBitRate(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersBitRate(double value) => new V1SpeakPostParametersBitRate((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(V1SpeakPostParametersBitRate @this) => @this.V1SpeakPostParametersBitRateVariant2;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersBitRate(double? value)
        {
            V1SpeakPostParametersBitRateVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V1SpeakPostParametersBitRate FromV1SpeakPostParametersBitRateVariant2(double? value) => new V1SpeakPostParametersBitRate(value);

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersBitRate(
            global::Deepgram.V1SpeakPostParametersBitRate0? v1SpeakPostParametersBitRate0,
            double? v1SpeakPostParametersBitRateVariant2,
            double? v1SpeakPostParametersBitRateVariant3
            )
        {
            V1SpeakPostParametersBitRate0 = v1SpeakPostParametersBitRate0;
            V1SpeakPostParametersBitRateVariant2 = v1SpeakPostParametersBitRateVariant2;
            V1SpeakPostParametersBitRateVariant3 = v1SpeakPostParametersBitRateVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1SpeakPostParametersBitRateVariant3 as object ??
            V1SpeakPostParametersBitRateVariant2 as object ??
            V1SpeakPostParametersBitRate0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1SpeakPostParametersBitRate0?.ToValueString() ??
            V1SpeakPostParametersBitRateVariant2?.ToString() ??
            V1SpeakPostParametersBitRateVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1SpeakPostParametersBitRate0 && !IsV1SpeakPostParametersBitRateVariant2 && !IsV1SpeakPostParametersBitRateVariant3 || !IsV1SpeakPostParametersBitRate0 && IsV1SpeakPostParametersBitRateVariant2 && !IsV1SpeakPostParametersBitRateVariant3 || !IsV1SpeakPostParametersBitRate0 && !IsV1SpeakPostParametersBitRateVariant2 && IsV1SpeakPostParametersBitRateVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.V1SpeakPostParametersBitRate0?, TResult>? v1SpeakPostParametersBitRate0 = null,
            global::System.Func<double?, TResult>? v1SpeakPostParametersBitRateVariant2 = null,
            global::System.Func<double?, TResult>? v1SpeakPostParametersBitRateVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1SpeakPostParametersBitRate0 && v1SpeakPostParametersBitRate0 != null)
            {
                return v1SpeakPostParametersBitRate0(V1SpeakPostParametersBitRate0!);
            }
            else if (IsV1SpeakPostParametersBitRateVariant2 && v1SpeakPostParametersBitRateVariant2 != null)
            {
                return v1SpeakPostParametersBitRateVariant2(V1SpeakPostParametersBitRateVariant2!);
            }
            else if (IsV1SpeakPostParametersBitRateVariant3 && v1SpeakPostParametersBitRateVariant3 != null)
            {
                return v1SpeakPostParametersBitRateVariant3(V1SpeakPostParametersBitRateVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.V1SpeakPostParametersBitRate0?>? v1SpeakPostParametersBitRate0 = null,

            global::System.Action<double?>? v1SpeakPostParametersBitRateVariant2 = null,

            global::System.Action<double?>? v1SpeakPostParametersBitRateVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1SpeakPostParametersBitRate0)
            {
                v1SpeakPostParametersBitRate0?.Invoke(V1SpeakPostParametersBitRate0!);
            }
            else if (IsV1SpeakPostParametersBitRateVariant2)
            {
                v1SpeakPostParametersBitRateVariant2?.Invoke(V1SpeakPostParametersBitRateVariant2!);
            }
            else if (IsV1SpeakPostParametersBitRateVariant3)
            {
                v1SpeakPostParametersBitRateVariant3?.Invoke(V1SpeakPostParametersBitRateVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.V1SpeakPostParametersBitRate0?>? v1SpeakPostParametersBitRate0 = null,
            global::System.Action<double?>? v1SpeakPostParametersBitRateVariant2 = null,
            global::System.Action<double?>? v1SpeakPostParametersBitRateVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1SpeakPostParametersBitRate0)
            {
                v1SpeakPostParametersBitRate0?.Invoke(V1SpeakPostParametersBitRate0!);
            }
            else if (IsV1SpeakPostParametersBitRateVariant2)
            {
                v1SpeakPostParametersBitRateVariant2?.Invoke(V1SpeakPostParametersBitRateVariant2!);
            }
            else if (IsV1SpeakPostParametersBitRateVariant3)
            {
                v1SpeakPostParametersBitRateVariant3?.Invoke(V1SpeakPostParametersBitRateVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1SpeakPostParametersBitRate0,
                typeof(global::Deepgram.V1SpeakPostParametersBitRate0),
                V1SpeakPostParametersBitRateVariant2,
                typeof(double),
                V1SpeakPostParametersBitRateVariant3,
                typeof(double),
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
        public bool Equals(V1SpeakPostParametersBitRate other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1SpeakPostParametersBitRate0?>.Default.Equals(V1SpeakPostParametersBitRate0, other.V1SpeakPostParametersBitRate0) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(V1SpeakPostParametersBitRateVariant2, other.V1SpeakPostParametersBitRateVariant2) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(V1SpeakPostParametersBitRateVariant3, other.V1SpeakPostParametersBitRateVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1SpeakPostParametersBitRate obj1, V1SpeakPostParametersBitRate obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1SpeakPostParametersBitRate>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1SpeakPostParametersBitRate obj1, V1SpeakPostParametersBitRate obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1SpeakPostParametersBitRate o && Equals(o);
        }
    }
}
