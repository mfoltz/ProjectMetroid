// Decompiled with JetBrains decompiler
// Type: BloodAltarHuntEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class BloodAltarHuntEntry : GridSelectionEntry
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Background;
  private static readonly System.IntPtr NativeFieldInfoPtr_Selected;
  private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
  private static readonly System.IntPtr NativeFieldInfoPtr_HiddenQuestionMark;
  private static readonly System.IntPtr NativeFieldInfoPtr_Name;
  private static readonly System.IntPtr NativeFieldInfoPtr_Level;
  private static readonly System.IntPtr NativeFieldInfoPtr_Parent_Known;
  private static readonly System.IntPtr NativeFieldInfoPtr_Parent_Unknown;
  private static readonly System.IntPtr NativeFieldInfoPtr_Highlighted;
  private static readonly System.IntPtr NativeFieldInfoPtr_Tracking;
  private static readonly System.IntPtr NativeFieldInfoPtr_Claimable;
  private static readonly System.IntPtr NativeFieldInfoPtr_Hunted;
  private static readonly System.IntPtr NativeFieldInfoPtr_EntryId;
  private static readonly System.IntPtr NativeFieldInfoPtr_UpdatedData;
  private static readonly System.IntPtr NativeFieldInfoPtr_HiddenVBloodHeader;
  private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Normal;
  private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Tracked;
  private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Shareable;
  private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Claimable;
  private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Unlocked;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Internal_Static_Void_BloodAltarHuntEntry_Data_GameDataSystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBackgroundSprite_Private_Static_Sprite_BloodAltarHuntEntry_HuntStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShouldHighlight_Private_Static_Boolean_BloodAltarHuntEntry_HuntStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1205374, RefRangeEnd = 1205375, XrefRangeStart = 1205345, XrefRangeEnd = 1205374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RefreshData(
    BloodAltarHuntEntry entry,
    BloodAltarHuntEntry.Data data,
    GameDataSystem gameDataSystem)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BloodAltarHuntEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_BloodAltarHuntEntry_Data_GameDataSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public static unsafe Sprite GetBackgroundSprite(BloodAltarHuntEntry entry, HuntStatus huntStatus)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &huntStatus;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BloodAltarHuntEntry.NativeMethodInfoPtr_GetBackgroundSprite_Private_Static_Sprite_BloodAltarHuntEntry_HuntStatus_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
  }

  [CallerCount(0)]
  public static unsafe bool ShouldHighlight(BloodAltarHuntEntry entry, HuntStatus huntStatus)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &huntStatus;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BloodAltarHuntEntry.NativeMethodInfoPtr_ShouldHighlight_Private_Static_Boolean_BloodAltarHuntEntry_HuntStatus_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BloodAltarHuntEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BloodAltarHuntEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BloodAltarHuntEntry()
  {
    Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (BloodAltarHuntEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr);
    BloodAltarHuntEntry.NativeFieldInfoPtr_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (Background));
    BloodAltarHuntEntry.NativeFieldInfoPtr_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (Selected));
    BloodAltarHuntEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (Icon));
    BloodAltarHuntEntry.NativeFieldInfoPtr_HiddenQuestionMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (HiddenQuestionMark));
    BloodAltarHuntEntry.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (Name));
    BloodAltarHuntEntry.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (Level));
    BloodAltarHuntEntry.NativeFieldInfoPtr_Parent_Known = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (Parent_Known));
    BloodAltarHuntEntry.NativeFieldInfoPtr_Parent_Unknown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (Parent_Unknown));
    BloodAltarHuntEntry.NativeFieldInfoPtr_Highlighted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (Highlighted));
    BloodAltarHuntEntry.NativeFieldInfoPtr_Tracking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (Tracking));
    BloodAltarHuntEntry.NativeFieldInfoPtr_Claimable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (Claimable));
    BloodAltarHuntEntry.NativeFieldInfoPtr_Hunted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (Hunted));
    BloodAltarHuntEntry.NativeFieldInfoPtr_EntryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (EntryId));
    BloodAltarHuntEntry.NativeFieldInfoPtr_UpdatedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (UpdatedData));
    BloodAltarHuntEntry.NativeFieldInfoPtr_HiddenVBloodHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (HiddenVBloodHeader));
    BloodAltarHuntEntry.NativeFieldInfoPtr_Sprite_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (Sprite_Normal));
    BloodAltarHuntEntry.NativeFieldInfoPtr_Sprite_Tracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (Sprite_Tracked));
    BloodAltarHuntEntry.NativeFieldInfoPtr_Sprite_Shareable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (Sprite_Shareable));
    BloodAltarHuntEntry.NativeFieldInfoPtr_Sprite_Claimable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (Sprite_Claimable));
    BloodAltarHuntEntry.NativeFieldInfoPtr_Sprite_Unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (Sprite_Unlocked));
    BloodAltarHuntEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_BloodAltarHuntEntry_Data_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, 100663306);
    BloodAltarHuntEntry.NativeMethodInfoPtr_GetBackgroundSprite_Private_Static_Sprite_BloodAltarHuntEntry_HuntStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, 100663307);
    BloodAltarHuntEntry.NativeMethodInfoPtr_ShouldHighlight_Private_Static_Boolean_BloodAltarHuntEntry_HuntStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, 100663308);
    BloodAltarHuntEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, 100663309);
  }

  public BloodAltarHuntEntry(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Image Background
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Background));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Background), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image Selected
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Selected));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Selected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image Icon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Icon));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform HiddenQuestionMark
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_HiddenQuestionMark));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_HiddenQuestionMark), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText Name
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Name));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText Level
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Level));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Level), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject Parent_Known
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Parent_Known));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Parent_Known), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject Parent_Unknown
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Parent_Unknown));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Parent_Unknown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject Highlighted
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Highlighted));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Highlighted), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject Tracking
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Tracking));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Tracking), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject Claimable
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Claimable));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Claimable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject Hunted
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Hunted));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Hunted), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PrefabGUID EntryId
  {
    get
    {
      return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_EntryId));
    }
    [param: In] set
    {
      *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_EntryId)) = value;
    }
  }

  public unsafe BloodAltarHuntEntry.Data UpdatedData
  {
    get
    {
      return *(BloodAltarHuntEntry.Data*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_UpdatedData));
    }
    [param: In] set
    {
      *(BloodAltarHuntEntry.Data*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_UpdatedData)) = value;
    }
  }

  public unsafe LocalizationKey HiddenVBloodHeader
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_HiddenVBloodHeader));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_HiddenVBloodHeader)) = value;
    }
  }

  public unsafe Sprite Sprite_Normal
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Sprite_Normal));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Sprite_Normal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite Sprite_Tracked
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Sprite_Tracked));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Sprite_Tracked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite Sprite_Shareable
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Sprite_Shareable));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Sprite_Shareable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite Sprite_Claimable
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Sprite_Claimable));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Sprite_Claimable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite Sprite_Unlocked
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Sprite_Unlocked));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarHuntEntry.NativeFieldInfoPtr_Sprite_Unlocked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Data
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EntryId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Level;
    private static readonly System.IntPtr NativeFieldInfoPtr_HuntStatus;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsSelected;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsUnknown;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsTracked;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsHidden;
    [FieldOffset(0)]
    public PrefabGUID EntryId;
    [FieldOffset(4)]
    public LocalizationKey Name;
    [FieldOffset(20)]
    public int Level;
    [FieldOffset(24)]
    public HuntStatus HuntStatus;
    [FieldOffset(28)]
    public bool IsSelected;
    [FieldOffset(29)]
    public bool IsUnknown;
    [FieldOffset(30)]
    public bool IsTracked;
    [FieldOffset(31)]
    public bool IsHidden;

    static Data()
    {
      Il2CppClassPointerStore<BloodAltarHuntEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloodAltarHuntEntry>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodAltarHuntEntry.Data>.NativeClassPtr);
      BloodAltarHuntEntry.Data.NativeFieldInfoPtr_EntryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry.Data>.NativeClassPtr, nameof (EntryId));
      BloodAltarHuntEntry.Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry.Data>.NativeClassPtr, nameof (Name));
      BloodAltarHuntEntry.Data.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry.Data>.NativeClassPtr, nameof (Level));
      BloodAltarHuntEntry.Data.NativeFieldInfoPtr_HuntStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry.Data>.NativeClassPtr, nameof (HuntStatus));
      BloodAltarHuntEntry.Data.NativeFieldInfoPtr_IsSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry.Data>.NativeClassPtr, nameof (IsSelected));
      BloodAltarHuntEntry.Data.NativeFieldInfoPtr_IsUnknown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry.Data>.NativeClassPtr, nameof (IsUnknown));
      BloodAltarHuntEntry.Data.NativeFieldInfoPtr_IsTracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry.Data>.NativeClassPtr, nameof (IsTracked));
      BloodAltarHuntEntry.Data.NativeFieldInfoPtr_IsHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarHuntEntry.Data>.NativeClassPtr, nameof (IsHidden));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodAltarHuntEntry.Data>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
