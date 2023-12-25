// Decompiled with JetBrains decompiler
// Type: ProjectM.ProgressionConsumableBookAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ProgressionConsumableBookAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_UnlocksRecipeAssets;
    private static readonly IntPtr NativeFieldInfoPtr_UnlocksTechAssets;
    private static readonly IntPtr NativeFieldInfoPtr_UnlocksBlueprintPrefabs;
    private static readonly IntPtr NativeFieldInfoPtr_UnlocksShapeshiftPrefabs;
    private static readonly IntPtr NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe List<RecipeDataAsset> UsedRecipes
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029041, XrefRangeEnd = 1029047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionConsumableBookAuthoring.NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<RecipeDataAsset>) null : new List<RecipeDataAsset>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029047, XrefRangeEnd = 1029135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ProgressionConsumableBookAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029135, XrefRangeEnd = 1029148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProgressionConsumableBookAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProgressionConsumableBookAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressionConsumableBookAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProgressionConsumableBookAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProgressionConsumableBookAuthoring()
    {
      Il2CppClassPointerStore<ProgressionConsumableBookAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ProgressionConsumableBookAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressionConsumableBookAuthoring>.NativeClassPtr);
      ProgressionConsumableBookAuthoring.NativeFieldInfoPtr_UnlocksRecipeAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionConsumableBookAuthoring>.NativeClassPtr, nameof (UnlocksRecipeAssets));
      ProgressionConsumableBookAuthoring.NativeFieldInfoPtr_UnlocksTechAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionConsumableBookAuthoring>.NativeClassPtr, nameof (UnlocksTechAssets));
      ProgressionConsumableBookAuthoring.NativeFieldInfoPtr_UnlocksBlueprintPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionConsumableBookAuthoring>.NativeClassPtr, nameof (UnlocksBlueprintPrefabs));
      ProgressionConsumableBookAuthoring.NativeFieldInfoPtr_UnlocksShapeshiftPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionConsumableBookAuthoring>.NativeClassPtr, nameof (UnlocksShapeshiftPrefabs));
      ProgressionConsumableBookAuthoring.NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionConsumableBookAuthoring>.NativeClassPtr, 100680343);
      ProgressionConsumableBookAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionConsumableBookAuthoring>.NativeClassPtr, 100680344);
      ProgressionConsumableBookAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionConsumableBookAuthoring>.NativeClassPtr, 100680345);
      ProgressionConsumableBookAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionConsumableBookAuthoring>.NativeClassPtr, 100680346);
    }

    public ProgressionConsumableBookAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<WeakAssetReference<RecipeDataAsset>> UnlocksRecipeAssets
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProgressionConsumableBookAuthoring.NativeFieldInfoPtr_UnlocksRecipeAssets));
        return pointer == IntPtr.Zero ? (List<WeakAssetReference<RecipeDataAsset>>) null : new List<WeakAssetReference<RecipeDataAsset>>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProgressionConsumableBookAuthoring.NativeFieldInfoPtr_UnlocksRecipeAssets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<WeakAssetReference<TechDataAsset>> UnlocksTechAssets
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProgressionConsumableBookAuthoring.NativeFieldInfoPtr_UnlocksTechAssets));
        return pointer == IntPtr.Zero ? (List<WeakAssetReference<TechDataAsset>>) null : new List<WeakAssetReference<TechDataAsset>>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProgressionConsumableBookAuthoring.NativeFieldInfoPtr_UnlocksTechAssets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<WeakAssetReference<BlueprintDataComponent>> UnlocksBlueprintPrefabs
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProgressionConsumableBookAuthoring.NativeFieldInfoPtr_UnlocksBlueprintPrefabs));
        return pointer == IntPtr.Zero ? (List<WeakAssetReference<BlueprintDataComponent>>) null : new List<WeakAssetReference<BlueprintDataComponent>>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProgressionConsumableBookAuthoring.NativeFieldInfoPtr_UnlocksBlueprintPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<WeakAssetReference<PrefabGuidComponent>> UnlocksShapeshiftPrefabs
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProgressionConsumableBookAuthoring.NativeFieldInfoPtr_UnlocksShapeshiftPrefabs));
        return pointer == IntPtr.Zero ? (List<WeakAssetReference<PrefabGuidComponent>>) null : new List<WeakAssetReference<PrefabGuidComponent>>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProgressionConsumableBookAuthoring.NativeFieldInfoPtr_UnlocksShapeshiftPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
