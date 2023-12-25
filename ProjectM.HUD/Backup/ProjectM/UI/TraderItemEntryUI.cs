// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TraderItemEntryUI
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class TraderItemEntryUI : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Background;
    private static readonly System.IntPtr NativeFieldInfoPtr_Background_Normal;
    private static readonly System.IntPtr NativeFieldInfoPtr_Background_Hover;
    private static readonly System.IntPtr NativeFieldInfoPtr_Background_Selected;
    private static readonly System.IntPtr NativeFieldInfoPtr_Background_Disabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemAmount;
    private static readonly System.IntPtr NativeFieldInfoPtr_CostIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_CostAmount;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExtraText;
    private static readonly System.IntPtr NativeFieldInfoPtr_StockAmountRoot;
    private static readonly System.IntPtr NativeFieldInfoPtr_StockAmountText;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color_Text_Normal;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color_Text_Hovered;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color_Text_Disabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color_Text_Selected;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color_Text_CanAfford;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color_Text_CannotAfford;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color_Item_Normal;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color_Item_Disabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_StockKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_CostKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ItemAmountKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_OutOfStockKey;
    private static readonly System.IntPtr NativeFieldInfoPtr__Data;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EntryData_Public_get_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOutOfStock_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Static_Void_TraderItemEntryUI_Data_ControllerType_GameDataSystem_GridSelectionGroup_2_TraderItemEntryUI_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe TraderItemEntryUI.Data EntryData
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TraderItemEntryUI.NativeMethodInfoPtr_get_EntryData_Public_get_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new TraderItemEntryUI.Data(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252828, XrefRangeEnd = 1252829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(TraderItemEntryUI.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TraderItemEntryUI.NativeMethodInfoPtr_SetData_Public_Void_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe bool IsOutOfStock
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1252829, RefRangeEnd = 1252830, XrefRangeStart = 1252829, XrefRangeEnd = 1252829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TraderItemEntryUI.NativeMethodInfoPtr_get_IsOutOfStock_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1252868, RefRangeEnd = 1252869, XrefRangeStart = 1252830, XrefRangeEnd = 1252868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RefreshData(
      TraderItemEntryUI entry,
      TraderItemEntryUI.Data data,
      ControllerType controllerType,
      GameDataSystem gameDataSystem,
      GridSelectionGroup<TraderItemEntryUI, TraderItemEntryUI.Data> parent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TraderItemEntryUI.NativeMethodInfoPtr_RefreshData_Public_Static_Void_TraderItemEntryUI_Data_ControllerType_GameDataSystem_GridSelectionGroup_2_TraderItemEntryUI_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TraderItemEntryUI()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TraderItemEntryUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TraderItemEntryUI()
    {
      Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TraderItemEntryUI));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr);
      TraderItemEntryUI.NativeFieldInfoPtr_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (Background));
      TraderItemEntryUI.NativeFieldInfoPtr_Background_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (Background_Normal));
      TraderItemEntryUI.NativeFieldInfoPtr_Background_Hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (Background_Hover));
      TraderItemEntryUI.NativeFieldInfoPtr_Background_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (Background_Selected));
      TraderItemEntryUI.NativeFieldInfoPtr_Background_Disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (Background_Disabled));
      TraderItemEntryUI.NativeFieldInfoPtr_ItemIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (ItemIcon));
      TraderItemEntryUI.NativeFieldInfoPtr_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (ItemName));
      TraderItemEntryUI.NativeFieldInfoPtr_ItemAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (ItemAmount));
      TraderItemEntryUI.NativeFieldInfoPtr_CostIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (CostIcon));
      TraderItemEntryUI.NativeFieldInfoPtr_CostAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (CostAmount));
      TraderItemEntryUI.NativeFieldInfoPtr_ExtraText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (ExtraText));
      TraderItemEntryUI.NativeFieldInfoPtr_StockAmountRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (StockAmountRoot));
      TraderItemEntryUI.NativeFieldInfoPtr_StockAmountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (StockAmountText));
      TraderItemEntryUI.NativeFieldInfoPtr_Color_Text_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (Color_Text_Normal));
      TraderItemEntryUI.NativeFieldInfoPtr_Color_Text_Hovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (Color_Text_Hovered));
      TraderItemEntryUI.NativeFieldInfoPtr_Color_Text_Disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (Color_Text_Disabled));
      TraderItemEntryUI.NativeFieldInfoPtr_Color_Text_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (Color_Text_Selected));
      TraderItemEntryUI.NativeFieldInfoPtr_Color_Text_CanAfford = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (Color_Text_CanAfford));
      TraderItemEntryUI.NativeFieldInfoPtr_Color_Text_CannotAfford = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (Color_Text_CannotAfford));
      TraderItemEntryUI.NativeFieldInfoPtr_Color_Item_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (Color_Item_Normal));
      TraderItemEntryUI.NativeFieldInfoPtr_Color_Item_Disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (Color_Item_Disabled));
      TraderItemEntryUI.NativeFieldInfoPtr_LK_StockKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (LK_StockKey));
      TraderItemEntryUI.NativeFieldInfoPtr_LK_CostKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (LK_CostKey));
      TraderItemEntryUI.NativeFieldInfoPtr_LK_ItemAmountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (LK_ItemAmountKey));
      TraderItemEntryUI.NativeFieldInfoPtr_LK_OutOfStockKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (LK_OutOfStockKey));
      TraderItemEntryUI.NativeFieldInfoPtr__Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (_Data));
      TraderItemEntryUI.NativeMethodInfoPtr_get_EntryData_Public_get_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, 100666709);
      TraderItemEntryUI.NativeMethodInfoPtr_SetData_Public_Void_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, 100666710);
      TraderItemEntryUI.NativeMethodInfoPtr_get_IsOutOfStock_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, 100666711);
      TraderItemEntryUI.NativeMethodInfoPtr_RefreshData_Public_Static_Void_TraderItemEntryUI_Data_ControllerType_GameDataSystem_GridSelectionGroup_2_TraderItemEntryUI_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, 100666712);
      TraderItemEntryUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, 100666713);
    }

    public TraderItemEntryUI(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image Background
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Background));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Background), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Background_Normal
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Background_Normal));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Background_Normal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Background_Hover
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Background_Hover));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Background_Hover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Background_Selected
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Background_Selected));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Background_Selected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Background_Disabled
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Background_Disabled));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Background_Disabled), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ItemIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_ItemIcon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_ItemIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ItemName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_ItemName));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_ItemName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ItemAmount
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_ItemAmount));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_ItemAmount), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image CostIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_CostIcon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_CostIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText CostAmount
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_CostAmount));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_CostAmount), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ExtraText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_ExtraText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_ExtraText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject StockAmountRoot
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_StockAmountRoot));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_StockAmountRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText StockAmountText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_StockAmountText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_StockAmountText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color Color_Text_Normal
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Color_Text_Normal));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Color_Text_Normal)) = value;
      }
    }

    public unsafe Color Color_Text_Hovered
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Color_Text_Hovered));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Color_Text_Hovered)) = value;
      }
    }

    public unsafe Color Color_Text_Disabled
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Color_Text_Disabled));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Color_Text_Disabled)) = value;
      }
    }

    public unsafe Color Color_Text_Selected
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Color_Text_Selected));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Color_Text_Selected)) = value;
      }
    }

    public unsafe Color Color_Text_CanAfford
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Color_Text_CanAfford));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Color_Text_CanAfford)) = value;
      }
    }

    public unsafe Color Color_Text_CannotAfford
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Color_Text_CannotAfford));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Color_Text_CannotAfford)) = value;
      }
    }

    public unsafe Color Color_Item_Normal
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Color_Item_Normal));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Color_Item_Normal)) = value;
      }
    }

    public unsafe Color Color_Item_Disabled
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Color_Item_Disabled));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_Color_Item_Disabled)) = value;
      }
    }

    public unsafe LocalizationKey LK_StockKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_LK_StockKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_LK_StockKey)) = value;
      }
    }

    public unsafe LocalizationKey LK_CostKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_LK_CostKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_LK_CostKey)) = value;
      }
    }

    public unsafe LocalizationKey LK_ItemAmountKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_LK_ItemAmountKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_LK_ItemAmountKey)) = value;
      }
    }

    public unsafe LocalizationKey LK_OutOfStockKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_LK_OutOfStockKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr_LK_OutOfStockKey)) = value;
      }
    }

    public TraderItemEntryUI.Data _Data
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr__Data);
        return new TraderItemEntryUI.Data(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TraderItemEntryUI.Data>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.NativeFieldInfoPtr__Data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TraderItemEntryUI.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_OutItemData;
      private static readonly System.IntPtr NativeFieldInfoPtr_OutItemGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_OutItemAmount;
      private static readonly System.IntPtr NativeFieldInfoPtr_CostItemData;
      private static readonly System.IntPtr NativeFieldInfoPtr_CostData;
      private static readonly System.IntPtr NativeFieldInfoPtr_CostAmount;
      private static readonly System.IntPtr NativeFieldInfoPtr_CanAfford;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasRoomInInventory;
      private static readonly System.IntPtr NativeFieldInfoPtr_StockAmount;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsSelected;
      private static readonly System.IntPtr NativeFieldInfoPtr_HideCostIfOutOfStock;

      static Data()
      {
        Il2CppClassPointerStore<TraderItemEntryUI.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TraderItemEntryUI>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraderItemEntryUI.Data>.NativeClassPtr);
        TraderItemEntryUI.Data.NativeFieldInfoPtr_OutItemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI.Data>.NativeClassPtr, nameof (OutItemData));
        TraderItemEntryUI.Data.NativeFieldInfoPtr_OutItemGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI.Data>.NativeClassPtr, nameof (OutItemGuid));
        TraderItemEntryUI.Data.NativeFieldInfoPtr_OutItemAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI.Data>.NativeClassPtr, nameof (OutItemAmount));
        TraderItemEntryUI.Data.NativeFieldInfoPtr_CostItemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI.Data>.NativeClassPtr, nameof (CostItemData));
        TraderItemEntryUI.Data.NativeFieldInfoPtr_CostData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI.Data>.NativeClassPtr, nameof (CostData));
        TraderItemEntryUI.Data.NativeFieldInfoPtr_CostAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI.Data>.NativeClassPtr, nameof (CostAmount));
        TraderItemEntryUI.Data.NativeFieldInfoPtr_CanAfford = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI.Data>.NativeClassPtr, nameof (CanAfford));
        TraderItemEntryUI.Data.NativeFieldInfoPtr_HasRoomInInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI.Data>.NativeClassPtr, nameof (HasRoomInInventory));
        TraderItemEntryUI.Data.NativeFieldInfoPtr_StockAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI.Data>.NativeClassPtr, nameof (StockAmount));
        TraderItemEntryUI.Data.NativeFieldInfoPtr_IsSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI.Data>.NativeClassPtr, nameof (IsSelected));
        TraderItemEntryUI.Data.NativeFieldInfoPtr_HideCostIfOutOfStock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemEntryUI.Data>.NativeClassPtr, nameof (HideCostIfOutOfStock));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TraderItemEntryUI.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TraderItemEntryUI.Data>.NativeClassPtr, data));
      }

      public unsafe ManagedItemData OutItemData
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_OutItemData));
          return pointer == System.IntPtr.Zero ? (ManagedItemData) null : new ManagedItemData(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_OutItemData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabGUID OutItemGuid
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_OutItemGuid));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_OutItemGuid)) = value;
        }
      }

      public unsafe int OutItemAmount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_OutItemAmount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_OutItemAmount)) = value;
        }
      }

      public unsafe ManagedItemData CostItemData
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_CostItemData));
          return pointer == System.IntPtr.Zero ? (ManagedItemData) null : new ManagedItemData(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_CostItemData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe TradeCost CostData
      {
        get
        {
          return *(TradeCost*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_CostData));
        }
        [param: In] set
        {
          *(TradeCost*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_CostData)) = value;
        }
      }

      public unsafe int CostAmount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_CostAmount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_CostAmount)) = value;
        }
      }

      public unsafe bool CanAfford
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_CanAfford));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_CanAfford)) = value;
        }
      }

      public unsafe bool HasRoomInInventory
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_HasRoomInInventory));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_HasRoomInInventory)) = value;
        }
      }

      public unsafe int StockAmount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_StockAmount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_StockAmount)) = value;
        }
      }

      public unsafe bool IsSelected
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_IsSelected));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_IsSelected)) = value;
        }
      }

      public unsafe bool HideCostIfOutOfStock
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_HideCostIfOutOfStock));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemEntryUI.Data.NativeFieldInfoPtr_HideCostIfOutOfStock)) = value;
        }
      }
    }
  }
}
