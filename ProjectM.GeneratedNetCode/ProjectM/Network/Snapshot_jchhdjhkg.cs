﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_jchhdjhkg
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
  public struct Snapshot_jchhdjhkg
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_StartTimeUnmodified;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Buff_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Buff_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Rotation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Rotation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public byte Buff_Stacks;
    [FieldOffset(9)]
    public double Buff_StartTimeUnmodified;
    [FieldOffset(17)]
    public NetworkId Buff_Target;
    [FieldOffset(25)]
    public NetworkId EntityCreator_Creator;
    [FieldOffset(33)]
    public NetworkId EntityOwner_Owner;
    [FieldOffset(41)]
    public quaternion Rotation_Value;
    [FieldOffset(57)]
    public int Team_FactionIndex;
    [FieldOffset(61)]
    public int Team_Value;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1589180, XrefRangeEnd = 1589244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_jchhdjhkg.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1589281, RefRangeEnd = 1589282, XrefRangeStart = 1589244, XrefRangeEnd = 1589281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_jchhdjhkg.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_jchhdjhkg()
    {
      Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_jchhdjhkg));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr);
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_Buff_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (Buff_Stacks));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_Buff_StartTimeUnmodified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (Buff_StartTimeUnmodified));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_Buff_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (Buff_Target));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (EntityCreator_Creator));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (EntityOwner_Owner));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_Rotation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (Rotation_Value));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (Team_Value));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_Buff_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedFields_Buff_Start));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_Buff_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedFields_Buff_Count));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Start));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Count));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Start));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Count));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedFields_Rotation_Start));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedFields_Rotation_Count));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedIndex_Buff));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedIndex_Rotation));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedIndex_Buff_Stacks));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedIndex_Buff_StartTimeUnmodified));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedIndex_Buff_Target));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator_Creator));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner_Owner));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedIndex_Rotation_Value));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataStartOffset_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (ComponentDataStartOffset_Buff));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataSize_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (ComponentDataSize_Buff));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityCreator));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataSize_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (ComponentDataSize_EntityCreator));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityOwner));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataSize_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (ComponentDataSize_EntityOwner));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (ComponentDataStartOffset_Rotation));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataSize_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (ComponentDataSize_Rotation));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_CompBit_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (CompBit_Buff));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_CompBit_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (CompBit_EntityCreator));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_CompBit_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (CompBit_EntityOwner));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_CompBit_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (CompBit_Rotation));
      Snapshot_jchhdjhkg.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_jchhdjhkg.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, 100664724);
      Snapshot_jchhdjhkg.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, 100664725);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_jchhdjhkg>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Buff_Start
    {
      get
      {
        int changedFieldsBuffStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_Buff_Start, (void*) &changedFieldsBuffStart);
        return changedFieldsBuffStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_Buff_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Buff_Count
    {
      get
      {
        int changedFieldsBuffCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_Buff_Count, (void*) &changedFieldsBuffCount);
        return changedFieldsBuffCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_Buff_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Start
    {
      get
      {
        int entityCreatorStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &entityCreatorStart);
        return entityCreatorStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Count
    {
      get
      {
        int entityCreatorCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &entityCreatorCount);
        return entityCreatorCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Start
    {
      get
      {
        int entityOwnerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &entityOwnerStart);
        return entityOwnerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Count
    {
      get
      {
        int entityOwnerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &entityOwnerCount);
        return entityOwnerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Rotation_Start
    {
      get
      {
        int fieldsRotationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start, (void*) &fieldsRotationStart);
        return fieldsRotationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Rotation_Count
    {
      get
      {
        int fieldsRotationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count, (void*) &fieldsRotationCount);
        return fieldsRotationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff
    {
      get
      {
        int changedIndexBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Buff, (void*) &changedIndexBuff);
        return changedIndexBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Buff, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator
    {
      get
      {
        int indexEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &indexEntityCreator);
        return indexEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner
    {
      get
      {
        int indexEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &indexEntityOwner);
        return indexEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Rotation
    {
      get
      {
        int changedIndexRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Rotation, (void*) &changedIndexRotation);
        return changedIndexRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Rotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_Stacks
    {
      get
      {
        int changedIndexBuffStacks;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks, (void*) &changedIndexBuffStacks);
        return changedIndexBuffStacks;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_StartTimeUnmodified
    {
      get
      {
        int startTimeUnmodified;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified, (void*) &startTimeUnmodified);
        return startTimeUnmodified;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_Target
    {
      get
      {
        int changedIndexBuffTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target, (void*) &changedIndexBuffTarget);
        return changedIndexBuffTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator_Creator
    {
      get
      {
        int entityCreatorCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &entityCreatorCreator);
        return entityCreatorCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner_Owner
    {
      get
      {
        int entityOwnerOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &entityOwnerOwner);
        return entityOwnerOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Rotation_Value
    {
      get
      {
        int indexRotationValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value, (void*) &indexRotationValue);
        return indexRotationValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Buff
    {
      get
      {
        int dataStartOffsetBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataStartOffset_Buff, (void*) &dataStartOffsetBuff);
        return dataStartOffsetBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataStartOffset_Buff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Buff
    {
      get
      {
        int componentDataSizeBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataSize_Buff, (void*) &componentDataSizeBuff);
        return componentDataSizeBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataSize_Buff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityCreator
    {
      get
      {
        int offsetEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &offsetEntityCreator);
        return offsetEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityCreator
    {
      get
      {
        int sizeEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &sizeEntityCreator);
        return sizeEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityOwner
    {
      get
      {
        int offsetEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &offsetEntityOwner);
        return offsetEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityOwner
    {
      get
      {
        int dataSizeEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &dataSizeEntityOwner);
        return dataSizeEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Rotation
    {
      get
      {
        int startOffsetRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation, (void*) &startOffsetRotation);
        return startOffsetRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Rotation
    {
      get
      {
        int dataSizeRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataSize_Rotation, (void*) &dataSizeRotation);
        return dataSizeRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataSize_Rotation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Buff
    {
      get
      {
        ulong compBitBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_CompBit_Buff, (void*) &compBitBuff);
        return compBitBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_CompBit_Buff, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityCreator
    {
      get
      {
        ulong bitEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &bitEntityCreator);
        return bitEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityOwner
    {
      get
      {
        ulong compBitEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &compBitEntityOwner);
        return compBitEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Rotation
    {
      get
      {
        ulong compBitRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_CompBit_Rotation, (void*) &compBitRotation);
        return compBitRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_CompBit_Rotation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jchhdjhkg.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }
  }
}
