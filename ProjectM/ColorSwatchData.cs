// Decompiled with JetBrains decompiler
// Type: ColorSwatchData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
public class ColorSwatchData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_UiColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_SubSwatchAssetGuids;
  private static readonly System.IntPtr NativeFieldInfoPtr_SwatchNameHash;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Color_Public_Virtual_Final_New_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public virtual unsafe Color Color
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912333, XrefRangeEnd = 912334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColorSwatchData.NativeMethodInfoPtr_get_Color_Public_Virtual_Final_New_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(3875)]
  [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ColorSwatchData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSwatchData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ColorSwatchData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ColorSwatchData()
  {
    Il2CppClassPointerStore<ColorSwatchData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (ColorSwatchData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSwatchData>.NativeClassPtr);
    ColorSwatchData.NativeFieldInfoPtr_UiColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSwatchData>.NativeClassPtr, nameof (UiColor));
    ColorSwatchData.NativeFieldInfoPtr_SubSwatchAssetGuids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSwatchData>.NativeClassPtr, nameof (SubSwatchAssetGuids));
    ColorSwatchData.NativeFieldInfoPtr_SwatchNameHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSwatchData>.NativeClassPtr, nameof (SwatchNameHash));
    ColorSwatchData.NativeMethodInfoPtr_get_Color_Public_Virtual_Final_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchData>.NativeClassPtr, 100663383);
    ColorSwatchData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchData>.NativeClassPtr, 100663384);
  }

  public ColorSwatchData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float4 UiColor
  {
    get
    {
      return *(float4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorSwatchData.NativeFieldInfoPtr_UiColor));
    }
    [param: In] set
    {
      *(float4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorSwatchData.NativeFieldInfoPtr_UiColor)) = value;
    }
  }

  public unsafe Il2CppStructArray<PrefabGUID> SubSwatchAssetGuids
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorSwatchData.NativeFieldInfoPtr_SubSwatchAssetGuids));
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<PrefabGUID>) null : new Il2CppStructArray<PrefabGUID>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ColorSwatchData.NativeFieldInfoPtr_SubSwatchAssetGuids), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int SwatchNameHash
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorSwatchData.NativeFieldInfoPtr_SwatchNameHash));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorSwatchData.NativeFieldInfoPtr_SwatchNameHash)) = value;
    }
  }
}
