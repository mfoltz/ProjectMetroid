// Decompiled with JetBrains decompiler
// Type: Unity.Physics.Extensions.RagdollTestSceneBootstrap
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
using Unity.Scenes;
using UnityEngine;

#nullable disable
namespace Unity.Physics.Extensions
{
  public class RagdollTestSceneBootstrap : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_SubScene;
    private static readonly IntPtr NativeFieldInfoPtr_HybridModelPrefabs;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnKey;
    private static readonly IntPtr NativeFieldInfoPtr_NextKey;
    private static readonly IntPtr NativeFieldInfoPtr_PreviousKey;
    private static readonly IntPtr NativeFieldInfoPtr__World;
    private static readonly IntPtr NativeFieldInfoPtr__BlobAssetStore;
    private static readonly IntPtr NativeFieldInfoPtr__HybridModelPrefabEntities;
    private static readonly IntPtr NativeFieldInfoPtr__SpawnIndex;
    private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetupInitialBoneTransforms_Private_Void_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926347, XrefRangeEnd = 926359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RagdollTestSceneBootstrap.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926359, XrefRangeEnd = 926368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RagdollTestSceneBootstrap.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926368, XrefRangeEnd = 926404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupInitialBoneTransforms(Entity ragdollDriverEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &ragdollDriverEntity;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RagdollTestSceneBootstrap.NativeMethodInfoPtr_SetupInitialBoneTransforms_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926404, XrefRangeEnd = 926408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RagdollTestSceneBootstrap.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926408, XrefRangeEnd = 926409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RagdollTestSceneBootstrap()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RagdollTestSceneBootstrap>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RagdollTestSceneBootstrap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RagdollTestSceneBootstrap()
    {
      Il2CppClassPointerStore<RagdollTestSceneBootstrap>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Physics.Extensions", nameof (RagdollTestSceneBootstrap));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollTestSceneBootstrap>.NativeClassPtr);
      RagdollTestSceneBootstrap.NativeFieldInfoPtr_SubScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollTestSceneBootstrap>.NativeClassPtr, nameof (SubScene));
      RagdollTestSceneBootstrap.NativeFieldInfoPtr_HybridModelPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollTestSceneBootstrap>.NativeClassPtr, nameof (HybridModelPrefabs));
      RagdollTestSceneBootstrap.NativeFieldInfoPtr_SpawnKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollTestSceneBootstrap>.NativeClassPtr, nameof (SpawnKey));
      RagdollTestSceneBootstrap.NativeFieldInfoPtr_NextKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollTestSceneBootstrap>.NativeClassPtr, nameof (NextKey));
      RagdollTestSceneBootstrap.NativeFieldInfoPtr_PreviousKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollTestSceneBootstrap>.NativeClassPtr, nameof (PreviousKey));
      RagdollTestSceneBootstrap.NativeFieldInfoPtr__World = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollTestSceneBootstrap>.NativeClassPtr, nameof (_World));
      RagdollTestSceneBootstrap.NativeFieldInfoPtr__BlobAssetStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollTestSceneBootstrap>.NativeClassPtr, nameof (_BlobAssetStore));
      RagdollTestSceneBootstrap.NativeFieldInfoPtr__HybridModelPrefabEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollTestSceneBootstrap>.NativeClassPtr, nameof (_HybridModelPrefabEntities));
      RagdollTestSceneBootstrap.NativeFieldInfoPtr__SpawnIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollTestSceneBootstrap>.NativeClassPtr, nameof (_SpawnIndex));
      RagdollTestSceneBootstrap.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollTestSceneBootstrap>.NativeClassPtr, 100664005);
      RagdollTestSceneBootstrap.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollTestSceneBootstrap>.NativeClassPtr, 100664006);
      RagdollTestSceneBootstrap.NativeMethodInfoPtr_SetupInitialBoneTransforms_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollTestSceneBootstrap>.NativeClassPtr, 100664007);
      RagdollTestSceneBootstrap.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollTestSceneBootstrap>.NativeClassPtr, 100664008);
      RagdollTestSceneBootstrap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollTestSceneBootstrap>.NativeClassPtr, 100664009);
    }

    public RagdollTestSceneBootstrap(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SubScene SubScene
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollTestSceneBootstrap.NativeFieldInfoPtr_SubScene));
        return pointer == IntPtr.Zero ? (SubScene) null : new SubScene(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RagdollTestSceneBootstrap.NativeFieldInfoPtr_SubScene), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<GameObject> HybridModelPrefabs
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollTestSceneBootstrap.NativeFieldInfoPtr_HybridModelPrefabs));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RagdollTestSceneBootstrap.NativeFieldInfoPtr_HybridModelPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe KeyCode SpawnKey
    {
      get
      {
        return *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollTestSceneBootstrap.NativeFieldInfoPtr_SpawnKey));
      }
      [param: In] set
      {
        *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollTestSceneBootstrap.NativeFieldInfoPtr_SpawnKey)) = value;
      }
    }

    public unsafe KeyCode NextKey
    {
      get
      {
        return *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollTestSceneBootstrap.NativeFieldInfoPtr_NextKey));
      }
      [param: In] set
      {
        *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollTestSceneBootstrap.NativeFieldInfoPtr_NextKey)) = value;
      }
    }

    public unsafe KeyCode PreviousKey
    {
      get
      {
        return *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollTestSceneBootstrap.NativeFieldInfoPtr_PreviousKey));
      }
      [param: In] set
      {
        *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollTestSceneBootstrap.NativeFieldInfoPtr_PreviousKey)) = value;
      }
    }

    public unsafe World _World
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollTestSceneBootstrap.NativeFieldInfoPtr__World));
        return pointer == IntPtr.Zero ? (World) null : new World(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RagdollTestSceneBootstrap.NativeFieldInfoPtr__World), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BlobAssetStore _BlobAssetStore
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollTestSceneBootstrap.NativeFieldInfoPtr__BlobAssetStore));
        return pointer == IntPtr.Zero ? (BlobAssetStore) null : new BlobAssetStore(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RagdollTestSceneBootstrap.NativeFieldInfoPtr__BlobAssetStore), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<Entity> _HybridModelPrefabEntities
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollTestSceneBootstrap.NativeFieldInfoPtr__HybridModelPrefabEntities));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<Entity>) null : new Il2CppStructArray<Entity>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RagdollTestSceneBootstrap.NativeFieldInfoPtr__HybridModelPrefabEntities), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _SpawnIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollTestSceneBootstrap.NativeFieldInfoPtr__SpawnIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollTestSceneBootstrap.NativeFieldInfoPtr__SpawnIndex)) = value;
      }
    }
  }
}
