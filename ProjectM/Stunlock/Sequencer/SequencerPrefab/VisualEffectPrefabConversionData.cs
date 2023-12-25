// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.SequencerPrefab.VisualEffectPrefabConversionData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Stunlock.Sequencer.SequencerPrefab
{
  [Serializable]
  public class VisualEffectPrefabConversionData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideData;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideParameterName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ColorMode;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VisualEffectPrefabConversionData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualEffectPrefabConversionData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VisualEffectPrefabConversionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VisualEffectPrefabConversionData()
    {
      Il2CppClassPointerStore<VisualEffectPrefabConversionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer.SequencerPrefab", nameof (VisualEffectPrefabConversionData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualEffectPrefabConversionData>.NativeClassPtr);
      VisualEffectPrefabConversionData.NativeFieldInfoPtr_OverrideData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectPrefabConversionData>.NativeClassPtr, nameof (OverrideData));
      VisualEffectPrefabConversionData.NativeFieldInfoPtr_OverrideParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectPrefabConversionData>.NativeClassPtr, nameof (OverrideParameterName));
      VisualEffectPrefabConversionData.NativeFieldInfoPtr_ColorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectPrefabConversionData>.NativeClassPtr, nameof (ColorMode));
      VisualEffectPrefabConversionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectPrefabConversionData>.NativeClassPtr, 100663965);
    }

    public VisualEffectPrefabConversionData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public VisualEffectOverride OverrideData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisualEffectPrefabConversionData.NativeFieldInfoPtr_OverrideData);
        return new VisualEffectOverride(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VisualEffectOverride>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisualEffectPrefabConversionData.NativeFieldInfoPtr_OverrideData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VisualEffectOverride>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe string OverrideParameterName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisualEffectPrefabConversionData.NativeFieldInfoPtr_OverrideParameterName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VisualEffectPrefabConversionData.NativeFieldInfoPtr_OverrideParameterName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe VFXColorMode ColorMode
    {
      get
      {
        return *(VFXColorMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisualEffectPrefabConversionData.NativeFieldInfoPtr_ColorMode));
      }
      [param: In] set
      {
        *(VFXColorMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisualEffectPrefabConversionData.NativeFieldInfoPtr_ColorMode)) = value;
      }
    }
  }
}
