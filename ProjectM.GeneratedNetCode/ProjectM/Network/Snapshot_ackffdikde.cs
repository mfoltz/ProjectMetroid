// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_ackffdikde
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
  public struct Snapshot_ackffdikde
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSequenceForEntity_PlayOnSelf;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSequenceForEntity_Scale;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSequenceForEntity_SecondaryTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSequenceForEntity_SequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSequenceForEntity_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_Translation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Rotation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Rotation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Translation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Translation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_PlayOnSelf;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Scale;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SecondaryTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Translation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_SpawnSequenceForEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_SpawnSequenceForEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_SpawnSequenceForEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Translation;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public float LifeTime_Duration;
    [FieldOffset(12)]
    public quaternion Rotation_Value;
    [FieldOffset(28)]
    public bool SpawnSequenceForEntity_PlayOnSelf;
    [FieldOffset(29)]
    public float SpawnSequenceForEntity_Scale;
    [FieldOffset(33)]
    public NetworkId SpawnSequenceForEntity_SecondaryTarget;
    [FieldOffset(41)]
    public SequenceGUID SpawnSequenceForEntity_SequenceGuid;
    [FieldOffset(45)]
    public NetworkId SpawnSequenceForEntity_Target;
    [FieldOffset(53)]
    public float3 Translation_Value;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1538080, XrefRangeEnd = 1538172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_ackffdikde.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1538213, RefRangeEnd = 1538214, XrefRangeStart = 1538172, XrefRangeEnd = 1538213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_ackffdikde.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_ackffdikde()
    {
      Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_ackffdikde));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr);
      Snapshot_ackffdikde.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_ackffdikde.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_ackffdikde.NativeFieldInfoPtr_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (LifeTime_Duration));
      Snapshot_ackffdikde.NativeFieldInfoPtr_Rotation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (Rotation_Value));
      Snapshot_ackffdikde.NativeFieldInfoPtr_SpawnSequenceForEntity_PlayOnSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (SpawnSequenceForEntity_PlayOnSelf));
      Snapshot_ackffdikde.NativeFieldInfoPtr_SpawnSequenceForEntity_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (SpawnSequenceForEntity_Scale));
      Snapshot_ackffdikde.NativeFieldInfoPtr_SpawnSequenceForEntity_SecondaryTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (SpawnSequenceForEntity_SecondaryTarget));
      Snapshot_ackffdikde.NativeFieldInfoPtr_SpawnSequenceForEntity_SequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (SpawnSequenceForEntity_SequenceGuid));
      Snapshot_ackffdikde.NativeFieldInfoPtr_SpawnSequenceForEntity_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (SpawnSequenceForEntity_Target));
      Snapshot_ackffdikde.NativeFieldInfoPtr_Translation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (Translation_Value));
      Snapshot_ackffdikde.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Start));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Count));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedFields_Rotation_Start));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedFields_Rotation_Count));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedFields_SpawnSequenceForEntity_Start));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedFields_SpawnSequenceForEntity_Count));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_Translation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedFields_Translation_Start));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_Translation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedFields_Translation_Count));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedIndex_Rotation));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedIndex_SpawnSequenceForEntity));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedIndex_Translation));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime_Duration));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedIndex_Rotation_Value));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_PlayOnSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedIndex_SpawnSequenceForEntity_PlayOnSelf));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedIndex_SpawnSequenceForEntity_Scale));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SecondaryTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedIndex_SpawnSequenceForEntity_SecondaryTarget));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedIndex_SpawnSequenceForEntity_SequenceGuid));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedIndex_SpawnSequenceForEntity_Target));
      Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (FrameChangedIndex_Translation_Value));
      Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (ComponentDataStartOffset_LifeTime));
      Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataSize_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (ComponentDataSize_LifeTime));
      Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (ComponentDataStartOffset_Rotation));
      Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataSize_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (ComponentDataSize_Rotation));
      Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataStartOffset_SpawnSequenceForEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (ComponentDataStartOffset_SpawnSequenceForEntity));
      Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataSize_SpawnSequenceForEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (ComponentDataSize_SpawnSequenceForEntity));
      Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataStartOffset_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (ComponentDataStartOffset_Translation));
      Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataSize_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (ComponentDataSize_Translation));
      Snapshot_ackffdikde.NativeFieldInfoPtr_CompBit_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (CompBit_LifeTime));
      Snapshot_ackffdikde.NativeFieldInfoPtr_CompBit_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (CompBit_Rotation));
      Snapshot_ackffdikde.NativeFieldInfoPtr_CompBit_SpawnSequenceForEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (CompBit_SpawnSequenceForEntity));
      Snapshot_ackffdikde.NativeFieldInfoPtr_CompBit_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, nameof (CompBit_Translation));
      Snapshot_ackffdikde.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, 100664278);
      Snapshot_ackffdikde.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, 100664279);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_ackffdikde>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Start
    {
      get
      {
        int fieldsLifeTimeStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &fieldsLifeTimeStart);
        return fieldsLifeTimeStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Count
    {
      get
      {
        int fieldsLifeTimeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &fieldsLifeTimeCount);
        return fieldsLifeTimeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Rotation_Start
    {
      get
      {
        int fieldsRotationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start, (void*) &fieldsRotationStart);
        return fieldsRotationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Rotation_Count
    {
      get
      {
        int fieldsRotationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count, (void*) &fieldsRotationCount);
        return fieldsRotationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpawnSequenceForEntity_Start
    {
      get
      {
        int sequenceForEntityStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Start, (void*) &sequenceForEntityStart);
        return sequenceForEntityStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpawnSequenceForEntity_Count
    {
      get
      {
        int sequenceForEntityCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Count, (void*) &sequenceForEntityCount);
        return sequenceForEntityCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Translation_Start
    {
      get
      {
        int translationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_Translation_Start, (void*) &translationStart);
        return translationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_Translation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Translation_Count
    {
      get
      {
        int translationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_Translation_Count, (void*) &translationCount);
        return translationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedFields_Translation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime
    {
      get
      {
        int changedIndexLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &changedIndexLifeTime);
        return changedIndexLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Rotation
    {
      get
      {
        int changedIndexRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_Rotation, (void*) &changedIndexRotation);
        return changedIndexRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_Rotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnSequenceForEntity
    {
      get
      {
        int sequenceForEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity, (void*) &sequenceForEntity);
        return sequenceForEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Translation
    {
      get
      {
        int indexTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_Translation, (void*) &indexTranslation);
        return indexTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_Translation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime_Duration
    {
      get
      {
        int lifeTimeDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &lifeTimeDuration);
        return lifeTimeDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Rotation_Value
    {
      get
      {
        int indexRotationValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value, (void*) &indexRotationValue);
        return indexRotationValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnSequenceForEntity_PlayOnSelf
    {
      get
      {
        int entityPlayOnSelf;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_PlayOnSelf, (void*) &entityPlayOnSelf);
        return entityPlayOnSelf;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_PlayOnSelf, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnSequenceForEntity_Scale
    {
      get
      {
        int sequenceForEntityScale;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Scale, (void*) &sequenceForEntityScale);
        return sequenceForEntityScale;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Scale, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnSequenceForEntity_SecondaryTarget
    {
      get
      {
        int entitySecondaryTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SecondaryTarget, (void*) &entitySecondaryTarget);
        return entitySecondaryTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SecondaryTarget, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnSequenceForEntity_SequenceGuid
    {
      get
      {
        int entitySequenceGuid;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SequenceGuid, (void*) &entitySequenceGuid);
        return entitySequenceGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SequenceGuid, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnSequenceForEntity_Target
    {
      get
      {
        int sequenceForEntityTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Target, (void*) &sequenceForEntityTarget);
        return sequenceForEntityTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Target, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Translation_Value
    {
      get
      {
        int translationValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value, (void*) &translationValue);
        return translationValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_LifeTime
    {
      get
      {
        int startOffsetLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &startOffsetLifeTime);
        return startOffsetLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_LifeTime
    {
      get
      {
        int dataSizeLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &dataSizeLifeTime);
        return dataSizeLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Rotation
    {
      get
      {
        int startOffsetRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation, (void*) &startOffsetRotation);
        return startOffsetRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Rotation
    {
      get
      {
        int dataSizeRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataSize_Rotation, (void*) &dataSizeRotation);
        return dataSizeRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataSize_Rotation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_SpawnSequenceForEntity
    {
      get
      {
        int sequenceForEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataStartOffset_SpawnSequenceForEntity, (void*) &sequenceForEntity);
        return sequenceForEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataStartOffset_SpawnSequenceForEntity, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_SpawnSequenceForEntity
    {
      get
      {
        int sequenceForEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataSize_SpawnSequenceForEntity, (void*) &sequenceForEntity);
        return sequenceForEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataSize_SpawnSequenceForEntity, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Translation
    {
      get
      {
        int offsetTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataStartOffset_Translation, (void*) &offsetTranslation);
        return offsetTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataStartOffset_Translation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Translation
    {
      get
      {
        int dataSizeTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataSize_Translation, (void*) &dataSizeTranslation);
        return dataSizeTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_ComponentDataSize_Translation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_LifeTime
    {
      get
      {
        ulong compBitLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &compBitLifeTime);
        return compBitLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Rotation
    {
      get
      {
        ulong compBitRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_CompBit_Rotation, (void*) &compBitRotation);
        return compBitRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_CompBit_Rotation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_SpawnSequenceForEntity
    {
      get
      {
        ulong sequenceForEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_CompBit_SpawnSequenceForEntity, (void*) &sequenceForEntity);
        return sequenceForEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_CompBit_SpawnSequenceForEntity, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Translation
    {
      get
      {
        ulong compBitTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackffdikde.NativeFieldInfoPtr_CompBit_Translation, (void*) &compBitTranslation);
        return compBitTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackffdikde.NativeFieldInfoPtr_CompBit_Translation, (void*) &value);
      }
    }
  }
}
