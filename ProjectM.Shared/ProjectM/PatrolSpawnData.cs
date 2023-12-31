// Decompiled with JetBrains decompiler
// Type: ProjectM.PatrolSpawnData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Malee;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class PatrolSpawnData : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Speed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Units;
    private static readonly System.IntPtr NativeFieldInfoPtr_SingleRespawnTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GroupRespawnTimer;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747469, XrefRangeEnd = 747470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PatrolSpawnData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolSpawnData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PatrolSpawnData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PatrolSpawnData()
    {
      Il2CppClassPointerStore<PatrolSpawnData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PatrolSpawnData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolSpawnData>.NativeClassPtr);
      PatrolSpawnData.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolSpawnData>.NativeClassPtr, nameof (Speed));
      PatrolSpawnData.NativeFieldInfoPtr_Units = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolSpawnData>.NativeClassPtr, nameof (Units));
      PatrolSpawnData.NativeFieldInfoPtr_SingleRespawnTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolSpawnData>.NativeClassPtr, nameof (SingleRespawnTimer));
      PatrolSpawnData.NativeFieldInfoPtr_GroupRespawnTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolSpawnData>.NativeClassPtr, nameof (GroupRespawnTimer));
      PatrolSpawnData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolSpawnData>.NativeClassPtr, 100665814);
    }

    public PatrolSpawnData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Speed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolSpawnData.NativeFieldInfoPtr_Speed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolSpawnData.NativeFieldInfoPtr_Speed)) = value;
      }
    }

    public unsafe PatrolSpawnData.PatrolSpawnUnitsArray Units
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolSpawnData.NativeFieldInfoPtr_Units));
        return pointer == System.IntPtr.Zero ? (PatrolSpawnData.PatrolSpawnUnitsArray) null : new PatrolSpawnData.PatrolSpawnUnitsArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PatrolSpawnData.NativeFieldInfoPtr_Units), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnitRespawnSettings SingleRespawnTimer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolSpawnData.NativeFieldInfoPtr_SingleRespawnTimer));
        return pointer == System.IntPtr.Zero ? (UnitRespawnSettings) null : new UnitRespawnSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PatrolSpawnData.NativeFieldInfoPtr_SingleRespawnTimer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnitRespawnSettings GroupRespawnTimer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolSpawnData.NativeFieldInfoPtr_GroupRespawnTimer));
        return pointer == System.IntPtr.Zero ? (UnitRespawnSettings) null : new UnitRespawnSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PatrolSpawnData.NativeFieldInfoPtr_GroupRespawnTimer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class PatrolSpawnUnit : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SpawnPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpawnChance;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PatrolSpawnUnit()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolSpawnData.PatrolSpawnUnit>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolSpawnData.PatrolSpawnUnit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static PatrolSpawnUnit()
      {
        Il2CppClassPointerStore<PatrolSpawnData.PatrolSpawnUnit>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolSpawnData>.NativeClassPtr, nameof (PatrolSpawnUnit));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolSpawnData.PatrolSpawnUnit>.NativeClassPtr);
        PatrolSpawnData.PatrolSpawnUnit.NativeFieldInfoPtr_SpawnPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolSpawnData.PatrolSpawnUnit>.NativeClassPtr, nameof (SpawnPrefab));
        PatrolSpawnData.PatrolSpawnUnit.NativeFieldInfoPtr_SpawnChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolSpawnData.PatrolSpawnUnit>.NativeClassPtr, nameof (SpawnChance));
        PatrolSpawnData.PatrolSpawnUnit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolSpawnData.PatrolSpawnUnit>.NativeClassPtr, 100665815);
      }

      public PatrolSpawnUnit(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe PrefabGuidComponent SpawnPrefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolSpawnData.PatrolSpawnUnit.NativeFieldInfoPtr_SpawnPrefab));
          return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PatrolSpawnData.PatrolSpawnUnit.NativeFieldInfoPtr_SpawnPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float SpawnChance
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolSpawnData.PatrolSpawnUnit.NativeFieldInfoPtr_SpawnChance));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolSpawnData.PatrolSpawnUnit.NativeFieldInfoPtr_SpawnChance)) = value;
        }
      }
    }

    [Serializable]
    public class PatrolSpawnUnitsArray : ReorderableArray<PatrolSpawnData.PatrolSpawnUnit>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747466, XrefRangeEnd = 747469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PatrolSpawnUnitsArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolSpawnData.PatrolSpawnUnitsArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolSpawnData.PatrolSpawnUnitsArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static PatrolSpawnUnitsArray()
      {
        Il2CppClassPointerStore<PatrolSpawnData.PatrolSpawnUnitsArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolSpawnData>.NativeClassPtr, nameof (PatrolSpawnUnitsArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolSpawnData.PatrolSpawnUnitsArray>.NativeClassPtr);
        PatrolSpawnData.PatrolSpawnUnitsArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolSpawnData.PatrolSpawnUnitsArray>.NativeClassPtr, 100665816);
      }

      public PatrolSpawnUnitsArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
