// Decompiled with JetBrains decompiler
// Type: ProjectM.ColorCollection
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ColorCollection : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Colors;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ColorCollection()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorCollection>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ColorCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ColorCollection()
    {
      Il2CppClassPointerStore<ColorCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ColorCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorCollection>.NativeClassPtr);
      ColorCollection.NativeFieldInfoPtr_Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorCollection>.NativeClassPtr, nameof (Colors));
      ColorCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorCollection>.NativeClassPtr, 100663871);
    }

    public ColorCollection(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppStructArray<Color> Colors
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorCollection.NativeFieldInfoPtr_Colors));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<Color>) null : new Il2CppStructArray<Color>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ColorCollection.NativeFieldInfoPtr_Colors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
