// Decompiled with JetBrains decompiler
// Type: ProjectM.UpgradeableFromTileModelAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class UpgradeableFromTileModelAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_RequireUpgradingToBuild;
    private static readonly IntPtr NativeFieldInfoPtr_FromPrefabs;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732286, XrefRangeEnd = 732315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(UpgradeableFromTileModelAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732315, XrefRangeEnd = 732316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UpgradeableFromTileModelAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpgradeableFromTileModelAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpgradeableFromTileModelAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UpgradeableFromTileModelAuthoring()
    {
      Il2CppClassPointerStore<UpgradeableFromTileModelAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UpgradeableFromTileModelAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpgradeableFromTileModelAuthoring>.NativeClassPtr);
      UpgradeableFromTileModelAuthoring.NativeFieldInfoPtr_RequireUpgradingToBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeableFromTileModelAuthoring>.NativeClassPtr, nameof (RequireUpgradingToBuild));
      UpgradeableFromTileModelAuthoring.NativeFieldInfoPtr_FromPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeableFromTileModelAuthoring>.NativeClassPtr, nameof (FromPrefabs));
      UpgradeableFromTileModelAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeableFromTileModelAuthoring>.NativeClassPtr, 100664694);
      UpgradeableFromTileModelAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeableFromTileModelAuthoring>.NativeClassPtr, 100664695);
    }

    public UpgradeableFromTileModelAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool RequireUpgradingToBuild
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeableFromTileModelAuthoring.NativeFieldInfoPtr_RequireUpgradingToBuild));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeableFromTileModelAuthoring.NativeFieldInfoPtr_RequireUpgradingToBuild)) = value;
      }
    }

    public unsafe List<WeakAssetReference<PrefabGuidComponent>> FromPrefabs
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeableFromTileModelAuthoring.NativeFieldInfoPtr_FromPrefabs));
        return pointer == IntPtr.Zero ? (List<WeakAssetReference<PrefabGuidComponent>>) null : new List<WeakAssetReference<PrefabGuidComponent>>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpgradeableFromTileModelAuthoring.NativeFieldInfoPtr_FromPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
