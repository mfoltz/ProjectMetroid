// Decompiled with JetBrains decompiler
// Type: RefinementstationRecipeEntry
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
public class RefinementstationRecipeEntry : GridSelectionEntry
{
  private static readonly System.IntPtr NativeFieldInfoPtr_RecipeName;
  private static readonly System.IntPtr NativeFieldInfoPtr_New;
  private static readonly System.IntPtr NativeFieldInfoPtr_Background;
  private static readonly System.IntPtr NativeFieldInfoPtr_NotUnlockedIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_NotUnlockedBackground;
  private static readonly System.IntPtr NativeFieldInfoPtr_InputSelectionGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_OutputSelectionGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_RecipeItemPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_InputParent;
  private static readonly System.IntPtr NativeFieldInfoPtr_OutputParent;
  private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_NotUnlocked_Servant;
  private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_NotUnlocked_Tech;
  private static readonly System.IntPtr NativeFieldInfoPtr_Alpha_NotUnlocked;
  private static readonly System.IntPtr NativeFieldInfoPtr_StandardColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_HilightColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_EntryId;
  private static readonly System.IntPtr NativeFieldInfoPtr_IsUnlocked;
  private static readonly System.IntPtr NativeFieldInfoPtr__InputData;
  private static readonly System.IntPtr NativeFieldInfoPtr__OutputData;
  private static readonly System.IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetHoveredItem_Public_Boolean_byref_PrefabGUID_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Internal_Static_Void_RefinementstationRecipeEntry_Data_ControllerType_GridSelectionGroup_2_RefinementstationRecipeEntry_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Void_InputState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsHilighted_Public_Static_Boolean_ControllerType_GridSelectionGroup_2_RefinementstationRecipeEntry_Data_RefinementstationRecipeEntry_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__18_0_Private_Void_RefinementstationRecipeItem_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__18_1_Private_Void_RefinementstationRecipeItem_Data_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205562, XrefRangeEnd = 1205588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RefinementstationRecipeEntry.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 1205594, RefRangeEnd = 1205596, XrefRangeStart = 1205588, XrefRangeEnd = 1205594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetHoveredItem(out PrefabGUID hoveredItemGuid)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) ref hoveredItemGuid;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RefinementstationRecipeEntry.NativeMethodInfoPtr_TryGetHoveredItem_Public_Boolean_byref_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 1205663, RefRangeEnd = 1205665, XrefRangeStart = 1205596, XrefRangeEnd = 1205663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RefreshData(
    RefinementstationRecipeEntry entry,
    RefinementstationRecipeEntry.Data data,
    ControllerType controllerType,
    GridSelectionGroup<RefinementstationRecipeEntry, RefinementstationRecipeEntry.Data> parent)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RefinementstationRecipeEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_RefinementstationRecipeEntry_Data_ControllerType_GridSelectionGroup_2_RefinementstationRecipeEntry_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 1205670, RefRangeEnd = 1205674, XrefRangeStart = 1205665, XrefRangeEnd = 1205670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HandleInput(InputState inputState)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &inputState;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RefinementstationRecipeEntry.NativeMethodInfoPtr_HandleInput_Public_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205674, XrefRangeEnd = 1205675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsHilighted(
    ControllerType controllerType,
    GridSelectionGroup<RefinementstationRecipeEntry, RefinementstationRecipeEntry.Data> parent,
    RefinementstationRecipeEntry entry)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &controllerType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RefinementstationRecipeEntry.NativeMethodInfoPtr_IsHilighted_Public_Static_Boolean_ControllerType_GridSelectionGroup_2_RefinementstationRecipeEntry_Data_RefinementstationRecipeEntry_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205675, XrefRangeEnd = 1205676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RefinementstationRecipeEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RefinementstationRecipeEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205676, XrefRangeEnd = 1205678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__18_0(
    RefinementstationRecipeItem entry,
    RefinementstationRecipeItem.Data data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RefinementstationRecipeEntry.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__18_0_Private_Void_RefinementstationRecipeItem_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205678, XrefRangeEnd = 1205680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__18_1(
    RefinementstationRecipeItem entry,
    RefinementstationRecipeItem.Data data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RefinementstationRecipeEntry.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__18_1_Private_Void_RefinementstationRecipeItem_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static RefinementstationRecipeEntry()
  {
    Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (RefinementstationRecipeEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr);
    RefinementstationRecipeEntry.NativeFieldInfoPtr_RecipeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (RecipeName));
    RefinementstationRecipeEntry.NativeFieldInfoPtr_New = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (New));
    RefinementstationRecipeEntry.NativeFieldInfoPtr_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (Background));
    RefinementstationRecipeEntry.NativeFieldInfoPtr_NotUnlockedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (NotUnlockedIcon));
    RefinementstationRecipeEntry.NativeFieldInfoPtr_NotUnlockedBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (NotUnlockedBackground));
    RefinementstationRecipeEntry.NativeFieldInfoPtr_InputSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (InputSelectionGroup));
    RefinementstationRecipeEntry.NativeFieldInfoPtr_OutputSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (OutputSelectionGroup));
    RefinementstationRecipeEntry.NativeFieldInfoPtr_RecipeItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (RecipeItemPrefab));
    RefinementstationRecipeEntry.NativeFieldInfoPtr_InputParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (InputParent));
    RefinementstationRecipeEntry.NativeFieldInfoPtr_OutputParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (OutputParent));
    RefinementstationRecipeEntry.NativeFieldInfoPtr_Sprite_NotUnlocked_Servant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (Sprite_NotUnlocked_Servant));
    RefinementstationRecipeEntry.NativeFieldInfoPtr_Sprite_NotUnlocked_Tech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (Sprite_NotUnlocked_Tech));
    RefinementstationRecipeEntry.NativeFieldInfoPtr_Alpha_NotUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (Alpha_NotUnlocked));
    RefinementstationRecipeEntry.NativeFieldInfoPtr_StandardColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (StandardColor));
    RefinementstationRecipeEntry.NativeFieldInfoPtr_HilightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (HilightColor));
    RefinementstationRecipeEntry.NativeFieldInfoPtr_EntryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (EntryId));
    RefinementstationRecipeEntry.NativeFieldInfoPtr_IsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (IsUnlocked));
    RefinementstationRecipeEntry.NativeFieldInfoPtr__InputData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (_InputData));
    RefinementstationRecipeEntry.NativeFieldInfoPtr__OutputData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (_OutputData));
    RefinementstationRecipeEntry.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, 100663334);
    RefinementstationRecipeEntry.NativeMethodInfoPtr_TryGetHoveredItem_Public_Boolean_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, 100663335);
    RefinementstationRecipeEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_RefinementstationRecipeEntry_Data_ControllerType_GridSelectionGroup_2_RefinementstationRecipeEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, 100663336);
    RefinementstationRecipeEntry.NativeMethodInfoPtr_HandleInput_Public_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, 100663337);
    RefinementstationRecipeEntry.NativeMethodInfoPtr_IsHilighted_Public_Static_Boolean_ControllerType_GridSelectionGroup_2_RefinementstationRecipeEntry_Data_RefinementstationRecipeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, 100663338);
    RefinementstationRecipeEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, 100663339);
    RefinementstationRecipeEntry.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__18_0_Private_Void_RefinementstationRecipeItem_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, 100663341);
    RefinementstationRecipeEntry.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__18_1_Private_Void_RefinementstationRecipeItem_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, 100663342);
  }

  public RefinementstationRecipeEntry(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizedText RecipeName
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_RecipeName));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_RecipeName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText New
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_New));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_New), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image Background
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_Background));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_Background), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image NotUnlockedIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_NotUnlockedIcon));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_NotUnlockedIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image NotUnlockedBackground
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_NotUnlockedBackground));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_NotUnlockedBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GridSelectionGroup<RefinementstationRecipeItem, RefinementstationRecipeItem.Data> InputSelectionGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_InputSelectionGroup));
      return pointer == System.IntPtr.Zero ? (GridSelectionGroup<RefinementstationRecipeItem, RefinementstationRecipeItem.Data>) null : new GridSelectionGroup<RefinementstationRecipeItem, RefinementstationRecipeItem.Data>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_InputSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GridSelectionGroup<RefinementstationRecipeItem, RefinementstationRecipeItem.Data> OutputSelectionGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_OutputSelectionGroup));
      return pointer == System.IntPtr.Zero ? (GridSelectionGroup<RefinementstationRecipeItem, RefinementstationRecipeItem.Data>) null : new GridSelectionGroup<RefinementstationRecipeItem, RefinementstationRecipeItem.Data>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_OutputSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RefinementstationRecipeItem RecipeItemPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_RecipeItemPrefab));
      return pointer == System.IntPtr.Zero ? (RefinementstationRecipeItem) null : new RefinementstationRecipeItem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_RecipeItemPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GridLayoutGroup InputParent
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_InputParent));
      return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_InputParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GridLayoutGroup OutputParent
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_OutputParent));
      return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_OutputParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite Sprite_NotUnlocked_Servant
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_Sprite_NotUnlocked_Servant));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_Sprite_NotUnlocked_Servant), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite Sprite_NotUnlocked_Tech
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_Sprite_NotUnlocked_Tech));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_Sprite_NotUnlocked_Tech), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe byte Alpha_NotUnlocked
  {
    get
    {
      return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_Alpha_NotUnlocked));
    }
    [param: In] set
    {
      *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_Alpha_NotUnlocked)) = value;
    }
  }

  public unsafe Color StandardColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_StandardColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_StandardColor)) = value;
    }
  }

  public unsafe Color HilightColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_HilightColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_HilightColor)) = value;
    }
  }

  public unsafe PrefabGUID EntryId
  {
    get
    {
      return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_EntryId));
    }
    [param: In] set
    {
      *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_EntryId)) = value;
    }
  }

  public unsafe bool IsUnlocked
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_IsUnlocked));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.NativeFieldInfoPtr_IsUnlocked)) = value;
    }
  }

  public static unsafe List<RefinementstationRecipeItem.Data> _InputData
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(RefinementstationRecipeEntry.NativeFieldInfoPtr__InputData, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<RefinementstationRecipeItem.Data>) null : new List<RefinementstationRecipeItem.Data>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RefinementstationRecipeEntry.NativeFieldInfoPtr__InputData, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe List<RefinementstationRecipeItem.Data> _OutputData
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(RefinementstationRecipeEntry.NativeFieldInfoPtr__OutputData, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<RefinementstationRecipeItem.Data>) null : new List<RefinementstationRecipeItem.Data>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RefinementstationRecipeEntry.NativeFieldInfoPtr__OutputData, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class Data : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Hilight;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntryId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Requirements;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputItems;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResourceMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsNew;

    static Data()
    {
      Il2CppClassPointerStore<RefinementstationRecipeEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RefinementstationRecipeEntry>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefinementstationRecipeEntry.Data>.NativeClassPtr);
      RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_Hilight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry.Data>.NativeClassPtr, nameof (Hilight));
      RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_EntryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry.Data>.NativeClassPtr, nameof (EntryId));
      RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_Requirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry.Data>.NativeClassPtr, nameof (Requirements));
      RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_OutputItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry.Data>.NativeClassPtr, nameof (OutputItems));
      RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry.Data>.NativeClassPtr, nameof (GameDataSystem));
      RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_ResourceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry.Data>.NativeClassPtr, nameof (ResourceMultiplier));
      RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_IsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry.Data>.NativeClassPtr, nameof (IsUnlocked));
      RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_IsNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipeEntry.Data>.NativeClassPtr, nameof (IsNew));
    }

    public Data(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Data()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RefinementstationRecipeEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RefinementstationRecipeEntry.Data>.NativeClassPtr, data));
    }

    public unsafe bool Hilight
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_Hilight));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_Hilight)) = value;
      }
    }

    public unsafe PrefabGUID EntryId
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_EntryId));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_EntryId)) = value;
      }
    }

    public unsafe DynamicBuffer<RecipeRequirementBuffer> Requirements
    {
      get
      {
        return *(DynamicBuffer<RecipeRequirementBuffer>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_Requirements));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_Requirements), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DynamicBuffer<RecipeRequirementBuffer>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe DynamicBuffer<RecipeOutputBuffer> OutputItems
    {
      get
      {
        return *(DynamicBuffer<RecipeOutputBuffer>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_OutputItems));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_OutputItems), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DynamicBuffer<RecipeOutputBuffer>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe GameDataSystem GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float ResourceMultiplier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_ResourceMultiplier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_ResourceMultiplier)) = value;
      }
    }

    public unsafe bool IsUnlocked
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_IsUnlocked));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_IsUnlocked)) = value;
      }
    }

    public unsafe bool IsNew
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_IsNew));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationRecipeEntry.Data.NativeFieldInfoPtr_IsNew)) = value;
      }
    }
  }
}
