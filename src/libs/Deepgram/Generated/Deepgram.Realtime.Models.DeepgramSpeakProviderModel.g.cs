
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Deepgram TTS model. Aura models (version v1) use the aura-* voices; Flux TTS (version v2) uses the flux-{voice}-{language} voices (e.g. flux-alexis-en). Defaults to flux-kit-en when agent.speak is omitted.
    /// </summary>
    public enum DeepgramSpeakProviderModel
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
        /// <summary>
        ///
        /// </summary>
        FluxAfsanaBn,
        /// <summary>
        ///
        /// </summary>
        FluxAgneseLv,
        /// <summary>
        ///
        /// </summary>
        FluxAinaEs,
        /// <summary>
        ///
        /// </summary>
        FluxAjayHi,
        /// <summary>
        ///
        /// </summary>
        FluxAlexisEn,
        /// <summary>
        ///
        /// </summary>
        FluxAlfredoEs,
        /// <summary>
        ///
        /// </summary>
        FluxAmbreenUr,
        /// <summary>
        ///
        /// </summary>
        FluxAndreiRu,
        /// <summary>
        ///
        /// </summary>
        FluxAngelaIt,
        /// <summary>
        ///
        /// </summary>
        FluxAnjaliHi,
        /// <summary>
        ///
        /// </summary>
        FluxAnoukNl,
        /// <summary>
        ///
        /// </summary>
        FluxArjunHi,
        /// <summary>
        ///
        /// </summary>
        FluxArnaudFr,
        /// <summary>
        ///
        /// </summary>
        FluxArturPt,
        /// <summary>
        ///
        /// </summary>
        FluxAxelSv,
        /// <summary>
        ///
        /// </summary>
        FluxAyumiJa,
        /// <summary>
        ///
        /// </summary>
        FluxBartoszPl,
        /// <summary>
        ///
        /// </summary>
        FluxBenceHu,
        /// <summary>
        ///
        /// </summary>
        FluxBeneditaPt,
        /// <summary>
        ///
        /// </summary>
        FluxBenjaminDe,
        /// <summary>
        ///
        /// </summary>
        FluxBenoitFr,
        /// <summary>
        ///
        /// </summary>
        FluxBhavnaGu,
        /// <summary>
        ///
        /// </summary>
        FluxBiancaPt,
        /// <summary>
        ///
        /// </summary>
        FluxBoZh,
        /// <summary>
        ///
        /// </summary>
        FluxBramNl,
        /// <summary>
        ///
        /// </summary>
        FluxBreeEn,
        /// <summary>
        ///
        /// </summary>
        FluxBrigitteFr,
        /// <summary>
        ///
        /// </summary>
        FluxBrittanyEn,
        /// <summary>
        ///
        /// </summary>
        FluxBrookeEn,
        /// <summary>
        ///
        /// </summary>
        FluxBruceEn,
        /// <summary>
        ///
        /// </summary>
        FluxBrunoPt,
        /// <summary>
        ///
        /// </summary>
        FluxCamilleFr,
        /// <summary>
        ///
        /// </summary>
        FluxCarmenEs,
        /// <summary>
        ///
        /// </summary>
        FluxCatarinaPt,
        /// <summary>
        ///
        /// </summary>
        FluxCeciliaEs,
        /// <summary>
        ///
        /// </summary>
        FluxCharlottaSv,
        /// <summary>
        ///
        /// </summary>
        FluxChiaraIt,
        /// <summary>
        ///
        /// </summary>
        FluxChiayingZh,
        /// <summary>
        ///
        /// </summary>
        FluxChloeFr,
        /// <summary>
        ///
        /// </summary>
        FluxChristianDe,
        /// <summary>
        ///
        /// </summary>
        FluxClaudiaPt,
        /// <summary>
        ///
        /// </summary>
        FluxCliffEn,
        /// <summary>
        ///
        /// </summary>
        FluxColeEn,
        /// <summary>
        ///
        /// </summary>
        FluxColinEn,
        /// <summary>
        ///
        /// </summary>
        FluxConorEn,
        /// <summary>
        ///
        /// </summary>
        FluxCosminRo,
        /// <summary>
        ///
        /// </summary>
        FluxDaliborHr,
        /// <summary>
        ///
        /// </summary>
        FluxDanijelaHr,
        /// <summary>
        ///
        /// </summary>
        FluxDenysUk,
        /// <summary>
        ///
        /// </summary>
        FluxDesislavaBg,
        /// <summary>
        ///
        /// </summary>
        FluxDewiId,
        /// <summary>
        ///
        /// </summary>
        FluxDilekTr,
        /// <summary>
        ///
        /// </summary>
        FluxDirkNl,
        /// <summary>
        ///
        /// </summary>
        FluxDivyaHi,
        /// <summary>
        ///
        /// </summary>
        FluxDomagojHr,
        /// <summary>
        ///
        /// </summary>
        FluxDominikaSk,
        /// <summary>
        ///
        /// </summary>
        FluxDonovanEn,
        /// <summary>
        ///
        /// </summary>
        FluxDrewEn,
        /// <summary>
        ///
        /// </summary>
        FluxDuvanEs,
        /// <summary>
        ///
        /// </summary>
        FluxEcemTr,
        /// <summary>
        ///
        /// </summary>
        FluxEdgarsLv,
        /// <summary>
        ///
        /// </summary>
        FluxEduardoEs,
        /// <summary>
        ///
        /// </summary>
        FluxEliseEn,
        /// <summary>
        ///
        /// </summary>
        FluxEmreTr,
        /// <summary>
        ///
        /// </summary>
        FluxErlendNo,
        /// <summary>
        ///
        /// </summary>
        FluxErnestoEs,
        /// <summary>
        ///
        /// </summary>
        FluxEspenNo,
        /// <summary>
        ///
        /// </summary>
        FluxEszterHu,
        /// <summary>
        ///
        /// </summary>
        FluxEunjiKo,
        /// <summary>
        ///
        /// </summary>
        FluxEwaPl,
        /// <summary>
        ///
        /// </summary>
        FluxFajarId,
        /// <summary>
        ///
        /// </summary>
        FluxFedericoIt,
        /// <summary>
        ///
        /// </summary>
        FluxFernandaEs,
        /// <summary>
        ///
        /// </summary>
        FluxFiorellaEs,
        /// <summary>
        ///
        /// </summary>
        FluxFitriId,
        /// <summary>
        ///
        /// </summary>
        FluxFleurNl,
        /// <summary>
        ///
        /// </summary>
        FluxFlorianFr,
        /// <summary>
        ///
        /// </summary>
        FluxFridaSv,
        /// <summary>
        ///
        /// </summary>
        FluxGemmaEn,
        /// <summary>
        ///
        /// </summary>
        FluxGerganaBg,
        /// <summary>
        ///
        /// </summary>
        FluxGiorgioIt,
        /// <summary>
        ///
        /// </summary>
        FluxGizemTr,
        /// <summary>
        ///
        /// </summary>
        FluxGodaLt,
        /// <summary>
        ///
        /// </summary>
        FluxGokulTa,
        /// <summary>
        ///
        /// </summary>
        FluxGregorSl,
        /// <summary>
        ///
        /// </summary>
        FluxGustavoEs,
        /// <summary>
        ///
        /// </summary>
        FluxHaleyEn,
        /// <summary>
        ///
        /// </summary>
        FluxHannahEn,
        /// <summary>
        ///
        /// </summary>
        FluxHaoranZh,
        /// <summary>
        ///
        /// </summary>
        FluxHayatoJa,
        /// <summary>
        ///
        /// </summary>
        FluxHaziqMs,
        /// <summary>
        ///
        /// </summary>
        FluxHeatherEn,
        /// <summary>
        ///
        /// </summary>
        FluxHetalGu,
        /// <summary>
        ///
        /// </summary>
        FluxHoaVi,
        /// <summary>
        ///
        /// </summary>
        FluxHugoPt,
        /// <summary>
        ///
        /// </summary>
        FluxHyunwooKo,
        /// <summary>
        ///
        /// </summary>
        FluxIdaNo,
        /// <summary>
        ///
        /// </summary>
        FluxIoanaRo,
        /// <summary>
        ///
        /// </summary>
        FluxIreneNl,
        /// <summary>
        ///
        /// </summary>
        FluxIshratBn,
        /// <summary>
        ///
        /// </summary>
        FluxIzzahMs,
        /// <summary>
        ///
        /// </summary>
        FluxJackEn,
        /// <summary>
        ///
        /// </summary>
        FluxJaimeEs,
        /// <summary>
        ///
        /// </summary>
        FluxJakubCs,
        /// <summary>
        ///
        /// </summary>
        FluxJanineDe,
        /// <summary>
        ///
        /// </summary>
        FluxJasnaHr,
        /// <summary>
        ///
        /// </summary>
        FluxJeromeTl,
        /// <summary>
        ///
        /// </summary>
        FluxJianZh,
        /// <summary>
        ///
        /// </summary>
        FluxJieZh,
        /// <summary>
        ///
        /// </summary>
        FluxJigneshGu,
        /// <summary>
        ///
        /// </summary>
        FluxJomarTl,
        /// <summary>
        ///
        /// </summary>
        FluxJordiCa,
        /// <summary>
        ///
        /// </summary>
        FluxJosipaHr,
        /// <summary>
        ///
        /// </summary>
        FluxJuditCa,
        /// <summary>
        ///
        /// </summary>
        FluxJulienFr,
        /// <summary>
        ///
        /// </summary>
        FluxJurajSk,
        /// <summary>
        ///
        /// </summary>
        FluxJustynaPl,
        /// <summary>
        ///
        /// </summary>
        FluxJyotiHi,
        /// <summary>
        ///
        /// </summary>
        FluxKacperPl,
        /// <summary>
        ///
        /// </summary>
        FluxKaiEn,
        /// <summary>
        ///
        /// </summary>
        FluxKatjaSl,
        /// <summary>
        ///
        /// </summary>
        FluxKavyaTa,
        /// <summary>
        ///
        /// </summary>
        FluxKelseyEn,
        /// <summary>
        ///
        /// </summary>
        FluxKingaHu,
        /// <summary>
        ///
        /// </summary>
        FluxKirillRu,
        /// <summary>
        ///
        /// </summary>
        FluxKirsiFi,
        /// <summary>
        ///
        /// </summary>
        FluxKitEn,
        /// <summary>
        ///
        /// </summary>
        FluxKonradPl,
        /// <summary>
        ///
        /// </summary>
        FluxKostasEl,
        /// <summary>
        ///
        /// </summary>
        FluxKuanyuZh,
        /// <summary>
        ///
        /// </summary>
        FluxLeandroPt,
        /// <summary>
        ///
        /// </summary>
        FluxLeonieDe,
        /// <summary>
        ///
        /// </summary>
        FluxLiezelTl,
        /// <summary>
        ///
        /// </summary>
        FluxLijuanZh,
        /// <summary>
        ///
        /// </summary>
        FluxLotteNl,
        /// <summary>
        ///
        /// </summary>
        FluxLudvigSv,
        /// <summary>
        ///
        /// </summary>
        FluxLuukNl,
        /// <summary>
        ///
        /// </summary>
        FluxMaeveEn,
        /// <summary>
        ///
        /// </summary>
        FluxMagdalenaDe,
        /// <summary>
        ///
        /// </summary>
        FluxMamunBn,
        /// <summary>
        ///
        /// </summary>
        FluxManjunathKn,
        /// <summary>
        ///
        /// </summary>
        FluxManlokZh,
        /// <summary>
        ///
        /// </summary>
        FluxMarceloEn,
        /// <summary>
        ///
        /// </summary>
        FluxMarciaPt,
        /// <summary>
        ///
        /// </summary>
        FluxMarcusEn,
        /// <summary>
        ///
        /// </summary>
        FluxMarianaPt,
        /// <summary>
        ///
        /// </summary>
        FluxMartaPt,
        /// <summary>
        ///
        /// </summary>
        FluxMartinEs,
        /// <summary>
        ///
        /// </summary>
        FluxMateusPt,
        /// <summary>
        ///
        /// </summary>
        FluxMathieuFr,
        /// <summary>
        ///
        /// </summary>
        FluxMatteoIt,
        /// <summary>
        ///
        /// </summary>
        FluxMauricioEs,
        /// <summary>
        ///
        /// </summary>
        FluxMaximRu,
        /// <summary>
        ///
        /// </summary>
        FluxMeenaEn,
        /// <summary>
        ///
        /// </summary>
        FluxMeghanEn,
        /// <summary>
        ///
        /// </summary>
        FluxMehmetTr,
        /// <summary>
        ///
        /// </summary>
        FluxMiguelPt,
        /// <summary>
        ///
        /// </summary>
        FluxMihaelaHr,
        /// <summary>
        ///
        /// </summary>
        FluxMikhailRu,
        /// <summary>
        ///
        /// </summary>
        FluxMikyungKo,
        /// <summary>
        ///
        /// </summary>
        FluxMilesEn,
        /// <summary>
        ///
        /// </summary>
        FluxMinhVi,
        /// <summary>
        ///
        /// </summary>
        FluxMinjunKo,
        /// <summary>
        ///
        /// </summary>
        FluxMoniqueNl,
        /// <summary>
        ///
        /// </summary>
        FluxMoritzDe,
        /// <summary>
        ///
        /// </summary>
        FluxNadineDe,
        /// <summary>
        ///
        /// </summary>
        FluxNataliaRu,
        /// <summary>
        ///
        /// </summary>
        FluxNaveenEn,
        /// <summary>
        ///
        /// </summary>
        FluxNeringaLt,
        /// <summary>
        ///
        /// </summary>
        FluxNielsNl,
        /// <summary>
        ///
        /// </summary>
        FluxNikhilHi,
        /// <summary>
        ///
        /// </summary>
        FluxNikolaiRu,
        /// <summary>
        ///
        /// </summary>
        FluxNoelTl,
        /// <summary>
        ///
        /// </summary>
        FluxNozomiJa,
        /// <summary>
        ///
        /// </summary>
        FluxOlgaRu,
        /// <summary>
        ///
        /// </summary>
        FluxOskarSv,
        /// <summary>
        ///
        /// </summary>
        FluxPaigeEn,
        /// <summary>
        ///
        /// </summary>
        FluxPallaviHi,
        /// <summary>
        ///
        /// </summary>
        FluxPaolaIt,
        /// <summary>
        ///
        /// </summary>
        FluxPatriciaEs,
        /// <summary>
        ///
        /// </summary>
        FluxPavanTe,
        /// <summary>
        ///
        /// </summary>
        FluxPedroPt,
        /// <summary>
        ///
        /// </summary>
        FluxPernilleDa,
        /// <summary>
        ///
        /// </summary>
        FluxPierreFr,
        /// <summary>
        ///
        /// </summary>
        FluxPilarEs,
        /// <summary>
        ///
        /// </summary>
        FluxPolinaRu,
        /// <summary>
        ///
        /// </summary>
        FluxPontusSv,
        /// <summary>
        ///
        /// </summary>
        FluxPoojaMr,
        /// <summary>
        ///
        /// </summary>
        FluxPrachiHi,
        /// <summary>
        ///
        /// </summary>
        FluxPratikMr,
        /// <summary>
        ///
        /// </summary>
        FluxPriyaEn,
        /// <summary>
        ///
        /// </summary>
        FluxRafaelEs,
        /// <summary>
        ///
        /// </summary>
        FluxRahulHi,
        /// <summary>
        ///
        /// </summary>
        FluxRajeshHi,
        /// <summary>
        ///
        /// </summary>
        FluxRasmusDa,
        /// <summary>
        ///
        /// </summary>
        FluxRaviTe,
        /// <summary>
        ///
        /// </summary>
        FluxRenatoPt,
        /// <summary>
        ///
        /// </summary>
        FluxRicardoPt,
        /// <summary>
        ///
        /// </summary>
        FluxRikkeDa,
        /// <summary>
        ///
        /// </summary>
        FluxRituHi,
        /// <summary>
        ///
        /// </summary>
        FluxRizkyId,
        /// <summary>
        ///
        /// </summary>
        FluxRobertoPt,
        /// <summary>
        ///
        /// </summary>
        FluxRoccoIt,
        /// <summary>
        ///
        /// </summary>
        FluxRodrigoPt,
        /// <summary>
        ///
        /// </summary>
        FluxRolfDe,
        /// <summary>
        ///
        /// </summary>
        FluxRubenNl,
        /// <summary>
        ///
        /// </summary>
        FluxRufusEn,
        /// <summary>
        ///
        /// </summary>
        FluxSabbirBn,
        /// <summary>
        ///
        /// </summary>
        FluxSanneNl,
        /// <summary>
        ///
        /// </summary>
        FluxSayakaJa,
        /// <summary>
        ///
        /// </summary>
        FluxSeanEn,
        /// <summary>
        ///
        /// </summary>
        FluxSerkanTr,
        /// <summary>
        ///
        /// </summary>
        FluxSharonEn,
        /// <summary>
        ///
        /// </summary>
        FluxShreyaHi,
        /// <summary>
        ///
        /// </summary>
        FluxShufenZh,
        /// <summary>
        ///
        /// </summary>
        FluxShuvoBn,
        /// <summary>
        ///
        /// </summary>
        FluxSiennaEn,
        /// <summary>
        ///
        /// </summary>
        FluxSigneNo,
        /// <summary>
        ///
        /// </summary>
        FluxSiljeNo,
        /// <summary>
        ///
        /// </summary>
        FluxSnehaMr,
        /// <summary>
        ///
        /// </summary>
        FluxSofiaIt,
        /// <summary>
        ///
        /// </summary>
        FluxSolomiyaUk,
        /// <summary>
        ///
        /// </summary>
        FluxSonjaDe,
        /// <summary>
        ///
        /// </summary>
        FluxSoojinKo,
        /// <summary>
        ///
        /// </summary>
        FluxSowmyaTa,
        /// <summary>
        ///
        /// </summary>
        FluxSravaniTe,
        /// <summary>
        ///
        /// </summary>
        FluxStefanoIt,
        /// <summary>
        ///
        /// </summary>
        FluxSumaiyaBn,
        /// <summary>
        ///
        /// </summary>
        FluxSungminKo,
        /// <summary>
        ///
        /// </summary>
        FluxSunitaHi,
        /// <summary>
        ///
        /// </summary>
        FluxSvenDe,
        /// <summary>
        ///
        /// </summary>
        FluxTannerEn,
        /// <summary>
        ///
        /// </summary>
        FluxTeemuFi,
        /// <summary>
        ///
        /// </summary>
        FluxTeguhId,
        /// <summary>
        ///
        /// </summary>
        FluxThierryFr,
        /// <summary>
        ///
        /// </summary>
        FluxTiborHu,
        /// <summary>
        ///
        /// </summary>
        FluxTobiasDe,
        /// <summary>
        ///
        /// </summary>
        FluxTomasEs,
        /// <summary>
        ///
        /// </summary>
        FluxTriinEt,
        /// <summary>
        ///
        /// </summary>
        FluxTrishaTl,
        /// <summary>
        ///
        /// </summary>
        FluxUsmanUr,
        /// <summary>
        ///
        /// </summary>
        FluxValentinaEs,
        /// <summary>
        ///
        /// </summary>
        FluxVedranHr,
        /// <summary>
        ///
        /// </summary>
        FluxVeerleNl,
        /// <summary>
        ///
        /// </summary>
        FluxVegardNo,
        /// <summary>
        ///
        /// </summary>
        FluxVerenaDe,
        /// <summary>
        ///
        /// </summary>
        FluxVeroniqueFr,
        /// <summary>
        ///
        /// </summary>
        FluxVikramHi,
        /// <summary>
        ///
        /// </summary>
        FluxVincenzoIt,
        /// <summary>
        ///
        /// </summary>
        FluxVinothTa,
        /// <summary>
        ///
        /// </summary>
        FluxVitoIt,
        /// <summary>
        ///
        /// </summary>
        FluxVladimirRu,
        /// <summary>
        ///
        /// </summary>
        FluxWadeEn,
        /// <summary>
        ///
        /// </summary>
        FluxWenboZh,
        /// <summary>
        ///
        /// </summary>
        FluxWenjingZh,
        /// <summary>
        ///
        /// </summary>
        FluxWesEn,
        /// <summary>
        ///
        /// </summary>
        FluxWilmaSv,
        /// <summary>
        ///
        /// </summary>
        FluxYannickDe,
        /// <summary>
        ///
        /// </summary>
        FluxYasmineFr,
        /// <summary>
        ///
        /// </summary>
        FluxYawenZh,
        /// <summary>
        ///
        /// </summary>
        FluxYsabelEs,
        /// <summary>
        ///
        /// </summary>
        FluxYutingZh,
        /// <summary>
        ///
        /// </summary>
        FluxYvonneNl,
        /// <summary>
        ///
        /// </summary>
        FluxZeynepTr,
        /// <summary>
        ///
        /// </summary>
        FluxZhenZh,
        /// <summary>
        ///
        /// </summary>
        FluxZuzannaPl,
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
                DeepgramSpeakProviderModel.Aura2AlvaroEs => "aura-2-alvaro-es",
                DeepgramSpeakProviderModel.Aura2AmaltheaEn => "aura-2-amalthea-en",
                DeepgramSpeakProviderModel.Aura2AndromedaEn => "aura-2-andromeda-en",
                DeepgramSpeakProviderModel.Aura2ApolloEn => "aura-2-apollo-en",
                DeepgramSpeakProviderModel.Aura2AquilaEs => "aura-2-aquila-es",
                DeepgramSpeakProviderModel.Aura2ArcasEn => "aura-2-arcas-en",
                DeepgramSpeakProviderModel.Aura2AriesEn => "aura-2-aries-en",
                DeepgramSpeakProviderModel.Aura2AsteriaEn => "aura-2-asteria-en",
                DeepgramSpeakProviderModel.Aura2AthenaEn => "aura-2-athena-en",
                DeepgramSpeakProviderModel.Aura2AtlasEn => "aura-2-atlas-en",
                DeepgramSpeakProviderModel.Aura2AuroraEn => "aura-2-aurora-en",
                DeepgramSpeakProviderModel.Aura2CallistaEn => "aura-2-callista-en",
                DeepgramSpeakProviderModel.Aura2CarinaEs => "aura-2-carina-es",
                DeepgramSpeakProviderModel.Aura2CelesteEs => "aura-2-celeste-es",
                DeepgramSpeakProviderModel.Aura2CoraEn => "aura-2-cora-en",
                DeepgramSpeakProviderModel.Aura2CordeliaEn => "aura-2-cordelia-en",
                DeepgramSpeakProviderModel.Aura2DeliaEn => "aura-2-delia-en",
                DeepgramSpeakProviderModel.Aura2DianaEs => "aura-2-diana-es",
                DeepgramSpeakProviderModel.Aura2DracoEn => "aura-2-draco-en",
                DeepgramSpeakProviderModel.Aura2ElectraEn => "aura-2-electra-en",
                DeepgramSpeakProviderModel.Aura2EstrellaEs => "aura-2-estrella-es",
                DeepgramSpeakProviderModel.Aura2HarmoniaEn => "aura-2-harmonia-en",
                DeepgramSpeakProviderModel.Aura2HelenaEn => "aura-2-helena-en",
                DeepgramSpeakProviderModel.Aura2HeraEn => "aura-2-hera-en",
                DeepgramSpeakProviderModel.Aura2HermesEn => "aura-2-hermes-en",
                DeepgramSpeakProviderModel.Aura2HyperionEn => "aura-2-hyperion-en",
                DeepgramSpeakProviderModel.Aura2IrisEn => "aura-2-iris-en",
                DeepgramSpeakProviderModel.Aura2JanusEn => "aura-2-janus-en",
                DeepgramSpeakProviderModel.Aura2JavierEs => "aura-2-javier-es",
                DeepgramSpeakProviderModel.Aura2JunoEn => "aura-2-juno-en",
                DeepgramSpeakProviderModel.Aura2JupiterEn => "aura-2-jupiter-en",
                DeepgramSpeakProviderModel.Aura2LunaEn => "aura-2-luna-en",
                DeepgramSpeakProviderModel.Aura2MarsEn => "aura-2-mars-en",
                DeepgramSpeakProviderModel.Aura2MinervaEn => "aura-2-minerva-en",
                DeepgramSpeakProviderModel.Aura2NeptuneEn => "aura-2-neptune-en",
                DeepgramSpeakProviderModel.Aura2NestorEs => "aura-2-nestor-es",
                DeepgramSpeakProviderModel.Aura2OdysseusEn => "aura-2-odysseus-en",
                DeepgramSpeakProviderModel.Aura2OpheliaEn => "aura-2-ophelia-en",
                DeepgramSpeakProviderModel.Aura2OrionEn => "aura-2-orion-en",
                DeepgramSpeakProviderModel.Aura2OrpheusEn => "aura-2-orpheus-en",
                DeepgramSpeakProviderModel.Aura2PandoraEn => "aura-2-pandora-en",
                DeepgramSpeakProviderModel.Aura2PhoebeEn => "aura-2-phoebe-en",
                DeepgramSpeakProviderModel.Aura2PlutoEn => "aura-2-pluto-en",
                DeepgramSpeakProviderModel.Aura2SaturnEn => "aura-2-saturn-en",
                DeepgramSpeakProviderModel.Aura2SelenaEs => "aura-2-selena-es",
                DeepgramSpeakProviderModel.Aura2SeleneEn => "aura-2-selene-en",
                DeepgramSpeakProviderModel.Aura2SirioEs => "aura-2-sirio-es",
                DeepgramSpeakProviderModel.Aura2ThaliaEn => "aura-2-thalia-en",
                DeepgramSpeakProviderModel.Aura2TheiaEn => "aura-2-theia-en",
                DeepgramSpeakProviderModel.Aura2VestaEn => "aura-2-vesta-en",
                DeepgramSpeakProviderModel.Aura2ZeusEn => "aura-2-zeus-en",
                DeepgramSpeakProviderModel.AuraAngusEn => "aura-angus-en",
                DeepgramSpeakProviderModel.AuraArcasEn => "aura-arcas-en",
                DeepgramSpeakProviderModel.AuraAsteriaEn => "aura-asteria-en",
                DeepgramSpeakProviderModel.AuraAthenaEn => "aura-athena-en",
                DeepgramSpeakProviderModel.AuraHeliosEn => "aura-helios-en",
                DeepgramSpeakProviderModel.AuraHeraEn => "aura-hera-en",
                DeepgramSpeakProviderModel.AuraLunaEn => "aura-luna-en",
                DeepgramSpeakProviderModel.AuraOrionEn => "aura-orion-en",
                DeepgramSpeakProviderModel.AuraOrpheusEn => "aura-orpheus-en",
                DeepgramSpeakProviderModel.AuraPerseusEn => "aura-perseus-en",
                DeepgramSpeakProviderModel.AuraStellaEn => "aura-stella-en",
                DeepgramSpeakProviderModel.AuraZeusEn => "aura-zeus-en",
                DeepgramSpeakProviderModel.FluxAfsanaBn => "flux-afsana-bn",
                DeepgramSpeakProviderModel.FluxAgneseLv => "flux-agnese-lv",
                DeepgramSpeakProviderModel.FluxAinaEs => "flux-aina-es",
                DeepgramSpeakProviderModel.FluxAjayHi => "flux-ajay-hi",
                DeepgramSpeakProviderModel.FluxAlexisEn => "flux-alexis-en",
                DeepgramSpeakProviderModel.FluxAlfredoEs => "flux-alfredo-es",
                DeepgramSpeakProviderModel.FluxAmbreenUr => "flux-ambreen-ur",
                DeepgramSpeakProviderModel.FluxAndreiRu => "flux-andrei-ru",
                DeepgramSpeakProviderModel.FluxAngelaIt => "flux-angela-it",
                DeepgramSpeakProviderModel.FluxAnjaliHi => "flux-anjali-hi",
                DeepgramSpeakProviderModel.FluxAnoukNl => "flux-anouk-nl",
                DeepgramSpeakProviderModel.FluxArjunHi => "flux-arjun-hi",
                DeepgramSpeakProviderModel.FluxArnaudFr => "flux-arnaud-fr",
                DeepgramSpeakProviderModel.FluxArturPt => "flux-artur-pt",
                DeepgramSpeakProviderModel.FluxAxelSv => "flux-axel-sv",
                DeepgramSpeakProviderModel.FluxAyumiJa => "flux-ayumi-ja",
                DeepgramSpeakProviderModel.FluxBartoszPl => "flux-bartosz-pl",
                DeepgramSpeakProviderModel.FluxBenceHu => "flux-bence-hu",
                DeepgramSpeakProviderModel.FluxBeneditaPt => "flux-benedita-pt",
                DeepgramSpeakProviderModel.FluxBenjaminDe => "flux-benjamin-de",
                DeepgramSpeakProviderModel.FluxBenoitFr => "flux-benoit-fr",
                DeepgramSpeakProviderModel.FluxBhavnaGu => "flux-bhavna-gu",
                DeepgramSpeakProviderModel.FluxBiancaPt => "flux-bianca-pt",
                DeepgramSpeakProviderModel.FluxBoZh => "flux-bo-zh",
                DeepgramSpeakProviderModel.FluxBramNl => "flux-bram-nl",
                DeepgramSpeakProviderModel.FluxBreeEn => "flux-bree-en",
                DeepgramSpeakProviderModel.FluxBrigitteFr => "flux-brigitte-fr",
                DeepgramSpeakProviderModel.FluxBrittanyEn => "flux-brittany-en",
                DeepgramSpeakProviderModel.FluxBrookeEn => "flux-brooke-en",
                DeepgramSpeakProviderModel.FluxBruceEn => "flux-bruce-en",
                DeepgramSpeakProviderModel.FluxBrunoPt => "flux-bruno-pt",
                DeepgramSpeakProviderModel.FluxCamilleFr => "flux-camille-fr",
                DeepgramSpeakProviderModel.FluxCarmenEs => "flux-carmen-es",
                DeepgramSpeakProviderModel.FluxCatarinaPt => "flux-catarina-pt",
                DeepgramSpeakProviderModel.FluxCeciliaEs => "flux-cecilia-es",
                DeepgramSpeakProviderModel.FluxCharlottaSv => "flux-charlotta-sv",
                DeepgramSpeakProviderModel.FluxChiaraIt => "flux-chiara-it",
                DeepgramSpeakProviderModel.FluxChiayingZh => "flux-chiaying-zh",
                DeepgramSpeakProviderModel.FluxChloeFr => "flux-chloe-fr",
                DeepgramSpeakProviderModel.FluxChristianDe => "flux-christian-de",
                DeepgramSpeakProviderModel.FluxClaudiaPt => "flux-claudia-pt",
                DeepgramSpeakProviderModel.FluxCliffEn => "flux-cliff-en",
                DeepgramSpeakProviderModel.FluxColeEn => "flux-cole-en",
                DeepgramSpeakProviderModel.FluxColinEn => "flux-colin-en",
                DeepgramSpeakProviderModel.FluxConorEn => "flux-conor-en",
                DeepgramSpeakProviderModel.FluxCosminRo => "flux-cosmin-ro",
                DeepgramSpeakProviderModel.FluxDaliborHr => "flux-dalibor-hr",
                DeepgramSpeakProviderModel.FluxDanijelaHr => "flux-danijela-hr",
                DeepgramSpeakProviderModel.FluxDenysUk => "flux-denys-uk",
                DeepgramSpeakProviderModel.FluxDesislavaBg => "flux-desislava-bg",
                DeepgramSpeakProviderModel.FluxDewiId => "flux-dewi-id",
                DeepgramSpeakProviderModel.FluxDilekTr => "flux-dilek-tr",
                DeepgramSpeakProviderModel.FluxDirkNl => "flux-dirk-nl",
                DeepgramSpeakProviderModel.FluxDivyaHi => "flux-divya-hi",
                DeepgramSpeakProviderModel.FluxDomagojHr => "flux-domagoj-hr",
                DeepgramSpeakProviderModel.FluxDominikaSk => "flux-dominika-sk",
                DeepgramSpeakProviderModel.FluxDonovanEn => "flux-donovan-en",
                DeepgramSpeakProviderModel.FluxDrewEn => "flux-drew-en",
                DeepgramSpeakProviderModel.FluxDuvanEs => "flux-duvan-es",
                DeepgramSpeakProviderModel.FluxEcemTr => "flux-ecem-tr",
                DeepgramSpeakProviderModel.FluxEdgarsLv => "flux-edgars-lv",
                DeepgramSpeakProviderModel.FluxEduardoEs => "flux-eduardo-es",
                DeepgramSpeakProviderModel.FluxEliseEn => "flux-elise-en",
                DeepgramSpeakProviderModel.FluxEmreTr => "flux-emre-tr",
                DeepgramSpeakProviderModel.FluxErlendNo => "flux-erlend-no",
                DeepgramSpeakProviderModel.FluxErnestoEs => "flux-ernesto-es",
                DeepgramSpeakProviderModel.FluxEspenNo => "flux-espen-no",
                DeepgramSpeakProviderModel.FluxEszterHu => "flux-eszter-hu",
                DeepgramSpeakProviderModel.FluxEunjiKo => "flux-eunji-ko",
                DeepgramSpeakProviderModel.FluxEwaPl => "flux-ewa-pl",
                DeepgramSpeakProviderModel.FluxFajarId => "flux-fajar-id",
                DeepgramSpeakProviderModel.FluxFedericoIt => "flux-federico-it",
                DeepgramSpeakProviderModel.FluxFernandaEs => "flux-fernanda-es",
                DeepgramSpeakProviderModel.FluxFiorellaEs => "flux-fiorella-es",
                DeepgramSpeakProviderModel.FluxFitriId => "flux-fitri-id",
                DeepgramSpeakProviderModel.FluxFleurNl => "flux-fleur-nl",
                DeepgramSpeakProviderModel.FluxFlorianFr => "flux-florian-fr",
                DeepgramSpeakProviderModel.FluxFridaSv => "flux-frida-sv",
                DeepgramSpeakProviderModel.FluxGemmaEn => "flux-gemma-en",
                DeepgramSpeakProviderModel.FluxGerganaBg => "flux-gergana-bg",
                DeepgramSpeakProviderModel.FluxGiorgioIt => "flux-giorgio-it",
                DeepgramSpeakProviderModel.FluxGizemTr => "flux-gizem-tr",
                DeepgramSpeakProviderModel.FluxGodaLt => "flux-goda-lt",
                DeepgramSpeakProviderModel.FluxGokulTa => "flux-gokul-ta",
                DeepgramSpeakProviderModel.FluxGregorSl => "flux-gregor-sl",
                DeepgramSpeakProviderModel.FluxGustavoEs => "flux-gustavo-es",
                DeepgramSpeakProviderModel.FluxHaleyEn => "flux-haley-en",
                DeepgramSpeakProviderModel.FluxHannahEn => "flux-hannah-en",
                DeepgramSpeakProviderModel.FluxHaoranZh => "flux-haoran-zh",
                DeepgramSpeakProviderModel.FluxHayatoJa => "flux-hayato-ja",
                DeepgramSpeakProviderModel.FluxHaziqMs => "flux-haziq-ms",
                DeepgramSpeakProviderModel.FluxHeatherEn => "flux-heather-en",
                DeepgramSpeakProviderModel.FluxHetalGu => "flux-hetal-gu",
                DeepgramSpeakProviderModel.FluxHoaVi => "flux-hoa-vi",
                DeepgramSpeakProviderModel.FluxHugoPt => "flux-hugo-pt",
                DeepgramSpeakProviderModel.FluxHyunwooKo => "flux-hyunwoo-ko",
                DeepgramSpeakProviderModel.FluxIdaNo => "flux-ida-no",
                DeepgramSpeakProviderModel.FluxIoanaRo => "flux-ioana-ro",
                DeepgramSpeakProviderModel.FluxIreneNl => "flux-irene-nl",
                DeepgramSpeakProviderModel.FluxIshratBn => "flux-ishrat-bn",
                DeepgramSpeakProviderModel.FluxIzzahMs => "flux-izzah-ms",
                DeepgramSpeakProviderModel.FluxJackEn => "flux-jack-en",
                DeepgramSpeakProviderModel.FluxJaimeEs => "flux-jaime-es",
                DeepgramSpeakProviderModel.FluxJakubCs => "flux-jakub-cs",
                DeepgramSpeakProviderModel.FluxJanineDe => "flux-janine-de",
                DeepgramSpeakProviderModel.FluxJasnaHr => "flux-jasna-hr",
                DeepgramSpeakProviderModel.FluxJeromeTl => "flux-jerome-tl",
                DeepgramSpeakProviderModel.FluxJianZh => "flux-jian-zh",
                DeepgramSpeakProviderModel.FluxJieZh => "flux-jie-zh",
                DeepgramSpeakProviderModel.FluxJigneshGu => "flux-jignesh-gu",
                DeepgramSpeakProviderModel.FluxJomarTl => "flux-jomar-tl",
                DeepgramSpeakProviderModel.FluxJordiCa => "flux-jordi-ca",
                DeepgramSpeakProviderModel.FluxJosipaHr => "flux-josipa-hr",
                DeepgramSpeakProviderModel.FluxJuditCa => "flux-judit-ca",
                DeepgramSpeakProviderModel.FluxJulienFr => "flux-julien-fr",
                DeepgramSpeakProviderModel.FluxJurajSk => "flux-juraj-sk",
                DeepgramSpeakProviderModel.FluxJustynaPl => "flux-justyna-pl",
                DeepgramSpeakProviderModel.FluxJyotiHi => "flux-jyoti-hi",
                DeepgramSpeakProviderModel.FluxKacperPl => "flux-kacper-pl",
                DeepgramSpeakProviderModel.FluxKaiEn => "flux-kai-en",
                DeepgramSpeakProviderModel.FluxKatjaSl => "flux-katja-sl",
                DeepgramSpeakProviderModel.FluxKavyaTa => "flux-kavya-ta",
                DeepgramSpeakProviderModel.FluxKelseyEn => "flux-kelsey-en",
                DeepgramSpeakProviderModel.FluxKingaHu => "flux-kinga-hu",
                DeepgramSpeakProviderModel.FluxKirillRu => "flux-kirill-ru",
                DeepgramSpeakProviderModel.FluxKirsiFi => "flux-kirsi-fi",
                DeepgramSpeakProviderModel.FluxKitEn => "flux-kit-en",
                DeepgramSpeakProviderModel.FluxKonradPl => "flux-konrad-pl",
                DeepgramSpeakProviderModel.FluxKostasEl => "flux-kostas-el",
                DeepgramSpeakProviderModel.FluxKuanyuZh => "flux-kuanyu-zh",
                DeepgramSpeakProviderModel.FluxLeandroPt => "flux-leandro-pt",
                DeepgramSpeakProviderModel.FluxLeonieDe => "flux-leonie-de",
                DeepgramSpeakProviderModel.FluxLiezelTl => "flux-liezel-tl",
                DeepgramSpeakProviderModel.FluxLijuanZh => "flux-lijuan-zh",
                DeepgramSpeakProviderModel.FluxLotteNl => "flux-lotte-nl",
                DeepgramSpeakProviderModel.FluxLudvigSv => "flux-ludvig-sv",
                DeepgramSpeakProviderModel.FluxLuukNl => "flux-luuk-nl",
                DeepgramSpeakProviderModel.FluxMaeveEn => "flux-maeve-en",
                DeepgramSpeakProviderModel.FluxMagdalenaDe => "flux-magdalena-de",
                DeepgramSpeakProviderModel.FluxMamunBn => "flux-mamun-bn",
                DeepgramSpeakProviderModel.FluxManjunathKn => "flux-manjunath-kn",
                DeepgramSpeakProviderModel.FluxManlokZh => "flux-manlok-zh",
                DeepgramSpeakProviderModel.FluxMarceloEn => "flux-marcelo-en",
                DeepgramSpeakProviderModel.FluxMarciaPt => "flux-marcia-pt",
                DeepgramSpeakProviderModel.FluxMarcusEn => "flux-marcus-en",
                DeepgramSpeakProviderModel.FluxMarianaPt => "flux-mariana-pt",
                DeepgramSpeakProviderModel.FluxMartaPt => "flux-marta-pt",
                DeepgramSpeakProviderModel.FluxMartinEs => "flux-martin-es",
                DeepgramSpeakProviderModel.FluxMateusPt => "flux-mateus-pt",
                DeepgramSpeakProviderModel.FluxMathieuFr => "flux-mathieu-fr",
                DeepgramSpeakProviderModel.FluxMatteoIt => "flux-matteo-it",
                DeepgramSpeakProviderModel.FluxMauricioEs => "flux-mauricio-es",
                DeepgramSpeakProviderModel.FluxMaximRu => "flux-maxim-ru",
                DeepgramSpeakProviderModel.FluxMeenaEn => "flux-meena-en",
                DeepgramSpeakProviderModel.FluxMeghanEn => "flux-meghan-en",
                DeepgramSpeakProviderModel.FluxMehmetTr => "flux-mehmet-tr",
                DeepgramSpeakProviderModel.FluxMiguelPt => "flux-miguel-pt",
                DeepgramSpeakProviderModel.FluxMihaelaHr => "flux-mihaela-hr",
                DeepgramSpeakProviderModel.FluxMikhailRu => "flux-mikhail-ru",
                DeepgramSpeakProviderModel.FluxMikyungKo => "flux-mikyung-ko",
                DeepgramSpeakProviderModel.FluxMilesEn => "flux-miles-en",
                DeepgramSpeakProviderModel.FluxMinhVi => "flux-minh-vi",
                DeepgramSpeakProviderModel.FluxMinjunKo => "flux-minjun-ko",
                DeepgramSpeakProviderModel.FluxMoniqueNl => "flux-monique-nl",
                DeepgramSpeakProviderModel.FluxMoritzDe => "flux-moritz-de",
                DeepgramSpeakProviderModel.FluxNadineDe => "flux-nadine-de",
                DeepgramSpeakProviderModel.FluxNataliaRu => "flux-natalia-ru",
                DeepgramSpeakProviderModel.FluxNaveenEn => "flux-naveen-en",
                DeepgramSpeakProviderModel.FluxNeringaLt => "flux-neringa-lt",
                DeepgramSpeakProviderModel.FluxNielsNl => "flux-niels-nl",
                DeepgramSpeakProviderModel.FluxNikhilHi => "flux-nikhil-hi",
                DeepgramSpeakProviderModel.FluxNikolaiRu => "flux-nikolai-ru",
                DeepgramSpeakProviderModel.FluxNoelTl => "flux-noel-tl",
                DeepgramSpeakProviderModel.FluxNozomiJa => "flux-nozomi-ja",
                DeepgramSpeakProviderModel.FluxOlgaRu => "flux-olga-ru",
                DeepgramSpeakProviderModel.FluxOskarSv => "flux-oskar-sv",
                DeepgramSpeakProviderModel.FluxPaigeEn => "flux-paige-en",
                DeepgramSpeakProviderModel.FluxPallaviHi => "flux-pallavi-hi",
                DeepgramSpeakProviderModel.FluxPaolaIt => "flux-paola-it",
                DeepgramSpeakProviderModel.FluxPatriciaEs => "flux-patricia-es",
                DeepgramSpeakProviderModel.FluxPavanTe => "flux-pavan-te",
                DeepgramSpeakProviderModel.FluxPedroPt => "flux-pedro-pt",
                DeepgramSpeakProviderModel.FluxPernilleDa => "flux-pernille-da",
                DeepgramSpeakProviderModel.FluxPierreFr => "flux-pierre-fr",
                DeepgramSpeakProviderModel.FluxPilarEs => "flux-pilar-es",
                DeepgramSpeakProviderModel.FluxPolinaRu => "flux-polina-ru",
                DeepgramSpeakProviderModel.FluxPontusSv => "flux-pontus-sv",
                DeepgramSpeakProviderModel.FluxPoojaMr => "flux-pooja-mr",
                DeepgramSpeakProviderModel.FluxPrachiHi => "flux-prachi-hi",
                DeepgramSpeakProviderModel.FluxPratikMr => "flux-pratik-mr",
                DeepgramSpeakProviderModel.FluxPriyaEn => "flux-priya-en",
                DeepgramSpeakProviderModel.FluxRafaelEs => "flux-rafael-es",
                DeepgramSpeakProviderModel.FluxRahulHi => "flux-rahul-hi",
                DeepgramSpeakProviderModel.FluxRajeshHi => "flux-rajesh-hi",
                DeepgramSpeakProviderModel.FluxRasmusDa => "flux-rasmus-da",
                DeepgramSpeakProviderModel.FluxRaviTe => "flux-ravi-te",
                DeepgramSpeakProviderModel.FluxRenatoPt => "flux-renato-pt",
                DeepgramSpeakProviderModel.FluxRicardoPt => "flux-ricardo-pt",
                DeepgramSpeakProviderModel.FluxRikkeDa => "flux-rikke-da",
                DeepgramSpeakProviderModel.FluxRituHi => "flux-ritu-hi",
                DeepgramSpeakProviderModel.FluxRizkyId => "flux-rizky-id",
                DeepgramSpeakProviderModel.FluxRobertoPt => "flux-roberto-pt",
                DeepgramSpeakProviderModel.FluxRoccoIt => "flux-rocco-it",
                DeepgramSpeakProviderModel.FluxRodrigoPt => "flux-rodrigo-pt",
                DeepgramSpeakProviderModel.FluxRolfDe => "flux-rolf-de",
                DeepgramSpeakProviderModel.FluxRubenNl => "flux-ruben-nl",
                DeepgramSpeakProviderModel.FluxRufusEn => "flux-rufus-en",
                DeepgramSpeakProviderModel.FluxSabbirBn => "flux-sabbir-bn",
                DeepgramSpeakProviderModel.FluxSanneNl => "flux-sanne-nl",
                DeepgramSpeakProviderModel.FluxSayakaJa => "flux-sayaka-ja",
                DeepgramSpeakProviderModel.FluxSeanEn => "flux-sean-en",
                DeepgramSpeakProviderModel.FluxSerkanTr => "flux-serkan-tr",
                DeepgramSpeakProviderModel.FluxSharonEn => "flux-sharon-en",
                DeepgramSpeakProviderModel.FluxShreyaHi => "flux-shreya-hi",
                DeepgramSpeakProviderModel.FluxShufenZh => "flux-shufen-zh",
                DeepgramSpeakProviderModel.FluxShuvoBn => "flux-shuvo-bn",
                DeepgramSpeakProviderModel.FluxSiennaEn => "flux-sienna-en",
                DeepgramSpeakProviderModel.FluxSigneNo => "flux-signe-no",
                DeepgramSpeakProviderModel.FluxSiljeNo => "flux-silje-no",
                DeepgramSpeakProviderModel.FluxSnehaMr => "flux-sneha-mr",
                DeepgramSpeakProviderModel.FluxSofiaIt => "flux-sofia-it",
                DeepgramSpeakProviderModel.FluxSolomiyaUk => "flux-solomiya-uk",
                DeepgramSpeakProviderModel.FluxSonjaDe => "flux-sonja-de",
                DeepgramSpeakProviderModel.FluxSoojinKo => "flux-soojin-ko",
                DeepgramSpeakProviderModel.FluxSowmyaTa => "flux-sowmya-ta",
                DeepgramSpeakProviderModel.FluxSravaniTe => "flux-sravani-te",
                DeepgramSpeakProviderModel.FluxStefanoIt => "flux-stefano-it",
                DeepgramSpeakProviderModel.FluxSumaiyaBn => "flux-sumaiya-bn",
                DeepgramSpeakProviderModel.FluxSungminKo => "flux-sungmin-ko",
                DeepgramSpeakProviderModel.FluxSunitaHi => "flux-sunita-hi",
                DeepgramSpeakProviderModel.FluxSvenDe => "flux-sven-de",
                DeepgramSpeakProviderModel.FluxTannerEn => "flux-tanner-en",
                DeepgramSpeakProviderModel.FluxTeemuFi => "flux-teemu-fi",
                DeepgramSpeakProviderModel.FluxTeguhId => "flux-teguh-id",
                DeepgramSpeakProviderModel.FluxThierryFr => "flux-thierry-fr",
                DeepgramSpeakProviderModel.FluxTiborHu => "flux-tibor-hu",
                DeepgramSpeakProviderModel.FluxTobiasDe => "flux-tobias-de",
                DeepgramSpeakProviderModel.FluxTomasEs => "flux-tomas-es",
                DeepgramSpeakProviderModel.FluxTriinEt => "flux-triin-et",
                DeepgramSpeakProviderModel.FluxTrishaTl => "flux-trisha-tl",
                DeepgramSpeakProviderModel.FluxUsmanUr => "flux-usman-ur",
                DeepgramSpeakProviderModel.FluxValentinaEs => "flux-valentina-es",
                DeepgramSpeakProviderModel.FluxVedranHr => "flux-vedran-hr",
                DeepgramSpeakProviderModel.FluxVeerleNl => "flux-veerle-nl",
                DeepgramSpeakProviderModel.FluxVegardNo => "flux-vegard-no",
                DeepgramSpeakProviderModel.FluxVerenaDe => "flux-verena-de",
                DeepgramSpeakProviderModel.FluxVeroniqueFr => "flux-veronique-fr",
                DeepgramSpeakProviderModel.FluxVikramHi => "flux-vikram-hi",
                DeepgramSpeakProviderModel.FluxVincenzoIt => "flux-vincenzo-it",
                DeepgramSpeakProviderModel.FluxVinothTa => "flux-vinoth-ta",
                DeepgramSpeakProviderModel.FluxVitoIt => "flux-vito-it",
                DeepgramSpeakProviderModel.FluxVladimirRu => "flux-vladimir-ru",
                DeepgramSpeakProviderModel.FluxWadeEn => "flux-wade-en",
                DeepgramSpeakProviderModel.FluxWenboZh => "flux-wenbo-zh",
                DeepgramSpeakProviderModel.FluxWenjingZh => "flux-wenjing-zh",
                DeepgramSpeakProviderModel.FluxWesEn => "flux-wes-en",
                DeepgramSpeakProviderModel.FluxWilmaSv => "flux-wilma-sv",
                DeepgramSpeakProviderModel.FluxYannickDe => "flux-yannick-de",
                DeepgramSpeakProviderModel.FluxYasmineFr => "flux-yasmine-fr",
                DeepgramSpeakProviderModel.FluxYawenZh => "flux-yawen-zh",
                DeepgramSpeakProviderModel.FluxYsabelEs => "flux-ysabel-es",
                DeepgramSpeakProviderModel.FluxYutingZh => "flux-yuting-zh",
                DeepgramSpeakProviderModel.FluxYvonneNl => "flux-yvonne-nl",
                DeepgramSpeakProviderModel.FluxZeynepTr => "flux-zeynep-tr",
                DeepgramSpeakProviderModel.FluxZhenZh => "flux-zhen-zh",
                DeepgramSpeakProviderModel.FluxZuzannaPl => "flux-zuzanna-pl",
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
                "aura-2-alvaro-es" => DeepgramSpeakProviderModel.Aura2AlvaroEs,
                "aura-2-amalthea-en" => DeepgramSpeakProviderModel.Aura2AmaltheaEn,
                "aura-2-andromeda-en" => DeepgramSpeakProviderModel.Aura2AndromedaEn,
                "aura-2-apollo-en" => DeepgramSpeakProviderModel.Aura2ApolloEn,
                "aura-2-aquila-es" => DeepgramSpeakProviderModel.Aura2AquilaEs,
                "aura-2-arcas-en" => DeepgramSpeakProviderModel.Aura2ArcasEn,
                "aura-2-aries-en" => DeepgramSpeakProviderModel.Aura2AriesEn,
                "aura-2-asteria-en" => DeepgramSpeakProviderModel.Aura2AsteriaEn,
                "aura-2-athena-en" => DeepgramSpeakProviderModel.Aura2AthenaEn,
                "aura-2-atlas-en" => DeepgramSpeakProviderModel.Aura2AtlasEn,
                "aura-2-aurora-en" => DeepgramSpeakProviderModel.Aura2AuroraEn,
                "aura-2-callista-en" => DeepgramSpeakProviderModel.Aura2CallistaEn,
                "aura-2-carina-es" => DeepgramSpeakProviderModel.Aura2CarinaEs,
                "aura-2-celeste-es" => DeepgramSpeakProviderModel.Aura2CelesteEs,
                "aura-2-cora-en" => DeepgramSpeakProviderModel.Aura2CoraEn,
                "aura-2-cordelia-en" => DeepgramSpeakProviderModel.Aura2CordeliaEn,
                "aura-2-delia-en" => DeepgramSpeakProviderModel.Aura2DeliaEn,
                "aura-2-diana-es" => DeepgramSpeakProviderModel.Aura2DianaEs,
                "aura-2-draco-en" => DeepgramSpeakProviderModel.Aura2DracoEn,
                "aura-2-electra-en" => DeepgramSpeakProviderModel.Aura2ElectraEn,
                "aura-2-estrella-es" => DeepgramSpeakProviderModel.Aura2EstrellaEs,
                "aura-2-harmonia-en" => DeepgramSpeakProviderModel.Aura2HarmoniaEn,
                "aura-2-helena-en" => DeepgramSpeakProviderModel.Aura2HelenaEn,
                "aura-2-hera-en" => DeepgramSpeakProviderModel.Aura2HeraEn,
                "aura-2-hermes-en" => DeepgramSpeakProviderModel.Aura2HermesEn,
                "aura-2-hyperion-en" => DeepgramSpeakProviderModel.Aura2HyperionEn,
                "aura-2-iris-en" => DeepgramSpeakProviderModel.Aura2IrisEn,
                "aura-2-janus-en" => DeepgramSpeakProviderModel.Aura2JanusEn,
                "aura-2-javier-es" => DeepgramSpeakProviderModel.Aura2JavierEs,
                "aura-2-juno-en" => DeepgramSpeakProviderModel.Aura2JunoEn,
                "aura-2-jupiter-en" => DeepgramSpeakProviderModel.Aura2JupiterEn,
                "aura-2-luna-en" => DeepgramSpeakProviderModel.Aura2LunaEn,
                "aura-2-mars-en" => DeepgramSpeakProviderModel.Aura2MarsEn,
                "aura-2-minerva-en" => DeepgramSpeakProviderModel.Aura2MinervaEn,
                "aura-2-neptune-en" => DeepgramSpeakProviderModel.Aura2NeptuneEn,
                "aura-2-nestor-es" => DeepgramSpeakProviderModel.Aura2NestorEs,
                "aura-2-odysseus-en" => DeepgramSpeakProviderModel.Aura2OdysseusEn,
                "aura-2-ophelia-en" => DeepgramSpeakProviderModel.Aura2OpheliaEn,
                "aura-2-orion-en" => DeepgramSpeakProviderModel.Aura2OrionEn,
                "aura-2-orpheus-en" => DeepgramSpeakProviderModel.Aura2OrpheusEn,
                "aura-2-pandora-en" => DeepgramSpeakProviderModel.Aura2PandoraEn,
                "aura-2-phoebe-en" => DeepgramSpeakProviderModel.Aura2PhoebeEn,
                "aura-2-pluto-en" => DeepgramSpeakProviderModel.Aura2PlutoEn,
                "aura-2-saturn-en" => DeepgramSpeakProviderModel.Aura2SaturnEn,
                "aura-2-selena-es" => DeepgramSpeakProviderModel.Aura2SelenaEs,
                "aura-2-selene-en" => DeepgramSpeakProviderModel.Aura2SeleneEn,
                "aura-2-sirio-es" => DeepgramSpeakProviderModel.Aura2SirioEs,
                "aura-2-thalia-en" => DeepgramSpeakProviderModel.Aura2ThaliaEn,
                "aura-2-theia-en" => DeepgramSpeakProviderModel.Aura2TheiaEn,
                "aura-2-vesta-en" => DeepgramSpeakProviderModel.Aura2VestaEn,
                "aura-2-zeus-en" => DeepgramSpeakProviderModel.Aura2ZeusEn,
                "aura-angus-en" => DeepgramSpeakProviderModel.AuraAngusEn,
                "aura-arcas-en" => DeepgramSpeakProviderModel.AuraArcasEn,
                "aura-asteria-en" => DeepgramSpeakProviderModel.AuraAsteriaEn,
                "aura-athena-en" => DeepgramSpeakProviderModel.AuraAthenaEn,
                "aura-helios-en" => DeepgramSpeakProviderModel.AuraHeliosEn,
                "aura-hera-en" => DeepgramSpeakProviderModel.AuraHeraEn,
                "aura-luna-en" => DeepgramSpeakProviderModel.AuraLunaEn,
                "aura-orion-en" => DeepgramSpeakProviderModel.AuraOrionEn,
                "aura-orpheus-en" => DeepgramSpeakProviderModel.AuraOrpheusEn,
                "aura-perseus-en" => DeepgramSpeakProviderModel.AuraPerseusEn,
                "aura-stella-en" => DeepgramSpeakProviderModel.AuraStellaEn,
                "aura-zeus-en" => DeepgramSpeakProviderModel.AuraZeusEn,
                "flux-afsana-bn" => DeepgramSpeakProviderModel.FluxAfsanaBn,
                "flux-agnese-lv" => DeepgramSpeakProviderModel.FluxAgneseLv,
                "flux-aina-es" => DeepgramSpeakProviderModel.FluxAinaEs,
                "flux-ajay-hi" => DeepgramSpeakProviderModel.FluxAjayHi,
                "flux-alexis-en" => DeepgramSpeakProviderModel.FluxAlexisEn,
                "flux-alfredo-es" => DeepgramSpeakProviderModel.FluxAlfredoEs,
                "flux-ambreen-ur" => DeepgramSpeakProviderModel.FluxAmbreenUr,
                "flux-andrei-ru" => DeepgramSpeakProviderModel.FluxAndreiRu,
                "flux-angela-it" => DeepgramSpeakProviderModel.FluxAngelaIt,
                "flux-anjali-hi" => DeepgramSpeakProviderModel.FluxAnjaliHi,
                "flux-anouk-nl" => DeepgramSpeakProviderModel.FluxAnoukNl,
                "flux-arjun-hi" => DeepgramSpeakProviderModel.FluxArjunHi,
                "flux-arnaud-fr" => DeepgramSpeakProviderModel.FluxArnaudFr,
                "flux-artur-pt" => DeepgramSpeakProviderModel.FluxArturPt,
                "flux-axel-sv" => DeepgramSpeakProviderModel.FluxAxelSv,
                "flux-ayumi-ja" => DeepgramSpeakProviderModel.FluxAyumiJa,
                "flux-bartosz-pl" => DeepgramSpeakProviderModel.FluxBartoszPl,
                "flux-bence-hu" => DeepgramSpeakProviderModel.FluxBenceHu,
                "flux-benedita-pt" => DeepgramSpeakProviderModel.FluxBeneditaPt,
                "flux-benjamin-de" => DeepgramSpeakProviderModel.FluxBenjaminDe,
                "flux-benoit-fr" => DeepgramSpeakProviderModel.FluxBenoitFr,
                "flux-bhavna-gu" => DeepgramSpeakProviderModel.FluxBhavnaGu,
                "flux-bianca-pt" => DeepgramSpeakProviderModel.FluxBiancaPt,
                "flux-bo-zh" => DeepgramSpeakProviderModel.FluxBoZh,
                "flux-bram-nl" => DeepgramSpeakProviderModel.FluxBramNl,
                "flux-bree-en" => DeepgramSpeakProviderModel.FluxBreeEn,
                "flux-brigitte-fr" => DeepgramSpeakProviderModel.FluxBrigitteFr,
                "flux-brittany-en" => DeepgramSpeakProviderModel.FluxBrittanyEn,
                "flux-brooke-en" => DeepgramSpeakProviderModel.FluxBrookeEn,
                "flux-bruce-en" => DeepgramSpeakProviderModel.FluxBruceEn,
                "flux-bruno-pt" => DeepgramSpeakProviderModel.FluxBrunoPt,
                "flux-camille-fr" => DeepgramSpeakProviderModel.FluxCamilleFr,
                "flux-carmen-es" => DeepgramSpeakProviderModel.FluxCarmenEs,
                "flux-catarina-pt" => DeepgramSpeakProviderModel.FluxCatarinaPt,
                "flux-cecilia-es" => DeepgramSpeakProviderModel.FluxCeciliaEs,
                "flux-charlotta-sv" => DeepgramSpeakProviderModel.FluxCharlottaSv,
                "flux-chiara-it" => DeepgramSpeakProviderModel.FluxChiaraIt,
                "flux-chiaying-zh" => DeepgramSpeakProviderModel.FluxChiayingZh,
                "flux-chloe-fr" => DeepgramSpeakProviderModel.FluxChloeFr,
                "flux-christian-de" => DeepgramSpeakProviderModel.FluxChristianDe,
                "flux-claudia-pt" => DeepgramSpeakProviderModel.FluxClaudiaPt,
                "flux-cliff-en" => DeepgramSpeakProviderModel.FluxCliffEn,
                "flux-cole-en" => DeepgramSpeakProviderModel.FluxColeEn,
                "flux-colin-en" => DeepgramSpeakProviderModel.FluxColinEn,
                "flux-conor-en" => DeepgramSpeakProviderModel.FluxConorEn,
                "flux-cosmin-ro" => DeepgramSpeakProviderModel.FluxCosminRo,
                "flux-dalibor-hr" => DeepgramSpeakProviderModel.FluxDaliborHr,
                "flux-danijela-hr" => DeepgramSpeakProviderModel.FluxDanijelaHr,
                "flux-denys-uk" => DeepgramSpeakProviderModel.FluxDenysUk,
                "flux-desislava-bg" => DeepgramSpeakProviderModel.FluxDesislavaBg,
                "flux-dewi-id" => DeepgramSpeakProviderModel.FluxDewiId,
                "flux-dilek-tr" => DeepgramSpeakProviderModel.FluxDilekTr,
                "flux-dirk-nl" => DeepgramSpeakProviderModel.FluxDirkNl,
                "flux-divya-hi" => DeepgramSpeakProviderModel.FluxDivyaHi,
                "flux-domagoj-hr" => DeepgramSpeakProviderModel.FluxDomagojHr,
                "flux-dominika-sk" => DeepgramSpeakProviderModel.FluxDominikaSk,
                "flux-donovan-en" => DeepgramSpeakProviderModel.FluxDonovanEn,
                "flux-drew-en" => DeepgramSpeakProviderModel.FluxDrewEn,
                "flux-duvan-es" => DeepgramSpeakProviderModel.FluxDuvanEs,
                "flux-ecem-tr" => DeepgramSpeakProviderModel.FluxEcemTr,
                "flux-edgars-lv" => DeepgramSpeakProviderModel.FluxEdgarsLv,
                "flux-eduardo-es" => DeepgramSpeakProviderModel.FluxEduardoEs,
                "flux-elise-en" => DeepgramSpeakProviderModel.FluxEliseEn,
                "flux-emre-tr" => DeepgramSpeakProviderModel.FluxEmreTr,
                "flux-erlend-no" => DeepgramSpeakProviderModel.FluxErlendNo,
                "flux-ernesto-es" => DeepgramSpeakProviderModel.FluxErnestoEs,
                "flux-espen-no" => DeepgramSpeakProviderModel.FluxEspenNo,
                "flux-eszter-hu" => DeepgramSpeakProviderModel.FluxEszterHu,
                "flux-eunji-ko" => DeepgramSpeakProviderModel.FluxEunjiKo,
                "flux-ewa-pl" => DeepgramSpeakProviderModel.FluxEwaPl,
                "flux-fajar-id" => DeepgramSpeakProviderModel.FluxFajarId,
                "flux-federico-it" => DeepgramSpeakProviderModel.FluxFedericoIt,
                "flux-fernanda-es" => DeepgramSpeakProviderModel.FluxFernandaEs,
                "flux-fiorella-es" => DeepgramSpeakProviderModel.FluxFiorellaEs,
                "flux-fitri-id" => DeepgramSpeakProviderModel.FluxFitriId,
                "flux-fleur-nl" => DeepgramSpeakProviderModel.FluxFleurNl,
                "flux-florian-fr" => DeepgramSpeakProviderModel.FluxFlorianFr,
                "flux-frida-sv" => DeepgramSpeakProviderModel.FluxFridaSv,
                "flux-gemma-en" => DeepgramSpeakProviderModel.FluxGemmaEn,
                "flux-gergana-bg" => DeepgramSpeakProviderModel.FluxGerganaBg,
                "flux-giorgio-it" => DeepgramSpeakProviderModel.FluxGiorgioIt,
                "flux-gizem-tr" => DeepgramSpeakProviderModel.FluxGizemTr,
                "flux-goda-lt" => DeepgramSpeakProviderModel.FluxGodaLt,
                "flux-gokul-ta" => DeepgramSpeakProviderModel.FluxGokulTa,
                "flux-gregor-sl" => DeepgramSpeakProviderModel.FluxGregorSl,
                "flux-gustavo-es" => DeepgramSpeakProviderModel.FluxGustavoEs,
                "flux-haley-en" => DeepgramSpeakProviderModel.FluxHaleyEn,
                "flux-hannah-en" => DeepgramSpeakProviderModel.FluxHannahEn,
                "flux-haoran-zh" => DeepgramSpeakProviderModel.FluxHaoranZh,
                "flux-hayato-ja" => DeepgramSpeakProviderModel.FluxHayatoJa,
                "flux-haziq-ms" => DeepgramSpeakProviderModel.FluxHaziqMs,
                "flux-heather-en" => DeepgramSpeakProviderModel.FluxHeatherEn,
                "flux-hetal-gu" => DeepgramSpeakProviderModel.FluxHetalGu,
                "flux-hoa-vi" => DeepgramSpeakProviderModel.FluxHoaVi,
                "flux-hugo-pt" => DeepgramSpeakProviderModel.FluxHugoPt,
                "flux-hyunwoo-ko" => DeepgramSpeakProviderModel.FluxHyunwooKo,
                "flux-ida-no" => DeepgramSpeakProviderModel.FluxIdaNo,
                "flux-ioana-ro" => DeepgramSpeakProviderModel.FluxIoanaRo,
                "flux-irene-nl" => DeepgramSpeakProviderModel.FluxIreneNl,
                "flux-ishrat-bn" => DeepgramSpeakProviderModel.FluxIshratBn,
                "flux-izzah-ms" => DeepgramSpeakProviderModel.FluxIzzahMs,
                "flux-jack-en" => DeepgramSpeakProviderModel.FluxJackEn,
                "flux-jaime-es" => DeepgramSpeakProviderModel.FluxJaimeEs,
                "flux-jakub-cs" => DeepgramSpeakProviderModel.FluxJakubCs,
                "flux-janine-de" => DeepgramSpeakProviderModel.FluxJanineDe,
                "flux-jasna-hr" => DeepgramSpeakProviderModel.FluxJasnaHr,
                "flux-jerome-tl" => DeepgramSpeakProviderModel.FluxJeromeTl,
                "flux-jian-zh" => DeepgramSpeakProviderModel.FluxJianZh,
                "flux-jie-zh" => DeepgramSpeakProviderModel.FluxJieZh,
                "flux-jignesh-gu" => DeepgramSpeakProviderModel.FluxJigneshGu,
                "flux-jomar-tl" => DeepgramSpeakProviderModel.FluxJomarTl,
                "flux-jordi-ca" => DeepgramSpeakProviderModel.FluxJordiCa,
                "flux-josipa-hr" => DeepgramSpeakProviderModel.FluxJosipaHr,
                "flux-judit-ca" => DeepgramSpeakProviderModel.FluxJuditCa,
                "flux-julien-fr" => DeepgramSpeakProviderModel.FluxJulienFr,
                "flux-juraj-sk" => DeepgramSpeakProviderModel.FluxJurajSk,
                "flux-justyna-pl" => DeepgramSpeakProviderModel.FluxJustynaPl,
                "flux-jyoti-hi" => DeepgramSpeakProviderModel.FluxJyotiHi,
                "flux-kacper-pl" => DeepgramSpeakProviderModel.FluxKacperPl,
                "flux-kai-en" => DeepgramSpeakProviderModel.FluxKaiEn,
                "flux-katja-sl" => DeepgramSpeakProviderModel.FluxKatjaSl,
                "flux-kavya-ta" => DeepgramSpeakProviderModel.FluxKavyaTa,
                "flux-kelsey-en" => DeepgramSpeakProviderModel.FluxKelseyEn,
                "flux-kinga-hu" => DeepgramSpeakProviderModel.FluxKingaHu,
                "flux-kirill-ru" => DeepgramSpeakProviderModel.FluxKirillRu,
                "flux-kirsi-fi" => DeepgramSpeakProviderModel.FluxKirsiFi,
                "flux-kit-en" => DeepgramSpeakProviderModel.FluxKitEn,
                "flux-konrad-pl" => DeepgramSpeakProviderModel.FluxKonradPl,
                "flux-kostas-el" => DeepgramSpeakProviderModel.FluxKostasEl,
                "flux-kuanyu-zh" => DeepgramSpeakProviderModel.FluxKuanyuZh,
                "flux-leandro-pt" => DeepgramSpeakProviderModel.FluxLeandroPt,
                "flux-leonie-de" => DeepgramSpeakProviderModel.FluxLeonieDe,
                "flux-liezel-tl" => DeepgramSpeakProviderModel.FluxLiezelTl,
                "flux-lijuan-zh" => DeepgramSpeakProviderModel.FluxLijuanZh,
                "flux-lotte-nl" => DeepgramSpeakProviderModel.FluxLotteNl,
                "flux-ludvig-sv" => DeepgramSpeakProviderModel.FluxLudvigSv,
                "flux-luuk-nl" => DeepgramSpeakProviderModel.FluxLuukNl,
                "flux-maeve-en" => DeepgramSpeakProviderModel.FluxMaeveEn,
                "flux-magdalena-de" => DeepgramSpeakProviderModel.FluxMagdalenaDe,
                "flux-mamun-bn" => DeepgramSpeakProviderModel.FluxMamunBn,
                "flux-manjunath-kn" => DeepgramSpeakProviderModel.FluxManjunathKn,
                "flux-manlok-zh" => DeepgramSpeakProviderModel.FluxManlokZh,
                "flux-marcelo-en" => DeepgramSpeakProviderModel.FluxMarceloEn,
                "flux-marcia-pt" => DeepgramSpeakProviderModel.FluxMarciaPt,
                "flux-marcus-en" => DeepgramSpeakProviderModel.FluxMarcusEn,
                "flux-mariana-pt" => DeepgramSpeakProviderModel.FluxMarianaPt,
                "flux-marta-pt" => DeepgramSpeakProviderModel.FluxMartaPt,
                "flux-martin-es" => DeepgramSpeakProviderModel.FluxMartinEs,
                "flux-mateus-pt" => DeepgramSpeakProviderModel.FluxMateusPt,
                "flux-mathieu-fr" => DeepgramSpeakProviderModel.FluxMathieuFr,
                "flux-matteo-it" => DeepgramSpeakProviderModel.FluxMatteoIt,
                "flux-mauricio-es" => DeepgramSpeakProviderModel.FluxMauricioEs,
                "flux-maxim-ru" => DeepgramSpeakProviderModel.FluxMaximRu,
                "flux-meena-en" => DeepgramSpeakProviderModel.FluxMeenaEn,
                "flux-meghan-en" => DeepgramSpeakProviderModel.FluxMeghanEn,
                "flux-mehmet-tr" => DeepgramSpeakProviderModel.FluxMehmetTr,
                "flux-miguel-pt" => DeepgramSpeakProviderModel.FluxMiguelPt,
                "flux-mihaela-hr" => DeepgramSpeakProviderModel.FluxMihaelaHr,
                "flux-mikhail-ru" => DeepgramSpeakProviderModel.FluxMikhailRu,
                "flux-mikyung-ko" => DeepgramSpeakProviderModel.FluxMikyungKo,
                "flux-miles-en" => DeepgramSpeakProviderModel.FluxMilesEn,
                "flux-minh-vi" => DeepgramSpeakProviderModel.FluxMinhVi,
                "flux-minjun-ko" => DeepgramSpeakProviderModel.FluxMinjunKo,
                "flux-monique-nl" => DeepgramSpeakProviderModel.FluxMoniqueNl,
                "flux-moritz-de" => DeepgramSpeakProviderModel.FluxMoritzDe,
                "flux-nadine-de" => DeepgramSpeakProviderModel.FluxNadineDe,
                "flux-natalia-ru" => DeepgramSpeakProviderModel.FluxNataliaRu,
                "flux-naveen-en" => DeepgramSpeakProviderModel.FluxNaveenEn,
                "flux-neringa-lt" => DeepgramSpeakProviderModel.FluxNeringaLt,
                "flux-niels-nl" => DeepgramSpeakProviderModel.FluxNielsNl,
                "flux-nikhil-hi" => DeepgramSpeakProviderModel.FluxNikhilHi,
                "flux-nikolai-ru" => DeepgramSpeakProviderModel.FluxNikolaiRu,
                "flux-noel-tl" => DeepgramSpeakProviderModel.FluxNoelTl,
                "flux-nozomi-ja" => DeepgramSpeakProviderModel.FluxNozomiJa,
                "flux-olga-ru" => DeepgramSpeakProviderModel.FluxOlgaRu,
                "flux-oskar-sv" => DeepgramSpeakProviderModel.FluxOskarSv,
                "flux-paige-en" => DeepgramSpeakProviderModel.FluxPaigeEn,
                "flux-pallavi-hi" => DeepgramSpeakProviderModel.FluxPallaviHi,
                "flux-paola-it" => DeepgramSpeakProviderModel.FluxPaolaIt,
                "flux-patricia-es" => DeepgramSpeakProviderModel.FluxPatriciaEs,
                "flux-pavan-te" => DeepgramSpeakProviderModel.FluxPavanTe,
                "flux-pedro-pt" => DeepgramSpeakProviderModel.FluxPedroPt,
                "flux-pernille-da" => DeepgramSpeakProviderModel.FluxPernilleDa,
                "flux-pierre-fr" => DeepgramSpeakProviderModel.FluxPierreFr,
                "flux-pilar-es" => DeepgramSpeakProviderModel.FluxPilarEs,
                "flux-polina-ru" => DeepgramSpeakProviderModel.FluxPolinaRu,
                "flux-pontus-sv" => DeepgramSpeakProviderModel.FluxPontusSv,
                "flux-pooja-mr" => DeepgramSpeakProviderModel.FluxPoojaMr,
                "flux-prachi-hi" => DeepgramSpeakProviderModel.FluxPrachiHi,
                "flux-pratik-mr" => DeepgramSpeakProviderModel.FluxPratikMr,
                "flux-priya-en" => DeepgramSpeakProviderModel.FluxPriyaEn,
                "flux-rafael-es" => DeepgramSpeakProviderModel.FluxRafaelEs,
                "flux-rahul-hi" => DeepgramSpeakProviderModel.FluxRahulHi,
                "flux-rajesh-hi" => DeepgramSpeakProviderModel.FluxRajeshHi,
                "flux-rasmus-da" => DeepgramSpeakProviderModel.FluxRasmusDa,
                "flux-ravi-te" => DeepgramSpeakProviderModel.FluxRaviTe,
                "flux-renato-pt" => DeepgramSpeakProviderModel.FluxRenatoPt,
                "flux-ricardo-pt" => DeepgramSpeakProviderModel.FluxRicardoPt,
                "flux-rikke-da" => DeepgramSpeakProviderModel.FluxRikkeDa,
                "flux-ritu-hi" => DeepgramSpeakProviderModel.FluxRituHi,
                "flux-rizky-id" => DeepgramSpeakProviderModel.FluxRizkyId,
                "flux-roberto-pt" => DeepgramSpeakProviderModel.FluxRobertoPt,
                "flux-rocco-it" => DeepgramSpeakProviderModel.FluxRoccoIt,
                "flux-rodrigo-pt" => DeepgramSpeakProviderModel.FluxRodrigoPt,
                "flux-rolf-de" => DeepgramSpeakProviderModel.FluxRolfDe,
                "flux-ruben-nl" => DeepgramSpeakProviderModel.FluxRubenNl,
                "flux-rufus-en" => DeepgramSpeakProviderModel.FluxRufusEn,
                "flux-sabbir-bn" => DeepgramSpeakProviderModel.FluxSabbirBn,
                "flux-sanne-nl" => DeepgramSpeakProviderModel.FluxSanneNl,
                "flux-sayaka-ja" => DeepgramSpeakProviderModel.FluxSayakaJa,
                "flux-sean-en" => DeepgramSpeakProviderModel.FluxSeanEn,
                "flux-serkan-tr" => DeepgramSpeakProviderModel.FluxSerkanTr,
                "flux-sharon-en" => DeepgramSpeakProviderModel.FluxSharonEn,
                "flux-shreya-hi" => DeepgramSpeakProviderModel.FluxShreyaHi,
                "flux-shufen-zh" => DeepgramSpeakProviderModel.FluxShufenZh,
                "flux-shuvo-bn" => DeepgramSpeakProviderModel.FluxShuvoBn,
                "flux-sienna-en" => DeepgramSpeakProviderModel.FluxSiennaEn,
                "flux-signe-no" => DeepgramSpeakProviderModel.FluxSigneNo,
                "flux-silje-no" => DeepgramSpeakProviderModel.FluxSiljeNo,
                "flux-sneha-mr" => DeepgramSpeakProviderModel.FluxSnehaMr,
                "flux-sofia-it" => DeepgramSpeakProviderModel.FluxSofiaIt,
                "flux-solomiya-uk" => DeepgramSpeakProviderModel.FluxSolomiyaUk,
                "flux-sonja-de" => DeepgramSpeakProviderModel.FluxSonjaDe,
                "flux-soojin-ko" => DeepgramSpeakProviderModel.FluxSoojinKo,
                "flux-sowmya-ta" => DeepgramSpeakProviderModel.FluxSowmyaTa,
                "flux-sravani-te" => DeepgramSpeakProviderModel.FluxSravaniTe,
                "flux-stefano-it" => DeepgramSpeakProviderModel.FluxStefanoIt,
                "flux-sumaiya-bn" => DeepgramSpeakProviderModel.FluxSumaiyaBn,
                "flux-sungmin-ko" => DeepgramSpeakProviderModel.FluxSungminKo,
                "flux-sunita-hi" => DeepgramSpeakProviderModel.FluxSunitaHi,
                "flux-sven-de" => DeepgramSpeakProviderModel.FluxSvenDe,
                "flux-tanner-en" => DeepgramSpeakProviderModel.FluxTannerEn,
                "flux-teemu-fi" => DeepgramSpeakProviderModel.FluxTeemuFi,
                "flux-teguh-id" => DeepgramSpeakProviderModel.FluxTeguhId,
                "flux-thierry-fr" => DeepgramSpeakProviderModel.FluxThierryFr,
                "flux-tibor-hu" => DeepgramSpeakProviderModel.FluxTiborHu,
                "flux-tobias-de" => DeepgramSpeakProviderModel.FluxTobiasDe,
                "flux-tomas-es" => DeepgramSpeakProviderModel.FluxTomasEs,
                "flux-triin-et" => DeepgramSpeakProviderModel.FluxTriinEt,
                "flux-trisha-tl" => DeepgramSpeakProviderModel.FluxTrishaTl,
                "flux-usman-ur" => DeepgramSpeakProviderModel.FluxUsmanUr,
                "flux-valentina-es" => DeepgramSpeakProviderModel.FluxValentinaEs,
                "flux-vedran-hr" => DeepgramSpeakProviderModel.FluxVedranHr,
                "flux-veerle-nl" => DeepgramSpeakProviderModel.FluxVeerleNl,
                "flux-vegard-no" => DeepgramSpeakProviderModel.FluxVegardNo,
                "flux-verena-de" => DeepgramSpeakProviderModel.FluxVerenaDe,
                "flux-veronique-fr" => DeepgramSpeakProviderModel.FluxVeroniqueFr,
                "flux-vikram-hi" => DeepgramSpeakProviderModel.FluxVikramHi,
                "flux-vincenzo-it" => DeepgramSpeakProviderModel.FluxVincenzoIt,
                "flux-vinoth-ta" => DeepgramSpeakProviderModel.FluxVinothTa,
                "flux-vito-it" => DeepgramSpeakProviderModel.FluxVitoIt,
                "flux-vladimir-ru" => DeepgramSpeakProviderModel.FluxVladimirRu,
                "flux-wade-en" => DeepgramSpeakProviderModel.FluxWadeEn,
                "flux-wenbo-zh" => DeepgramSpeakProviderModel.FluxWenboZh,
                "flux-wenjing-zh" => DeepgramSpeakProviderModel.FluxWenjingZh,
                "flux-wes-en" => DeepgramSpeakProviderModel.FluxWesEn,
                "flux-wilma-sv" => DeepgramSpeakProviderModel.FluxWilmaSv,
                "flux-yannick-de" => DeepgramSpeakProviderModel.FluxYannickDe,
                "flux-yasmine-fr" => DeepgramSpeakProviderModel.FluxYasmineFr,
                "flux-yawen-zh" => DeepgramSpeakProviderModel.FluxYawenZh,
                "flux-ysabel-es" => DeepgramSpeakProviderModel.FluxYsabelEs,
                "flux-yuting-zh" => DeepgramSpeakProviderModel.FluxYutingZh,
                "flux-yvonne-nl" => DeepgramSpeakProviderModel.FluxYvonneNl,
                "flux-zeynep-tr" => DeepgramSpeakProviderModel.FluxZeynepTr,
                "flux-zhen-zh" => DeepgramSpeakProviderModel.FluxZhenZh,
                "flux-zuzanna-pl" => DeepgramSpeakProviderModel.FluxZuzannaPl,
                _ => null,
            };
        }
    }
}