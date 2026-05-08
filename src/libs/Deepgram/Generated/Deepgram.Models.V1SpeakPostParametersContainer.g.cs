#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1SpeakPostParametersContainer : global::System.IEquatable<V1SpeakPostParametersContainer>
    {
        /// <summary>
        /// No container.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1SpeakPostParametersContainer0? V1SpeakPostParametersContainer0 { get; init; }
#else
        public global::Deepgram.V1SpeakPostParametersContainer0? V1SpeakPostParametersContainer0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersContainer0))]
#endif
        public bool IsV1SpeakPostParametersContainer0 => V1SpeakPostParametersContainer0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersContainer0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V1SpeakPostParametersContainer0? value)
        {
            value = V1SpeakPostParametersContainer0;
            return IsV1SpeakPostParametersContainer0;
        }

        /// <summary>
        /// Encoding - linear16. Supported container - wav (default), or no container.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1SpeakPostParametersContainer1? V1SpeakPostParametersContainer1 { get; init; }
#else
        public global::Deepgram.V1SpeakPostParametersContainer1? V1SpeakPostParametersContainer1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersContainer1))]
#endif
        public bool IsV1SpeakPostParametersContainer1 => V1SpeakPostParametersContainer1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersContainer1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V1SpeakPostParametersContainer1? value)
        {
            value = V1SpeakPostParametersContainer1;
            return IsV1SpeakPostParametersContainer1;
        }

        /// <summary>
        /// Encoding - mulaw. Supported container - wav (default), or no container.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1SpeakPostParametersContainer2? V1SpeakPostParametersContainer2 { get; init; }
#else
        public global::Deepgram.V1SpeakPostParametersContainer2? V1SpeakPostParametersContainer2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersContainer2))]
#endif
        public bool IsV1SpeakPostParametersContainer2 => V1SpeakPostParametersContainer2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersContainer2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V1SpeakPostParametersContainer2? value)
        {
            value = V1SpeakPostParametersContainer2;
            return IsV1SpeakPostParametersContainer2;
        }

        /// <summary>
        /// Encoding - alaw. Supported container - wav (default), or no container.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1SpeakPostParametersContainer3? V1SpeakPostParametersContainer3 { get; init; }
#else
        public global::Deepgram.V1SpeakPostParametersContainer3? V1SpeakPostParametersContainer3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersContainer3))]
#endif
        public bool IsV1SpeakPostParametersContainer3 => V1SpeakPostParametersContainer3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersContainer3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V1SpeakPostParametersContainer3? value)
        {
            value = V1SpeakPostParametersContainer3;
            return IsV1SpeakPostParametersContainer3;
        }

        /// <summary>
        /// Encoding - opus. Supported container - ogg (default).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1SpeakPostParametersContainer4? V1SpeakPostParametersContainer4 { get; init; }
#else
        public global::Deepgram.V1SpeakPostParametersContainer4? V1SpeakPostParametersContainer4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersContainer4))]
