// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodQualityCurveSettingsAsset
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
  public class BloodQualityCurveSettingsAsset : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entries;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748558, XrefRangeEnd = 748566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BloodQualityCurveSettingsAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodQualityCurveSettingsAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodQualityCurveSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BloodQualityCurveSettingsAsset()
    {
      Il2CppClassPointerStore<BloodQualityCurveSettingsAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BloodQualityCurveSettingsAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodQualityCurveSettingsAsset>.NativeClassPtr);
      BloodQualityCurveSettingsAsset.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodQualityCurveSettingsAsset>.NativeClassPtr, nameof (Entries));
      BloodQualityCurveSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodQualityCurveSettingsAsset>.NativeClassPtr, 100665900);
    }

    public BloodQualityCurveSettingsAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<BloodQualityCurveSettingsAsset.TypeEntry> Entries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodQualityCurveSettingsAsset.NativeFieldInfoPtr_Entries));
        return pointer == System.IntPtr.Zero ? (List<BloodQualityCurveSettingsAsset.TypeEntry>) null : new List<BloodQualityCurveSettingsAsset.TypeEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodQualityCurveSettingsAsset.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class TypeEntry : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_UnitBaseStatsType;
      private static readonly System.IntPtr NativeFieldInfoPtr_LevelEntries;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TypeEntry()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodQualityCurveSettingsAsset.TypeEntry>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BloodQualityCurveSettingsAsset.TypeEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TypeEntry()
      {
        Il2CppClassPointerStore<BloodQualityCurveSettingsAsset.TypeEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloodQualityCurveSettingsAsset>.NativeClassPtr, nameof (TypeEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodQualityCurveSettingsAsset.TypeEntry>.NativeClassPtr);
        BloodQualityCurveSettingsAsset.TypeEntry.NativeFieldInfoPtr_UnitBaseStatsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodQualityCurveSettingsAsset.TypeEntry>.NativeClassPtr, nameof (UnitBaseStatsType));
        BloodQualityCurveSettingsAsset.TypeEntry.NativeFieldInfoPtr_LevelEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodQualityCurveSettingsAsset.TypeEntry>.NativeClassPtr, nameof (LevelEntries));
        BloodQualityCurveSettingsAsset.TypeEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodQualityCurveSettingsAsset.TypeEntry>.NativeClassPtr, 100665901);
      }

      public TypeEntry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe UnitBaseStatsType UnitBaseStatsType
      {
        get
        {
          return *(UnitBaseStatsType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodQualityCurveSettingsAsset.TypeEntry.NativeFieldInfoPtr_UnitBaseStatsType));
        }
        [param: In] set
        {
          *(UnitBaseStatsType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodQualityCurveSettingsAsset.TypeEntry.NativeFieldInfoPtr_UnitBaseStatsType)) = value;
        }
      }

      public unsafe List<BloodQualityCurveSettingsAsset.LevelEntry> LevelEntries
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodQualityCurveSettingsAsset.TypeEntry.NativeFieldInfoPtr_LevelEntries));
          return pointer == System.IntPtr.Zero ? (List<BloodQualityCurveSettingsAsset.LevelEntry>) null : new List<BloodQualityCurveSettingsAsset.LevelEntry>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodQualityCurveSettingsAsset.TypeEntry.NativeFieldInfoPtr_LevelEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [Serializable]
    public class LevelEntry : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MinLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_BloodQualityCurve;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe LevelEntry()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodQualityCurveSettingsAsset.LevelEntry>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BloodQualityCurveSettingsAsset.LevelEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static LevelEntry()
      {
        Il2CppClassPointerStore<BloodQualityCurveSettingsAsset.LevelEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloodQualityCurveSettingsAsset>.NativeClassPtr, nameof (LevelEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodQualityCurveSettingsAsset.LevelEntry>.NativeClassPtr);
        BloodQualityCurveSettingsAsset.LevelEntry.NativeFieldInfoPtr_MinLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodQualityCurveSettingsAsset.LevelEntry>.NativeClassPtr, nameof (MinLevel));
        BloodQualityCurveSettingsAsset.LevelEntry.NativeFieldInfoPtr_BloodQualityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodQualityCurveSettingsAsset.LevelEntry>.NativeClassPtr, nameof (BloodQualityCurve));
        BloodQualityCurveSettingsAsset.LevelEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodQualityCurveSettingsAsset.LevelEntry>.NativeClassPtr, 100665902);
      }

      public LevelEntry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int MinLevel
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodQualityCurveSettingsAsset.LevelEntry.NativeFieldInfoPtr_MinLevel));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodQualityCurveSettingsAsset.LevelEntry.NativeFieldInfoPtr_MinLevel)) = value;
        }
      }

      public unsafe CurveReference BloodQualityCurve
      {
        get
        {
          return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodQualityCurveSettingsAsset.LevelEntry.NativeFieldInfoPtr_BloodQualityCurve));
        }
        [param: In] set
        {
          *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodQualityCurveSettingsAsset.LevelEntry.NativeFieldInfoPtr_BloodQualityCurve)) = value;
        }
      }
    }
  }
}
