#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V2SpeakPostParametersEncoding : global::System.IEquatable<V2SpeakPostParametersEncoding>
    {
        /// <summary>
        /// Encoding - linear16. Uncompressed, high-quality audio format often used for telephony or audio processing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V2SpeakPostParametersEncoding0? V2SpeakPostParametersEncoding0 { get; init; }
#else
        public global::Deepgram.V2SpeakPostParametersEncoding0? V2SpeakPostParametersEncoding0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersEncoding0))]
#endif
        public bool IsV2SpeakPostParametersEncoding0 => V2SpeakPostParametersEncoding0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersEncoding0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V2SpeakPostParametersEncoding0? value)
        {
            value = V2SpeakPostParametersEncoding0;
            return IsV2SpeakPostParametersEncoding0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V2SpeakPostParametersEncoding0 PickV2SpeakPostParametersEncoding0() => IsV2SpeakPostParametersEncoding0
            ? V2SpeakPostParametersEncoding0!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersEncoding0' but the value was {ToString()}.");

        /// <summary>
        /// Encoding - flac. Lossless audio format for high-quality compression.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V2SpeakPostParametersEncoding1? V2SpeakPostParametersEncoding1 { get; init; }
#else
        public global::Deepgram.V2SpeakPostParametersEncoding1? V2SpeakPostParametersEncoding1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersEncoding1))]
#endif
        public bool IsV2SpeakPostParametersEncoding1 => V2SpeakPostParametersEncoding1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersEncoding1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V2SpeakPostParametersEncoding1? value)
        {
            value = V2SpeakPostParametersEncoding1;
            return IsV2SpeakPostParametersEncoding1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V2SpeakPostParametersEncoding1 PickV2SpeakPostParametersEncoding1() => IsV2SpeakPostParametersEncoding1
            ? V2SpeakPostParametersEncoding1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersEncoding1' but the value was {ToString()}.");

        /// <summary>
        /// Encoding - mulaw. Compressed audio format commonly used in telephony.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V2SpeakPostParametersEncoding2? V2SpeakPostParametersEncoding2 { get; init; }
#else
        public global::Deepgram.V2SpeakPostParametersEncoding2? V2SpeakPostParametersEncoding2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersEncoding2))]
#endif
        public bool IsV2SpeakPostParametersEncoding2 => V2SpeakPostParametersEncoding2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersEncoding2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V2SpeakPostParametersEncoding2? value)
        {
            value = V2SpeakPostParametersEncoding2;
            return IsV2SpeakPostParametersEncoding2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V2SpeakPostParametersEncoding2 PickV2SpeakPostParametersEncoding2() => IsV2SpeakPostParametersEncoding2
            ? V2SpeakPostParametersEncoding2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersEncoding2' but the value was {ToString()}.");

        /// <summary>
        /// Encoding - alaw. Similar to mulaw but used in international telephony.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V2SpeakPostParametersEncoding3? V2SpeakPostParametersEncoding3 { get; init; }
#else
        public global::Deepgram.V2SpeakPostParametersEncoding3? V2SpeakPostParametersEncoding3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersEncoding3))]
#endif
        public bool IsV2SpeakPostParametersEncoding3 => V2SpeakPostParametersEncoding3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersEncoding3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V2SpeakPostParametersEncoding3? value)
        {
            value = V2SpeakPostParametersEncoding3;
            return IsV2SpeakPostParametersEncoding3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V2SpeakPostParametersEncoding3 PickV2SpeakPostParametersEncoding3() => IsV2SpeakPostParametersEncoding3
            ? V2SpeakPostParametersEncoding3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersEncoding3' but the value was {ToString()}.");

        /// <summary>
        /// Encoding - mp3. Popular compressed audio format for music and streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V2SpeakPostParametersEncoding4? V2SpeakPostParametersEncoding4 { get; init; }
#else
        public global::Deepgram.V2SpeakPostParametersEncoding4? V2SpeakPostParametersEncoding4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersEncoding4))]
