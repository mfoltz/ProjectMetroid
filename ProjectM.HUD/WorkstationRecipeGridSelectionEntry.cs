// Decompiled with JetBrains decompiler
// Type: WorkstationRecipeGridSelectionEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM;
using ProjectM.UI;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class WorkstationRecipeGridSelectionEntry : GridSelectionEntry
{
  private static readonly System.IntPtr NativeFieldInfoPtr_QueuedCountText;
  private static readonly System.IntPtr NativeFieldInfoPtr_OutputAmountText;
  private static readonly System.IntPtr NativeFieldInfoPtr_ItemNameText;
  private static readonly System.IntPtr NativeFieldInfoPtr_TimeRemainingText;
  private static readonly System.IntPtr NativeFieldInfoPtr_TimeKeys;
  private static readonly System.IntPtr NativeFieldInfoPtr__LocalizedTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_ItemIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_ButtonComponent;
  private static readonly System.IntPtr NativeFieldInfoPtr_NotUnlockedBackground;
  private static readonly System.IntPtr NativeFieldInfoPtr_ProgressBackground;
  private static readonly System.IntPtr NativeFieldInfoPtr_ProgressImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_NotUnlockedIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_UpgradeIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_IconRarityBackground;
  private static readonly System.IntPtr NativeFieldInfoPtr_EntryId;
  private static readonly System.IntPtr NativeFieldInfoPtr_AlreadyUnlocked;
  private static readonly System.IntPtr NativeFieldInfoPtr_InQueue;
  private static readonly System.IntPtr NativeFieldInfoPtr_ItemLevelRaritySettings;
  private static readonly System.IntPtr NativeFieldInfoPtr_RarityAlpha;
  private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundSprite_NotUnlocked;
  private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_NotUnlocked_Servant;
  private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_NotUnlocked_Tech;
  private static readonly System.IntPtr NativeFieldInfoPtr_Alpha_NotUnlocked;
  private static readonly System.IntPtr NativeFieldInfoPtr_NewImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_Requirements;
  private static readonly System.IntPtr NativeFieldInfoPtr_IsUnlocked;
  private static readonly System.IntPtr NativeFieldInfoPtr_IsActive;
  private static readonly System.IntPtr NativeFieldInfoPtr_RequirementsMet;
  private static readonly System.IntPtr NativeMethodInfoPtr_AllRequirementMet_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Static_Void_WorkstationRecipeGridSelectionEntry_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeString_Private_Static_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1205837, RefRangeEnd = 1205838, XrefRangeStart = 1205833, XrefRangeEnd = 1205837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool AllRequirementMet()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorkstationRecipeGridSelectionEntry.NativeMethodInfoPtr_AllRequirementMet_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 1205893, RefRangeEnd = 1205898, XrefRangeStart = 1205838, XrefRangeEnd = 1205893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RefreshData(
    WorkstationRecipeGridSelectionEntry entry,
    WorkstationRecipeGridSelectionEntry.Data data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WorkstationRecipeGridSelectionEntry.NativeMethodInfoPtr_RefreshData_Public_Static_Void_WorkstationRecipeGridSelectionEntry_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205898, XrefRangeEnd = 1205918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetTimeString(float timeLeft)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &timeLeft;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(WorkstationRecipeGridSelectionEntry.NativeMethodInfoPtr_GetTimeString_Private_Static_String_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205918, XrefRangeEnd = 1205919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WorkstationRecipeGridSelectionEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WorkstationRecipeGridSelectionEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static WorkstationRecipeGridSelectionEntry()
  {
    Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (WorkstationRecipeGridSelectionEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr);
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_QueuedCountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (QueuedCountText));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_OutputAmountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (OutputAmountText));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_ItemNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (ItemNameText));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_TimeRemainingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (TimeRemainingText));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_TimeKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (TimeKeys));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr__LocalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (_LocalizedTime));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_ItemIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (ItemIcon));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_ButtonComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (ButtonComponent));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_NotUnlockedBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (NotUnlockedBackground));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_ProgressBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (ProgressBackground));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_ProgressImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (ProgressImage));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_NotUnlockedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (NotUnlockedIcon));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_UpgradeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (UpgradeIcon));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_IconRarityBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (IconRarityBackground));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_EntryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (EntryId));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_AlreadyUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (AlreadyUnlocked));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_InQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (InQueue));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_ItemLevelRaritySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (ItemLevelRaritySettings));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_RarityAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (RarityAlpha));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_BackgroundSprite_NotUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (BackgroundSprite_NotUnlocked));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_Sprite_NotUnlocked_Servant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (Sprite_NotUnlocked_Servant));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_Sprite_NotUnlocked_Tech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (Sprite_NotUnlocked_Tech));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_Alpha_NotUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (Alpha_NotUnlocked));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_NewImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (NewImage));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_Requirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (Requirements));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_IsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (IsUnlocked));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_IsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (IsActive));
    WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_RequirementsMet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (RequirementsMet));
    WorkstationRecipeGridSelectionEntry.NativeMethodInfoPtr_AllRequirementMet_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, 100663354);
    WorkstationRecipeGridSelectionEntry.NativeMethodInfoPtr_RefreshData_Public_Static_Void_WorkstationRecipeGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, 100663355);
    WorkstationRecipeGridSelectionEntry.NativeMethodInfoPtr_GetTimeString_Private_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, 100663356);
    WorkstationRecipeGridSelectionEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, 100663357);
  }

  public WorkstationRecipeGridSelectionEntry(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizedText QueuedCountText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_QueuedCountText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_QueuedCountText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText OutputAmountText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_OutputAmountText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_OutputAmountText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText ItemNameText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_ItemNameText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_ItemNameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText TimeRemainingText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_TimeRemainingText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_TimeRemainingText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizationTimeKeys TimeKeys
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_TimeKeys));
      return pointer == System.IntPtr.Zero ? (LocalizationTimeKeys) null : new LocalizationTimeKeys(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_TimeKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public LocalizedTimeBuilder _LocalizedTime
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr__LocalizedTime);
      return new LocalizedTimeBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr__LocalizedTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe Image ItemIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_ItemIcon));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_ItemIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button ButtonComponent
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_ButtonComponent));
      return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_ButtonComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image NotUnlockedBackground
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_NotUnlockedBackground));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_NotUnlockedBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image ProgressBackground
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_ProgressBackground));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_ProgressBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image ProgressImage
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_ProgressImage));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_ProgressImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image NotUnlockedIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_NotUnlockedIcon));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_NotUnlockedIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image UpgradeIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_UpgradeIcon));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_UpgradeIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image IconRarityBackground
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_IconRarityBackground));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_IconRarityBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PrefabGUID EntryId
  {
    get
    {
      return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_EntryId));
    }
    [param: In] set
    {
      *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_EntryId)) = value;
    }
  }

  public unsafe LocalizationKey AlreadyUnlocked
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_AlreadyUnlocked));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_AlreadyUnlocked)) = value;
    }
  }

  public unsafe LocalizationKey InQueue
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_InQueue));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_InQueue)) = value;
    }
  }

  public unsafe ItemLevelRaritySettings ItemLevelRaritySettings
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_ItemLevelRaritySettings));
      return pointer == System.IntPtr.Zero ? (ItemLevelRaritySettings) null : new ItemLevelRaritySettings(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_ItemLevelRaritySettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float RarityAlpha
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_RarityAlpha));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_RarityAlpha)) = value;
    }
  }

  public unsafe Sprite BackgroundSprite_NotUnlocked
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_BackgroundSprite_NotUnlocked));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_BackgroundSprite_NotUnlocked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite Sprite_NotUnlocked_Servant
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_Sprite_NotUnlocked_Servant));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_Sprite_NotUnlocked_Servant), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite Sprite_NotUnlocked_Tech
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_Sprite_NotUnlocked_Tech));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_Sprite_NotUnlocked_Tech), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe byte Alpha_NotUnlocked
  {
    get
    {
      return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_Alpha_NotUnlocked));
    }
    [param: In] set
    {
      *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_Alpha_NotUnlocked)) = value;
    }
  }

  public unsafe Image NewImage
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_NewImage));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_NewImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CostData> Requirements
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_Requirements));
      return pointer == System.IntPtr.Zero ? (List<CostData>) null : new List<CostData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_Requirements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool IsUnlocked
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_IsUnlocked));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_IsUnlocked)) = value;
    }
  }

  public unsafe bool IsActive
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_IsActive));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_IsActive)) = value;
    }
  }

  public unsafe bool RequirementsMet
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_RequirementsMet));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.NativeFieldInfoPtr_RequirementsMet)) = value;
    }
  }

  public sealed class Data : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EntryId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemSprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_RarityValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsUpgrade;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsNew;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsEmpty;
    private static readonly System.IntPtr NativeFieldInfoPtr_Progress;
    private static readonly System.IntPtr NativeFieldInfoPtr_CraftDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputName;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputAmount;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_Requirements;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsActive;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueuedCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueueSpot;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sorting;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowLearnedText;

    static Data()
    {
      Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr);
      WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_EntryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, nameof (EntryId));
      WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_ItemSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, nameof (ItemSprite));
      WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_RarityValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, nameof (RarityValue));
      WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_IsUpgrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, nameof (IsUpgrade));
      WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_IsNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, nameof (IsNew));
      WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_IsEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, nameof (IsEmpty));
      WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, nameof (Progress));
      WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_CraftDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, nameof (CraftDuration));
      WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_TimeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, nameof (TimeLeft));
      WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_OutputName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, nameof (OutputName));
      WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_OutputAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, nameof (OutputAmount));
      WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_ItemLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, nameof (ItemLevel));
      WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_Requirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, nameof (Requirements));
      WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_IsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, nameof (IsActive));
      WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_QueuedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, nameof (QueuedCount));
      WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_QueueSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, nameof (QueueSpot));
      WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_IsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, nameof (IsUnlocked));
      WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_Sorting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, nameof (Sorting));
      WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_ShowLearnedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, nameof (ShowLearnedText));
    }

    public Data(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Data()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorkstationRecipeGridSelectionEntry.Data>.NativeClassPtr, data));
    }

    public unsafe PrefabGUID EntryId
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_EntryId));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_EntryId)) = value;
      }
    }

    public unsafe Sprite ItemSprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_ItemSprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_ItemSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float RarityValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_RarityValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_RarityValue)) = value;
      }
    }

    public unsafe bool IsUpgrade
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_IsUpgrade));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_IsUpgrade)) = value;
      }
    }

    public unsafe bool IsNew
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_IsNew));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_IsNew)) = value;
      }
    }

    public unsafe bool IsEmpty
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_IsEmpty));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_IsEmpty)) = value;
      }
    }

    public unsafe float Progress
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_Progress));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_Progress)) = value;
      }
    }

    public unsafe float CraftDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_CraftDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_CraftDuration)) = value;
      }
    }

    public unsafe float TimeLeft
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_TimeLeft));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_TimeLeft)) = value;
      }
    }

    public unsafe LocalizationKey OutputName
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_OutputName));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_OutputName)) = value;
      }
    }

    public unsafe int OutputAmount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_OutputAmount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_OutputAmount)) = value;
      }
    }

    public unsafe float ItemLevel
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_ItemLevel));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_ItemLevel)) = value;
      }
    }

    public unsafe List<CostData> Requirements
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_Requirements));
        return pointer == System.IntPtr.Zero ? (List<CostData>) null : new List<CostData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_Requirements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool IsActive
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_IsActive));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_IsActive)) = value;
      }
    }

    public unsafe int QueuedCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_QueuedCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_QueuedCount)) = value;
      }
    }

    public unsafe int QueueSpot
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_QueueSpot));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_QueueSpot)) = value;
      }
    }

    public unsafe bool IsUnlocked
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_IsUnlocked));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_IsUnlocked)) = value;
      }
    }

    public unsafe int Sorting
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_Sorting));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_Sorting)) = value;
      }
    }

    public unsafe bool ShowLearnedText
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_ShowLearnedText));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationRecipeGridSelectionEntry.Data.NativeFieldInfoPtr_ShowLearnedText)) = value;
      }
    }
  }
}
