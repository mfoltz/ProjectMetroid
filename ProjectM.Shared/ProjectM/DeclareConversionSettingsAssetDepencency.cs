// Decompiled with JetBrains decompiler
// Type: ProjectM.DeclareConversionSettingsAssetDepencency
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class DeclareConversionSettingsAssetDepencency : GameObjectConversionSystem
  {
    private static readonly IntPtr NativeFieldInfoPtr__HasRun;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnUpdate_b__1_0_Private_Void_SubSceneConversionSettingsAssetDependency_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736325, XrefRangeEnd = 736334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DeclareConversionSettingsAssetDepencency.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DeclareConversionSettingsAssetDepencency()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeclareConversionSettingsAssetDepencency>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeclareConversionSettingsAssetDepencency.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736334, XrefRangeEnd = 736348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__1_0(
      SubSceneConversionSettingsAssetDependency dependency)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dependency);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeclareConversionSettingsAssetDepencency.NativeMethodInfoPtr__OnUpdate_b__1_0_Private_Void_SubSceneConversionSettingsAssetDependency_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DeclareConversionSettingsAssetDepencency.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DeclareConversionSettingsAssetDepencency()
    {
      Il2CppClassPointerStore<DeclareConversionSettingsAssetDepencency>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DeclareConversionSettingsAssetDepencency));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeclareConversionSettingsAssetDepencency>.NativeClassPtr);
      DeclareConversionSettingsAssetDepencency.NativeFieldInfoPtr__HasRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeclareConversionSettingsAssetDepencency>.NativeClassPtr, nameof (_HasRun));
      DeclareConversionSettingsAssetDepencency.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeclareConversionSettingsAssetDepencency>.NativeClassPtr, 100665005);
      DeclareConversionSettingsAssetDepencency.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeclareConversionSettingsAssetDepencency>.NativeClassPtr, 100665006);
      DeclareConversionSettingsAssetDepencency.NativeMethodInfoPtr__OnUpdate_b__1_0_Private_Void_SubSceneConversionSettingsAssetDependency_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeclareConversionSettingsAssetDepencency>.NativeClassPtr, 100665007);
      DeclareConversionSettingsAssetDepencency.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeclareConversionSettingsAssetDepencency>.NativeClassPtr, 100665008);
    }

    public DeclareConversionSettingsAssetDepencency(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool _HasRun
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeclareConversionSettingsAssetDepencency.NativeFieldInfoPtr__HasRun));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeclareConversionSettingsAssetDepencency.NativeFieldInfoPtr__HasRun)) = value;
      }
    }
  }
}