#endif
        public bool IsV2SpeakPostParametersEncoding4 => V2SpeakPostParametersEncoding4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersEncoding4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V2SpeakPostParametersEncoding4? value)
        {
            value = V2SpeakPostParametersEncoding4;
            return IsV2SpeakPostParametersEncoding4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V2SpeakPostParametersEncoding4 PickV2SpeakPostParametersEncoding4() => IsV2SpeakPostParametersEncoding4
            ? V2SpeakPostParametersEncoding4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersEncoding4' but the value was {ToString()}.");

        /// <summary>
        /// Encoding - opus. High-compression audio format optimized for real-time communications.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V2SpeakPostParametersEncoding5? V2SpeakPostParametersEncoding5 { get; init; }
#else
        public global::Deepgram.V2SpeakPostParametersEncoding5? V2SpeakPostParametersEncoding5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersEncoding5))]
#endif
        public bool IsV2SpeakPostParametersEncoding5 => V2SpeakPostParametersEncoding5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersEncoding5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V2SpeakPostParametersEncoding5? value)
        {
            value = V2SpeakPostParametersEncoding5;
            return IsV2SpeakPostParametersEncoding5;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V2SpeakPostParametersEncoding5 PickV2SpeakPostParametersEncoding5() => IsV2SpeakPostParametersEncoding5
            ? V2SpeakPostParametersEncoding5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersEncoding5' but the value was {ToString()}.");

        /// <summary>
        /// Encoding - aac. Advanced audio format offering better quality at smaller file sizes than mp3.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V2SpeakPostParametersEncoding6? V2SpeakPostParametersEncoding6 { get; init; }
#else
        public global::Deepgram.V2SpeakPostParametersEncoding6? V2SpeakPostParametersEncoding6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersEncoding6))]
