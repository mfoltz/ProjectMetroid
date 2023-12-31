// Decompiled with JetBrains decompiler
// Type: ProjectM.ConversionSettingsAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ConversionSettingsAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_ConversionTarget;
    private static readonly IntPtr NativeFieldInfoPtr_UseSubScenesForUI;
    private static readonly IntPtr NativeFieldInfoPtr_UseSubScenesForStreamingAssets;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConversionSettingsAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversionSettingsAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConversionSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ConversionSettingsAsset()
    {
      Il2CppClassPointerStore<ConversionSettingsAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ConversionSettingsAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversionSettingsAsset>.NativeClassPtr);
      ConversionSettingsAsset.NativeFieldInfoPtr_ConversionTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversionSettingsAsset>.NativeClassPtr, nameof (ConversionTarget));
      ConversionSettingsAsset.NativeFieldInfoPtr_UseSubScenesForUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversionSettingsAsset>.NativeClassPtr, nameof (UseSubScenesForUI));
      ConversionSettingsAsset.NativeFieldInfoPtr_UseSubScenesForStreamingAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversionSettingsAsset>.NativeClassPtr, nameof (UseSubScenesForStreamingAssets));
      ConversionSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionSettingsAsset>.NativeClassPtr, 100664894);
    }

    public ConversionSettingsAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ApplicationConversionTarget ConversionTarget
    {
      get
      {
        return *(ApplicationConversionTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConversionSettingsAsset.NativeFieldInfoPtr_ConversionTarget));
      }
      [param: In] set
      {
        *(ApplicationConversionTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConversionSettingsAsset.NativeFieldInfoPtr_ConversionTarget)) = value;
      }
    }

    public unsafe bool UseSubScenesForUI
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConversionSettingsAsset.NativeFieldInfoPtr_UseSubScenesForUI));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConversionSettingsAsset.NativeFieldInfoPtr_UseSubScenesForUI)) = value;
      }
    }

    public unsafe bool UseSubScenesForStreamingAssets
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConversionSettingsAsset.NativeFieldInfoPtr_UseSubScenesForStreamingAssets));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConversionSettingsAsset.NativeFieldInfoPtr_UseSubScenesForStreamingAssets)) = value;
      }
    }
  }
}
