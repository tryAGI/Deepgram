
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Deepgram TTS model
    /// </summary>
    public enum DeepgramSpeakProviderModel
    {
        /// <summary>
        /// 
        /// </summary>
        AuraAsteriaEn,
        /// <summary>
        /// 
        /// </summary>
        AuraLunaEn,
        /// <summary>
        /// 
        /// </summary>
        AuraStellaEn,
        /// <summary>
        /// 
        /// </summary>
        AuraAthenaEn,
        /// <summary>
        /// 
        /// </summary>
        AuraHeraEn,
        /// <summary>
        /// 
        /// </summary>
        AuraOrionEn,
        /// <summary>
        /// 
        /// </summary>
        AuraArcasEn,
        /// <summary>
        /// 
        /// </summary>
        AuraPerseusEn,
        /// <summary>
        /// 
        /// </summary>
        AuraAngusEn,
        /// <summary>
        /// 
        /// </summary>
        AuraOrpheusEn,
        /// <summary>
        /// 
        /// </summary>
        AuraHeliosEn,
        /// <summary>
        /// 
        /// </summary>
        AuraZeusEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2AmaltheaEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2AndromedaEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2ApolloEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2ArcasEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2AriesEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2AsteriaEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2AthenaEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2AtlasEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2AuroraEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2CallistaEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2CoraEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2CordeliaEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2DeliaEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2DracoEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2ElectraEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2HarmoniaEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2HelenaEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2HeraEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2HermesEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2HyperionEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2IrisEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2JanusEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2JunoEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2JupiterEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2LunaEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2MarsEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2MinervaEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2NeptuneEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2OdysseusEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2OpheliaEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2OrionEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2OrpheusEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2PandoraEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2PhoebeEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2PlutoEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2SaturnEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2SeleneEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2ThaliaEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2TheiaEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2VestaEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2ZeusEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2SirioEs,
        /// <summary>
        /// 
        /// </summary>
        Aura2NestorEs,
        /// <summary>
        /// 
        /// </summary>
        Aura2CarinaEs,
        /// <summary>
        /// 
        /// </summary>
        Aura2CelesteEs,
        /// <summary>
        /// 
        /// </summary>
        Aura2AlvaroEs,
        /// <summary>
        /// 
        /// </summary>
        Aura2DianaEs,
        /// <summary>
        /// 
        /// </summary>
        Aura2AquilaEs,
        /// <summary>
        /// 
        /// </summary>
        Aura2SelenaEs,
        /// <summary>
        /// 
        /// </summary>
        Aura2EstrellaEs,
        /// <summary>
        /// 
        /// </summary>
        Aura2JavierEs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeepgramSpeakProviderModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepgramSpeakProviderModel value)
        {
            return value switch
            {
                DeepgramSpeakProviderModel.AuraAsteriaEn => "aura-asteria-en",
                DeepgramSpeakProviderModel.AuraLunaEn => "aura-luna-en",
                DeepgramSpeakProviderModel.AuraStellaEn => "aura-stella-en",
                DeepgramSpeakProviderModel.AuraAthenaEn => "aura-athena-en",
                DeepgramSpeakProviderModel.AuraHeraEn => "aura-hera-en",
                DeepgramSpeakProviderModel.AuraOrionEn => "aura-orion-en",
                DeepgramSpeakProviderModel.AuraArcasEn => "aura-arcas-en",
                DeepgramSpeakProviderModel.AuraPerseusEn => "aura-perseus-en",
                DeepgramSpeakProviderModel.AuraAngusEn => "aura-angus-en",
                DeepgramSpeakProviderModel.AuraOrpheusEn => "aura-orpheus-en",
                DeepgramSpeakProviderModel.AuraHeliosEn => "aura-helios-en",
                DeepgramSpeakProviderModel.AuraZeusEn => "aura-zeus-en",
                DeepgramSpeakProviderModel.Aura2AmaltheaEn => "aura-2-amalthea-en",
                DeepgramSpeakProviderModel.Aura2AndromedaEn => "aura-2-andromeda-en",
                DeepgramSpeakProviderModel.Aura2ApolloEn => "aura-2-apollo-en",
                DeepgramSpeakProviderModel.Aura2ArcasEn => "aura-2-arcas-en",
                DeepgramSpeakProviderModel.Aura2AriesEn => "aura-2-aries-en",
                DeepgramSpeakProviderModel.Aura2AsteriaEn => "aura-2-asteria-en",
                DeepgramSpeakProviderModel.Aura2AthenaEn => "aura-2-athena-en",
                DeepgramSpeakProviderModel.Aura2AtlasEn => "aura-2-atlas-en",
                DeepgramSpeakProviderModel.Aura2AuroraEn => "aura-2-aurora-en",
                DeepgramSpeakProviderModel.Aura2CallistaEn => "aura-2-callista-en",
                DeepgramSpeakProviderModel.Aura2CoraEn => "aura-2-cora-en",
                DeepgramSpeakProviderModel.Aura2CordeliaEn => "aura-2-cordelia-en",
                DeepgramSpeakProviderModel.Aura2DeliaEn => "aura-2-delia-en",
                DeepgramSpeakProviderModel.Aura2DracoEn => "aura-2-draco-en",
                DeepgramSpeakProviderModel.Aura2ElectraEn => "aura-2-electra-en",
                DeepgramSpeakProviderModel.Aura2HarmoniaEn => "aura-2-harmonia-en",
                DeepgramSpeakProviderModel.Aura2HelenaEn => "aura-2-helena-en",
                DeepgramSpeakProviderModel.Aura2HeraEn => "aura-2-hera-en",
                DeepgramSpeakProviderModel.Aura2HermesEn => "aura-2-hermes-en",
                DeepgramSpeakProviderModel.Aura2HyperionEn => "aura-2-hyperion-en",
                DeepgramSpeakProviderModel.Aura2IrisEn => "aura-2-iris-en",
                DeepgramSpeakProviderModel.Aura2JanusEn => "aura-2-janus-en",
                DeepgramSpeakProviderModel.Aura2JunoEn => "aura-2-juno-en",
                DeepgramSpeakProviderModel.Aura2JupiterEn => "aura-2-jupiter-en",
                DeepgramSpeakProviderModel.Aura2LunaEn => "aura-2-luna-en",
                DeepgramSpeakProviderModel.Aura2MarsEn => "aura-2-mars-en",
                DeepgramSpeakProviderModel.Aura2MinervaEn => "aura-2-minerva-en",
                DeepgramSpeakProviderModel.Aura2NeptuneEn => "aura-2-neptune-en",
                DeepgramSpeakProviderModel.Aura2OdysseusEn => "aura-2-odysseus-en",
                DeepgramSpeakProviderModel.Aura2OpheliaEn => "aura-2-ophelia-en",
                DeepgramSpeakProviderModel.Aura2OrionEn => "aura-2-orion-en",
                DeepgramSpeakProviderModel.Aura2OrpheusEn => "aura-2-orpheus-en",
                DeepgramSpeakProviderModel.Aura2PandoraEn => "aura-2-pandora-en",
                DeepgramSpeakProviderModel.Aura2PhoebeEn => "aura-2-phoebe-en",
                DeepgramSpeakProviderModel.Aura2PlutoEn => "aura-2-pluto-en",
                DeepgramSpeakProviderModel.Aura2SaturnEn => "aura-2-saturn-en",
                DeepgramSpeakProviderModel.Aura2SeleneEn => "aura-2-selene-en",
                DeepgramSpeakProviderModel.Aura2ThaliaEn => "aura-2-thalia-en",
                DeepgramSpeakProviderModel.Aura2TheiaEn => "aura-2-theia-en",
                DeepgramSpeakProviderModel.Aura2VestaEn => "aura-2-vesta-en",
                DeepgramSpeakProviderModel.Aura2ZeusEn => "aura-2-zeus-en",
                DeepgramSpeakProviderModel.Aura2SirioEs => "aura-2-sirio-es",
                DeepgramSpeakProviderModel.Aura2NestorEs => "aura-2-nestor-es",
                DeepgramSpeakProviderModel.Aura2CarinaEs => "aura-2-carina-es",
                DeepgramSpeakProviderModel.Aura2CelesteEs => "aura-2-celeste-es",
                DeepgramSpeakProviderModel.Aura2AlvaroEs => "aura-2-alvaro-es",
                DeepgramSpeakProviderModel.Aura2DianaEs => "aura-2-diana-es",
                DeepgramSpeakProviderModel.Aura2AquilaEs => "aura-2-aquila-es",
                DeepgramSpeakProviderModel.Aura2SelenaEs => "aura-2-selena-es",
                DeepgramSpeakProviderModel.Aura2EstrellaEs => "aura-2-estrella-es",
                DeepgramSpeakProviderModel.Aura2JavierEs => "aura-2-javier-es",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepgramSpeakProviderModel? ToEnum(string value)
        {
            return value switch
            {
                "aura-asteria-en" => DeepgramSpeakProviderModel.AuraAsteriaEn,
                "aura-luna-en" => DeepgramSpeakProviderModel.AuraLunaEn,
                "aura-stella-en" => DeepgramSpeakProviderModel.AuraStellaEn,
                "aura-athena-en" => DeepgramSpeakProviderModel.AuraAthenaEn,
                "aura-hera-en" => DeepgramSpeakProviderModel.AuraHeraEn,
                "aura-orion-en" => DeepgramSpeakProviderModel.AuraOrionEn,
                "aura-arcas-en" => DeepgramSpeakProviderModel.AuraArcasEn,
                "aura-perseus-en" => DeepgramSpeakProviderModel.AuraPerseusEn,
                "aura-angus-en" => DeepgramSpeakProviderModel.AuraAngusEn,
                "aura-orpheus-en" => DeepgramSpeakProviderModel.AuraOrpheusEn,
                "aura-helios-en" => DeepgramSpeakProviderModel.AuraHeliosEn,
                "aura-zeus-en" => DeepgramSpeakProviderModel.AuraZeusEn,
                "aura-2-amalthea-en" => DeepgramSpeakProviderModel.Aura2AmaltheaEn,
                "aura-2-andromeda-en" => DeepgramSpeakProviderModel.Aura2AndromedaEn,
                "aura-2-apollo-en" => DeepgramSpeakProviderModel.Aura2ApolloEn,
                "aura-2-arcas-en" => DeepgramSpeakProviderModel.Aura2ArcasEn,
                "aura-2-aries-en" => DeepgramSpeakProviderModel.Aura2AriesEn,
                "aura-2-asteria-en" => DeepgramSpeakProviderModel.Aura2AsteriaEn,
                "aura-2-athena-en" => DeepgramSpeakProviderModel.Aura2AthenaEn,
                "aura-2-atlas-en" => DeepgramSpeakProviderModel.Aura2AtlasEn,
                "aura-2-aurora-en" => DeepgramSpeakProviderModel.Aura2AuroraEn,
                "aura-2-callista-en" => DeepgramSpeakProviderModel.Aura2CallistaEn,
                "aura-2-cora-en" => DeepgramSpeakProviderModel.Aura2CoraEn,
                "aura-2-cordelia-en" => DeepgramSpeakProviderModel.Aura2CordeliaEn,
                "aura-2-delia-en" => DeepgramSpeakProviderModel.Aura2DeliaEn,
                "aura-2-draco-en" => DeepgramSpeakProviderModel.Aura2DracoEn,
                "aura-2-electra-en" => DeepgramSpeakProviderModel.Aura2ElectraEn,
                "aura-2-harmonia-en" => DeepgramSpeakProviderModel.Aura2HarmoniaEn,
                "aura-2-helena-en" => DeepgramSpeakProviderModel.Aura2HelenaEn,
                "aura-2-hera-en" => DeepgramSpeakProviderModel.Aura2HeraEn,
                "aura-2-hermes-en" => DeepgramSpeakProviderModel.Aura2HermesEn,
                "aura-2-hyperion-en" => DeepgramSpeakProviderModel.Aura2HyperionEn,
                "aura-2-iris-en" => DeepgramSpeakProviderModel.Aura2IrisEn,
                "aura-2-janus-en" => DeepgramSpeakProviderModel.Aura2JanusEn,
                "aura-2-juno-en" => DeepgramSpeakProviderModel.Aura2JunoEn,
                "aura-2-jupiter-en" => DeepgramSpeakProviderModel.Aura2JupiterEn,
                "aura-2-luna-en" => DeepgramSpeakProviderModel.Aura2LunaEn,
                "aura-2-mars-en" => DeepgramSpeakProviderModel.Aura2MarsEn,
                "aura-2-minerva-en" => DeepgramSpeakProviderModel.Aura2MinervaEn,
                "aura-2-neptune-en" => DeepgramSpeakProviderModel.Aura2NeptuneEn,
                "aura-2-odysseus-en" => DeepgramSpeakProviderModel.Aura2OdysseusEn,
                "aura-2-ophelia-en" => DeepgramSpeakProviderModel.Aura2OpheliaEn,
                "aura-2-orion-en" => DeepgramSpeakProviderModel.Aura2OrionEn,
                "aura-2-orpheus-en" => DeepgramSpeakProviderModel.Aura2OrpheusEn,
                "aura-2-pandora-en" => DeepgramSpeakProviderModel.Aura2PandoraEn,
                "aura-2-phoebe-en" => DeepgramSpeakProviderModel.Aura2PhoebeEn,
                "aura-2-pluto-en" => DeepgramSpeakProviderModel.Aura2PlutoEn,
                "aura-2-saturn-en" => DeepgramSpeakProviderModel.Aura2SaturnEn,
                "aura-2-selene-en" => DeepgramSpeakProviderModel.Aura2SeleneEn,
                "aura-2-thalia-en" => DeepgramSpeakProviderModel.Aura2ThaliaEn,
                "aura-2-theia-en" => DeepgramSpeakProviderModel.Aura2TheiaEn,
                "aura-2-vesta-en" => DeepgramSpeakProviderModel.Aura2VestaEn,
                "aura-2-zeus-en" => DeepgramSpeakProviderModel.Aura2ZeusEn,
                "aura-2-sirio-es" => DeepgramSpeakProviderModel.Aura2SirioEs,
                "aura-2-nestor-es" => DeepgramSpeakProviderModel.Aura2NestorEs,
                "aura-2-carina-es" => DeepgramSpeakProviderModel.Aura2CarinaEs,
                "aura-2-celeste-es" => DeepgramSpeakProviderModel.Aura2CelesteEs,
                "aura-2-alvaro-es" => DeepgramSpeakProviderModel.Aura2AlvaroEs,
                "aura-2-diana-es" => DeepgramSpeakProviderModel.Aura2DianaEs,
                "aura-2-aquila-es" => DeepgramSpeakProviderModel.Aura2AquilaEs,
                "aura-2-selena-es" => DeepgramSpeakProviderModel.Aura2SelenaEs,
                "aura-2-estrella-es" => DeepgramSpeakProviderModel.Aura2EstrellaEs,
                "aura-2-javier-es" => DeepgramSpeakProviderModel.Aura2JavierEs,
                _ => null,
            };
        }
    }
}