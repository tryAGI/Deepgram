#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V2SpeakPostParametersSampleRate : global::System.IEquatable<V2SpeakPostParametersSampleRate>
    {
        /// <summary>
        /// Encoding - linear16. Supported sample rates - 8000, 16000, 24000, 32000, 44100, 48000 Hz.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V2SpeakPostParametersSampleRate0? V2SpeakPostParametersSampleRate0 { get; init; }
#else
        public global::Deepgram.V2SpeakPostParametersSampleRate0? V2SpeakPostParametersSampleRate0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersSampleRate0))]
#endif
        public bool IsV2SpeakPostParametersSampleRate0 => V2SpeakPostParametersSampleRate0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersSampleRate0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V2SpeakPostParametersSampleRate0? value)
        {
            value = V2SpeakPostParametersSampleRate0;
            return IsV2SpeakPostParametersSampleRate0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V2SpeakPostParametersSampleRate0 PickV2SpeakPostParametersSampleRate0() => IsV2SpeakPostParametersSampleRate0
            ? V2SpeakPostParametersSampleRate0!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersSampleRate0' but the value was {ToString()}.");

        /// <summary>
        /// Encoding - mulaw. Supported sample rates - 8000, 16000 Hz.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V2SpeakPostParametersSampleRate1? V2SpeakPostParametersSampleRate1 { get; init; }
#else
        public global::Deepgram.V2SpeakPostParametersSampleRate1? V2SpeakPostParametersSampleRate1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersSampleRate1))]
#endif
        public bool IsV2SpeakPostParametersSampleRate1 => V2SpeakPostParametersSampleRate1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersSampleRate1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V2SpeakPostParametersSampleRate1? value)
        {
            value = V2SpeakPostParametersSampleRate1;
            return IsV2SpeakPostParametersSampleRate1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V2SpeakPostParametersSampleRate1 PickV2SpeakPostParametersSampleRate1() => IsV2SpeakPostParametersSampleRate1
            ? V2SpeakPostParametersSampleRate1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersSampleRate1' but the value was {ToString()}.");

        /// <summary>
        /// Encoding - alaw. Supported sample rates - 8000, 16000 Hz.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V2SpeakPostParametersSampleRate2? V2SpeakPostParametersSampleRate2 { get; init; }
#else
        public global::Deepgram.V2SpeakPostParametersSampleRate2? V2SpeakPostParametersSampleRate2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersSampleRate2))]
#endif
        public bool IsV2SpeakPostParametersSampleRate2 => V2SpeakPostParametersSampleRate2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersSampleRate2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V2SpeakPostParametersSampleRate2? value)
        {
            value = V2SpeakPostParametersSampleRate2;
            return IsV2SpeakPostParametersSampleRate2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V2SpeakPostParametersSampleRate2 PickV2SpeakPostParametersSampleRate2() => IsV2SpeakPostParametersSampleRate2
            ? V2SpeakPostParametersSampleRate2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersSampleRate2' but the value was {ToString()}.");

        /// <summary>
        /// Encoding - flac. Supported sample rates - 8000, 16000, 22050, 32000, 48000 Hz.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V2SpeakPostParametersSampleRate3? V2SpeakPostParametersSampleRate3 { get; init; }
#else
        public global::Deepgram.V2SpeakPostParametersSampleRate3? V2SpeakPostParametersSampleRate3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersSampleRate3))]
