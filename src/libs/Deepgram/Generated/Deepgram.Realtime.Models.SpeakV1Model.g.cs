
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// AI model used to process submitted text<br/>
    /// Default Value: aura-asteria-en
    /// </summary>
    public enum SpeakV1Model
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
        Aura2CordeliaEn,
        /// <summary>
        /// 
        /// </summary>
        Aura2CoraEn,
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
    public static class SpeakV1ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1Model value)
        {
            return value switch
            {
                SpeakV1Model.AuraAsteriaEn => "aura-asteria-en",
                SpeakV1Model.AuraLunaEn => "aura-luna-en",
                SpeakV1Model.AuraStellaEn => "aura-stella-en",
                SpeakV1Model.AuraAthenaEn => "aura-athena-en",
                SpeakV1Model.AuraHeraEn => "aura-hera-en",
                SpeakV1Model.AuraOrionEn => "aura-orion-en",
                SpeakV1Model.AuraArcasEn => "aura-arcas-en",
                SpeakV1Model.AuraPerseusEn => "aura-perseus-en",
                SpeakV1Model.AuraAngusEn => "aura-angus-en",
                SpeakV1Model.AuraOrpheusEn => "aura-orpheus-en",
                SpeakV1Model.AuraHeliosEn => "aura-helios-en",
                SpeakV1Model.AuraZeusEn => "aura-zeus-en",
                SpeakV1Model.Aura2AmaltheaEn => "aura-2-amalthea-en",
                SpeakV1Model.Aura2AndromedaEn => "aura-2-andromeda-en",
                SpeakV1Model.Aura2ApolloEn => "aura-2-apollo-en",
                SpeakV1Model.Aura2ArcasEn => "aura-2-arcas-en",
                SpeakV1Model.Aura2AriesEn => "aura-2-aries-en",
                SpeakV1Model.Aura2AsteriaEn => "aura-2-asteria-en",
                SpeakV1Model.Aura2AthenaEn => "aura-2-athena-en",
                SpeakV1Model.Aura2AtlasEn => "aura-2-atlas-en",
                SpeakV1Model.Aura2AuroraEn => "aura-2-aurora-en",
                SpeakV1Model.Aura2CallistaEn => "aura-2-callista-en",
                SpeakV1Model.Aura2CordeliaEn => "aura-2-cordelia-en",
                SpeakV1Model.Aura2CoraEn => "aura-2-cora-en",
                SpeakV1Model.Aura2DeliaEn => "aura-2-delia-en",
                SpeakV1Model.Aura2DracoEn => "aura-2-draco-en",
                SpeakV1Model.Aura2ElectraEn => "aura-2-electra-en",
                SpeakV1Model.Aura2HarmoniaEn => "aura-2-harmonia-en",
                SpeakV1Model.Aura2HelenaEn => "aura-2-helena-en",
                SpeakV1Model.Aura2HeraEn => "aura-2-hera-en",
                SpeakV1Model.Aura2HermesEn => "aura-2-hermes-en",
                SpeakV1Model.Aura2HyperionEn => "aura-2-hyperion-en",
                SpeakV1Model.Aura2IrisEn => "aura-2-iris-en",
                SpeakV1Model.Aura2JanusEn => "aura-2-janus-en",
                SpeakV1Model.Aura2JunoEn => "aura-2-juno-en",
                SpeakV1Model.Aura2JupiterEn => "aura-2-jupiter-en",
                SpeakV1Model.Aura2LunaEn => "aura-2-luna-en",
                SpeakV1Model.Aura2MarsEn => "aura-2-mars-en",
                SpeakV1Model.Aura2MinervaEn => "aura-2-minerva-en",
                SpeakV1Model.Aura2NeptuneEn => "aura-2-neptune-en",
                SpeakV1Model.Aura2OdysseusEn => "aura-2-odysseus-en",
                SpeakV1Model.Aura2OpheliaEn => "aura-2-ophelia-en",
                SpeakV1Model.Aura2OrionEn => "aura-2-orion-en",
                SpeakV1Model.Aura2OrpheusEn => "aura-2-orpheus-en",
                SpeakV1Model.Aura2PandoraEn => "aura-2-pandora-en",
                SpeakV1Model.Aura2PhoebeEn => "aura-2-phoebe-en",
                SpeakV1Model.Aura2PlutoEn => "aura-2-pluto-en",
                SpeakV1Model.Aura2SaturnEn => "aura-2-saturn-en",
                SpeakV1Model.Aura2SeleneEn => "aura-2-selene-en",
                SpeakV1Model.Aura2ThaliaEn => "aura-2-thalia-en",
                SpeakV1Model.Aura2TheiaEn => "aura-2-theia-en",
                SpeakV1Model.Aura2VestaEn => "aura-2-vesta-en",
                SpeakV1Model.Aura2ZeusEn => "aura-2-zeus-en",
                SpeakV1Model.Aura2SirioEs => "aura-2-sirio-es",
                SpeakV1Model.Aura2NestorEs => "aura-2-nestor-es",
                SpeakV1Model.Aura2CarinaEs => "aura-2-carina-es",
                SpeakV1Model.Aura2CelesteEs => "aura-2-celeste-es",
                SpeakV1Model.Aura2AlvaroEs => "aura-2-alvaro-es",
                SpeakV1Model.Aura2DianaEs => "aura-2-diana-es",
                SpeakV1Model.Aura2AquilaEs => "aura-2-aquila-es",
                SpeakV1Model.Aura2SelenaEs => "aura-2-selena-es",
                SpeakV1Model.Aura2EstrellaEs => "aura-2-estrella-es",
                SpeakV1Model.Aura2JavierEs => "aura-2-javier-es",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1Model? ToEnum(string value)
        {
            return value switch
            {
                "aura-asteria-en" => SpeakV1Model.AuraAsteriaEn,
                "aura-luna-en" => SpeakV1Model.AuraLunaEn,
                "aura-stella-en" => SpeakV1Model.AuraStellaEn,
                "aura-athena-en" => SpeakV1Model.AuraAthenaEn,
                "aura-hera-en" => SpeakV1Model.AuraHeraEn,
                "aura-orion-en" => SpeakV1Model.AuraOrionEn,
                "aura-arcas-en" => SpeakV1Model.AuraArcasEn,
                "aura-perseus-en" => SpeakV1Model.AuraPerseusEn,
                "aura-angus-en" => SpeakV1Model.AuraAngusEn,
                "aura-orpheus-en" => SpeakV1Model.AuraOrpheusEn,
                "aura-helios-en" => SpeakV1Model.AuraHeliosEn,
                "aura-zeus-en" => SpeakV1Model.AuraZeusEn,
                "aura-2-amalthea-en" => SpeakV1Model.Aura2AmaltheaEn,
                "aura-2-andromeda-en" => SpeakV1Model.Aura2AndromedaEn,
                "aura-2-apollo-en" => SpeakV1Model.Aura2ApolloEn,
                "aura-2-arcas-en" => SpeakV1Model.Aura2ArcasEn,
                "aura-2-aries-en" => SpeakV1Model.Aura2AriesEn,
                "aura-2-asteria-en" => SpeakV1Model.Aura2AsteriaEn,
                "aura-2-athena-en" => SpeakV1Model.Aura2AthenaEn,
                "aura-2-atlas-en" => SpeakV1Model.Aura2AtlasEn,
                "aura-2-aurora-en" => SpeakV1Model.Aura2AuroraEn,
                "aura-2-callista-en" => SpeakV1Model.Aura2CallistaEn,
                "aura-2-cordelia-en" => SpeakV1Model.Aura2CordeliaEn,
                "aura-2-cora-en" => SpeakV1Model.Aura2CoraEn,
                "aura-2-delia-en" => SpeakV1Model.Aura2DeliaEn,
                "aura-2-draco-en" => SpeakV1Model.Aura2DracoEn,
                "aura-2-electra-en" => SpeakV1Model.Aura2ElectraEn,
                "aura-2-harmonia-en" => SpeakV1Model.Aura2HarmoniaEn,
                "aura-2-helena-en" => SpeakV1Model.Aura2HelenaEn,
                "aura-2-hera-en" => SpeakV1Model.Aura2HeraEn,
                "aura-2-hermes-en" => SpeakV1Model.Aura2HermesEn,
                "aura-2-hyperion-en" => SpeakV1Model.Aura2HyperionEn,
                "aura-2-iris-en" => SpeakV1Model.Aura2IrisEn,
                "aura-2-janus-en" => SpeakV1Model.Aura2JanusEn,
                "aura-2-juno-en" => SpeakV1Model.Aura2JunoEn,
                "aura-2-jupiter-en" => SpeakV1Model.Aura2JupiterEn,
                "aura-2-luna-en" => SpeakV1Model.Aura2LunaEn,
                "aura-2-mars-en" => SpeakV1Model.Aura2MarsEn,
                "aura-2-minerva-en" => SpeakV1Model.Aura2MinervaEn,
                "aura-2-neptune-en" => SpeakV1Model.Aura2NeptuneEn,
                "aura-2-odysseus-en" => SpeakV1Model.Aura2OdysseusEn,
                "aura-2-ophelia-en" => SpeakV1Model.Aura2OpheliaEn,
                "aura-2-orion-en" => SpeakV1Model.Aura2OrionEn,
                "aura-2-orpheus-en" => SpeakV1Model.Aura2OrpheusEn,
                "aura-2-pandora-en" => SpeakV1Model.Aura2PandoraEn,
                "aura-2-phoebe-en" => SpeakV1Model.Aura2PhoebeEn,
                "aura-2-pluto-en" => SpeakV1Model.Aura2PlutoEn,
                "aura-2-saturn-en" => SpeakV1Model.Aura2SaturnEn,
                "aura-2-selene-en" => SpeakV1Model.Aura2SeleneEn,
                "aura-2-thalia-en" => SpeakV1Model.Aura2ThaliaEn,
                "aura-2-theia-en" => SpeakV1Model.Aura2TheiaEn,
                "aura-2-vesta-en" => SpeakV1Model.Aura2VestaEn,
                "aura-2-zeus-en" => SpeakV1Model.Aura2ZeusEn,
                "aura-2-sirio-es" => SpeakV1Model.Aura2SirioEs,
                "aura-2-nestor-es" => SpeakV1Model.Aura2NestorEs,
                "aura-2-carina-es" => SpeakV1Model.Aura2CarinaEs,
                "aura-2-celeste-es" => SpeakV1Model.Aura2CelesteEs,
                "aura-2-alvaro-es" => SpeakV1Model.Aura2AlvaroEs,
                "aura-2-diana-es" => SpeakV1Model.Aura2DianaEs,
                "aura-2-aquila-es" => SpeakV1Model.Aura2AquilaEs,
                "aura-2-selena-es" => SpeakV1Model.Aura2SelenaEs,
                "aura-2-estrella-es" => SpeakV1Model.Aura2EstrellaEs,
                "aura-2-javier-es" => SpeakV1Model.Aura2JavierEs,
                _ => null,
            };
        }
    }
}