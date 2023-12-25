// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.DeathMenu
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
  public class DeathMenu : HUDMenu
  {
    private static readonly IntPtr NativeFieldInfoPtr_Root;
    private static readonly IntPtr NativeFieldInfoPtr_Motion;
    private static readonly IntPtr NativeFieldInfoPtr_Image_RespawnProgress;
    private static readonly IntPtr NativeFieldInfoPtr_Image_ForceRespawnProgress;
    private static readonly IntPtr NativeFieldInfoPtr_Header;
    private static readonly IntPtr NativeFieldInfoPtr_SubHeader;
    private static readonly IntPtr NativeFieldInfoPtr_DurabilityLossInfoText;
    private static readonly IntPtr NativeFieldInfoPtr_RespawnTimer;
    private static readonly IntPtr NativeFieldInfoPtr_CanRespawn;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnSelectionPopupNode;
    private static readonly IntPtr NativeFieldInfoPtr_SelectSpawnPointText;
    private static readonly IntPtr NativeFieldInfoPtr_SelectionEntryPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_SelectionEntryRoot;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_SourceDeathTime;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_DurabilityLossKey;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_TimeValueKey;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_PressButtonToSpawnKey;
    private static readonly IntPtr NativeFieldInfoPtr_HideHUDElements;
    private static readonly IntPtr NativeFieldInfoPtr__ButtonCache;
    private static readonly IntPtr NativeMethodInfoPtr_get_ButtonCache_Public_get_UI_Cache_1_SpawnPointSelectionEntry_0;
    private static readonly IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe UI_Cache<SpawnPointSelectionEntry> ButtonCache
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeathMenu.NativeMethodInfoPtr_get_ButtonCache_Public_get_UI_Cache_1_SpawnPointSelectionEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (UI_Cache<SpawnPointSelectionEntry>) null : new UI_Cache<SpawnPointSelectionEntry>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233959, XrefRangeEnd = 1233966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeathMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DeathMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeathMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DeathMenu()
    {
      Il2CppClassPointerStore<DeathMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (DeathMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr);
      DeathMenu.NativeFieldInfoPtr_Root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, nameof (Root));
      DeathMenu.NativeFieldInfoPtr_Motion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, nameof (Motion));
      DeathMenu.NativeFieldInfoPtr_Image_RespawnProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, nameof (Image_RespawnProgress));
      DeathMenu.NativeFieldInfoPtr_Image_ForceRespawnProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, nameof (Image_ForceRespawnProgress));
      DeathMenu.NativeFieldInfoPtr_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, nameof (Header));
      DeathMenu.NativeFieldInfoPtr_SubHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, nameof (SubHeader));
      DeathMenu.NativeFieldInfoPtr_DurabilityLossInfoText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, nameof (DurabilityLossInfoText));
      DeathMenu.NativeFieldInfoPtr_RespawnTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, nameof (RespawnTimer));
      DeathMenu.NativeFieldInfoPtr_CanRespawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, nameof (CanRespawn));
      DeathMenu.NativeFieldInfoPtr_SpawnSelectionPopupNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, nameof (SpawnSelectionPopupNode));
      DeathMenu.NativeFieldInfoPtr_SelectSpawnPointText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, nameof (SelectSpawnPointText));
      DeathMenu.NativeFieldInfoPtr_SelectionEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, nameof (SelectionEntryPrefab));
      DeathMenu.NativeFieldInfoPtr_SelectionEntryRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, nameof (SelectionEntryRoot));
      DeathMenu.NativeFieldInfoPtr_LKey_SourceDeathTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, nameof (LKey_SourceDeathTime));
      DeathMenu.NativeFieldInfoPtr_LKey_DurabilityLossKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, nameof (LKey_DurabilityLossKey));
      DeathMenu.NativeFieldInfoPtr_LKey_TimeValueKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, nameof (LKey_TimeValueKey));
      DeathMenu.NativeFieldInfoPtr_LKey_PressButtonToSpawnKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, nameof (LKey_PressButtonToSpawnKey));
      DeathMenu.NativeFieldInfoPtr_HideHUDElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, nameof (HideHUDElements));
      DeathMenu.NativeFieldInfoPtr__ButtonCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, nameof (_ButtonCache));
      DeathMenu.NativeMethodInfoPtr_get_ButtonCache_Public_get_UI_Cache_1_SpawnPointSelectionEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, 100665618);
      DeathMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, 100665619);
      DeathMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathMenu>.NativeClassPtr, 100665620);
    }

    public DeathMenu(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameObject Root
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_Root));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_Root), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DInOut Motion
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_Motion));
        return pointer == IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_Motion), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Image_RespawnProgress
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_Image_RespawnProgress));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_Image_RespawnProgress), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Image_ForceRespawnProgress
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_Image_ForceRespawnProgress));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_Image_ForceRespawnProgress), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Header
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_Header));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_Header), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SubHeader
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_SubHeader));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_SubHeader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText DurabilityLossInfoText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_DurabilityLossInfoText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_DurabilityLossInfoText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText RespawnTimer
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_RespawnTimer));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_RespawnTimer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText CanRespawn
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_CanRespawn));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_CanRespawn), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SpawnSelectionPopupNode
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_SpawnSelectionPopupNode));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_SpawnSelectionPopupNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SelectSpawnPointText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_SelectSpawnPointText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_SelectSpawnPointText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnPointSelectionEntry SelectionEntryPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_SelectionEntryPrefab));
        return pointer == IntPtr.Zero ? (SpawnPointSelectionEntry) null : new SpawnPointSelectionEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_SelectionEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SelectionEntryRoot
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_SelectionEntryRoot));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_SelectionEntryRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_SourceDeathTime
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_LKey_SourceDeathTime));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_LKey_SourceDeathTime)) = value;
      }
    }

    public unsafe LocalizationKey LKey_DurabilityLossKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_LKey_DurabilityLossKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_LKey_DurabilityLossKey)) = value;
      }
    }

    public unsafe LocalizationKey LKey_TimeValueKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_LKey_TimeValueKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_LKey_TimeValueKey)) = value;
      }
    }

    public unsafe LocalizationKey LKey_PressButtonToSpawnKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_LKey_PressButtonToSpawnKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_LKey_PressButtonToSpawnKey)) = value;
      }
    }

    public unsafe HUDElementType HideHUDElements
    {
      get
      {
        return *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_HideHUDElements));
      }
      [param: In] set
      {
        *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr_HideHUDElements)) = value;
      }
    }

    public unsafe UI_Cache<SpawnPointSelectionEntry> _ButtonCache
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr__ButtonCache));
        return pointer == IntPtr.Zero ? (UI_Cache<SpawnPointSelectionEntry>) null : new UI_Cache<SpawnPointSelectionEntry>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeathMenu.NativeFieldInfoPtr__ButtonCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
