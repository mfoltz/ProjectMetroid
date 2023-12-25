// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CharacterCreationMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using Unity.Entities;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class CharacterCreationMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterCreationScreen;
    private static readonly System.IntPtr NativeFieldInfoPtr_FeaturesDropdown;
    private static readonly System.IntPtr NativeFieldInfoPtr_HairstyleDropdown;
    private static readonly System.IntPtr NativeFieldInfoPtr_FacialHairDropdown;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameInputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_BackButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreateButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationSpeedDragFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationSpeedDecreaseFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideHUDElements;
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterCreationScenePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__FeaturesList;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitalizeUI_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230368, XrefRangeEnd = 1230378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitalizeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterCreationMenu.NativeMethodInfoPtr_InitalizeUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230378, XrefRangeEnd = 1230379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharacterCreationMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreationMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterCreationMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharacterCreationMenu()
    {
      Il2CppClassPointerStore<CharacterCreationMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (CharacterCreationMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreationMenu>.NativeClassPtr);
      CharacterCreationMenu.NativeFieldInfoPtr_CharacterCreationScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationMenu>.NativeClassPtr, nameof (CharacterCreationScreen));
      CharacterCreationMenu.NativeFieldInfoPtr_FeaturesDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationMenu>.NativeClassPtr, nameof (FeaturesDropdown));
      CharacterCreationMenu.NativeFieldInfoPtr_HairstyleDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationMenu>.NativeClassPtr, nameof (HairstyleDropdown));
      CharacterCreationMenu.NativeFieldInfoPtr_FacialHairDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationMenu>.NativeClassPtr, nameof (FacialHairDropdown));
      CharacterCreationMenu.NativeFieldInfoPtr_NameInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationMenu>.NativeClassPtr, nameof (NameInputField));
      CharacterCreationMenu.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationMenu>.NativeClassPtr, nameof (BackButton));
      CharacterCreationMenu.NativeFieldInfoPtr_CreateButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationMenu>.NativeClassPtr, nameof (CreateButton));
      CharacterCreationMenu.NativeFieldInfoPtr_RotationSpeedDragFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationMenu>.NativeClassPtr, nameof (RotationSpeedDragFactor));
      CharacterCreationMenu.NativeFieldInfoPtr_RotationSpeedDecreaseFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationMenu>.NativeClassPtr, nameof (RotationSpeedDecreaseFactor));
      CharacterCreationMenu.NativeFieldInfoPtr_HideHUDElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationMenu>.NativeClassPtr, nameof (HideHUDElements));
      CharacterCreationMenu.NativeFieldInfoPtr_CharacterCreationScenePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationMenu>.NativeClassPtr, nameof (CharacterCreationScenePrefab));
      CharacterCreationMenu.NativeFieldInfoPtr__FeaturesList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationMenu>.NativeClassPtr, nameof (_FeaturesList));
      CharacterCreationMenu.NativeMethodInfoPtr_InitalizeUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreationMenu>.NativeClassPtr, 100665283);
      CharacterCreationMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreationMenu>.NativeClassPtr, 100665284);
    }

    public CharacterCreationMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CharacterCreationScreen CharacterCreationScreen
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_CharacterCreationScreen));
        return pointer == System.IntPtr.Zero ? (CharacterCreationScreen) null : new CharacterCreationScreen(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_CharacterCreationScreen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Dropdown FeaturesDropdown
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_FeaturesDropdown));
        return pointer == System.IntPtr.Zero ? (TMP_Dropdown) null : new TMP_Dropdown(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_FeaturesDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Dropdown HairstyleDropdown
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_HairstyleDropdown));
        return pointer == System.IntPtr.Zero ? (TMP_Dropdown) null : new TMP_Dropdown(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_HairstyleDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Dropdown FacialHairDropdown
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_FacialHairDropdown));
        return pointer == System.IntPtr.Zero ? (TMP_Dropdown) null : new TMP_Dropdown(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_FacialHairDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField NameInputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_NameInputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_NameInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Button BackButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_BackButton));
        return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Button CreateButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_CreateButton));
        return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_CreateButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float RotationSpeedDragFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_RotationSpeedDragFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_RotationSpeedDragFactor)) = value;
      }
    }

    public unsafe float RotationSpeedDecreaseFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_RotationSpeedDecreaseFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_RotationSpeedDecreaseFactor)) = value;
      }
    }

    public unsafe HUDElementType HideHUDElements
    {
      get
      {
        return *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_HideHUDElements));
      }
      [param: In] set
      {
        *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_HideHUDElements)) = value;
      }
    }

    public unsafe CustomizationBrowser CharacterCreationScenePrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_CharacterCreationScenePrefab));
        return pointer == System.IntPtr.Zero ? (CustomizationBrowser) null : new CustomizationBrowser(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr_CharacterCreationScenePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<string> _FeaturesList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr__FeaturesList));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationMenu.NativeFieldInfoPtr__FeaturesList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InitData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MenuMode;
      private static readonly System.IntPtr NativeFieldInfoPtr_TargetWorkstation;
      private static readonly System.IntPtr NativeFieldInfoPtr_InteractBuff;
      [FieldOffset(0)]
      public CharacterCreationMenuMode MenuMode;
      [FieldOffset(4)]
      public Entity TargetWorkstation;
      [FieldOffset(12)]
      public Entity InteractBuff;

      static InitData()
      {
        Il2CppClassPointerStore<CharacterCreationMenu.InitData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreationMenu>.NativeClassPtr, nameof (InitData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreationMenu.InitData>.NativeClassPtr);
        CharacterCreationMenu.InitData.NativeFieldInfoPtr_MenuMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationMenu.InitData>.NativeClassPtr, nameof (MenuMode));
        CharacterCreationMenu.InitData.NativeFieldInfoPtr_TargetWorkstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationMenu.InitData>.NativeClassPtr, nameof (TargetWorkstation));
        CharacterCreationMenu.InitData.NativeFieldInfoPtr_InteractBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationMenu.InitData>.NativeClassPtr, nameof (InteractBuff));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterCreationMenu.InitData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
