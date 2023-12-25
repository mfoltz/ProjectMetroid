// Decompiled with JetBrains decompiler
// Type: ProjectM.RespawnPointComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public class RespawnPointComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_SpawnTravelBuffPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnSleepingBuff;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnExitOffset;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnAnimationSequence;
    private static readonly IntPtr NativeFieldInfoPtr_RespawnPointType;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032857, XrefRangeEnd = 1032873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RespawnPointComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032873, XrefRangeEnd = 1032877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RespawnPointComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RespawnPointComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RespawnPointComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RespawnPointComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RespawnPointComponent()
    {
      Il2CppClassPointerStore<RespawnPointComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RespawnPointComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RespawnPointComponent>.NativeClassPtr);
      RespawnPointComponent.NativeFieldInfoPtr_SpawnTravelBuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnPointComponent>.NativeClassPtr, nameof (SpawnTravelBuffPrefab));
      RespawnPointComponent.NativeFieldInfoPtr_SpawnSleepingBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnPointComponent>.NativeClassPtr, nameof (SpawnSleepingBuff));
      RespawnPointComponent.NativeFieldInfoPtr_SpawnExitOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnPointComponent>.NativeClassPtr, nameof (SpawnExitOffset));
      RespawnPointComponent.NativeFieldInfoPtr_SpawnAnimationSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnPointComponent>.NativeClassPtr, nameof (SpawnAnimationSequence));
      RespawnPointComponent.NativeFieldInfoPtr_RespawnPointType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnPointComponent>.NativeClassPtr, nameof (RespawnPointType));
      RespawnPointComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RespawnPointComponent>.NativeClassPtr, 100680676);
      RespawnPointComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RespawnPointComponent>.NativeClassPtr, 100680677);
      RespawnPointComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RespawnPointComponent>.NativeClassPtr, 100680678);
    }

    public RespawnPointComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent SpawnTravelBuffPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RespawnPointComponent.NativeFieldInfoPtr_SpawnTravelBuffPrefab));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RespawnPointComponent.NativeFieldInfoPtr_SpawnTravelBuffPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent SpawnSleepingBuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RespawnPointComponent.NativeFieldInfoPtr_SpawnSleepingBuff));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RespawnPointComponent.NativeFieldInfoPtr_SpawnSleepingBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float3 SpawnExitOffset
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RespawnPointComponent.NativeFieldInfoPtr_SpawnExitOffset));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RespawnPointComponent.NativeFieldInfoPtr_SpawnExitOffset)) = value;
      }
    }

    public unsafe SequenceField SpawnAnimationSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RespawnPointComponent.NativeFieldInfoPtr_SpawnAnimationSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RespawnPointComponent.NativeFieldInfoPtr_SpawnAnimationSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RespawnPointType RespawnPointType
    {
      get
      {
        return *(RespawnPointType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RespawnPointComponent.NativeFieldInfoPtr_RespawnPointType));
      }
      [param: In] set
      {
        *(RespawnPointType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RespawnPointComponent.NativeFieldInfoPtr_RespawnPointType)) = value;
      }
    }
  }
}
