// Decompiled with JetBrains decompiler
// Type: ProjectM.PrisonAuthoring
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
  public class PrisonAuthoring : StunlockBehaviour
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
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061826, XrefRangeEnd = 1061838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrisonAuthoring.NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<RecipeDataAsset>) null : new List<RecipeDataAsset>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061838, XrefRangeEnd = 1061884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(PrisonAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061884, XrefRangeEnd = 1061900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrisonAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrisonAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrisonAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrisonAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PrisonAuthoring()
    {
      Il2CppClassPointerStore<PrisonAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PrisonAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrisonAuthoring>.NativeClassPtr);
      PrisonAuthoring.NativeFieldInfoPtr_CraftRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonAuthoring>.NativeClassPtr, nameof (CraftRecipes));
      PrisonAuthoring.NativeFieldInfoPtr_Bonuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonAuthoring>.NativeClassPtr, nameof (Bonuses));
      PrisonAuthoring.NativeFieldInfoPtr_ActiveSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonAuthoring>.NativeClassPtr, nameof (ActiveSequence));
      PrisonAuthoring.NativeFieldInfoPtr_InactiveSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonAuthoring>.NativeClassPtr, nameof (InactiveSequence));
      PrisonAuthoring.NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonAuthoring>.NativeClassPtr, 100683305);
      PrisonAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonAuthoring>.NativeClassPtr, 100683306);
      PrisonAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonAuthoring>.NativeClassPtr, 100683307);
      PrisonAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonAuthoring>.NativeClassPtr, 100683308);
    }

    public PrisonAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrisonAuthoring.RecipeArray CraftRecipes
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonAuthoring.NativeFieldInfoPtr_CraftRecipes));
        return pointer == IntPtr.Zero ? (PrisonAuthoring.RecipeArray) null : new PrisonAuthoring.RecipeArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonAuthoring.NativeFieldInfoPtr_CraftRecipes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrisonAuthoring.StationBonusArray Bonuses
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonAuthoring.NativeFieldInfoPtr_Bonuses));
        return pointer == IntPtr.Zero ? (PrisonAuthoring.StationBonusArray) null : new PrisonAuthoring.StationBonusArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonAuthoring.NativeFieldInfoPtr_Bonuses), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField ActiveSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonAuthoring.NativeFieldInfoPtr_ActiveSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonAuthoring.NativeFieldInfoPtr_ActiveSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField InactiveSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonAuthoring.NativeFieldInfoPtr_InactiveSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonAuthoring.NativeFieldInfoPtr_InactiveSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class StationBonusArray : ReorderableArray<StationBonusDataComponent>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061820, XrefRangeEnd = 1061823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe StationBonusArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrisonAuthoring.StationBonusArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrisonAuthoring.StationBonusArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static StationBonusArray()
      {
        Il2CppClassPointerStore<PrisonAuthoring.StationBonusArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrisonAuthoring>.NativeClassPtr, nameof (StationBonusArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrisonAuthoring.StationBonusArray>.NativeClassPtr);
        PrisonAuthoring.StationBonusArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonAuthoring.StationBonusArray>.NativeClassPtr, 100683309);
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
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061823, XrefRangeEnd = 1061826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe RecipeArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrisonAuthoring.RecipeArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrisonAuthoring.RecipeArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RecipeArray()
      {
        Il2CppClassPointerStore<PrisonAuthoring.RecipeArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrisonAuthoring>.NativeClassPtr, nameof (RecipeArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrisonAuthoring.RecipeArray>.NativeClassPtr);
        PrisonAuthoring.RecipeArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonAuthoring.RecipeArray>.NativeClassPtr, 100683310);
      }

      public RecipeArray(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
