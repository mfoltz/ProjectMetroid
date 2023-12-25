// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitSpawnerstationAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Malee;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class UnitSpawnerstationAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MaxSpawnedUnits;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnPoints;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnRadiusMin;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnRadiusMax;
    private static readonly IntPtr NativeFieldInfoPtr_OnDestroyAction;
    private static readonly IntPtr NativeFieldInfoPtr_CraftRecipes;
    private static readonly IntPtr NativeFieldInfoPtr_Bonuses;
    private static readonly IntPtr NativeFieldInfoPtr_ActiveSequence;
    private static readonly IntPtr NativeFieldInfoPtr_InactiveSequence;
    private static readonly IntPtr NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe List<RecipeDataAsset> UsedRecipes
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077744, XrefRangeEnd = 1077756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationAuthoring.NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<RecipeDataAsset>) null : new List<RecipeDataAsset>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077756, XrefRangeEnd = 1077830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077830, XrefRangeEnd = 1077849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnitSpawnerstationAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077849, XrefRangeEnd = 1077850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitSpawnerstationAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitSpawnerstationAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnitSpawnerstationAuthoring()
    {
      Il2CppClassPointerStore<UnitSpawnerstationAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UnitSpawnerstationAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitSpawnerstationAuthoring>.NativeClassPtr);
      UnitSpawnerstationAuthoring.NativeFieldInfoPtr_MaxSpawnedUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationAuthoring>.NativeClassPtr, nameof (MaxSpawnedUnits));
      UnitSpawnerstationAuthoring.NativeFieldInfoPtr_SpawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationAuthoring>.NativeClassPtr, nameof (SpawnPoints));
      UnitSpawnerstationAuthoring.NativeFieldInfoPtr_SpawnRadiusMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationAuthoring>.NativeClassPtr, nameof (SpawnRadiusMin));
      UnitSpawnerstationAuthoring.NativeFieldInfoPtr_SpawnRadiusMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationAuthoring>.NativeClassPtr, nameof (SpawnRadiusMax));
      UnitSpawnerstationAuthoring.NativeFieldInfoPtr_OnDestroyAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationAuthoring>.NativeClassPtr, nameof (OnDestroyAction));
      UnitSpawnerstationAuthoring.NativeFieldInfoPtr_CraftRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationAuthoring>.NativeClassPtr, nameof (CraftRecipes));
      UnitSpawnerstationAuthoring.NativeFieldInfoPtr_Bonuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationAuthoring>.NativeClassPtr, nameof (Bonuses));
      UnitSpawnerstationAuthoring.NativeFieldInfoPtr_ActiveSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationAuthoring>.NativeClassPtr, nameof (ActiveSequence));
      UnitSpawnerstationAuthoring.NativeFieldInfoPtr_InactiveSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationAuthoring>.NativeClassPtr, nameof (InactiveSequence));
      UnitSpawnerstationAuthoring.NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationAuthoring>.NativeClassPtr, 100684872);
      UnitSpawnerstationAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationAuthoring>.NativeClassPtr, 100684873);
      UnitSpawnerstationAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationAuthoring>.NativeClassPtr, 100684874);
      UnitSpawnerstationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationAuthoring>.NativeClassPtr, 100684875);
    }

    public UnitSpawnerstationAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int MaxSpawnedUnits
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationAuthoring.NativeFieldInfoPtr_MaxSpawnedUnits));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationAuthoring.NativeFieldInfoPtr_MaxSpawnedUnits)) = value;
      }
    }

    public unsafe UnitSpawnerstationAuthoring.TransformArray SpawnPoints
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationAuthoring.NativeFieldInfoPtr_SpawnPoints));
        return pointer == IntPtr.Zero ? (UnitSpawnerstationAuthoring.TransformArray) null : new UnitSpawnerstationAuthoring.TransformArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationAuthoring.NativeFieldInfoPtr_SpawnPoints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float SpawnRadiusMin
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationAuthoring.NativeFieldInfoPtr_SpawnRadiusMin));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationAuthoring.NativeFieldInfoPtr_SpawnRadiusMin)) = value;
      }
    }

    public unsafe float SpawnRadiusMax
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationAuthoring.NativeFieldInfoPtr_SpawnRadiusMax));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationAuthoring.NativeFieldInfoPtr_SpawnRadiusMax)) = value;
      }
    }

    public unsafe UnitSpawnerOnDestroyAction OnDestroyAction
    {
      get
      {
        return *(UnitSpawnerOnDestroyAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationAuthoring.NativeFieldInfoPtr_OnDestroyAction));
      }
      [param: In] set
      {
        *(UnitSpawnerOnDestroyAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationAuthoring.NativeFieldInfoPtr_OnDestroyAction)) = value;
      }
    }

    public unsafe UnitSpawnerstationAuthoring.RecipeArray CraftRecipes
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationAuthoring.NativeFieldInfoPtr_CraftRecipes));
        return pointer == IntPtr.Zero ? (UnitSpawnerstationAuthoring.RecipeArray) null : new UnitSpawnerstationAuthoring.RecipeArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationAuthoring.NativeFieldInfoPtr_CraftRecipes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnitSpawnerstationAuthoring.StationBonusArray Bonuses
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationAuthoring.NativeFieldInfoPtr_Bonuses));
        return pointer == IntPtr.Zero ? (UnitSpawnerstationAuthoring.StationBonusArray) null : new UnitSpawnerstationAuthoring.StationBonusArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationAuthoring.NativeFieldInfoPtr_Bonuses), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField ActiveSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationAuthoring.NativeFieldInfoPtr_ActiveSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationAuthoring.NativeFieldInfoPtr_ActiveSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField InactiveSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationAuthoring.NativeFieldInfoPtr_InactiveSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationAuthoring.NativeFieldInfoPtr_InactiveSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class TransformArray : ReorderableArray<Transform>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077735, XrefRangeEnd = 1077738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TransformArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitSpawnerstationAuthoring.TransformArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationAuthoring.TransformArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TransformArray()
      {
        Il2CppClassPointerStore<UnitSpawnerstationAuthoring.TransformArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitSpawnerstationAuthoring>.NativeClassPtr, nameof (TransformArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitSpawnerstationAuthoring.TransformArray>.NativeClassPtr);
        UnitSpawnerstationAuthoring.TransformArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationAuthoring.TransformArray>.NativeClassPtr, 100684876);
      }

      public TransformArray(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [Serializable]
    public class StationBonusArray : ReorderableArray<StationBonusDataComponent>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077738, XrefRangeEnd = 1077741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe StationBonusArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitSpawnerstationAuthoring.StationBonusArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationAuthoring.StationBonusArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static StationBonusArray()
      {
        Il2CppClassPointerStore<UnitSpawnerstationAuthoring.StationBonusArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitSpawnerstationAuthoring>.NativeClassPtr, nameof (StationBonusArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitSpawnerstationAuthoring.StationBonusArray>.NativeClassPtr);
        UnitSpawnerstationAuthoring.StationBonusArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationAuthoring.StationBonusArray>.NativeClassPtr, 100684877);
      }

      public StationBonusArray(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [Serializable]
    public class RecipeArray : ReorderableArray<RecipeDataAsset>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077741, XrefRangeEnd = 1077744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe RecipeArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitSpawnerstationAuthoring.RecipeArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationAuthoring.RecipeArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RecipeArray()
      {
        Il2CppClassPointerStore<UnitSpawnerstationAuthoring.RecipeArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitSpawnerstationAuthoring>.NativeClassPtr, nameof (RecipeArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitSpawnerstationAuthoring.RecipeArray>.NativeClassPtr);
        UnitSpawnerstationAuthoring.RecipeArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationAuthoring.RecipeArray>.NativeClassPtr, 100684878);
      }

      public RecipeArray(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
