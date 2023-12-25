// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.PowerSelectionMenu_PowerEntry
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
  public class PowerSelectionMenu_PowerEntry : 
    GenericSelectionEntry<PowerSelectionMenu_PowerEntry.Data>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedBackground;
    private static readonly System.IntPtr NativeFieldInfoPtr_Button;
    private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Internal_Virtual_Void_byref_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262278, XrefRangeEnd = 1262286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Refresh([In] ref PowerSelectionMenu_PowerEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PowerSelectionMenu_PowerEntry.NativeMethodInfoPtr_Refresh_Internal_Virtual_Void_byref_Data_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262286, XrefRangeEnd = 1262289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PowerSelectionMenu_PowerEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerSelectionMenu_PowerEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PowerSelectionMenu_PowerEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PowerSelectionMenu_PowerEntry()
    {
      Il2CppClassPointerStore<PowerSelectionMenu_PowerEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (PowerSelectionMenu_PowerEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerSelectionMenu_PowerEntry>.NativeClassPtr);
      PowerSelectionMenu_PowerEntry.NativeFieldInfoPtr_AbilityEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu_PowerEntry>.NativeClassPtr, nameof (AbilityEntry));
      PowerSelectionMenu_PowerEntry.NativeFieldInfoPtr_SelectedBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu_PowerEntry>.NativeClassPtr, nameof (SelectedBackground));
      PowerSelectionMenu_PowerEntry.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu_PowerEntry>.NativeClassPtr, nameof (Button));
      PowerSelectionMenu_PowerEntry.NativeMethodInfoPtr_Refresh_Internal_Virtual_Void_byref_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenu_PowerEntry>.NativeClassPtr, 100667380);
      PowerSelectionMenu_PowerEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerSelectionMenu_PowerEntry>.NativeClassPtr, 100667381);
    }

    public PowerSelectionMenu_PowerEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AbilityBarEntry AbilityEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu_PowerEntry.NativeFieldInfoPtr_AbilityEntry));
        return pointer == System.IntPtr.Zero ? (AbilityBarEntry) null : new AbilityBarEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu_PowerEntry.NativeFieldInfoPtr_AbilityEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image SelectedBackground
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu_PowerEntry.NativeFieldInfoPtr_SelectedBackground));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu_PowerEntry.NativeFieldInfoPtr_SelectedBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu_PowerEntry.NativeFieldInfoPtr_Button));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu_PowerEntry.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityData;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsSelected;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsUnlocked;
      private static readonly System.IntPtr NativeFieldInfoPtr_HeaderString;
      private static readonly System.IntPtr NativeFieldInfoPtr_CustomIconColor;
      private static readonly System.IntPtr NativeFieldInfoPtr_InputSystem;

      static Data()
      {
        Il2CppClassPointerStore<PowerSelectionMenu_PowerEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PowerSelectionMenu_PowerEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerSelectionMenu_PowerEntry.Data>.NativeClassPtr);
        PowerSelectionMenu_PowerEntry.Data.NativeFieldInfoPtr_AbilityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu_PowerEntry.Data>.NativeClassPtr, nameof (AbilityData));
        PowerSelectionMenu_PowerEntry.Data.NativeFieldInfoPtr_IsSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu_PowerEntry.Data>.NativeClassPtr, nameof (IsSelected));
        PowerSelectionMenu_PowerEntry.Data.NativeFieldInfoPtr_IsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu_PowerEntry.Data>.NativeClassPtr, nameof (IsUnlocked));
        PowerSelectionMenu_PowerEntry.Data.NativeFieldInfoPtr_HeaderString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu_PowerEntry.Data>.NativeClassPtr, nameof (HeaderString));
        PowerSelectionMenu_PowerEntry.Data.NativeFieldInfoPtr_CustomIconColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu_PowerEntry.Data>.NativeClassPtr, nameof (CustomIconColor));
        PowerSelectionMenu_PowerEntry.Data.NativeFieldInfoPtr_InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerSelectionMenu_PowerEntry.Data>.NativeClassPtr, nameof (InputSystem));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PowerSelectionMenu_PowerEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PowerSelectionMenu_PowerEntry.Data>.NativeClassPtr, data));
      }

      public AbilityBarEntry.Data AbilityData
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu_PowerEntry.Data.NativeFieldInfoPtr_AbilityData);
          return new AbilityBarEntry.Data(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu_PowerEntry.Data.NativeFieldInfoPtr_AbilityData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe bool IsSelected
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu_PowerEntry.Data.NativeFieldInfoPtr_IsSelected));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu_PowerEntry.Data.NativeFieldInfoPtr_IsSelected)) = value;
        }
      }

      public unsafe bool IsUnlocked
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu_PowerEntry.Data.NativeFieldInfoPtr_IsUnlocked));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu_PowerEntry.Data.NativeFieldInfoPtr_IsUnlocked)) = value;
        }
      }

      public unsafe LocalizationKey HeaderString
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu_PowerEntry.Data.NativeFieldInfoPtr_HeaderString));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu_PowerEntry.Data.NativeFieldInfoPtr_HeaderString)) = value;
        }
      }

      public unsafe Nullable_Unboxed<Color> CustomIconColor
      {
        get
        {
          return *(Nullable_Unboxed<Color>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu_PowerEntry.Data.NativeFieldInfoPtr_CustomIconColor));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu_PowerEntry.Data.NativeFieldInfoPtr_CustomIconColor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<Color>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe InputSystem InputSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu_PowerEntry.Data.NativeFieldInfoPtr_InputSystem));
          return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PowerSelectionMenu_PowerEntry.Data.NativeFieldInfoPtr_InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
