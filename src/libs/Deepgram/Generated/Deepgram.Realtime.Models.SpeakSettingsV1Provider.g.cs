#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SpeakSettingsV1Provider : global::System.IEquatable<SpeakSettingsV1Provider>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.DeepgramSpeakProvider? DeepgramSpeakProvider { get; init; }
#else
        public global::Deepgram.Realtime.DeepgramSpeakProvider? DeepgramSpeakProvider { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeepgramSpeakProvider))]
#endif
        public bool IsDeepgramSpeakProvider => DeepgramSpeakProvider != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeepgramSpeakProvider(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.DeepgramSpeakProvider? value)
        {
            value = DeepgramSpeakProvider;
            return IsDeepgramSpeakProvider;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ElevenLabsSpeakProvider? ElevenLabsSpeakProvider { get; init; }
#else
        public global::Deepgram.Realtime.ElevenLabsSpeakProvider? ElevenLabsSpeakProvider { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElevenLabsSpeakProvider))]
#endif
        public bool IsElevenLabsSpeakProvider => ElevenLabsSpeakProvider != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickElevenLabsSpeakProvider(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.ElevenLabsSpeakProvider? value)
        {
            value = ElevenLabsSpeakProvider;
            return IsElevenLabsSpeakProvider;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.CartesiaSpeakProvider? CartesiaSpeakProvider { get; init; }
#else
        public global::Deepgram.Realtime.CartesiaSpeakProvider? CartesiaSpeakProvider { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CartesiaSpeakProvider))]
#endif
        public bool IsCartesiaSpeakProvider => CartesiaSpeakProvider != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCartesiaSpeakProvider(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.CartesiaSpeakProvider? value)
        {
            value = CartesiaSpeakProvider;
            return IsCartesiaSpeakProvider;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.OpenAiSpeakProvider? OpenAiSpeakProvider { get; init; }
#else
        public global::Deepgram.Realtime.OpenAiSpeakProvider? OpenAiSpeakProvider { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAiSpeakProvider))]
#endif
        public bool IsOpenAiSpeakProvider => OpenAiSpeakProvider != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenAiSpeakProvider(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.OpenAiSpeakProvider? value)
        {
            value = OpenAiSpeakProvider;
            return IsOpenAiSpeakProvider;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AwsPollySpeakProvider? AwsPollySpeakProvider { get; init; }
#else
        public global::Deepgram.Realtime.AwsPollySpeakProvider? AwsPollySpeakProvider { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AwsPollySpeakProvider))]
