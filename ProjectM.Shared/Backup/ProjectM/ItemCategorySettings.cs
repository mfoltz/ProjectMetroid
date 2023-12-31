// Decompiled with JetBrains decompiler
// Type: ProjectM.ItemCategorySettings
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
namespace ProjectM
{
  public class ItemCategorySettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_ItemCategories;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ItemCategorySettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemCategorySettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ItemCategorySettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ItemCategorySettings()
    {
      Il2CppClassPointerStore<ItemCategorySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ItemCategorySettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemCategorySettings>.NativeClassPtr);
      ItemCategorySettings.NativeFieldInfoPtr_ItemCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemCategorySettings>.NativeClassPtr, nameof (ItemCategories));
      ItemCategorySettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemCategorySettings>.NativeClassPtr, 100667391);
    }

    public ItemCategorySettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<ItemCategoryData> ItemCategories
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemCategorySettings.NativeFieldInfoPtr_ItemCategories));
        return pointer == IntPtr.Zero ? (List<ItemCategoryData>) null : new List<ItemCategoryData>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemCategorySettings.NativeFieldInfoPtr_ItemCategories), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
