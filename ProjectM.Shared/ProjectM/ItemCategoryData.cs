// Decompiled with JetBrains decompiler
// Type: ProjectM.ItemCategoryData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class ItemCategoryData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;

    static ItemCategoryData()
    {
      Il2CppClassPointerStore<ItemCategoryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ItemCategoryData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemCategoryData>.NativeClassPtr);
      ItemCategoryData.NativeFieldInfoPtr_ItemCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemCategoryData>.NativeClassPtr, nameof (ItemCategory));
      ItemCategoryData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemCategoryData>.NativeClassPtr, nameof (Name));
      ItemCategoryData.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemCategoryData>.NativeClassPtr, nameof (Icon));
    }

    public ItemCategoryData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ItemCategoryData()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ItemCategoryData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemCategoryData>.NativeClassPtr, data));
    }

    public unsafe long ItemCategory
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemCategoryData.NativeFieldInfoPtr_ItemCategory));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemCategoryData.NativeFieldInfoPtr_ItemCategory)) = value;
      }
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemCategoryData.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemCategoryData.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe Sprite Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemCategoryData.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemCategoryData.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
