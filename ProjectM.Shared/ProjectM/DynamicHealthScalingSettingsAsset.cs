// Decompiled with JetBrains decompiler
// Type: ProjectM.DynamicHealthScalingSettingsAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class DynamicHealthScalingSettingsAsset : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entries;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryConvert_Public_Boolean_UnitBaseStatsType_byref_DynamicallyWeakenAttackers_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 748934, RefRangeEnd = 748935, XrefRangeStart = 748919, XrefRangeEnd = 748934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryConvert(
      UnitBaseStatsType unitBaseStatsType,
      out DynamicallyWeakenAttackers result,
      float multiplierOverride = -1f,
      float multiplierReductionFactorPerCrowdednessOverride = -1f)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &unitBaseStatsType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &multiplierOverride;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &multiplierReductionFactorPerCrowdednessOverride;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicHealthScalingSettingsAsset.NativeMethodInfoPtr_TryConvert_Public_Boolean_UnitBaseStatsType_byref_DynamicallyWeakenAttackers_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748935, XrefRangeEnd = 748943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DynamicHealthScalingSettingsAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DynamicHealthScalingSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DynamicHealthScalingSettingsAsset()
    {
      Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DynamicHealthScalingSettingsAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset>.NativeClassPtr);
      DynamicHealthScalingSettingsAsset.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset>.NativeClassPtr, nameof (Entries));
      DynamicHealthScalingSettingsAsset.NativeMethodInfoPtr_TryConvert_Public_Boolean_UnitBaseStatsType_byref_DynamicallyWeakenAttackers_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset>.NativeClassPtr, 100665937);
      DynamicHealthScalingSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset>.NativeClassPtr, 100665938);
    }

    public DynamicHealthScalingSettingsAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<DynamicHealthScalingSettingsAsset.Entry> Entries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicHealthScalingSettingsAsset.NativeFieldInfoPtr_Entries));
        return pointer == System.IntPtr.Zero ? (List<DynamicHealthScalingSettingsAsset.Entry>) null : new List<DynamicHealthScalingSettingsAsset.Entry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DynamicHealthScalingSettingsAsset.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class Entry : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_UnitBaseStatsType;
      private static readonly System.IntPtr NativeFieldInfoPtr_Multiplier;
      private static readonly System.IntPtr NativeFieldInfoPtr_MultiplierReductionFactorPerCrowdedness;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxPlayers;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Entry()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset.Entry>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DynamicHealthScalingSettingsAsset.Entry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Entry()
      {
        Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset>.NativeClassPtr, nameof (Entry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset.Entry>.NativeClassPtr);
        DynamicHealthScalingSettingsAsset.Entry.NativeFieldInfoPtr_UnitBaseStatsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset.Entry>.NativeClassPtr, nameof (UnitBaseStatsType));
        DynamicHealthScalingSettingsAsset.Entry.NativeFieldInfoPtr_Multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset.Entry>.NativeClassPtr, nameof (Multiplier));
        DynamicHealthScalingSettingsAsset.Entry.NativeFieldInfoPtr_MultiplierReductionFactorPerCrowdedness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset.Entry>.NativeClassPtr, nameof (MultiplierReductionFactorPerCrowdedness));
        DynamicHealthScalingSettingsAsset.Entry.NativeFieldInfoPtr_MaxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset.Entry>.NativeClassPtr, nameof (MaxPlayers));
        DynamicHealthScalingSettingsAsset.Entry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset.Entry>.NativeClassPtr, 100665939);
      }

      public Entry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe UnitBaseStatsType UnitBaseStatsType
      {
        get
        {
          return *(UnitBaseStatsType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicHealthScalingSettingsAsset.Entry.NativeFieldInfoPtr_UnitBaseStatsType));
        }
        [param: In] set
        {
          *(UnitBaseStatsType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicHealthScalingSettingsAsset.Entry.NativeFieldInfoPtr_UnitBaseStatsType)) = value;
        }
      }

      public unsafe float Multiplier
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicHealthScalingSettingsAsset.Entry.NativeFieldInfoPtr_Multiplier));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicHealthScalingSettingsAsset.Entry.NativeFieldInfoPtr_Multiplier)) = value;
        }
      }

      public unsafe float MultiplierReductionFactorPerCrowdedness
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicHealthScalingSettingsAsset.Entry.NativeFieldInfoPtr_MultiplierReductionFactorPerCrowdedness));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicHealthScalingSettingsAsset.Entry.NativeFieldInfoPtr_MultiplierReductionFactorPerCrowdedness)) = value;
        }
      }

      public unsafe int MaxPlayers
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicHealthScalingSettingsAsset.Entry.NativeFieldInfoPtr_MaxPlayers));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicHealthScalingSettingsAsset.Entry.NativeFieldInfoPtr_MaxPlayers)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.DynamicHealthScalingSettingsAsset/<>c__DisplayClass2_0")]
    public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_unitBaseStatsType;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__TryConvert_b__0_Internal_Boolean_Entry_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset.__c__DisplayClass2_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DynamicHealthScalingSettingsAsset.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe bool _TryConvert_b__0(DynamicHealthScalingSettingsAsset.Entry asset)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicHealthScalingSettingsAsset.__c__DisplayClass2_0.NativeMethodInfoPtr__TryConvert_b__0_Internal_Boolean_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset.__c__DisplayClass2_0>.NativeClassPtr);
        DynamicHealthScalingSettingsAsset.__c__DisplayClass2_0.NativeFieldInfoPtr_unitBaseStatsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset.__c__DisplayClass2_0>.NativeClassPtr, nameof (unitBaseStatsType));
        DynamicHealthScalingSettingsAsset.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset.__c__DisplayClass2_0>.NativeClassPtr, 100665940);
        DynamicHealthScalingSettingsAsset.__c__DisplayClass2_0.NativeMethodInfoPtr__TryConvert_b__0_Internal_Boolean_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicHealthScalingSettingsAsset.__c__DisplayClass2_0>.NativeClassPtr, 100665941);
      }

      public __c__DisplayClass2_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe UnitBaseStatsType unitBaseStatsType
      {
        get
        {
          return *(UnitBaseStatsType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicHealthScalingSettingsAsset.__c__DisplayClass2_0.NativeFieldInfoPtr_unitBaseStatsType));
        }
        [param: In] set
        {
          *(UnitBaseStatsType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicHealthScalingSettingsAsset.__c__DisplayClass2_0.NativeFieldInfoPtr_unitBaseStatsType)) = value;
        }
      }
    }
  }
}
