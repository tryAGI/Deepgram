#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1SpeakPostParametersSampleRate : global::System.IEquatable<V1SpeakPostParametersSampleRate>
    {
        /// <summary>
        /// Encoding - linear16. Supported sample rates - 8000, 16000, 24000, 32000, 48000 Hz.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1SpeakPostParametersSampleRate0? V1SpeakPostParametersSampleRate0 { get; init; }
#else
        public global::Deepgram.V1SpeakPostParametersSampleRate0? V1SpeakPostParametersSampleRate0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersSampleRate0))]
#endif
        public bool IsV1SpeakPostParametersSampleRate0 => V1SpeakPostParametersSampleRate0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersSampleRate0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V1SpeakPostParametersSampleRate0? value)
        {
            value = V1SpeakPostParametersSampleRate0;
            return IsV1SpeakPostParametersSampleRate0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V1SpeakPostParametersSampleRate0 PickV1SpeakPostParametersSampleRate0() => IsV1SpeakPostParametersSampleRate0
            ? V1SpeakPostParametersSampleRate0!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1SpeakPostParametersSampleRate0' but the value was {ToString()}.");

        /// <summary>
        /// Encoding - mulaw. Supported sample rates - 8000, 16000 Hz.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1SpeakPostParametersSampleRate1? V1SpeakPostParametersSampleRate1 { get; init; }
#else
        public global::Deepgram.V1SpeakPostParametersSampleRate1? V1SpeakPostParametersSampleRate1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersSampleRate1))]
#endif
        public bool IsV1SpeakPostParametersSampleRate1 => V1SpeakPostParametersSampleRate1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersSampleRate1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V1SpeakPostParametersSampleRate1? value)
        {
            value = V1SpeakPostParametersSampleRate1;
            return IsV1SpeakPostParametersSampleRate1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V1SpeakPostParametersSampleRate1 PickV1SpeakPostParametersSampleRate1() => IsV1SpeakPostParametersSampleRate1
            ? V1SpeakPostParametersSampleRate1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1SpeakPostParametersSampleRate1' but the value was {ToString()}.");

        /// <summary>
        /// Encoding - alaw. Supported sample rates - 8000, 16000 Hz.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1SpeakPostParametersSampleRate2? V1SpeakPostParametersSampleRate2 { get; init; }
#else
        public global::Deepgram.V1SpeakPostParametersSampleRate2? V1SpeakPostParametersSampleRate2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersSampleRate2))]
#endif
        public bool IsV1SpeakPostParametersSampleRate2 => V1SpeakPostParametersSampleRate2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersSampleRate2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V1SpeakPostParametersSampleRate2? value)
        {
            value = V1SpeakPostParametersSampleRate2;
            return IsV1SpeakPostParametersSampleRate2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V1SpeakPostParametersSampleRate2 PickV1SpeakPostParametersSampleRate2() => IsV1SpeakPostParametersSampleRate2
            ? V1SpeakPostParametersSampleRate2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1SpeakPostParametersSampleRate2' but the value was {ToString()}.");

        /// <summary>
        /// Encoding - mp3. Sample rate is fixed and not configurable (22050 Hz).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1SpeakPostParametersSampleRate3? V1SpeakPostParametersSampleRate3 { get; init; }
#else
        public global::Deepgram.V1SpeakPostParametersSampleRate3? V1SpeakPostParametersSampleRate3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersSampleRate3))]
#endif
        public bool IsV1SpeakPostParametersSampleRate3 => V1SpeakPostParametersSampleRate3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersSampleRate3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V1SpeakPostParametersSampleRate3? value)
        {
            value = V1SpeakPostParametersSampleRate3;
            return IsV1SpeakPostParametersSampleRate3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V1SpeakPostParametersSampleRate3 PickV1SpeakPostParametersSampleRate3() => IsV1SpeakPostParametersSampleRate3
            ? V1SpeakPostParametersSampleRate3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1SpeakPostParametersSampleRate3' but the value was {ToString()}.");

        /// <summary>
        /// Encoding - opus. Sample rate is fixed at 48000 Hz.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1SpeakPostParametersSampleRate4? V1SpeakPostParametersSampleRate4 { get; init; }
#else
        public global::Deepgram.V1SpeakPostParametersSampleRate4? V1SpeakPostParametersSampleRate4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersSampleRate4))]
