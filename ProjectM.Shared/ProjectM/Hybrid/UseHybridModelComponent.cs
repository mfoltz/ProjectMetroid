// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.UseHybridModelComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Malee;
using ProjectM.ContentTesting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Hybrid
{
  public class UseHybridModelComponent : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Bounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_HybridModels;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseSkinColorCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_SkinColorCollection;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasAnyValidModel_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetReferencedHybridModels_Public_Virtual_Final_New_Void_HashSet_1_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UseHybridModelComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmosSelected()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UseHybridModelComponent.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796767, XrefRangeEnd = 796778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasAnyValidModel()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UseHybridModelComponent.NativeMethodInfoPtr_HasAnyValidModel_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796778, XrefRangeEnd = 796814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UseHybridModelComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe TestGroupFlags TestGroups
    {
      [CallerCount(21), CachedScanResults(RefRangeStart = 31081, RefRangeEnd = 31102, XrefRangeStart = 31081, XrefRangeEnd = 31102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UseHybridModelComponent.NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TestGroupFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796814, XrefRangeEnd = 796843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Test(TestContext<GameObject> context, List<ContentIssue> outIssues)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UseHybridModelComponent.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796843, XrefRangeEnd = 796860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetReferencedHybridModels(HashSet<GameObject> hybridModels)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hybridModels);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UseHybridModelComponent.NativeMethodInfoPtr_GetReferencedHybridModels_Public_Virtual_Final_New_Void_HashSet_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796860, XrefRangeEnd = 796866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UseHybridModelComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseHybridModelComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UseHybridModelComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UseHybridModelComponent()
    {
      Il2CppClassPointerStore<UseHybridModelComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Hybrid", nameof (UseHybridModelComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseHybridModelComponent>.NativeClassPtr);
      UseHybridModelComponent.NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseHybridModelComponent>.NativeClassPtr, nameof (Bounds));
      UseHybridModelComponent.NativeFieldInfoPtr_HybridModels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseHybridModelComponent>.NativeClassPtr, nameof (HybridModels));
      UseHybridModelComponent.NativeFieldInfoPtr_UseSkinColorCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseHybridModelComponent>.NativeClassPtr, nameof (UseSkinColorCollection));
      UseHybridModelComponent.NativeFieldInfoPtr_SkinColorCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseHybridModelComponent>.NativeClassPtr, nameof (SkinColorCollection));
      UseHybridModelComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseHybridModelComponent>.NativeClassPtr, 100670305);
      UseHybridModelComponent.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseHybridModelComponent>.NativeClassPtr, 100670306);
      UseHybridModelComponent.NativeMethodInfoPtr_HasAnyValidModel_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseHybridModelComponent>.NativeClassPtr, 100670307);
      UseHybridModelComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseHybridModelComponent>.NativeClassPtr, 100670308);
      UseHybridModelComponent.NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseHybridModelComponent>.NativeClassPtr, 100670309);
      UseHybridModelComponent.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseHybridModelComponent>.NativeClassPtr, 100670310);
      UseHybridModelComponent.NativeMethodInfoPtr_GetReferencedHybridModels_Public_Virtual_Final_New_Void_HashSet_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseHybridModelComponent>.NativeClassPtr, 100670311);
      UseHybridModelComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseHybridModelComponent>.NativeClassPtr, 100670312);
    }

    public UseHybridModelComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Vector3 Bounds
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseHybridModelComponent.NativeFieldInfoPtr_Bounds));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseHybridModelComponent.NativeFieldInfoPtr_Bounds)) = value;
      }
    }

    public unsafe UseHybridModelComponent.HybridModelTransformComponentArray HybridModels
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseHybridModelComponent.NativeFieldInfoPtr_HybridModels));
        return pointer == System.IntPtr.Zero ? (UseHybridModelComponent.HybridModelTransformComponentArray) null : new UseHybridModelComponent.HybridModelTransformComponentArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UseHybridModelComponent.NativeFieldInfoPtr_HybridModels), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool UseSkinColorCollection
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseHybridModelComponent.NativeFieldInfoPtr_UseSkinColorCollection));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseHybridModelComponent.NativeFieldInfoPtr_UseSkinColorCollection)) = value;
      }
    }

    public unsafe NPCServantSkinColorCollection SkinColorCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseHybridModelComponent.NativeFieldInfoPtr_SkinColorCollection));
        return pointer == System.IntPtr.Zero ? (NPCServantSkinColorCollection) null : new NPCServantSkinColorCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UseHybridModelComponent.NativeFieldInfoPtr_SkinColorCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class HybridModelTransformComponentArray : ReorderableArray<HybridModelTransformComponent>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 796755, RefRangeEnd = 796756, XrefRangeStart = 796752, XrefRangeEnd = 796755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe HybridModelTransformComponentArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseHybridModelComponent.HybridModelTransformComponentArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UseHybridModelComponent.HybridModelTransformComponentArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HybridModelTransformComponentArray()
      {
        Il2CppClassPointerStore<UseHybridModelComponent.HybridModelTransformComponentArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UseHybridModelComponent>.NativeClassPtr, nameof (HybridModelTransformComponentArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseHybridModelComponent.HybridModelTransformComponentArray>.NativeClassPtr);
        UseHybridModelComponent.HybridModelTransformComponentArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseHybridModelComponent.HybridModelTransformComponentArray>.NativeClassPtr, 100670313);
      }

      public HybridModelTransformComponentArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class HybridPreview : MonoBehaviour
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(520)]
      [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe HybridPreview()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseHybridModelComponent.HybridPreview>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UseHybridModelComponent.HybridPreview.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HybridPreview()
      {
        Il2CppClassPointerStore<UseHybridModelComponent.HybridPreview>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UseHybridModelComponent>.NativeClassPtr, nameof (HybridPreview));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseHybridModelComponent.HybridPreview>.NativeClassPtr);
        UseHybridModelComponent.HybridPreview.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseHybridModelComponent.HybridPreview>.NativeClassPtr, 100670314);
      }

      public HybridPreview(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [ObfuscatedName("ProjectM.Hybrid.UseHybridModelComponent/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__8_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetRequiredNetworked_b__8_0_Internal_Boolean_HybridModelTransformComponent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetRequiredNetworked_b__8_1_Internal_Boolean_IHybridComponent_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseHybridModelComponent.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UseHybridModelComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796756, XrefRangeEnd = 796766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _GetRequiredNetworked_b__8_0(HybridModelTransformComponent x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UseHybridModelComponent.__c.NativeMethodInfoPtr__GetRequiredNetworked_b__8_0_Internal_Boolean_HybridModelTransformComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796766, XrefRangeEnd = 796767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _GetRequiredNetworked_b__8_1(IHybridComponent c)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UseHybridModelComponent.__c.NativeMethodInfoPtr__GetRequiredNetworked_b__8_1_Internal_Boolean_IHybridComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<UseHybridModelComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UseHybridModelComponent>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseHybridModelComponent.__c>.NativeClassPtr);
        UseHybridModelComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseHybridModelComponent.__c>.NativeClassPtr, "<>9");
        UseHybridModelComponent.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseHybridModelComponent.__c>.NativeClassPtr, "<>9__8_1");
        UseHybridModelComponent.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseHybridModelComponent.__c>.NativeClassPtr, "<>9__8_0");
        UseHybridModelComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseHybridModelComponent.__c>.NativeClassPtr, 100670316);
        UseHybridModelComponent.__c.NativeMethodInfoPtr__GetRequiredNetworked_b__8_0_Internal_Boolean_HybridModelTransformComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseHybridModelComponent.__c>.NativeClassPtr, 100670317);
        UseHybridModelComponent.__c.NativeMethodInfoPtr__GetRequiredNetworked_b__8_1_Internal_Boolean_IHybridComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseHybridModelComponent.__c>.NativeClassPtr, 100670318);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe UseHybridModelComponent.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UseHybridModelComponent.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (UseHybridModelComponent.__c) null : new UseHybridModelComponent.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UseHybridModelComponent.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<IHybridComponent, bool> __9__8_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UseHybridModelComponent.__c.NativeFieldInfoPtr___9__8_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<IHybridComponent, bool>) null : new Il2CppSystem.Func<IHybridComponent, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UseHybridModelComponent.__c.NativeFieldInfoPtr___9__8_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<HybridModelTransformComponent, bool> __9__8_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UseHybridModelComponent.__c.NativeFieldInfoPtr___9__8_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<HybridModelTransformComponent, bool>) null : new Il2CppSystem.Func<HybridModelTransformComponent, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UseHybridModelComponent.__c.NativeFieldInfoPtr___9__8_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
