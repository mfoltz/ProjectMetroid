// Decompiled with JetBrains decompiler
// Type: ColorSwatchCollection
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
[Serializable]
public class ColorSwatchCollection : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_EditorUIName;
  private static readonly System.IntPtr NativeFieldInfoPtr_InternalSwatchName;
  private static readonly System.IntPtr NativeFieldInfoPtr_UiColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_SwatchAssets;
  private static readonly System.IntPtr NativeMethodInfoPtr_IColor_get_Color_Private_Virtual_Final_New_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetGuid_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGuid_Public_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGuidHash_Public_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public virtual unsafe Color IColor\u002EColor
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 29043, RefRangeEnd = 29047, XrefRangeStart = 29043, XrefRangeEnd = 29047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColorSwatchCollection.NativeMethodInfoPtr_IColor_get_Color_Private_Virtual_Final_New_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetGuid(string newGuid)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(newGuid);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ColorSwatchCollection.NativeMethodInfoPtr_SetGuid_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetGuid()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ColorSwatchCollection.NativeMethodInfoPtr_GetGuid_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 466385, RefRangeEnd = 466399, XrefRangeStart = 466385, XrefRangeEnd = 466399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetGuidHash()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColorSwatchCollection.NativeMethodInfoPtr_GetGuidHash_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912342, XrefRangeEnd = 912346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ColorSwatchCollection()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSwatchCollection>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ColorSwatchCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ColorSwatchCollection()
  {
    Il2CppClassPointerStore<ColorSwatchCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (ColorSwatchCollection));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSwatchCollection>.NativeClassPtr);
    ColorSwatchCollection.NativeFieldInfoPtr_EditorUIName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSwatchCollection>.NativeClassPtr, nameof (EditorUIName));
    ColorSwatchCollection.NativeFieldInfoPtr_InternalSwatchName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSwatchCollection>.NativeClassPtr, nameof (InternalSwatchName));
    ColorSwatchCollection.NativeFieldInfoPtr_UiColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSwatchCollection>.NativeClassPtr, nameof (UiColor));
    ColorSwatchCollection.NativeFieldInfoPtr_SwatchAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSwatchCollection>.NativeClassPtr, nameof (SwatchAssets));
    ColorSwatchCollection.NativeMethodInfoPtr_IColor_get_Color_Private_Virtual_Final_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchCollection>.NativeClassPtr, 100663388);
    ColorSwatchCollection.NativeMethodInfoPtr_SetGuid_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchCollection>.NativeClassPtr, 100663389);
    ColorSwatchCollection.NativeMethodInfoPtr_GetGuid_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchCollection>.NativeClassPtr, 100663390);
    ColorSwatchCollection.NativeMethodInfoPtr_GetGuidHash_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchCollection>.NativeClassPtr, 100663391);
    ColorSwatchCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSwatchCollection>.NativeClassPtr, 100663392);
  }

  public ColorSwatchCollection(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string EditorUIName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorSwatchCollection.NativeFieldInfoPtr_EditorUIName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ColorSwatchCollection.NativeFieldInfoPtr_EditorUIName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string InternalSwatchName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorSwatchCollection.NativeFieldInfoPtr_InternalSwatchName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ColorSwatchCollection.NativeFieldInfoPtr_InternalSwatchName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Color UiColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorSwatchCollection.NativeFieldInfoPtr_UiColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorSwatchCollection.NativeFieldInfoPtr_UiColor)) = value;
    }
  }

  public unsafe List<BuildMenuDyeSubSwatchAsset> SwatchAssets
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorSwatchCollection.NativeFieldInfoPtr_SwatchAssets));
      return pointer == System.IntPtr.Zero ? (List<BuildMenuDyeSubSwatchAsset>) null : new List<BuildMenuDyeSubSwatchAsset>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ColorSwatchCollection.NativeFieldInfoPtr_SwatchAssets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
