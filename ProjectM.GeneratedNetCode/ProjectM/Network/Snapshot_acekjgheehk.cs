﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_acekjgheehk
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Gameplay.Scripting;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_acekjgheehk
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotateOverTimeData_InitialRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotateOverTimeData_RotationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_RotateOverTimeData_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_RotateOverTimeData_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData_InitialRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData_RotationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_RotateOverTimeData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_RotateOverTimeData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_RotateOverTimeData;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public NetworkId EntityCreator_Creator;
    [FieldOffset(16)]
    public NetworkId EntityOwner_Owner;
    [FieldOffset(24)]
    public float LifeTime_Duration;
    [FieldOffset(28)]
    public quaternion RotateOverTimeData_InitialRotation;
    [FieldOffset(44)]
    public RotationType RotateOverTimeData_RotationType;
    [FieldOffset(48)]
    public int Team_FactionIndex;
    [FieldOffset(52)]
    public int Team_Value;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1529100, XrefRangeEnd = 1529186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acekjgheehk.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1529220, RefRangeEnd = 1529221, XrefRangeStart = 1529186, XrefRangeEnd = 1529220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acekjgheehk.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_acekjgheehk()
    {
      Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_acekjgheehk));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr);
      Snapshot_acekjgheehk.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (EntityCreator_Creator));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (EntityOwner_Owner));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (LifeTime_Duration));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_RotateOverTimeData_InitialRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (RotateOverTimeData_InitialRotation));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_RotateOverTimeData_RotationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (RotateOverTimeData_RotationType));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (Team_Value));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Start));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Count));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Start));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Count));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Start));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Count));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_RotateOverTimeData_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedFields_RotateOverTimeData_Start));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_RotateOverTimeData_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedFields_RotateOverTimeData_Count));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedIndex_RotateOverTimeData));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator_Creator));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner_Owner));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime_Duration));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData_InitialRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedIndex_RotateOverTimeData_InitialRotation));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData_RotationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedIndex_RotateOverTimeData_RotationType));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityCreator));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataSize_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (ComponentDataSize_EntityCreator));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityOwner));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataSize_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (ComponentDataSize_EntityOwner));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (ComponentDataStartOffset_LifeTime));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataSize_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (ComponentDataSize_LifeTime));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataStartOffset_RotateOverTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (ComponentDataStartOffset_RotateOverTimeData));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataSize_RotateOverTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (ComponentDataSize_RotateOverTimeData));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_CompBit_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (CompBit_EntityCreator));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_CompBit_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (CompBit_EntityOwner));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_CompBit_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (CompBit_LifeTime));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_CompBit_RotateOverTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (CompBit_RotateOverTimeData));
      Snapshot_acekjgheehk.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_acekjgheehk.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, 100664186);
      Snapshot_acekjgheehk.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, 100664187);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_acekjgheehk>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Start
    {
      get
      {
        int entityCreatorStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &entityCreatorStart);
        return entityCreatorStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Count
    {
      get
      {
        int entityCreatorCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &entityCreatorCount);
        return entityCreatorCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Start
    {
      get
      {
        int entityOwnerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &entityOwnerStart);
        return entityOwnerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Count
    {
      get
      {
        int entityOwnerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &entityOwnerCount);
        return entityOwnerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Start
    {
      get
      {
        int fieldsLifeTimeStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &fieldsLifeTimeStart);
        return fieldsLifeTimeStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Count
    {
      get
      {
        int fieldsLifeTimeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &fieldsLifeTimeCount);
        return fieldsLifeTimeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_RotateOverTimeData_Start
    {
      get
      {
        int overTimeDataStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_RotateOverTimeData_Start, (void*) &overTimeDataStart);
        return overTimeDataStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_RotateOverTimeData_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_RotateOverTimeData_Count
    {
      get
      {
        int overTimeDataCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_RotateOverTimeData_Count, (void*) &overTimeDataCount);
        return overTimeDataCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_RotateOverTimeData_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator
    {
      get
      {
        int indexEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &indexEntityCreator);
        return indexEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner
    {
      get
      {
        int indexEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &indexEntityOwner);
        return indexEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime
    {
      get
      {
        int changedIndexLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &changedIndexLifeTime);
        return changedIndexLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_RotateOverTimeData
    {
      get
      {
        int rotateOverTimeData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData, (void*) &rotateOverTimeData);
        return rotateOverTimeData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator_Creator
    {
      get
      {
        int entityCreatorCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &entityCreatorCreator);
        return entityCreatorCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner_Owner
    {
      get
      {
        int entityOwnerOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &entityOwnerOwner);
        return entityOwnerOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime_Duration
    {
      get
      {
        int lifeTimeDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &lifeTimeDuration);
        return lifeTimeDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_RotateOverTimeData_InitialRotation
    {
      get
      {
        int dataInitialRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData_InitialRotation, (void*) &dataInitialRotation);
        return dataInitialRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData_InitialRotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_RotateOverTimeData_RotationType
    {
      get
      {
        int dataRotationType;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData_RotationType, (void*) &dataRotationType);
        return dataRotationType;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData_RotationType, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityCreator
    {
      get
      {
        int offsetEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &offsetEntityCreator);
        return offsetEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityCreator
    {
      get
      {
        int sizeEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &sizeEntityCreator);
        return sizeEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityOwner
    {
      get
      {
        int offsetEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &offsetEntityOwner);
        return offsetEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityOwner
    {
      get
      {
        int dataSizeEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &dataSizeEntityOwner);
        return dataSizeEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_LifeTime
    {
      get
      {
        int startOffsetLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &startOffsetLifeTime);
        return startOffsetLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_LifeTime
    {
      get
      {
        int dataSizeLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &dataSizeLifeTime);
        return dataSizeLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_RotateOverTimeData
    {
      get
      {
        int rotateOverTimeData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataStartOffset_RotateOverTimeData, (void*) &rotateOverTimeData);
        return rotateOverTimeData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataStartOffset_RotateOverTimeData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_RotateOverTimeData
    {
      get
      {
        int rotateOverTimeData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataSize_RotateOverTimeData, (void*) &rotateOverTimeData);
        return rotateOverTimeData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataSize_RotateOverTimeData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityCreator
    {
      get
      {
        ulong bitEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &bitEntityCreator);
        return bitEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityOwner
    {
      get
      {
        ulong compBitEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &compBitEntityOwner);
        return compBitEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_LifeTime
    {
      get
      {
        ulong compBitLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &compBitLifeTime);
        return compBitLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_RotateOverTimeData
    {
      get
      {
        ulong rotateOverTimeData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_CompBit_RotateOverTimeData, (void*) &rotateOverTimeData);
        return rotateOverTimeData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_CompBit_RotateOverTimeData, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acekjgheehk.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }
  }
}
