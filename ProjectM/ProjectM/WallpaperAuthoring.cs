// Decompiled with JetBrains decompiler
// Type: ProjectM.WallpaperAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class WallpaperAuthoring : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Styles;
    private static readonly System.IntPtr NativeFieldInfoPtr_MeshVariationPrefabs;
    private static readonly System.IntPtr NativeFieldInfoPtr_ObjectSplits;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082299, XrefRangeEnd = 1082373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(WallpaperAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082373, XrefRangeEnd = 1082378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WallpaperAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WallpaperAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WallpaperAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WallpaperAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WallpaperAuthoring()
    {
      Il2CppClassPointerStore<WallpaperAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (WallpaperAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallpaperAuthoring>.NativeClassPtr);
      WallpaperAuthoring.NativeFieldInfoPtr_Styles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperAuthoring>.NativeClassPtr, nameof (Styles));
      WallpaperAuthoring.NativeFieldInfoPtr_MeshVariationPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperAuthoring>.NativeClassPtr, nameof (MeshVariationPrefabs));
      WallpaperAuthoring.NativeFieldInfoPtr_ObjectSplits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperAuthoring>.NativeClassPtr, nameof (ObjectSplits));
      WallpaperAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperAuthoring>.NativeClassPtr, 100685242);
      WallpaperAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperAuthoring>.NativeClassPtr, 100685243);
      WallpaperAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperAuthoring>.NativeClassPtr, 100685244);
    }

    public WallpaperAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<WallpaperAuthoring.WallpaperStyle> Styles
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAuthoring.NativeFieldInfoPtr_Styles));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<WallpaperAuthoring.WallpaperStyle>) null : new Il2CppReferenceArray<WallpaperAuthoring.WallpaperStyle>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAuthoring.NativeFieldInfoPtr_Styles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<WeakAssetReference<PrefabGuidComponent>> MeshVariationPrefabs
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAuthoring.NativeFieldInfoPtr_MeshVariationPrefabs));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<WeakAssetReference<PrefabGuidComponent>>) null : new Il2CppReferenceArray<WeakAssetReference<PrefabGuidComponent>>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAuthoring.NativeFieldInfoPtr_MeshVariationPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ObjectSplits ObjectSplits
    {
      get
      {
        return *(ObjectSplits*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAuthoring.NativeFieldInfoPtr_ObjectSplits));
      }
      [param: In] set
      {
        *(ObjectSplits*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAuthoring.NativeFieldInfoPtr_ObjectSplits)) = value;
      }
    }

    [Serializable]
    public class WallpaperStyle : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ParentBlueprint;
      private static readonly System.IntPtr NativeFieldInfoPtr_StyleBlueprint;
      private static readonly System.IntPtr NativeFieldInfoPtr_MeshVariationPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_MeshVariationPrefabIndex;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe WallpaperStyle()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WallpaperAuthoring.WallpaperStyle>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WallpaperAuthoring.WallpaperStyle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static WallpaperStyle()
      {
        Il2CppClassPointerStore<WallpaperAuthoring.WallpaperStyle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WallpaperAuthoring>.NativeClassPtr, nameof (WallpaperStyle));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallpaperAuthoring.WallpaperStyle>.NativeClassPtr);
        WallpaperAuthoring.WallpaperStyle.NativeFieldInfoPtr_ParentBlueprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperAuthoring.WallpaperStyle>.NativeClassPtr, nameof (ParentBlueprint));
        WallpaperAuthoring.WallpaperStyle.NativeFieldInfoPtr_StyleBlueprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperAuthoring.WallpaperStyle>.NativeClassPtr, nameof (StyleBlueprint));
        WallpaperAuthoring.WallpaperStyle.NativeFieldInfoPtr_MeshVariationPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperAuthoring.WallpaperStyle>.NativeClassPtr, nameof (MeshVariationPrefab));
        WallpaperAuthoring.WallpaperStyle.NativeFieldInfoPtr_MeshVariationPrefabIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperAuthoring.WallpaperStyle>.NativeClassPtr, nameof (MeshVariationPrefabIndex));
        WallpaperAuthoring.WallpaperStyle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperAuthoring.WallpaperStyle>.NativeClassPtr, 100685245);
      }

      public WallpaperStyle(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe WeakAssetReference<GameObject> ParentBlueprint
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAuthoring.WallpaperStyle.NativeFieldInfoPtr_ParentBlueprint));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAuthoring.WallpaperStyle.NativeFieldInfoPtr_ParentBlueprint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe WeakAssetReference<GameObject> StyleBlueprint
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAuthoring.WallpaperStyle.NativeFieldInfoPtr_StyleBlueprint));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAuthoring.WallpaperStyle.NativeFieldInfoPtr_StyleBlueprint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe WeakAssetReference<GameObject> MeshVariationPrefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAuthoring.WallpaperStyle.NativeFieldInfoPtr_MeshVariationPrefab));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAuthoring.WallpaperStyle.NativeFieldInfoPtr_MeshVariationPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe byte MeshVariationPrefabIndex
      {
        get
        {
          return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAuthoring.WallpaperStyle.NativeFieldInfoPtr_MeshVariationPrefabIndex));
        }
        [param: In] set
        {
          *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAuthoring.WallpaperStyle.NativeFieldInfoPtr_MeshVariationPrefabIndex)) = value;
        }
      }
    }
  }
}
