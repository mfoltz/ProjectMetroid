// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CastleHeartMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class CastleHeartMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InventorySubMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeartSubMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubMenusParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalizationKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideHUDElements;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleHeartMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleHeartMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleHeartMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleHeartMenu()
    {
      Il2CppClassPointerStore<CastleHeartMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (CastleHeartMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleHeartMenu>.NativeClassPtr);
      CastleHeartMenu.NativeFieldInfoPtr_InventorySubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartMenu>.NativeClassPtr, nameof (InventorySubMenu));
      CastleHeartMenu.NativeFieldInfoPtr_CastleHeartSubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartMenu>.NativeClassPtr, nameof (CastleHeartSubMenu));
      CastleHeartMenu.NativeFieldInfoPtr_SubMenusParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartMenu>.NativeClassPtr, nameof (SubMenusParent));
      CastleHeartMenu.NativeFieldInfoPtr_LocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartMenu>.NativeClassPtr, nameof (LocalizationKeys));
      CastleHeartMenu.NativeFieldInfoPtr_HideHUDElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartMenu>.NativeClassPtr, nameof (HideHUDElements));
      CastleHeartMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartMenu>.NativeClassPtr, 100665198);
    }

    public CastleHeartMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe InventorySubMenu InventorySubMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartMenu.NativeFieldInfoPtr_InventorySubMenu));
        return pointer == System.IntPtr.Zero ? (InventorySubMenu) null : new InventorySubMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartMenu.NativeFieldInfoPtr_InventorySubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CastleHeartSubMenu CastleHeartSubMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartMenu.NativeFieldInfoPtr_CastleHeartSubMenu));
        return pointer == System.IntPtr.Zero ? (CastleHeartSubMenu) null : new CastleHeartSubMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartMenu.NativeFieldInfoPtr_CastleHeartSubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SubMenusParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartMenu.NativeFieldInfoPtr_SubMenusParent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartMenu.NativeFieldInfoPtr_SubMenusParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InventoryLocalizationKeys LocalizationKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartMenu.NativeFieldInfoPtr_LocalizationKeys));
        return pointer == System.IntPtr.Zero ? (InventoryLocalizationKeys) null : new InventoryLocalizationKeys(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartMenu.NativeFieldInfoPtr_LocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HUDElementType HideHUDElements
    {
      get
      {
        return *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartMenu.NativeFieldInfoPtr_HideHUDElements));
      }
      [param: In] set
      {
        *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartMenu.NativeFieldInfoPtr_HideHUDElements)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InitData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TargetWorkstation;
      private static readonly System.IntPtr NativeFieldInfoPtr_InteractBuff;
      [FieldOffset(0)]
      public Entity TargetWorkstation;
      [FieldOffset(8)]
      public Entity InteractBuff;

      static InitData()
      {
        Il2CppClassPointerStore<CastleHeartMenu.InitData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleHeartMenu>.NativeClassPtr, nameof (InitData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleHeartMenu.InitData>.NativeClassPtr);
        CastleHeartMenu.InitData.NativeFieldInfoPtr_TargetWorkstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartMenu.InitData>.NativeClassPtr, nameof (TargetWorkstation));
        CastleHeartMenu.InitData.NativeFieldInfoPtr_InteractBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartMenu.InitData>.NativeClassPtr, nameof (InteractBuff));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleHeartMenu.InitData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
