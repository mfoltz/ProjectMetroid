// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleFloorComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Roofs;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class CastleFloorComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_FloorType;
    private static readonly IntPtr NativeFieldInfoPtr_RoofType;
    private static readonly IntPtr NativeFieldInfoPtr_Impassable;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794328, XrefRangeEnd = 794337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(CastleFloorComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794337, XrefRangeEnd = 794344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleFloorComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleFloorComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleFloorComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleFloorComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleFloorComponent()
    {
      Il2CppClassPointerStore<CastleFloorComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding", nameof (CastleFloorComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleFloorComponent>.NativeClassPtr);
      CastleFloorComponent.NativeFieldInfoPtr_FloorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorComponent>.NativeClassPtr, nameof (FloorType));
      CastleFloorComponent.NativeFieldInfoPtr_RoofType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorComponent>.NativeClassPtr, nameof (RoofType));
      CastleFloorComponent.NativeFieldInfoPtr_Impassable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloorComponent>.NativeClassPtr, nameof (Impassable));
      CastleFloorComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorComponent>.NativeClassPtr, 100670037);
      CastleFloorComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorComponent>.NativeClassPtr, 100670038);
      CastleFloorComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloorComponent>.NativeClassPtr, 100670039);
    }

    public CastleFloorComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CastleFloorTypes FloorType
    {
      get
      {
        return *(CastleFloorTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorComponent.NativeFieldInfoPtr_FloorType));
      }
      [param: In] set
      {
        *(CastleFloorTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorComponent.NativeFieldInfoPtr_FloorType)) = value;
      }
    }

    public unsafe RoofCategoryType RoofType
    {
      get
      {
        return *(RoofCategoryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorComponent.NativeFieldInfoPtr_RoofType));
      }
      [param: In] set
      {
        *(RoofCategoryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorComponent.NativeFieldInfoPtr_RoofType)) = value;
      }
    }

    public unsafe bool Impassable
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorComponent.NativeFieldInfoPtr_Impassable));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleFloorComponent.NativeFieldInfoPtr_Impassable)) = value;
      }
    }
  }
}
