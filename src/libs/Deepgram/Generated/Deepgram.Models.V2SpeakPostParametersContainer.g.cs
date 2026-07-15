#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V2SpeakPostParametersContainer : global::System.IEquatable<V2SpeakPostParametersContainer>
    {
        /// <summary>
        /// No container.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V2SpeakPostParametersContainer0? V2SpeakPostParametersContainer0 { get; init; }
#else
        public global::Deepgram.V2SpeakPostParametersContainer0? V2SpeakPostParametersContainer0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersContainer0))]
#endif
        public bool IsV2SpeakPostParametersContainer0 => V2SpeakPostParametersContainer0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersContainer0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V2SpeakPostParametersContainer0? value)
        {
            value = V2SpeakPostParametersContainer0;
            return IsV2SpeakPostParametersContainer0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V2SpeakPostParametersContainer0 PickV2SpeakPostParametersContainer0() => IsV2SpeakPostParametersContainer0
            ? V2SpeakPostParametersContainer0!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersContainer0' but the value was {ToString()}.");

        /// <summary>
        /// Encoding - linear16. Supported container - wav (default), or no container.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V2SpeakPostParametersContainer1? V2SpeakPostParametersContainer1 { get; init; }
#else
        public global::Deepgram.V2SpeakPostParametersContainer1? V2SpeakPostParametersContainer1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersContainer1))]
#endif
        public bool IsV2SpeakPostParametersContainer1 => V2SpeakPostParametersContainer1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersContainer1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V2SpeakPostParametersContainer1? value)
        {
            value = V2SpeakPostParametersContainer1;
            return IsV2SpeakPostParametersContainer1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V2SpeakPostParametersContainer1 PickV2SpeakPostParametersContainer1() => IsV2SpeakPostParametersContainer1
            ? V2SpeakPostParametersContainer1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersContainer1' but the value was {ToString()}.");

        /// <summary>
        /// Encoding - mulaw. Supported container - wav (default), or no container.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V2SpeakPostParametersContainer2? V2SpeakPostParametersContainer2 { get; init; }
#else
        public global::Deepgram.V2SpeakPostParametersContainer2? V2SpeakPostParametersContainer2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersContainer2))]
#endif
        public bool IsV2SpeakPostParametersContainer2 => V2SpeakPostParametersContainer2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersContainer2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V2SpeakPostParametersContainer2? value)
        {
            value = V2SpeakPostParametersContainer2;
            return IsV2SpeakPostParametersContainer2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V2SpeakPostParametersContainer2 PickV2SpeakPostParametersContainer2() => IsV2SpeakPostParametersContainer2
            ? V2SpeakPostParametersContainer2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersContainer2' but the value was {ToString()}.");

        /// <summary>
        /// Encoding - alaw. Supported container - wav (default), or no container.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V2SpeakPostParametersContainer3? V2SpeakPostParametersContainer3 { get; init; }
#else
        public global::Deepgram.V2SpeakPostParametersContainer3? V2SpeakPostParametersContainer3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersContainer3))]
#endif
        public bool IsV2SpeakPostParametersContainer3 => V2SpeakPostParametersContainer3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersContainer3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V2SpeakPostParametersContainer3? value)
        {
            value = V2SpeakPostParametersContainer3;
            return IsV2SpeakPostParametersContainer3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V2SpeakPostParametersContainer3 PickV2SpeakPostParametersContainer3() => IsV2SpeakPostParametersContainer3
            ? V2SpeakPostParametersContainer3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersContainer3' but the value was {ToString()}.");

        /// <summary>
        /// Encoding - opus. Supported container - ogg (default).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V2SpeakPostParametersContainer4? V2SpeakPostParametersContainer4 { get; init; }
#else
        public global::Deepgram.V2SpeakPostParametersContainer4? V2SpeakPostParametersContainer4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersContainer4))]
