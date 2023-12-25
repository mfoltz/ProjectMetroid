// Decompiled with JetBrains decompiler
// Type: VFXReplacementSettings
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class VFXReplacementSettings : ScriptableObject
{
  private static readonly System.IntPtr NativeFieldInfoPtr_BloodEffectReplacements;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VFXReplacementSettings()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXReplacementSettings>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VFXReplacementSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static VFXReplacementSettings()
  {
    Il2CppClassPointerStore<VFXReplacementSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (VFXReplacementSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXReplacementSettings>.NativeClassPtr);
    VFXReplacementSettings.NativeFieldInfoPtr_BloodEffectReplacements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXReplacementSettings>.NativeClassPtr, nameof (BloodEffectReplacements));
    VFXReplacementSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXReplacementSettings>.NativeClassPtr, 100663710);
  }

  public VFXReplacementSettings(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe List<VFXReplacementSettings.VFXReplacement> BloodEffectReplacements
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXReplacementSettings.NativeFieldInfoPtr_BloodEffectReplacements));
      return pointer == System.IntPtr.Zero ? (List<VFXReplacementSettings.VFXReplacement>) null : new List<VFXReplacementSettings.VFXReplacement>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXReplacementSettings.NativeFieldInfoPtr_BloodEffectReplacements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class VFXReplacement : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FromVFXPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToVFXPrefab;

    static VFXReplacement()
    {
      Il2CppClassPointerStore<VFXReplacementSettings.VFXReplacement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VFXReplacementSettings>.NativeClassPtr, nameof (VFXReplacement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXReplacementSettings.VFXReplacement>.NativeClassPtr);
      VFXReplacementSettings.VFXReplacement.NativeFieldInfoPtr_FromVFXPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXReplacementSettings.VFXReplacement>.NativeClassPtr, nameof (FromVFXPrefab));
      VFXReplacementSettings.VFXReplacement.NativeFieldInfoPtr_ToVFXPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXReplacementSettings.VFXReplacement>.NativeClassPtr, nameof (ToVFXPrefab));
    }

    public VFXReplacement(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public VFXReplacement()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXReplacementSettings.VFXReplacement>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXReplacementSettings.VFXReplacement>.NativeClassPtr, data));
    }

    public unsafe GameObject FromVFXPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXReplacementSettings.VFXReplacement.NativeFieldInfoPtr_FromVFXPrefab));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXReplacementSettings.VFXReplacement.NativeFieldInfoPtr_FromVFXPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject ToVFXPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXReplacementSettings.VFXReplacement.NativeFieldInfoPtr_ToVFXPrefab));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXReplacementSettings.VFXReplacement.NativeFieldInfoPtr_ToVFXPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
