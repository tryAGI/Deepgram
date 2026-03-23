
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Default Value: aura-asteria-en
    /// </summary>
    public enum SpeakV1AudioGenerateModel
    {
        /// <summary>
        /// 
        /// </summary>
        Aura2AlvaroEs,
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
        Aura2AquilaEs,
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
        Aura2CarinaEs,
        /// <summary>
        /// 
        /// </summary>
        Aura2CelesteEs,
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
        Aura2DianaEs,
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
        Aura2EstrellaEs,
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
        Aura2JavierEs,
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
        Aura2NestorEs,
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
        Aura2SelenaEs,
        /// <summary>
        /// 
        /// </summary>
        Aura2SeleneEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2SirioEs,
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
        AuraAngusEn,
        /// <summary>
        /// 
        /// </summary>
        AuraArcasEn,
        /// <summary>
        /// 
        /// </summary>
        AuraAsteriaEn,
        /// <summary>
        /// 
        /// </summary>
        AuraAthenaEn,
        /// <summary>
        /// 
        /// </summary>
        AuraHeliosEn,
        /// <summary>
        /// 
        /// </summary>
        AuraHeraEn,
        /// <summary>
        /// 
        /// </summary>
        AuraLunaEn,
        /// <summary>
        /// 
        /// </summary>
        AuraOrionEn,
        /// <summary>
        /// 
        /// </summary>
        AuraOrpheusEn,
        /// <summary>
        /// 
        /// </summary>
        AuraPerseusEn,
        /// <summary>
        /// 
        /// </summary>
        AuraStellaEn,
        /// <summary>
        /// 
        /// </summary>
        AuraZeusEn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1AudioGenerateModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1AudioGenerateModel value)
        {
            return value switch
            {
                SpeakV1AudioGenerateModel.Aura2AlvaroEs => "aura-2-alvaro-es",
                SpeakV1AudioGenerateModel.Aura2AmaltheaEn => "aura-2-amalthea-en",
                SpeakV1AudioGenerateModel.Aura2AndromedaEn => "aura-2-andromeda-en",
                SpeakV1AudioGenerateModel.Aura2ApolloEn => "aura-2-apollo-en",
                SpeakV1AudioGenerateModel.Aura2AquilaEs => "aura-2-aquila-es",
                SpeakV1AudioGenerateModel.Aura2ArcasEn => "aura-2-arcas-en",
                SpeakV1AudioGenerateModel.Aura2AriesEn => "aura-2-aries-en",
                SpeakV1AudioGenerateModel.Aura2AsteriaEn => "aura-2-asteria-en",
                SpeakV1AudioGenerateModel.Aura2AthenaEn => "aura-2-athena-en",
                SpeakV1AudioGenerateModel.Aura2AtlasEn => "aura-2-atlas-en",
                SpeakV1AudioGenerateModel.Aura2AuroraEn => "aura-2-aurora-en",
                SpeakV1AudioGenerateModel.Aura2CallistaEn => "aura-2-callista-en",
                SpeakV1AudioGenerateModel.Aura2CarinaEs => "aura-2-carina-es",
                SpeakV1AudioGenerateModel.Aura2CelesteEs => "aura-2-celeste-es",
                SpeakV1AudioGenerateModel.Aura2CoraEn => "aura-2-cora-en",
                SpeakV1AudioGenerateModel.Aura2CordeliaEn => "aura-2-cordelia-en",
                SpeakV1AudioGenerateModel.Aura2DeliaEn => "aura-2-delia-en",
                SpeakV1AudioGenerateModel.Aura2DianaEs => "aura-2-diana-es",
                SpeakV1AudioGenerateModel.Aura2DracoEn => "aura-2-draco-en",
                SpeakV1AudioGenerateModel.Aura2ElectraEn => "aura-2-electra-en",
                SpeakV1AudioGenerateModel.Aura2EstrellaEs => "aura-2-estrella-es",
                SpeakV1AudioGenerateModel.Aura2HarmoniaEn => "aura-2-harmonia-en",
                SpeakV1AudioGenerateModel.Aura2HelenaEn => "aura-2-helena-en",
                SpeakV1AudioGenerateModel.Aura2HeraEn => "aura-2-hera-en",
                SpeakV1AudioGenerateModel.Aura2HermesEn => "aura-2-hermes-en",
                SpeakV1AudioGenerateModel.Aura2HyperionEn => "aura-2-hyperion-en",
                SpeakV1AudioGenerateModel.Aura2IrisEn => "aura-2-iris-en",
                SpeakV1AudioGenerateModel.Aura2JanusEn => "aura-2-janus-en",
                SpeakV1AudioGenerateModel.Aura2JavierEs => "aura-2-javier-es",
                SpeakV1AudioGenerateModel.Aura2JunoEn => "aura-2-juno-en",
                SpeakV1AudioGenerateModel.Aura2JupiterEn => "aura-2-jupiter-en",
                SpeakV1AudioGenerateModel.Aura2LunaEn => "aura-2-luna-en",
                SpeakV1AudioGenerateModel.Aura2MarsEn => "aura-2-mars-en",
                SpeakV1AudioGenerateModel.Aura2MinervaEn => "aura-2-minerva-en",
                SpeakV1AudioGenerateModel.Aura2NeptuneEn => "aura-2-neptune-en",
                SpeakV1AudioGenerateModel.Aura2NestorEs => "aura-2-nestor-es",
                SpeakV1AudioGenerateModel.Aura2OdysseusEn => "aura-2-odysseus-en",
                SpeakV1AudioGenerateModel.Aura2OpheliaEn => "aura-2-ophelia-en",
                SpeakV1AudioGenerateModel.Aura2OrionEn => "aura-2-orion-en",
                SpeakV1AudioGenerateModel.Aura2OrpheusEn => "aura-2-orpheus-en",
                SpeakV1AudioGenerateModel.Aura2PandoraEn => "aura-2-pandora-en",
                SpeakV1AudioGenerateModel.Aura2PhoebeEn => "aura-2-phoebe-en",
                SpeakV1AudioGenerateModel.Aura2PlutoEn => "aura-2-pluto-en",
                SpeakV1AudioGenerateModel.Aura2SaturnEn => "aura-2-saturn-en",
                SpeakV1AudioGenerateModel.Aura2SelenaEs => "aura-2-selena-es",
                SpeakV1AudioGenerateModel.Aura2SeleneEn => "aura-2-selene-en",
                SpeakV1AudioGenerateModel.Aura2SirioEs => "aura-2-sirio-es",
                SpeakV1AudioGenerateModel.Aura2ThaliaEn => "aura-2-thalia-en",
                SpeakV1AudioGenerateModel.Aura2TheiaEn => "aura-2-theia-en",
                SpeakV1AudioGenerateModel.Aura2VestaEn => "aura-2-vesta-en",
                SpeakV1AudioGenerateModel.Aura2ZeusEn => "aura-2-zeus-en",
                SpeakV1AudioGenerateModel.AuraAngusEn => "aura-angus-en",
                SpeakV1AudioGenerateModel.AuraArcasEn => "aura-arcas-en",
                SpeakV1AudioGenerateModel.AuraAsteriaEn => "aura-asteria-en",
                SpeakV1AudioGenerateModel.AuraAthenaEn => "aura-athena-en",
                SpeakV1AudioGenerateModel.AuraHeliosEn => "aura-helios-en",
                SpeakV1AudioGenerateModel.AuraHeraEn => "aura-hera-en",
                SpeakV1AudioGenerateModel.AuraLunaEn => "aura-luna-en",
                SpeakV1AudioGenerateModel.AuraOrionEn => "aura-orion-en",
                SpeakV1AudioGenerateModel.AuraOrpheusEn => "aura-orpheus-en",
                SpeakV1AudioGenerateModel.AuraPerseusEn => "aura-perseus-en",
                SpeakV1AudioGenerateModel.AuraStellaEn => "aura-stella-en",
                SpeakV1AudioGenerateModel.AuraZeusEn => "aura-zeus-en",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1AudioGenerateModel? ToEnum(string value)
        {
            return value switch
            {
                "aura-2-alvaro-es" => SpeakV1AudioGenerateModel.Aura2AlvaroEs,
                "aura-2-amalthea-en" => SpeakV1AudioGenerateModel.Aura2AmaltheaEn,
                "aura-2-andromeda-en" => SpeakV1AudioGenerateModel.Aura2AndromedaEn,
                "aura-2-apollo-en" => SpeakV1AudioGenerateModel.Aura2ApolloEn,
                "aura-2-aquila-es" => SpeakV1AudioGenerateModel.Aura2AquilaEs,
                "aura-2-arcas-en" => SpeakV1AudioGenerateModel.Aura2ArcasEn,
                "aura-2-aries-en" => SpeakV1AudioGenerateModel.Aura2AriesEn,
                "aura-2-asteria-en" => SpeakV1AudioGenerateModel.Aura2AsteriaEn,
                "aura-2-athena-en" => SpeakV1AudioGenerateModel.Aura2AthenaEn,
                "aura-2-atlas-en" => SpeakV1AudioGenerateModel.Aura2AtlasEn,
                "aura-2-aurora-en" => SpeakV1AudioGenerateModel.Aura2AuroraEn,
                "aura-2-callista-en" => SpeakV1AudioGenerateModel.Aura2CallistaEn,
                "aura-2-carina-es" => SpeakV1AudioGenerateModel.Aura2CarinaEs,
                "aura-2-celeste-es" => SpeakV1AudioGenerateModel.Aura2CelesteEs,
                "aura-2-cora-en" => SpeakV1AudioGenerateModel.Aura2CoraEn,
                "aura-2-cordelia-en" => SpeakV1AudioGenerateModel.Aura2CordeliaEn,
                "aura-2-delia-en" => SpeakV1AudioGenerateModel.Aura2DeliaEn,
                "aura-2-diana-es" => SpeakV1AudioGenerateModel.Aura2DianaEs,
                "aura-2-draco-en" => SpeakV1AudioGenerateModel.Aura2DracoEn,
                "aura-2-electra-en" => SpeakV1AudioGenerateModel.Aura2ElectraEn,
                "aura-2-estrella-es" => SpeakV1AudioGenerateModel.Aura2EstrellaEs,
                "aura-2-harmonia-en" => SpeakV1AudioGenerateModel.Aura2HarmoniaEn,
                "aura-2-helena-en" => SpeakV1AudioGenerateModel.Aura2HelenaEn,
                "aura-2-hera-en" => SpeakV1AudioGenerateModel.Aura2HeraEn,
                "aura-2-hermes-en" => SpeakV1AudioGenerateModel.Aura2HermesEn,
                "aura-2-hyperion-en" => SpeakV1AudioGenerateModel.Aura2HyperionEn,
                "aura-2-iris-en" => SpeakV1AudioGenerateModel.Aura2IrisEn,
                "aura-2-janus-en" => SpeakV1AudioGenerateModel.Aura2JanusEn,
                "aura-2-javier-es" => SpeakV1AudioGenerateModel.Aura2JavierEs,
                "aura-2-juno-en" => SpeakV1AudioGenerateModel.Aura2JunoEn,
                "aura-2-jupiter-en" => SpeakV1AudioGenerateModel.Aura2JupiterEn,
                "aura-2-luna-en" => SpeakV1AudioGenerateModel.Aura2LunaEn,
                "aura-2-mars-en" => SpeakV1AudioGenerateModel.Aura2MarsEn,
                "aura-2-minerva-en" => SpeakV1AudioGenerateModel.Aura2MinervaEn,
                "aura-2-neptune-en" => SpeakV1AudioGenerateModel.Aura2NeptuneEn,
                "aura-2-nestor-es" => SpeakV1AudioGenerateModel.Aura2NestorEs,
                "aura-2-odysseus-en" => SpeakV1AudioGenerateModel.Aura2OdysseusEn,
                "aura-2-ophelia-en" => SpeakV1AudioGenerateModel.Aura2OpheliaEn,
                "aura-2-orion-en" => SpeakV1AudioGenerateModel.Aura2OrionEn,
                "aura-2-orpheus-en" => SpeakV1AudioGenerateModel.Aura2OrpheusEn,
                "aura-2-pandora-en" => SpeakV1AudioGenerateModel.Aura2PandoraEn,
                "aura-2-phoebe-en" => SpeakV1AudioGenerateModel.Aura2PhoebeEn,
                "aura-2-pluto-en" => SpeakV1AudioGenerateModel.Aura2PlutoEn,
                "aura-2-saturn-en" => SpeakV1AudioGenerateModel.Aura2SaturnEn,
                "aura-2-selena-es" => SpeakV1AudioGenerateModel.Aura2SelenaEs,
                "aura-2-selene-en" => SpeakV1AudioGenerateModel.Aura2SeleneEn,
                "aura-2-sirio-es" => SpeakV1AudioGenerateModel.Aura2SirioEs,
                "aura-2-thalia-en" => SpeakV1AudioGenerateModel.Aura2ThaliaEn,
                "aura-2-theia-en" => SpeakV1AudioGenerateModel.Aura2TheiaEn,
                "aura-2-vesta-en" => SpeakV1AudioGenerateModel.Aura2VestaEn,
                "aura-2-zeus-en" => SpeakV1AudioGenerateModel.Aura2ZeusEn,
                "aura-angus-en" => SpeakV1AudioGenerateModel.AuraAngusEn,
                "aura-arcas-en" => SpeakV1AudioGenerateModel.AuraArcasEn,
                "aura-asteria-en" => SpeakV1AudioGenerateModel.AuraAsteriaEn,
                "aura-athena-en" => SpeakV1AudioGenerateModel.AuraAthenaEn,
                "aura-helios-en" => SpeakV1AudioGenerateModel.AuraHeliosEn,
                "aura-hera-en" => SpeakV1AudioGenerateModel.AuraHeraEn,
                "aura-luna-en" => SpeakV1AudioGenerateModel.AuraLunaEn,
                "aura-orion-en" => SpeakV1AudioGenerateModel.AuraOrionEn,
                "aura-orpheus-en" => SpeakV1AudioGenerateModel.AuraOrpheusEn,
                "aura-perseus-en" => SpeakV1AudioGenerateModel.AuraPerseusEn,
                "aura-stella-en" => SpeakV1AudioGenerateModel.AuraStellaEn,
                "aura-zeus-en" => SpeakV1AudioGenerateModel.AuraZeusEn,
                _ => null,
            };
        }
    }
}