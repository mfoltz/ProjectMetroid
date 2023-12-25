// Decompiled with JetBrains decompiler
// Type: ProjectM.RefinementstationAuthoring
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
  public class RefinementstationAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_InputSlots;
    private static readonly IntPtr NativeFieldInfoPtr_OutputSlots;
    private static readonly IntPtr NativeFieldInfoPtr_NetworkedRefinementstationInventory;
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
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1064732, XrefRangeEnd = 1064744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(RefinementstationAuthoring.NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<RecipeDataAsset>) null : new List<RecipeDataAsset>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1064744, XrefRangeEnd = 1064788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(RefinementstationAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1064788, XrefRangeEnd = 1064804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RefinementstationAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1064804, XrefRangeEnd = 1064805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RefinementstationAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RefinementstationAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RefinementstationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RefinementstationAuthoring()
    {
      Il2CppClassPointerStore<RefinementstationAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RefinementstationAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefinementstationAuthoring>.NativeClassPtr);
      RefinementstationAuthoring.NativeFieldInfoPtr_InputSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationAuthoring>.NativeClassPtr, nameof (InputSlots));
      RefinementstationAuthoring.NativeFieldInfoPtr_OutputSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationAuthoring>.NativeClassPtr, nameof (OutputSlots));
      RefinementstationAuthoring.NativeFieldInfoPtr_NetworkedRefinementstationInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationAuthoring>.NativeClassPtr, nameof (NetworkedRefinementstationInventory));
      RefinementstationAuthoring.NativeFieldInfoPtr_CraftRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationAuthoring>.NativeClassPtr, nameof (CraftRecipes));
      RefinementstationAuthoring.NativeFieldInfoPtr_Bonuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationAuthoring>.NativeClassPtr, nameof (Bonuses));
      RefinementstationAuthoring.NativeFieldInfoPtr_ActiveSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationAuthoring>.NativeClassPtr, nameof (ActiveSequence));
      RefinementstationAuthoring.NativeFieldInfoPtr_InactiveSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationAuthoring>.NativeClassPtr, nameof (InactiveSequence));
      RefinementstationAuthoring.NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationAuthoring>.NativeClassPtr, 100683649);
      RefinementstationAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationAuthoring>.NativeClassPtr, 100683650);
      RefinementstationAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationAuthoring>.NativeClassPtr, 100683651);
      RefinementstationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationAuthoring>.NativeClassPtr, 100683652);
    }

    public RefinementstationAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int InputSlots
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationAuthoring.NativeFieldInfoPtr_InputSlots));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationAuthoring.NativeFieldInfoPtr_InputSlots)) = value;
      }
    }

    public unsafe int OutputSlots
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationAuthoring.NativeFieldInfoPtr_OutputSlots));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationAuthoring.NativeFieldInfoPtr_OutputSlots)) = value;
      }
    }

    public unsafe GameObject NetworkedRefinementstationInventory
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationAuthoring.NativeFieldInfoPtr_NetworkedRefinementstationInventory));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationAuthoring.NativeFieldInfoPtr_NetworkedRefinementstationInventory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RefinementstationAuthoring.RecipeArray CraftRecipes
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationAuthoring.NativeFieldInfoPtr_CraftRecipes));
        return pointer == IntPtr.Zero ? (RefinementstationAuthoring.RecipeArray) null : new RefinementstationAuthoring.RecipeArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationAuthoring.NativeFieldInfoPtr_CraftRecipes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RefinementstationAuthoring.StationBonusArray Bonuses
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationAuthoring.NativeFieldInfoPtr_Bonuses));
        return pointer == IntPtr.Zero ? (RefinementstationAuthoring.StationBonusArray) null : new RefinementstationAuthoring.StationBonusArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationAuthoring.NativeFieldInfoPtr_Bonuses), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField ActiveSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationAuthoring.NativeFieldInfoPtr_ActiveSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationAuthoring.NativeFieldInfoPtr_ActiveSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField InactiveSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationAuthoring.NativeFieldInfoPtr_InactiveSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationAuthoring.NativeFieldInfoPtr_InactiveSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class StationBonusArray : ReorderableArray<StationBonusDataComponent>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1064726, XrefRangeEnd = 1064729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe StationBonusArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RefinementstationAuthoring.StationBonusArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RefinementstationAuthoring.StationBonusArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static StationBonusArray()
      {
        Il2CppClassPointerStore<RefinementstationAuthoring.StationBonusArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RefinementstationAuthoring>.NativeClassPtr, nameof (StationBonusArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefinementstationAuthoring.StationBonusArray>.NativeClassPtr);
        RefinementstationAuthoring.StationBonusArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationAuthoring.StationBonusArray>.NativeClassPtr, 100683653);
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
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1064729, XrefRangeEnd = 1064732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe RecipeArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RefinementstationAuthoring.RecipeArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RefinementstationAuthoring.RecipeArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RecipeArray()
      {
        Il2CppClassPointerStore<RefinementstationAuthoring.RecipeArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RefinementstationAuthoring>.NativeClassPtr, nameof (RecipeArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefinementstationAuthoring.RecipeArray>.NativeClassPtr);
        RefinementstationAuthoring.RecipeArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationAuthoring.RecipeArray>.NativeClassPtr, 100683654);
      }

      public RecipeArray(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
