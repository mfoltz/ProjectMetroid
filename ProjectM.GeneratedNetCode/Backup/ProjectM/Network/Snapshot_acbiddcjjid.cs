// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_acbiddcjjid
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
  public struct Snapshot_acbiddcjjid
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSequenceForEntity_PlayOnSelf;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSequenceForEntity_Scale;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSequenceForEntity_SecondaryTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSequenceForEntity_SequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSequenceForEntity_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMovement_Disabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMovement_StartPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMovement_TargetPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpellMovement_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpellMovement_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpellMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_PlayOnSelf;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Scale;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SecondaryTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_Disabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_StartPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_TargetPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_SpawnSequenceForEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_SpawnSequenceForEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_SpellMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_SpellMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_SpawnSequenceForEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_SpellMovement;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public float LifeTime_Duration;
    [FieldOffset(12)]
    public bool SpawnSequenceForEntity_PlayOnSelf;
    [FieldOffset(13)]
    public float SpawnSequenceForEntity_Scale;
    [FieldOffset(17)]
    public NetworkId SpawnSequenceForEntity_SecondaryTarget;
    [FieldOffset(25)]
    public SequenceGUID SpawnSequenceForEntity_SequenceGuid;
    [FieldOffset(29)]
    public NetworkId SpawnSequenceForEntity_Target;
    [FieldOffset(37)]
    public bool SpellMovement_Disabled;
    [FieldOffset(38)]
    public float3 SpellMovement_StartPosition;
    [FieldOffset(50)]
    public float3 SpellMovement_TargetPosition;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1523460, XrefRangeEnd = 1523552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acbiddcjjid.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1523592, RefRangeEnd = 1523593, XrefRangeStart = 1523552, XrefRangeEnd = 1523592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acbiddcjjid.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_acbiddcjjid()
    {
      Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_acbiddcjjid));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr);
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (LifeTime_Duration));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_SpawnSequenceForEntity_PlayOnSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (SpawnSequenceForEntity_PlayOnSelf));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_SpawnSequenceForEntity_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (SpawnSequenceForEntity_Scale));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_SpawnSequenceForEntity_SecondaryTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (SpawnSequenceForEntity_SecondaryTarget));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_SpawnSequenceForEntity_SequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (SpawnSequenceForEntity_SequenceGuid));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_SpawnSequenceForEntity_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (SpawnSequenceForEntity_Target));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_SpellMovement_Disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (SpellMovement_Disabled));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_SpellMovement_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (SpellMovement_StartPosition));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_SpellMovement_TargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (SpellMovement_TargetPosition));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Start));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Count));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChangedFields_SpawnSequenceForEntity_Start));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChangedFields_SpawnSequenceForEntity_Count));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedFields_SpellMovement_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChangedFields_SpellMovement_Start));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedFields_SpellMovement_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChangedFields_SpellMovement_Count));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChangedIndex_SpawnSequenceForEntity));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChangedIndex_SpellMovement));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime_Duration));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_PlayOnSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChangedIndex_SpawnSequenceForEntity_PlayOnSelf));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChangedIndex_SpawnSequenceForEntity_Scale));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SecondaryTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChangedIndex_SpawnSequenceForEntity_SecondaryTarget));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChangedIndex_SpawnSequenceForEntity_SequenceGuid));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChangedIndex_SpawnSequenceForEntity_Target));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_Disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChangedIndex_SpellMovement_Disabled));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChangedIndex_SpellMovement_StartPosition));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_TargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (FrameChangedIndex_SpellMovement_TargetPosition));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (ComponentDataStartOffset_LifeTime));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_ComponentDataSize_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (ComponentDataSize_LifeTime));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_ComponentDataStartOffset_SpawnSequenceForEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (ComponentDataStartOffset_SpawnSequenceForEntity));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_ComponentDataSize_SpawnSequenceForEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (ComponentDataSize_SpawnSequenceForEntity));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_ComponentDataStartOffset_SpellMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (ComponentDataStartOffset_SpellMovement));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_ComponentDataSize_SpellMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (ComponentDataSize_SpellMovement));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_CompBit_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (CompBit_LifeTime));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_CompBit_SpawnSequenceForEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (CompBit_SpawnSequenceForEntity));
      Snapshot_acbiddcjjid.NativeFieldInfoPtr_CompBit_SpellMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, nameof (CompBit_SpellMovement));
      Snapshot_acbiddcjjid.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, 100664134);
      Snapshot_acbiddcjjid.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, 100664135);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_acbiddcjjid>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Start
    {
      get
      {
        int fieldsLifeTimeStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &fieldsLifeTimeStart);
        return fieldsLifeTimeStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Count
    {
      get
      {
        int fieldsLifeTimeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &fieldsLifeTimeCount);
        return fieldsLifeTimeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpawnSequenceForEntity_Start
    {
      get
      {
        int sequenceForEntityStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Start, (void*) &sequenceForEntityStart);
        return sequenceForEntityStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpawnSequenceForEntity_Count
    {
      get
      {
        int sequenceForEntityCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Count, (void*) &sequenceForEntityCount);
        return sequenceForEntityCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpellMovement_Start
    {
      get
      {
        int spellMovementStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedFields_SpellMovement_Start, (void*) &spellMovementStart);
        return spellMovementStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedFields_SpellMovement_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpellMovement_Count
    {
      get
      {
        int spellMovementCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedFields_SpellMovement_Count, (void*) &spellMovementCount);
        return spellMovementCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedFields_SpellMovement_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime
    {
      get
      {
        int changedIndexLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &changedIndexLifeTime);
        return changedIndexLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnSequenceForEntity
    {
      get
      {
        int sequenceForEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity, (void*) &sequenceForEntity);
        return sequenceForEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpellMovement
    {
      get
      {
        int indexSpellMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement, (void*) &indexSpellMovement);
        return indexSpellMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime_Duration
    {
      get
      {
        int lifeTimeDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &lifeTimeDuration);
        return lifeTimeDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnSequenceForEntity_PlayOnSelf
    {
      get
      {
        int entityPlayOnSelf;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_PlayOnSelf, (void*) &entityPlayOnSelf);
        return entityPlayOnSelf;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_PlayOnSelf, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnSequenceForEntity_Scale
    {
      get
      {
        int sequenceForEntityScale;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Scale, (void*) &sequenceForEntityScale);
        return sequenceForEntityScale;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Scale, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnSequenceForEntity_SecondaryTarget
    {
      get
      {
        int entitySecondaryTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SecondaryTarget, (void*) &entitySecondaryTarget);
        return entitySecondaryTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SecondaryTarget, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnSequenceForEntity_SequenceGuid
    {
      get
      {
        int entitySequenceGuid;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SequenceGuid, (void*) &entitySequenceGuid);
        return entitySequenceGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SequenceGuid, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnSequenceForEntity_Target
    {
      get
      {
        int sequenceForEntityTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Target, (void*) &sequenceForEntityTarget);
        return sequenceForEntityTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Target, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpellMovement_Disabled
    {
      get
      {
        int movementDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_Disabled, (void*) &movementDisabled);
        return movementDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_Disabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpellMovement_StartPosition
    {
      get
      {
        int movementStartPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_StartPosition, (void*) &movementStartPosition);
        return movementStartPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_StartPosition, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpellMovement_TargetPosition
    {
      get
      {
        int movementTargetPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_TargetPosition, (void*) &movementTargetPosition);
        return movementTargetPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_TargetPosition, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_LifeTime
    {
      get
      {
        int startOffsetLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &startOffsetLifeTime);
        return startOffsetLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_LifeTime
    {
      get
      {
        int dataSizeLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &dataSizeLifeTime);
        return dataSizeLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_SpawnSequenceForEntity
    {
      get
      {
        int sequenceForEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_ComponentDataStartOffset_SpawnSequenceForEntity, (void*) &sequenceForEntity);
        return sequenceForEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_ComponentDataStartOffset_SpawnSequenceForEntity, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_SpawnSequenceForEntity
    {
      get
      {
        int sequenceForEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_ComponentDataSize_SpawnSequenceForEntity, (void*) &sequenceForEntity);
        return sequenceForEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_ComponentDataSize_SpawnSequenceForEntity, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_SpellMovement
    {
      get
      {
        int offsetSpellMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_ComponentDataStartOffset_SpellMovement, (void*) &offsetSpellMovement);
        return offsetSpellMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_ComponentDataStartOffset_SpellMovement, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_SpellMovement
    {
      get
      {
        int sizeSpellMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_ComponentDataSize_SpellMovement, (void*) &sizeSpellMovement);
        return sizeSpellMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_ComponentDataSize_SpellMovement, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_LifeTime
    {
      get
      {
        ulong compBitLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &compBitLifeTime);
        return compBitLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_SpawnSequenceForEntity
    {
      get
      {
        ulong sequenceForEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_CompBit_SpawnSequenceForEntity, (void*) &sequenceForEntity);
        return sequenceForEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_CompBit_SpawnSequenceForEntity, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_SpellMovement
    {
      get
      {
        ulong bitSpellMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_CompBit_SpellMovement, (void*) &bitSpellMovement);
        return bitSpellMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acbiddcjjid.NativeFieldInfoPtr_CompBit_SpellMovement, (void*) &value);
      }
    }
  }
}
