// Decompiled with JetBrains decompiler
// Type: ServantSelectEntry
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
using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ServantSelectEntry : GridSelectionEntry
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Background_Normal;
  private static readonly System.IntPtr NativeFieldInfoPtr_Background_Hovered;
  private static readonly System.IntPtr NativeFieldInfoPtr_Background_Selected;
  private static readonly System.IntPtr NativeFieldInfoPtr_Background_Disabled;
  private static readonly System.IntPtr NativeFieldInfoPtr_IssueColor_Default;
  private static readonly System.IntPtr NativeFieldInfoPtr_IssueColor_AlreadyAssigned;
  private static readonly System.IntPtr NativeFieldInfoPtr_IssueColor_InjuryDescription;
  private static readonly System.IntPtr NativeFieldInfoPtr_Background;
  private static readonly System.IntPtr NativeFieldInfoPtr_Name;
  private static readonly System.IntPtr NativeFieldInfoPtr_Power;
  private static readonly System.IntPtr NativeFieldInfoPtr_IssueText;
  private static readonly System.IntPtr NativeFieldInfoPtr_Prefab_MissionPerkEntry;
  private static readonly System.IntPtr NativeFieldInfoPtr_Grid_MissionPerk;
  private static readonly System.IntPtr NativeFieldInfoPtr_MissionPerkGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Dead;
  private static readonly System.IntPtr NativeFieldInfoPtr_LKey_HasItemsInInventory;
  private static readonly System.IntPtr NativeFieldInfoPtr_LKey_AwayOnHunt;
  private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Recuperating;
  private static readonly System.IntPtr NativeFieldInfoPtr_LKey_AlreadyAssigned;
  private static readonly System.IntPtr NativeFieldInfoPtr_LKey_InjuredHeader;
  private static readonly System.IntPtr NativeFieldInfoPtr_TimeKeys;
  private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_CurrentData;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Static_Void_ServantSelectEntry_Data_ControllerType_GameDataSystem_GridSelectionGroup_2_ServantSelectEntry_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__23_0_Private_Void_MissionPerkEntry_Data_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205751, XrefRangeEnd = 1205766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ServantSelectEntry.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1205826, RefRangeEnd = 1205827, XrefRangeStart = 1205766, XrefRangeEnd = 1205826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RefreshData(
    ServantSelectEntry entry,
    ServantSelectEntry.Data data,
    ControllerType controllerType,
    GameDataSystem gameDataSystem,
    GridSelectionGroup<ServantSelectEntry, ServantSelectEntry.Data> parent)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ServantSelectEntry.NativeMethodInfoPtr_RefreshData_Public_Static_Void_ServantSelectEntry_Data_ControllerType_GameDataSystem_GridSelectionGroup_2_ServantSelectEntry_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ServantSelectEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ServantSelectEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205827, XrefRangeEnd = 1205829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Awake_b__23_0(MissionPerkEntry entry, MissionPerkEntry.Data data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ServantSelectEntry.NativeMethodInfoPtr__Awake_b__23_0_Private_Void_MissionPerkEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ServantSelectEntry()
  {
    Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (ServantSelectEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr);
    ServantSelectEntry.NativeFieldInfoPtr_Background_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (Background_Normal));
    ServantSelectEntry.NativeFieldInfoPtr_Background_Hovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (Background_Hovered));
    ServantSelectEntry.NativeFieldInfoPtr_Background_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (Background_Selected));
    ServantSelectEntry.NativeFieldInfoPtr_Background_Disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (Background_Disabled));
    ServantSelectEntry.NativeFieldInfoPtr_IssueColor_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (IssueColor_Default));
    ServantSelectEntry.NativeFieldInfoPtr_IssueColor_AlreadyAssigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (IssueColor_AlreadyAssigned));
    ServantSelectEntry.NativeFieldInfoPtr_IssueColor_InjuryDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (IssueColor_InjuryDescription));
    ServantSelectEntry.NativeFieldInfoPtr_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (Background));
    ServantSelectEntry.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (Name));
    ServantSelectEntry.NativeFieldInfoPtr_Power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (Power));
    ServantSelectEntry.NativeFieldInfoPtr_IssueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (IssueText));
    ServantSelectEntry.NativeFieldInfoPtr_Prefab_MissionPerkEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (Prefab_MissionPerkEntry));
    ServantSelectEntry.NativeFieldInfoPtr_Grid_MissionPerk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (Grid_MissionPerk));
    ServantSelectEntry.NativeFieldInfoPtr_MissionPerkGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (MissionPerkGroup));
    ServantSelectEntry.NativeFieldInfoPtr_LKey_Dead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (LKey_Dead));
    ServantSelectEntry.NativeFieldInfoPtr_LKey_HasItemsInInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (LKey_HasItemsInInventory));
    ServantSelectEntry.NativeFieldInfoPtr_LKey_AwayOnHunt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (LKey_AwayOnHunt));
    ServantSelectEntry.NativeFieldInfoPtr_LKey_Recuperating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (LKey_Recuperating));
    ServantSelectEntry.NativeFieldInfoPtr_LKey_AlreadyAssigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (LKey_AlreadyAssigned));
    ServantSelectEntry.NativeFieldInfoPtr_LKey_InjuredHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (LKey_InjuredHeader));
    ServantSelectEntry.NativeFieldInfoPtr_TimeKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (TimeKeys));
    ServantSelectEntry.NativeFieldInfoPtr_LocalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (LocalizedTime));
    ServantSelectEntry.NativeFieldInfoPtr_CurrentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (CurrentData));
    ServantSelectEntry.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, 100663348);
    ServantSelectEntry.NativeMethodInfoPtr_RefreshData_Public_Static_Void_ServantSelectEntry_Data_ControllerType_GameDataSystem_GridSelectionGroup_2_ServantSelectEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, 100663349);
    ServantSelectEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, 100663350);
    ServantSelectEntry.NativeMethodInfoPtr__Awake_b__23_0_Private_Void_MissionPerkEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, 100663351);
  }

  public ServantSelectEntry(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Sprite Background_Normal
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_Background_Normal));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_Background_Normal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite Background_Hovered
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_Background_Hovered));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_Background_Hovered), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite Background_Selected
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_Background_Selected));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_Background_Selected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite Background_Disabled
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_Background_Disabled));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_Background_Disabled), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color IssueColor_Default
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_IssueColor_Default));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_IssueColor_Default)) = value;
    }
  }

  public unsafe Color IssueColor_AlreadyAssigned
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_IssueColor_AlreadyAssigned));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_IssueColor_AlreadyAssigned)) = value;
    }
  }

  public unsafe Color IssueColor_InjuryDescription
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_IssueColor_InjuryDescription));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_IssueColor_InjuryDescription)) = value;
    }
  }

  public unsafe Image Background
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_Background));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_Background), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText Name
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_Name));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText Power
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_Power));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_Power), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText IssueText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_IssueText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_IssueText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MissionPerkEntry Prefab_MissionPerkEntry
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_Prefab_MissionPerkEntry));
      return pointer == System.IntPtr.Zero ? (MissionPerkEntry) null : new MissionPerkEntry(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_Prefab_MissionPerkEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GridLayoutGroup Grid_MissionPerk
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_Grid_MissionPerk));
      return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_Grid_MissionPerk), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GridSelectionGroup<MissionPerkEntry, MissionPerkEntry.Data> MissionPerkGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_MissionPerkGroup));
      return pointer == System.IntPtr.Zero ? (GridSelectionGroup<MissionPerkEntry, MissionPerkEntry.Data>) null : new GridSelectionGroup<MissionPerkEntry, MissionPerkEntry.Data>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_MissionPerkGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizationKey LKey_Dead
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_LKey_Dead));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_LKey_Dead)) = value;
    }
  }

  public unsafe LocalizationKey LKey_HasItemsInInventory
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_LKey_HasItemsInInventory));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_LKey_HasItemsInInventory)) = value;
    }
  }

  public unsafe LocalizationKey LKey_AwayOnHunt
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_LKey_AwayOnHunt));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_LKey_AwayOnHunt)) = value;
    }
  }

  public unsafe LocalizationKey LKey_Recuperating
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_LKey_Recuperating));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_LKey_Recuperating)) = value;
    }
  }

  public unsafe LocalizationKey LKey_AlreadyAssigned
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_LKey_AlreadyAssigned));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_LKey_AlreadyAssigned)) = value;
    }
  }

  public unsafe LocalizationKey LKey_InjuredHeader
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_LKey_InjuredHeader));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_LKey_InjuredHeader)) = value;
    }
  }

  public unsafe LocalizationTimeKeys TimeKeys
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_TimeKeys));
      return pointer == System.IntPtr.Zero ? (LocalizationTimeKeys) null : new LocalizationTimeKeys(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_TimeKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public LocalizedTimeBuilder LocalizedTime
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_LocalizedTime);
      return new LocalizedTimeBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_LocalizedTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public ServantSelectEntry.Data CurrentData
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_CurrentData);
      return new ServantSelectEntry.Data(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantSelectEntry.Data>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.NativeFieldInfoPtr_CurrentData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServantSelectEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public enum State
  {
    Assignable,
    IsRecuperating,
    Dead,
    HasItemsInInventory,
    AlreadyAssigned,
    AwayOnHunt,
  }

  public sealed class Data : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Power;
    private static readonly System.IntPtr NativeFieldInfoPtr_RawLootBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_State;
    private static readonly System.IntPtr NativeFieldInfoPtr_Injury;
    private static readonly System.IntPtr NativeFieldInfoPtr_Perks;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecuperateTimeLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;

    static Data()
    {
      Il2CppClassPointerStore<ServantSelectEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantSelectEntry>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantSelectEntry.Data>.NativeClassPtr);
      ServantSelectEntry.Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry.Data>.NativeClassPtr, nameof (Name));
      ServantSelectEntry.Data.NativeFieldInfoPtr_Power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry.Data>.NativeClassPtr, nameof (Power));
      ServantSelectEntry.Data.NativeFieldInfoPtr_RawLootBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry.Data>.NativeClassPtr, nameof (RawLootBonus));
      ServantSelectEntry.Data.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry.Data>.NativeClassPtr, nameof (State));
      ServantSelectEntry.Data.NativeFieldInfoPtr_Injury = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry.Data>.NativeClassPtr, nameof (Injury));
      ServantSelectEntry.Data.NativeFieldInfoPtr_Perks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry.Data>.NativeClassPtr, nameof (Perks));
      ServantSelectEntry.Data.NativeFieldInfoPtr_RecuperateTimeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry.Data>.NativeClassPtr, nameof (RecuperateTimeLeft));
      ServantSelectEntry.Data.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSelectEntry.Data>.NativeClassPtr, nameof (Entity));
    }

    public Data(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Data()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServantSelectEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantSelectEntry.Data>.NativeClassPtr, data));
    }

    public unsafe string Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.Data.NativeFieldInfoPtr_Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.Data.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float Power
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.Data.NativeFieldInfoPtr_Power));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.Data.NativeFieldInfoPtr_Power)) = value;
      }
    }

    public unsafe float RawLootBonus
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.Data.NativeFieldInfoPtr_RawLootBonus));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.Data.NativeFieldInfoPtr_RawLootBonus)) = value;
      }
    }

    public unsafe ServantSelectEntry.State State
    {
      get
      {
        return *(ServantSelectEntry.State*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.Data.NativeFieldInfoPtr_State));
      }
      [param: In] set
      {
        *(ServantSelectEntry.State*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.Data.NativeFieldInfoPtr_State)) = value;
      }
    }

    public unsafe ManagedMissionInjureDataAsset Injury
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.Data.NativeFieldInfoPtr_Injury));
        return pointer == System.IntPtr.Zero ? (ManagedMissionInjureDataAsset) null : new ManagedMissionInjureDataAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.Data.NativeFieldInfoPtr_Injury), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<MissionPerkEntry.Data> Perks
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.Data.NativeFieldInfoPtr_Perks));
        return pointer == System.IntPtr.Zero ? (List<MissionPerkEntry.Data>) null : new List<MissionPerkEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.Data.NativeFieldInfoPtr_Perks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float RecuperateTimeLeft
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.Data.NativeFieldInfoPtr_RecuperateTimeLeft));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.Data.NativeFieldInfoPtr_RecuperateTimeLeft)) = value;
      }
    }

    public unsafe Entity Entity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.Data.NativeFieldInfoPtr_Entity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSelectEntry.Data.NativeFieldInfoPtr_Entity)) = value;
      }
    }
  }
}