#endif
        public bool IsV2SpeakPostParametersSampleRate3 => V2SpeakPostParametersSampleRate3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersSampleRate3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V2SpeakPostParametersSampleRate3? value)
        {
            value = V2SpeakPostParametersSampleRate3;
            return IsV2SpeakPostParametersSampleRate3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V2SpeakPostParametersSampleRate3 PickV2SpeakPostParametersSampleRate3() => IsV2SpeakPostParametersSampleRate3
            ? V2SpeakPostParametersSampleRate3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersSampleRate3' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2SpeakPostParametersSampleRate(global::Deepgram.V2SpeakPostParametersSampleRate0 value) => new V2SpeakPostParametersSampleRate((global::Deepgram.V2SpeakPostParametersSampleRate0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V2SpeakPostParametersSampleRate0?(V2SpeakPostParametersSampleRate @this) => @this.V2SpeakPostParametersSampleRate0;

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersSampleRate(global::Deepgram.V2SpeakPostParametersSampleRate0? value)
        {
            V2SpeakPostParametersSampleRate0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2SpeakPostParametersSampleRate FromV2SpeakPostParametersSampleRate0(global::Deepgram.V2SpeakPostParametersSampleRate0? value) => new V2SpeakPostParametersSampleRate(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2SpeakPostParametersSampleRate(global::Deepgram.V2SpeakPostParametersSampleRate1 value) => new V2SpeakPostParametersSampleRate((global::Deepgram.V2SpeakPostParametersSampleRate1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V2SpeakPostParametersSampleRate1?(V2SpeakPostParametersSampleRate @this) => @this.V2SpeakPostParametersSampleRate1;

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersSampleRate(global::Deepgram.V2SpeakPostParametersSampleRate1? value)
        {
            V2SpeakPostParametersSampleRate1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2SpeakPostParametersSampleRate FromV2SpeakPostParametersSampleRate1(global::Deepgram.V2SpeakPostParametersSampleRate1? value) => new V2SpeakPostParametersSampleRate(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2SpeakPostParametersSampleRate(global::Deepgram.V2SpeakPostParametersSampleRate2 value) => new V2SpeakPostParametersSampleRate((global::Deepgram.V2SpeakPostParametersSampleRate2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V2SpeakPostParametersSampleRate2?(V2SpeakPostParametersSampleRate @this) => @this.V2SpeakPostParametersSampleRate2;

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersSampleRate(global::Deepgram.V2SpeakPostParametersSampleRate2? value)
        {
            V2SpeakPostParametersSampleRate2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2SpeakPostParametersSampleRate FromV2SpeakPostParametersSampleRate2(global::Deepgram.V2SpeakPostParametersSampleRate2? value) => new V2SpeakPostParametersSampleRate(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2SpeakPostParametersSampleRate(global::Deepgram.V2SpeakPostParametersSampleRate3 value) => new V2SpeakPostParametersSampleRate((global::Deepgram.V2SpeakPostParametersSampleRate3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V2SpeakPostParametersSampleRate3?(V2SpeakPostParametersSampleRate @this) => @this.V2SpeakPostParametersSampleRate3;

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersSampleRate(global::Deepgram.V2SpeakPostParametersSampleRate3? value)
        {
            V2SpeakPostParametersSampleRate3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2SpeakPostParametersSampleRate FromV2SpeakPostParametersSampleRate3(global::Deepgram.V2SpeakPostParametersSampleRate3? value) => new V2SpeakPostParametersSampleRate(value);

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersSampleRate(
            global::Deepgram.V2SpeakPostParametersSampleRate0? v2SpeakPostParametersSampleRate0,
            global::Deepgram.V2SpeakPostParametersSampleRate1? v2SpeakPostParametersSampleRate1,
            global::Deepgram.V2SpeakPostParametersSampleRate2? v2SpeakPostParametersSampleRate2,
            global::Deepgram.V2SpeakPostParametersSampleRate3? v2SpeakPostParametersSampleRate3
            )
        {
            V2SpeakPostParametersSampleRate0 = v2SpeakPostParametersSampleRate0;
            V2SpeakPostParametersSampleRate1 = v2SpeakPostParametersSampleRate1;
            V2SpeakPostParametersSampleRate2 = v2SpeakPostParametersSampleRate2;
            V2SpeakPostParametersSampleRate3 = v2SpeakPostParametersSampleRate3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V2SpeakPostParametersSampleRate3 as object ??
            V2SpeakPostParametersSampleRate2 as object ??
            V2SpeakPostParametersSampleRate1 as object ??
            V2SpeakPostParametersSampleRate0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V2SpeakPostParametersSampleRate0?.ToValueString() ??
            V2SpeakPostParametersSampleRate1?.ToValueString() ??
            V2SpeakPostParametersSampleRate2?.ToValueString() ??
            V2SpeakPostParametersSampleRate3?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV2SpeakPostParametersSampleRate0 && !IsV2SpeakPostParametersSampleRate1 && !IsV2SpeakPostParametersSampleRate2 && !IsV2SpeakPostParametersSampleRate3 || !IsV2SpeakPostParametersSampleRate0 && IsV2SpeakPostParametersSampleRate1 && !IsV2SpeakPostParametersSampleRate2 && !IsV2SpeakPostParametersSampleRate3 || !IsV2SpeakPostParametersSampleRate0 && !IsV2SpeakPostParametersSampleRate1 && IsV2SpeakPostParametersSampleRate2 && !IsV2SpeakPostParametersSampleRate3 || !IsV2SpeakPostParametersSampleRate0 && !IsV2SpeakPostParametersSampleRate1 && !IsV2SpeakPostParametersSampleRate2 && IsV2SpeakPostParametersSampleRate3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.V2SpeakPostParametersSampleRate0?, TResult>? v2SpeakPostParametersSampleRate0 = null,
            global::System.Func<global::Deepgram.V2SpeakPostParametersSampleRate1?, TResult>? v2SpeakPostParametersSampleRate1 = null,
            global::System.Func<global::Deepgram.V2SpeakPostParametersSampleRate2?, TResult>? v2SpeakPostParametersSampleRate2 = null,
            global::System.Func<global::Deepgram.V2SpeakPostParametersSampleRate3?, TResult>? v2SpeakPostParametersSampleRate3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2SpeakPostParametersSampleRate0 && v2SpeakPostParametersSampleRate0 != null)
            {
                return v2SpeakPostParametersSampleRate0(V2SpeakPostParametersSampleRate0!);
            }
            else if (IsV2SpeakPostParametersSampleRate1 && v2SpeakPostParametersSampleRate1 != null)
            {
                return v2SpeakPostParametersSampleRate1(V2SpeakPostParametersSampleRate1!);
            }
            else if (IsV2SpeakPostParametersSampleRate2 && v2SpeakPostParametersSampleRate2 != null)
            {
                return v2SpeakPostParametersSampleRate2(V2SpeakPostParametersSampleRate2!);
            }
            else if (IsV2SpeakPostParametersSampleRate3 && v2SpeakPostParametersSampleRate3 != null)
            {
                return v2SpeakPostParametersSampleRate3(V2SpeakPostParametersSampleRate3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.V2SpeakPostParametersSampleRate0?>? v2SpeakPostParametersSampleRate0 = null,

            global::System.Action<global::Deepgram.V2SpeakPostParametersSampleRate1?>? v2SpeakPostParametersSampleRate1 = null,

            global::System.Action<global::Deepgram.V2SpeakPostParametersSampleRate2?>? v2SpeakPostParametersSampleRate2 = null,

            global::System.Action<global::Deepgram.V2SpeakPostParametersSampleRate3?>? v2SpeakPostParametersSampleRate3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2SpeakPostParametersSampleRate0)
            {
                v2SpeakPostParametersSampleRate0?.Invoke(V2SpeakPostParametersSampleRate0!);
            }
            else if (IsV2SpeakPostParametersSampleRate1)
            {
                v2SpeakPostParametersSampleRate1?.Invoke(V2SpeakPostParametersSampleRate1!);
            }
            else if (IsV2SpeakPostParametersSampleRate2)
            {
                v2SpeakPostParametersSampleRate2?.Invoke(V2SpeakPostParametersSampleRate2!);
            }
            else if (IsV2SpeakPostParametersSampleRate3)
            {
                v2SpeakPostParametersSampleRate3?.Invoke(V2SpeakPostParametersSampleRate3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.V2SpeakPostParametersSampleRate0?>? v2SpeakPostParametersSampleRate0 = null,
            global::System.Action<global::Deepgram.V2SpeakPostParametersSampleRate1?>? v2SpeakPostParametersSampleRate1 = null,
            global::System.Action<global::Deepgram.V2SpeakPostParametersSampleRate2?>? v2SpeakPostParametersSampleRate2 = null,
            global::System.Action<global::Deepgram.V2SpeakPostParametersSampleRate3?>? v2SpeakPostParametersSampleRate3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2SpeakPostParametersSampleRate0)
            {
                v2SpeakPostParametersSampleRate0?.Invoke(V2SpeakPostParametersSampleRate0!);
            }
            else if (IsV2SpeakPostParametersSampleRate1)
            {
                v2SpeakPostParametersSampleRate1?.Invoke(V2SpeakPostParametersSampleRate1!);
            }
            else if (IsV2SpeakPostParametersSampleRate2)
            {
                v2SpeakPostParametersSampleRate2?.Invoke(V2SpeakPostParametersSampleRate2!);
            }
            else if (IsV2SpeakPostParametersSampleRate3)
            {
                v2SpeakPostParametersSampleRate3?.Invoke(V2SpeakPostParametersSampleRate3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V2SpeakPostParametersSampleRate0,
                typeof(global::Deepgram.V2SpeakPostParametersSampleRate0),
                V2SpeakPostParametersSampleRate1,
                typeof(global::Deepgram.V2SpeakPostParametersSampleRate1),
                V2SpeakPostParametersSampleRate2,
                typeof(global::Deepgram.V2SpeakPostParametersSampleRate2),
                V2SpeakPostParametersSampleRate3,
                typeof(global::Deepgram.V2SpeakPostParametersSampleRate3),
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
        public bool Equals(V2SpeakPostParametersSampleRate other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V2SpeakPostParametersSampleRate0?>.Default.Equals(V2SpeakPostParametersSampleRate0, other.V2SpeakPostParametersSampleRate0) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V2SpeakPostParametersSampleRate1?>.Default.Equals(V2SpeakPostParametersSampleRate1, other.V2SpeakPostParametersSampleRate1) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V2SpeakPostParametersSampleRate2?>.Default.Equals(V2SpeakPostParametersSampleRate2, other.V2SpeakPostParametersSampleRate2) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V2SpeakPostParametersSampleRate3?>.Default.Equals(V2SpeakPostParametersSampleRate3, other.V2SpeakPostParametersSampleRate3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V2SpeakPostParametersSampleRate obj1, V2SpeakPostParametersSampleRate obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V2SpeakPostParametersSampleRate>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V2SpeakPostParametersSampleRate obj1, V2SpeakPostParametersSampleRate obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V2SpeakPostParametersSampleRate o && Equals(o);
        }
    }
}
