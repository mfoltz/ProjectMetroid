// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_acidjkkbgbk
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.CastleBuilding.Placement;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_acidjkkbgbk
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_IsDead;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_MaxRecoveryHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_TimeOfDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlacementDestroyData_DestroyReason;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpiderCocoon_DataShared_Activated;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_Translation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Health_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Health_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Rotation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Rotation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpiderCocoon_DataShared_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpiderCocoon_DataShared_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Translation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Translation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpiderCocoon_DataShared;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Health_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData_DestroyReason;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpiderCocoon_DataShared_Activated;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Translation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_PlacementDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_PlacementDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_SpiderCocoon_DataShared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_SpiderCocoon_DataShared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_PlacementDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_SpiderCocoon_DataShared;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Translation;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public ModifiableLong BuffableFlagState_Value;
    [FieldOffset(24)]
    public bool Health_IsDead;
    [FieldOffset(25)]
    public ModifiableFloat Health_MaxHealth;
    [FieldOffset(33)]
    public float Health_MaxRecoveryHealth;
    [FieldOffset(37)]
    public double Health_TimeOfDeath;
    [FieldOffset(45)]
    public float Health_Value;
    [FieldOffset(49)]
    public TileModelDestroyReason PlacementDestroyData_DestroyReason;
    [FieldOffset(53)]
    public quaternion Rotation_Value;
    [FieldOffset(69)]
    public bool SpiderCocoon_DataShared_Activated;
    [FieldOffset(70)]
    public int Team_FactionIndex;
    [FieldOffset(74)]
    public int Team_Value;
    [FieldOffset(78)]
    public TileType TileModel_DisabledTileTypes;
    [FieldOffset(79)]
    public float3 Translation_Value;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1534955, XrefRangeEnd = 1535072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acidjkkbgbk.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1535120, RefRangeEnd = 1535121, XrefRangeStart = 1535072, XrefRangeEnd = 1535120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acidjkkbgbk.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_acidjkkbgbk()
    {
      Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_acidjkkbgbk));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr);
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (BuffableFlagState_Value));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_Health_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (Health_IsDead));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_Health_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (Health_MaxHealth));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_Health_MaxRecoveryHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (Health_MaxRecoveryHealth));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_Health_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (Health_TimeOfDeath));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_Health_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (Health_Value));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_PlacementDestroyData_DestroyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (PlacementDestroyData_DestroyReason));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_Rotation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (Rotation_Value));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_SpiderCocoon_DataShared_Activated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (SpiderCocoon_DataShared_Activated));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (Team_Value));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (TileModel_DisabledTileTypes));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_Translation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (Translation_Value));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Start));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Count));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Health_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedFields_Health_Start));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Health_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedFields_Health_Count));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedFields_PlacementDestroyData_Start));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedFields_PlacementDestroyData_Count));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedFields_Rotation_Start));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedFields_Rotation_Count));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_SpiderCocoon_DataShared_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedFields_SpiderCocoon_DataShared_Start));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_SpiderCocoon_DataShared_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedFields_SpiderCocoon_DataShared_Count));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Start));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Count));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Translation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedFields_Translation_Start));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Translation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedFields_Translation_Count));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_Health));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_PlacementDestroyData));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_Rotation));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_SpiderCocoon_DataShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_SpiderCocoon_DataShared));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_TileModel));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_Translation));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState_Value));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_Health_IsDead));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_Health_MaxHealth));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_Health_MaxRecoveryHealth));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_Health_TimeOfDeath));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Health_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_Health_Value));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData_DestroyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_PlacementDestroyData_DestroyReason));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_Rotation_Value));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_SpiderCocoon_DataShared_Activated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_SpiderCocoon_DataShared_Activated));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_TileModel_DisabledTileTypes));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (FrameChangedIndex_Translation_Value));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (ComponentDataStartOffset_BuffableFlagState));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (ComponentDataSize_BuffableFlagState));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (ComponentDataStartOffset_Health));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (ComponentDataSize_Health));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_PlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (ComponentDataStartOffset_PlacementDestroyData));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_PlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (ComponentDataSize_PlacementDestroyData));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (ComponentDataStartOffset_Rotation));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (ComponentDataSize_Rotation));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_SpiderCocoon_DataShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (ComponentDataStartOffset_SpiderCocoon_DataShared));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_SpiderCocoon_DataShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (ComponentDataSize_SpiderCocoon_DataShared));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (ComponentDataStartOffset_TileModel));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (ComponentDataSize_TileModel));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (ComponentDataStartOffset_Translation));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (ComponentDataSize_Translation));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (CompBit_BuffableFlagState));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (CompBit_Health));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_PlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (CompBit_PlacementDestroyData));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (CompBit_Rotation));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_SpiderCocoon_DataShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (CompBit_SpiderCocoon_DataShared));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (CompBit_TileModel));
      Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, nameof (CompBit_Translation));
      Snapshot_acidjkkbgbk.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, 100664244);
      Snapshot_acidjkkbgbk.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, 100664245);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_acidjkkbgbk>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Start
    {
      get
      {
        int buffableFlagStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &buffableFlagStateStart);
        return buffableFlagStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Count
    {
      get
      {
        int buffableFlagStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &buffableFlagStateCount);
        return buffableFlagStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Health_Start
    {
      get
      {
        int fieldsHealthStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Health_Start, (void*) &fieldsHealthStart);
        return fieldsHealthStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Health_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Health_Count
    {
      get
      {
        int fieldsHealthCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Health_Count, (void*) &fieldsHealthCount);
        return fieldsHealthCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Health_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_PlacementDestroyData_Start
    {
      get
      {
        int destroyDataStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Start, (void*) &destroyDataStart);
        return destroyDataStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_PlacementDestroyData_Count
    {
      get
      {
        int destroyDataCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Count, (void*) &destroyDataCount);
        return destroyDataCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_PlacementDestroyData_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Rotation_Start
    {
      get
      {
        int fieldsRotationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start, (void*) &fieldsRotationStart);
        return fieldsRotationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Rotation_Count
    {
      get
      {
        int fieldsRotationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count, (void*) &fieldsRotationCount);
        return fieldsRotationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpiderCocoon_DataShared_Start
    {
      get
      {
        int cocoonDataSharedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_SpiderCocoon_DataShared_Start, (void*) &cocoonDataSharedStart);
        return cocoonDataSharedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_SpiderCocoon_DataShared_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpiderCocoon_DataShared_Count
    {
      get
      {
        int cocoonDataSharedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_SpiderCocoon_DataShared_Count, (void*) &cocoonDataSharedCount);
        return cocoonDataSharedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_SpiderCocoon_DataShared_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Start
    {
      get
      {
        int fieldsTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &fieldsTileModelStart);
        return fieldsTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Count
    {
      get
      {
        int fieldsTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &fieldsTileModelCount);
        return fieldsTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Translation_Start
    {
      get
      {
        int translationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Translation_Start, (void*) &translationStart);
        return translationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Translation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Translation_Count
    {
      get
      {
        int translationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Translation_Count, (void*) &translationCount);
        return translationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedFields_Translation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health
    {
      get
      {
        int changedIndexHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Health, (void*) &changedIndexHealth);
        return changedIndexHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Health, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_PlacementDestroyData
    {
      get
      {
        int placementDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData, (void*) &placementDestroyData);
        return placementDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Rotation
    {
      get
      {
        int changedIndexRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Rotation, (void*) &changedIndexRotation);
        return changedIndexRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Rotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpiderCocoon_DataShared
    {
      get
      {
        int cocoonDataShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_SpiderCocoon_DataShared, (void*) &cocoonDataShared);
        return cocoonDataShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_SpiderCocoon_DataShared, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel
    {
      get
      {
        int changedIndexTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &changedIndexTileModel);
        return changedIndexTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Translation
    {
      get
      {
        int indexTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Translation, (void*) &indexTranslation);
        return indexTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Translation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState_Value
    {
      get
      {
        int buffableFlagStateValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &buffableFlagStateValue);
        return buffableFlagStateValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_IsDead
    {
      get
      {
        int indexHealthIsDead;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead, (void*) &indexHealthIsDead);
        return indexHealthIsDead;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Health_IsDead, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_MaxHealth
    {
      get
      {
        int indexHealthMaxHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth, (void*) &indexHealthMaxHealth);
        return indexHealthMaxHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxHealth, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_MaxRecoveryHealth
    {
      get
      {
        int maxRecoveryHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth, (void*) &maxRecoveryHealth);
        return maxRecoveryHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Health_MaxRecoveryHealth, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_TimeOfDeath
    {
      get
      {
        int healthTimeOfDeath;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath, (void*) &healthTimeOfDeath);
        return healthTimeOfDeath;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Health_TimeOfDeath, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Health_Value
    {
      get
      {
        int indexHealthValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Health_Value, (void*) &indexHealthValue);
        return indexHealthValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Health_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_PlacementDestroyData_DestroyReason
    {
      get
      {
        int dataDestroyReason;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData_DestroyReason, (void*) &dataDestroyReason);
        return dataDestroyReason;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_PlacementDestroyData_DestroyReason, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Rotation_Value
    {
      get
      {
        int indexRotationValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value, (void*) &indexRotationValue);
        return indexRotationValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpiderCocoon_DataShared_Activated
    {
      get
      {
        int dataSharedActivated;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_SpiderCocoon_DataShared_Activated, (void*) &dataSharedActivated);
        return dataSharedActivated;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_SpiderCocoon_DataShared_Activated, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel_DisabledTileTypes
    {
      get
      {
        int disabledTileTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &disabledTileTypes);
        return disabledTileTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Translation_Value
    {
      get
      {
        int translationValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value, (void*) &translationValue);
        return translationValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Health
    {
      get
      {
        int startOffsetHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_Health, (void*) &startOffsetHealth);
        return startOffsetHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_Health, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Health
    {
      get
      {
        int componentDataSizeHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_Health, (void*) &componentDataSizeHealth);
        return componentDataSizeHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_Health, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_PlacementDestroyData
    {
      get
      {
        int placementDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_PlacementDestroyData, (void*) &placementDestroyData);
        return placementDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_PlacementDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_PlacementDestroyData
    {
      get
      {
        int placementDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_PlacementDestroyData, (void*) &placementDestroyData);
        return placementDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_PlacementDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Rotation
    {
      get
      {
        int startOffsetRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation, (void*) &startOffsetRotation);
        return startOffsetRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Rotation
    {
      get
      {
        int dataSizeRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_Rotation, (void*) &dataSizeRotation);
        return dataSizeRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_Rotation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_SpiderCocoon_DataShared
    {
      get
      {
        int cocoonDataShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_SpiderCocoon_DataShared, (void*) &cocoonDataShared);
        return cocoonDataShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_SpiderCocoon_DataShared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_SpiderCocoon_DataShared
    {
      get
      {
        int cocoonDataShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_SpiderCocoon_DataShared, (void*) &cocoonDataShared);
        return cocoonDataShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_SpiderCocoon_DataShared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TileModel
    {
      get
      {
        int startOffsetTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &startOffsetTileModel);
        return startOffsetTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TileModel
    {
      get
      {
        int dataSizeTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &dataSizeTileModel);
        return dataSizeTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Translation
    {
      get
      {
        int offsetTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_Translation, (void*) &offsetTranslation);
        return offsetTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataStartOffset_Translation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Translation
    {
      get
      {
        int dataSizeTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_Translation, (void*) &dataSizeTranslation);
        return dataSizeTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_ComponentDataSize_Translation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_BuffableFlagState
    {
      get
      {
        ulong buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Health
    {
      get
      {
        ulong compBitHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_Health, (void*) &compBitHealth);
        return compBitHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_Health, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_PlacementDestroyData
    {
      get
      {
        ulong placementDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_PlacementDestroyData, (void*) &placementDestroyData);
        return placementDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_PlacementDestroyData, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Rotation
    {
      get
      {
        ulong compBitRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_Rotation, (void*) &compBitRotation);
        return compBitRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_Rotation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_SpiderCocoon_DataShared
    {
      get
      {
        ulong cocoonDataShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_SpiderCocoon_DataShared, (void*) &cocoonDataShared);
        return cocoonDataShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_SpiderCocoon_DataShared, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TileModel
    {
      get
      {
        ulong compBitTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_TileModel, (void*) &compBitTileModel);
        return compBitTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_TileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Translation
    {
      get
      {
        ulong compBitTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_Translation, (void*) &compBitTranslation);
        return compBitTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acidjkkbgbk.NativeFieldInfoPtr_CompBit_Translation, (void*) &value);
      }
    }
  }
}
