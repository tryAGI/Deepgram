#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateKeyV1Request : global::System.IEquatable<CreateKeyV1Request>
    {
        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? CreateKeyV1RequestVariant1 { get; init; }
#else
        public object? CreateKeyV1RequestVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateKeyV1RequestVariant1))]
#endif
        public bool IsCreateKeyV1RequestVariant1 => CreateKeyV1RequestVariant1 != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? CreateKeyV1RequestVariant2 { get; init; }
#else
        public object? CreateKeyV1RequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateKeyV1RequestVariant2))]
#endif
        public bool IsCreateKeyV1RequestVariant2 => CreateKeyV1RequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public CreateKeyV1Request(
            object? createKeyV1RequestVariant1,
            object? createKeyV1RequestVariant2
            )
        {
            CreateKeyV1RequestVariant1 = createKeyV1RequestVariant1;
            CreateKeyV1RequestVariant2 = createKeyV1RequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateKeyV1RequestVariant2 as object ??
            CreateKeyV1RequestVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateKeyV1RequestVariant1?.ToString() ??
            CreateKeyV1RequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateKeyV1RequestVariant1 && !IsCreateKeyV1RequestVariant2 || !IsCreateKeyV1RequestVariant1 && IsCreateKeyV1RequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<object?, TResult>? createKeyV1RequestVariant1 = null,
            global::System.Func<object?, TResult>? createKeyV1RequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateKeyV1RequestVariant1 && createKeyV1RequestVariant1 != null)
            {
                return createKeyV1RequestVariant1(CreateKeyV1RequestVariant1!);
            }
            else if (IsCreateKeyV1RequestVariant2 && createKeyV1RequestVariant2 != null)
            {
                return createKeyV1RequestVariant2(CreateKeyV1RequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<object?>? createKeyV1RequestVariant1 = null,
            global::System.Action<object?>? createKeyV1RequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateKeyV1RequestVariant1)
            {
                createKeyV1RequestVariant1?.Invoke(CreateKeyV1RequestVariant1!);
            }
            else if (IsCreateKeyV1RequestVariant2)
            {
                createKeyV1RequestVariant2?.Invoke(CreateKeyV1RequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateKeyV1RequestVariant1,
                typeof(object),
                CreateKeyV1RequestVariant2,
                typeof(object),
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
        public bool Equals(CreateKeyV1Request other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(CreateKeyV1RequestVariant1, other.CreateKeyV1RequestVariant1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(CreateKeyV1RequestVariant2, other.CreateKeyV1RequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateKeyV1Request obj1, CreateKeyV1Request obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateKeyV1Request>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateKeyV1Request obj1, CreateKeyV1Request obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateKeyV1Request o && Equals(o);
        }
    }
}
