// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_kfkchgjdd
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
  public struct Snapshot_kfkchgjdd
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellTarget_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpellTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpellTarget_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_SpellTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_SpellTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_SpellTarget;
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
    public NetworkId SpellTarget_Target;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1590432, XrefRangeEnd = 1590489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_kfkchgjdd.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1590516, RefRangeEnd = 1590517, XrefRangeStart = 1590489, XrefRangeEnd = 1590516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_kfkchgjdd.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_kfkchgjdd()
    {
      Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_kfkchgjdd));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr);
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (EntityCreator_Creator));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (EntityOwner_Owner));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (LifeTime_Duration));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_SpellTarget_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (SpellTarget_Target));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Start));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Count));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Start));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Count));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Start));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Count));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (FrameChangedFields_SpellTarget_Start));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (FrameChangedFields_SpellTarget_Count));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_SpellTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (FrameChangedIndex_SpellTarget));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator_Creator));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner_Owner));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime_Duration));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_SpellTarget_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (FrameChangedIndex_SpellTarget_Target));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityCreator));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataSize_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (ComponentDataSize_EntityCreator));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityOwner));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataSize_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (ComponentDataSize_EntityOwner));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (ComponentDataStartOffset_LifeTime));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataSize_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (ComponentDataSize_LifeTime));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataStartOffset_SpellTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (ComponentDataStartOffset_SpellTarget));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataSize_SpellTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (ComponentDataSize_SpellTarget));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_CompBit_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (CompBit_EntityCreator));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_CompBit_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (CompBit_EntityOwner));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_CompBit_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (CompBit_LifeTime));
      Snapshot_kfkchgjdd.NativeFieldInfoPtr_CompBit_SpellTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, nameof (CompBit_SpellTarget));
      Snapshot_kfkchgjdd.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, 100664744);
      Snapshot_kfkchgjdd.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, 100664745);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_kfkchgjdd>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Start
    {
      get
      {
        int entityCreatorStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &entityCreatorStart);
        return entityCreatorStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Count
    {
      get
      {
        int entityCreatorCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &entityCreatorCount);
        return entityCreatorCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Start
    {
      get
      {
        int entityOwnerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &entityOwnerStart);
        return entityOwnerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Count
    {
      get
      {
        int entityOwnerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &entityOwnerCount);
        return entityOwnerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Start
    {
      get
      {
        int fieldsLifeTimeStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &fieldsLifeTimeStart);
        return fieldsLifeTimeStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Count
    {
      get
      {
        int fieldsLifeTimeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &fieldsLifeTimeCount);
        return fieldsLifeTimeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpellTarget_Start
    {
      get
      {
        int spellTargetStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Start, (void*) &spellTargetStart);
        return spellTargetStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpellTarget_Count
    {
      get
      {
        int spellTargetCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Count, (void*) &spellTargetCount);
        return spellTargetCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator
    {
      get
      {
        int indexEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &indexEntityCreator);
        return indexEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner
    {
      get
      {
        int indexEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &indexEntityOwner);
        return indexEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime
    {
      get
      {
        int changedIndexLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &changedIndexLifeTime);
        return changedIndexLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpellTarget
    {
      get
      {
        int indexSpellTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_SpellTarget, (void*) &indexSpellTarget);
        return indexSpellTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_SpellTarget, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator_Creator
    {
      get
      {
        int entityCreatorCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &entityCreatorCreator);
        return entityCreatorCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner_Owner
    {
      get
      {
        int entityOwnerOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &entityOwnerOwner);
        return entityOwnerOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime_Duration
    {
      get
      {
        int lifeTimeDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &lifeTimeDuration);
        return lifeTimeDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpellTarget_Target
    {
      get
      {
        int spellTargetTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_SpellTarget_Target, (void*) &spellTargetTarget);
        return spellTargetTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_FrameChangedIndex_SpellTarget_Target, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityCreator
    {
      get
      {
        int offsetEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &offsetEntityCreator);
        return offsetEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityCreator
    {
      get
      {
        int sizeEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &sizeEntityCreator);
        return sizeEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityOwner
    {
      get
      {
        int offsetEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &offsetEntityOwner);
        return offsetEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityOwner
    {
      get
      {
        int dataSizeEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &dataSizeEntityOwner);
        return dataSizeEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_LifeTime
    {
      get
      {
        int startOffsetLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &startOffsetLifeTime);
        return startOffsetLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_LifeTime
    {
      get
      {
        int dataSizeLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &dataSizeLifeTime);
        return dataSizeLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_SpellTarget
    {
      get
      {
        int offsetSpellTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataStartOffset_SpellTarget, (void*) &offsetSpellTarget);
        return offsetSpellTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataStartOffset_SpellTarget, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_SpellTarget
    {
      get
      {
        int dataSizeSpellTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataSize_SpellTarget, (void*) &dataSizeSpellTarget);
        return dataSizeSpellTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_ComponentDataSize_SpellTarget, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityCreator
    {
      get
      {
        ulong bitEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &bitEntityCreator);
        return bitEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityOwner
    {
      get
      {
        ulong compBitEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &compBitEntityOwner);
        return compBitEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_LifeTime
    {
      get
      {
        ulong compBitLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &compBitLifeTime);
        return compBitLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_SpellTarget
    {
      get
      {
        ulong compBitSpellTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_CompBit_SpellTarget, (void*) &compBitSpellTarget);
        return compBitSpellTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_kfkchgjdd.NativeFieldInfoPtr_CompBit_SpellTarget, (void*) &value);
      }
    }
  }
}