#endif
        public bool IsV1SpeakPostParametersContainer4 => V1SpeakPostParametersContainer4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersContainer4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V1SpeakPostParametersContainer4? value)
        {
            value = V1SpeakPostParametersContainer4;
            return IsV1SpeakPostParametersContainer4;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersContainer(global::Deepgram.V1SpeakPostParametersContainer0 value) => new V1SpeakPostParametersContainer((global::Deepgram.V1SpeakPostParametersContainer0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1SpeakPostParametersContainer0?(V1SpeakPostParametersContainer @this) => @this.V1SpeakPostParametersContainer0;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersContainer(global::Deepgram.V1SpeakPostParametersContainer0? value)
        {
            V1SpeakPostParametersContainer0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersContainer(global::Deepgram.V1SpeakPostParametersContainer1 value) => new V1SpeakPostParametersContainer((global::Deepgram.V1SpeakPostParametersContainer1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1SpeakPostParametersContainer1?(V1SpeakPostParametersContainer @this) => @this.V1SpeakPostParametersContainer1;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersContainer(global::Deepgram.V1SpeakPostParametersContainer1? value)
        {
            V1SpeakPostParametersContainer1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersContainer(global::Deepgram.V1SpeakPostParametersContainer2 value) => new V1SpeakPostParametersContainer((global::Deepgram.V1SpeakPostParametersContainer2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1SpeakPostParametersContainer2?(V1SpeakPostParametersContainer @this) => @this.V1SpeakPostParametersContainer2;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersContainer(global::Deepgram.V1SpeakPostParametersContainer2? value)
        {
            V1SpeakPostParametersContainer2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersContainer(global::Deepgram.V1SpeakPostParametersContainer3 value) => new V1SpeakPostParametersContainer((global::Deepgram.V1SpeakPostParametersContainer3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1SpeakPostParametersContainer3?(V1SpeakPostParametersContainer @this) => @this.V1SpeakPostParametersContainer3;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersContainer(global::Deepgram.V1SpeakPostParametersContainer3? value)
        {
            V1SpeakPostParametersContainer3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersContainer(global::Deepgram.V1SpeakPostParametersContainer4 value) => new V1SpeakPostParametersContainer((global::Deepgram.V1SpeakPostParametersContainer4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1SpeakPostParametersContainer4?(V1SpeakPostParametersContainer @this) => @this.V1SpeakPostParametersContainer4;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersContainer(global::Deepgram.V1SpeakPostParametersContainer4? value)
        {
            V1SpeakPostParametersContainer4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersContainer(
            global::Deepgram.V1SpeakPostParametersContainer0? v1SpeakPostParametersContainer0,
            global::Deepgram.V1SpeakPostParametersContainer1? v1SpeakPostParametersContainer1,
            global::Deepgram.V1SpeakPostParametersContainer2? v1SpeakPostParametersContainer2,
            global::Deepgram.V1SpeakPostParametersContainer3? v1SpeakPostParametersContainer3,
            global::Deepgram.V1SpeakPostParametersContainer4? v1SpeakPostParametersContainer4
            )
        {
            V1SpeakPostParametersContainer0 = v1SpeakPostParametersContainer0;
            V1SpeakPostParametersContainer1 = v1SpeakPostParametersContainer1;
            V1SpeakPostParametersContainer2 = v1SpeakPostParametersContainer2;
            V1SpeakPostParametersContainer3 = v1SpeakPostParametersContainer3;
            V1SpeakPostParametersContainer4 = v1SpeakPostParametersContainer4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1SpeakPostParametersContainer4 as object ??
            V1SpeakPostParametersContainer3 as object ??
            V1SpeakPostParametersContainer2 as object ??
            V1SpeakPostParametersContainer1 as object ??
            V1SpeakPostParametersContainer0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1SpeakPostParametersContainer0?.ToValueString() ??
            V1SpeakPostParametersContainer1?.ToValueString() ??
            V1SpeakPostParametersContainer2?.ToValueString() ??
            V1SpeakPostParametersContainer3?.ToValueString() ??
            V1SpeakPostParametersContainer4?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1SpeakPostParametersContainer0 && !IsV1SpeakPostParametersContainer1 && !IsV1SpeakPostParametersContainer2 && !IsV1SpeakPostParametersContainer3 && !IsV1SpeakPostParametersContainer4 || !IsV1SpeakPostParametersContainer0 && IsV1SpeakPostParametersContainer1 && !IsV1SpeakPostParametersContainer2 && !IsV1SpeakPostParametersContainer3 && !IsV1SpeakPostParametersContainer4 || !IsV1SpeakPostParametersContainer0 && !IsV1SpeakPostParametersContainer1 && IsV1SpeakPostParametersContainer2 && !IsV1SpeakPostParametersContainer3 && !IsV1SpeakPostParametersContainer4 || !IsV1SpeakPostParametersContainer0 && !IsV1SpeakPostParametersContainer1 && !IsV1SpeakPostParametersContainer2 && IsV1SpeakPostParametersContainer3 && !IsV1SpeakPostParametersContainer4 || !IsV1SpeakPostParametersContainer0 && !IsV1SpeakPostParametersContainer1 && !IsV1SpeakPostParametersContainer2 && !IsV1SpeakPostParametersContainer3 && IsV1SpeakPostParametersContainer4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.V1SpeakPostParametersContainer0?, TResult>? v1SpeakPostParametersContainer0 = null,
            global::System.Func<global::Deepgram.V1SpeakPostParametersContainer1?, TResult>? v1SpeakPostParametersContainer1 = null,
            global::System.Func<global::Deepgram.V1SpeakPostParametersContainer2?, TResult>? v1SpeakPostParametersContainer2 = null,
            global::System.Func<global::Deepgram.V1SpeakPostParametersContainer3?, TResult>? v1SpeakPostParametersContainer3 = null,
            global::System.Func<global::Deepgram.V1SpeakPostParametersContainer4?, TResult>? v1SpeakPostParametersContainer4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1SpeakPostParametersContainer0 && v1SpeakPostParametersContainer0 != null)
            {
                return v1SpeakPostParametersContainer0(V1SpeakPostParametersContainer0!);
            }
            else if (IsV1SpeakPostParametersContainer1 && v1SpeakPostParametersContainer1 != null)
            {
                return v1SpeakPostParametersContainer1(V1SpeakPostParametersContainer1!);
            }
            else if (IsV1SpeakPostParametersContainer2 && v1SpeakPostParametersContainer2 != null)
            {
                return v1SpeakPostParametersContainer2(V1SpeakPostParametersContainer2!);
            }
            else if (IsV1SpeakPostParametersContainer3 && v1SpeakPostParametersContainer3 != null)
            {
                return v1SpeakPostParametersContainer3(V1SpeakPostParametersContainer3!);
            }
            else if (IsV1SpeakPostParametersContainer4 && v1SpeakPostParametersContainer4 != null)
            {
                return v1SpeakPostParametersContainer4(V1SpeakPostParametersContainer4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.V1SpeakPostParametersContainer0?>? v1SpeakPostParametersContainer0 = null,

            global::System.Action<global::Deepgram.V1SpeakPostParametersContainer1?>? v1SpeakPostParametersContainer1 = null,

            global::System.Action<global::Deepgram.V1SpeakPostParametersContainer2?>? v1SpeakPostParametersContainer2 = null,

            global::System.Action<global::Deepgram.V1SpeakPostParametersContainer3?>? v1SpeakPostParametersContainer3 = null,

            global::System.Action<global::Deepgram.V1SpeakPostParametersContainer4?>? v1SpeakPostParametersContainer4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1SpeakPostParametersContainer0)
            {
                v1SpeakPostParametersContainer0?.Invoke(V1SpeakPostParametersContainer0!);
            }
            else if (IsV1SpeakPostParametersContainer1)
            {
                v1SpeakPostParametersContainer1?.Invoke(V1SpeakPostParametersContainer1!);
            }
            else if (IsV1SpeakPostParametersContainer2)
            {
                v1SpeakPostParametersContainer2?.Invoke(V1SpeakPostParametersContainer2!);
            }
            else if (IsV1SpeakPostParametersContainer3)
            {
                v1SpeakPostParametersContainer3?.Invoke(V1SpeakPostParametersContainer3!);
            }
            else if (IsV1SpeakPostParametersContainer4)
            {
                v1SpeakPostParametersContainer4?.Invoke(V1SpeakPostParametersContainer4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.V1SpeakPostParametersContainer0?>? v1SpeakPostParametersContainer0 = null,
            global::System.Action<global::Deepgram.V1SpeakPostParametersContainer1?>? v1SpeakPostParametersContainer1 = null,
            global::System.Action<global::Deepgram.V1SpeakPostParametersContainer2?>? v1SpeakPostParametersContainer2 = null,
            global::System.Action<global::Deepgram.V1SpeakPostParametersContainer3?>? v1SpeakPostParametersContainer3 = null,
            global::System.Action<global::Deepgram.V1SpeakPostParametersContainer4?>? v1SpeakPostParametersContainer4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1SpeakPostParametersContainer0)
            {
                v1SpeakPostParametersContainer0?.Invoke(V1SpeakPostParametersContainer0!);
            }
            else if (IsV1SpeakPostParametersContainer1)
            {
                v1SpeakPostParametersContainer1?.Invoke(V1SpeakPostParametersContainer1!);
            }
            else if (IsV1SpeakPostParametersContainer2)
            {
                v1SpeakPostParametersContainer2?.Invoke(V1SpeakPostParametersContainer2!);
            }
            else if (IsV1SpeakPostParametersContainer3)
            {
                v1SpeakPostParametersContainer3?.Invoke(V1SpeakPostParametersContainer3!);
            }
            else if (IsV1SpeakPostParametersContainer4)
            {
                v1SpeakPostParametersContainer4?.Invoke(V1SpeakPostParametersContainer4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1SpeakPostParametersContainer0,
                typeof(global::Deepgram.V1SpeakPostParametersContainer0),
                V1SpeakPostParametersContainer1,
                typeof(global::Deepgram.V1SpeakPostParametersContainer1),
                V1SpeakPostParametersContainer2,
                typeof(global::Deepgram.V1SpeakPostParametersContainer2),
                V1SpeakPostParametersContainer3,
                typeof(global::Deepgram.V1SpeakPostParametersContainer3),
                V1SpeakPostParametersContainer4,
                typeof(global::Deepgram.V1SpeakPostParametersContainer4),
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
        public bool Equals(V1SpeakPostParametersContainer other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1SpeakPostParametersContainer0?>.Default.Equals(V1SpeakPostParametersContainer0, other.V1SpeakPostParametersContainer0) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1SpeakPostParametersContainer1?>.Default.Equals(V1SpeakPostParametersContainer1, other.V1SpeakPostParametersContainer1) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1SpeakPostParametersContainer2?>.Default.Equals(V1SpeakPostParametersContainer2, other.V1SpeakPostParametersContainer2) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1SpeakPostParametersContainer3?>.Default.Equals(V1SpeakPostParametersContainer3, other.V1SpeakPostParametersContainer3) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1SpeakPostParametersContainer4?>.Default.Equals(V1SpeakPostParametersContainer4, other.V1SpeakPostParametersContainer4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1SpeakPostParametersContainer obj1, V1SpeakPostParametersContainer obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1SpeakPostParametersContainer>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1SpeakPostParametersContainer obj1, V1SpeakPostParametersContainer obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1SpeakPostParametersContainer o && Equals(o);
        }
    }
}
