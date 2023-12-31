// Decompiled with JetBrains decompiler
// Type: ProjectM.ColorAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ColorAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Color;
    private static readonly IntPtr NativeFieldInfoPtr_Name;
    private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Color_ColorAsset_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    public static unsafe implicit operator Color(ColorAsset ca)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ca);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColorAsset.NativeMethodInfoPtr_op_Implicit_Public_Static_Color_ColorAsset_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ColorAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ColorAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ColorAsset()
    {
      Il2CppClassPointerStore<ColorAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ColorAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorAsset>.NativeClassPtr);
      ColorAsset.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorAsset>.NativeClassPtr, nameof (Color));
      ColorAsset.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorAsset>.NativeClassPtr, nameof (Name));
      ColorAsset.NativeMethodInfoPtr_op_Implicit_Public_Static_Color_ColorAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorAsset>.NativeClassPtr, 100667389);
      ColorAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorAsset>.NativeClassPtr, 100667390);
    }

    public ColorAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Color Color
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorAsset.NativeFieldInfoPtr_Color));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorAsset.NativeFieldInfoPtr_Color)) = value;
      }
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorAsset.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorAsset.NativeFieldInfoPtr_Name)) = value;
      }
    }
  }
}
