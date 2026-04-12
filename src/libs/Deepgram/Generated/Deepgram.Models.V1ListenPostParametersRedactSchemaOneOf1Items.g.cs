
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ListenPostParametersRedactSchemaOneOf1Items
    {
        /// <summary>
        /// 
        /// </summary>
        Numbers,
        /// <summary>
        /// 
        /// </summary>
        Pci,
        /// <summary>
        /// 
        /// </summary>
        Pii,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ListenPostParametersRedactSchemaOneOf1ItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ListenPostParametersRedactSchemaOneOf1Items value)
        {
            return value switch
            {
                V1ListenPostParametersRedactSchemaOneOf1Items.Numbers => "numbers",
                V1ListenPostParametersRedactSchemaOneOf1Items.Pci => "pci",
                V1ListenPostParametersRedactSchemaOneOf1Items.Pii => "pii",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ListenPostParametersRedactSchemaOneOf1Items? ToEnum(string value)
        {
            return value switch
            {
                "numbers" => V1ListenPostParametersRedactSchemaOneOf1Items.Numbers,
                "pci" => V1ListenPostParametersRedactSchemaOneOf1Items.Pci,
                "pii" => V1ListenPostParametersRedactSchemaOneOf1Items.Pii,
                _ => null,
            };
        }
    }
}