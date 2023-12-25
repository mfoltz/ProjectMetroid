// Decompiled with JetBrains decompiler
// Type: ProjectM.Wind.FoliageSpringAuthoring
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
namespace ProjectM.Wind
{
  public class FoliageSpringAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_TrunkMovementScale;
    private static readonly IntPtr NativeFieldInfoPtr_TrunkBending;
    private static readonly IntPtr NativeFieldInfoPtr_LeafMovementScale;
    private static readonly IntPtr NativeFieldInfoPtr_LeafBending;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085121, XrefRangeEnd = 1085124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(FoliageSpringAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085124, XrefRangeEnd = 1085125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FoliageSpringAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FoliageSpringAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FoliageSpringAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FoliageSpringAuthoring()
    {
      Il2CppClassPointerStore<FoliageSpringAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Wind", nameof (FoliageSpringAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FoliageSpringAuthoring>.NativeClassPtr);
      FoliageSpringAuthoring.NativeFieldInfoPtr_TrunkMovementScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageSpringAuthoring>.NativeClassPtr, nameof (TrunkMovementScale));
      FoliageSpringAuthoring.NativeFieldInfoPtr_TrunkBending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageSpringAuthoring>.NativeClassPtr, nameof (TrunkBending));
      FoliageSpringAuthoring.NativeFieldInfoPtr_LeafMovementScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageSpringAuthoring>.NativeClassPtr, nameof (LeafMovementScale));
      FoliageSpringAuthoring.NativeFieldInfoPtr_LeafBending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoliageSpringAuthoring>.NativeClassPtr, nameof (LeafBending));
      FoliageSpringAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoliageSpringAuthoring>.NativeClassPtr, 100685465);
      FoliageSpringAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoliageSpringAuthoring>.NativeClassPtr, 100685466);
    }

    public FoliageSpringAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float TrunkMovementScale
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FoliageSpringAuthoring.NativeFieldInfoPtr_TrunkMovementScale));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FoliageSpringAuthoring.NativeFieldInfoPtr_TrunkMovementScale)) = value;
      }
    }

    public unsafe float TrunkBending
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FoliageSpringAuthoring.NativeFieldInfoPtr_TrunkBending));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FoliageSpringAuthoring.NativeFieldInfoPtr_TrunkBending)) = value;
      }
    }

    public unsafe float LeafMovementScale
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FoliageSpringAuthoring.NativeFieldInfoPtr_LeafMovementScale));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FoliageSpringAuthoring.NativeFieldInfoPtr_LeafMovementScale)) = value;
      }
    }

    public unsafe float LeafBending
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FoliageSpringAuthoring.NativeFieldInfoPtr_LeafBending));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FoliageSpringAuthoring.NativeFieldInfoPtr_LeafBending)) = value;
      }
    }
  }
}
