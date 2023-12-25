// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SpellbookMenu_AbilityEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class SpellbookMenu_AbilityEntry : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EmptyBackgroundSprite_Basic;
    private static readonly System.IntPtr NativeFieldInfoPtr_EmptyBackgroundSprite_Ultimate;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedBackground;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedBackground_SelectedColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedBackground_NormalColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_JewelIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewUnlockHighlightImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityType;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityId;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_byref_Data_Nullable_Unboxed_1_Single_InputSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1263257, RefRangeEnd = 1263259, XrefRangeStart = 1263237, XrefRangeEnd = 1263257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(
      ref SpellbookMenu_AbilityEntry.Data data,
      Nullable_Unboxed<float> currentMana,
      InputSystem inputSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &currentMana;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenu_AbilityEntry.NativeMethodInfoPtr_SetData_Public_Void_byref_Data_Nullable_Unboxed_1_Single_InputSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellbookMenu_AbilityEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenu_AbilityEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpellbookMenu_AbilityEntry()
    {
      Il2CppClassPointerStore<SpellbookMenu_AbilityEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (SpellbookMenu_AbilityEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry>.NativeClassPtr);
      SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_EmptyBackgroundSprite_Basic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry>.NativeClassPtr, nameof (EmptyBackgroundSprite_Basic));
      SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_EmptyBackgroundSprite_Ultimate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry>.NativeClassPtr, nameof (EmptyBackgroundSprite_Ultimate));
      SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_AbilityEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry>.NativeClassPtr, nameof (AbilityEntry));
      SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_SelectedBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry>.NativeClassPtr, nameof (SelectedBackground));
      SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_SelectedBackground_SelectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry>.NativeClassPtr, nameof (SelectedBackground_SelectedColor));
      SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_SelectedBackground_NormalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry>.NativeClassPtr, nameof (SelectedBackground_NormalColor));
      SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_JewelIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry>.NativeClassPtr, nameof (JewelIcon));
      SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_NewUnlockHighlightImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry>.NativeClassPtr, nameof (NewUnlockHighlightImage));
      SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry>.NativeClassPtr, nameof (Button));
      SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_IsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry>.NativeClassPtr, nameof (IsUnlocked));
      SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_AbilityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry>.NativeClassPtr, nameof (AbilityType));
      SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_AbilityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry>.NativeClassPtr, nameof (AbilityId));
      SpellbookMenu_AbilityEntry.NativeMethodInfoPtr_SetData_Public_Void_byref_Data_Nullable_Unboxed_1_Single_InputSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry>.NativeClassPtr, 100667438);
      SpellbookMenu_AbilityEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry>.NativeClassPtr, 100667439);
    }

    public SpellbookMenu_AbilityEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Sprite EmptyBackgroundSprite_Basic
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_EmptyBackgroundSprite_Basic));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_EmptyBackgroundSprite_Basic), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite EmptyBackgroundSprite_Ultimate
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_EmptyBackgroundSprite_Ultimate));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_EmptyBackgroundSprite_Ultimate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AbilityBarEntry AbilityEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_AbilityEntry));
        return pointer == System.IntPtr.Zero ? (AbilityBarEntry) null : new AbilityBarEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_AbilityEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image SelectedBackground
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_SelectedBackground));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_SelectedBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color SelectedBackground_SelectedColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_SelectedBackground_SelectedColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_SelectedBackground_SelectedColor)) = value;
      }
    }

    public unsafe Color SelectedBackground_NormalColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_SelectedBackground_NormalColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_SelectedBackground_NormalColor)) = value;
      }
    }

    public unsafe Image JewelIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_JewelIcon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_JewelIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image NewUnlockHighlightImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_NewUnlockHighlightImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_NewUnlockHighlightImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_Button));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool IsUnlocked
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_IsUnlocked));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_IsUnlocked)) = value;
      }
    }

    public unsafe VBloodAbilityType AbilityType
    {
      get
      {
        return *(VBloodAbilityType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_AbilityType));
      }
      [param: In] set
      {
        *(VBloodAbilityType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_AbilityType)) = value;
      }
    }

    public unsafe PrefabGUID AbilityId
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_AbilityId));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.NativeFieldInfoPtr_AbilityId)) = value;
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_IsSelected;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityData;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsUnlocked;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsNewUnlockNotSeen;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_CustomIconColor;
      private static readonly System.IntPtr NativeFieldInfoPtr_JewelSprite;

      static Data()
      {
        Il2CppClassPointerStore<SpellbookMenu_AbilityEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry.Data>.NativeClassPtr);
        SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_IsSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry.Data>.NativeClassPtr, nameof (IsSelected));
        SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_AbilityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry.Data>.NativeClassPtr, nameof (AbilityData));
        SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_IsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry.Data>.NativeClassPtr, nameof (IsUnlocked));
        SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_IsNewUnlockNotSeen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry.Data>.NativeClassPtr, nameof (IsNewUnlockNotSeen));
        SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_AbilityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry.Data>.NativeClassPtr, nameof (AbilityType));
        SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_CustomIconColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry.Data>.NativeClassPtr, nameof (CustomIconColor));
        SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_JewelSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry.Data>.NativeClassPtr, nameof (JewelSprite));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellbookMenu_AbilityEntry.Data>.NativeClassPtr, data));
      }

      public unsafe bool IsSelected
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_IsSelected));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_IsSelected)) = value;
        }
      }

      public AbilityBarEntry.Data AbilityData
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_AbilityData);
          return new AbilityBarEntry.Data(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_AbilityData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe bool IsUnlocked
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_IsUnlocked));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_IsUnlocked)) = value;
        }
      }

      public unsafe bool IsNewUnlockNotSeen
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_IsNewUnlockNotSeen));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_IsNewUnlockNotSeen)) = value;
        }
      }

      public unsafe VBloodAbilityType AbilityType
      {
        get
        {
          return *(VBloodAbilityType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_AbilityType));
        }
        [param: In] set
        {
          *(VBloodAbilityType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_AbilityType)) = value;
        }
      }

      public unsafe Nullable_Unboxed<Color> CustomIconColor
      {
        get
        {
          return *(Nullable_Unboxed<Color>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_CustomIconColor));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_CustomIconColor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<Color>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Sprite JewelSprite
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_JewelSprite));
          return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_AbilityEntry.Data.NativeFieldInfoPtr_JewelSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
