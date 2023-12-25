// Decompiled with JetBrains decompiler
// Type: SunBlockerConversion
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System;

#nullable disable
public class SunBlockerConversion : GameObjectConversionSystem
{
  private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_ShadowQualitySettingsComponent_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921733, XrefRangeEnd = 921742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SunBlockerConversion.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(105)]
  [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SunBlockerConversion()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SunBlockerConversion>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SunBlockerConversion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921742, XrefRangeEnd = 921767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _OnUpdate_b__0_0(ShadowQualitySettingsComponent shadowSettingsComp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shadowSettingsComp);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SunBlockerConversion.NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_ShadowQualitySettingsComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1696)]
  [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnCreateForCompiler()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SunBlockerConversion.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SunBlockerConversion()
  {
    Il2CppClassPointerStore<SunBlockerConversion>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (SunBlockerConversion));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SunBlockerConversion>.NativeClassPtr);
    SunBlockerConversion.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunBlockerConversion>.NativeClassPtr, 100663711);
    SunBlockerConversion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunBlockerConversion>.NativeClassPtr, 100663712);
    SunBlockerConversion.NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_ShadowQualitySettingsComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunBlockerConversion>.NativeClassPtr, 100663713);
    SunBlockerConversion.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunBlockerConversion>.NativeClassPtr, 100663714);
  }

  public SunBlockerConversion(IntPtr pointer)
    : base(pointer)
  {
  }
}
