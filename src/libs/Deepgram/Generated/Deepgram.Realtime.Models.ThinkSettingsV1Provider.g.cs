#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ThinkSettingsV1Provider : global::System.IEquatable<ThinkSettingsV1Provider>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.OpenAiThinkProvider? OpenAiThinkProvider { get; init; }
#else
        public global::Deepgram.Realtime.OpenAiThinkProvider? OpenAiThinkProvider { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAiThinkProvider))]
#endif
        public bool IsOpenAiThinkProvider => OpenAiThinkProvider != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AwsBedrockThinkProvider? AwsBedrockThinkProvider { get; init; }
#else
        public global::Deepgram.Realtime.AwsBedrockThinkProvider? AwsBedrockThinkProvider { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AwsBedrockThinkProvider))]
#endif
        public bool IsAwsBedrockThinkProvider => AwsBedrockThinkProvider != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AnthropicThinkProvider? AnthropicThinkProvider { get; init; }
#else
        public global::Deepgram.Realtime.AnthropicThinkProvider? AnthropicThinkProvider { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicThinkProvider))]
#endif
        public bool IsAnthropicThinkProvider => AnthropicThinkProvider != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.GoogleThinkProvider? GoogleThinkProvider { get; init; }
#else
        public global::Deepgram.Realtime.GoogleThinkProvider? GoogleThinkProvider { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleThinkProvider))]
#endif
        public bool IsGoogleThinkProvider => GoogleThinkProvider != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.GroqThinkProvider? GroqThinkProvider { get; init; }
#else
        public global::Deepgram.Realtime.GroqThinkProvider? GroqThinkProvider { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GroqThinkProvider))]
