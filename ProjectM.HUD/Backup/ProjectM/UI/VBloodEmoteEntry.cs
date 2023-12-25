// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.VBloodEmoteEntry
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
  public class VBloodEmoteEntry : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UndiscoveredEmoteKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_EmoteKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedBackground;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_KeybindImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_KeybindBackground;
    private static readonly System.IntPtr NativeFieldInfoPtr_KeybindText;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_byref_Data_InputSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289352, XrefRangeEnd = 1289400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(ref VBloodEmoteEntry.Data data, InputSystem inputSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodEmoteEntry.NativeMethodInfoPtr_SetData_Public_Void_byref_Data_InputSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VBloodEmoteEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodEmoteEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodEmoteEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VBloodEmoteEntry()
    {
      Il2CppClassPointerStore<VBloodEmoteEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (VBloodEmoteEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodEmoteEntry>.NativeClassPtr);
      VBloodEmoteEntry.NativeFieldInfoPtr_UndiscoveredEmoteKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodEmoteEntry>.NativeClassPtr, nameof (UndiscoveredEmoteKey));
      VBloodEmoteEntry.NativeFieldInfoPtr_EmoteKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodEmoteEntry>.NativeClassPtr, nameof (EmoteKey));
      VBloodEmoteEntry.NativeFieldInfoPtr_AbilityEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodEmoteEntry>.NativeClassPtr, nameof (AbilityEntry));
      VBloodEmoteEntry.NativeFieldInfoPtr_SelectedBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodEmoteEntry>.NativeClassPtr, nameof (SelectedBackground));
      VBloodEmoteEntry.NativeFieldInfoPtr_IsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodEmoteEntry>.NativeClassPtr, nameof (IsUnlocked));
      VBloodEmoteEntry.NativeFieldInfoPtr_KeybindImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodEmoteEntry>.NativeClassPtr, nameof (KeybindImage));
      VBloodEmoteEntry.NativeFieldInfoPtr_KeybindBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodEmoteEntry>.NativeClassPtr, nameof (KeybindBackground));
      VBloodEmoteEntry.NativeFieldInfoPtr_KeybindText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodEmoteEntry>.NativeClassPtr, nameof (KeybindText));
      VBloodEmoteEntry.NativeMethodInfoPtr_SetData_Public_Void_byref_Data_InputSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodEmoteEntry>.NativeClassPtr, 100669760);
      VBloodEmoteEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodEmoteEntry>.NativeClassPtr, 100669761);
    }

    public VBloodEmoteEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey UndiscoveredEmoteKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.NativeFieldInfoPtr_UndiscoveredEmoteKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.NativeFieldInfoPtr_UndiscoveredEmoteKey)) = value;
      }
    }

    public unsafe LocalizationKey EmoteKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.NativeFieldInfoPtr_EmoteKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.NativeFieldInfoPtr_EmoteKey)) = value;
      }
    }

    public unsafe AbilityBarEntry AbilityEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.NativeFieldInfoPtr_AbilityEntry));
        return pointer == System.IntPtr.Zero ? (AbilityBarEntry) null : new AbilityBarEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.NativeFieldInfoPtr_AbilityEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image SelectedBackground
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.NativeFieldInfoPtr_SelectedBackground));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.NativeFieldInfoPtr_SelectedBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool IsUnlocked
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.NativeFieldInfoPtr_IsUnlocked));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.NativeFieldInfoPtr_IsUnlocked)) = value;
      }
    }

    public unsafe Image KeybindImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.NativeFieldInfoPtr_KeybindImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.NativeFieldInfoPtr_KeybindImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image KeybindBackground
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.NativeFieldInfoPtr_KeybindBackground));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.NativeFieldInfoPtr_KeybindBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText KeybindText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.NativeFieldInfoPtr_KeybindText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.NativeFieldInfoPtr_KeybindText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityData;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsSelected;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsUnlocked;
      private static readonly System.IntPtr NativeFieldInfoPtr_HeaderString;
      private static readonly System.IntPtr NativeFieldInfoPtr_KeyBind;
      private static readonly System.IntPtr NativeFieldInfoPtr_Modifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_CustomIconColor;

      static Data()
      {
        Il2CppClassPointerStore<VBloodEmoteEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VBloodEmoteEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodEmoteEntry.Data>.NativeClassPtr);
        VBloodEmoteEntry.Data.NativeFieldInfoPtr_AbilityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodEmoteEntry.Data>.NativeClassPtr, nameof (AbilityData));
        VBloodEmoteEntry.Data.NativeFieldInfoPtr_IsSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodEmoteEntry.Data>.NativeClassPtr, nameof (IsSelected));
        VBloodEmoteEntry.Data.NativeFieldInfoPtr_IsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodEmoteEntry.Data>.NativeClassPtr, nameof (IsUnlocked));
        VBloodEmoteEntry.Data.NativeFieldInfoPtr_HeaderString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodEmoteEntry.Data>.NativeClassPtr, nameof (HeaderString));
        VBloodEmoteEntry.Data.NativeFieldInfoPtr_KeyBind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodEmoteEntry.Data>.NativeClassPtr, nameof (KeyBind));
        VBloodEmoteEntry.Data.NativeFieldInfoPtr_Modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodEmoteEntry.Data>.NativeClassPtr, nameof (Modifier));
        VBloodEmoteEntry.Data.NativeFieldInfoPtr_CustomIconColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodEmoteEntry.Data>.NativeClassPtr, nameof (CustomIconColor));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VBloodEmoteEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VBloodEmoteEntry.Data>.NativeClassPtr, data));
      }

      public AbilityBarEntry.Data AbilityData
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.Data.NativeFieldInfoPtr_AbilityData);
          return new AbilityBarEntry.Data(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.Data.NativeFieldInfoPtr_AbilityData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe bool IsSelected
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.Data.NativeFieldInfoPtr_IsSelected));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.Data.NativeFieldInfoPtr_IsSelected)) = value;
        }
      }

      public unsafe bool IsUnlocked
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.Data.NativeFieldInfoPtr_IsUnlocked));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.Data.NativeFieldInfoPtr_IsUnlocked)) = value;
        }
      }

      public unsafe LocalizationKey HeaderString
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.Data.NativeFieldInfoPtr_HeaderString));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.Data.NativeFieldInfoPtr_HeaderString)) = value;
        }
      }

      public unsafe InputFlag KeyBind
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.Data.NativeFieldInfoPtr_KeyBind));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.Data.NativeFieldInfoPtr_KeyBind)) = value;
        }
      }

      public unsafe InputFlag Modifier
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.Data.NativeFieldInfoPtr_Modifier));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.Data.NativeFieldInfoPtr_Modifier)) = value;
        }
      }

      public unsafe Nullable_Unboxed<Color> CustomIconColor
      {
        get
        {
          return *(Nullable_Unboxed<Color>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.Data.NativeFieldInfoPtr_CustomIconColor));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodEmoteEntry.Data.NativeFieldInfoPtr_CustomIconColor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<Color>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }
}
