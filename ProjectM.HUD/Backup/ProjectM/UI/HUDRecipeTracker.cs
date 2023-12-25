// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.HUDRecipeTracker
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public class HUDRecipeTracker : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_HeaderText;
    private static readonly IntPtr NativeFieldInfoPtr_RecipeRequirements;
    private static readonly IntPtr NativeFieldInfoPtr_LK_TrackingRecipe;
    private static readonly IntPtr NativeFieldInfoPtr_LK_TrackingItem;
    private static readonly IntPtr NativeFieldInfoPtr_LK_TrackingItems;
    private static readonly IntPtr NativeMethodInfoPtr_SetRecipeHeader_Public_Void_LocalizationKey_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetItemsheader_Public_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_RefreshList_Public_Void_List_1_CostData_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273993, XrefRangeEnd = 1274003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetRecipeHeader(LocalizationKey recipeKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &recipeKey;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDRecipeTracker.NativeMethodInfoPtr_SetRecipeHeader_Public_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274003, XrefRangeEnd = 1274005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetItemsheader(bool multipleItems)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &multipleItems;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDRecipeTracker.NativeMethodInfoPtr_SetItemsheader_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274005, XrefRangeEnd = 1274010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshList(List<CostData> costDataList, bool showAmount)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) costDataList);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &showAmount;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDRecipeTracker.NativeMethodInfoPtr_RefreshList_Public_Void_List_1_CostData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HUDRecipeTracker()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HUDRecipeTracker>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDRecipeTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HUDRecipeTracker()
    {
      Il2CppClassPointerStore<HUDRecipeTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (HUDRecipeTracker));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUDRecipeTracker>.NativeClassPtr);
      HUDRecipeTracker.NativeFieldInfoPtr_HeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDRecipeTracker>.NativeClassPtr, nameof (HeaderText));
      HUDRecipeTracker.NativeFieldInfoPtr_RecipeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDRecipeTracker>.NativeClassPtr, nameof (RecipeRequirements));
      HUDRecipeTracker.NativeFieldInfoPtr_LK_TrackingRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDRecipeTracker>.NativeClassPtr, nameof (LK_TrackingRecipe));
      HUDRecipeTracker.NativeFieldInfoPtr_LK_TrackingItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDRecipeTracker>.NativeClassPtr, nameof (LK_TrackingItem));
      HUDRecipeTracker.NativeFieldInfoPtr_LK_TrackingItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDRecipeTracker>.NativeClassPtr, nameof (LK_TrackingItems));
      HUDRecipeTracker.NativeMethodInfoPtr_SetRecipeHeader_Public_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDRecipeTracker>.NativeClassPtr, 100668306);
      HUDRecipeTracker.NativeMethodInfoPtr_SetItemsheader_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDRecipeTracker>.NativeClassPtr, 100668307);
      HUDRecipeTracker.NativeMethodInfoPtr_RefreshList_Public_Void_List_1_CostData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDRecipeTracker>.NativeClassPtr, 100668308);
      HUDRecipeTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDRecipeTracker>.NativeClassPtr, 100668309);
    }

    public HUDRecipeTracker(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText HeaderText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDRecipeTracker.NativeFieldInfoPtr_HeaderText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HUDRecipeTracker.NativeFieldInfoPtr_HeaderText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TooltipRecipeRequiredItems RecipeRequirements
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDRecipeTracker.NativeFieldInfoPtr_RecipeRequirements));
        return pointer == IntPtr.Zero ? (TooltipRecipeRequiredItems) null : new TooltipRecipeRequiredItems(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HUDRecipeTracker.NativeFieldInfoPtr_RecipeRequirements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_TrackingRecipe
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDRecipeTracker.NativeFieldInfoPtr_LK_TrackingRecipe));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDRecipeTracker.NativeFieldInfoPtr_LK_TrackingRecipe)) = value;
      }
    }

    public unsafe LocalizationKey LK_TrackingItem
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDRecipeTracker.NativeFieldInfoPtr_LK_TrackingItem));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDRecipeTracker.NativeFieldInfoPtr_LK_TrackingItem)) = value;
      }
    }

    public unsafe LocalizationKey LK_TrackingItems
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDRecipeTracker.NativeFieldInfoPtr_LK_TrackingItems));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDRecipeTracker.NativeFieldInfoPtr_LK_TrackingItems)) = value;
      }
    }
  }
}