#endif
        public bool IsGroqThinkProvider => GroqThinkProvider != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThinkSettingsV1Provider(global::Deepgram.Realtime.OpenAiThinkProvider value) => new ThinkSettingsV1Provider((global::Deepgram.Realtime.OpenAiThinkProvider?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.OpenAiThinkProvider?(ThinkSettingsV1Provider @this) => @this.OpenAiThinkProvider;

        /// <summary>
        /// 
        /// </summary>
        public ThinkSettingsV1Provider(global::Deepgram.Realtime.OpenAiThinkProvider? value)
        {
            OpenAiThinkProvider = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThinkSettingsV1Provider(global::Deepgram.Realtime.AwsBedrockThinkProvider value) => new ThinkSettingsV1Provider((global::Deepgram.Realtime.AwsBedrockThinkProvider?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AwsBedrockThinkProvider?(ThinkSettingsV1Provider @this) => @this.AwsBedrockThinkProvider;

        /// <summary>
        /// 
        /// </summary>
        public ThinkSettingsV1Provider(global::Deepgram.Realtime.AwsBedrockThinkProvider? value)
        {
            AwsBedrockThinkProvider = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThinkSettingsV1Provider(global::Deepgram.Realtime.AnthropicThinkProvider value) => new ThinkSettingsV1Provider((global::Deepgram.Realtime.AnthropicThinkProvider?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AnthropicThinkProvider?(ThinkSettingsV1Provider @this) => @this.AnthropicThinkProvider;

        /// <summary>
        /// 
        /// </summary>
        public ThinkSettingsV1Provider(global::Deepgram.Realtime.AnthropicThinkProvider? value)
        {
            AnthropicThinkProvider = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThinkSettingsV1Provider(global::Deepgram.Realtime.GoogleThinkProvider value) => new ThinkSettingsV1Provider((global::Deepgram.Realtime.GoogleThinkProvider?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.GoogleThinkProvider?(ThinkSettingsV1Provider @this) => @this.GoogleThinkProvider;

        /// <summary>
        /// 
        /// </summary>
        public ThinkSettingsV1Provider(global::Deepgram.Realtime.GoogleThinkProvider? value)
        {
            GoogleThinkProvider = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThinkSettingsV1Provider(global::Deepgram.Realtime.GroqThinkProvider value) => new ThinkSettingsV1Provider((global::Deepgram.Realtime.GroqThinkProvider?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.GroqThinkProvider?(ThinkSettingsV1Provider @this) => @this.GroqThinkProvider;

        /// <summary>
        /// 
        /// </summary>
        public ThinkSettingsV1Provider(global::Deepgram.Realtime.GroqThinkProvider? value)
        {
            GroqThinkProvider = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ThinkSettingsV1Provider(
            global::Deepgram.Realtime.OpenAiThinkProvider? openAiThinkProvider,
            global::Deepgram.Realtime.AwsBedrockThinkProvider? awsBedrockThinkProvider,
            global::Deepgram.Realtime.AnthropicThinkProvider? anthropicThinkProvider,
            global::Deepgram.Realtime.GoogleThinkProvider? googleThinkProvider,
            global::Deepgram.Realtime.GroqThinkProvider? groqThinkProvider
            )
        {
            OpenAiThinkProvider = openAiThinkProvider;
            AwsBedrockThinkProvider = awsBedrockThinkProvider;
            AnthropicThinkProvider = anthropicThinkProvider;
            GoogleThinkProvider = googleThinkProvider;
            GroqThinkProvider = groqThinkProvider;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GroqThinkProvider as object ??
            GoogleThinkProvider as object ??
            AnthropicThinkProvider as object ??
            AwsBedrockThinkProvider as object ??
            OpenAiThinkProvider as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenAiThinkProvider?.ToString() ??
            AwsBedrockThinkProvider?.ToString() ??
            AnthropicThinkProvider?.ToString() ??
            GoogleThinkProvider?.ToString() ??
            GroqThinkProvider?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenAiThinkProvider && !IsAwsBedrockThinkProvider && !IsAnthropicThinkProvider && !IsGoogleThinkProvider && !IsGroqThinkProvider || !IsOpenAiThinkProvider && IsAwsBedrockThinkProvider && !IsAnthropicThinkProvider && !IsGoogleThinkProvider && !IsGroqThinkProvider || !IsOpenAiThinkProvider && !IsAwsBedrockThinkProvider && IsAnthropicThinkProvider && !IsGoogleThinkProvider && !IsGroqThinkProvider || !IsOpenAiThinkProvider && !IsAwsBedrockThinkProvider && !IsAnthropicThinkProvider && IsGoogleThinkProvider && !IsGroqThinkProvider || !IsOpenAiThinkProvider && !IsAwsBedrockThinkProvider && !IsAnthropicThinkProvider && !IsGoogleThinkProvider && IsGroqThinkProvider;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.OpenAiThinkProvider?, TResult>? openAiThinkProvider = null,
            global::System.Func<global::Deepgram.Realtime.AwsBedrockThinkProvider?, TResult>? awsBedrockThinkProvider = null,
            global::System.Func<global::Deepgram.Realtime.AnthropicThinkProvider?, TResult>? anthropicThinkProvider = null,
            global::System.Func<global::Deepgram.Realtime.GoogleThinkProvider?, TResult>? googleThinkProvider = null,
            global::System.Func<global::Deepgram.Realtime.GroqThinkProvider?, TResult>? groqThinkProvider = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAiThinkProvider && openAiThinkProvider != null)
            {
                return openAiThinkProvider(OpenAiThinkProvider!);
            }
            else if (IsAwsBedrockThinkProvider && awsBedrockThinkProvider != null)
            {
                return awsBedrockThinkProvider(AwsBedrockThinkProvider!);
            }
            else if (IsAnthropicThinkProvider && anthropicThinkProvider != null)
            {
                return anthropicThinkProvider(AnthropicThinkProvider!);
            }
            else if (IsGoogleThinkProvider && googleThinkProvider != null)
            {
                return googleThinkProvider(GoogleThinkProvider!);
            }
            else if (IsGroqThinkProvider && groqThinkProvider != null)
            {
                return groqThinkProvider(GroqThinkProvider!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.OpenAiThinkProvider?>? openAiThinkProvider = null,
            global::System.Action<global::Deepgram.Realtime.AwsBedrockThinkProvider?>? awsBedrockThinkProvider = null,
            global::System.Action<global::Deepgram.Realtime.AnthropicThinkProvider?>? anthropicThinkProvider = null,
            global::System.Action<global::Deepgram.Realtime.GoogleThinkProvider?>? googleThinkProvider = null,
            global::System.Action<global::Deepgram.Realtime.GroqThinkProvider?>? groqThinkProvider = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAiThinkProvider)
            {
                openAiThinkProvider?.Invoke(OpenAiThinkProvider!);
            }
            else if (IsAwsBedrockThinkProvider)
            {
                awsBedrockThinkProvider?.Invoke(AwsBedrockThinkProvider!);
            }
            else if (IsAnthropicThinkProvider)
            {
                anthropicThinkProvider?.Invoke(AnthropicThinkProvider!);
            }
            else if (IsGoogleThinkProvider)
            {
                googleThinkProvider?.Invoke(GoogleThinkProvider!);
            }
            else if (IsGroqThinkProvider)
            {
                groqThinkProvider?.Invoke(GroqThinkProvider!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAiThinkProvider,
                typeof(global::Deepgram.Realtime.OpenAiThinkProvider),
                AwsBedrockThinkProvider,
                typeof(global::Deepgram.Realtime.AwsBedrockThinkProvider),
                AnthropicThinkProvider,
                typeof(global::Deepgram.Realtime.AnthropicThinkProvider),
                GoogleThinkProvider,
                typeof(global::Deepgram.Realtime.GoogleThinkProvider),
                GroqThinkProvider,
                typeof(global::Deepgram.Realtime.GroqThinkProvider),
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
        public bool Equals(ThinkSettingsV1Provider other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.OpenAiThinkProvider?>.Default.Equals(OpenAiThinkProvider, other.OpenAiThinkProvider) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AwsBedrockThinkProvider?>.Default.Equals(AwsBedrockThinkProvider, other.AwsBedrockThinkProvider) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AnthropicThinkProvider?>.Default.Equals(AnthropicThinkProvider, other.AnthropicThinkProvider) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.GoogleThinkProvider?>.Default.Equals(GoogleThinkProvider, other.GoogleThinkProvider) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.GroqThinkProvider?>.Default.Equals(GroqThinkProvider, other.GroqThinkProvider) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ThinkSettingsV1Provider obj1, ThinkSettingsV1Provider obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ThinkSettingsV1Provider>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ThinkSettingsV1Provider obj1, ThinkSettingsV1Provider obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ThinkSettingsV1Provider o && Equals(o);
        }
    }
}
