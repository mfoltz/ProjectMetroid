// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.JewelCraftingMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class JewelCraftingMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InventorySubMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr_JewelCraftingSubMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubMenusParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalizationKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideHUDElements;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MissingRecipes;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MissingKnowledge;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MissingBlacksmith;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MissingLumberjack;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MissingTailor;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusOutputFull;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe JewelCraftingMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JewelCraftingMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelCraftingMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static JewelCraftingMenu()
    {
      Il2CppClassPointerStore<JewelCraftingMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (JewelCraftingMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelCraftingMenu>.NativeClassPtr);
      JewelCraftingMenu.NativeFieldInfoPtr_InventorySubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingMenu>.NativeClassPtr, nameof (InventorySubMenu));
      JewelCraftingMenu.NativeFieldInfoPtr_JewelCraftingSubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingMenu>.NativeClassPtr, nameof (JewelCraftingSubMenu));
      JewelCraftingMenu.NativeFieldInfoPtr_SubMenusParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingMenu>.NativeClassPtr, nameof (SubMenusParent));
      JewelCraftingMenu.NativeFieldInfoPtr_LocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingMenu>.NativeClassPtr, nameof (LocalizationKeys));
      JewelCraftingMenu.NativeFieldInfoPtr_HideHUDElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingMenu>.NativeClassPtr, nameof (HideHUDElements));
      JewelCraftingMenu.NativeFieldInfoPtr_LKey_MissingRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingMenu>.NativeClassPtr, nameof (LKey_MissingRecipes));
      JewelCraftingMenu.NativeFieldInfoPtr_LKey_MissingKnowledge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingMenu>.NativeClassPtr, nameof (LKey_MissingKnowledge));
      JewelCraftingMenu.NativeFieldInfoPtr_LKey_MissingBlacksmith = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingMenu>.NativeClassPtr, nameof (LKey_MissingBlacksmith));
      JewelCraftingMenu.NativeFieldInfoPtr_LKey_MissingLumberjack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingMenu>.NativeClassPtr, nameof (LKey_MissingLumberjack));
      JewelCraftingMenu.NativeFieldInfoPtr_LKey_MissingTailor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingMenu>.NativeClassPtr, nameof (LKey_MissingTailor));
      JewelCraftingMenu.NativeFieldInfoPtr_LKey_StatusOutputFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingMenu>.NativeClassPtr, nameof (LKey_StatusOutputFull));
      JewelCraftingMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelCraftingMenu>.NativeClassPtr, 100665959);
    }

    public JewelCraftingMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe InventorySubMenu InventorySubMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_InventorySubMenu));
        return pointer == System.IntPtr.Zero ? (InventorySubMenu) null : new InventorySubMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_InventorySubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe JewelCraftingSubMenu JewelCraftingSubMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_JewelCraftingSubMenu));
        return pointer == System.IntPtr.Zero ? (JewelCraftingSubMenu) null : new JewelCraftingSubMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_JewelCraftingSubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SubMenusParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_SubMenusParent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_SubMenusParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InventoryLocalizationKeys LocalizationKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_LocalizationKeys));
        return pointer == System.IntPtr.Zero ? (InventoryLocalizationKeys) null : new InventoryLocalizationKeys(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_LocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HUDElementType HideHUDElements
    {
      get
      {
        return *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_HideHUDElements));
      }
      [param: In] set
      {
        *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_HideHUDElements)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MissingRecipes
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_LKey_MissingRecipes));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_LKey_MissingRecipes)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MissingKnowledge
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_LKey_MissingKnowledge));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_LKey_MissingKnowledge)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MissingBlacksmith
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_LKey_MissingBlacksmith));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_LKey_MissingBlacksmith)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MissingLumberjack
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_LKey_MissingLumberjack));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_LKey_MissingLumberjack)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MissingTailor
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_LKey_MissingTailor));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_LKey_MissingTailor)) = value;
      }
    }

    public unsafe LocalizationKey LKey_StatusOutputFull
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_LKey_StatusOutputFull));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelCraftingMenu.NativeFieldInfoPtr_LKey_StatusOutputFull)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InitData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TargetStation;
      private static readonly System.IntPtr NativeFieldInfoPtr_InteractBuff;
      [FieldOffset(0)]
      public Entity TargetStation;
      [FieldOffset(8)]
      public Entity InteractBuff;

      static InitData()
      {
        Il2CppClassPointerStore<JewelCraftingMenu.InitData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelCraftingMenu>.NativeClassPtr, nameof (InitData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelCraftingMenu.InitData>.NativeClassPtr);
        JewelCraftingMenu.InitData.NativeFieldInfoPtr_TargetStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingMenu.InitData>.NativeClassPtr, nameof (TargetStation));
        JewelCraftingMenu.InitData.NativeFieldInfoPtr_InteractBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingMenu.InitData>.NativeClassPtr, nameof (InteractBuff));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelCraftingMenu.InitData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
