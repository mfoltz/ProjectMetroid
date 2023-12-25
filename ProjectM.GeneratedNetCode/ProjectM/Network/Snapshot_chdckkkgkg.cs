// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_chdckkkgkg
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_chdckkkgkg
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeScale_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TimeScale_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TimeScale_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TimeScale;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TimeScale_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TimeScale;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TimeScale;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TimeScale;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public float TimeScale_Value;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1570469, XrefRangeEnd = 1570506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_chdckkkgkg.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1570516, RefRangeEnd = 1570517, XrefRangeStart = 1570506, XrefRangeEnd = 1570516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_chdckkkgkg.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_chdckkkgkg()
    {
      Il2CppClassPointerStore<Snapshot_chdckkkgkg>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_chdckkkgkg));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_chdckkkgkg>.NativeClassPtr);
      Snapshot_chdckkkgkg.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chdckkkgkg>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_chdckkkgkg.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chdckkkgkg>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_chdckkkgkg.NativeFieldInfoPtr_TimeScale_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chdckkkgkg>.NativeClassPtr, nameof (TimeScale_Value));
      Snapshot_chdckkkgkg.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chdckkkgkg>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_chdckkkgkg.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chdckkkgkg>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_chdckkkgkg.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chdckkkgkg>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_chdckkkgkg.NativeFieldInfoPtr_FrameChangedFields_TimeScale_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chdckkkgkg>.NativeClassPtr, nameof (FrameChangedFields_TimeScale_Start));
      Snapshot_chdckkkgkg.NativeFieldInfoPtr_FrameChangedFields_TimeScale_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chdckkkgkg>.NativeClassPtr, nameof (FrameChangedFields_TimeScale_Count));
      Snapshot_chdckkkgkg.NativeFieldInfoPtr_FrameChangedIndex_TimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chdckkkgkg>.NativeClassPtr, nameof (FrameChangedIndex_TimeScale));
      Snapshot_chdckkkgkg.NativeFieldInfoPtr_FrameChangedIndex_TimeScale_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chdckkkgkg>.NativeClassPtr, nameof (FrameChangedIndex_TimeScale_Value));
      Snapshot_chdckkkgkg.NativeFieldInfoPtr_ComponentDataStartOffset_TimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chdckkkgkg>.NativeClassPtr, nameof (ComponentDataStartOffset_TimeScale));
      Snapshot_chdckkkgkg.NativeFieldInfoPtr_ComponentDataSize_TimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chdckkkgkg>.NativeClassPtr, nameof (ComponentDataSize_TimeScale));
      Snapshot_chdckkkgkg.NativeFieldInfoPtr_CompBit_TimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_chdckkkgkg>.NativeClassPtr, nameof (CompBit_TimeScale));
      Snapshot_chdckkkgkg.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_chdckkkgkg>.NativeClassPtr, 100664538);
      Snapshot_chdckkkgkg.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_chdckkkgkg>.NativeClassPtr, 100664539);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_chdckkkgkg>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TimeScale_Start
    {
      get
      {
        int fieldsTimeScaleStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_FrameChangedFields_TimeScale_Start, (void*) &fieldsTimeScaleStart);
        return fieldsTimeScaleStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_FrameChangedFields_TimeScale_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TimeScale_Count
    {
      get
      {
        int fieldsTimeScaleCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_FrameChangedFields_TimeScale_Count, (void*) &fieldsTimeScaleCount);
        return fieldsTimeScaleCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_FrameChangedFields_TimeScale_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TimeScale
    {
      get
      {
        int changedIndexTimeScale;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_FrameChangedIndex_TimeScale, (void*) &changedIndexTimeScale);
        return changedIndexTimeScale;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_FrameChangedIndex_TimeScale, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TimeScale_Value
    {
      get
      {
        int indexTimeScaleValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_FrameChangedIndex_TimeScale_Value, (void*) &indexTimeScaleValue);
        return indexTimeScaleValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_FrameChangedIndex_TimeScale_Value, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TimeScale
    {
      get
      {
        int startOffsetTimeScale;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_ComponentDataStartOffset_TimeScale, (void*) &startOffsetTimeScale);
        return startOffsetTimeScale;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_ComponentDataStartOffset_TimeScale, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TimeScale
    {
      get
      {
        int dataSizeTimeScale;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_ComponentDataSize_TimeScale, (void*) &dataSizeTimeScale);
        return dataSizeTimeScale;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_ComponentDataSize_TimeScale, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TimeScale
    {
      get
      {
        ulong compBitTimeScale;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_CompBit_TimeScale, (void*) &compBitTimeScale);
        return compBitTimeScale;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_chdckkkgkg.NativeFieldInfoPtr_CompBit_TimeScale, (void*) &value);
      }
    }
  }
}