#endif
        public bool IsV2SpeakPostParametersContainer4 => V2SpeakPostParametersContainer4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersContainer4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V2SpeakPostParametersContainer4? value)
        {
            value = V2SpeakPostParametersContainer4;
            return IsV2SpeakPostParametersContainer4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V2SpeakPostParametersContainer4 PickV2SpeakPostParametersContainer4() => IsV2SpeakPostParametersContainer4
            ? V2SpeakPostParametersContainer4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersContainer4' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2SpeakPostParametersContainer(global::Deepgram.V2SpeakPostParametersContainer0 value) => new V2SpeakPostParametersContainer((global::Deepgram.V2SpeakPostParametersContainer0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V2SpeakPostParametersContainer0?(V2SpeakPostParametersContainer @this) => @this.V2SpeakPostParametersContainer0;

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersContainer(global::Deepgram.V2SpeakPostParametersContainer0? value)
        {
            V2SpeakPostParametersContainer0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2SpeakPostParametersContainer FromV2SpeakPostParametersContainer0(global::Deepgram.V2SpeakPostParametersContainer0? value) => new V2SpeakPostParametersContainer(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2SpeakPostParametersContainer(global::Deepgram.V2SpeakPostParametersContainer1 value) => new V2SpeakPostParametersContainer((global::Deepgram.V2SpeakPostParametersContainer1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V2SpeakPostParametersContainer1?(V2SpeakPostParametersContainer @this) => @this.V2SpeakPostParametersContainer1;

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersContainer(global::Deepgram.V2SpeakPostParametersContainer1? value)
        {
            V2SpeakPostParametersContainer1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2SpeakPostParametersContainer FromV2SpeakPostParametersContainer1(global::Deepgram.V2SpeakPostParametersContainer1? value) => new V2SpeakPostParametersContainer(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2SpeakPostParametersContainer(global::Deepgram.V2SpeakPostParametersContainer2 value) => new V2SpeakPostParametersContainer((global::Deepgram.V2SpeakPostParametersContainer2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V2SpeakPostParametersContainer2?(V2SpeakPostParametersContainer @this) => @this.V2SpeakPostParametersContainer2;

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersContainer(global::Deepgram.V2SpeakPostParametersContainer2? value)
        {
            V2SpeakPostParametersContainer2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2SpeakPostParametersContainer FromV2SpeakPostParametersContainer2(global::Deepgram.V2SpeakPostParametersContainer2? value) => new V2SpeakPostParametersContainer(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2SpeakPostParametersContainer(global::Deepgram.V2SpeakPostParametersContainer3 value) => new V2SpeakPostParametersContainer((global::Deepgram.V2SpeakPostParametersContainer3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V2SpeakPostParametersContainer3?(V2SpeakPostParametersContainer @this) => @this.V2SpeakPostParametersContainer3;

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersContainer(global::Deepgram.V2SpeakPostParametersContainer3? value)
        {
            V2SpeakPostParametersContainer3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2SpeakPostParametersContainer FromV2SpeakPostParametersContainer3(global::Deepgram.V2SpeakPostParametersContainer3? value) => new V2SpeakPostParametersContainer(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2SpeakPostParametersContainer(global::Deepgram.V2SpeakPostParametersContainer4 value) => new V2SpeakPostParametersContainer((global::Deepgram.V2SpeakPostParametersContainer4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V2SpeakPostParametersContainer4?(V2SpeakPostParametersContainer @this) => @this.V2SpeakPostParametersContainer4;

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersContainer(global::Deepgram.V2SpeakPostParametersContainer4? value)
        {
            V2SpeakPostParametersContainer4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2SpeakPostParametersContainer FromV2SpeakPostParametersContainer4(global::Deepgram.V2SpeakPostParametersContainer4? value) => new V2SpeakPostParametersContainer(value);

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersContainer(
            global::Deepgram.V2SpeakPostParametersContainer0? v2SpeakPostParametersContainer0,
            global::Deepgram.V2SpeakPostParametersContainer1? v2SpeakPostParametersContainer1,
            global::Deepgram.V2SpeakPostParametersContainer2? v2SpeakPostParametersContainer2,
            global::Deepgram.V2SpeakPostParametersContainer3? v2SpeakPostParametersContainer3,
            global::Deepgram.V2SpeakPostParametersContainer4? v2SpeakPostParametersContainer4
            )
        {
            V2SpeakPostParametersContainer0 = v2SpeakPostParametersContainer0;
            V2SpeakPostParametersContainer1 = v2SpeakPostParametersContainer1;
            V2SpeakPostParametersContainer2 = v2SpeakPostParametersContainer2;
            V2SpeakPostParametersContainer3 = v2SpeakPostParametersContainer3;
            V2SpeakPostParametersContainer4 = v2SpeakPostParametersContainer4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V2SpeakPostParametersContainer4 as object ??
            V2SpeakPostParametersContainer3 as object ??
            V2SpeakPostParametersContainer2 as object ??
            V2SpeakPostParametersContainer1 as object ??
            V2SpeakPostParametersContainer0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V2SpeakPostParametersContainer0?.ToValueString() ??
            V2SpeakPostParametersContainer1?.ToValueString() ??
            V2SpeakPostParametersContainer2?.ToValueString() ??
            V2SpeakPostParametersContainer3?.ToValueString() ??
            V2SpeakPostParametersContainer4?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV2SpeakPostParametersContainer0 && !IsV2SpeakPostParametersContainer1 && !IsV2SpeakPostParametersContainer2 && !IsV2SpeakPostParametersContainer3 && !IsV2SpeakPostParametersContainer4 || !IsV2SpeakPostParametersContainer0 && IsV2SpeakPostParametersContainer1 && !IsV2SpeakPostParametersContainer2 && !IsV2SpeakPostParametersContainer3 && !IsV2SpeakPostParametersContainer4 || !IsV2SpeakPostParametersContainer0 && !IsV2SpeakPostParametersContainer1 && IsV2SpeakPostParametersContainer2 && !IsV2SpeakPostParametersContainer3 && !IsV2SpeakPostParametersContainer4 || !IsV2SpeakPostParametersContainer0 && !IsV2SpeakPostParametersContainer1 && !IsV2SpeakPostParametersContainer2 && IsV2SpeakPostParametersContainer3 && !IsV2SpeakPostParametersContainer4 || !IsV2SpeakPostParametersContainer0 && !IsV2SpeakPostParametersContainer1 && !IsV2SpeakPostParametersContainer2 && !IsV2SpeakPostParametersContainer3 && IsV2SpeakPostParametersContainer4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.V2SpeakPostParametersContainer0?, TResult>? v2SpeakPostParametersContainer0 = null,
            global::System.Func<global::Deepgram.V2SpeakPostParametersContainer1?, TResult>? v2SpeakPostParametersContainer1 = null,
            global::System.Func<global::Deepgram.V2SpeakPostParametersContainer2?, TResult>? v2SpeakPostParametersContainer2 = null,
            global::System.Func<global::Deepgram.V2SpeakPostParametersContainer3?, TResult>? v2SpeakPostParametersContainer3 = null,
            global::System.Func<global::Deepgram.V2SpeakPostParametersContainer4?, TResult>? v2SpeakPostParametersContainer4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2SpeakPostParametersContainer0 && v2SpeakPostParametersContainer0 != null)
            {
                return v2SpeakPostParametersContainer0(V2SpeakPostParametersContainer0!);
            }
            else if (IsV2SpeakPostParametersContainer1 && v2SpeakPostParametersContainer1 != null)
            {
                return v2SpeakPostParametersContainer1(V2SpeakPostParametersContainer1!);
            }
            else if (IsV2SpeakPostParametersContainer2 && v2SpeakPostParametersContainer2 != null)
            {
                return v2SpeakPostParametersContainer2(V2SpeakPostParametersContainer2!);
            }
            else if (IsV2SpeakPostParametersContainer3 && v2SpeakPostParametersContainer3 != null)
            {
                return v2SpeakPostParametersContainer3(V2SpeakPostParametersContainer3!);
            }
            else if (IsV2SpeakPostParametersContainer4 && v2SpeakPostParametersContainer4 != null)
            {
                return v2SpeakPostParametersContainer4(V2SpeakPostParametersContainer4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.V2SpeakPostParametersContainer0?>? v2SpeakPostParametersContainer0 = null,

            global::System.Action<global::Deepgram.V2SpeakPostParametersContainer1?>? v2SpeakPostParametersContainer1 = null,

            global::System.Action<global::Deepgram.V2SpeakPostParametersContainer2?>? v2SpeakPostParametersContainer2 = null,

            global::System.Action<global::Deepgram.V2SpeakPostParametersContainer3?>? v2SpeakPostParametersContainer3 = null,

            global::System.Action<global::Deepgram.V2SpeakPostParametersContainer4?>? v2SpeakPostParametersContainer4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2SpeakPostParametersContainer0)
            {
                v2SpeakPostParametersContainer0?.Invoke(V2SpeakPostParametersContainer0!);
            }
            else if (IsV2SpeakPostParametersContainer1)
            {
                v2SpeakPostParametersContainer1?.Invoke(V2SpeakPostParametersContainer1!);
            }
            else if (IsV2SpeakPostParametersContainer2)
            {
                v2SpeakPostParametersContainer2?.Invoke(V2SpeakPostParametersContainer2!);
            }
            else if (IsV2SpeakPostParametersContainer3)
            {
                v2SpeakPostParametersContainer3?.Invoke(V2SpeakPostParametersContainer3!);
            }
            else if (IsV2SpeakPostParametersContainer4)
            {
                v2SpeakPostParametersContainer4?.Invoke(V2SpeakPostParametersContainer4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.V2SpeakPostParametersContainer0?>? v2SpeakPostParametersContainer0 = null,
            global::System.Action<global::Deepgram.V2SpeakPostParametersContainer1?>? v2SpeakPostParametersContainer1 = null,
            global::System.Action<global::Deepgram.V2SpeakPostParametersContainer2?>? v2SpeakPostParametersContainer2 = null,
            global::System.Action<global::Deepgram.V2SpeakPostParametersContainer3?>? v2SpeakPostParametersContainer3 = null,
            global::System.Action<global::Deepgram.V2SpeakPostParametersContainer4?>? v2SpeakPostParametersContainer4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2SpeakPostParametersContainer0)
            {
                v2SpeakPostParametersContainer0?.Invoke(V2SpeakPostParametersContainer0!);
            }
            else if (IsV2SpeakPostParametersContainer1)
            {
                v2SpeakPostParametersContainer1?.Invoke(V2SpeakPostParametersContainer1!);
            }
            else if (IsV2SpeakPostParametersContainer2)
            {
                v2SpeakPostParametersContainer2?.Invoke(V2SpeakPostParametersContainer2!);
            }
            else if (IsV2SpeakPostParametersContainer3)
            {
                v2SpeakPostParametersContainer3?.Invoke(V2SpeakPostParametersContainer3!);
            }
            else if (IsV2SpeakPostParametersContainer4)
            {
                v2SpeakPostParametersContainer4?.Invoke(V2SpeakPostParametersContainer4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V2SpeakPostParametersContainer0,
                typeof(global::Deepgram.V2SpeakPostParametersContainer0),
                V2SpeakPostParametersContainer1,
                typeof(global::Deepgram.V2SpeakPostParametersContainer1),
                V2SpeakPostParametersContainer2,
                typeof(global::Deepgram.V2SpeakPostParametersContainer2),
                V2SpeakPostParametersContainer3,
                typeof(global::Deepgram.V2SpeakPostParametersContainer3),
                V2SpeakPostParametersContainer4,
                typeof(global::Deepgram.V2SpeakPostParametersContainer4),
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
        public bool Equals(V2SpeakPostParametersContainer other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V2SpeakPostParametersContainer0?>.Default.Equals(V2SpeakPostParametersContainer0, other.V2SpeakPostParametersContainer0) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V2SpeakPostParametersContainer1?>.Default.Equals(V2SpeakPostParametersContainer1, other.V2SpeakPostParametersContainer1) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V2SpeakPostParametersContainer2?>.Default.Equals(V2SpeakPostParametersContainer2, other.V2SpeakPostParametersContainer2) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V2SpeakPostParametersContainer3?>.Default.Equals(V2SpeakPostParametersContainer3, other.V2SpeakPostParametersContainer3) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V2SpeakPostParametersContainer4?>.Default.Equals(V2SpeakPostParametersContainer4, other.V2SpeakPostParametersContainer4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V2SpeakPostParametersContainer obj1, V2SpeakPostParametersContainer obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V2SpeakPostParametersContainer>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V2SpeakPostParametersContainer obj1, V2SpeakPostParametersContainer obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V2SpeakPostParametersContainer o && Equals(o);
        }
    }
}
