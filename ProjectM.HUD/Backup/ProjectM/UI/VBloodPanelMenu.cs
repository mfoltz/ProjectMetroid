// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.VBloodPanelMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class VBloodPanelMenu : HUDMenu
  {
    private static readonly IntPtr NativeFieldInfoPtr_BloodAltarSubMenu;
    private static readonly IntPtr NativeFieldInfoPtr_SubMenusParent;
    private static readonly IntPtr NativeFieldInfoPtr_LocalizationKeys;
    private static readonly IntPtr NativeFieldInfoPtr_HideHUDElements;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodPanelMenu.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VBloodPanelMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodPanelMenu>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodPanelMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VBloodPanelMenu()
    {
      Il2CppClassPointerStore<VBloodPanelMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (VBloodPanelMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodPanelMenu>.NativeClassPtr);
      VBloodPanelMenu.NativeFieldInfoPtr_BloodAltarSubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPanelMenu>.NativeClassPtr, nameof (BloodAltarSubMenu));
      VBloodPanelMenu.NativeFieldInfoPtr_SubMenusParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPanelMenu>.NativeClassPtr, nameof (SubMenusParent));
      VBloodPanelMenu.NativeFieldInfoPtr_LocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPanelMenu>.NativeClassPtr, nameof (LocalizationKeys));
      VBloodPanelMenu.NativeFieldInfoPtr_HideHUDElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPanelMenu>.NativeClassPtr, nameof (HideHUDElements));
      VBloodPanelMenu.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPanelMenu>.NativeClassPtr, 100666828);
      VBloodPanelMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPanelMenu>.NativeClassPtr, 100666829);
    }

    public VBloodPanelMenu(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BloodAltarSubMenu BloodAltarSubMenu
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPanelMenu.NativeFieldInfoPtr_BloodAltarSubMenu));
        return pointer == IntPtr.Zero ? (BloodAltarSubMenu) null : new BloodAltarSubMenu(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodPanelMenu.NativeFieldInfoPtr_BloodAltarSubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SubMenusParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPanelMenu.NativeFieldInfoPtr_SubMenusParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodPanelMenu.NativeFieldInfoPtr_SubMenusParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InventoryLocalizationKeys LocalizationKeys
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPanelMenu.NativeFieldInfoPtr_LocalizationKeys));
        return pointer == IntPtr.Zero ? (InventoryLocalizationKeys) null : new InventoryLocalizationKeys(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodPanelMenu.NativeFieldInfoPtr_LocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HUDElementType HideHUDElements
    {
      get
      {
        return *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPanelMenu.NativeFieldInfoPtr_HideHUDElements));
      }
      [param: In] set
      {
        *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPanelMenu.NativeFieldInfoPtr_HideHUDElements)) = value;
      }
    }
  }
}
