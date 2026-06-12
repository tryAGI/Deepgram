
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListenV1DiarizeModel
    {
        /// <summary>
        /// 
        /// </summary>
        Latest,
        /// <summary>
        /// 
        /// </summary>
        V1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1DiarizeModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1DiarizeModel value)
        {
            return value switch
            {
                ListenV1DiarizeModel.Latest => "latest",
                ListenV1DiarizeModel.V1 => "v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1DiarizeModel? ToEnum(string value)
        {
            return value switch
            {
                "latest" => ListenV1DiarizeModel.Latest,
                "v1" => ListenV1DiarizeModel.V1,
                _ => null,
            };
        }
    }
}