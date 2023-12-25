// Decompiled with JetBrains decompiler
// Type: ProjectM.WorkstationAuthoring
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

#nullable disable
namespace ProjectM
{
  public class WorkstationAuthoring : StunlockBehaviour
  {
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
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082417, XrefRangeEnd = 1082429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorkstationAuthoring.NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<RecipeDataAsset>) null : new List<RecipeDataAsset>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082429, XrefRangeEnd = 1082475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(WorkstationAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082475, XrefRangeEnd = 1082488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorkstationAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WorkstationAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkstationAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorkstationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WorkstationAuthoring()
    {
      Il2CppClassPointerStore<WorkstationAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (WorkstationAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkstationAuthoring>.NativeClassPtr);
      WorkstationAuthoring.NativeFieldInfoPtr_CraftRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationAuthoring>.NativeClassPtr, nameof (CraftRecipes));
      WorkstationAuthoring.NativeFieldInfoPtr_Bonuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationAuthoring>.NativeClassPtr, nameof (Bonuses));
      WorkstationAuthoring.NativeFieldInfoPtr_ActiveSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationAuthoring>.NativeClassPtr, nameof (ActiveSequence));
      WorkstationAuthoring.NativeFieldInfoPtr_InactiveSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationAuthoring>.NativeClassPtr, nameof (InactiveSequence));
      WorkstationAuthoring.NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationAuthoring>.NativeClassPtr, 100685252);
      WorkstationAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationAuthoring>.NativeClassPtr, 100685253);
      WorkstationAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationAuthoring>.NativeClassPtr, 100685254);
      WorkstationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationAuthoring>.NativeClassPtr, 100685255);
    }

    public WorkstationAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WorkstationAuthoring.RecipeArray CraftRecipes
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationAuthoring.NativeFieldInfoPtr_CraftRecipes));
        return pointer == IntPtr.Zero ? (WorkstationAuthoring.RecipeArray) null : new WorkstationAuthoring.RecipeArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationAuthoring.NativeFieldInfoPtr_CraftRecipes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WorkstationAuthoring.StationBonusArray Bonuses
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationAuthoring.NativeFieldInfoPtr_Bonuses));
        return pointer == IntPtr.Zero ? (WorkstationAuthoring.StationBonusArray) null : new WorkstationAuthoring.StationBonusArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationAuthoring.NativeFieldInfoPtr_Bonuses), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField ActiveSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationAuthoring.NativeFieldInfoPtr_ActiveSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationAuthoring.NativeFieldInfoPtr_ActiveSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField InactiveSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationAuthoring.NativeFieldInfoPtr_InactiveSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationAuthoring.NativeFieldInfoPtr_InactiveSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class StationBonusArray : ReorderableArray<StationBonusDataComponent>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082411, XrefRangeEnd = 1082414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe StationBonusArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkstationAuthoring.StationBonusArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorkstationAuthoring.StationBonusArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static StationBonusArray()
      {
        Il2CppClassPointerStore<WorkstationAuthoring.StationBonusArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkstationAuthoring>.NativeClassPtr, nameof (StationBonusArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkstationAuthoring.StationBonusArray>.NativeClassPtr);
        WorkstationAuthoring.StationBonusArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationAuthoring.StationBonusArray>.NativeClassPtr, 100685256);
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
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082414, XrefRangeEnd = 1082417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe RecipeArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkstationAuthoring.RecipeArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorkstationAuthoring.RecipeArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RecipeArray()
      {
        Il2CppClassPointerStore<WorkstationAuthoring.RecipeArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkstationAuthoring>.NativeClassPtr, nameof (RecipeArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkstationAuthoring.RecipeArray>.NativeClassPtr);
        WorkstationAuthoring.RecipeArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationAuthoring.RecipeArray>.NativeClassPtr, 100685257);
      }

      public RecipeArray(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
