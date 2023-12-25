// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleBuildingShowOnlyInPreviewConversionSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class CastleBuildingShowOnlyInPreviewConversionSystem : GameObjectConversionSystem
  {
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddComponentRecursively_Private_Void_Transform_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_CastleBuildingShowOnlyInPreviewComponent_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127217, XrefRangeEnd = 1127226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuildingShowOnlyInPreviewConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1127250, RefRangeEnd = 1127252, XrefRangeStart = 1127226, XrefRangeEnd = 1127250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddComponentRecursively(Transform transform)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingShowOnlyInPreviewConversionSystem.NativeMethodInfoPtr_AddComponentRecursively_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleBuildingShowOnlyInPreviewConversionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleBuildingShowOnlyInPreviewConversionSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingShowOnlyInPreviewConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127252, XrefRangeEnd = 1127255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__0_0(CastleBuildingShowOnlyInPreviewComponent component)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) component);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingShowOnlyInPreviewConversionSystem.NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_CastleBuildingShowOnlyInPreviewComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuildingShowOnlyInPreviewConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleBuildingShowOnlyInPreviewConversionSystem()
    {
      Il2CppClassPointerStore<CastleBuildingShowOnlyInPreviewConversionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleBuildingShowOnlyInPreviewConversionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingShowOnlyInPreviewConversionSystem>.NativeClassPtr);
      CastleBuildingShowOnlyInPreviewConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingShowOnlyInPreviewConversionSystem>.NativeClassPtr, 100689535);
      CastleBuildingShowOnlyInPreviewConversionSystem.NativeMethodInfoPtr_AddComponentRecursively_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingShowOnlyInPreviewConversionSystem>.NativeClassPtr, 100689536);
      CastleBuildingShowOnlyInPreviewConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingShowOnlyInPreviewConversionSystem>.NativeClassPtr, 100689537);
      CastleBuildingShowOnlyInPreviewConversionSystem.NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_CastleBuildingShowOnlyInPreviewComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingShowOnlyInPreviewConversionSystem>.NativeClassPtr, 100689538);
      CastleBuildingShowOnlyInPreviewConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingShowOnlyInPreviewConversionSystem>.NativeClassPtr, 100689539);
    }

    public CastleBuildingShowOnlyInPreviewConversionSystem(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
