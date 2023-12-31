// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ItemLevelRaritySettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class ItemLevelRaritySettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_ItemRarityColors;
    private static readonly IntPtr NativeMethodInfoPtr_GetIndex_Public_Int32_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Color_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 794834, RefRangeEnd = 794837, XrefRangeStart = 794832, XrefRangeEnd = 794834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetIndex(float itemLevel)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &itemLevel;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ItemLevelRaritySettings.NativeMethodInfoPtr_GetIndex_Public_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 794847, RefRangeEnd = 794848, XrefRangeStart = 794837, XrefRangeEnd = 794847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Color GetColor(float itemLevel)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &itemLevel;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ItemLevelRaritySettings.NativeMethodInfoPtr_GetColor_Public_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ItemLevelRaritySettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemLevelRaritySettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ItemLevelRaritySettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ItemLevelRaritySettings()
    {
      Il2CppClassPointerStore<ItemLevelRaritySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (ItemLevelRaritySettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemLevelRaritySettings>.NativeClassPtr);
      ItemLevelRaritySettings.NativeFieldInfoPtr_ItemRarityColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemLevelRaritySettings>.NativeClassPtr, nameof (ItemRarityColors));
      ItemLevelRaritySettings.NativeMethodInfoPtr_GetIndex_Public_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemLevelRaritySettings>.NativeClassPtr, 100670086);
      ItemLevelRaritySettings.NativeMethodInfoPtr_GetColor_Public_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemLevelRaritySettings>.NativeClassPtr, 100670087);
      ItemLevelRaritySettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemLevelRaritySettings>.NativeClassPtr, 100670088);
    }

    public ItemLevelRaritySettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<Color> ItemRarityColors
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemLevelRaritySettings.NativeFieldInfoPtr_ItemRarityColors));
        return pointer == IntPtr.Zero ? (List<Color>) null : new List<Color>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemLevelRaritySettings.NativeFieldInfoPtr_ItemRarityColors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
