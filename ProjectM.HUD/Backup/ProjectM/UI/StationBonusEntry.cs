// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.StationBonusEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class StationBonusEntry : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusText;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusTitle;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusTextImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_Status;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color_Unlock;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color_Locked;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Requirement;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Bonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_FloorType;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Internal_Static_Void_StationBonusEntry_Data_ControllerType_GridSelectionGroup_2_StationBonusEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1251248, RefRangeEnd = 1251256, XrefRangeStart = 1251210, XrefRangeEnd = 1251248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RefreshData(
      StationBonusEntry entry,
      StationBonusEntry.Data data,
      ControllerType controllerType,
      GridSelectionGroup<StationBonusEntry, StationBonusEntry.Data> parent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StationBonusEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_StationBonusEntry_Data_ControllerType_GridSelectionGroup_2_StationBonusEntry_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StationBonusEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationBonusEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StationBonusEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StationBonusEntry()
    {
      Il2CppClassPointerStore<StationBonusEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (StationBonusEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationBonusEntry>.NativeClassPtr);
      StationBonusEntry.NativeFieldInfoPtr_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry>.NativeClassPtr, nameof (Sprite));
      StationBonusEntry.NativeFieldInfoPtr_BonusText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry>.NativeClassPtr, nameof (BonusText));
      StationBonusEntry.NativeFieldInfoPtr_BonusTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry>.NativeClassPtr, nameof (BonusTitle));
      StationBonusEntry.NativeFieldInfoPtr_BonusImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry>.NativeClassPtr, nameof (BonusImage));
      StationBonusEntry.NativeFieldInfoPtr_BonusTextImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry>.NativeClassPtr, nameof (BonusTextImage));
      StationBonusEntry.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry>.NativeClassPtr, nameof (Status));
      StationBonusEntry.NativeFieldInfoPtr_Color_Unlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry>.NativeClassPtr, nameof (Color_Unlock));
      StationBonusEntry.NativeFieldInfoPtr_Color_Locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry>.NativeClassPtr, nameof (Color_Locked));
      StationBonusEntry.NativeFieldInfoPtr_LKey_Requirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry>.NativeClassPtr, nameof (LKey_Requirement));
      StationBonusEntry.NativeFieldInfoPtr_LKey_Bonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry>.NativeClassPtr, nameof (LKey_Bonus));
      StationBonusEntry.NativeFieldInfoPtr_LKey_FloorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry>.NativeClassPtr, nameof (LKey_FloorType));
      StationBonusEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_StationBonusEntry_Data_ControllerType_GridSelectionGroup_2_StationBonusEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationBonusEntry>.NativeClassPtr, 100666660);
      StationBonusEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationBonusEntry>.NativeClassPtr, 100666661);
    }

    public StationBonusEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image Sprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_Sprite));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_Sprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText BonusText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_BonusText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_BonusText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText BonusTitle
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_BonusTitle));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_BonusTitle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image BonusImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_BonusImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_BonusImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image BonusTextImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_BonusTextImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_BonusTextImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Status
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_Status));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_Status), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color Color_Unlock
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_Color_Unlock));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_Color_Unlock)) = value;
      }
    }

    public unsafe Color Color_Locked
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_Color_Locked));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_Color_Locked)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Requirement
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_LKey_Requirement));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_LKey_Requirement)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Bonus
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_LKey_Bonus));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_LKey_Bonus)) = value;
      }
    }

    public unsafe Nullable_Unboxed<LocalizationKey> LKey_FloorType
    {
      get
      {
        return *(Nullable_Unboxed<LocalizationKey>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_LKey_FloorType));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.NativeFieldInfoPtr_LKey_FloorType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<LocalizationKey>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Unlocked;
      private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Unlocked;
      private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Locked;
      private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Bonus;
      private static readonly System.IntPtr NativeFieldInfoPtr_BonusKey;
      private static readonly System.IntPtr NativeFieldInfoPtr_TextRequirements;
      private static readonly System.IntPtr NativeFieldInfoPtr_TextBonus;
      private static readonly System.IntPtr NativeFieldInfoPtr_FloorType;
      private static readonly System.IntPtr NativeFieldInfoPtr_Value;
      private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Unlocked_ImageText;
      private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Locked_ImageText;
      private static readonly System.IntPtr NativeFieldInfoPtr_BonusType;

      static Data()
      {
        Il2CppClassPointerStore<StationBonusEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationBonusEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationBonusEntry.Data>.NativeClassPtr);
        StationBonusEntry.Data.NativeFieldInfoPtr_Unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry.Data>.NativeClassPtr, nameof (Unlocked));
        StationBonusEntry.Data.NativeFieldInfoPtr_Sprite_Unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry.Data>.NativeClassPtr, nameof (Sprite_Unlocked));
        StationBonusEntry.Data.NativeFieldInfoPtr_Sprite_Locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry.Data>.NativeClassPtr, nameof (Sprite_Locked));
        StationBonusEntry.Data.NativeFieldInfoPtr_Sprite_Bonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry.Data>.NativeClassPtr, nameof (Sprite_Bonus));
        StationBonusEntry.Data.NativeFieldInfoPtr_BonusKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry.Data>.NativeClassPtr, nameof (BonusKey));
        StationBonusEntry.Data.NativeFieldInfoPtr_TextRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry.Data>.NativeClassPtr, nameof (TextRequirements));
        StationBonusEntry.Data.NativeFieldInfoPtr_TextBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry.Data>.NativeClassPtr, nameof (TextBonus));
        StationBonusEntry.Data.NativeFieldInfoPtr_FloorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry.Data>.NativeClassPtr, nameof (FloorType));
        StationBonusEntry.Data.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry.Data>.NativeClassPtr, nameof (Value));
        StationBonusEntry.Data.NativeFieldInfoPtr_Sprite_Unlocked_ImageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry.Data>.NativeClassPtr, nameof (Sprite_Unlocked_ImageText));
        StationBonusEntry.Data.NativeFieldInfoPtr_Sprite_Locked_ImageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry.Data>.NativeClassPtr, nameof (Sprite_Locked_ImageText));
        StationBonusEntry.Data.NativeFieldInfoPtr_BonusType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusEntry.Data>.NativeClassPtr, nameof (BonusType));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StationBonusEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StationBonusEntry.Data>.NativeClassPtr, data));
      }

      public unsafe bool Unlocked
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_Unlocked));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_Unlocked)) = value;
        }
      }

      public unsafe UnityEngine.Sprite Sprite_Unlocked
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_Sprite_Unlocked));
          return pointer == System.IntPtr.Zero ? (UnityEngine.Sprite) null : new UnityEngine.Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_Sprite_Unlocked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UnityEngine.Sprite Sprite_Locked
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_Sprite_Locked));
          return pointer == System.IntPtr.Zero ? (UnityEngine.Sprite) null : new UnityEngine.Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_Sprite_Locked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UnityEngine.Sprite Sprite_Bonus
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_Sprite_Bonus));
          return pointer == System.IntPtr.Zero ? (UnityEngine.Sprite) null : new UnityEngine.Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_Sprite_Bonus), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe LocalizationKey BonusKey
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_BonusKey));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_BonusKey)) = value;
        }
      }

      public unsafe LocalizationKey TextRequirements
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_TextRequirements));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_TextRequirements)) = value;
        }
      }

      public unsafe LocalizationKey TextBonus
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_TextBonus));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_TextBonus)) = value;
        }
      }

      public unsafe Nullable_Unboxed<LocalizationKey> FloorType
      {
        get
        {
          return *(Nullable_Unboxed<LocalizationKey>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_FloorType));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_FloorType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<LocalizationKey>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe float Value
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_Value));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_Value)) = value;
        }
      }

      public unsafe UnityEngine.Sprite Sprite_Unlocked_ImageText
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_Sprite_Unlocked_ImageText));
          return pointer == System.IntPtr.Zero ? (UnityEngine.Sprite) null : new UnityEngine.Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_Sprite_Unlocked_ImageText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UnityEngine.Sprite Sprite_Locked_ImageText
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_Sprite_Locked_ImageText));
          return pointer == System.IntPtr.Zero ? (UnityEngine.Sprite) null : new UnityEngine.Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_Sprite_Locked_ImageText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe StationBonusType BonusType
      {
        get
        {
          return *(StationBonusType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_BonusType));
        }
        [param: In] set
        {
          *(StationBonusType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationBonusEntry.Data.NativeFieldInfoPtr_BonusType)) = value;
        }
      }
    }
  }
}
