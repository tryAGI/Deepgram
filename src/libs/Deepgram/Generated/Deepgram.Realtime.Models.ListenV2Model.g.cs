
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Defines the AI model used to process submitted audio.
    /// </summary>
    public enum ListenV2Model
    {
        /// <summary>
        /// 
        /// </summary>
        FluxGeneralEn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV2ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV2Model value)
        {
            return value switch
            {
                ListenV2Model.FluxGeneralEn => "flux-general-en",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV2Model? ToEnum(string value)
        {
            return value switch
            {
                "flux-general-en" => ListenV2Model.FluxGeneralEn,
                _ => null,
            };
        }
    }
}