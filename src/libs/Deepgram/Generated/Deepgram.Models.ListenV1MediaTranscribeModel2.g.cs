
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Our public models available to all accounts
    /// </summary>
    public enum ListenV1MediaTranscribeModel2
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
    public static class ListenV1MediaTranscribeModel2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1MediaTranscribeModel2 value)
        {
            return value switch
            {
                ListenV1MediaTranscribeModel2.Base => "base",
                ListenV1MediaTranscribeModel2.Conversationalai => "conversationalai",
                ListenV1MediaTranscribeModel2.Enhanced => "enhanced",
                ListenV1MediaTranscribeModel2.EnhancedFinance => "enhanced-finance",
                ListenV1MediaTranscribeModel2.EnhancedGeneral => "enhanced-general",
                ListenV1MediaTranscribeModel2.EnhancedMeeting => "enhanced-meeting",
                ListenV1MediaTranscribeModel2.EnhancedPhonecall => "enhanced-phonecall",
                ListenV1MediaTranscribeModel2.Finance => "finance",
                ListenV1MediaTranscribeModel2.Meeting => "meeting",
                ListenV1MediaTranscribeModel2.Nova => "nova",
                ListenV1MediaTranscribeModel2.Nova2 => "nova-2",
                ListenV1MediaTranscribeModel2.Nova2Automotive => "nova-2-automotive",
                ListenV1MediaTranscribeModel2.Nova2Conversationalai => "nova-2-conversationalai",
                ListenV1MediaTranscribeModel2.Nova2Drivethru => "nova-2-drivethru",
                ListenV1MediaTranscribeModel2.Nova2Finance => "nova-2-finance",
                ListenV1MediaTranscribeModel2.Nova2General => "nova-2-general",
                ListenV1MediaTranscribeModel2.Nova2Medical => "nova-2-medical",
                ListenV1MediaTranscribeModel2.Nova2Meeting => "nova-2-meeting",
                ListenV1MediaTranscribeModel2.Nova2Video => "nova-2-video",
                ListenV1MediaTranscribeModel2.Nova2Voicemail => "nova-2-voicemail",
                ListenV1MediaTranscribeModel2.Nova3 => "nova-3",
                ListenV1MediaTranscribeModel2.Nova3General => "nova-3-general",
                ListenV1MediaTranscribeModel2.Nova3Medical => "nova-3-medical",
                ListenV1MediaTranscribeModel2.NovaGeneral => "nova-general",
                ListenV1MediaTranscribeModel2.NovaMedical => "nova-medical",
                ListenV1MediaTranscribeModel2.NovaPhonecall => "nova-phonecall",
                ListenV1MediaTranscribeModel2.Phonecall => "phonecall",
                ListenV1MediaTranscribeModel2.Video => "video",
                ListenV1MediaTranscribeModel2.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1MediaTranscribeModel2? ToEnum(string value)
        {
            return value switch
            {
                "base" => ListenV1MediaTranscribeModel2.Base,
                "conversationalai" => ListenV1MediaTranscribeModel2.Conversationalai,
                "enhanced" => ListenV1MediaTranscribeModel2.Enhanced,
                "enhanced-finance" => ListenV1MediaTranscribeModel2.EnhancedFinance,
                "enhanced-general" => ListenV1MediaTranscribeModel2.EnhancedGeneral,
                "enhanced-meeting" => ListenV1MediaTranscribeModel2.EnhancedMeeting,
                "enhanced-phonecall" => ListenV1MediaTranscribeModel2.EnhancedPhonecall,
                "finance" => ListenV1MediaTranscribeModel2.Finance,
                "meeting" => ListenV1MediaTranscribeModel2.Meeting,
                "nova" => ListenV1MediaTranscribeModel2.Nova,
                "nova-2" => ListenV1MediaTranscribeModel2.Nova2,
                "nova-2-automotive" => ListenV1MediaTranscribeModel2.Nova2Automotive,
                "nova-2-conversationalai" => ListenV1MediaTranscribeModel2.Nova2Conversationalai,
                "nova-2-drivethru" => ListenV1MediaTranscribeModel2.Nova2Drivethru,
                "nova-2-finance" => ListenV1MediaTranscribeModel2.Nova2Finance,
                "nova-2-general" => ListenV1MediaTranscribeModel2.Nova2General,
                "nova-2-medical" => ListenV1MediaTranscribeModel2.Nova2Medical,
                "nova-2-meeting" => ListenV1MediaTranscribeModel2.Nova2Meeting,
                "nova-2-video" => ListenV1MediaTranscribeModel2.Nova2Video,
                "nova-2-voicemail" => ListenV1MediaTranscribeModel2.Nova2Voicemail,
                "nova-3" => ListenV1MediaTranscribeModel2.Nova3,
                "nova-3-general" => ListenV1MediaTranscribeModel2.Nova3General,
                "nova-3-medical" => ListenV1MediaTranscribeModel2.Nova3Medical,
                "nova-general" => ListenV1MediaTranscribeModel2.NovaGeneral,
                "nova-medical" => ListenV1MediaTranscribeModel2.NovaMedical,
                "nova-phonecall" => ListenV1MediaTranscribeModel2.NovaPhonecall,
                "phonecall" => ListenV1MediaTranscribeModel2.Phonecall,
                "video" => ListenV1MediaTranscribeModel2.Video,
                "voicemail" => ListenV1MediaTranscribeModel2.Voicemail,
                _ => null,
            };
        }
    }
}