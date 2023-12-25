// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_akhiekbd
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
  public struct Snapshot_akhiekbd
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeToBlack_Manual_FadeState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_FadeToBlack_Manual_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_FadeToBlack_Manual_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_FadeToBlack_Manual;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_FadeToBlack_Manual_FadeState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_FadeToBlack_Manual;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_FadeToBlack_Manual;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_FadeToBlack_Manual;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public NetworkId EntityOwner_Owner;
    [FieldOffset(16)]
    public FadeToBlack_Manual.State FadeToBlack_Manual_FadeState;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1553788, XrefRangeEnd = 1553800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_akhiekbd.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1553813, RefRangeEnd = 1553814, XrefRangeStart = 1553800, XrefRangeEnd = 1553813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_akhiekbd.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_akhiekbd()
    {
      Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_akhiekbd));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr);
      Snapshot_akhiekbd.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_akhiekbd.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_akhiekbd.NativeFieldInfoPtr_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (EntityOwner_Owner));
      Snapshot_akhiekbd.NativeFieldInfoPtr_FadeToBlack_Manual_FadeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (FadeToBlack_Manual_FadeState));
      Snapshot_akhiekbd.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Start));
      Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Count));
      Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedFields_FadeToBlack_Manual_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (FrameChangedFields_FadeToBlack_Manual_Start));
      Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedFields_FadeToBlack_Manual_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (FrameChangedFields_FadeToBlack_Manual_Count));
      Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner));
      Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedIndex_FadeToBlack_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (FrameChangedIndex_FadeToBlack_Manual));
      Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner_Owner));
      Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedIndex_FadeToBlack_Manual_FadeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (FrameChangedIndex_FadeToBlack_Manual_FadeState));
      Snapshot_akhiekbd.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityOwner));
      Snapshot_akhiekbd.NativeFieldInfoPtr_ComponentDataSize_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (ComponentDataSize_EntityOwner));
      Snapshot_akhiekbd.NativeFieldInfoPtr_ComponentDataStartOffset_FadeToBlack_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (ComponentDataStartOffset_FadeToBlack_Manual));
      Snapshot_akhiekbd.NativeFieldInfoPtr_ComponentDataSize_FadeToBlack_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (ComponentDataSize_FadeToBlack_Manual));
      Snapshot_akhiekbd.NativeFieldInfoPtr_CompBit_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (CompBit_EntityOwner));
      Snapshot_akhiekbd.NativeFieldInfoPtr_CompBit_FadeToBlack_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, nameof (CompBit_FadeToBlack_Manual));
      Snapshot_akhiekbd.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, 100664424);
      Snapshot_akhiekbd.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, 100664425);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_akhiekbd>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akhiekbd.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akhiekbd.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Start
    {
      get
      {
        int entityOwnerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &entityOwnerStart);
        return entityOwnerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Count
    {
      get
      {
        int entityOwnerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &entityOwnerCount);
        return entityOwnerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_FadeToBlack_Manual_Start
    {
      get
      {
        int blackManualStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedFields_FadeToBlack_Manual_Start, (void*) &blackManualStart);
        return blackManualStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedFields_FadeToBlack_Manual_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_FadeToBlack_Manual_Count
    {
      get
      {
        int blackManualCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedFields_FadeToBlack_Manual_Count, (void*) &blackManualCount);
        return blackManualCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedFields_FadeToBlack_Manual_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner
    {
      get
      {
        int indexEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &indexEntityOwner);
        return indexEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_FadeToBlack_Manual
    {
      get
      {
        int fadeToBlackManual;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedIndex_FadeToBlack_Manual, (void*) &fadeToBlackManual);
        return fadeToBlackManual;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedIndex_FadeToBlack_Manual, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner_Owner
    {
      get
      {
        int entityOwnerOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &entityOwnerOwner);
        return entityOwnerOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_FadeToBlack_Manual_FadeState
    {
      get
      {
        int blackManualFadeState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedIndex_FadeToBlack_Manual_FadeState, (void*) &blackManualFadeState);
        return blackManualFadeState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akhiekbd.NativeFieldInfoPtr_FrameChangedIndex_FadeToBlack_Manual_FadeState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityOwner
    {
      get
      {
        int offsetEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akhiekbd.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &offsetEntityOwner);
        return offsetEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akhiekbd.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityOwner
    {
      get
      {
        int dataSizeEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akhiekbd.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &dataSizeEntityOwner);
        return dataSizeEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akhiekbd.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_FadeToBlack_Manual
    {
      get
      {
        int fadeToBlackManual;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akhiekbd.NativeFieldInfoPtr_ComponentDataStartOffset_FadeToBlack_Manual, (void*) &fadeToBlackManual);
        return fadeToBlackManual;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akhiekbd.NativeFieldInfoPtr_ComponentDataStartOffset_FadeToBlack_Manual, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_FadeToBlack_Manual
    {
      get
      {
        int fadeToBlackManual;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akhiekbd.NativeFieldInfoPtr_ComponentDataSize_FadeToBlack_Manual, (void*) &fadeToBlackManual);
        return fadeToBlackManual;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akhiekbd.NativeFieldInfoPtr_ComponentDataSize_FadeToBlack_Manual, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityOwner
    {
      get
      {
        ulong compBitEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akhiekbd.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &compBitEntityOwner);
        return compBitEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akhiekbd.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_FadeToBlack_Manual
    {
      get
      {
        ulong fadeToBlackManual;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_akhiekbd.NativeFieldInfoPtr_CompBit_FadeToBlack_Manual, (void*) &fadeToBlackManual);
        return fadeToBlackManual;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_akhiekbd.NativeFieldInfoPtr_CompBit_FadeToBlack_Manual, (void*) &value);
      }
    }
  }
}
