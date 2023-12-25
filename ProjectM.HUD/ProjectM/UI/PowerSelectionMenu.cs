// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.PowerSelectionMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class PowerSelectionMenu : FullscreenMenuView
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Background;
    private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundSprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_PowerCategories;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedPowerEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedPowerNameText;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedPowerTypeText;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedPowerDescriptionText;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnknownPowerSprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_UnknownPowerName;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_UnknownPowerDescription;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_VampirePower;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1262066, RefRangeEnd = 1262068, XrefRangeStart = 1262065, XrefRangeEnd = 1262066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PowerSelectionMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerSelectionMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PowerSelectionMenu()
    {
      Il2CppClassPointerStore<PowerSelectionMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (PowerSelectionMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerSelectionMenu>.NativeClassPtr);
      PowerSelectionMenu.NativeFieldInfoPtr_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu>.NativeClassPtr, nameof (Background));
      PowerSelectionMenu.NativeFieldInfoPtr_BackgroundSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu>.NativeClassPtr, nameof (BackgroundSprite));
      PowerSelectionMenu.NativeFieldInfoPtr_PowerCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu>.NativeClassPtr, nameof (PowerCategories));
      PowerSelectionMenu.NativeFieldInfoPtr_SelectedPowerEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu>.NativeClassPtr, nameof (SelectedPowerEntries));
      PowerSelectionMenu.NativeFieldInfoPtr_SelectedPowerNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu>.NativeClassPtr, nameof (SelectedPowerNameText));
      PowerSelectionMenu.NativeFieldInfoPtr_SelectedPowerTypeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu>.NativeClassPtr, nameof (SelectedPowerTypeText));
      PowerSelectionMenu.NativeFieldInfoPtr_SelectedPowerDescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu>.NativeClassPtr, nameof (SelectedPowerDescriptionText));
      PowerSelectionMenu.NativeFieldInfoPtr_UnknownPowerSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu>.NativeClassPtr, nameof (UnknownPowerSprite));
      PowerSelectionMenu.NativeFieldInfoPtr_LKey_UnknownPowerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu>.NativeClassPtr, nameof (LKey_UnknownPowerName));
      PowerSelectionMenu.NativeFieldInfoPtr_LKey_UnknownPowerDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu>.NativeClassPtr, nameof (LKey_UnknownPowerDescription));
      PowerSelectionMenu.NativeFieldInfoPtr_LKey_VampirePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu>.NativeClassPtr, nameof (LKey_VampirePower));
      PowerSelectionMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenu>.NativeClassPtr, 100667355);
    }

    public PowerSelectionMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ImageFadeSwap Background
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_Background));
        return pointer == System.IntPtr.Zero ? (ImageFadeSwap) null : new ImageFadeSwap(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_Background), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<Sprite> BackgroundSprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_BackgroundSprite));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<Sprite>) null : new WeakAssetReference<Sprite>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_BackgroundSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<PowerSelectionMenu.PowerCategory> PowerCategories
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_PowerCategories));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<PowerSelectionMenu.PowerCategory>) null : new Il2CppReferenceArray<PowerSelectionMenu.PowerCategory>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_PowerCategories), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<PowerSelectionMenu_PowerEntry> SelectedPowerEntries
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_SelectedPowerEntries));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<PowerSelectionMenu_PowerEntry>) null : new Il2CppReferenceArray<PowerSelectionMenu_PowerEntry>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_SelectedPowerEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SelectedPowerNameText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_SelectedPowerNameText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_SelectedPowerNameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SelectedPowerTypeText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_SelectedPowerTypeText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_SelectedPowerTypeText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SelectedPowerDescriptionText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_SelectedPowerDescriptionText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_SelectedPowerDescriptionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite UnknownPowerSprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_UnknownPowerSprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_UnknownPowerSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_UnknownPowerName
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_LKey_UnknownPowerName));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_LKey_UnknownPowerName)) = value;
      }
    }

    public unsafe LocalizationKey LKey_UnknownPowerDescription
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_LKey_UnknownPowerDescription));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_LKey_UnknownPowerDescription)) = value;
      }
    }

    public unsafe LocalizationKey LKey_VampirePower
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_LKey_VampirePower));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.NativeFieldInfoPtr_LKey_VampirePower)) = value;
      }
    }

    [Serializable]
    public class PowerUiData : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_UpperGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_LowerGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxItemsPerRow;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PowerUiData()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerSelectionMenu.PowerUiData>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenu.PowerUiData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static PowerUiData()
      {
        Il2CppClassPointerStore<PowerSelectionMenu.PowerUiData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PowerSelectionMenu>.NativeClassPtr, nameof (PowerUiData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerSelectionMenu.PowerUiData>.NativeClassPtr);
        PowerSelectionMenu.PowerUiData.NativeFieldInfoPtr_UpperGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu.PowerUiData>.NativeClassPtr, nameof (UpperGroup));
        PowerSelectionMenu.PowerUiData.NativeFieldInfoPtr_LowerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu.PowerUiData>.NativeClassPtr, nameof (LowerGroup));
        PowerSelectionMenu.PowerUiData.NativeFieldInfoPtr_MaxItemsPerRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu.PowerUiData>.NativeClassPtr, nameof (MaxItemsPerRow));
        PowerSelectionMenu.PowerUiData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenu.PowerUiData>.NativeClassPtr, 100667356);
      }

      public PowerUiData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe GenericSelectionGroup<PowerSelectionMenu_PowerEntry, PowerSelectionMenu_PowerEntry.Data> UpperGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.PowerUiData.NativeFieldInfoPtr_UpperGroup));
          return pointer == System.IntPtr.Zero ? (GenericSelectionGroup<PowerSelectionMenu_PowerEntry, PowerSelectionMenu_PowerEntry.Data>) null : new GenericSelectionGroup<PowerSelectionMenu_PowerEntry, PowerSelectionMenu_PowerEntry.Data>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.PowerUiData.NativeFieldInfoPtr_UpperGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe GenericSelectionGroup<PowerSelectionMenu_PowerEntry, PowerSelectionMenu_PowerEntry.Data> LowerGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.PowerUiData.NativeFieldInfoPtr_LowerGroup));
          return pointer == System.IntPtr.Zero ? (GenericSelectionGroup<PowerSelectionMenu_PowerEntry, PowerSelectionMenu_PowerEntry.Data>) null : new GenericSelectionGroup<PowerSelectionMenu_PowerEntry, PowerSelectionMenu_PowerEntry.Data>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.PowerUiData.NativeFieldInfoPtr_LowerGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int MaxItemsPerRow
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.PowerUiData.NativeFieldInfoPtr_MaxItemsPerRow));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.PowerUiData.NativeFieldInfoPtr_MaxItemsPerRow)) = value;
        }
      }
    }

    [Serializable]
    public class PowerCategory : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Prefabs;
      private static readonly System.IntPtr NativeFieldInfoPtr_UiData;
      private static readonly System.IntPtr NativeFieldInfoPtr_SkipProgressionCheck;
      private static readonly System.IntPtr NativeFieldInfoPtr_Cache;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262057, XrefRangeEnd = 1262065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PowerCategory()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerSelectionMenu.PowerCategory>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenu.PowerCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static PowerCategory()
      {
        Il2CppClassPointerStore<PowerSelectionMenu.PowerCategory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PowerSelectionMenu>.NativeClassPtr, nameof (PowerCategory));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerSelectionMenu.PowerCategory>.NativeClassPtr);
        PowerSelectionMenu.PowerCategory.NativeFieldInfoPtr_Prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu.PowerCategory>.NativeClassPtr, nameof (Prefabs));
        PowerSelectionMenu.PowerCategory.NativeFieldInfoPtr_UiData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu.PowerCategory>.NativeClassPtr, nameof (UiData));
        PowerSelectionMenu.PowerCategory.NativeFieldInfoPtr_SkipProgressionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu.PowerCategory>.NativeClassPtr, nameof (SkipProgressionCheck));
        PowerSelectionMenu.PowerCategory.NativeFieldInfoPtr_Cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu.PowerCategory>.NativeClassPtr, nameof (Cache));
        PowerSelectionMenu.PowerCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenu.PowerCategory>.NativeClassPtr, 100667357);
      }

      public PowerCategory(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Il2CppReferenceArray<WeakAssetReference<PrefabGuidComponent>> Prefabs
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.PowerCategory.NativeFieldInfoPtr_Prefabs));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<WeakAssetReference<PrefabGuidComponent>>) null : new Il2CppReferenceArray<WeakAssetReference<PrefabGuidComponent>>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.PowerCategory.NativeFieldInfoPtr_Prefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PowerSelectionMenu.PowerUiData UiData
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.PowerCategory.NativeFieldInfoPtr_UiData));
          return pointer == System.IntPtr.Zero ? (PowerSelectionMenu.PowerUiData) null : new PowerSelectionMenu.PowerUiData(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.PowerCategory.NativeFieldInfoPtr_UiData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool SkipProgressionCheck
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.PowerCategory.NativeFieldInfoPtr_SkipProgressionCheck));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.PowerCategory.NativeFieldInfoPtr_SkipProgressionCheck)) = value;
        }
      }

      public unsafe List<PowerSelectionMenu_PowerEntry.Data> Cache
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.PowerCategory.NativeFieldInfoPtr_Cache));
          return pointer == System.IntPtr.Zero ? (List<PowerSelectionMenu_PowerEntry.Data>) null : new List<PowerSelectionMenu_PowerEntry.Data>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu.PowerCategory.NativeFieldInfoPtr_Cache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