#endif
        public bool IsAwsPollySpeakProvider => AwsPollySpeakProvider != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAwsPollySpeakProvider(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AwsPollySpeakProvider? value)
        {
            value = AwsPollySpeakProvider;
            return IsAwsPollySpeakProvider;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeakSettingsV1Provider(global::Deepgram.Realtime.DeepgramSpeakProvider value) => new SpeakSettingsV1Provider((global::Deepgram.Realtime.DeepgramSpeakProvider?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.DeepgramSpeakProvider?(SpeakSettingsV1Provider @this) => @this.DeepgramSpeakProvider;

        /// <summary>
        /// 
        /// </summary>
        public SpeakSettingsV1Provider(global::Deepgram.Realtime.DeepgramSpeakProvider? value)
        {
            DeepgramSpeakProvider = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeakSettingsV1Provider(global::Deepgram.Realtime.ElevenLabsSpeakProvider value) => new SpeakSettingsV1Provider((global::Deepgram.Realtime.ElevenLabsSpeakProvider?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ElevenLabsSpeakProvider?(SpeakSettingsV1Provider @this) => @this.ElevenLabsSpeakProvider;

        /// <summary>
        /// 
        /// </summary>
        public SpeakSettingsV1Provider(global::Deepgram.Realtime.ElevenLabsSpeakProvider? value)
        {
            ElevenLabsSpeakProvider = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeakSettingsV1Provider(global::Deepgram.Realtime.CartesiaSpeakProvider value) => new SpeakSettingsV1Provider((global::Deepgram.Realtime.CartesiaSpeakProvider?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.CartesiaSpeakProvider?(SpeakSettingsV1Provider @this) => @this.CartesiaSpeakProvider;

        /// <summary>
        /// 
        /// </summary>
        public SpeakSettingsV1Provider(global::Deepgram.Realtime.CartesiaSpeakProvider? value)
        {
            CartesiaSpeakProvider = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeakSettingsV1Provider(global::Deepgram.Realtime.OpenAiSpeakProvider value) => new SpeakSettingsV1Provider((global::Deepgram.Realtime.OpenAiSpeakProvider?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.OpenAiSpeakProvider?(SpeakSettingsV1Provider @this) => @this.OpenAiSpeakProvider;

        /// <summary>
        /// 
        /// </summary>
        public SpeakSettingsV1Provider(global::Deepgram.Realtime.OpenAiSpeakProvider? value)
        {
            OpenAiSpeakProvider = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeakSettingsV1Provider(global::Deepgram.Realtime.AwsPollySpeakProvider value) => new SpeakSettingsV1Provider((global::Deepgram.Realtime.AwsPollySpeakProvider?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AwsPollySpeakProvider?(SpeakSettingsV1Provider @this) => @this.AwsPollySpeakProvider;

        /// <summary>
        /// 
        /// </summary>
        public SpeakSettingsV1Provider(global::Deepgram.Realtime.AwsPollySpeakProvider? value)
        {
            AwsPollySpeakProvider = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SpeakSettingsV1Provider(
            global::Deepgram.Realtime.DeepgramSpeakProvider? deepgramSpeakProvider,
            global::Deepgram.Realtime.ElevenLabsSpeakProvider? elevenLabsSpeakProvider,
            global::Deepgram.Realtime.CartesiaSpeakProvider? cartesiaSpeakProvider,
            global::Deepgram.Realtime.OpenAiSpeakProvider? openAiSpeakProvider,
            global::Deepgram.Realtime.AwsPollySpeakProvider? awsPollySpeakProvider
            )
        {
            DeepgramSpeakProvider = deepgramSpeakProvider;
            ElevenLabsSpeakProvider = elevenLabsSpeakProvider;
            CartesiaSpeakProvider = cartesiaSpeakProvider;
            OpenAiSpeakProvider = openAiSpeakProvider;
            AwsPollySpeakProvider = awsPollySpeakProvider;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AwsPollySpeakProvider as object ??
            OpenAiSpeakProvider as object ??
            CartesiaSpeakProvider as object ??
            ElevenLabsSpeakProvider as object ??
            DeepgramSpeakProvider as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DeepgramSpeakProvider?.ToString() ??
            ElevenLabsSpeakProvider?.ToString() ??
            CartesiaSpeakProvider?.ToString() ??
            OpenAiSpeakProvider?.ToString() ??
            AwsPollySpeakProvider?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDeepgramSpeakProvider && !IsElevenLabsSpeakProvider && !IsCartesiaSpeakProvider && !IsOpenAiSpeakProvider && !IsAwsPollySpeakProvider || !IsDeepgramSpeakProvider && IsElevenLabsSpeakProvider && !IsCartesiaSpeakProvider && !IsOpenAiSpeakProvider && !IsAwsPollySpeakProvider || !IsDeepgramSpeakProvider && !IsElevenLabsSpeakProvider && IsCartesiaSpeakProvider && !IsOpenAiSpeakProvider && !IsAwsPollySpeakProvider || !IsDeepgramSpeakProvider && !IsElevenLabsSpeakProvider && !IsCartesiaSpeakProvider && IsOpenAiSpeakProvider && !IsAwsPollySpeakProvider || !IsDeepgramSpeakProvider && !IsElevenLabsSpeakProvider && !IsCartesiaSpeakProvider && !IsOpenAiSpeakProvider && IsAwsPollySpeakProvider;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.DeepgramSpeakProvider, TResult>? deepgramSpeakProvider = null,
            global::System.Func<global::Deepgram.Realtime.ElevenLabsSpeakProvider, TResult>? elevenLabsSpeakProvider = null,
            global::System.Func<global::Deepgram.Realtime.CartesiaSpeakProvider, TResult>? cartesiaSpeakProvider = null,
            global::System.Func<global::Deepgram.Realtime.OpenAiSpeakProvider, TResult>? openAiSpeakProvider = null,
            global::System.Func<global::Deepgram.Realtime.AwsPollySpeakProvider, TResult>? awsPollySpeakProvider = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeepgramSpeakProvider && deepgramSpeakProvider != null)
            {
                return deepgramSpeakProvider(DeepgramSpeakProvider!);
            }
            else if (IsElevenLabsSpeakProvider && elevenLabsSpeakProvider != null)
            {
                return elevenLabsSpeakProvider(ElevenLabsSpeakProvider!);
            }
            else if (IsCartesiaSpeakProvider && cartesiaSpeakProvider != null)
            {
                return cartesiaSpeakProvider(CartesiaSpeakProvider!);
            }
            else if (IsOpenAiSpeakProvider && openAiSpeakProvider != null)
            {
                return openAiSpeakProvider(OpenAiSpeakProvider!);
            }
            else if (IsAwsPollySpeakProvider && awsPollySpeakProvider != null)
            {
                return awsPollySpeakProvider(AwsPollySpeakProvider!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.DeepgramSpeakProvider>? deepgramSpeakProvider = null,

            global::System.Action<global::Deepgram.Realtime.ElevenLabsSpeakProvider>? elevenLabsSpeakProvider = null,

            global::System.Action<global::Deepgram.Realtime.CartesiaSpeakProvider>? cartesiaSpeakProvider = null,

            global::System.Action<global::Deepgram.Realtime.OpenAiSpeakProvider>? openAiSpeakProvider = null,

            global::System.Action<global::Deepgram.Realtime.AwsPollySpeakProvider>? awsPollySpeakProvider = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeepgramSpeakProvider)
            {
                deepgramSpeakProvider?.Invoke(DeepgramSpeakProvider!);
            }
            else if (IsElevenLabsSpeakProvider)
            {
                elevenLabsSpeakProvider?.Invoke(ElevenLabsSpeakProvider!);
            }
            else if (IsCartesiaSpeakProvider)
            {
                cartesiaSpeakProvider?.Invoke(CartesiaSpeakProvider!);
            }
            else if (IsOpenAiSpeakProvider)
            {
                openAiSpeakProvider?.Invoke(OpenAiSpeakProvider!);
            }
            else if (IsAwsPollySpeakProvider)
            {
                awsPollySpeakProvider?.Invoke(AwsPollySpeakProvider!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.Realtime.DeepgramSpeakProvider>? deepgramSpeakProvider = null,
            global::System.Action<global::Deepgram.Realtime.ElevenLabsSpeakProvider>? elevenLabsSpeakProvider = null,
            global::System.Action<global::Deepgram.Realtime.CartesiaSpeakProvider>? cartesiaSpeakProvider = null,
            global::System.Action<global::Deepgram.Realtime.OpenAiSpeakProvider>? openAiSpeakProvider = null,
            global::System.Action<global::Deepgram.Realtime.AwsPollySpeakProvider>? awsPollySpeakProvider = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeepgramSpeakProvider)
            {
                deepgramSpeakProvider?.Invoke(DeepgramSpeakProvider!);
            }
            else if (IsElevenLabsSpeakProvider)
            {
                elevenLabsSpeakProvider?.Invoke(ElevenLabsSpeakProvider!);
            }
            else if (IsCartesiaSpeakProvider)
            {
                cartesiaSpeakProvider?.Invoke(CartesiaSpeakProvider!);
            }
            else if (IsOpenAiSpeakProvider)
            {
                openAiSpeakProvider?.Invoke(OpenAiSpeakProvider!);
            }
            else if (IsAwsPollySpeakProvider)
            {
                awsPollySpeakProvider?.Invoke(AwsPollySpeakProvider!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DeepgramSpeakProvider,
                typeof(global::Deepgram.Realtime.DeepgramSpeakProvider),
                ElevenLabsSpeakProvider,
                typeof(global::Deepgram.Realtime.ElevenLabsSpeakProvider),
                CartesiaSpeakProvider,
                typeof(global::Deepgram.Realtime.CartesiaSpeakProvider),
                OpenAiSpeakProvider,
                typeof(global::Deepgram.Realtime.OpenAiSpeakProvider),
                AwsPollySpeakProvider,
                typeof(global::Deepgram.Realtime.AwsPollySpeakProvider),
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
        public bool Equals(SpeakSettingsV1Provider other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.DeepgramSpeakProvider?>.Default.Equals(DeepgramSpeakProvider, other.DeepgramSpeakProvider) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ElevenLabsSpeakProvider?>.Default.Equals(ElevenLabsSpeakProvider, other.ElevenLabsSpeakProvider) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.CartesiaSpeakProvider?>.Default.Equals(CartesiaSpeakProvider, other.CartesiaSpeakProvider) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.OpenAiSpeakProvider?>.Default.Equals(OpenAiSpeakProvider, other.OpenAiSpeakProvider) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AwsPollySpeakProvider?>.Default.Equals(AwsPollySpeakProvider, other.AwsPollySpeakProvider) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SpeakSettingsV1Provider obj1, SpeakSettingsV1Provider obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SpeakSettingsV1Provider>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SpeakSettingsV1Provider obj1, SpeakSettingsV1Provider obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SpeakSettingsV1Provider o && Equals(o);
        }
    }
}
