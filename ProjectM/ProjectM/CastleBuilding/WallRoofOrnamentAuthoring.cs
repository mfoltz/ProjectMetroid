// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.WallRoofOrnamentAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class WallRoofOrnamentAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_OrnamentPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_CountWallAsRoofOpening;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129001, XrefRangeEnd = 1129005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(WallRoofOrnamentAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129005, XrefRangeEnd = 1129006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WallRoofOrnamentAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WallRoofOrnamentAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WallRoofOrnamentAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WallRoofOrnamentAuthoring()
    {
      Il2CppClassPointerStore<WallRoofOrnamentAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (WallRoofOrnamentAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallRoofOrnamentAuthoring>.NativeClassPtr);
      WallRoofOrnamentAuthoring.NativeFieldInfoPtr_OrnamentPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallRoofOrnamentAuthoring>.NativeClassPtr, nameof (OrnamentPrefab));
      WallRoofOrnamentAuthoring.NativeFieldInfoPtr_CountWallAsRoofOpening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallRoofOrnamentAuthoring>.NativeClassPtr, nameof (CountWallAsRoofOpening));
      WallRoofOrnamentAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallRoofOrnamentAuthoring>.NativeClassPtr, 100689718);
      WallRoofOrnamentAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallRoofOrnamentAuthoring>.NativeClassPtr, 100689719);
    }

    public WallRoofOrnamentAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> OrnamentPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallRoofOrnamentAuthoring.NativeFieldInfoPtr_OrnamentPrefab));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WallRoofOrnamentAuthoring.NativeFieldInfoPtr_OrnamentPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool CountWallAsRoofOpening
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallRoofOrnamentAuthoring.NativeFieldInfoPtr_CountWallAsRoofOpening));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallRoofOrnamentAuthoring.NativeFieldInfoPtr_CountWallAsRoofOpening)) = value;
      }
    }
  }
}
