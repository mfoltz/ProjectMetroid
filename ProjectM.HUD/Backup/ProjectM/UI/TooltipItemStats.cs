// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TooltipItemStats
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class TooltipItemStats : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipStatsEntryList;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemLevel_Gear;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1252558, RefRangeEnd = 1252559, XrefRangeStart = 1252464, XrefRangeEnd = 1252558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(TooltipItemStats.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipItemStats.NativeMethodInfoPtr_SetData_Public_Void_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TooltipItemStats()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipItemStats>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipItemStats.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TooltipItemStats()
    {
      Il2CppClassPointerStore<TooltipItemStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TooltipItemStats));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipItemStats>.NativeClassPtr);
      TooltipItemStats.NativeFieldInfoPtr_ItemLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipItemStats>.NativeClassPtr, nameof (ItemLevel));
      TooltipItemStats.NativeFieldInfoPtr_TooltipStatsEntryList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipItemStats>.NativeClassPtr, nameof (TooltipStatsEntryList));
      TooltipItemStats.NativeFieldInfoPtr_ItemLevel_Gear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipItemStats>.NativeClassPtr, nameof (ItemLevel_Gear));
      TooltipItemStats.NativeMethodInfoPtr_SetData_Public_Void_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipItemStats>.NativeClassPtr, 100666687);
      TooltipItemStats.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipItemStats>.NativeClassPtr, 100666688);
    }

    public TooltipItemStats(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText ItemLevel
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemStats.NativeFieldInfoPtr_ItemLevel));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemStats.NativeFieldInfoPtr_ItemLevel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<TooltipSetItemEntry> TooltipStatsEntryList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemStats.NativeFieldInfoPtr_TooltipStatsEntryList));
        return pointer == System.IntPtr.Zero ? (List<TooltipSetItemEntry>) null : new List<TooltipSetItemEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemStats.NativeFieldInfoPtr_TooltipStatsEntryList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey ItemLevel_Gear
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemStats.NativeFieldInfoPtr_ItemLevel_Gear));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemStats.NativeFieldInfoPtr_ItemLevel_Gear)) = value;
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ItemLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_Stats;

      static Data()
      {
        Il2CppClassPointerStore<TooltipItemStats.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TooltipItemStats>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipItemStats.Data>.NativeClassPtr);
        TooltipItemStats.Data.NativeFieldInfoPtr_ItemLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipItemStats.Data>.NativeClassPtr, nameof (ItemLevel));
        TooltipItemStats.Data.NativeFieldInfoPtr_Stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipItemStats.Data>.NativeClassPtr, nameof (Stats));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TooltipItemStats.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TooltipItemStats.Data>.NativeClassPtr, data));
      }

      public unsafe Nullable_Unboxed<ProjectM.UI.ItemLevel> ItemLevel
      {
        get
        {
          return *(Nullable_Unboxed<ProjectM.UI.ItemLevel>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemStats.Data.NativeFieldInfoPtr_ItemLevel));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemStats.Data.NativeFieldInfoPtr_ItemLevel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<ProjectM.UI.ItemLevel>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public Il2CppSystem.Nullable<StatsInfo> Stats
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemStats.Data.NativeFieldInfoPtr_Stats);
          return new Il2CppSystem.Nullable<StatsInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<StatsInfo>>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipItemStats.Data.NativeFieldInfoPtr_Stats), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<StatsInfo>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }
}
