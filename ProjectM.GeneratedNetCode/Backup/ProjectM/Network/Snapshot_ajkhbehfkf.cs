// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_ajkhbehfkf
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_ajkhbehfkf
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleWorkstation_WorkstationLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreatedTime_CreateTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_DismantleDestroyData_WasDismantled;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_IsDead;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_MaxRecoveryHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_TimeOfDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_InteractedUpon_Interacting;
    private static readonly System.IntPtr NativeFieldInfoPtr_LightningRodStation_ProcessingRecipe;
    private static readonly System.IntPtr NativeFieldInfoPtr_LightningRodStation_Progress;
    private static readonly System.IntPtr NativeFieldInfoPtr_LightningRodStation_State;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Pos;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_StaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_UseStaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_StationServants_Servants;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Health_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Health_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LightningRodStation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LightningRodStation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StationServants_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StationServants_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LightningRodStation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StationServants;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation_WorkstationLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_CreatedTime_CreateTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData_WasDismantled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LightningRodStation_ProcessingRecipe;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LightningRodStation_Progress;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LightningRodStation_State;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StationServants_Servants;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CastleWorkstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CastleWorkstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_LightningRodStation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_LightningRodStation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_StationServants;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_StationServants;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CastleWorkstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_CreatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_DismantleDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_LightningRodStation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_StationServants;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TileModel;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public ModifiableLong BuffableFlagState_Value;
    [FieldOffset(24)]
    public WorkstationLevel CastleWorkstation_WorkstationLevel;
    [FieldOffset(25)]
    public double CreatedTime_CreateTime;
    [FieldOffset(33)]
    public bool DismantleDestroyData_WasDismantled;
    [FieldOffset(34)]
    public bool Health_IsDead;
    [FieldOffset(35)]
    public ModifiableFloat Health_MaxHealth;
    [FieldOffset(43)]
    public float Health_MaxRecoveryHealth;
    [FieldOffset(47)]
    public double Health_TimeOfDeath;
    [FieldOffset(55)]
    public float Health_Value;
    [FieldOffset(59)]
    public bool InteractedUpon_Interacting;
    [FieldOffset(60)]
    public PrefabGUID LightningRodStation_ProcessingRecipe;
    [FieldOffset(64)]
    public float LightningRodStation_Progress;
    [FieldOffset(68)]
    public LightningRodStationState LightningRodStation_State;
    [FieldOffset(72)]
    public float StaticTransformCompatible_NonStaticTransform_Height;
    [FieldOffset(76)]
    public float2 StaticTransformCompatible_NonStaticTransform_Pos;
    [FieldOffset(84)]
    public TileRotation StaticTransformCompatible_NonStaticTransform_Rotation;
    [FieldOffset(85)]
    public StaticTransformIndex StaticTransformCompatible_StaticTransform;
    [FieldOffset(97)]
    public bool StaticTransformCompatible_UseStaticTransform;
    [FieldOffset(98)]
    public ServantType StationServants_Servants;
    [FieldOffset(102)]
    public int Team_FactionIndex;
    [FieldOffset(106)]
    public int Team_Value;
    [FieldOffset(110)]
    public ProjectM.TileType TileModel_DisabledTileTypes;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1552910, XrefRangeEnd = 1553041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeSnapshot(
      ref NetBufferOut netBuffer,
      SnapshotFrameChangedBuffer* frameChanged,
      ref SerializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) frameChanged;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_ajkhbehfkf.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1553106, RefRangeEnd = 1553107, XrefRangeStart = 1553041, XrefRangeEnd = 1553106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_ajkhbehfkf.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_ajkhbehfkf()
    {
      Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_ajkhbehfkf));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr);
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (BuffableFlagState_Value));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CastleWorkstation_WorkstationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (CastleWorkstation_WorkstationLevel));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CreatedTime_CreateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (CreatedTime_CreateTime));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_DismantleDestroyData_WasDismantled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (DismantleDestroyData_WasDismantled));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_Health_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (Health_IsDead));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_Health_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (Health_MaxHealth));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_Health_MaxRecoveryHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (Health_MaxRecoveryHealth));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_Health_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (Health_TimeOfDeath));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_Health_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (Health_Value));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (InteractedUpon_Interacting));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_LightningRodStation_ProcessingRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (LightningRodStation_ProcessingRecipe));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_LightningRodStation_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (LightningRodStation_Progress));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_LightningRodStation_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (LightningRodStation_State));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (StaticTransformCompatible_StaticTransform));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (StaticTransformCompatible_UseStaticTransform));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_StationServants_Servants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (StationServants_Servants));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (Team_Value));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (TileModel_DisabledTileTypes));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Start));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Count));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_CastleWorkstation_Start));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_CastleWorkstation_Count));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_CreatedTime_Start));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_CreatedTime_Count));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_DismantleDestroyData_Start));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_DismantleDestroyData_Count));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_Health_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_Health_Start));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_Health_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_Health_Count));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Start));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Count));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_LightningRodStation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_LightningRodStation_Start));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_LightningRodStation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_LightningRodStation_Count));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Start));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Count));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_StationServants_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_StationServants_Start));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_StationServants_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_StationServants_Count));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Start));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Count));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_CastleWorkstation));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_CreatedTime));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_DismantleDestroyData));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_Health));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_LightningRodStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_LightningRodStation));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StationServants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_StationServants));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_TileModel));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState_Value));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation_WorkstationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_CastleWorkstation_WorkstationLevel));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime_CreateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_CreatedTime_CreateTime));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData_WasDismantled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_DismantleDestroyData_WasDismantled));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_Health_IsDead));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_Health_MaxHealth));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_Health_MaxRecoveryHealth));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_Health_TimeOfDeath));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Health_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_Health_Value));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon_Interacting));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_LightningRodStation_ProcessingRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_LightningRodStation_ProcessingRecipe));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_LightningRodStation_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_LightningRodStation_Progress));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_LightningRodStation_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_LightningRodStation_State));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_StaticTransform));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_UseStaticTransform));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StationServants_Servants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_StationServants_Servants));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (FrameChangedIndex_TileModel_DisabledTileTypes));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataStartOffset_BuffableFlagState));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataSize_BuffableFlagState));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_CastleWorkstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataStartOffset_CastleWorkstation));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_CastleWorkstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataSize_CastleWorkstation));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataStartOffset_CreatedTime));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataSize_CreatedTime));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataStartOffset_DismantleDestroyData));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataSize_DismantleDestroyData));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataStartOffset_Health));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataSize_Health));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataStartOffset_InteractedUpon));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataSize_InteractedUpon));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_LightningRodStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataStartOffset_LightningRodStation));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_LightningRodStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataSize_LightningRodStation));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataStartOffset_StaticTransformCompatible));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataSize_StaticTransformCompatible));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_StationServants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataStartOffset_StationServants));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_StationServants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataSize_StationServants));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataStartOffset_TileModel));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (ComponentDataSize_TileModel));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (CompBit_BuffableFlagState));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_CastleWorkstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (CompBit_CastleWorkstation));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (CompBit_CreatedTime));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_DismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (CompBit_DismantleDestroyData));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (CompBit_Health));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (CompBit_InteractedUpon));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_LightningRodStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (CompBit_LightningRodStation));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (CompBit_StaticTransformCompatible));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_StationServants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (CompBit_StationServants));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, nameof (CompBit_TileModel));
      Snapshot_ajkhbehfkf.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, 100664412);
      Snapshot_ajkhbehfkf.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, 100664413);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_ajkhbehfkf>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Start
    {
      get
      {
        int buffableFlagStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &buffableFlagStateStart);
        return buffableFlagStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Count
    {
      get
      {
        int buffableFlagStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &buffableFlagStateCount);
        return buffableFlagStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleWorkstation_Start
    {
      get
      {
        int workstationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Start, (void*) &workstationStart);
        return workstationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CastleWorkstation_Count
    {
      get
      {
        int workstationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Count, (void*) &workstationCount);
        return workstationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_CastleWorkstation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CreatedTime_Start
    {
      get
      {
        int createdTimeStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start, (void*) &createdTimeStart);
        return createdTimeStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_CreatedTime_Count
    {
      get
      {
        int createdTimeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count, (void*) &createdTimeCount);
        return createdTimeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_CreatedTime_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DismantleDestroyData_Start
    {
      get
      {
        int destroyDataStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start, (void*) &destroyDataStart);
        return destroyDataStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DismantleDestroyData_Count
    {
      get
      {
        int destroyDataCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count, (void*) &destroyDataCount);
        return destroyDataCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_DismantleDestroyData_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Health_Start
    {
      get
      {
        int fieldsHealthStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_Health_Start, (void*) &fieldsHealthStart);
        return fieldsHealthStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_Health_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Health_Count
    {
      get
      {
        int fieldsHealthCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_Health_Count, (void*) &fieldsHealthCount);
        return fieldsHealthCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_Health_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Start
    {
      get
      {
        int interactedUponStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &interactedUponStart);
        return interactedUponStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Count
    {
      get
      {
        int interactedUponCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &interactedUponCount);
        return interactedUponCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LightningRodStation_Start
    {
      get
      {
        int lightningRodStationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_LightningRodStation_Start, (void*) &lightningRodStationStart);
        return lightningRodStationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_LightningRodStation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LightningRodStation_Count
    {
      get
      {
        int lightningRodStationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_LightningRodStation_Count, (void*) &lightningRodStationCount);
        return lightningRodStationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_LightningRodStation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Start
    {
      get
      {
        int transformCompatibleStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &transformCompatibleStart);
        return transformCompatibleStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Count
    {
      get
      {
        int transformCompatibleCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &transformCompatibleCount);
        return transformCompatibleCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StationServants_Start
    {
      get
      {
        int stationServantsStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_StationServants_Start, (void*) &stationServantsStart);
        return stationServantsStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_StationServants_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StationServants_Count
    {
      get
      {
        int stationServantsCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_StationServants_Count, (void*) &stationServantsCount);
        return stationServantsCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_StationServants_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Start
    {
      get
      {
        int fieldsTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &fieldsTileModelStart);
        return fieldsTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Count
    {
      get
      {
        int fieldsTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &fieldsTileModelCount);
        return fieldsTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleWorkstation
    {
      get
      {
        int castleWorkstation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation, (void*) &castleWorkstation);
        return castleWorkstation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CreatedTime
    {
      get
      {
        int indexCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime, (void*) &indexCreatedTime);
        return indexCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DismantleDestroyData
    {
      get
      {
        int dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health
    {
      get
      {
        int changedIndexHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Health, (void*) &changedIndexHealth);
        return changedIndexHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Health, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon
    {
      get
      {
        int indexInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &indexInteractedUpon);
        return indexInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LightningRodStation
    {
      get
      {
        int lightningRodStation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_LightningRodStation, (void*) &lightningRodStation);
        return lightningRodStation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_LightningRodStation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StationServants
    {
      get
      {
        int indexStationServants;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StationServants, (void*) &indexStationServants);
        return indexStationServants;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StationServants, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel
    {
      get
      {
        int changedIndexTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &changedIndexTileModel);
        return changedIndexTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState_Value
    {
      get
      {
        int buffableFlagStateValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &buffableFlagStateValue);
        return buffableFlagStateValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CastleWorkstation_WorkstationLevel
    {
      get
      {
        int workstationLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation_WorkstationLevel, (void*) &workstationLevel);
        return workstationLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_CastleWorkstation_WorkstationLevel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_CreatedTime_CreateTime
    {
      get
      {
        int createdTimeCreateTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime_CreateTime, (void*) &createdTimeCreateTime);
        return createdTimeCreateTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_CreatedTime_CreateTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DismantleDestroyData_WasDismantled
    {
      get
      {
        int dataWasDismantled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData_WasDismantled, (void*) &dataWasDismantled);
        return dataWasDismantled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_DismantleDestroyData_WasDismantled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_IsDead
    {
      get
      {
        int indexHealthIsDead;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead, (void*) &indexHealthIsDead);
        return indexHealthIsDead;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_MaxHealth
    {
      get
      {
        int indexHealthMaxHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth, (void*) &indexHealthMaxHealth);
        return indexHealthMaxHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_MaxRecoveryHealth
    {
      get
      {
        int maxRecoveryHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth, (void*) &maxRecoveryHealth);
        return maxRecoveryHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_TimeOfDeath
    {
      get
      {
        int healthTimeOfDeath;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath, (void*) &healthTimeOfDeath);
        return healthTimeOfDeath;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_Value
    {
      get
      {
        int indexHealthValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Health_Value, (void*) &indexHealthValue);
        return indexHealthValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Health_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon_Interacting
    {
      get
      {
        int interactedUponInteracting;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &interactedUponInteracting);
        return interactedUponInteracting;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LightningRodStation_ProcessingRecipe
    {
      get
      {
        int processingRecipe;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_LightningRodStation_ProcessingRecipe, (void*) &processingRecipe);
        return processingRecipe;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_LightningRodStation_ProcessingRecipe, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LightningRodStation_Progress
    {
      get
      {
        int rodStationProgress;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_LightningRodStation_Progress, (void*) &rodStationProgress);
        return rodStationProgress;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_LightningRodStation_Progress, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LightningRodStation_State
    {
      get
      {
        int lightningRodStationState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_LightningRodStation_State, (void*) &lightningRodStationState);
        return lightningRodStationState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_LightningRodStation_State, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height
    {
      get
      {
        int staticTransformHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &staticTransformHeight);
        return staticTransformHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos
    {
      get
      {
        int staticTransformPos;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &staticTransformPos);
        return staticTransformPos;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation
    {
      get
      {
        int transformRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &transformRotation);
        return transformRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_StaticTransform
    {
      get
      {
        int compatibleStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &compatibleStaticTransform);
        return compatibleStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_UseStaticTransform
    {
      get
      {
        int useStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &useStaticTransform);
        return useStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StationServants_Servants
    {
      get
      {
        int servantsServants;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StationServants_Servants, (void*) &servantsServants);
        return servantsServants;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_StationServants_Servants, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel_DisabledTileTypes
    {
      get
      {
        int disabledTileTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &disabledTileTypes);
        return disabledTileTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CastleWorkstation
    {
      get
      {
        int castleWorkstation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_CastleWorkstation, (void*) &castleWorkstation);
        return castleWorkstation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_CastleWorkstation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CastleWorkstation
    {
      get
      {
        int castleWorkstation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_CastleWorkstation, (void*) &castleWorkstation);
        return castleWorkstation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_CastleWorkstation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_CreatedTime
    {
      get
      {
        int offsetCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime, (void*) &offsetCreatedTime);
        return offsetCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_CreatedTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_CreatedTime
    {
      get
      {
        int dataSizeCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_CreatedTime, (void*) &dataSizeCreatedTime);
        return dataSizeCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_CreatedTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_DismantleDestroyData
    {
      get
      {
        int dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_DismantleDestroyData
    {
      get
      {
        int dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Health
    {
      get
      {
        int startOffsetHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_Health, (void*) &startOffsetHealth);
        return startOffsetHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_Health, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Health
    {
      get
      {
        int componentDataSizeHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_Health, (void*) &componentDataSizeHealth);
        return componentDataSizeHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_Health, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_InteractedUpon
    {
      get
      {
        int offsetInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &offsetInteractedUpon);
        return offsetInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_InteractedUpon
    {
      get
      {
        int sizeInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &sizeInteractedUpon);
        return sizeInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_LightningRodStation
    {
      get
      {
        int lightningRodStation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_LightningRodStation, (void*) &lightningRodStation);
        return lightningRodStation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_LightningRodStation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_LightningRodStation
    {
      get
      {
        int lightningRodStation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_LightningRodStation, (void*) &lightningRodStation);
        return lightningRodStation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_LightningRodStation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_StationServants
    {
      get
      {
        int offsetStationServants;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_StationServants, (void*) &offsetStationServants);
        return offsetStationServants;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_StationServants, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_StationServants
    {
      get
      {
        int sizeStationServants;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_StationServants, (void*) &sizeStationServants);
        return sizeStationServants;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_StationServants, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TileModel
    {
      get
      {
        int startOffsetTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &startOffsetTileModel);
        return startOffsetTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TileModel
    {
      get
      {
        int dataSizeTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &dataSizeTileModel);
        return dataSizeTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_BuffableFlagState
    {
      get
      {
        ulong buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CastleWorkstation
    {
      get
      {
        ulong castleWorkstation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_CastleWorkstation, (void*) &castleWorkstation);
        return castleWorkstation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_CastleWorkstation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_CreatedTime
    {
      get
      {
        ulong compBitCreatedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_CreatedTime, (void*) &compBitCreatedTime);
        return compBitCreatedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_CreatedTime, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_DismantleDestroyData
    {
      get
      {
        ulong dismantleDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_DismantleDestroyData, (void*) &dismantleDestroyData);
        return dismantleDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_DismantleDestroyData, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Health
    {
      get
      {
        ulong compBitHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_Health, (void*) &compBitHealth);
        return compBitHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_Health, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_InteractedUpon
    {
      get
      {
        ulong bitInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &bitInteractedUpon);
        return bitInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_LightningRodStation
    {
      get
      {
        ulong lightningRodStation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_LightningRodStation, (void*) &lightningRodStation);
        return lightningRodStation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_LightningRodStation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_StaticTransformCompatible
    {
      get
      {
        ulong transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_StationServants
    {
      get
      {
        ulong bitStationServants;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_StationServants, (void*) &bitStationServants);
        return bitStationServants;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_StationServants, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TileModel
    {
      get
      {
        ulong compBitTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_TileModel, (void*) &compBitTileModel);
        return compBitTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ajkhbehfkf.NativeFieldInfoPtr_CompBit_TileModel, (void*) &value);
      }
    }
  }
}
