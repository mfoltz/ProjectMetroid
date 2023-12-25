// Decompiled with JetBrains decompiler
// Type: ProjectM.ProgressionGainAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Malee;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ProgressionGainAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_UnlocksRecipeAssets;
    private static readonly IntPtr NativeFieldInfoPtr_UnlocksBlueprints;
    private static readonly IntPtr NativeFieldInfoPtr_UnlocksTechAssets;
    private static readonly IntPtr NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe List<RecipeDataAsset> UsedRecipes
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029160, XrefRangeEnd = 1029172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionGainAuthoring.NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<RecipeDataAsset>) null : new List<RecipeDataAsset>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029172, XrefRangeEnd = 1029253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ProgressionGainAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029253, XrefRangeEnd = 1029269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProgressionGainAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressionGainAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProgressionGainAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProgressionGainAuthoring()
    {
      Il2CppClassPointerStore<ProgressionGainAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ProgressionGainAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressionGainAuthoring>.NativeClassPtr);
      ProgressionGainAuthoring.NativeFieldInfoPtr_UnlocksRecipeAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionGainAuthoring>.NativeClassPtr, nameof (UnlocksRecipeAssets));
      ProgressionGainAuthoring.NativeFieldInfoPtr_UnlocksBlueprints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionGainAuthoring>.NativeClassPtr, nameof (UnlocksBlueprints));
      ProgressionGainAuthoring.NativeFieldInfoPtr_UnlocksTechAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionGainAuthoring>.NativeClassPtr, nameof (UnlocksTechAssets));
      ProgressionGainAuthoring.NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionGainAuthoring>.NativeClassPtr, 100680347);
      ProgressionGainAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionGainAuthoring>.NativeClassPtr, 100680348);
      ProgressionGainAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionGainAuthoring>.NativeClassPtr, 100680349);
    }

    public ProgressionGainAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ProgressionGainAuthoring.RecipeDataAssetArray UnlocksRecipeAssets
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProgressionGainAuthoring.NativeFieldInfoPtr_UnlocksRecipeAssets));
        return pointer == IntPtr.Zero ? (ProgressionGainAuthoring.RecipeDataAssetArray) null : new ProgressionGainAuthoring.RecipeDataAssetArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProgressionGainAuthoring.NativeFieldInfoPtr_UnlocksRecipeAssets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProgressionGainAuthoring.BlueprintArray UnlocksBlueprints
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProgressionGainAuthoring.NativeFieldInfoPtr_UnlocksBlueprints));
        return pointer == IntPtr.Zero ? (ProgressionGainAuthoring.BlueprintArray) null : new ProgressionGainAuthoring.BlueprintArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProgressionGainAuthoring.NativeFieldInfoPtr_UnlocksBlueprints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProgressionGainAuthoring.TechDataAssetArray UnlocksTechAssets
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProgressionGainAuthoring.NativeFieldInfoPtr_UnlocksTechAssets));
        return pointer == IntPtr.Zero ? (ProgressionGainAuthoring.TechDataAssetArray) null : new ProgressionGainAuthoring.TechDataAssetArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProgressionGainAuthoring.NativeFieldInfoPtr_UnlocksTechAssets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class RecipeDataAssetArray : ReorderableArray<RecipeDataAsset>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1029151, RefRangeEnd = 1029152, XrefRangeStart = 1029148, XrefRangeEnd = 1029151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe RecipeDataAssetArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressionGainAuthoring.RecipeDataAssetArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProgressionGainAuthoring.RecipeDataAssetArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RecipeDataAssetArray()
      {
        Il2CppClassPointerStore<ProgressionGainAuthoring.RecipeDataAssetArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProgressionGainAuthoring>.NativeClassPtr, nameof (RecipeDataAssetArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressionGainAuthoring.RecipeDataAssetArray>.NativeClassPtr);
        ProgressionGainAuthoring.RecipeDataAssetArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionGainAuthoring.RecipeDataAssetArray>.NativeClassPtr, 100680350);
      }

      public RecipeDataAssetArray(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [Serializable]
    public class BlueprintArray : ReorderableArray<BlueprintDataComponent>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1029155, RefRangeEnd = 1029156, XrefRangeStart = 1029152, XrefRangeEnd = 1029155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BlueprintArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressionGainAuthoring.BlueprintArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProgressionGainAuthoring.BlueprintArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static BlueprintArray()
      {
        Il2CppClassPointerStore<ProgressionGainAuthoring.BlueprintArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProgressionGainAuthoring>.NativeClassPtr, nameof (BlueprintArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressionGainAuthoring.BlueprintArray>.NativeClassPtr);
        ProgressionGainAuthoring.BlueprintArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionGainAuthoring.BlueprintArray>.NativeClassPtr, 100680351);
      }

      public BlueprintArray(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [Serializable]
    public class TechDataAssetArray : ReorderableArray<TechDataAsset>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1029159, RefRangeEnd = 1029160, XrefRangeStart = 1029156, XrefRangeEnd = 1029159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TechDataAssetArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressionGainAuthoring.TechDataAssetArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProgressionGainAuthoring.TechDataAssetArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TechDataAssetArray()
      {
        Il2CppClassPointerStore<ProgressionGainAuthoring.TechDataAssetArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProgressionGainAuthoring>.NativeClassPtr, nameof (TechDataAssetArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressionGainAuthoring.TechDataAssetArray>.NativeClassPtr);
        ProgressionGainAuthoring.TechDataAssetArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionGainAuthoring.TechDataAssetArray>.NativeClassPtr, 100680352);
      }

      public TechDataAssetArray(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
