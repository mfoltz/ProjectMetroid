// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.InteractHUDParent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class InteractHUDParent : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_InteractBackgroundImage;
    private static readonly IntPtr NativeFieldInfoPtr_InteractFillImage;
    private static readonly IntPtr NativeFieldInfoPtr_InteractKeyText;
    private static readonly IntPtr NativeFieldInfoPtr_InteractKeyImage;
    private static readonly IntPtr NativeFieldInfoPtr_InteractNameText;
    private static readonly IntPtr NativeFieldInfoPtr_FeedPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Container;
    private static readonly IntPtr NativeFieldInfoPtr_ZoomSettings;
    private static readonly IntPtr NativeFieldInfoPtr_RootCanvasGroup;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_VBlood;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_VBloodItemName;
    private static readonly IntPtr NativeFieldInfoPtr_ItemLevelRaritySettings;
    private static readonly IntPtr NativeMethodInfoPtr_ToggleAvailable_Internal_Void_Boolean_Single_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266944, XrefRangeEnd = 1266955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ToggleAvailable(bool available, float itemLevel, bool isRelic)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &available;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &itemLevel;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &isRelic;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InteractHUDParent.NativeMethodInfoPtr_ToggleAvailable_Internal_Void_Boolean_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InteractHUDParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractHUDParent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InteractHUDParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InteractHUDParent()
    {
      Il2CppClassPointerStore<InteractHUDParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (InteractHUDParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractHUDParent>.NativeClassPtr);
      InteractHUDParent.NativeFieldInfoPtr_InteractBackgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractHUDParent>.NativeClassPtr, nameof (InteractBackgroundImage));
      InteractHUDParent.NativeFieldInfoPtr_InteractFillImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractHUDParent>.NativeClassPtr, nameof (InteractFillImage));
      InteractHUDParent.NativeFieldInfoPtr_InteractKeyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractHUDParent>.NativeClassPtr, nameof (InteractKeyText));
      InteractHUDParent.NativeFieldInfoPtr_InteractKeyImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractHUDParent>.NativeClassPtr, nameof (InteractKeyImage));
      InteractHUDParent.NativeFieldInfoPtr_InteractNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractHUDParent>.NativeClassPtr, nameof (InteractNameText));
      InteractHUDParent.NativeFieldInfoPtr_FeedPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractHUDParent>.NativeClassPtr, nameof (FeedPrefab));
      InteractHUDParent.NativeFieldInfoPtr_LKey_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractHUDParent>.NativeClassPtr, nameof (LKey_Container));
      InteractHUDParent.NativeFieldInfoPtr_ZoomSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractHUDParent>.NativeClassPtr, nameof (ZoomSettings));
      InteractHUDParent.NativeFieldInfoPtr_RootCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractHUDParent>.NativeClassPtr, nameof (RootCanvasGroup));
      InteractHUDParent.NativeFieldInfoPtr_LKey_VBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractHUDParent>.NativeClassPtr, nameof (LKey_VBlood));
      InteractHUDParent.NativeFieldInfoPtr_LKey_VBloodItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractHUDParent>.NativeClassPtr, nameof (LKey_VBloodItemName));
      InteractHUDParent.NativeFieldInfoPtr_ItemLevelRaritySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractHUDParent>.NativeClassPtr, nameof (ItemLevelRaritySettings));
      InteractHUDParent.NativeMethodInfoPtr_ToggleAvailable_Internal_Void_Boolean_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractHUDParent>.NativeClassPtr, 100667655);
      InteractHUDParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractHUDParent>.NativeClassPtr, 100667656);
    }

    public InteractHUDParent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image InteractBackgroundImage
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_InteractBackgroundImage));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_InteractBackgroundImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image InteractFillImage
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_InteractFillImage));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_InteractFillImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText InteractKeyText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_InteractKeyText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_InteractKeyText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image InteractKeyImage
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_InteractKeyImage));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_InteractKeyImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText InteractNameText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_InteractNameText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_InteractNameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent FeedPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_FeedPrefab));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_FeedPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_Container
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_LKey_Container));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_LKey_Container)) = value;
      }
    }

    public unsafe CharacterHUDSettings ZoomSettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_ZoomSettings));
        return pointer == IntPtr.Zero ? (CharacterHUDSettings) null : new CharacterHUDSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_ZoomSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CanvasGroup RootCanvasGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_RootCanvasGroup));
        return pointer == IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_RootCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_VBlood
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_LKey_VBlood));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_LKey_VBlood)) = value;
      }
    }

    public unsafe LocalizationKey LKey_VBloodItemName
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_LKey_VBloodItemName));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_LKey_VBloodItemName)) = value;
      }
    }

    public unsafe ItemLevelRaritySettings ItemLevelRaritySettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_ItemLevelRaritySettings));
        return pointer == IntPtr.Zero ? (ItemLevelRaritySettings) null : new ItemLevelRaritySettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractHUDParent.NativeFieldInfoPtr_ItemLevelRaritySettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
