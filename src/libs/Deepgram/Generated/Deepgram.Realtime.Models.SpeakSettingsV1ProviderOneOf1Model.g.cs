
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Flux TTS model to use, in the format flux-{voice}-{language} (e.g. flux-alexis-en). See the Flux TTS voice catalog for the full list.
    /// </summary>
    public enum SpeakSettingsV1ProviderOneOf1Model
    {
        /// <summary>
        /// 
        /// </summary>
        FluxAlexisEn,
        /// <summary>
        /// 
        /// </summary>
        FluxBruceEn,
        /// <summary>
        /// 
        /// </summary>
        FluxColeEn,
        /// <summary>
        /// 
        /// </summary>
        FluxDrewEn,
        /// <summary>
        /// 
        /// </summary>
        FluxHaleyEn,
        /// <summary>
        /// 
        /// </summary>
        FluxHeatherEn,
        /// <summary>
        /// 
        /// </summary>
        FluxJackEn,
        /// <summary>
        /// 
        /// </summary>
        FluxMarcusEn,
        /// <summary>
        /// 
        /// </summary>
        FluxPriyaEn,
        /// <summary>
        /// 
        /// </summary>
        FluxReneeEn,
        /// <summary>
        /// 
        /// </summary>
        FluxRufusEn,
        /// <summary>
        /// 
        /// </summary>
        FluxSharonEn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakSettingsV1ProviderOneOf1ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakSettingsV1ProviderOneOf1Model value)
        {
            return value switch
            {
                SpeakSettingsV1ProviderOneOf1Model.FluxAlexisEn => "flux-alexis-en",
                SpeakSettingsV1ProviderOneOf1Model.FluxBruceEn => "flux-bruce-en",
                SpeakSettingsV1ProviderOneOf1Model.FluxColeEn => "flux-cole-en",
                SpeakSettingsV1ProviderOneOf1Model.FluxDrewEn => "flux-drew-en",
                SpeakSettingsV1ProviderOneOf1Model.FluxHaleyEn => "flux-haley-en",
                SpeakSettingsV1ProviderOneOf1Model.FluxHeatherEn => "flux-heather-en",
                SpeakSettingsV1ProviderOneOf1Model.FluxJackEn => "flux-jack-en",
                SpeakSettingsV1ProviderOneOf1Model.FluxMarcusEn => "flux-marcus-en",
                SpeakSettingsV1ProviderOneOf1Model.FluxPriyaEn => "flux-priya-en",
                SpeakSettingsV1ProviderOneOf1Model.FluxReneeEn => "flux-renee-en",
                SpeakSettingsV1ProviderOneOf1Model.FluxRufusEn => "flux-rufus-en",
                SpeakSettingsV1ProviderOneOf1Model.FluxSharonEn => "flux-sharon-en",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakSettingsV1ProviderOneOf1Model? ToEnum(string value)
        {
            return value switch
            {
                "flux-alexis-en" => SpeakSettingsV1ProviderOneOf1Model.FluxAlexisEn,
                "flux-bruce-en" => SpeakSettingsV1ProviderOneOf1Model.FluxBruceEn,
                "flux-cole-en" => SpeakSettingsV1ProviderOneOf1Model.FluxColeEn,
                "flux-drew-en" => SpeakSettingsV1ProviderOneOf1Model.FluxDrewEn,
                "flux-haley-en" => SpeakSettingsV1ProviderOneOf1Model.FluxHaleyEn,
                "flux-heather-en" => SpeakSettingsV1ProviderOneOf1Model.FluxHeatherEn,
                "flux-jack-en" => SpeakSettingsV1ProviderOneOf1Model.FluxJackEn,
                "flux-marcus-en" => SpeakSettingsV1ProviderOneOf1Model.FluxMarcusEn,
                "flux-priya-en" => SpeakSettingsV1ProviderOneOf1Model.FluxPriyaEn,
                "flux-renee-en" => SpeakSettingsV1ProviderOneOf1Model.FluxReneeEn,
                "flux-rufus-en" => SpeakSettingsV1ProviderOneOf1Model.FluxRufusEn,
                "flux-sharon-en" => SpeakSettingsV1ProviderOneOf1Model.FluxSharonEn,
                _ => null,
            };
        }
    }
}