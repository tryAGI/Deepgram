
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ListenPostParametersDiarizeModel
    {
        /// <summary>
        /// 
        /// </summary>
        Latest,
        /// <summary>
        /// 
        /// </summary>
        V1,
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ListenPostParametersDiarizeModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ListenPostParametersDiarizeModel value)
        {
            return value switch
            {
                V1ListenPostParametersDiarizeModel.Latest => "latest",
                V1ListenPostParametersDiarizeModel.V1 => "v1",
                V1ListenPostParametersDiarizeModel.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ListenPostParametersDiarizeModel? ToEnum(string value)
        {
            return value switch
            {
                "latest" => V1ListenPostParametersDiarizeModel.Latest,
                "v1" => V1ListenPostParametersDiarizeModel.V1,
                "v2" => V1ListenPostParametersDiarizeModel.V2,
                _ => null,
            };
        }
    }
}