// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ItemSetInfo
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public sealed class ItemSetInfo : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SetName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemList;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusList;

    static ItemSetInfo()
    {
      Il2CppClassPointerStore<ItemSetInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ItemSetInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSetInfo>.NativeClassPtr);
      ItemSetInfo.NativeFieldInfoPtr_SetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetInfo>.NativeClassPtr, nameof (SetName));
      ItemSetInfo.NativeFieldInfoPtr_ItemList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetInfo>.NativeClassPtr, nameof (ItemList));
      ItemSetInfo.NativeFieldInfoPtr_BonusList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetInfo>.NativeClassPtr, nameof (BonusList));
    }

    public ItemSetInfo(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ItemSetInfo()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ItemSetInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemSetInfo>.NativeClassPtr, data));
    }

    public unsafe AssetGuid SetName
    {
      get
      {
        return *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemSetInfo.NativeFieldInfoPtr_SetName));
      }
      [param: In] set
      {
        *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemSetInfo.NativeFieldInfoPtr_SetName)) = value;
      }
    }

    public unsafe List<KeyValuePair_Unboxed<AssetGuid, bool>> ItemList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemSetInfo.NativeFieldInfoPtr_ItemList));
        return pointer == System.IntPtr.Zero ? (List<KeyValuePair_Unboxed<AssetGuid, bool>>) null : new List<KeyValuePair_Unboxed<AssetGuid, bool>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemSetInfo.NativeFieldInfoPtr_ItemList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<KeyValuePair_Unboxed<DescriptionWrapper, int>> BonusList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemSetInfo.NativeFieldInfoPtr_BonusList));
        return pointer == System.IntPtr.Zero ? (List<KeyValuePair_Unboxed<DescriptionWrapper, int>>) null : new List<KeyValuePair_Unboxed<DescriptionWrapper, int>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemSetInfo.NativeFieldInfoPtr_BonusList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
