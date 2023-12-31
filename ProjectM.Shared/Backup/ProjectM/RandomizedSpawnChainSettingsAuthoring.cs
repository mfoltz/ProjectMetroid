// Decompiled with JetBrains decompiler
// Type: ProjectM.RandomizedSpawnChainSettingsAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class RandomizedSpawnChainSettingsAuthoring : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Groups;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditorPreview;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe PrefabGUID PrefabGuid
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 727933, RefRangeEnd = 727935, XrefRangeStart = 727932, XrefRangeEnd = 727933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSettingsAuthoring.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727935, XrefRangeEnd = 727988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSettingsAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RandomizedSpawnChainSettingsAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSettingsAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RandomizedSpawnChainSettingsAuthoring()
    {
      Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RandomizedSpawnChainSettingsAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring>.NativeClassPtr);
      RandomizedSpawnChainSettingsAuthoring.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring>.NativeClassPtr, nameof (_Guid));
      RandomizedSpawnChainSettingsAuthoring.NativeFieldInfoPtr_Groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring>.NativeClassPtr, nameof (Groups));
      RandomizedSpawnChainSettingsAuthoring.NativeFieldInfoPtr_EditorPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring>.NativeClassPtr, nameof (EditorPreview));
      RandomizedSpawnChainSettingsAuthoring.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring>.NativeClassPtr, 100664463);
      RandomizedSpawnChainSettingsAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring>.NativeClassPtr, 100664464);
      RandomizedSpawnChainSettingsAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring>.NativeClassPtr, 100664465);
    }

    public RandomizedSpawnChainSettingsAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSettingsAuthoring.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSettingsAuthoring.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe List<RandomizedSpawnChainSettingsAuthoring.ChainGroup> Groups
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSettingsAuthoring.NativeFieldInfoPtr_Groups));
        return pointer == System.IntPtr.Zero ? (List<RandomizedSpawnChainSettingsAuthoring.ChainGroup>) null : new List<RandomizedSpawnChainSettingsAuthoring.ChainGroup>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSettingsAuthoring.NativeFieldInfoPtr_Groups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<SpawnChainAuthoring> EditorPreview
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSettingsAuthoring.NativeFieldInfoPtr_EditorPreview));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<SpawnChainAuthoring>) null : new WeakAssetReference<SpawnChainAuthoring>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSettingsAuthoring.NativeFieldInfoPtr_EditorPreview), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class Chain : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727930, XrefRangeEnd = 727931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Chain()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring.Chain>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSettingsAuthoring.Chain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Chain()
      {
        Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring.Chain>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring>.NativeClassPtr, nameof (Chain));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring.Chain>.NativeClassPtr);
        RandomizedSpawnChainSettingsAuthoring.Chain.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring.Chain>.NativeClassPtr, nameof (Prefab));
        RandomizedSpawnChainSettingsAuthoring.Chain.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring.Chain>.NativeClassPtr, nameof (Weight));
        RandomizedSpawnChainSettingsAuthoring.Chain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring.Chain>.NativeClassPtr, 100664466);
      }

      public Chain(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe WeakAssetReference<SpawnChainAuthoring> Prefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSettingsAuthoring.Chain.NativeFieldInfoPtr_Prefab));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<SpawnChainAuthoring>) null : new WeakAssetReference<SpawnChainAuthoring>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSettingsAuthoring.Chain.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float Weight
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSettingsAuthoring.Chain.NativeFieldInfoPtr_Weight));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSettingsAuthoring.Chain.NativeFieldInfoPtr_Weight)) = value;
        }
      }
    }

    [Serializable]
    public class ChainGroup : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_GroupName;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpawnChains;
      private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727931, XrefRangeEnd = 727932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ChainGroup()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring.ChainGroup>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSettingsAuthoring.ChainGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ChainGroup()
      {
        Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring.ChainGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring>.NativeClassPtr, nameof (ChainGroup));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring.ChainGroup>.NativeClassPtr);
        RandomizedSpawnChainSettingsAuthoring.ChainGroup.NativeFieldInfoPtr_GroupName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring.ChainGroup>.NativeClassPtr, nameof (GroupName));
        RandomizedSpawnChainSettingsAuthoring.ChainGroup.NativeFieldInfoPtr_SpawnChains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring.ChainGroup>.NativeClassPtr, nameof (SpawnChains));
        RandomizedSpawnChainSettingsAuthoring.ChainGroup.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring.ChainGroup>.NativeClassPtr, nameof (Weight));
        RandomizedSpawnChainSettingsAuthoring.ChainGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSettingsAuthoring.ChainGroup>.NativeClassPtr, 100664467);
      }

      public ChainGroup(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe string GroupName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSettingsAuthoring.ChainGroup.NativeFieldInfoPtr_GroupName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSettingsAuthoring.ChainGroup.NativeFieldInfoPtr_GroupName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe List<RandomizedSpawnChainSettingsAuthoring.Chain> SpawnChains
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSettingsAuthoring.ChainGroup.NativeFieldInfoPtr_SpawnChains));
          return pointer == System.IntPtr.Zero ? (List<RandomizedSpawnChainSettingsAuthoring.Chain>) null : new List<RandomizedSpawnChainSettingsAuthoring.Chain>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSettingsAuthoring.ChainGroup.NativeFieldInfoPtr_SpawnChains), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float Weight
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSettingsAuthoring.ChainGroup.NativeFieldInfoPtr_Weight));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSettingsAuthoring.ChainGroup.NativeFieldInfoPtr_Weight)) = value;
        }
      }
    }
  }
}
