// Decompiled with JetBrains decompiler
// Type: ProjectM.Roofs.RoofTileAuthoring
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Terrain;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Roofs
{
  public class RoofTileAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_RoofCategory;
    private static readonly IntPtr NativeFieldInfoPtr_TileBlobType;
    private static readonly IntPtr NativeFieldInfoPtr_RotationOffset;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191507, XrefRangeEnd = 1191513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(RoofTileAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RoofTileAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoofTileAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoofTileAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RoofTileAuthoring()
    {
      Il2CppClassPointerStore<RoofTileAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.Roofs", nameof (RoofTileAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoofTileAuthoring>.NativeClassPtr);
      RoofTileAuthoring.NativeFieldInfoPtr_RoofCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTileAuthoring>.NativeClassPtr, nameof (RoofCategory));
      RoofTileAuthoring.NativeFieldInfoPtr_TileBlobType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTileAuthoring>.NativeClassPtr, nameof (TileBlobType));
      RoofTileAuthoring.NativeFieldInfoPtr_RotationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTileAuthoring>.NativeClassPtr, nameof (RotationOffset));
      RoofTileAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTileAuthoring>.NativeClassPtr, 100663457);
      RoofTileAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTileAuthoring>.NativeClassPtr, 100663458);
    }

    public RoofTileAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RoofCategoryType RoofCategory
    {
      get
      {
        return *(RoofCategoryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTileAuthoring.NativeFieldInfoPtr_RoofCategory));
      }
      [param: In] set
      {
        *(RoofCategoryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTileAuthoring.NativeFieldInfoPtr_RoofCategory)) = value;
      }
    }

    public unsafe TileBlobRootType TileBlobType
    {
      get
      {
        return *(TileBlobRootType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTileAuthoring.NativeFieldInfoPtr_TileBlobType));
      }
      [param: In] set
      {
        *(TileBlobRootType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTileAuthoring.NativeFieldInfoPtr_TileBlobType)) = value;
      }
    }

    public unsafe OrthogonalRotation RotationOffset
    {
      get
      {
        return *(OrthogonalRotation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTileAuthoring.NativeFieldInfoPtr_RotationOffset));
      }
      [param: In] set
      {
        *(OrthogonalRotation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTileAuthoring.NativeFieldInfoPtr_RotationOffset)) = value;
      }
    }
  }
}
