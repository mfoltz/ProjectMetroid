// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.InventoryLocalizationKeys
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class InventoryLocalizationKeys : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_CreateKey;
    private static readonly IntPtr NativeFieldInfoPtr_TakeKey;
    private static readonly IntPtr NativeFieldInfoPtr_AbortKey;
    private static readonly IntPtr NativeFieldInfoPtr_SelectKey;
    private static readonly IntPtr NativeFieldInfoPtr_SplitKey;
    private static readonly IntPtr NativeFieldInfoPtr_RepairKey;
    private static readonly IntPtr NativeFieldInfoPtr_GiveKey;
    private static readonly IntPtr NativeFieldInfoPtr_PickUpKey;
    private static readonly IntPtr NativeFieldInfoPtr_DropKey;
    private static readonly IntPtr NativeFieldInfoPtr_EquipKey;
    private static readonly IntPtr NativeFieldInfoPtr_SwapJewelKey;
    private static readonly IntPtr NativeFieldInfoPtr_UnequipKey;
    private static readonly IntPtr NativeFieldInfoPtr_UseKey;
    private static readonly IntPtr NativeFieldInfoPtr_SmartMergeKey;
    private static readonly IntPtr NativeFieldInfoPtr_SmartMergeDesc;
    private static readonly IntPtr NativeFieldInfoPtr_SelfSortKey;
    private static readonly IntPtr NativeFieldInfoPtr_SelfSortDesc;
    private static readonly IntPtr NativeFieldInfoPtr_BagSlotKey;
    private static readonly IntPtr NativeFieldInfoPtr_BagSlotDesc;
    private static readonly IntPtr NativeFieldInfoPtr_ShowBagInventoriesKey;
    private static readonly IntPtr NativeFieldInfoPtr_ShowBagInventoriesDesc;
    private static readonly IntPtr NativeFieldInfoPtr_HideBagInventoriesKey;
    private static readonly IntPtr NativeFieldInfoPtr_HideBagInventoriesDesc;
    private static readonly IntPtr NativeFieldInfoPtr_ItemNotPlaceableKey;
    private static readonly IntPtr NativeFieldInfoPtr_TypeSlotKey;
    private static readonly IntPtr NativeFieldInfoPtr_RestrictedSlotKey;
    private static readonly IntPtr NativeFieldInfoPtr_RestrictedItemSlotDesc;
    private static readonly IntPtr NativeFieldInfoPtr_RestrictedItemCategorySlotDesc;
    private static readonly IntPtr NativeFieldInfoPtr_ChargeKey;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InventoryLocalizationKeys()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryLocalizationKeys.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InventoryLocalizationKeys()
    {
      Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (InventoryLocalizationKeys));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr);
      InventoryLocalizationKeys.NativeFieldInfoPtr_CreateKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (CreateKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_TakeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (TakeKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_AbortKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (AbortKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_SelectKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (SelectKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_SplitKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (SplitKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_RepairKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (RepairKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_GiveKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (GiveKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_PickUpKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (PickUpKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_DropKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (DropKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_EquipKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (EquipKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_SwapJewelKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (SwapJewelKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_UnequipKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (UnequipKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_UseKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (UseKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_SmartMergeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (SmartMergeKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_SmartMergeDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (SmartMergeDesc));
      InventoryLocalizationKeys.NativeFieldInfoPtr_SelfSortKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (SelfSortKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_SelfSortDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (SelfSortDesc));
      InventoryLocalizationKeys.NativeFieldInfoPtr_BagSlotKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (BagSlotKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_BagSlotDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (BagSlotDesc));
      InventoryLocalizationKeys.NativeFieldInfoPtr_ShowBagInventoriesKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (ShowBagInventoriesKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_ShowBagInventoriesDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (ShowBagInventoriesDesc));
      InventoryLocalizationKeys.NativeFieldInfoPtr_HideBagInventoriesKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (HideBagInventoriesKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_HideBagInventoriesDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (HideBagInventoriesDesc));
      InventoryLocalizationKeys.NativeFieldInfoPtr_ItemNotPlaceableKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (ItemNotPlaceableKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_TypeSlotKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (TypeSlotKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_RestrictedSlotKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (RestrictedSlotKey));
      InventoryLocalizationKeys.NativeFieldInfoPtr_RestrictedItemSlotDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (RestrictedItemSlotDesc));
      InventoryLocalizationKeys.NativeFieldInfoPtr_RestrictedItemCategorySlotDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (RestrictedItemCategorySlotDesc));
      InventoryLocalizationKeys.NativeFieldInfoPtr_ChargeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, nameof (ChargeKey));
      InventoryLocalizationKeys.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryLocalizationKeys>.NativeClassPtr, 100667688);
    }

    public InventoryLocalizationKeys(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey CreateKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_CreateKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_CreateKey)) = value;
      }
    }

    public unsafe LocalizationKey TakeKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_TakeKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_TakeKey)) = value;
      }
    }

    public unsafe LocalizationKey AbortKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_AbortKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_AbortKey)) = value;
      }
    }

    public unsafe LocalizationKey SelectKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_SelectKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_SelectKey)) = value;
      }
    }

    public unsafe LocalizationKey SplitKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_SplitKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_SplitKey)) = value;
      }
    }

    public unsafe LocalizationKey RepairKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_RepairKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_RepairKey)) = value;
      }
    }

    public unsafe LocalizationKey GiveKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_GiveKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_GiveKey)) = value;
      }
    }

    public unsafe LocalizationKey PickUpKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_PickUpKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_PickUpKey)) = value;
      }
    }

    public unsafe LocalizationKey DropKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_DropKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_DropKey)) = value;
      }
    }

    public unsafe LocalizationKey EquipKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_EquipKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_EquipKey)) = value;
      }
    }

    public unsafe LocalizationKey SwapJewelKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_SwapJewelKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_SwapJewelKey)) = value;
      }
    }

    public unsafe LocalizationKey UnequipKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_UnequipKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_UnequipKey)) = value;
      }
    }

    public unsafe LocalizationKey UseKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_UseKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_UseKey)) = value;
      }
    }

    public unsafe LocalizationKey SmartMergeKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_SmartMergeKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_SmartMergeKey)) = value;
      }
    }

    public unsafe LocalizationKey SmartMergeDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_SmartMergeDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_SmartMergeDesc)) = value;
      }
    }

    public unsafe LocalizationKey SelfSortKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_SelfSortKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_SelfSortKey)) = value;
      }
    }

    public unsafe LocalizationKey SelfSortDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_SelfSortDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_SelfSortDesc)) = value;
      }
    }

    public unsafe LocalizationKey BagSlotKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_BagSlotKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_BagSlotKey)) = value;
      }
    }

    public unsafe LocalizationKey BagSlotDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_BagSlotDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_BagSlotDesc)) = value;
      }
    }

    public unsafe LocalizationKey ShowBagInventoriesKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_ShowBagInventoriesKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_ShowBagInventoriesKey)) = value;
      }
    }

    public unsafe LocalizationKey ShowBagInventoriesDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_ShowBagInventoriesDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_ShowBagInventoriesDesc)) = value;
      }
    }

    public unsafe LocalizationKey HideBagInventoriesKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_HideBagInventoriesKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_HideBagInventoriesKey)) = value;
      }
    }

    public unsafe LocalizationKey HideBagInventoriesDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_HideBagInventoriesDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_HideBagInventoriesDesc)) = value;
      }
    }

    public unsafe LocalizationKey ItemNotPlaceableKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_ItemNotPlaceableKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_ItemNotPlaceableKey)) = value;
      }
    }

    public unsafe LocalizationKey TypeSlotKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_TypeSlotKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_TypeSlotKey)) = value;
      }
    }

    public unsafe LocalizationKey RestrictedSlotKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_RestrictedSlotKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_RestrictedSlotKey)) = value;
      }
    }

    public unsafe LocalizationKey RestrictedItemSlotDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_RestrictedItemSlotDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_RestrictedItemSlotDesc)) = value;
      }
    }

    public unsafe LocalizationKey RestrictedItemCategorySlotDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_RestrictedItemCategorySlotDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_RestrictedItemCategorySlotDesc)) = value;
      }
    }

    public unsafe LocalizationKey ChargeKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_ChargeKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryLocalizationKeys.NativeFieldInfoPtr_ChargeKey)) = value;
      }
    }
  }
}
