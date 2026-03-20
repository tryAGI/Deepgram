
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListenV1MediaTranscribeRedactVariant2Item
    {
        /// <summary>
        /// 
        /// </summary>
        Pci,
        /// <summary>
        /// 
        /// </summary>
        Pii,
        /// <summary>
        /// 
        /// </summary>
        Numbers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1MediaTranscribeRedactVariant2ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1MediaTranscribeRedactVariant2Item value)
        {
            return value switch
            {
                ListenV1MediaTranscribeRedactVariant2Item.Pci => "pci",
                ListenV1MediaTranscribeRedactVariant2Item.Pii => "pii",
                ListenV1MediaTranscribeRedactVariant2Item.Numbers => "numbers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1MediaTranscribeRedactVariant2Item? ToEnum(string value)
        {
            return value switch
            {
                "pci" => ListenV1MediaTranscribeRedactVariant2Item.Pci,
                "pii" => ListenV1MediaTranscribeRedactVariant2Item.Pii,
                "numbers" => ListenV1MediaTranscribeRedactVariant2Item.Numbers,
                _ => null,
            };
        }
    }
}