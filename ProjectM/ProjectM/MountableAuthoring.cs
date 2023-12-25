// Decompiled with JetBrains decompiler
// Type: ProjectM.MountableAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public class MountableAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MountInventoryInteractRadius;
    private static readonly IntPtr NativeFieldInfoPtr_MountBuff;
    private static readonly IntPtr NativeFieldInfoPtr_MaxSpeedRange;
    private static readonly IntPtr NativeFieldInfoPtr_AccelerationRange;
    private static readonly IntPtr NativeFieldInfoPtr_RotationRange;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025093, XrefRangeEnd = 1025097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(MountableAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025097, XrefRangeEnd = 1025101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MountableAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025101, XrefRangeEnd = 1025102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MountableAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MountableAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MountableAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MountableAuthoring()
    {
      Il2CppClassPointerStore<MountableAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (MountableAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MountableAuthoring>.NativeClassPtr);
      MountableAuthoring.NativeFieldInfoPtr_MountInventoryInteractRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountableAuthoring>.NativeClassPtr, nameof (MountInventoryInteractRadius));
      MountableAuthoring.NativeFieldInfoPtr_MountBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountableAuthoring>.NativeClassPtr, nameof (MountBuff));
      MountableAuthoring.NativeFieldInfoPtr_MaxSpeedRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountableAuthoring>.NativeClassPtr, nameof (MaxSpeedRange));
      MountableAuthoring.NativeFieldInfoPtr_AccelerationRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountableAuthoring>.NativeClassPtr, nameof (AccelerationRange));
      MountableAuthoring.NativeFieldInfoPtr_RotationRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountableAuthoring>.NativeClassPtr, nameof (RotationRange));
      MountableAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountableAuthoring>.NativeClassPtr, 100680109);
      MountableAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountableAuthoring>.NativeClassPtr, 100680110);
      MountableAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountableAuthoring>.NativeClassPtr, 100680111);
    }

    public MountableAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe float MountInventoryInteractRadius
    {
      get
      {
        float inventoryInteractRadius;
        IL2CPP.il2cpp_field_static_get_value(MountableAuthoring.NativeFieldInfoPtr_MountInventoryInteractRadius, (void*) &inventoryInteractRadius);
        return inventoryInteractRadius;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MountableAuthoring.NativeFieldInfoPtr_MountInventoryInteractRadius, (void*) &value);
      }
    }

    public unsafe PrefabGuidComponent MountBuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountableAuthoring.NativeFieldInfoPtr_MountBuff));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountableAuthoring.NativeFieldInfoPtr_MountBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float2 MaxSpeedRange
    {
      get
      {
        return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountableAuthoring.NativeFieldInfoPtr_MaxSpeedRange));
      }
      [param: In] set
      {
        *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountableAuthoring.NativeFieldInfoPtr_MaxSpeedRange)) = value;
      }
    }

    public unsafe float2 AccelerationRange
    {
      get
      {
        return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountableAuthoring.NativeFieldInfoPtr_AccelerationRange));
      }
      [param: In] set
      {
        *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountableAuthoring.NativeFieldInfoPtr_AccelerationRange)) = value;
      }
    }

    public unsafe float2 RotationRange
    {
      get
      {
        return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountableAuthoring.NativeFieldInfoPtr_RotationRange));
      }
      [param: In] set
      {
        *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountableAuthoring.NativeFieldInfoPtr_RotationRange)) = value;
      }
    }
  }
}
