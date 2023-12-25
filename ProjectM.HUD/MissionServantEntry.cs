// Decompiled with JetBrains decompiler
// Type: MissionServantEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM;
using ProjectM.UI;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class MissionServantEntry : GridSelectionEntry
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Parent_Empty;
  private static readonly System.IntPtr NativeFieldInfoPtr_Parent_Assigned;
  private static readonly System.IntPtr NativeFieldInfoPtr_Background_Normal;
  private static readonly System.IntPtr NativeFieldInfoPtr_Background_Hovered;
  private static readonly System.IntPtr NativeFieldInfoPtr_Background_Selected;
  private static readonly System.IntPtr NativeFieldInfoPtr_Background;
  private static readonly System.IntPtr NativeFieldInfoPtr_RemoveButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_Name;
  private static readonly System.IntPtr NativeFieldInfoPtr_Power;
  private static readonly System.IntPtr NativeFieldInfoPtr_PartyParent;
  private static readonly System.IntPtr NativeFieldInfoPtr_PartyPower;
  private static readonly System.IntPtr NativeFieldInfoPtr_SuccessChance;
  private static readonly System.IntPtr NativeFieldInfoPtr_CurrentData;
  private static readonly System.IntPtr NativeFieldInfoPtr_Prefab_MissionPerkEntry;
  private static readonly System.IntPtr NativeFieldInfoPtr_Grid_MissionPerk;
  private static readonly System.IntPtr NativeFieldInfoPtr_MissionPerkGroup;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Static_Void_MissionServantEntry_Data_ControllerType_GameDataSystem_GridSelectionGroup_2_MissionServantEntry_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__17_0_Private_Void_MissionPerkEntry_Data_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205424, XrefRangeEnd = 1205439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MissionServantEntry.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1205465, RefRangeEnd = 1205466, XrefRangeStart = 1205439, XrefRangeEnd = 1205465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RefreshData(
    MissionServantEntry entry,
    MissionServantEntry.Data data,
    ControllerType controllerType,
    GameDataSystem gameDataSystem,
    GridSelectionGroup<MissionServantEntry, MissionServantEntry.Data> parent)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MissionServantEntry.NativeMethodInfoPtr_RefreshData_Public_Static_Void_MissionServantEntry_Data_ControllerType_GameDataSystem_GridSelectionGroup_2_MissionServantEntry_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MissionServantEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MissionServantEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205466, XrefRangeEnd = 1205475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Awake_b__17_0(MissionPerkEntry entry, MissionPerkEntry.Data data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MissionServantEntry.NativeMethodInfoPtr__Awake_b__17_0_Private_Void_MissionPerkEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MissionServantEntry()
  {
    Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (MissionServantEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr);
    MissionServantEntry.NativeFieldInfoPtr_Parent_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, nameof (Parent_Empty));
    MissionServantEntry.NativeFieldInfoPtr_Parent_Assigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, nameof (Parent_Assigned));
    MissionServantEntry.NativeFieldInfoPtr_Background_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, nameof (Background_Normal));
    MissionServantEntry.NativeFieldInfoPtr_Background_Hovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, nameof (Background_Hovered));
    MissionServantEntry.NativeFieldInfoPtr_Background_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, nameof (Background_Selected));
    MissionServantEntry.NativeFieldInfoPtr_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, nameof (Background));
    MissionServantEntry.NativeFieldInfoPtr_RemoveButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, nameof (RemoveButton));
    MissionServantEntry.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, nameof (Name));
    MissionServantEntry.NativeFieldInfoPtr_Power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, nameof (Power));
    MissionServantEntry.NativeFieldInfoPtr_PartyParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, nameof (PartyParent));
    MissionServantEntry.NativeFieldInfoPtr_PartyPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, nameof (PartyPower));
    MissionServantEntry.NativeFieldInfoPtr_SuccessChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, nameof (SuccessChance));
    MissionServantEntry.NativeFieldInfoPtr_CurrentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, nameof (CurrentData));
    MissionServantEntry.NativeFieldInfoPtr_Prefab_MissionPerkEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, nameof (Prefab_MissionPerkEntry));
    MissionServantEntry.NativeFieldInfoPtr_Grid_MissionPerk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, nameof (Grid_MissionPerk));
    MissionServantEntry.NativeFieldInfoPtr_MissionPerkGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, nameof (MissionPerkGroup));
    MissionServantEntry.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, 100663319);
    MissionServantEntry.NativeMethodInfoPtr_RefreshData_Public_Static_Void_MissionServantEntry_Data_ControllerType_GameDataSystem_GridSelectionGroup_2_MissionServantEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, 100663320);
    MissionServantEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, 100663321);
    MissionServantEntry.NativeMethodInfoPtr__Awake_b__17_0_Private_Void_MissionPerkEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, 100663322);
  }

  public MissionServantEntry(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe GameObject Parent_Empty
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Parent_Empty));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Parent_Empty), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject Parent_Assigned
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Parent_Assigned));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Parent_Assigned), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite Background_Normal
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Background_Normal));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Background_Normal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite Background_Hovered
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Background_Hovered));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Background_Hovered), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite Background_Selected
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Background_Selected));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Background_Selected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image Background
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Background));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Background), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button RemoveButton
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_RemoveButton));
      return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_RemoveButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText Name
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Name));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText Power
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Power));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Power), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject PartyParent
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_PartyParent));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_PartyParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText PartyPower
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_PartyPower));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_PartyPower), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText SuccessChance
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_SuccessChance));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_SuccessChance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public MissionServantEntry.Data CurrentData
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_CurrentData);
      return new MissionServantEntry.Data(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MissionServantEntry.Data>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_CurrentData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MissionServantEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe MissionPerkEntry Prefab_MissionPerkEntry
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Prefab_MissionPerkEntry));
      return pointer == System.IntPtr.Zero ? (MissionPerkEntry) null : new MissionPerkEntry(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Prefab_MissionPerkEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GridLayoutGroup Grid_MissionPerk
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Grid_MissionPerk));
      return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_Grid_MissionPerk), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GridSelectionGroup<MissionPerkEntry, MissionPerkEntry.Data> MissionPerkGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_MissionPerkGroup));
      return pointer == System.IntPtr.Zero ? (GridSelectionGroup<MissionPerkEntry, MissionPerkEntry.Data>) null : new GridSelectionGroup<MissionPerkEntry, MissionPerkEntry.Data>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.NativeFieldInfoPtr_MissionPerkGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class Data : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_IsSet;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Power;
    private static readonly System.IntPtr NativeFieldInfoPtr_RawLootBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_Perks;

    static Data()
    {
      Il2CppClassPointerStore<MissionServantEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MissionServantEntry>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionServantEntry.Data>.NativeClassPtr);
      MissionServantEntry.Data.NativeFieldInfoPtr_IsSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry.Data>.NativeClassPtr, nameof (IsSet));
      MissionServantEntry.Data.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry.Data>.NativeClassPtr, nameof (Entity));
      MissionServantEntry.Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry.Data>.NativeClassPtr, nameof (Name));
      MissionServantEntry.Data.NativeFieldInfoPtr_Power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry.Data>.NativeClassPtr, nameof (Power));
      MissionServantEntry.Data.NativeFieldInfoPtr_RawLootBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry.Data>.NativeClassPtr, nameof (RawLootBonus));
      MissionServantEntry.Data.NativeFieldInfoPtr_Perks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionServantEntry.Data>.NativeClassPtr, nameof (Perks));
    }

    public Data(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Data()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MissionServantEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MissionServantEntry.Data>.NativeClassPtr, data));
    }

    public unsafe bool IsSet
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.Data.NativeFieldInfoPtr_IsSet));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.Data.NativeFieldInfoPtr_IsSet)) = value;
      }
    }

    public unsafe Entity Entity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.Data.NativeFieldInfoPtr_Entity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.Data.NativeFieldInfoPtr_Entity)) = value;
      }
    }

    public unsafe string Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.Data.NativeFieldInfoPtr_Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.Data.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float Power
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.Data.NativeFieldInfoPtr_Power));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.Data.NativeFieldInfoPtr_Power)) = value;
      }
    }

    public unsafe float RawLootBonus
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.Data.NativeFieldInfoPtr_RawLootBonus));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.Data.NativeFieldInfoPtr_RawLootBonus)) = value;
      }
    }

    public unsafe List<MissionPerkEntry.Data> Perks
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.Data.NativeFieldInfoPtr_Perks));
        return pointer == System.IntPtr.Zero ? (List<MissionPerkEntry.Data>) null : new List<MissionPerkEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MissionServantEntry.Data.NativeFieldInfoPtr_Perks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
