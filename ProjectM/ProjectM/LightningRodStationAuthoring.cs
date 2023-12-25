// Decompiled with JetBrains decompiler
// Type: ProjectM.LightningRodStationAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class LightningRodStationAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_CraftRecipes;
    private static readonly IntPtr NativeFieldInfoPtr_ResetTime;
    private static readonly IntPtr NativeFieldInfoPtr_TimeProgressPerStrike;
    private static readonly IntPtr NativeFieldInfoPtr_ReadySequence;
    private static readonly IntPtr NativeFieldInfoPtr_WorkingSequence;
    private static readonly IntPtr NativeFieldInfoPtr_CompleteSequence;
    private static readonly IntPtr NativeFieldInfoPtr_OverloadedSequence;
    private static readonly IntPtr NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe List<RecipeDataAsset> UsedRecipes
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047558, XrefRangeEnd = 1047567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningRodStationAuthoring.NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<RecipeDataAsset>) null : new List<RecipeDataAsset>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047567, XrefRangeEnd = 1047584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(LightningRodStationAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047584, XrefRangeEnd = 1047588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LightningRodStationAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LightningRodStationAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningRodStationAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningRodStationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LightningRodStationAuthoring()
    {
      Il2CppClassPointerStore<LightningRodStationAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (LightningRodStationAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningRodStationAuthoring>.NativeClassPtr);
      LightningRodStationAuthoring.NativeFieldInfoPtr_CraftRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStationAuthoring>.NativeClassPtr, nameof (CraftRecipes));
      LightningRodStationAuthoring.NativeFieldInfoPtr_ResetTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStationAuthoring>.NativeClassPtr, nameof (ResetTime));
      LightningRodStationAuthoring.NativeFieldInfoPtr_TimeProgressPerStrike = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStationAuthoring>.NativeClassPtr, nameof (TimeProgressPerStrike));
      LightningRodStationAuthoring.NativeFieldInfoPtr_ReadySequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStationAuthoring>.NativeClassPtr, nameof (ReadySequence));
      LightningRodStationAuthoring.NativeFieldInfoPtr_WorkingSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStationAuthoring>.NativeClassPtr, nameof (WorkingSequence));
      LightningRodStationAuthoring.NativeFieldInfoPtr_CompleteSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStationAuthoring>.NativeClassPtr, nameof (CompleteSequence));
      LightningRodStationAuthoring.NativeFieldInfoPtr_OverloadedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStationAuthoring>.NativeClassPtr, nameof (OverloadedSequence));
      LightningRodStationAuthoring.NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRodStationAuthoring>.NativeClassPtr, 100682126);
      LightningRodStationAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRodStationAuthoring>.NativeClassPtr, 100682127);
      LightningRodStationAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRodStationAuthoring>.NativeClassPtr, 100682128);
      LightningRodStationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningRodStationAuthoring>.NativeClassPtr, 100682129);
    }

    public LightningRodStationAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<RecipeDataAsset> CraftRecipes
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningRodStationAuthoring.NativeFieldInfoPtr_CraftRecipes));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<RecipeDataAsset>) null : new Il2CppReferenceArray<RecipeDataAsset>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightningRodStationAuthoring.NativeFieldInfoPtr_CraftRecipes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float ResetTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningRodStationAuthoring.NativeFieldInfoPtr_ResetTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningRodStationAuthoring.NativeFieldInfoPtr_ResetTime)) = value;
      }
    }

    public unsafe float TimeProgressPerStrike
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningRodStationAuthoring.NativeFieldInfoPtr_TimeProgressPerStrike));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningRodStationAuthoring.NativeFieldInfoPtr_TimeProgressPerStrike)) = value;
      }
    }

    public unsafe SequenceField ReadySequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningRodStationAuthoring.NativeFieldInfoPtr_ReadySequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightningRodStationAuthoring.NativeFieldInfoPtr_ReadySequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField WorkingSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningRodStationAuthoring.NativeFieldInfoPtr_WorkingSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightningRodStationAuthoring.NativeFieldInfoPtr_WorkingSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField CompleteSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningRodStationAuthoring.NativeFieldInfoPtr_CompleteSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightningRodStationAuthoring.NativeFieldInfoPtr_CompleteSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField OverloadedSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningRodStationAuthoring.NativeFieldInfoPtr_OverloadedSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightningRodStationAuthoring.NativeFieldInfoPtr_OverloadedSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
