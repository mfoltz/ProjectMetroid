// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_dbbbcebccf
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_dbbbcebccf
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyAfterDuration_EndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsSpellControlled_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_AimDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_DefaultRotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_Direction;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_ForceRotateTowardsMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection_RotateTowardsMouse;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_Translation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DestroyAfterDuration_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DestroyAfterDuration_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Rotation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Rotation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Translation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Translation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DestroyAfterDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DestroyAfterDuration_EndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Translation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_DestroyAfterDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_DestroyAfterDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_IsSpellControlled;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_IsSpellControlled;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_DestroyAfterDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_IsSpellControlled;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TargetDirection;
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
    public double DestroyAfterDuration_EndTime;
    [FieldOffset(32)]
    public ModifiableBool IsSpellControlled_Value;
    [FieldOffset(36)]
    public quaternion Rotation_Value;
    [FieldOffset(52)]
    public float3 TargetDirection_AimDirection;
    [FieldOffset(64)]
    public float TargetDirection_DefaultRotationSpeed;
    [FieldOffset(68)]
    public float3 TargetDirection_Direction;
    [FieldOffset(80)]
    public ModifiableBool TargetDirection_ForceRotateTowardsMovement;
    [FieldOffset(84)]
    public ModifiableBool TargetDirection_RotateTowardsMouse;
    [FieldOffset(88)]
    public int Team_FactionIndex;
    [FieldOffset(92)]
    public int Team_Value;
    [FieldOffset(96)]
    public TileType TileModel_DisabledTileTypes;
    [FieldOffset(97)]
    public float3 Translation_Value;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1576148, XrefRangeEnd = 1576244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_dbbbcebccf.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1576298, RefRangeEnd = 1576299, XrefRangeStart = 1576244, XrefRangeEnd = 1576298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_dbbbcebccf.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_dbbbcebccf()
    {
      Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_dbbbcebccf));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr);
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (BuffableFlagState_Value));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_DestroyAfterDuration_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (DestroyAfterDuration_EndTime));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_IsSpellControlled_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (IsSpellControlled_Value));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_Rotation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (Rotation_Value));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_TargetDirection_AimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (TargetDirection_AimDirection));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_TargetDirection_DefaultRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (TargetDirection_DefaultRotationSpeed));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_TargetDirection_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (TargetDirection_Direction));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_TargetDirection_ForceRotateTowardsMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (TargetDirection_ForceRotateTowardsMovement));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_TargetDirection_RotateTowardsMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (TargetDirection_RotateTowardsMouse));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (Team_Value));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (TileModel_DisabledTileTypes));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_Translation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (Translation_Value));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Start));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Count));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_DestroyAfterDuration_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedFields_DestroyAfterDuration_Start));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_DestroyAfterDuration_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedFields_DestroyAfterDuration_Count));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedFields_IsSpellControlled_Start));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedFields_IsSpellControlled_Count));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedFields_Rotation_Start));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedFields_Rotation_Count));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedFields_TargetDirection_Start));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedFields_TargetDirection_Count));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Start));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Count));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_Translation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedFields_Translation_Start));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_Translation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedFields_Translation_Count));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_DestroyAfterDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_DestroyAfterDuration));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_IsSpellControlled));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_Rotation));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_TileModel));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_Translation));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState_Value));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_DestroyAfterDuration_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_DestroyAfterDuration_EndTime));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_IsSpellControlled_Value));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_Rotation_Value));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_AimDirection));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_DefaultRotationSpeed));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_Direction));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_TargetDirection_RotateTowardsMouse));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_TileModel_DisabledTileTypes));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (FrameChangedIndex_Translation_Value));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (ComponentDataStartOffset_BuffableFlagState));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (ComponentDataSize_BuffableFlagState));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_DestroyAfterDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (ComponentDataStartOffset_DestroyAfterDuration));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_DestroyAfterDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (ComponentDataSize_DestroyAfterDuration));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_IsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (ComponentDataStartOffset_IsSpellControlled));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_IsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (ComponentDataSize_IsSpellControlled));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (ComponentDataStartOffset_Rotation));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (ComponentDataSize_Rotation));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (ComponentDataStartOffset_TargetDirection));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (ComponentDataSize_TargetDirection));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (ComponentDataStartOffset_TileModel));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (ComponentDataSize_TileModel));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (ComponentDataStartOffset_Translation));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (ComponentDataSize_Translation));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (CompBit_BuffableFlagState));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_DestroyAfterDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (CompBit_DestroyAfterDuration));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_IsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (CompBit_IsSpellControlled));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (CompBit_Rotation));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (CompBit_TargetDirection));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (CompBit_TileModel));
      Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, nameof (CompBit_Translation));
      Snapshot_dbbbcebccf.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, 100664592);
      Snapshot_dbbbcebccf.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, 100664593);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_dbbbcebccf>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Start
    {
      get
      {
        int buffableFlagStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &buffableFlagStateStart);
        return buffableFlagStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Count
    {
      get
      {
        int buffableFlagStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &buffableFlagStateCount);
        return buffableFlagStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DestroyAfterDuration_Start
    {
      get
      {
        int afterDurationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_DestroyAfterDuration_Start, (void*) &afterDurationStart);
        return afterDurationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_DestroyAfterDuration_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DestroyAfterDuration_Count
    {
      get
      {
        int afterDurationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_DestroyAfterDuration_Count, (void*) &afterDurationCount);
        return afterDurationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_DestroyAfterDuration_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_IsSpellControlled_Start
    {
      get
      {
        int spellControlledStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Start, (void*) &spellControlledStart);
        return spellControlledStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_IsSpellControlled_Count
    {
      get
      {
        int spellControlledCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Count, (void*) &spellControlledCount);
        return spellControlledCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_IsSpellControlled_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Rotation_Start
    {
      get
      {
        int fieldsRotationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start, (void*) &fieldsRotationStart);
        return fieldsRotationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Rotation_Count
    {
      get
      {
        int fieldsRotationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count, (void*) &fieldsRotationCount);
        return fieldsRotationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TargetDirection_Start
    {
      get
      {
        int targetDirectionStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start, (void*) &targetDirectionStart);
        return targetDirectionStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TargetDirection_Count
    {
      get
      {
        int targetDirectionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count, (void*) &targetDirectionCount);
        return targetDirectionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_TargetDirection_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Start
    {
      get
      {
        int fieldsTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &fieldsTileModelStart);
        return fieldsTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Count
    {
      get
      {
        int fieldsTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &fieldsTileModelCount);
        return fieldsTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Translation_Start
    {
      get
      {
        int translationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_Translation_Start, (void*) &translationStart);
        return translationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_Translation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Translation_Count
    {
      get
      {
        int translationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_Translation_Count, (void*) &translationCount);
        return translationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedFields_Translation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DestroyAfterDuration
    {
      get
      {
        int destroyAfterDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_DestroyAfterDuration, (void*) &destroyAfterDuration);
        return destroyAfterDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_DestroyAfterDuration, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_IsSpellControlled
    {
      get
      {
        int isSpellControlled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled, (void*) &isSpellControlled);
        return isSpellControlled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Rotation
    {
      get
      {
        int changedIndexRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Rotation, (void*) &changedIndexRotation);
        return changedIndexRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Rotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection
    {
      get
      {
        int indexTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection, (void*) &indexTargetDirection);
        return indexTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel
    {
      get
      {
        int changedIndexTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &changedIndexTileModel);
        return changedIndexTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Translation
    {
      get
      {
        int indexTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Translation, (void*) &indexTranslation);
        return indexTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Translation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState_Value
    {
      get
      {
        int buffableFlagStateValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &buffableFlagStateValue);
        return buffableFlagStateValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DestroyAfterDuration_EndTime
    {
      get
      {
        int afterDurationEndTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_DestroyAfterDuration_EndTime, (void*) &afterDurationEndTime);
        return afterDurationEndTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_DestroyAfterDuration_EndTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_IsSpellControlled_Value
    {
      get
      {
        int spellControlledValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled_Value, (void*) &spellControlledValue);
        return spellControlledValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_IsSpellControlled_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Rotation_Value
    {
      get
      {
        int indexRotationValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value, (void*) &indexRotationValue);
        return indexRotationValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_AimDirection
    {
      get
      {
        int directionAimDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection, (void*) &directionAimDirection);
        return directionAimDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_AimDirection, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_DefaultRotationSpeed
    {
      get
      {
        int defaultRotationSpeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed, (void*) &defaultRotationSpeed);
        return defaultRotationSpeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_DefaultRotationSpeed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_Direction
    {
      get
      {
        int directionDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction, (void*) &directionDirection);
        return directionDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_Direction, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement
    {
      get
      {
        int rotateTowardsMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement, (void*) &rotateTowardsMovement);
        return rotateTowardsMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_ForceRotateTowardsMovement, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TargetDirection_RotateTowardsMouse
    {
      get
      {
        int rotateTowardsMouse;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse, (void*) &rotateTowardsMouse);
        return rotateTowardsMouse;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TargetDirection_RotateTowardsMouse, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel_DisabledTileTypes
    {
      get
      {
        int disabledTileTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &disabledTileTypes);
        return disabledTileTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Translation_Value
    {
      get
      {
        int translationValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value, (void*) &translationValue);
        return translationValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_DestroyAfterDuration
    {
      get
      {
        int destroyAfterDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_DestroyAfterDuration, (void*) &destroyAfterDuration);
        return destroyAfterDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_DestroyAfterDuration, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_DestroyAfterDuration
    {
      get
      {
        int destroyAfterDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_DestroyAfterDuration, (void*) &destroyAfterDuration);
        return destroyAfterDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_DestroyAfterDuration, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_IsSpellControlled
    {
      get
      {
        int isSpellControlled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_IsSpellControlled, (void*) &isSpellControlled);
        return isSpellControlled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_IsSpellControlled, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_IsSpellControlled
    {
      get
      {
        int isSpellControlled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_IsSpellControlled, (void*) &isSpellControlled);
        return isSpellControlled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_IsSpellControlled, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Rotation
    {
      get
      {
        int startOffsetRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation, (void*) &startOffsetRotation);
        return startOffsetRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Rotation
    {
      get
      {
        int dataSizeRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_Rotation, (void*) &dataSizeRotation);
        return dataSizeRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_Rotation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TargetDirection
    {
      get
      {
        int offsetTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection, (void*) &offsetTargetDirection);
        return offsetTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_TargetDirection, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TargetDirection
    {
      get
      {
        int sizeTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_TargetDirection, (void*) &sizeTargetDirection);
        return sizeTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_TargetDirection, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TileModel
    {
      get
      {
        int startOffsetTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &startOffsetTileModel);
        return startOffsetTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TileModel
    {
      get
      {
        int dataSizeTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &dataSizeTileModel);
        return dataSizeTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Translation
    {
      get
      {
        int offsetTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_Translation, (void*) &offsetTranslation);
        return offsetTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataStartOffset_Translation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Translation
    {
      get
      {
        int dataSizeTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_Translation, (void*) &dataSizeTranslation);
        return dataSizeTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_ComponentDataSize_Translation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_BuffableFlagState
    {
      get
      {
        ulong buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_DestroyAfterDuration
    {
      get
      {
        ulong destroyAfterDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_DestroyAfterDuration, (void*) &destroyAfterDuration);
        return destroyAfterDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_DestroyAfterDuration, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_IsSpellControlled
    {
      get
      {
        ulong isSpellControlled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_IsSpellControlled, (void*) &isSpellControlled);
        return isSpellControlled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_IsSpellControlled, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Rotation
    {
      get
      {
        ulong compBitRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_Rotation, (void*) &compBitRotation);
        return compBitRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_Rotation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TargetDirection
    {
      get
      {
        ulong bitTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_TargetDirection, (void*) &bitTargetDirection);
        return bitTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_TargetDirection, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TileModel
    {
      get
      {
        ulong compBitTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_TileModel, (void*) &compBitTileModel);
        return compBitTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_TileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Translation
    {
      get
      {
        ulong compBitTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_Translation, (void*) &compBitTranslation);
        return compBitTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbbbcebccf.NativeFieldInfoPtr_CompBit_Translation, (void*) &value);
      }
    }
  }
}
