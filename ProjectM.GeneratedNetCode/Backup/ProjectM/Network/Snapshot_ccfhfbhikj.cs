﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_ccfhfbhikj
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
  public struct Snapshot_ccfhfbhikj
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_HardnessThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_PushStrengthMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_PushStrengthMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstUnits_HardnessThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstUnits_PushStrengthMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstUnits_PushStrengthMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollision_AgainstUnits_RadiusVariation;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastTranslation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_Translation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LastTranslation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LastTranslation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Rotation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Rotation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Translation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Translation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LastTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LastTranslation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Translation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_DynamicCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_DynamicCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_LastTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_LastTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_BuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_DynamicCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_LastTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Rotation;
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
    public ModifiableFloat DynamicCollision_AgainstPlayers_HardnessThreshold;
    [FieldOffset(32)]
    public ModifiableFloat DynamicCollision_AgainstPlayers_PushStrengthMax;
    [FieldOffset(40)]
    public ModifiableFloat DynamicCollision_AgainstPlayers_PushStrengthMin;
    [FieldOffset(48)]
    public ModifiableFloat DynamicCollision_AgainstUnits_HardnessThreshold;
    [FieldOffset(56)]
    public ModifiableFloat DynamicCollision_AgainstUnits_PushStrengthMax;
    [FieldOffset(64)]
    public ModifiableFloat DynamicCollision_AgainstUnits_PushStrengthMin;
    [FieldOffset(72)]
    public float DynamicCollision_AgainstUnits_RadiusVariation;
    [FieldOffset(76)]
    public float3 LastTranslation_Value;
    [FieldOffset(88)]
    public quaternion Rotation_Value;
    [FieldOffset(104)]
    public int Team_FactionIndex;
    [FieldOffset(108)]
    public int Team_Value;
    [FieldOffset(112)]
    public TileType TileModel_DisabledTileTypes;
    [FieldOffset(113)]
    public float3 Translation_Value;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1557359, XrefRangeEnd = 1557424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_ccfhfbhikj.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1557478, RefRangeEnd = 1557479, XrefRangeStart = 1557424, XrefRangeEnd = 1557478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_ccfhfbhikj.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_ccfhfbhikj()
    {
      Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_ccfhfbhikj));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr);
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (BuffableFlagState_Value));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_HardnessThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (DynamicCollision_AgainstPlayers_HardnessThreshold));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (DynamicCollision_AgainstPlayers_PushStrengthMax));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_DynamicCollision_AgainstPlayers_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (DynamicCollision_AgainstPlayers_PushStrengthMin));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_DynamicCollision_AgainstUnits_HardnessThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (DynamicCollision_AgainstUnits_HardnessThreshold));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_DynamicCollision_AgainstUnits_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (DynamicCollision_AgainstUnits_PushStrengthMax));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_DynamicCollision_AgainstUnits_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (DynamicCollision_AgainstUnits_PushStrengthMin));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_DynamicCollision_AgainstUnits_RadiusVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (DynamicCollision_AgainstUnits_RadiusVariation));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_LastTranslation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (LastTranslation_Value));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_Rotation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (Rotation_Value));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (Team_Value));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (TileModel_DisabledTileTypes));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_Translation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (Translation_Value));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Start));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedFields_BuffableFlagState_Count));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedFields_DynamicCollision_Start));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedFields_DynamicCollision_Count));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_LastTranslation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedFields_LastTranslation_Start));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_LastTranslation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedFields_LastTranslation_Count));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedFields_Rotation_Start));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedFields_Rotation_Count));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Start));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Count));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_Translation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedFields_Translation_Start));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_Translation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedFields_Translation_Count));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_LastTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_LastTranslation));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_Rotation));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_TileModel));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_Translation));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_BuffableFlagState_Value));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_LastTranslation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_LastTranslation_Value));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_Rotation_Value));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_TileModel_DisabledTileTypes));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (FrameChangedIndex_Translation_Value));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (ComponentDataStartOffset_BuffableFlagState));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (ComponentDataSize_BuffableFlagState));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_DynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (ComponentDataStartOffset_DynamicCollision));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_DynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (ComponentDataSize_DynamicCollision));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_LastTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (ComponentDataStartOffset_LastTranslation));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_LastTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (ComponentDataSize_LastTranslation));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (ComponentDataStartOffset_Rotation));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (ComponentDataSize_Rotation));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (ComponentDataStartOffset_TileModel));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (ComponentDataSize_TileModel));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (ComponentDataStartOffset_Translation));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (ComponentDataSize_Translation));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_BuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (CompBit_BuffableFlagState));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_DynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (CompBit_DynamicCollision));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_LastTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (CompBit_LastTranslation));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (CompBit_Rotation));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (CompBit_TileModel));
      Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, nameof (CompBit_Translation));
      Snapshot_ccfhfbhikj.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, 100664454);
      Snapshot_ccfhfbhikj.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, 100664455);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_ccfhfbhikj>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Start
    {
      get
      {
        int buffableFlagStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &buffableFlagStateStart);
        return buffableFlagStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_BuffableFlagState_Count
    {
      get
      {
        int buffableFlagStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &buffableFlagStateCount);
        return buffableFlagStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_BuffableFlagState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DynamicCollision_Start
    {
      get
      {
        int dynamicCollisionStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Start, (void*) &dynamicCollisionStart);
        return dynamicCollisionStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DynamicCollision_Count
    {
      get
      {
        int dynamicCollisionCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Count, (void*) &dynamicCollisionCount);
        return dynamicCollisionCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_DynamicCollision_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LastTranslation_Start
    {
      get
      {
        int translationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_LastTranslation_Start, (void*) &translationStart);
        return translationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_LastTranslation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LastTranslation_Count
    {
      get
      {
        int translationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_LastTranslation_Count, (void*) &translationCount);
        return translationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_LastTranslation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Rotation_Start
    {
      get
      {
        int fieldsRotationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start, (void*) &fieldsRotationStart);
        return fieldsRotationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Rotation_Count
    {
      get
      {
        int fieldsRotationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count, (void*) &fieldsRotationCount);
        return fieldsRotationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Start
    {
      get
      {
        int fieldsTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &fieldsTileModelStart);
        return fieldsTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Count
    {
      get
      {
        int fieldsTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &fieldsTileModelCount);
        return fieldsTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Translation_Start
    {
      get
      {
        int translationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_Translation_Start, (void*) &translationStart);
        return translationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_Translation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Translation_Count
    {
      get
      {
        int translationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_Translation_Count, (void*) &translationCount);
        return translationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedFields_Translation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision
    {
      get
      {
        int dynamicCollision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision, (void*) &dynamicCollision);
        return dynamicCollision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LastTranslation
    {
      get
      {
        int indexLastTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_LastTranslation, (void*) &indexLastTranslation);
        return indexLastTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_LastTranslation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Rotation
    {
      get
      {
        int changedIndexRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Rotation, (void*) &changedIndexRotation);
        return changedIndexRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Rotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel
    {
      get
      {
        int changedIndexTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &changedIndexTileModel);
        return changedIndexTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Translation
    {
      get
      {
        int indexTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Translation, (void*) &indexTranslation);
        return indexTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Translation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_BuffableFlagState_Value
    {
      get
      {
        int buffableFlagStateValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &buffableFlagStateValue);
        return buffableFlagStateValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_BuffableFlagState_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold
    {
      get
      {
        int hardnessThreshold;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold, (void*) &hardnessThreshold);
        return hardnessThreshold;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_HardnessThreshold, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax
    {
      get
      {
        int playersPushStrengthMax;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax, (void*) &playersPushStrengthMax);
        return playersPushStrengthMax;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMax, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin
    {
      get
      {
        int playersPushStrengthMin;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin, (void*) &playersPushStrengthMin);
        return playersPushStrengthMin;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstPlayers_PushStrengthMin, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold
    {
      get
      {
        int hardnessThreshold;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold, (void*) &hardnessThreshold);
        return hardnessThreshold;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_HardnessThreshold, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax
    {
      get
      {
        int unitsPushStrengthMax;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax, (void*) &unitsPushStrengthMax);
        return unitsPushStrengthMax;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMax, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin
    {
      get
      {
        int unitsPushStrengthMin;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin, (void*) &unitsPushStrengthMin);
        return unitsPushStrengthMin;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_PushStrengthMin, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation
    {
      get
      {
        int unitsRadiusVariation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation, (void*) &unitsRadiusVariation);
        return unitsRadiusVariation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_DynamicCollision_AgainstUnits_RadiusVariation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LastTranslation_Value
    {
      get
      {
        int translationValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_LastTranslation_Value, (void*) &translationValue);
        return translationValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_LastTranslation_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Rotation_Value
    {
      get
      {
        int indexRotationValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value, (void*) &indexRotationValue);
        return indexRotationValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel_DisabledTileTypes
    {
      get
      {
        int disabledTileTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &disabledTileTypes);
        return disabledTileTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Translation_Value
    {
      get
      {
        int translationValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value, (void*) &translationValue);
        return translationValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_BuffableFlagState
    {
      get
      {
        int buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_DynamicCollision
    {
      get
      {
        int dynamicCollision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_DynamicCollision, (void*) &dynamicCollision);
        return dynamicCollision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_DynamicCollision, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_DynamicCollision
    {
      get
      {
        int dynamicCollision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_DynamicCollision, (void*) &dynamicCollision);
        return dynamicCollision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_DynamicCollision, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_LastTranslation
    {
      get
      {
        int offsetLastTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_LastTranslation, (void*) &offsetLastTranslation);
        return offsetLastTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_LastTranslation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_LastTranslation
    {
      get
      {
        int sizeLastTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_LastTranslation, (void*) &sizeLastTranslation);
        return sizeLastTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_LastTranslation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Rotation
    {
      get
      {
        int startOffsetRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation, (void*) &startOffsetRotation);
        return startOffsetRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Rotation
    {
      get
      {
        int dataSizeRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_Rotation, (void*) &dataSizeRotation);
        return dataSizeRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_Rotation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TileModel
    {
      get
      {
        int startOffsetTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &startOffsetTileModel);
        return startOffsetTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TileModel
    {
      get
      {
        int dataSizeTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &dataSizeTileModel);
        return dataSizeTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Translation
    {
      get
      {
        int offsetTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_Translation, (void*) &offsetTranslation);
        return offsetTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataStartOffset_Translation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Translation
    {
      get
      {
        int dataSizeTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_Translation, (void*) &dataSizeTranslation);
        return dataSizeTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_ComponentDataSize_Translation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_BuffableFlagState
    {
      get
      {
        ulong buffableFlagState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &buffableFlagState);
        return buffableFlagState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_BuffableFlagState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_DynamicCollision
    {
      get
      {
        ulong dynamicCollision;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_DynamicCollision, (void*) &dynamicCollision);
        return dynamicCollision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_DynamicCollision, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_LastTranslation
    {
      get
      {
        ulong bitLastTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_LastTranslation, (void*) &bitLastTranslation);
        return bitLastTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_LastTranslation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Rotation
    {
      get
      {
        ulong compBitRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_Rotation, (void*) &compBitRotation);
        return compBitRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_Rotation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TileModel
    {
      get
      {
        ulong compBitTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_TileModel, (void*) &compBitTileModel);
        return compBitTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_TileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Translation
    {
      get
      {
        ulong compBitTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_Translation, (void*) &compBitTranslation);
        return compBitTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ccfhfbhikj.NativeFieldInfoPtr_CompBit_Translation, (void*) &value);
      }
    }
  }
}
