// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.ProxyVFXGradient
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Presentation
{
  public sealed class ProxyVFXGradient : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_colorKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_alphaKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_mode;

    static ProxyVFXGradient()
    {
      Il2CppClassPointerStore<ProxyVFXGradient>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (ProxyVFXGradient));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProxyVFXGradient>.NativeClassPtr);
      ProxyVFXGradient.NativeFieldInfoPtr_colorKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXGradient>.NativeClassPtr, nameof (colorKeys));
      ProxyVFXGradient.NativeFieldInfoPtr_alphaKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXGradient>.NativeClassPtr, nameof (alphaKeys));
      ProxyVFXGradient.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXGradient>.NativeClassPtr, nameof (mode));
    }

    public ProxyVFXGradient(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ProxyVFXGradient()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProxyVFXGradient>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProxyVFXGradient>.NativeClassPtr, data));
    }

    public unsafe Il2CppStructArray<GradientColorKey> colorKeys
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyVFXGradient.NativeFieldInfoPtr_colorKeys));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<GradientColorKey>) null : new Il2CppStructArray<GradientColorKey>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProxyVFXGradient.NativeFieldInfoPtr_colorKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<GradientAlphaKey> alphaKeys
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyVFXGradient.NativeFieldInfoPtr_alphaKeys));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<GradientAlphaKey>) null : new Il2CppStructArray<GradientAlphaKey>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProxyVFXGradient.NativeFieldInfoPtr_alphaKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GradientMode mode
    {
      get
      {
        return *(GradientMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyVFXGradient.NativeFieldInfoPtr_mode));
      }
      [param: In] set
      {
        *(GradientMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyVFXGradient.NativeFieldInfoPtr_mode)) = value;
      }
    }
  }
}
