
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
    public static class ListenV1MediaTranscribeRedactVariant2ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1MediaTranscribeRedactVariant2Item value)
        {
            return value switch
            {
                ListenV1MediaTranscribeRedactVariant2Item.Numbers => "numbers",
                ListenV1MediaTranscribeRedactVariant2Item.Pci => "pci",
                ListenV1MediaTranscribeRedactVariant2Item.Pii => "pii",
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
                "numbers" => ListenV1MediaTranscribeRedactVariant2Item.Numbers,
                "pci" => ListenV1MediaTranscribeRedactVariant2Item.Pci,
                "pii" => ListenV1MediaTranscribeRedactVariant2Item.Pii,
                _ => null,
            };
        }
    }
}