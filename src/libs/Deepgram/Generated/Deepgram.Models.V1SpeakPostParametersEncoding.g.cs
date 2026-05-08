#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1SpeakPostParametersEncoding : global::System.IEquatable<V1SpeakPostParametersEncoding>
    {
        /// <summary>
        /// Encoding - linear16. Uncompressed, high-quality audio format often used for telephony or audio processing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1SpeakPostParametersEncoding0? V1SpeakPostParametersEncoding0 { get; init; }
#else
        public global::Deepgram.V1SpeakPostParametersEncoding0? V1SpeakPostParametersEncoding0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersEncoding0))]
#endif
        public bool IsV1SpeakPostParametersEncoding0 => V1SpeakPostParametersEncoding0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersEncoding0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V1SpeakPostParametersEncoding0? value)
        {
            value = V1SpeakPostParametersEncoding0;
            return IsV1SpeakPostParametersEncoding0;
        }

        /// <summary>
        /// Encoding - flac. Lossless audio format for high-quality compression.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1SpeakPostParametersEncoding1? V1SpeakPostParametersEncoding1 { get; init; }
#else
        public global::Deepgram.V1SpeakPostParametersEncoding1? V1SpeakPostParametersEncoding1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersEncoding1))]
#endif
        public bool IsV1SpeakPostParametersEncoding1 => V1SpeakPostParametersEncoding1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersEncoding1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V1SpeakPostParametersEncoding1? value)
        {
            value = V1SpeakPostParametersEncoding1;
            return IsV1SpeakPostParametersEncoding1;
        }

        /// <summary>
        /// Encoding - mulaw. Compressed audio format commonly used in telephony.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1SpeakPostParametersEncoding2? V1SpeakPostParametersEncoding2 { get; init; }
#else
        public global::Deepgram.V1SpeakPostParametersEncoding2? V1SpeakPostParametersEncoding2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersEncoding2))]
#endif
        public bool IsV1SpeakPostParametersEncoding2 => V1SpeakPostParametersEncoding2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersEncoding2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V1SpeakPostParametersEncoding2? value)
        {
            value = V1SpeakPostParametersEncoding2;
            return IsV1SpeakPostParametersEncoding2;
        }

        /// <summary>
        /// Encoding - alaw. Similar to mulaw but used in international telephony.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1SpeakPostParametersEncoding3? V1SpeakPostParametersEncoding3 { get; init; }
#else
        public global::Deepgram.V1SpeakPostParametersEncoding3? V1SpeakPostParametersEncoding3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersEncoding3))]
#endif
        public bool IsV1SpeakPostParametersEncoding3 => V1SpeakPostParametersEncoding3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersEncoding3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V1SpeakPostParametersEncoding3? value)
        {
            value = V1SpeakPostParametersEncoding3;
            return IsV1SpeakPostParametersEncoding3;
        }

        /// <summary>
        /// Encoding - mp3. Popular compressed audio format for music and streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1SpeakPostParametersEncoding4? V1SpeakPostParametersEncoding4 { get; init; }
#else
        public global::Deepgram.V1SpeakPostParametersEncoding4? V1SpeakPostParametersEncoding4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersEncoding4))]
#endif
        public bool IsV1SpeakPostParametersEncoding4 => V1SpeakPostParametersEncoding4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersEncoding4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V1SpeakPostParametersEncoding4? value)
        {
            value = V1SpeakPostParametersEncoding4;
            return IsV1SpeakPostParametersEncoding4;
        }

        /// <summary>
        /// Encoding - opus. High-compression audio format optimized for real-time communications.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1SpeakPostParametersEncoding5? V1SpeakPostParametersEncoding5 { get; init; }
#else
        public global::Deepgram.V1SpeakPostParametersEncoding5? V1SpeakPostParametersEncoding5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersEncoding5))]
#endif
        public bool IsV1SpeakPostParametersEncoding5 => V1SpeakPostParametersEncoding5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersEncoding5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V1SpeakPostParametersEncoding5? value)
        {
            value = V1SpeakPostParametersEncoding5;
            return IsV1SpeakPostParametersEncoding5;
        }

        /// <summary>
        /// Encoding - aac. Advanced audio format offering better quality at smaller file sizes than mp3.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1SpeakPostParametersEncoding6? V1SpeakPostParametersEncoding6 { get; init; }
#else
        public global::Deepgram.V1SpeakPostParametersEncoding6? V1SpeakPostParametersEncoding6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersEncoding6))]
