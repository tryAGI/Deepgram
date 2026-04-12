
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Use the latest version of a model
    /// </summary>
    public enum V1ListenPostParametersVersion0
    {
        /// <summary>
        /// 
        /// </summary>
        Latest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ListenPostParametersVersion0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ListenPostParametersVersion0 value)
        {
            return value switch
            {
                V1ListenPostParametersVersion0.Latest => "latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ListenPostParametersVersion0? ToEnum(string value)
        {
            return value switch
            {
                "latest" => V1ListenPostParametersVersion0.Latest,
                _ => null,
            };
        }
    }
}