#endif
        public bool IsV1SpeakPostParametersSampleRate4 => V1SpeakPostParametersSampleRate4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersSampleRate4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V1SpeakPostParametersSampleRate4? value)
        {
            value = V1SpeakPostParametersSampleRate4;
            return IsV1SpeakPostParametersSampleRate4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V1SpeakPostParametersSampleRate4 PickV1SpeakPostParametersSampleRate4() => IsV1SpeakPostParametersSampleRate4
            ? V1SpeakPostParametersSampleRate4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1SpeakPostParametersSampleRate4' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersSampleRate(global::Deepgram.V1SpeakPostParametersSampleRate0 value) => new V1SpeakPostParametersSampleRate((global::Deepgram.V1SpeakPostParametersSampleRate0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1SpeakPostParametersSampleRate0?(V1SpeakPostParametersSampleRate @this) => @this.V1SpeakPostParametersSampleRate0;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersSampleRate(global::Deepgram.V1SpeakPostParametersSampleRate0? value)
        {
            V1SpeakPostParametersSampleRate0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V1SpeakPostParametersSampleRate FromV1SpeakPostParametersSampleRate0(global::Deepgram.V1SpeakPostParametersSampleRate0? value) => new V1SpeakPostParametersSampleRate(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersSampleRate(global::Deepgram.V1SpeakPostParametersSampleRate1 value) => new V1SpeakPostParametersSampleRate((global::Deepgram.V1SpeakPostParametersSampleRate1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1SpeakPostParametersSampleRate1?(V1SpeakPostParametersSampleRate @this) => @this.V1SpeakPostParametersSampleRate1;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersSampleRate(global::Deepgram.V1SpeakPostParametersSampleRate1? value)
        {
            V1SpeakPostParametersSampleRate1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V1SpeakPostParametersSampleRate FromV1SpeakPostParametersSampleRate1(global::Deepgram.V1SpeakPostParametersSampleRate1? value) => new V1SpeakPostParametersSampleRate(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersSampleRate(global::Deepgram.V1SpeakPostParametersSampleRate2 value) => new V1SpeakPostParametersSampleRate((global::Deepgram.V1SpeakPostParametersSampleRate2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1SpeakPostParametersSampleRate2?(V1SpeakPostParametersSampleRate @this) => @this.V1SpeakPostParametersSampleRate2;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersSampleRate(global::Deepgram.V1SpeakPostParametersSampleRate2? value)
        {
            V1SpeakPostParametersSampleRate2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V1SpeakPostParametersSampleRate FromV1SpeakPostParametersSampleRate2(global::Deepgram.V1SpeakPostParametersSampleRate2? value) => new V1SpeakPostParametersSampleRate(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersSampleRate(global::Deepgram.V1SpeakPostParametersSampleRate3 value) => new V1SpeakPostParametersSampleRate((global::Deepgram.V1SpeakPostParametersSampleRate3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1SpeakPostParametersSampleRate3?(V1SpeakPostParametersSampleRate @this) => @this.V1SpeakPostParametersSampleRate3;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersSampleRate(global::Deepgram.V1SpeakPostParametersSampleRate3? value)
        {
            V1SpeakPostParametersSampleRate3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V1SpeakPostParametersSampleRate FromV1SpeakPostParametersSampleRate3(global::Deepgram.V1SpeakPostParametersSampleRate3? value) => new V1SpeakPostParametersSampleRate(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersSampleRate(global::Deepgram.V1SpeakPostParametersSampleRate4 value) => new V1SpeakPostParametersSampleRate((global::Deepgram.V1SpeakPostParametersSampleRate4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1SpeakPostParametersSampleRate4?(V1SpeakPostParametersSampleRate @this) => @this.V1SpeakPostParametersSampleRate4;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersSampleRate(global::Deepgram.V1SpeakPostParametersSampleRate4? value)
        {
            V1SpeakPostParametersSampleRate4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V1SpeakPostParametersSampleRate FromV1SpeakPostParametersSampleRate4(global::Deepgram.V1SpeakPostParametersSampleRate4? value) => new V1SpeakPostParametersSampleRate(value);

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersSampleRate(
            global::Deepgram.V1SpeakPostParametersSampleRate0? v1SpeakPostParametersSampleRate0,
            global::Deepgram.V1SpeakPostParametersSampleRate1? v1SpeakPostParametersSampleRate1,
            global::Deepgram.V1SpeakPostParametersSampleRate2? v1SpeakPostParametersSampleRate2,
            global::Deepgram.V1SpeakPostParametersSampleRate3? v1SpeakPostParametersSampleRate3,
            global::Deepgram.V1SpeakPostParametersSampleRate4? v1SpeakPostParametersSampleRate4
            )
        {
            V1SpeakPostParametersSampleRate0 = v1SpeakPostParametersSampleRate0;
            V1SpeakPostParametersSampleRate1 = v1SpeakPostParametersSampleRate1;
            V1SpeakPostParametersSampleRate2 = v1SpeakPostParametersSampleRate2;
            V1SpeakPostParametersSampleRate3 = v1SpeakPostParametersSampleRate3;
            V1SpeakPostParametersSampleRate4 = v1SpeakPostParametersSampleRate4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1SpeakPostParametersSampleRate4 as object ??
            V1SpeakPostParametersSampleRate3 as object ??
            V1SpeakPostParametersSampleRate2 as object ??
            V1SpeakPostParametersSampleRate1 as object ??
            V1SpeakPostParametersSampleRate0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1SpeakPostParametersSampleRate0?.ToValueString() ??
            V1SpeakPostParametersSampleRate1?.ToValueString() ??
            V1SpeakPostParametersSampleRate2?.ToValueString() ??
            V1SpeakPostParametersSampleRate3?.ToValueString() ??
            V1SpeakPostParametersSampleRate4?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1SpeakPostParametersSampleRate0 && !IsV1SpeakPostParametersSampleRate1 && !IsV1SpeakPostParametersSampleRate2 && !IsV1SpeakPostParametersSampleRate3 && !IsV1SpeakPostParametersSampleRate4 || !IsV1SpeakPostParametersSampleRate0 && IsV1SpeakPostParametersSampleRate1 && !IsV1SpeakPostParametersSampleRate2 && !IsV1SpeakPostParametersSampleRate3 && !IsV1SpeakPostParametersSampleRate4 || !IsV1SpeakPostParametersSampleRate0 && !IsV1SpeakPostParametersSampleRate1 && IsV1SpeakPostParametersSampleRate2 && !IsV1SpeakPostParametersSampleRate3 && !IsV1SpeakPostParametersSampleRate4 || !IsV1SpeakPostParametersSampleRate0 && !IsV1SpeakPostParametersSampleRate1 && !IsV1SpeakPostParametersSampleRate2 && IsV1SpeakPostParametersSampleRate3 && !IsV1SpeakPostParametersSampleRate4 || !IsV1SpeakPostParametersSampleRate0 && !IsV1SpeakPostParametersSampleRate1 && !IsV1SpeakPostParametersSampleRate2 && !IsV1SpeakPostParametersSampleRate3 && IsV1SpeakPostParametersSampleRate4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.V1SpeakPostParametersSampleRate0?, TResult>? v1SpeakPostParametersSampleRate0 = null,
            global::System.Func<global::Deepgram.V1SpeakPostParametersSampleRate1?, TResult>? v1SpeakPostParametersSampleRate1 = null,
            global::System.Func<global::Deepgram.V1SpeakPostParametersSampleRate2?, TResult>? v1SpeakPostParametersSampleRate2 = null,
            global::System.Func<global::Deepgram.V1SpeakPostParametersSampleRate3?, TResult>? v1SpeakPostParametersSampleRate3 = null,
            global::System.Func<global::Deepgram.V1SpeakPostParametersSampleRate4?, TResult>? v1SpeakPostParametersSampleRate4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1SpeakPostParametersSampleRate0 && v1SpeakPostParametersSampleRate0 != null)
            {
                return v1SpeakPostParametersSampleRate0(V1SpeakPostParametersSampleRate0!);
            }
            else if (IsV1SpeakPostParametersSampleRate1 && v1SpeakPostParametersSampleRate1 != null)
            {
                return v1SpeakPostParametersSampleRate1(V1SpeakPostParametersSampleRate1!);
            }
            else if (IsV1SpeakPostParametersSampleRate2 && v1SpeakPostParametersSampleRate2 != null)
            {
                return v1SpeakPostParametersSampleRate2(V1SpeakPostParametersSampleRate2!);
            }
            else if (IsV1SpeakPostParametersSampleRate3 && v1SpeakPostParametersSampleRate3 != null)
            {
                return v1SpeakPostParametersSampleRate3(V1SpeakPostParametersSampleRate3!);
            }
            else if (IsV1SpeakPostParametersSampleRate4 && v1SpeakPostParametersSampleRate4 != null)
            {
                return v1SpeakPostParametersSampleRate4(V1SpeakPostParametersSampleRate4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.V1SpeakPostParametersSampleRate0?>? v1SpeakPostParametersSampleRate0 = null,

            global::System.Action<global::Deepgram.V1SpeakPostParametersSampleRate1?>? v1SpeakPostParametersSampleRate1 = null,

            global::System.Action<global::Deepgram.V1SpeakPostParametersSampleRate2?>? v1SpeakPostParametersSampleRate2 = null,

            global::System.Action<global::Deepgram.V1SpeakPostParametersSampleRate3?>? v1SpeakPostParametersSampleRate3 = null,

            global::System.Action<global::Deepgram.V1SpeakPostParametersSampleRate4?>? v1SpeakPostParametersSampleRate4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1SpeakPostParametersSampleRate0)
            {
                v1SpeakPostParametersSampleRate0?.Invoke(V1SpeakPostParametersSampleRate0!);
            }
            else if (IsV1SpeakPostParametersSampleRate1)
            {
                v1SpeakPostParametersSampleRate1?.Invoke(V1SpeakPostParametersSampleRate1!);
            }
            else if (IsV1SpeakPostParametersSampleRate2)
            {
                v1SpeakPostParametersSampleRate2?.Invoke(V1SpeakPostParametersSampleRate2!);
            }
            else if (IsV1SpeakPostParametersSampleRate3)
            {
                v1SpeakPostParametersSampleRate3?.Invoke(V1SpeakPostParametersSampleRate3!);
            }
            else if (IsV1SpeakPostParametersSampleRate4)
            {
                v1SpeakPostParametersSampleRate4?.Invoke(V1SpeakPostParametersSampleRate4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.V1SpeakPostParametersSampleRate0?>? v1SpeakPostParametersSampleRate0 = null,
            global::System.Action<global::Deepgram.V1SpeakPostParametersSampleRate1?>? v1SpeakPostParametersSampleRate1 = null,
            global::System.Action<global::Deepgram.V1SpeakPostParametersSampleRate2?>? v1SpeakPostParametersSampleRate2 = null,
            global::System.Action<global::Deepgram.V1SpeakPostParametersSampleRate3?>? v1SpeakPostParametersSampleRate3 = null,
            global::System.Action<global::Deepgram.V1SpeakPostParametersSampleRate4?>? v1SpeakPostParametersSampleRate4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1SpeakPostParametersSampleRate0)
            {
                v1SpeakPostParametersSampleRate0?.Invoke(V1SpeakPostParametersSampleRate0!);
            }
            else if (IsV1SpeakPostParametersSampleRate1)
            {
                v1SpeakPostParametersSampleRate1?.Invoke(V1SpeakPostParametersSampleRate1!);
            }
            else if (IsV1SpeakPostParametersSampleRate2)
            {
                v1SpeakPostParametersSampleRate2?.Invoke(V1SpeakPostParametersSampleRate2!);
            }
            else if (IsV1SpeakPostParametersSampleRate3)
            {
                v1SpeakPostParametersSampleRate3?.Invoke(V1SpeakPostParametersSampleRate3!);
            }
            else if (IsV1SpeakPostParametersSampleRate4)
            {
                v1SpeakPostParametersSampleRate4?.Invoke(V1SpeakPostParametersSampleRate4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1SpeakPostParametersSampleRate0,
                typeof(global::Deepgram.V1SpeakPostParametersSampleRate0),
                V1SpeakPostParametersSampleRate1,
                typeof(global::Deepgram.V1SpeakPostParametersSampleRate1),
                V1SpeakPostParametersSampleRate2,
                typeof(global::Deepgram.V1SpeakPostParametersSampleRate2),
                V1SpeakPostParametersSampleRate3,
                typeof(global::Deepgram.V1SpeakPostParametersSampleRate3),
                V1SpeakPostParametersSampleRate4,
                typeof(global::Deepgram.V1SpeakPostParametersSampleRate4),
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
        public bool Equals(V1SpeakPostParametersSampleRate other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1SpeakPostParametersSampleRate0?>.Default.Equals(V1SpeakPostParametersSampleRate0, other.V1SpeakPostParametersSampleRate0) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1SpeakPostParametersSampleRate1?>.Default.Equals(V1SpeakPostParametersSampleRate1, other.V1SpeakPostParametersSampleRate1) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1SpeakPostParametersSampleRate2?>.Default.Equals(V1SpeakPostParametersSampleRate2, other.V1SpeakPostParametersSampleRate2) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1SpeakPostParametersSampleRate3?>.Default.Equals(V1SpeakPostParametersSampleRate3, other.V1SpeakPostParametersSampleRate3) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1SpeakPostParametersSampleRate4?>.Default.Equals(V1SpeakPostParametersSampleRate4, other.V1SpeakPostParametersSampleRate4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1SpeakPostParametersSampleRate obj1, V1SpeakPostParametersSampleRate obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1SpeakPostParametersSampleRate>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1SpeakPostParametersSampleRate obj1, V1SpeakPostParametersSampleRate obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1SpeakPostParametersSampleRate o && Equals(o);
        }
    }
}