#endif
        public bool IsV1SpeakPostParametersEncoding6 => V1SpeakPostParametersEncoding6 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1SpeakPostParametersEncoding6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V1SpeakPostParametersEncoding6? value)
        {
            value = V1SpeakPostParametersEncoding6;
            return IsV1SpeakPostParametersEncoding6;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersEncoding(global::Deepgram.V1SpeakPostParametersEncoding0 value) => new V1SpeakPostParametersEncoding((global::Deepgram.V1SpeakPostParametersEncoding0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1SpeakPostParametersEncoding0?(V1SpeakPostParametersEncoding @this) => @this.V1SpeakPostParametersEncoding0;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersEncoding(global::Deepgram.V1SpeakPostParametersEncoding0? value)
        {
            V1SpeakPostParametersEncoding0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersEncoding(global::Deepgram.V1SpeakPostParametersEncoding1 value) => new V1SpeakPostParametersEncoding((global::Deepgram.V1SpeakPostParametersEncoding1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1SpeakPostParametersEncoding1?(V1SpeakPostParametersEncoding @this) => @this.V1SpeakPostParametersEncoding1;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersEncoding(global::Deepgram.V1SpeakPostParametersEncoding1? value)
        {
            V1SpeakPostParametersEncoding1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersEncoding(global::Deepgram.V1SpeakPostParametersEncoding2 value) => new V1SpeakPostParametersEncoding((global::Deepgram.V1SpeakPostParametersEncoding2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1SpeakPostParametersEncoding2?(V1SpeakPostParametersEncoding @this) => @this.V1SpeakPostParametersEncoding2;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersEncoding(global::Deepgram.V1SpeakPostParametersEncoding2? value)
        {
            V1SpeakPostParametersEncoding2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersEncoding(global::Deepgram.V1SpeakPostParametersEncoding3 value) => new V1SpeakPostParametersEncoding((global::Deepgram.V1SpeakPostParametersEncoding3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1SpeakPostParametersEncoding3?(V1SpeakPostParametersEncoding @this) => @this.V1SpeakPostParametersEncoding3;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersEncoding(global::Deepgram.V1SpeakPostParametersEncoding3? value)
        {
            V1SpeakPostParametersEncoding3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersEncoding(global::Deepgram.V1SpeakPostParametersEncoding4 value) => new V1SpeakPostParametersEncoding((global::Deepgram.V1SpeakPostParametersEncoding4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1SpeakPostParametersEncoding4?(V1SpeakPostParametersEncoding @this) => @this.V1SpeakPostParametersEncoding4;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersEncoding(global::Deepgram.V1SpeakPostParametersEncoding4? value)
        {
            V1SpeakPostParametersEncoding4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersEncoding(global::Deepgram.V1SpeakPostParametersEncoding5 value) => new V1SpeakPostParametersEncoding((global::Deepgram.V1SpeakPostParametersEncoding5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1SpeakPostParametersEncoding5?(V1SpeakPostParametersEncoding @this) => @this.V1SpeakPostParametersEncoding5;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersEncoding(global::Deepgram.V1SpeakPostParametersEncoding5? value)
        {
            V1SpeakPostParametersEncoding5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersEncoding(global::Deepgram.V1SpeakPostParametersEncoding6 value) => new V1SpeakPostParametersEncoding((global::Deepgram.V1SpeakPostParametersEncoding6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1SpeakPostParametersEncoding6?(V1SpeakPostParametersEncoding @this) => @this.V1SpeakPostParametersEncoding6;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersEncoding(global::Deepgram.V1SpeakPostParametersEncoding6? value)
        {
            V1SpeakPostParametersEncoding6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersEncoding(
            global::Deepgram.V1SpeakPostParametersEncoding0? v1SpeakPostParametersEncoding0,
            global::Deepgram.V1SpeakPostParametersEncoding1? v1SpeakPostParametersEncoding1,
            global::Deepgram.V1SpeakPostParametersEncoding2? v1SpeakPostParametersEncoding2,
            global::Deepgram.V1SpeakPostParametersEncoding3? v1SpeakPostParametersEncoding3,
            global::Deepgram.V1SpeakPostParametersEncoding4? v1SpeakPostParametersEncoding4,
            global::Deepgram.V1SpeakPostParametersEncoding5? v1SpeakPostParametersEncoding5,
            global::Deepgram.V1SpeakPostParametersEncoding6? v1SpeakPostParametersEncoding6
            )
        {
            V1SpeakPostParametersEncoding0 = v1SpeakPostParametersEncoding0;
            V1SpeakPostParametersEncoding1 = v1SpeakPostParametersEncoding1;
            V1SpeakPostParametersEncoding2 = v1SpeakPostParametersEncoding2;
            V1SpeakPostParametersEncoding3 = v1SpeakPostParametersEncoding3;
            V1SpeakPostParametersEncoding4 = v1SpeakPostParametersEncoding4;
            V1SpeakPostParametersEncoding5 = v1SpeakPostParametersEncoding5;
            V1SpeakPostParametersEncoding6 = v1SpeakPostParametersEncoding6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1SpeakPostParametersEncoding6 as object ??
            V1SpeakPostParametersEncoding5 as object ??
            V1SpeakPostParametersEncoding4 as object ??
            V1SpeakPostParametersEncoding3 as object ??
            V1SpeakPostParametersEncoding2 as object ??
            V1SpeakPostParametersEncoding1 as object ??
            V1SpeakPostParametersEncoding0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1SpeakPostParametersEncoding0?.ToValueString() ??
            V1SpeakPostParametersEncoding1?.ToValueString() ??
            V1SpeakPostParametersEncoding2?.ToValueString() ??
            V1SpeakPostParametersEncoding3?.ToValueString() ??
            V1SpeakPostParametersEncoding4?.ToValueString() ??
            V1SpeakPostParametersEncoding5?.ToValueString() ??
            V1SpeakPostParametersEncoding6?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1SpeakPostParametersEncoding0 && !IsV1SpeakPostParametersEncoding1 && !IsV1SpeakPostParametersEncoding2 && !IsV1SpeakPostParametersEncoding3 && !IsV1SpeakPostParametersEncoding4 && !IsV1SpeakPostParametersEncoding5 && !IsV1SpeakPostParametersEncoding6 || !IsV1SpeakPostParametersEncoding0 && IsV1SpeakPostParametersEncoding1 && !IsV1SpeakPostParametersEncoding2 && !IsV1SpeakPostParametersEncoding3 && !IsV1SpeakPostParametersEncoding4 && !IsV1SpeakPostParametersEncoding5 && !IsV1SpeakPostParametersEncoding6 || !IsV1SpeakPostParametersEncoding0 && !IsV1SpeakPostParametersEncoding1 && IsV1SpeakPostParametersEncoding2 && !IsV1SpeakPostParametersEncoding3 && !IsV1SpeakPostParametersEncoding4 && !IsV1SpeakPostParametersEncoding5 && !IsV1SpeakPostParametersEncoding6 || !IsV1SpeakPostParametersEncoding0 && !IsV1SpeakPostParametersEncoding1 && !IsV1SpeakPostParametersEncoding2 && IsV1SpeakPostParametersEncoding3 && !IsV1SpeakPostParametersEncoding4 && !IsV1SpeakPostParametersEncoding5 && !IsV1SpeakPostParametersEncoding6 || !IsV1SpeakPostParametersEncoding0 && !IsV1SpeakPostParametersEncoding1 && !IsV1SpeakPostParametersEncoding2 && !IsV1SpeakPostParametersEncoding3 && IsV1SpeakPostParametersEncoding4 && !IsV1SpeakPostParametersEncoding5 && !IsV1SpeakPostParametersEncoding6 || !IsV1SpeakPostParametersEncoding0 && !IsV1SpeakPostParametersEncoding1 && !IsV1SpeakPostParametersEncoding2 && !IsV1SpeakPostParametersEncoding3 && !IsV1SpeakPostParametersEncoding4 && IsV1SpeakPostParametersEncoding5 && !IsV1SpeakPostParametersEncoding6 || !IsV1SpeakPostParametersEncoding0 && !IsV1SpeakPostParametersEncoding1 && !IsV1SpeakPostParametersEncoding2 && !IsV1SpeakPostParametersEncoding3 && !IsV1SpeakPostParametersEncoding4 && !IsV1SpeakPostParametersEncoding5 && IsV1SpeakPostParametersEncoding6;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.V1SpeakPostParametersEncoding0?, TResult>? v1SpeakPostParametersEncoding0 = null,
            global::System.Func<global::Deepgram.V1SpeakPostParametersEncoding1?, TResult>? v1SpeakPostParametersEncoding1 = null,
            global::System.Func<global::Deepgram.V1SpeakPostParametersEncoding2?, TResult>? v1SpeakPostParametersEncoding2 = null,
            global::System.Func<global::Deepgram.V1SpeakPostParametersEncoding3?, TResult>? v1SpeakPostParametersEncoding3 = null,
            global::System.Func<global::Deepgram.V1SpeakPostParametersEncoding4?, TResult>? v1SpeakPostParametersEncoding4 = null,
            global::System.Func<global::Deepgram.V1SpeakPostParametersEncoding5?, TResult>? v1SpeakPostParametersEncoding5 = null,
            global::System.Func<global::Deepgram.V1SpeakPostParametersEncoding6?, TResult>? v1SpeakPostParametersEncoding6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1SpeakPostParametersEncoding0 && v1SpeakPostParametersEncoding0 != null)
            {
                return v1SpeakPostParametersEncoding0(V1SpeakPostParametersEncoding0!);
            }
            else if (IsV1SpeakPostParametersEncoding1 && v1SpeakPostParametersEncoding1 != null)
            {
                return v1SpeakPostParametersEncoding1(V1SpeakPostParametersEncoding1!);
            }
            else if (IsV1SpeakPostParametersEncoding2 && v1SpeakPostParametersEncoding2 != null)
            {
                return v1SpeakPostParametersEncoding2(V1SpeakPostParametersEncoding2!);
            }
            else if (IsV1SpeakPostParametersEncoding3 && v1SpeakPostParametersEncoding3 != null)
            {
                return v1SpeakPostParametersEncoding3(V1SpeakPostParametersEncoding3!);
            }
            else if (IsV1SpeakPostParametersEncoding4 && v1SpeakPostParametersEncoding4 != null)
            {
                return v1SpeakPostParametersEncoding4(V1SpeakPostParametersEncoding4!);
            }
            else if (IsV1SpeakPostParametersEncoding5 && v1SpeakPostParametersEncoding5 != null)
            {
                return v1SpeakPostParametersEncoding5(V1SpeakPostParametersEncoding5!);
            }
            else if (IsV1SpeakPostParametersEncoding6 && v1SpeakPostParametersEncoding6 != null)
            {
                return v1SpeakPostParametersEncoding6(V1SpeakPostParametersEncoding6!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.V1SpeakPostParametersEncoding0?>? v1SpeakPostParametersEncoding0 = null,

            global::System.Action<global::Deepgram.V1SpeakPostParametersEncoding1?>? v1SpeakPostParametersEncoding1 = null,

            global::System.Action<global::Deepgram.V1SpeakPostParametersEncoding2?>? v1SpeakPostParametersEncoding2 = null,

            global::System.Action<global::Deepgram.V1SpeakPostParametersEncoding3?>? v1SpeakPostParametersEncoding3 = null,

            global::System.Action<global::Deepgram.V1SpeakPostParametersEncoding4?>? v1SpeakPostParametersEncoding4 = null,

            global::System.Action<global::Deepgram.V1SpeakPostParametersEncoding5?>? v1SpeakPostParametersEncoding5 = null,

            global::System.Action<global::Deepgram.V1SpeakPostParametersEncoding6?>? v1SpeakPostParametersEncoding6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1SpeakPostParametersEncoding0)
            {
                v1SpeakPostParametersEncoding0?.Invoke(V1SpeakPostParametersEncoding0!);
            }
            else if (IsV1SpeakPostParametersEncoding1)
            {
                v1SpeakPostParametersEncoding1?.Invoke(V1SpeakPostParametersEncoding1!);
            }
            else if (IsV1SpeakPostParametersEncoding2)
            {
                v1SpeakPostParametersEncoding2?.Invoke(V1SpeakPostParametersEncoding2!);
            }
            else if (IsV1SpeakPostParametersEncoding3)
            {
                v1SpeakPostParametersEncoding3?.Invoke(V1SpeakPostParametersEncoding3!);
            }
            else if (IsV1SpeakPostParametersEncoding4)
            {
                v1SpeakPostParametersEncoding4?.Invoke(V1SpeakPostParametersEncoding4!);
            }
            else if (IsV1SpeakPostParametersEncoding5)
            {
                v1SpeakPostParametersEncoding5?.Invoke(V1SpeakPostParametersEncoding5!);
            }
            else if (IsV1SpeakPostParametersEncoding6)
            {
                v1SpeakPostParametersEncoding6?.Invoke(V1SpeakPostParametersEncoding6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.V1SpeakPostParametersEncoding0?>? v1SpeakPostParametersEncoding0 = null,
            global::System.Action<global::Deepgram.V1SpeakPostParametersEncoding1?>? v1SpeakPostParametersEncoding1 = null,
            global::System.Action<global::Deepgram.V1SpeakPostParametersEncoding2?>? v1SpeakPostParametersEncoding2 = null,
            global::System.Action<global::Deepgram.V1SpeakPostParametersEncoding3?>? v1SpeakPostParametersEncoding3 = null,
            global::System.Action<global::Deepgram.V1SpeakPostParametersEncoding4?>? v1SpeakPostParametersEncoding4 = null,
            global::System.Action<global::Deepgram.V1SpeakPostParametersEncoding5?>? v1SpeakPostParametersEncoding5 = null,
            global::System.Action<global::Deepgram.V1SpeakPostParametersEncoding6?>? v1SpeakPostParametersEncoding6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1SpeakPostParametersEncoding0)
            {
                v1SpeakPostParametersEncoding0?.Invoke(V1SpeakPostParametersEncoding0!);
            }
            else if (IsV1SpeakPostParametersEncoding1)
            {
                v1SpeakPostParametersEncoding1?.Invoke(V1SpeakPostParametersEncoding1!);
            }
            else if (IsV1SpeakPostParametersEncoding2)
            {
                v1SpeakPostParametersEncoding2?.Invoke(V1SpeakPostParametersEncoding2!);
            }
            else if (IsV1SpeakPostParametersEncoding3)
            {
                v1SpeakPostParametersEncoding3?.Invoke(V1SpeakPostParametersEncoding3!);
            }
            else if (IsV1SpeakPostParametersEncoding4)
            {
                v1SpeakPostParametersEncoding4?.Invoke(V1SpeakPostParametersEncoding4!);
            }
            else if (IsV1SpeakPostParametersEncoding5)
            {
                v1SpeakPostParametersEncoding5?.Invoke(V1SpeakPostParametersEncoding5!);
            }
            else if (IsV1SpeakPostParametersEncoding6)
            {
                v1SpeakPostParametersEncoding6?.Invoke(V1SpeakPostParametersEncoding6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1SpeakPostParametersEncoding0,
                typeof(global::Deepgram.V1SpeakPostParametersEncoding0),
                V1SpeakPostParametersEncoding1,
                typeof(global::Deepgram.V1SpeakPostParametersEncoding1),
                V1SpeakPostParametersEncoding2,
                typeof(global::Deepgram.V1SpeakPostParametersEncoding2),
                V1SpeakPostParametersEncoding3,
                typeof(global::Deepgram.V1SpeakPostParametersEncoding3),
                V1SpeakPostParametersEncoding4,
                typeof(global::Deepgram.V1SpeakPostParametersEncoding4),
                V1SpeakPostParametersEncoding5,
                typeof(global::Deepgram.V1SpeakPostParametersEncoding5),
                V1SpeakPostParametersEncoding6,
                typeof(global::Deepgram.V1SpeakPostParametersEncoding6),
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
        public bool Equals(V1SpeakPostParametersEncoding other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1SpeakPostParametersEncoding0?>.Default.Equals(V1SpeakPostParametersEncoding0, other.V1SpeakPostParametersEncoding0) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1SpeakPostParametersEncoding1?>.Default.Equals(V1SpeakPostParametersEncoding1, other.V1SpeakPostParametersEncoding1) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1SpeakPostParametersEncoding2?>.Default.Equals(V1SpeakPostParametersEncoding2, other.V1SpeakPostParametersEncoding2) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1SpeakPostParametersEncoding3?>.Default.Equals(V1SpeakPostParametersEncoding3, other.V1SpeakPostParametersEncoding3) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1SpeakPostParametersEncoding4?>.Default.Equals(V1SpeakPostParametersEncoding4, other.V1SpeakPostParametersEncoding4) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1SpeakPostParametersEncoding5?>.Default.Equals(V1SpeakPostParametersEncoding5, other.V1SpeakPostParametersEncoding5) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1SpeakPostParametersEncoding6?>.Default.Equals(V1SpeakPostParametersEncoding6, other.V1SpeakPostParametersEncoding6) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1SpeakPostParametersEncoding obj1, V1SpeakPostParametersEncoding obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1SpeakPostParametersEncoding>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1SpeakPostParametersEncoding obj1, V1SpeakPostParametersEncoding obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1SpeakPostParametersEncoding o && Equals(o);
        }
    }
}
