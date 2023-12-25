// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantDataAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ServantDataAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ServantType;
    private static readonly IntPtr NativeFieldInfoPtr_GenderType;
    private static readonly IntPtr NativeFieldInfoPtr_ConvertingDuration;
    private static readonly IntPtr NativeFieldInfoPtr_ConvertCost;
    private static readonly IntPtr NativeFieldInfoPtr_RevivingDuration;
    private static readonly IntPtr NativeFieldInfoPtr_ReviveCostModifier;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993030, XrefRangeEnd = 993068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ServantDataAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993068, XrefRangeEnd = 993078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantDataAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993078, XrefRangeEnd = 993079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantDataAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantDataAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantDataAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantDataAuthoring()
    {
      Il2CppClassPointerStore<ServantDataAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServantDataAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantDataAuthoring>.NativeClassPtr);
      ServantDataAuthoring.NativeFieldInfoPtr_ServantType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantDataAuthoring>.NativeClassPtr, nameof (ServantType));
      ServantDataAuthoring.NativeFieldInfoPtr_GenderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantDataAuthoring>.NativeClassPtr, nameof (GenderType));
      ServantDataAuthoring.NativeFieldInfoPtr_ConvertingDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantDataAuthoring>.NativeClassPtr, nameof (ConvertingDuration));
      ServantDataAuthoring.NativeFieldInfoPtr_ConvertCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantDataAuthoring>.NativeClassPtr, nameof (ConvertCost));
      ServantDataAuthoring.NativeFieldInfoPtr_RevivingDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantDataAuthoring>.NativeClassPtr, nameof (RevivingDuration));
      ServantDataAuthoring.NativeFieldInfoPtr_ReviveCostModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantDataAuthoring>.NativeClassPtr, nameof (ReviveCostModifier));
      ServantDataAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantDataAuthoring>.NativeClassPtr, 100676678);
      ServantDataAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantDataAuthoring>.NativeClassPtr, 100676679);
      ServantDataAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantDataAuthoring>.NativeClassPtr, 100676680);
    }

    public ServantDataAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ServantType ServantType
    {
      get
      {
        return *(ServantType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantDataAuthoring.NativeFieldInfoPtr_ServantType));
      }
      [param: In] set
      {
        *(ServantType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantDataAuthoring.NativeFieldInfoPtr_ServantType)) = value;
      }
    }

    public unsafe GenderType GenderType
    {
      get
      {
        return *(GenderType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantDataAuthoring.NativeFieldInfoPtr_GenderType));
      }
      [param: In] set
      {
        *(GenderType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantDataAuthoring.NativeFieldInfoPtr_GenderType)) = value;
      }
    }

    public unsafe BasicTimerSettings ConvertingDuration
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantDataAuthoring.NativeFieldInfoPtr_ConvertingDuration));
        return pointer == IntPtr.Zero ? (BasicTimerSettings) null : new BasicTimerSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantDataAuthoring.NativeFieldInfoPtr_ConvertingDuration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SharedItemRequirementAsset ConvertCost
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantDataAuthoring.NativeFieldInfoPtr_ConvertCost));
        return pointer == IntPtr.Zero ? (SharedItemRequirementAsset) null : new SharedItemRequirementAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantDataAuthoring.NativeFieldInfoPtr_ConvertCost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BasicTimerSettings RevivingDuration
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantDataAuthoring.NativeFieldInfoPtr_RevivingDuration));
        return pointer == IntPtr.Zero ? (BasicTimerSettings) null : new BasicTimerSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantDataAuthoring.NativeFieldInfoPtr_RevivingDuration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float ReviveCostModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantDataAuthoring.NativeFieldInfoPtr_ReviveCostModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantDataAuthoring.NativeFieldInfoPtr_ReviveCostModifier)) = value;
      }
    }
  }
}
