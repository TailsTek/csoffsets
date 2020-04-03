using System;

// 2020-04-03 05:35:12.021977900 UTC

namespace hazedumper
{
    public const Int32 timestamp = 1585892112;
    public static class netvars
    {
        public const Int32 cs_gamerules_data = 0x0;
        public const Int32 m_ArmorValue = 0xB368;
        public const Int32 m_Collision = 0x320;
        public const Int32 m_CollisionGroup = 0x474;
        public const Int32 m_Local = 0x2FBC;
        public const Int32 m_MoveType = 0x25C;
        public const Int32 m_OriginalOwnerXuidHigh = 0x31B4;
        public const Int32 m_OriginalOwnerXuidLow = 0x31B0;
        public const Int32 m_SurvivalGameRuleDecisionTypes = 0x1320;
        public const Int32 m_SurvivalRules = 0xCF8;
        public const Int32 m_aimPunchAngle = 0x302C;
        public const Int32 m_aimPunchAngleVel = 0x3038;
        public const Int32 m_angEyeAnglesX = 0xB36C;
        public const Int32 m_angEyeAnglesY = 0xB370;
        public const Int32 m_bBombPlanted = 0x99D;
        public const Int32 m_bFreezePeriod = 0x20;
        public const Int32 m_bGunGameImmunity = 0x3930;
        public const Int32 m_bHasDefuser = 0xB378;
        public const Int32 m_bHasHelmet = 0xB35C;
        public const Int32 m_bInReload = 0x3295;
        public const Int32 m_bIsDefusing = 0x391C;
        public const Int32 m_bIsQueuedMatchmaking = 0x74;
        public const Int32 m_bIsScoped = 0x3914;
        public const Int32 m_bIsValveDS = 0x75;
        public const Int32 m_bSpotted = 0x93D;
        public const Int32 m_bSpottedByMask = 0x980;
        public const Int32 m_bStartedArming = 0x33E0;
        public const Int32 m_bUseCustomAutoExposureMax = 0x9D9;
        public const Int32 m_bUseCustomAutoExposureMin = 0x9D8;
        public const Int32 m_bUseCustomBloomScale = 0x9DA;
        public const Int32 m_clrRender = 0x70;
        public const Int32 m_dwBoneMatrix = 0x26A8;
        public const Int32 m_fAccuracyPenalty = 0x3320;
        public const Int32 m_fFlags = 0x104;
        public const Int32 m_flC4Blow = 0x2990;
        public const Int32 m_flCustomAutoExposureMax = 0x9E0;
        public const Int32 m_flCustomAutoExposureMin = 0x9DC;
        public const Int32 m_flCustomBloomScale = 0x9E4;
        public const Int32 m_flDefuseCountDown = 0x29AC;
        public const Int32 m_flDefuseLength = 0x29A8;
        public const Int32 m_flFallbackWear = 0x31C0;
        public const Int32 m_flFlashDuration = 0xA410;
        public const Int32 m_flFlashMaxAlpha = 0xA40C;
        public const Int32 m_flLastBoneSetupTime = 0x2924;
        public const Int32 m_flLowerBodyYawTarget = 0x3A7C;
        public const Int32 m_flNextAttack = 0x2D70;
        public const Int32 m_flNextPrimaryAttack = 0x3228;
        public const Int32 m_flSimulationTime = 0x268;
        public const Int32 m_flTimerLength = 0x2994;
        public const Int32 m_hActiveWeapon = 0x2EF8;
        public const Int32 m_hMyWeapons = 0x2DF8;
        public const Int32 m_hObserverTarget = 0x338C;
        public const Int32 m_hOwner = 0x29CC;
        public const Int32 m_hOwnerEntity = 0x14C;
        public const Int32 m_iAccountID = 0x2FC8;
        public const Int32 m_iClip1 = 0x3254;
        public const Int32 m_iCompetitiveRanking = 0x1A84;
        public const Int32 m_iCompetitiveWins = 0x1B88;
        public const Int32 m_iCrosshairId = 0xB3D4;
        public const Int32 m_iEntityQuality = 0x2FAC;
        public const Int32 m_iFOV = 0x31E4;
        public const Int32 m_iFOVStart = 0x31E8;
        public const Int32 m_iGlowIndex = 0xA428;
        public const Int32 m_iHealth = 0x100;
        public const Int32 m_iItemDefinitionIndex = 0x2FAA;
        public const Int32 m_iItemIDHigh = 0x2FC0;
        public const Int32 m_iMostRecentModelBoneCounter = 0x2690;
        public const Int32 m_iObserverMode = 0x3378;
        public const Int32 m_iShotsFired = 0xA380;
        public const Int32 m_iState = 0x3248;
        public const Int32 m_iTeamNum = 0xF4;
        public const Int32 m_lifeState = 0x25F;
        public const Int32 m_nFallbackPaintKit = 0x31B8;
        public const Int32 m_nFallbackSeed = 0x31BC;
        public const Int32 m_nFallbackStatTrak = 0x31C4;
        public const Int32 m_nForceBone = 0x268C;
        public const Int32 m_nTickBase = 0x3430;
        public const Int32 m_rgflCoordinateFrame = 0x444;
        public const Int32 m_szCustomName = 0x303C;
        public const Int32 m_szLastPlaceName = 0x35B4;
        public const Int32 m_thirdPersonViewAngles = 0x31D8;
        public const Int32 m_vecOrigin = 0x138;
        public const Int32 m_vecVelocity = 0x114;
        public const Int32 m_vecViewOffset = 0x108;
        public const Int32 m_viewPunchAngle = 0x3020;
    }
    public static class signatures
    {
        public const Int32 anim_overlays = 0x2980;
        public const Int32 clientstate_choked_commands = 0x4D28;
        public const Int32 clientstate_delta_ticks = 0x174;
        public const Int32 clientstate_last_outgoing_command = 0x4D24;
        public const Int32 clientstate_net_channel = 0x9C;
        public const Int32 convar_name_hash_table = 0x2F0F8;
        public const Int32 dwClientState = 0x589DCC;
        public const Int32 dwClientState_GetLocalPlayer = 0x180;
        public const Int32 dwClientState_IsHLTV = 0x4D40;
        public const Int32 dwClientState_Map = 0x28C;
        public const Int32 dwClientState_MapDirectory = 0x188;
        public const Int32 dwClientState_MaxPlayer = 0x388;
        public const Int32 dwClientState_PlayerInfo = 0x52B8;
        public const Int32 dwClientState_State = 0x108;
        public const Int32 dwClientState_ViewAngles = 0x4D88;
        public const Int32 dwEntityList = 0x4D419F4;
        public const Int32 dwForceAttack = 0x3172FBC;
        public const Int32 dwForceAttack2 = 0x3172FC8;
        public const Int32 dwForceBackward = 0x3173010;
        public const Int32 dwForceForward = 0x317301C;
        public const Int32 dwForceJump = 0x51EB650;
        public const Int32 dwForceLeft = 0x3172F98;
        public const Int32 dwForceRight = 0x3172F8C;
        public const Int32 dwGameDir = 0x6285F8;
        public const Int32 dwGameRulesProxy = 0x525E92C;
        public const Int32 dwGetAllClasses = 0xD53E6C;
        public const Int32 dwGlobalVars = 0x589AD0;
        public const Int32 dwGlowObjectManager = 0x52898B8;
        public const Int32 dwInput = 0x5192F80;
        public const Int32 dwInterfaceLinkList = 0x8F83F4;
        public const Int32 dwLocalPlayer = 0xD2DB84;
        public const Int32 dwMatchFound = 0x4CEE7375;
        public const Int32 dwMouseEnable = 0xD33728;
        public const Int32 dwMouseEnablePtr = 0xD336F8;
        public const Int32 dwPlayerResource = 0x317133C;
        public const Int32 dwRadarBase = 0x5176764;
        public const Int32 dwSensitivity = 0xD335C4;
        public const Int32 dwSensitivityPtr = 0xD33598;
        public const Int32 dwSetClanTag = 0x89E00;
        public const Int32 dwViewMatrix = 0x4D33334;
        public const Int32 dwWeaponTable = 0x5193A44;
        public const Int32 dwWeaponTableIndex = 0x324C;
        public const Int32 dwYawPtr = 0xD33388;
        public const Int32 dwZoomSensitivityRatioPtr = 0xD385D0;
        public const Int32 dwbSendPackets = 0xD3A0A;
        public const Int32 dwppDirect3DDevice9 = 0xA7030;
        public const Int32 find_hud_element = 0x2DD8C0A0;
        public const Int32 force_update_spectator_glow = 0x399022;
        public const Int32 interface_engine_cvar = 0x3E9EC;
        public const Int32 is_c4_owner = 0x3A57F0;
        public const Int32 m_bDormant = 0xED;
        public const Int32 m_flSpawnTime = 0xA360;
        public const Int32 m_pStudioHdr = 0x294C;
        public const Int32 m_pitchClassPtr = 0x5176A08;
        public const Int32 m_yawClassPtr = 0xD33388;
        public const Int32 model_ambient_min = 0x58CDEC;
        public const Int32 set_abs_angles = 0x1CF030;
        public const Int32 set_abs_origin = 0x1CEE70;
    }
} // namespace hazedumper