#endif
        public bool IsV2SpeakPostParametersEncoding6 => V2SpeakPostParametersEncoding6 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersEncoding6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V2SpeakPostParametersEncoding6? value)
        {
            value = V2SpeakPostParametersEncoding6;
            return IsV2SpeakPostParametersEncoding6;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.V2SpeakPostParametersEncoding6 PickV2SpeakPostParametersEncoding6() => IsV2SpeakPostParametersEncoding6
            ? V2SpeakPostParametersEncoding6!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersEncoding6' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2SpeakPostParametersEncoding(global::Deepgram.V2SpeakPostParametersEncoding0 value) => new V2SpeakPostParametersEncoding((global::Deepgram.V2SpeakPostParametersEncoding0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V2SpeakPostParametersEncoding0?(V2SpeakPostParametersEncoding @this) => @this.V2SpeakPostParametersEncoding0;

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersEncoding(global::Deepgram.V2SpeakPostParametersEncoding0? value)
        {
            V2SpeakPostParametersEncoding0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2SpeakPostParametersEncoding FromV2SpeakPostParametersEncoding0(global::Deepgram.V2SpeakPostParametersEncoding0? value) => new V2SpeakPostParametersEncoding(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2SpeakPostParametersEncoding(global::Deepgram.V2SpeakPostParametersEncoding1 value) => new V2SpeakPostParametersEncoding((global::Deepgram.V2SpeakPostParametersEncoding1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V2SpeakPostParametersEncoding1?(V2SpeakPostParametersEncoding @this) => @this.V2SpeakPostParametersEncoding1;

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersEncoding(global::Deepgram.V2SpeakPostParametersEncoding1? value)
        {
            V2SpeakPostParametersEncoding1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2SpeakPostParametersEncoding FromV2SpeakPostParametersEncoding1(global::Deepgram.V2SpeakPostParametersEncoding1? value) => new V2SpeakPostParametersEncoding(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2SpeakPostParametersEncoding(global::Deepgram.V2SpeakPostParametersEncoding2 value) => new V2SpeakPostParametersEncoding((global::Deepgram.V2SpeakPostParametersEncoding2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V2SpeakPostParametersEncoding2?(V2SpeakPostParametersEncoding @this) => @this.V2SpeakPostParametersEncoding2;

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersEncoding(global::Deepgram.V2SpeakPostParametersEncoding2? value)
        {
            V2SpeakPostParametersEncoding2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2SpeakPostParametersEncoding FromV2SpeakPostParametersEncoding2(global::Deepgram.V2SpeakPostParametersEncoding2? value) => new V2SpeakPostParametersEncoding(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2SpeakPostParametersEncoding(global::Deepgram.V2SpeakPostParametersEncoding3 value) => new V2SpeakPostParametersEncoding((global::Deepgram.V2SpeakPostParametersEncoding3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V2SpeakPostParametersEncoding3?(V2SpeakPostParametersEncoding @this) => @this.V2SpeakPostParametersEncoding3;

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersEncoding(global::Deepgram.V2SpeakPostParametersEncoding3? value)
        {
            V2SpeakPostParametersEncoding3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2SpeakPostParametersEncoding FromV2SpeakPostParametersEncoding3(global::Deepgram.V2SpeakPostParametersEncoding3? value) => new V2SpeakPostParametersEncoding(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2SpeakPostParametersEncoding(global::Deepgram.V2SpeakPostParametersEncoding4 value) => new V2SpeakPostParametersEncoding((global::Deepgram.V2SpeakPostParametersEncoding4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V2SpeakPostParametersEncoding4?(V2SpeakPostParametersEncoding @this) => @this.V2SpeakPostParametersEncoding4;

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersEncoding(global::Deepgram.V2SpeakPostParametersEncoding4? value)
        {
            V2SpeakPostParametersEncoding4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2SpeakPostParametersEncoding FromV2SpeakPostParametersEncoding4(global::Deepgram.V2SpeakPostParametersEncoding4? value) => new V2SpeakPostParametersEncoding(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2SpeakPostParametersEncoding(global::Deepgram.V2SpeakPostParametersEncoding5 value) => new V2SpeakPostParametersEncoding((global::Deepgram.V2SpeakPostParametersEncoding5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V2SpeakPostParametersEncoding5?(V2SpeakPostParametersEncoding @this) => @this.V2SpeakPostParametersEncoding5;

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersEncoding(global::Deepgram.V2SpeakPostParametersEncoding5? value)
        {
            V2SpeakPostParametersEncoding5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2SpeakPostParametersEncoding FromV2SpeakPostParametersEncoding5(global::Deepgram.V2SpeakPostParametersEncoding5? value) => new V2SpeakPostParametersEncoding(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2SpeakPostParametersEncoding(global::Deepgram.V2SpeakPostParametersEncoding6 value) => new V2SpeakPostParametersEncoding((global::Deepgram.V2SpeakPostParametersEncoding6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V2SpeakPostParametersEncoding6?(V2SpeakPostParametersEncoding @this) => @this.V2SpeakPostParametersEncoding6;

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersEncoding(global::Deepgram.V2SpeakPostParametersEncoding6? value)
        {
            V2SpeakPostParametersEncoding6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2SpeakPostParametersEncoding FromV2SpeakPostParametersEncoding6(global::Deepgram.V2SpeakPostParametersEncoding6? value) => new V2SpeakPostParametersEncoding(value);

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersEncoding(
            global::Deepgram.V2SpeakPostParametersEncoding0? v2SpeakPostParametersEncoding0,
            global::Deepgram.V2SpeakPostParametersEncoding1? v2SpeakPostParametersEncoding1,
            global::Deepgram.V2SpeakPostParametersEncoding2? v2SpeakPostParametersEncoding2,
            global::Deepgram.V2SpeakPostParametersEncoding3? v2SpeakPostParametersEncoding3,
            global::Deepgram.V2SpeakPostParametersEncoding4? v2SpeakPostParametersEncoding4,
            global::Deepgram.V2SpeakPostParametersEncoding5? v2SpeakPostParametersEncoding5,
            global::Deepgram.V2SpeakPostParametersEncoding6? v2SpeakPostParametersEncoding6
            )
        {
            V2SpeakPostParametersEncoding0 = v2SpeakPostParametersEncoding0;
            V2SpeakPostParametersEncoding1 = v2SpeakPostParametersEncoding1;
            V2SpeakPostParametersEncoding2 = v2SpeakPostParametersEncoding2;
            V2SpeakPostParametersEncoding3 = v2SpeakPostParametersEncoding3;
            V2SpeakPostParametersEncoding4 = v2SpeakPostParametersEncoding4;
            V2SpeakPostParametersEncoding5 = v2SpeakPostParametersEncoding5;
            V2SpeakPostParametersEncoding6 = v2SpeakPostParametersEncoding6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V2SpeakPostParametersEncoding6 as object ??
            V2SpeakPostParametersEncoding5 as object ??
            V2SpeakPostParametersEncoding4 as object ??
            V2SpeakPostParametersEncoding3 as object ??
            V2SpeakPostParametersEncoding2 as object ??
            V2SpeakPostParametersEncoding1 as object ??
            V2SpeakPostParametersEncoding0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V2SpeakPostParametersEncoding0?.ToValueString() ??
            V2SpeakPostParametersEncoding1?.ToValueString() ??
            V2SpeakPostParametersEncoding2?.ToValueString() ??
            V2SpeakPostParametersEncoding3?.ToValueString() ??
            V2SpeakPostParametersEncoding4?.ToValueString() ??
            V2SpeakPostParametersEncoding5?.ToValueString() ??
            V2SpeakPostParametersEncoding6?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV2SpeakPostParametersEncoding0 && !IsV2SpeakPostParametersEncoding1 && !IsV2SpeakPostParametersEncoding2 && !IsV2SpeakPostParametersEncoding3 && !IsV2SpeakPostParametersEncoding4 && !IsV2SpeakPostParametersEncoding5 && !IsV2SpeakPostParametersEncoding6 || !IsV2SpeakPostParametersEncoding0 && IsV2SpeakPostParametersEncoding1 && !IsV2SpeakPostParametersEncoding2 && !IsV2SpeakPostParametersEncoding3 && !IsV2SpeakPostParametersEncoding4 && !IsV2SpeakPostParametersEncoding5 && !IsV2SpeakPostParametersEncoding6 || !IsV2SpeakPostParametersEncoding0 && !IsV2SpeakPostParametersEncoding1 && IsV2SpeakPostParametersEncoding2 && !IsV2SpeakPostParametersEncoding3 && !IsV2SpeakPostParametersEncoding4 && !IsV2SpeakPostParametersEncoding5 && !IsV2SpeakPostParametersEncoding6 || !IsV2SpeakPostParametersEncoding0 && !IsV2SpeakPostParametersEncoding1 && !IsV2SpeakPostParametersEncoding2 && IsV2SpeakPostParametersEncoding3 && !IsV2SpeakPostParametersEncoding4 && !IsV2SpeakPostParametersEncoding5 && !IsV2SpeakPostParametersEncoding6 || !IsV2SpeakPostParametersEncoding0 && !IsV2SpeakPostParametersEncoding1 && !IsV2SpeakPostParametersEncoding2 && !IsV2SpeakPostParametersEncoding3 && IsV2SpeakPostParametersEncoding4 && !IsV2SpeakPostParametersEncoding5 && !IsV2SpeakPostParametersEncoding6 || !IsV2SpeakPostParametersEncoding0 && !IsV2SpeakPostParametersEncoding1 && !IsV2SpeakPostParametersEncoding2 && !IsV2SpeakPostParametersEncoding3 && !IsV2SpeakPostParametersEncoding4 && IsV2SpeakPostParametersEncoding5 && !IsV2SpeakPostParametersEncoding6 || !IsV2SpeakPostParametersEncoding0 && !IsV2SpeakPostParametersEncoding1 && !IsV2SpeakPostParametersEncoding2 && !IsV2SpeakPostParametersEncoding3 && !IsV2SpeakPostParametersEncoding4 && !IsV2SpeakPostParametersEncoding5 && IsV2SpeakPostParametersEncoding6;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.V2SpeakPostParametersEncoding0?, TResult>? v2SpeakPostParametersEncoding0 = null,
            global::System.Func<global::Deepgram.V2SpeakPostParametersEncoding1?, TResult>? v2SpeakPostParametersEncoding1 = null,
            global::System.Func<global::Deepgram.V2SpeakPostParametersEncoding2?, TResult>? v2SpeakPostParametersEncoding2 = null,
            global::System.Func<global::Deepgram.V2SpeakPostParametersEncoding3?, TResult>? v2SpeakPostParametersEncoding3 = null,
            global::System.Func<global::Deepgram.V2SpeakPostParametersEncoding4?, TResult>? v2SpeakPostParametersEncoding4 = null,
            global::System.Func<global::Deepgram.V2SpeakPostParametersEncoding5?, TResult>? v2SpeakPostParametersEncoding5 = null,
            global::System.Func<global::Deepgram.V2SpeakPostParametersEncoding6?, TResult>? v2SpeakPostParametersEncoding6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2SpeakPostParametersEncoding0 && v2SpeakPostParametersEncoding0 != null)
            {
                return v2SpeakPostParametersEncoding0(V2SpeakPostParametersEncoding0!);
            }
            else if (IsV2SpeakPostParametersEncoding1 && v2SpeakPostParametersEncoding1 != null)
            {
                return v2SpeakPostParametersEncoding1(V2SpeakPostParametersEncoding1!);
            }
            else if (IsV2SpeakPostParametersEncoding2 && v2SpeakPostParametersEncoding2 != null)
            {
                return v2SpeakPostParametersEncoding2(V2SpeakPostParametersEncoding2!);
            }
            else if (IsV2SpeakPostParametersEncoding3 && v2SpeakPostParametersEncoding3 != null)
            {
                return v2SpeakPostParametersEncoding3(V2SpeakPostParametersEncoding3!);
            }
            else if (IsV2SpeakPostParametersEncoding4 && v2SpeakPostParametersEncoding4 != null)
            {
                return v2SpeakPostParametersEncoding4(V2SpeakPostParametersEncoding4!);
            }
            else if (IsV2SpeakPostParametersEncoding5 && v2SpeakPostParametersEncoding5 != null)
            {
                return v2SpeakPostParametersEncoding5(V2SpeakPostParametersEncoding5!);
            }
            else if (IsV2SpeakPostParametersEncoding6 && v2SpeakPostParametersEncoding6 != null)
            {
                return v2SpeakPostParametersEncoding6(V2SpeakPostParametersEncoding6!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.V2SpeakPostParametersEncoding0?>? v2SpeakPostParametersEncoding0 = null,

            global::System.Action<global::Deepgram.V2SpeakPostParametersEncoding1?>? v2SpeakPostParametersEncoding1 = null,

            global::System.Action<global::Deepgram.V2SpeakPostParametersEncoding2?>? v2SpeakPostParametersEncoding2 = null,

            global::System.Action<global::Deepgram.V2SpeakPostParametersEncoding3?>? v2SpeakPostParametersEncoding3 = null,

            global::System.Action<global::Deepgram.V2SpeakPostParametersEncoding4?>? v2SpeakPostParametersEncoding4 = null,

            global::System.Action<global::Deepgram.V2SpeakPostParametersEncoding5?>? v2SpeakPostParametersEncoding5 = null,

            global::System.Action<global::Deepgram.V2SpeakPostParametersEncoding6?>? v2SpeakPostParametersEncoding6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2SpeakPostParametersEncoding0)
            {
                v2SpeakPostParametersEncoding0?.Invoke(V2SpeakPostParametersEncoding0!);
            }
            else if (IsV2SpeakPostParametersEncoding1)
            {
                v2SpeakPostParametersEncoding1?.Invoke(V2SpeakPostParametersEncoding1!);
            }
            else if (IsV2SpeakPostParametersEncoding2)
            {
                v2SpeakPostParametersEncoding2?.Invoke(V2SpeakPostParametersEncoding2!);
            }
            else if (IsV2SpeakPostParametersEncoding3)
            {
                v2SpeakPostParametersEncoding3?.Invoke(V2SpeakPostParametersEncoding3!);
            }
            else if (IsV2SpeakPostParametersEncoding4)
            {
                v2SpeakPostParametersEncoding4?.Invoke(V2SpeakPostParametersEncoding4!);
            }
            else if (IsV2SpeakPostParametersEncoding5)
            {
                v2SpeakPostParametersEncoding5?.Invoke(V2SpeakPostParametersEncoding5!);
            }
            else if (IsV2SpeakPostParametersEncoding6)
            {
                v2SpeakPostParametersEncoding6?.Invoke(V2SpeakPostParametersEncoding6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.V2SpeakPostParametersEncoding0?>? v2SpeakPostParametersEncoding0 = null,
            global::System.Action<global::Deepgram.V2SpeakPostParametersEncoding1?>? v2SpeakPostParametersEncoding1 = null,
            global::System.Action<global::Deepgram.V2SpeakPostParametersEncoding2?>? v2SpeakPostParametersEncoding2 = null,
            global::System.Action<global::Deepgram.V2SpeakPostParametersEncoding3?>? v2SpeakPostParametersEncoding3 = null,
            global::System.Action<global::Deepgram.V2SpeakPostParametersEncoding4?>? v2SpeakPostParametersEncoding4 = null,
            global::System.Action<global::Deepgram.V2SpeakPostParametersEncoding5?>? v2SpeakPostParametersEncoding5 = null,
            global::System.Action<global::Deepgram.V2SpeakPostParametersEncoding6?>? v2SpeakPostParametersEncoding6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2SpeakPostParametersEncoding0)
            {
                v2SpeakPostParametersEncoding0?.Invoke(V2SpeakPostParametersEncoding0!);
            }
            else if (IsV2SpeakPostParametersEncoding1)
            {
                v2SpeakPostParametersEncoding1?.Invoke(V2SpeakPostParametersEncoding1!);
            }
            else if (IsV2SpeakPostParametersEncoding2)
            {
                v2SpeakPostParametersEncoding2?.Invoke(V2SpeakPostParametersEncoding2!);
            }
            else if (IsV2SpeakPostParametersEncoding3)
            {
                v2SpeakPostParametersEncoding3?.Invoke(V2SpeakPostParametersEncoding3!);
            }
            else if (IsV2SpeakPostParametersEncoding4)
            {
                v2SpeakPostParametersEncoding4?.Invoke(V2SpeakPostParametersEncoding4!);
            }
            else if (IsV2SpeakPostParametersEncoding5)
            {
                v2SpeakPostParametersEncoding5?.Invoke(V2SpeakPostParametersEncoding5!);
            }
            else if (IsV2SpeakPostParametersEncoding6)
            {
                v2SpeakPostParametersEncoding6?.Invoke(V2SpeakPostParametersEncoding6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V2SpeakPostParametersEncoding0,
                typeof(global::Deepgram.V2SpeakPostParametersEncoding0),
                V2SpeakPostParametersEncoding1,
                typeof(global::Deepgram.V2SpeakPostParametersEncoding1),
                V2SpeakPostParametersEncoding2,
                typeof(global::Deepgram.V2SpeakPostParametersEncoding2),
                V2SpeakPostParametersEncoding3,
                typeof(global::Deepgram.V2SpeakPostParametersEncoding3),
                V2SpeakPostParametersEncoding4,
                typeof(global::Deepgram.V2SpeakPostParametersEncoding4),
                V2SpeakPostParametersEncoding5,
                typeof(global::Deepgram.V2SpeakPostParametersEncoding5),
                V2SpeakPostParametersEncoding6,
                typeof(global::Deepgram.V2SpeakPostParametersEncoding6),
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
        public bool Equals(V2SpeakPostParametersEncoding other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V2SpeakPostParametersEncoding0?>.Default.Equals(V2SpeakPostParametersEncoding0, other.V2SpeakPostParametersEncoding0) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V2SpeakPostParametersEncoding1?>.Default.Equals(V2SpeakPostParametersEncoding1, other.V2SpeakPostParametersEncoding1) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V2SpeakPostParametersEncoding2?>.Default.Equals(V2SpeakPostParametersEncoding2, other.V2SpeakPostParametersEncoding2) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V2SpeakPostParametersEncoding3?>.Default.Equals(V2SpeakPostParametersEncoding3, other.V2SpeakPostParametersEncoding3) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V2SpeakPostParametersEncoding4?>.Default.Equals(V2SpeakPostParametersEncoding4, other.V2SpeakPostParametersEncoding4) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V2SpeakPostParametersEncoding5?>.Default.Equals(V2SpeakPostParametersEncoding5, other.V2SpeakPostParametersEncoding5) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V2SpeakPostParametersEncoding6?>.Default.Equals(V2SpeakPostParametersEncoding6, other.V2SpeakPostParametersEncoding6) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V2SpeakPostParametersEncoding obj1, V2SpeakPostParametersEncoding obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V2SpeakPostParametersEncoding>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V2SpeakPostParametersEncoding obj1, V2SpeakPostParametersEncoding obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V2SpeakPostParametersEncoding o && Equals(o);
        }
    }
}
