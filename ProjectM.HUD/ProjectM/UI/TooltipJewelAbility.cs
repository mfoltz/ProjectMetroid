// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TooltipJewelAbility
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class TooltipJewelAbility : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RegularAbilityEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_TravelAbilityEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_UltimateAbilityEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityName;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_Nullable_1_SpellModInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAbility_Private_Void_AbilityBarEntry_Nullable_1_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool IsHovered
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1252581, RefRangeEnd = 1252582, XrefRangeStart = 1252581, XrefRangeEnd = 1252581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TooltipJewelAbility.NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1252622, RefRangeEnd = 1252628, XrefRangeStart = 1252582, XrefRangeEnd = 1252622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(Il2CppSystem.Nullable<SpellModInfo> info)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) info));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipJewelAbility.NativeMethodInfoPtr_SetData_Public_Void_Nullable_1_SpellModInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252628, XrefRangeEnd = 1252636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAbility(AbilityBarEntry entry, Il2CppSystem.Nullable<AbilityBarEntry.Data> data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipJewelAbility.NativeMethodInfoPtr_SetAbility_Private_Void_AbilityBarEntry_Nullable_1_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TooltipJewelAbility()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipJewelAbility>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipJewelAbility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TooltipJewelAbility()
    {
      Il2CppClassPointerStore<TooltipJewelAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TooltipJewelAbility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipJewelAbility>.NativeClassPtr);
      TooltipJewelAbility.NativeFieldInfoPtr_RegularAbilityEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipJewelAbility>.NativeClassPtr, nameof (RegularAbilityEntry));
      TooltipJewelAbility.NativeFieldInfoPtr_TravelAbilityEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipJewelAbility>.NativeClassPtr, nameof (TravelAbilityEntry));
      TooltipJewelAbility.NativeFieldInfoPtr_UltimateAbilityEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipJewelAbility>.NativeClassPtr, nameof (UltimateAbilityEntry));
      TooltipJewelAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipJewelAbility>.NativeClassPtr, nameof (AbilityName));
      TooltipJewelAbility.NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipJewelAbility>.NativeClassPtr, 100666691);
      TooltipJewelAbility.NativeMethodInfoPtr_SetData_Public_Void_Nullable_1_SpellModInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipJewelAbility>.NativeClassPtr, 100666692);
      TooltipJewelAbility.NativeMethodInfoPtr_SetAbility_Private_Void_AbilityBarEntry_Nullable_1_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipJewelAbility>.NativeClassPtr, 100666693);
      TooltipJewelAbility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipJewelAbility>.NativeClassPtr, 100666694);
    }

    public TooltipJewelAbility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AbilityBarEntry RegularAbilityEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipJewelAbility.NativeFieldInfoPtr_RegularAbilityEntry));
        return pointer == System.IntPtr.Zero ? (AbilityBarEntry) null : new AbilityBarEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipJewelAbility.NativeFieldInfoPtr_RegularAbilityEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AbilityBarEntry TravelAbilityEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipJewelAbility.NativeFieldInfoPtr_TravelAbilityEntry));
        return pointer == System.IntPtr.Zero ? (AbilityBarEntry) null : new AbilityBarEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipJewelAbility.NativeFieldInfoPtr_TravelAbilityEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AbilityBarEntry UltimateAbilityEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipJewelAbility.NativeFieldInfoPtr_UltimateAbilityEntry));
        return pointer == System.IntPtr.Zero ? (AbilityBarEntry) null : new AbilityBarEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipJewelAbility.NativeFieldInfoPtr_UltimateAbilityEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText AbilityName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipJewelAbility.NativeFieldInfoPtr_AbilityName));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipJewelAbility.NativeFieldInfoPtr_AbilityName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_RegularAbilityData;
      private static readonly System.IntPtr NativeFieldInfoPtr_TravelAbilityData;
      private static readonly System.IntPtr NativeFieldInfoPtr_UltimateAbilityData;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityNameText;

      static Data()
      {
        Il2CppClassPointerStore<TooltipJewelAbility.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TooltipJewelAbility>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipJewelAbility.Data>.NativeClassPtr);
        TooltipJewelAbility.Data.NativeFieldInfoPtr_RegularAbilityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipJewelAbility.Data>.NativeClassPtr, nameof (RegularAbilityData));
        TooltipJewelAbility.Data.NativeFieldInfoPtr_TravelAbilityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipJewelAbility.Data>.NativeClassPtr, nameof (TravelAbilityData));
        TooltipJewelAbility.Data.NativeFieldInfoPtr_UltimateAbilityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipJewelAbility.Data>.NativeClassPtr, nameof (UltimateAbilityData));
        TooltipJewelAbility.Data.NativeFieldInfoPtr_AbilityNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipJewelAbility.Data>.NativeClassPtr, nameof (AbilityNameText));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TooltipJewelAbility.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TooltipJewelAbility.Data>.NativeClassPtr, data));
      }

      public Il2CppSystem.Nullable<AbilityBarEntry.Data> RegularAbilityData
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipJewelAbility.Data.NativeFieldInfoPtr_RegularAbilityData);
          return new Il2CppSystem.Nullable<AbilityBarEntry.Data>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<AbilityBarEntry.Data>>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipJewelAbility.Data.NativeFieldInfoPtr_RegularAbilityData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<AbilityBarEntry.Data>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public Il2CppSystem.Nullable<AbilityBarEntry.Data> TravelAbilityData
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipJewelAbility.Data.NativeFieldInfoPtr_TravelAbilityData);
          return new Il2CppSystem.Nullable<AbilityBarEntry.Data>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<AbilityBarEntry.Data>>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipJewelAbility.Data.NativeFieldInfoPtr_TravelAbilityData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<AbilityBarEntry.Data>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public Il2CppSystem.Nullable<AbilityBarEntry.Data> UltimateAbilityData
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipJewelAbility.Data.NativeFieldInfoPtr_UltimateAbilityData);
          return new Il2CppSystem.Nullable<AbilityBarEntry.Data>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<AbilityBarEntry.Data>>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipJewelAbility.Data.NativeFieldInfoPtr_UltimateAbilityData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<AbilityBarEntry.Data>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe LocalizationKey AbilityNameText
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipJewelAbility.Data.NativeFieldInfoPtr_AbilityNameText));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipJewelAbility.Data.NativeFieldInfoPtr_AbilityNameText)) = value;
        }
      }
    }
  }
}
