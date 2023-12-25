// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileBrushTypeHelpers
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Tiles
{
  public static class TileBrushTypeHelpers : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__BrushNames;
    private static readonly System.IntPtr NativeFieldInfoPtr__Colors;
    private static readonly System.IntPtr NativeFieldInfoPtr__Count_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_Static_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Count_Private_Static_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_TileBrushType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_TileBrushType_0;

    public static unsafe int Count
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085962, XrefRangeEnd = 1085966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBrushTypeHelpers.NativeMethodInfoPtr_get_Count_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085966, XrefRangeEnd = 1085970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileBrushTypeHelpers.NativeMethodInfoPtr_set_Count_Private_Static_set_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085970, XrefRangeEnd = 1085993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Initialize()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileBrushTypeHelpers.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085993, XrefRangeEnd = 1085997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetName(TileBrushType brushType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &brushType;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TileBrushTypeHelpers.NativeMethodInfoPtr_GetName_Public_Static_String_TileBrushType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085997, XrefRangeEnd = 1086001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Color GetColor(TileBrushType brushType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &brushType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBrushTypeHelpers.NativeMethodInfoPtr_GetColor_Public_Static_Color_TileBrushType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileBrushTypeHelpers()
    {
      Il2CppClassPointerStore<TileBrushTypeHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (TileBrushTypeHelpers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileBrushTypeHelpers>.NativeClassPtr);
      TileBrushTypeHelpers.NativeFieldInfoPtr__BrushNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBrushTypeHelpers>.NativeClassPtr, nameof (_BrushNames));
      TileBrushTypeHelpers.NativeFieldInfoPtr__Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBrushTypeHelpers>.NativeClassPtr, nameof (_Colors));
      TileBrushTypeHelpers.NativeFieldInfoPtr__Count_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBrushTypeHelpers>.NativeClassPtr, "<Count>k__BackingField");
      TileBrushTypeHelpers.NativeMethodInfoPtr_get_Count_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushTypeHelpers>.NativeClassPtr, 100685540);
      TileBrushTypeHelpers.NativeMethodInfoPtr_set_Count_Private_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushTypeHelpers>.NativeClassPtr, 100685541);
      TileBrushTypeHelpers.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushTypeHelpers>.NativeClassPtr, 100685542);
      TileBrushTypeHelpers.NativeMethodInfoPtr_GetName_Public_Static_String_TileBrushType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushTypeHelpers>.NativeClassPtr, 100685543);
      TileBrushTypeHelpers.NativeMethodInfoPtr_GetColor_Public_Static_Color_TileBrushType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushTypeHelpers>.NativeClassPtr, 100685544);
    }

    public TileBrushTypeHelpers(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Il2CppStringArray _BrushNames
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TileBrushTypeHelpers.NativeFieldInfoPtr__BrushNames, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileBrushTypeHelpers.NativeFieldInfoPtr__BrushNames, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppStructArray<Color> _Colors
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TileBrushTypeHelpers.NativeFieldInfoPtr__Colors, (void*) &num);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Color>) null : new Il2CppStructArray<Color>(nativeObject);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileBrushTypeHelpers.NativeFieldInfoPtr__Colors, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe int _Count_k__BackingField
    {
      get
      {
        int countKBackingField;
        IL2CPP.il2cpp_field_static_get_value(TileBrushTypeHelpers.NativeFieldInfoPtr__Count_k__BackingField, (void*) &countKBackingField);
        return countKBackingField;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileBrushTypeHelpers.NativeFieldInfoPtr__Count_k__BackingField, (void*) &value);
      }
    }
  }
}
