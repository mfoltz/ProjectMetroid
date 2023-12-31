// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerGameBalanceSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServerGameBalanceSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_API_Version;
    private static readonly System.IntPtr NativeFieldInfoPtr_Version;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedResearch;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideVBloodUnitSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedAchievements;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleStatModifiers_Global;
    private static readonly System.IntPtr NativeFieldInfoPtr_StarterEquipmentId;
    private static readonly System.IntPtr NativeFieldInfoPtr_StarterResourcesId;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitModifiers_Global;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitModifiers_VBlood;
    private static readonly System.IntPtr NativeFieldInfoPtr_VampireModifiers;
    private static readonly System.IntPtr NativeFieldInfoPtr_EquipmentModifiers_Global;
    private static readonly System.IntPtr NativeFieldInfoPtr_JournalVBloodSourceUnitMaxDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_PvPVampireRespawnModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_InventoryStacksModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropTableModifier_General;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropTableModifier_Missions;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaterialYieldModifier_Global;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodEssenceYieldModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodDrainModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_DurabilityDrainModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_GarlicAreaStrengthModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_HolyAreaStrengthModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_SilverStrengthModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_SunDamageModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleBloodEssenceDrainModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleDecayRateModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleSiegeTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleUnderAttackTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleRaidTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleRaidProtectionTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxCastleRaidProtectionTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleForfeitFreeClaimTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuildCostModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipeCostModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_CraftRateModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResearchCostModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_RefinementCostModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_RefinementRateModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResearchTimeModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_DismantleResourceModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_Death_DurabilityFactorLoss;
    private static readonly System.IntPtr NativeFieldInfoPtr_Death_DurabilityLossFactorAsResources;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServantConvertRateModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_RepairCostModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_Trader_StockModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_Trader_PriceModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_Trader_RestockTimerModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_PvPProtectionMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameModeType;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleDamageMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerDamageMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeartDamageMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_SiegeWeaponHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeathContainerPermission;
    private static readonly System.IntPtr NativeFieldInfoPtr_RelicSpawnType;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerInteractionSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleMinimumDistanceInFloors;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllWaypointsUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllowGlobalChat;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodBoundEquipment;
    private static readonly System.IntPtr NativeFieldInfoPtr_FreeCastleDestroy;
    private static readonly System.IntPtr NativeFieldInfoPtr_FreeCastleClaim;
    private static readonly System.IntPtr NativeFieldInfoPtr_FreeCastleRaid;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnnounceSiegeWeaponSpawn;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowSiegeWeaponMapIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_TeleportBoundItems;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanLootEnemyContainers;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomizeVBloodSpawnLocations;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomizeVBloodAbilities;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomizeVBloodTechs;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ScrambleGameModeEnabled_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeBase_Private_Static_Void_byref_ServerGameBalanceSettings_byref_NetBufferOut_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeAdditional_Private_Static_Void_byref_ServerGameBalanceSettings_byref_NetBufferOut_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_ServerGameBalanceSettings_byref_NetBufferOut_SerializeType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeBase_Public_Static_Void_byref_ServerGameBalanceSettings_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeAdditional_Public_Static_Void_byref_ServerGameBalanceSettings_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_ServerGameBalanceSettings_byref_NetBufferIn_SerializeType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_ServerGameBalanceSettings_SingletonAccessor_1_ServerGameBalanceSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHardCore_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsVampirePvPEnabled_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsCastlePvPEnabled_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCastlePvPEnabled_Public_CastlePvPEnabledType_0;
    [FieldOffset(0)]
    public int Version;
    [FieldOffset(4)]
    public FixedListInt64 UnlockedResearch;
    [FieldOffset(68)]
    public FixedList512<VBloodUnitSetting.StructData> OverrideVBloodUnitSettings;
    [FieldOffset(580)]
    public FixedListInt512 UnlockedAchievements;
    [FieldOffset(1092)]
    public CastleStatModifiers CastleStatModifiers_Global;
    [FieldOffset(1228)]
    public int StarterEquipmentId;
    [FieldOffset(1232)]
    public int StarterResourcesId;
    [FieldOffset(1236)]
    public GameTimeModifiers.StructData GameTime;
    [FieldOffset(1246)]
    public UnitStatModifiers.StructData UnitModifiers_Global;
    [FieldOffset(1250)]
    public UnitStatModifiers.StructData UnitModifiers_VBlood;
    [FieldOffset(1254)]
    public VampireStatModifiers.StructData VampireModifiers;
    [FieldOffset(1270)]
    public EquipmentStatModifiers.StructData EquipmentModifiers_Global;
    [FieldOffset(1284)]
    public half JournalVBloodSourceUnitMaxDistance;
    [FieldOffset(1286)]
    public half PvPVampireRespawnModifier;
    [FieldOffset(1288)]
    public half InventoryStacksModifier;
    [FieldOffset(1290)]
    public half DropTableModifier_General;
    [FieldOffset(1292)]
    public half DropTableModifier_Missions;
    [FieldOffset(1294)]
    public half MaterialYieldModifier_Global;
    [FieldOffset(1296)]
    public half BloodEssenceYieldModifier;
    [FieldOffset(1298)]
    public half BloodDrainModifier;
    [FieldOffset(1300)]
    public half DurabilityDrainModifier;
    [FieldOffset(1302)]
    public half GarlicAreaStrengthModifier;
    [FieldOffset(1304)]
    public half HolyAreaStrengthModifier;
    [FieldOffset(1306)]
    public half SilverStrengthModifier;
    [FieldOffset(1308)]
    public half SunDamageModifier;
    [FieldOffset(1310)]
    public half CastleBloodEssenceDrainModifier;
    [FieldOffset(1312)]
    public half CastleDecayRateModifier;
    [FieldOffset(1314)]
    public half CastleSiegeTimer;
    [FieldOffset(1316)]
    public half CastleUnderAttackTimer;
    [FieldOffset(1318)]
    public half CastleRaidTimer;
    [FieldOffset(1320)]
    public float CastleRaidProtectionTime;
    [FieldOffset(1324)]
    public half CastleForfeitFreeClaimTimer;
    [FieldOffset(1326)]
    public half BuildCostModifier;
    [FieldOffset(1328)]
    public half RecipeCostModifier;
    [FieldOffset(1330)]
    public half CraftRateModifier;
    [FieldOffset(1332)]
    public half ResearchCostModifier;
    [FieldOffset(1334)]
    public half RefinementCostModifier;
    [FieldOffset(1336)]
    public half RefinementRateModifier;
    [FieldOffset(1338)]
    public half ResearchTimeModifier;
    [FieldOffset(1340)]
    public half DismantleResourceModifier;
    [FieldOffset(1342)]
    public half Death_DurabilityFactorLoss;
    [FieldOffset(1344)]
    public half Death_DurabilityLossFactorAsResources;
    [FieldOffset(1346)]
    public half ServantConvertRateModifier;
    [FieldOffset(1348)]
    public half RepairCostModifier;
    [FieldOffset(1350)]
    public half Trader_StockModifier;
    [FieldOffset(1352)]
    public half Trader_PriceModifier;
    [FieldOffset(1354)]
    public half Trader_RestockTimerModifier;
    [FieldOffset(1356)]
    public PvPProtectionMode PvPProtectionMode;
    [FieldOffset(1357)]
    public GameModeType GameModeType;
    [FieldOffset(1358)]
    public CastleDamageMode CastleDamageMode;
    [FieldOffset(1359)]
    public PlayerDamageMode PlayerDamageMode;
    [FieldOffset(1360)]
    public CastleHeartDamageMode CastleHeartDamageMode;
    [FieldOffset(1361)]
    public SiegeWeaponHealth SiegeWeaponHealth;
    [FieldOffset(1362)]
    public DeathContainerPermission DeathContainerPermission;
    [FieldOffset(1363)]
    public RelicSpawnType RelicSpawnType;
    [FieldOffset(1364)]
    public ProjectM.PlayerInteractionSettings.StructData PlayerInteractionSettings;
    [FieldOffset(1384)]
    public byte CastleMinimumDistanceInFloors;
    [FieldOffset(1385)]
    public byte ClanSize;
    [FieldOffset(1386)]
    public bool AllWaypointsUnlocked;
    [FieldOffset(1387)]
    public bool AllowGlobalChat;
    [FieldOffset(1388)]
    public bool BloodBoundEquipment;
    [FieldOffset(1389)]
    public bool FreeCastleDestroy;
    [FieldOffset(1390)]
    public bool FreeCastleClaim;
    [FieldOffset(1391)]
    public bool FreeCastleRaid;
    [FieldOffset(1392)]
    public bool AnnounceSiegeWeaponSpawn;
    [FieldOffset(1393)]
    public bool ShowSiegeWeaponMapIcon;
    [FieldOffset(1394)]
    public bool TeleportBoundItems;
    [FieldOffset(1395)]
    public bool CanLootEnemyContainers;
    [FieldOffset(1396)]
    public bool RandomizeVBloodSpawnLocations;
    [FieldOffset(1397)]
    public bool RandomizeVBloodAbilities;
    [FieldOffset(1398)]
    public bool RandomizeVBloodTechs;

    public unsafe bool ScrambleGameModeEnabled
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 758061, RefRangeEnd = 758064, XrefRangeStart = 758061, XrefRangeEnd = 758061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameBalanceSettings.NativeMethodInfoPtr_get_ScrambleGameModeEnabled_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 758138, RefRangeEnd = 758139, XrefRangeStart = 758064, XrefRangeEnd = 758138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SerializeBase(
      [In] ref ServerGameBalanceSettings settings,
      ref NetBufferOut netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref settings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameBalanceSettings.NativeMethodInfoPtr_SerializeBase_Private_Static_Void_byref_ServerGameBalanceSettings_byref_NetBufferOut_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758139, XrefRangeEnd = 758147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SerializeAdditional(
      [In] ref ServerGameBalanceSettings settings,
      ref NetBufferOut netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref settings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameBalanceSettings.NativeMethodInfoPtr_SerializeAdditional_Private_Static_Void_byref_ServerGameBalanceSettings_byref_NetBufferOut_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 758157, RefRangeEnd = 758162, XrefRangeStart = 758147, XrefRangeEnd = 758157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Serialize(
      [In] ref ServerGameBalanceSettings settings,
      ref NetBufferOut netBuffer,
      ServerGameBalanceSettings.SerializeType serializeType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref settings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &serializeType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameBalanceSettings.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_ServerGameBalanceSettings_byref_NetBufferOut_SerializeType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 758247, RefRangeEnd = 758248, XrefRangeStart = 758162, XrefRangeEnd = 758247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DeserializeBase(
      ref ServerGameBalanceSettings output,
      ref NetBufferIn netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref output;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameBalanceSettings.NativeMethodInfoPtr_DeserializeBase_Public_Static_Void_byref_ServerGameBalanceSettings_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758248, XrefRangeEnd = 758263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DeserializeAdditional(
      ref ServerGameBalanceSettings output,
      ref NetBufferIn netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref output;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameBalanceSettings.NativeMethodInfoPtr_DeserializeAdditional_Public_Static_Void_byref_ServerGameBalanceSettings_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 758281, RefRangeEnd = 758285, XrefRangeStart = 758263, XrefRangeEnd = 758281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ServerGameBalanceSettings Deserialize(
      ref NetBufferIn netBuffer,
      ServerGameBalanceSettings.SerializeType serializeType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &serializeType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameBalanceSettings.NativeMethodInfoPtr_Deserialize_Public_Static_ServerGameBalanceSettings_byref_NetBufferIn_SerializeType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ServerGameBalanceSettings*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 758328, RefRangeEnd = 758329, XrefRangeStart = 758285, XrefRangeEnd = 758328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ServerGameBalanceSettings.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(25)]
    [CachedScanResults(RefRangeStart = 758334, RefRangeEnd = 758359, XrefRangeStart = 758329, XrefRangeEnd = 758334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ServerGameBalanceSettings Get(
      SingletonAccessor<ServerGameBalanceSettings> serverGameBalanceSettings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &serverGameBalanceSettings;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameBalanceSettings.NativeMethodInfoPtr_Get_Public_Static_ServerGameBalanceSettings_SingletonAccessor_1_ServerGameBalanceSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ServerGameBalanceSettings*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 758359, RefRangeEnd = 758361, XrefRangeStart = 758359, XrefRangeEnd = 758359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsHardCore()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameBalanceSettings.NativeMethodInfoPtr_IsHardCore_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 758362, RefRangeEnd = 758369, XrefRangeStart = 758361, XrefRangeEnd = 758362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsVampirePvPEnabled()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameBalanceSettings.NativeMethodInfoPtr_IsVampirePvPEnabled_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 758370, RefRangeEnd = 758372, XrefRangeStart = 758369, XrefRangeEnd = 758370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsCastlePvPEnabled()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameBalanceSettings.NativeMethodInfoPtr_IsCastlePvPEnabled_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 758373, RefRangeEnd = 758374, XrefRangeStart = 758372, XrefRangeEnd = 758373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerGameBalanceSettings.CastlePvPEnabledType GetCastlePvPEnabled()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameBalanceSettings.NativeMethodInfoPtr_GetCastlePvPEnabled_Public_CastlePvPEnabledType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ServerGameBalanceSettings.CastlePvPEnabledType*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ServerGameBalanceSettings()
    {
      Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ServerGameBalanceSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr);
      ServerGameBalanceSettings.NativeFieldInfoPtr_API_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (API_Version));
      ServerGameBalanceSettings.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (Version));
      ServerGameBalanceSettings.NativeFieldInfoPtr_UnlockedResearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (UnlockedResearch));
      ServerGameBalanceSettings.NativeFieldInfoPtr_OverrideVBloodUnitSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (OverrideVBloodUnitSettings));
      ServerGameBalanceSettings.NativeFieldInfoPtr_UnlockedAchievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (UnlockedAchievements));
      ServerGameBalanceSettings.NativeFieldInfoPtr_CastleStatModifiers_Global = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (CastleStatModifiers_Global));
      ServerGameBalanceSettings.NativeFieldInfoPtr_StarterEquipmentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (StarterEquipmentId));
      ServerGameBalanceSettings.NativeFieldInfoPtr_StarterResourcesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (StarterResourcesId));
      ServerGameBalanceSettings.NativeFieldInfoPtr_GameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (GameTime));
      ServerGameBalanceSettings.NativeFieldInfoPtr_UnitModifiers_Global = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (UnitModifiers_Global));
      ServerGameBalanceSettings.NativeFieldInfoPtr_UnitModifiers_VBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (UnitModifiers_VBlood));
      ServerGameBalanceSettings.NativeFieldInfoPtr_VampireModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (VampireModifiers));
      ServerGameBalanceSettings.NativeFieldInfoPtr_EquipmentModifiers_Global = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (EquipmentModifiers_Global));
      ServerGameBalanceSettings.NativeFieldInfoPtr_JournalVBloodSourceUnitMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (JournalVBloodSourceUnitMaxDistance));
      ServerGameBalanceSettings.NativeFieldInfoPtr_PvPVampireRespawnModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (PvPVampireRespawnModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_InventoryStacksModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (InventoryStacksModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_DropTableModifier_General = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (DropTableModifier_General));
      ServerGameBalanceSettings.NativeFieldInfoPtr_DropTableModifier_Missions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (DropTableModifier_Missions));
      ServerGameBalanceSettings.NativeFieldInfoPtr_MaterialYieldModifier_Global = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (MaterialYieldModifier_Global));
      ServerGameBalanceSettings.NativeFieldInfoPtr_BloodEssenceYieldModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (BloodEssenceYieldModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_BloodDrainModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (BloodDrainModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_DurabilityDrainModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (DurabilityDrainModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_GarlicAreaStrengthModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (GarlicAreaStrengthModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_HolyAreaStrengthModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (HolyAreaStrengthModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_SilverStrengthModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (SilverStrengthModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_SunDamageModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (SunDamageModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_CastleBloodEssenceDrainModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (CastleBloodEssenceDrainModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_CastleDecayRateModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (CastleDecayRateModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_CastleSiegeTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (CastleSiegeTimer));
      ServerGameBalanceSettings.NativeFieldInfoPtr_CastleUnderAttackTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (CastleUnderAttackTimer));
      ServerGameBalanceSettings.NativeFieldInfoPtr_CastleRaidTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (CastleRaidTimer));
      ServerGameBalanceSettings.NativeFieldInfoPtr_CastleRaidProtectionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (CastleRaidProtectionTime));
      ServerGameBalanceSettings.NativeFieldInfoPtr_MaxCastleRaidProtectionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (MaxCastleRaidProtectionTime));
      ServerGameBalanceSettings.NativeFieldInfoPtr_CastleForfeitFreeClaimTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (CastleForfeitFreeClaimTimer));
      ServerGameBalanceSettings.NativeFieldInfoPtr_BuildCostModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (BuildCostModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_RecipeCostModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (RecipeCostModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_CraftRateModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (CraftRateModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_ResearchCostModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (ResearchCostModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_RefinementCostModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (RefinementCostModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_RefinementRateModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (RefinementRateModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_ResearchTimeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (ResearchTimeModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_DismantleResourceModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (DismantleResourceModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_Death_DurabilityFactorLoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (Death_DurabilityFactorLoss));
      ServerGameBalanceSettings.NativeFieldInfoPtr_Death_DurabilityLossFactorAsResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (Death_DurabilityLossFactorAsResources));
      ServerGameBalanceSettings.NativeFieldInfoPtr_ServantConvertRateModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (ServantConvertRateModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_RepairCostModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (RepairCostModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_Trader_StockModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (Trader_StockModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_Trader_PriceModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (Trader_PriceModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_Trader_RestockTimerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (Trader_RestockTimerModifier));
      ServerGameBalanceSettings.NativeFieldInfoPtr_PvPProtectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (PvPProtectionMode));
      ServerGameBalanceSettings.NativeFieldInfoPtr_GameModeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (GameModeType));
      ServerGameBalanceSettings.NativeFieldInfoPtr_CastleDamageMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (CastleDamageMode));
      ServerGameBalanceSettings.NativeFieldInfoPtr_PlayerDamageMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (PlayerDamageMode));
      ServerGameBalanceSettings.NativeFieldInfoPtr_CastleHeartDamageMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (CastleHeartDamageMode));
      ServerGameBalanceSettings.NativeFieldInfoPtr_SiegeWeaponHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (SiegeWeaponHealth));
      ServerGameBalanceSettings.NativeFieldInfoPtr_DeathContainerPermission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (DeathContainerPermission));
      ServerGameBalanceSettings.NativeFieldInfoPtr_RelicSpawnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (RelicSpawnType));
      ServerGameBalanceSettings.NativeFieldInfoPtr_PlayerInteractionSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (PlayerInteractionSettings));
      ServerGameBalanceSettings.NativeFieldInfoPtr_CastleMinimumDistanceInFloors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (CastleMinimumDistanceInFloors));
      ServerGameBalanceSettings.NativeFieldInfoPtr_ClanSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (ClanSize));
      ServerGameBalanceSettings.NativeFieldInfoPtr_AllWaypointsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (AllWaypointsUnlocked));
      ServerGameBalanceSettings.NativeFieldInfoPtr_AllowGlobalChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (AllowGlobalChat));
      ServerGameBalanceSettings.NativeFieldInfoPtr_BloodBoundEquipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (BloodBoundEquipment));
      ServerGameBalanceSettings.NativeFieldInfoPtr_FreeCastleDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (FreeCastleDestroy));
      ServerGameBalanceSettings.NativeFieldInfoPtr_FreeCastleClaim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (FreeCastleClaim));
      ServerGameBalanceSettings.NativeFieldInfoPtr_FreeCastleRaid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (FreeCastleRaid));
      ServerGameBalanceSettings.NativeFieldInfoPtr_AnnounceSiegeWeaponSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (AnnounceSiegeWeaponSpawn));
      ServerGameBalanceSettings.NativeFieldInfoPtr_ShowSiegeWeaponMapIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (ShowSiegeWeaponMapIcon));
      ServerGameBalanceSettings.NativeFieldInfoPtr_TeleportBoundItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (TeleportBoundItems));
      ServerGameBalanceSettings.NativeFieldInfoPtr_CanLootEnemyContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (CanLootEnemyContainers));
      ServerGameBalanceSettings.NativeFieldInfoPtr_RandomizeVBloodSpawnLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (RandomizeVBloodSpawnLocations));
      ServerGameBalanceSettings.NativeFieldInfoPtr_RandomizeVBloodAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (RandomizeVBloodAbilities));
      ServerGameBalanceSettings.NativeFieldInfoPtr_RandomizeVBloodTechs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, nameof (RandomizeVBloodTechs));
      ServerGameBalanceSettings.NativeMethodInfoPtr_get_ScrambleGameModeEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, 100666906);
      ServerGameBalanceSettings.NativeMethodInfoPtr_SerializeBase_Private_Static_Void_byref_ServerGameBalanceSettings_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, 100666907);
      ServerGameBalanceSettings.NativeMethodInfoPtr_SerializeAdditional_Private_Static_Void_byref_ServerGameBalanceSettings_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, 100666908);
      ServerGameBalanceSettings.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_ServerGameBalanceSettings_byref_NetBufferOut_SerializeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, 100666909);
      ServerGameBalanceSettings.NativeMethodInfoPtr_DeserializeBase_Public_Static_Void_byref_ServerGameBalanceSettings_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, 100666910);
      ServerGameBalanceSettings.NativeMethodInfoPtr_DeserializeAdditional_Public_Static_Void_byref_ServerGameBalanceSettings_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, 100666911);
      ServerGameBalanceSettings.NativeMethodInfoPtr_Deserialize_Public_Static_ServerGameBalanceSettings_byref_NetBufferIn_SerializeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, 100666912);
      ServerGameBalanceSettings.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, 100666913);
      ServerGameBalanceSettings.NativeMethodInfoPtr_Get_Public_Static_ServerGameBalanceSettings_SingletonAccessor_1_ServerGameBalanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, 100666914);
      ServerGameBalanceSettings.NativeMethodInfoPtr_IsHardCore_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, 100666915);
      ServerGameBalanceSettings.NativeMethodInfoPtr_IsVampirePvPEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, 100666916);
      ServerGameBalanceSettings.NativeMethodInfoPtr_IsCastlePvPEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, 100666917);
      ServerGameBalanceSettings.NativeMethodInfoPtr_GetCastlePvPEnabled_Public_CastlePvPEnabledType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, 100666918);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerGameBalanceSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int API_Version
    {
      get
      {
        int apiVersion;
        IL2CPP.il2cpp_field_static_get_value(ServerGameBalanceSettings.NativeFieldInfoPtr_API_Version, (void*) &apiVersion);
        return apiVersion;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerGameBalanceSettings.NativeFieldInfoPtr_API_Version, (void*) &value);
      }
    }

    public static unsafe float MaxCastleRaidProtectionTime
    {
      get
      {
        float raidProtectionTime;
        IL2CPP.il2cpp_field_static_get_value(ServerGameBalanceSettings.NativeFieldInfoPtr_MaxCastleRaidProtectionTime, (void*) &raidProtectionTime);
        return raidProtectionTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerGameBalanceSettings.NativeFieldInfoPtr_MaxCastleRaidProtectionTime, (void*) &value);
      }
    }

    public enum SerializeType
    {
      Whole,
      Limited,
    }

    public enum CastlePvPEnabledType
    {
      Enabled = 1,
      Disabled_Never = 2,
      Disabled_OutsideOfTimeSpan = 3,
    }
  }
}
