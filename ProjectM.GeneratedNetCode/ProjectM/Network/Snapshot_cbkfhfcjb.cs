// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_cbkfhfcjb
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_cbkfhfcjb
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AchievementInProgressElement;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AchievementInProgressElement;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_AchievementInProgressElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_AchievementInProgressElement_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1556407, XrefRangeEnd = 1556435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeSnapshot(
      ref NetBufferOut netBuffer,
      SnapshotFrameChangedBuffer* frameChanged,
      ref SerializeEntityParams data,
      ref BufferFromEntity<Snapshot_AchievementInProgressElement> get_buffer_AchievementInProgressElement)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) frameChanged;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_AchievementInProgressElement;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cbkfhfcjb.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_AchievementInProgressElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1556450, RefRangeEnd = 1556451, XrefRangeStart = 1556435, XrefRangeEnd = 1556450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data,
      DynamicBuffer<Snapshot_AchievementInProgressElement> buffer_AchievementInProgressElement)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_AchievementInProgressElement;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cbkfhfcjb.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_AchievementInProgressElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_cbkfhfcjb()
    {
      Il2CppClassPointerStore<Snapshot_cbkfhfcjb>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_cbkfhfcjb));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_cbkfhfcjb>.NativeClassPtr);
      Snapshot_cbkfhfcjb.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cbkfhfcjb>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_cbkfhfcjb.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cbkfhfcjb>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_cbkfhfcjb.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cbkfhfcjb>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_cbkfhfcjb.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cbkfhfcjb>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_cbkfhfcjb.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cbkfhfcjb>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_cbkfhfcjb.NativeFieldInfoPtr_FrameChangedIndex_AchievementInProgressElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cbkfhfcjb>.NativeClassPtr, nameof (FrameChangedIndex_AchievementInProgressElement));
      Snapshot_cbkfhfcjb.NativeFieldInfoPtr_CompBit_AchievementInProgressElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cbkfhfcjb>.NativeClassPtr, nameof (CompBit_AchievementInProgressElement));
      Snapshot_cbkfhfcjb.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_AchievementInProgressElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cbkfhfcjb>.NativeClassPtr, 100664444);
      Snapshot_cbkfhfcjb.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_AchievementInProgressElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cbkfhfcjb>.NativeClassPtr, 100664445);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_cbkfhfcjb>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cbkfhfcjb.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cbkfhfcjb.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cbkfhfcjb.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cbkfhfcjb.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cbkfhfcjb.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cbkfhfcjb.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AchievementInProgressElement
    {
      get
      {
        int inProgressElement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cbkfhfcjb.NativeFieldInfoPtr_FrameChangedIndex_AchievementInProgressElement, (void*) &inProgressElement);
        return inProgressElement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cbkfhfcjb.NativeFieldInfoPtr_FrameChangedIndex_AchievementInProgressElement, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AchievementInProgressElement
    {
      get
      {
        ulong inProgressElement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cbkfhfcjb.NativeFieldInfoPtr_CompBit_AchievementInProgressElement, (void*) &inProgressElement);
        return inProgressElement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cbkfhfcjb.NativeFieldInfoPtr_CompBit_AchievementInProgressElement, (void*) &value);
      }
    }
  }
}
