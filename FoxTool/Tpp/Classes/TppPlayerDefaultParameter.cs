using System.Collections.Generic;
using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class TppPlayerDefaultParameter
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        public FoxString ParamName { get; set; }
        public FoxUInt32 LifeMax { get; set; }
        public FoxFloat FlinchDamageInvincibleTime { get; set; }
        public FoxFloat BendDamageInvincibleTime { get; set; }
        public FoxFloat BlowDamageInvincibleTime { get; set; }
        public FoxFloat BrainMaxDamageLifeRate { get; set; }
        public FoxFloat BrainMinDamageLifeRate { get; set; }
        public FoxFloat DyingLifeRate { get; set; }
        public FoxFloat LifeRecoverNormalLevelRate { get; set; }
        public FoxInt32 LifeRecoverRateNormal { get; set; }
        public FoxInt32 LifeRecoverRateDying { get; set; }
        public FoxInt32 LifeRecoverRateHurt { get; set; }
        public FoxDouble NoDamageTime { get; set; }
        public FoxFloat MinHeightFallDamage { get; set; }
        public FoxFloat MaxHeightFallDamage { get; set; }
        public FoxFloat MinFallDamageRate { get; set; }
        public FoxFloat MaxFallDamageRate { get; set; }
        public FoxFloat ForceActionFrame { get; set; }
        public FoxFloat DashAttainRate { get; set; }
        public FoxFloat ParaMoveMinRate { get; set; }
        public FoxFloat ParaMoveMaxRate { get; set; }
        public FoxBool FireReserve { get; set; }
        public FoxFloat WallCheckDistance { get; set; }
        public FoxFloat WallCheckRadius { get; set; }
        public FoxFloat TimeToShowMarker { get; set; }
        public FoxFloat TimeToHideMarker { get; set; }
        public FoxFloat TimeToMarking { get; set; }
        public FoxFloat DistanceEnableMarking { get; set; }
        public FoxFloat DistanceEnableEspRadio { get; set; }
        public FoxFloat RangeEnableMarking { get; set; }
        public FoxFloat AroundCamMarkingRange { get; set; }
        public FoxFloat AroundCamMarkingRangeOnScreen { get; set; }
        public FoxFloat AroundCamMarkerSetTime { get; set; }
        public FoxFloat RangeEnableMarkingOnTps { get; set; }
        public FoxFloat DistanceEnableMarkingOnHeli { get; set; }
        public FoxFloat AroundDistanceEnableMarkingOnHeli { get; set; }
        public FoxFloat HomingAdjustDistance { get; set; }
        public FoxFloat HomingAdjustRangeNear { get; set; }
        public FoxFloat HomingAdjustRangeFar { get; set; }
        public FoxFloat HomingAdjustDistanceNear { get; set; }
        public FoxFloat HomingAdjustDistanceFar { get; set; }
        public FoxFloat HomingAdjustRangeCenterOffsetY { get; set; }
        public Dictionary<string, FoxFloat> CamoufLightRate { get; set; }
        public FoxFloat CamoufAttackTriggerInterval { get; set; }
        public FoxFloat CamoufAttackTriggerIntervalOnVehicle { get; set; }
        public FoxFloat CamoufNight { get; set; }
        public FoxFloat CamoufStanceBehind { get; set; }
        public FoxFloat CamoufStanceStand { get; set; }
        public FoxFloat CamoufStanceSquat { get; set; }
        public FoxFloat CamoufStanceCrawl { get; set; }
        public FoxFloat CamoufCarryEnemy { get; set; }
        public FoxFloat CamoufSquatRun { get; set; }
        public FoxFloat CamoufCrawlMove { get; set; }
        public FoxFloat CamoufStandRun { get; set; }
        public FoxFloat CamoufStandDash { get; set; }
        public FoxFloat CamoufStandWalk { get; set; }
        public FoxFloat CamoufOther { get; set; }
        public FoxFloat CamoufAttack { get; set; }
        public FoxFloat CamoufAttackOnVehicle { get; set; }
        public FoxFloat CamoufShadow { get; set; }
        public FoxFloat CamoufUseFlashLight { get; set; }
        public FoxFloat CamoufHorseRide { get; set; }
        public FoxFloat CamoufHorseClingTop { get; set; }
        public FoxFloat CamoufHorseClingSide { get; set; }
        public FoxFloat CamoufHorseClingBottom { get; set; }
        public FoxFloat CamoufHorseIdle { get; set; }
        public FoxFloat CamoufHorseWalk { get; set; }
        public FoxFloat CamoufHorseTrot { get; set; }
        public FoxFloat CamoufHorseCanter { get; set; }
        public FoxFloat CamoufHorseGallop { get; set; }
        public FoxFloat CamoufArmoredVehicle { get; set; }
        public FoxFloat CamoufTruck { get; set; }
        public FoxFloat CamoufTruckOnDeck { get; set; }
        public FoxFloat CamoufLightVehicle { get; set; }
        public FoxFloat CamoufHelicopter { get; set; }
        public FoxFloat CamoufBushDensityTh { get; set; }
        public FoxFloat CamoufBushRate { get; set; }
        public FoxFloat CamoufBushCheckRadius { get; set; }
        public FoxFloat PhysActionUpperPower { get; set; }
        public FoxFloat PhysActionAdjustPower { get; set; }
        public FoxFloat RecoilAdjustStandMove { get; set; }
        public FoxFloat RecoilAdjustStandIdle { get; set; }
        public FoxFloat RecoilAdjustSquatMove { get; set; }
        public FoxFloat RecoilAdjustSquatIdle { get; set; }
        public FoxFloat RecoilAdjustCrawlMove { get; set; }
        public FoxFloat RecoilAdjustCrawlIdle { get; set; }
        public FoxFloat RecoilMovingRate { get; set; }
        public FoxFloat ThresholdMovingStandMin { get; set; }
        public FoxFloat ThresholdMovingStandMax { get; set; }
        public FoxFloat ThresholdMovingSquatMin { get; set; }
        public FoxFloat ThresholdMovingSquatMax { get; set; }
        public FoxFloat WobblingAdjustStandMove { get; set; }
        public FoxFloat WobblingAdjustStandIdle { get; set; }
        public FoxFloat WobblingAdjustSquatMove { get; set; }
        public FoxFloat WobblingAdjustSquatIdle { get; set; }
        public FoxFloat WobblingAdjustCrawlMove { get; set; }
        public FoxFloat WobblingAdjustCrawlIdle { get; set; }
        public FoxFloat AdjustRateRiseTo { get; set; }
        public FoxFloat ZoomAdjustRateRiseEnd { get; set; }
        public FoxFloat TimeCigaretteSpeedRate { get; set; }
        public FoxFloat TimeCigaretteSpeedRateSlow { get; set; }
        public FoxInt32 TimeCigaretteStopInterval { get; set; }
        public FoxFloat TimeCigaretteStopTime { get; set; }
        public FoxFloat HighSpeedContinueTime { get; set; }
        public FoxFloat HighSpeedAdvContinueTime { get; set; }
        public FoxBool HighSpeedIsSetLocalPlayerTime { get; set; }
        public FoxBool HighSpeedIsSetWorldTime { get; set; }
        public FoxFloat HighSpeedLocalPlayerTimeRate { get; set; }
        public FoxFloat HighSpeedWorldTimeRate { get; set; }
        public FoxFloat HighSpeedTimeRateInterpTimeStart { get; set; }
        public FoxFloat HighSpeedTimeRateInterpTimeEnd { get; set; }
    }
}
