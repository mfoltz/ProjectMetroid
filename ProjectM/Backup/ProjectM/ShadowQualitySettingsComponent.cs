// Decompiled with JetBrains decompiler
// Type: ProjectM.ShadowQualitySettingsComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using Unity.Rendering;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ShadowQualitySettingsComponent : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ShadowQualitySettings;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063369, XrefRangeEnd = 1063395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShadowQualitySettingsComponent.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ShadowQualitySettingsComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowQualitySettingsComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShadowQualitySettingsComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ShadowQualitySettingsComponent()
    {
      Il2CppClassPointerStore<ShadowQualitySettingsComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ShadowQualitySettingsComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowQualitySettingsComponent>.NativeClassPtr);
      ShadowQualitySettingsComponent.NativeFieldInfoPtr_ShadowQualitySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowQualitySettingsComponent>.NativeClassPtr, nameof (ShadowQualitySettings));
      ShadowQualitySettingsComponent.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowQualitySettingsComponent>.NativeClassPtr, 100683487);
      ShadowQualitySettingsComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowQualitySettingsComponent>.NativeClassPtr, 100683488);
    }

    public ShadowQualitySettingsComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<ShadowQualitySettingsComponent.ShadowQualitySetting> ShadowQualitySettings
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowQualitySettingsComponent.NativeFieldInfoPtr_ShadowQualitySettings));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ShadowQualitySettingsComponent.ShadowQualitySetting>) null : new Il2CppReferenceArray<ShadowQualitySettingsComponent.ShadowQualitySetting>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowQualitySettingsComponent.NativeFieldInfoPtr_ShadowQualitySettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class ShadowQualitySetting : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_RendererComponent;
      private static readonly System.IntPtr NativeFieldInfoPtr_ShadowQuality;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ShadowQualitySetting()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowQualitySettingsComponent.ShadowQualitySetting>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShadowQualitySettingsComponent.ShadowQualitySetting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ShadowQualitySetting()
      {
        Il2CppClassPointerStore<ShadowQualitySettingsComponent.ShadowQualitySetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShadowQualitySettingsComponent>.NativeClassPtr, nameof (ShadowQualitySetting));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowQualitySettingsComponent.ShadowQualitySetting>.NativeClassPtr);
        ShadowQualitySettingsComponent.ShadowQualitySetting.NativeFieldInfoPtr_RendererComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowQualitySettingsComponent.ShadowQualitySetting>.NativeClassPtr, nameof (RendererComponent));
        ShadowQualitySettingsComponent.ShadowQualitySetting.NativeFieldInfoPtr_ShadowQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowQualitySettingsComponent.ShadowQualitySetting>.NativeClassPtr, nameof (ShadowQuality));
        ShadowQualitySettingsComponent.ShadowQualitySetting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowQualitySettingsComponent.ShadowQualitySetting>.NativeClassPtr, 100683489);
      }

      public ShadowQualitySetting(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe MeshRenderer RendererComponent
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowQualitySettingsComponent.ShadowQualitySetting.NativeFieldInfoPtr_RendererComponent));
          return pointer == System.IntPtr.Zero ? (MeshRenderer) null : new MeshRenderer(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowQualitySettingsComponent.ShadowQualitySetting.NativeFieldInfoPtr_RendererComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ShadowQualityLevel ShadowQuality
      {
        get
        {
          return *(ShadowQualityLevel*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowQualitySettingsComponent.ShadowQualitySetting.NativeFieldInfoPtr_ShadowQuality));
        }
        [param: In] set
        {
          *(ShadowQualityLevel*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowQualitySettingsComponent.ShadowQualitySetting.NativeFieldInfoPtr_ShadowQuality)) = value;
        }
      }
    }
  }
}
