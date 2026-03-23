
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// AI model to use for the transcription
    /// </summary>
    public enum ListenV1Model
    {
        /// <summary>
        /// 
        /// </summary>
        Base,
        /// <summary>
        /// 
        /// </summary>
        Conversationalai,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Enhanced,
        /// <summary>
        /// 
        /// </summary>
        EnhancedFinance,
        /// <summary>
        /// 
        /// </summary>
        EnhancedGeneral,
        /// <summary>
        /// 
        /// </summary>
        EnhancedMeeting,
        /// <summary>
        /// 
        /// </summary>
        EnhancedPhonecall,
        /// <summary>
        /// 
        /// </summary>
        Finance,
        /// <summary>
        /// 
        /// </summary>
        Meeting,
        /// <summary>
        /// 
        /// </summary>
        Nova,
        /// <summary>
        /// 
        /// </summary>
        Nova2,
        /// <summary>
        /// 
        /// </summary>
        Nova2Automotive,
        /// <summary>
        /// 
        /// </summary>
        Nova2Conversationalai,
        /// <summary>
        /// 
        /// </summary>
        Nova2Drivethru,
        /// <summary>
        /// 
        /// </summary>
        Nova2Finance,
        /// <summary>
        /// 
        /// </summary>
        Nova2General,
        /// <summary>
        /// 
        /// </summary>
        Nova2Medical,
        /// <summary>
        /// 
        /// </summary>
        Nova2Meeting,
        /// <summary>
        /// 
        /// </summary>
        Nova2Video,
        /// <summary>
        /// 
        /// </summary>
        Nova2Voicemail,
        /// <summary>
        /// 
        /// </summary>
        Nova3,
        /// <summary>
        /// 
        /// </summary>
        Nova3General,
        /// <summary>
        /// 
        /// </summary>
        Nova3Medical,
        /// <summary>
        /// 
        /// </summary>
        NovaGeneral,
        /// <summary>
        /// 
        /// </summary>
        NovaMedical,
        /// <summary>
        /// 
        /// </summary>
        NovaPhonecall,
        /// <summary>
        /// 
        /// </summary>
        Phonecall,
        /// <summary>
        /// 
        /// </summary>
        Video,
        /// <summary>
        /// 
        /// </summary>
        Voicemail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1Model value)
        {
            return value switch
            {
                ListenV1Model.Base => "base",
                ListenV1Model.Conversationalai => "conversationalai",
                ListenV1Model.Custom => "custom",
                ListenV1Model.Enhanced => "enhanced",
                ListenV1Model.EnhancedFinance => "enhanced-finance",
                ListenV1Model.EnhancedGeneral => "enhanced-general",
                ListenV1Model.EnhancedMeeting => "enhanced-meeting",
                ListenV1Model.EnhancedPhonecall => "enhanced-phonecall",
                ListenV1Model.Finance => "finance",
                ListenV1Model.Meeting => "meeting",
                ListenV1Model.Nova => "nova",
                ListenV1Model.Nova2 => "nova-2",
                ListenV1Model.Nova2Automotive => "nova-2-automotive",
                ListenV1Model.Nova2Conversationalai => "nova-2-conversationalai",
                ListenV1Model.Nova2Drivethru => "nova-2-drivethru",
                ListenV1Model.Nova2Finance => "nova-2-finance",
                ListenV1Model.Nova2General => "nova-2-general",
                ListenV1Model.Nova2Medical => "nova-2-medical",
                ListenV1Model.Nova2Meeting => "nova-2-meeting",
                ListenV1Model.Nova2Video => "nova-2-video",
                ListenV1Model.Nova2Voicemail => "nova-2-voicemail",
                ListenV1Model.Nova3 => "nova-3",
                ListenV1Model.Nova3General => "nova-3-general",
                ListenV1Model.Nova3Medical => "nova-3-medical",
                ListenV1Model.NovaGeneral => "nova-general",
                ListenV1Model.NovaMedical => "nova-medical",
                ListenV1Model.NovaPhonecall => "nova-phonecall",
                ListenV1Model.Phonecall => "phonecall",
                ListenV1Model.Video => "video",
                ListenV1Model.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1Model? ToEnum(string value)
        {
            return value switch
            {
                "base" => ListenV1Model.Base,
                "conversationalai" => ListenV1Model.Conversationalai,
                "custom" => ListenV1Model.Custom,
                "enhanced" => ListenV1Model.Enhanced,
                "enhanced-finance" => ListenV1Model.EnhancedFinance,
                "enhanced-general" => ListenV1Model.EnhancedGeneral,
                "enhanced-meeting" => ListenV1Model.EnhancedMeeting,
                "enhanced-phonecall" => ListenV1Model.EnhancedPhonecall,
                "finance" => ListenV1Model.Finance,
                "meeting" => ListenV1Model.Meeting,
                "nova" => ListenV1Model.Nova,
                "nova-2" => ListenV1Model.Nova2,
                "nova-2-automotive" => ListenV1Model.Nova2Automotive,
                "nova-2-conversationalai" => ListenV1Model.Nova2Conversationalai,
                "nova-2-drivethru" => ListenV1Model.Nova2Drivethru,
                "nova-2-finance" => ListenV1Model.Nova2Finance,
                "nova-2-general" => ListenV1Model.Nova2General,
                "nova-2-medical" => ListenV1Model.Nova2Medical,
                "nova-2-meeting" => ListenV1Model.Nova2Meeting,
                "nova-2-video" => ListenV1Model.Nova2Video,
                "nova-2-voicemail" => ListenV1Model.Nova2Voicemail,
                "nova-3" => ListenV1Model.Nova3,
                "nova-3-general" => ListenV1Model.Nova3General,
                "nova-3-medical" => ListenV1Model.Nova3Medical,
                "nova-general" => ListenV1Model.NovaGeneral,
                "nova-medical" => ListenV1Model.NovaMedical,
                "nova-phonecall" => ListenV1Model.NovaPhonecall,
                "phonecall" => ListenV1Model.Phonecall,
                "video" => ListenV1Model.Video,
                "voicemail" => ListenV1Model.Voicemail,
                _ => null,
            };
        }
    }
}