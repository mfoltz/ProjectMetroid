// Decompiled with JetBrains decompiler
// Type: ProjectM.SubSceneConversionSettingsAssetDependency
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
  public class SubSceneConversionSettingsAssetDependency : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ConversionSettingsAsset;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SubSceneConversionSettingsAssetDependency()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubSceneConversionSettingsAssetDependency>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SubSceneConversionSettingsAssetDependency.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SubSceneConversionSettingsAssetDependency()
    {
      Il2CppClassPointerStore<SubSceneConversionSettingsAssetDependency>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SubSceneConversionSettingsAssetDependency));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubSceneConversionSettingsAssetDependency>.NativeClassPtr);
      SubSceneConversionSettingsAssetDependency.NativeFieldInfoPtr_ConversionSettingsAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubSceneConversionSettingsAssetDependency>.NativeClassPtr, nameof (ConversionSettingsAsset));
      SubSceneConversionSettingsAssetDependency.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSceneConversionSettingsAssetDependency>.NativeClassPtr, 100665004);
    }

    public SubSceneConversionSettingsAssetDependency(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ConversionSettingsAsset ConversionSettingsAsset
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubSceneConversionSettingsAssetDependency.NativeFieldInfoPtr_ConversionSettingsAsset));
        return pointer == IntPtr.Zero ? (ConversionSettingsAsset) null : new ConversionSettingsAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SubSceneConversionSettingsAssetDependency.NativeFieldInfoPtr_ConversionSettingsAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
