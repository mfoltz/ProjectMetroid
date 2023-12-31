// Decompiled with JetBrains decompiler
// Type: ProjectM.PrefabGizmoDrawer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class PrefabGizmoDrawer : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PreviewWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr__PreviewEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__PreviewOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr__Prefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__Cache;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsInPrefabIsolationMode;
    private static readonly System.IntPtr NativeFieldInfoPtr__InPrefabPreviewForOtherTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr__InPrefabStageForThisTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr__HasWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr__HasEntityPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentTransformLocalToWorld;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsInPrefabIsolationMode_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_InPrefabPreviewForOtherTarget_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_InPrefabStageForThisTarget_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Prefab_Public_get_PrefabGuidComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Prefab_Public_set_Void_PrefabGuidComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetEntityPreview_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Step1_StageState_Public_Void_GameObject_Transform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Step2_Public_Void_Transform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RecalculateGizmoPositions_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateGizmoCache_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Public_Void_Transform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsNaN_Private_Boolean_Quaternion_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Public_Void_Transform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetWorld_Private_Boolean_byref_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool IsInPrefabIsolationMode
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabGizmoDrawer.NativeMethodInfoPtr_get_IsInPrefabIsolationMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool InPrefabPreviewForOtherTarget
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabGizmoDrawer.NativeMethodInfoPtr_get_InPrefabPreviewForOtherTarget_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool InPrefabStageForThisTarget
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabGizmoDrawer.NativeMethodInfoPtr_get_InPrefabStageForThisTarget_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe PrefabGuidComponent Prefab
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 22440, RefRangeEnd = 22452, XrefRangeStart = 22440, XrefRangeEnd = 22452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabGizmoDrawer.NativeMethodInfoPtr_get_Prefab_Public_get_PrefabGuidComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 727807, RefRangeEnd = 727809, XrefRangeStart = 727801, XrefRangeEnd = 727807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabGizmoDrawer.NativeMethodInfoPtr_set_Prefab_Public_set_Void_PrefabGuidComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 727815, RefRangeEnd = 727817, XrefRangeStart = 727809, XrefRangeEnd = 727815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetEntityPreview()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabGizmoDrawer.NativeMethodInfoPtr_ResetEntityPreview_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update_Step1_StageState(GameObject previewOwner, Transform transform)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) previewOwner);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabGizmoDrawer.NativeMethodInfoPtr_Update_Step1_StageState_Public_Void_GameObject_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727817, XrefRangeEnd = 727831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update_Step2(Transform transform)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabGizmoDrawer.NativeMethodInfoPtr_Update_Step2_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 727858, RefRangeEnd = 727860, XrefRangeStart = 727831, XrefRangeEnd = 727858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RecalculateGizmoPositions()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabGizmoDrawer.NativeMethodInfoPtr_RecalculateGizmoPositions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727860, XrefRangeEnd = 727889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateGizmoCache()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabGizmoDrawer.NativeMethodInfoPtr_UpdateGizmoCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 727891, RefRangeEnd = 727892, XrefRangeStart = 727889, XrefRangeEnd = 727891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabGizmoDrawer.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmos(Transform transform)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabGizmoDrawer.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727892, XrefRangeEnd = 727896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsNaN(Quaternion q)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &q;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabGizmoDrawer.NativeMethodInfoPtr_IsNaN_Private_Boolean_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmosSelected(Transform transform)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabGizmoDrawer.NativeMethodInfoPtr_OnDrawGizmosSelected_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727896, XrefRangeEnd = 727900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetWorld(out World world)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabGizmoDrawer.NativeMethodInfoPtr_TryGetWorld_Private_Boolean_byref_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref World local = ref world;
      System.IntPtr pointer = zero;
      World world1 = pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
      local = world1;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 727908, RefRangeEnd = 727909, XrefRangeStart = 727900, XrefRangeEnd = 727908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGizmoDrawer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabGizmoDrawer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PrefabGizmoDrawer()
    {
      Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PrefabGizmoDrawer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr);
      PrefabGizmoDrawer.NativeFieldInfoPtr__PreviewWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, nameof (_PreviewWorld));
      PrefabGizmoDrawer.NativeFieldInfoPtr__PreviewEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, nameof (_PreviewEntity));
      PrefabGizmoDrawer.NativeFieldInfoPtr__PreviewOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, nameof (_PreviewOwner));
      PrefabGizmoDrawer.NativeFieldInfoPtr__Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, nameof (_Prefab));
      PrefabGizmoDrawer.NativeFieldInfoPtr__Cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, nameof (_Cache));
      PrefabGizmoDrawer.NativeFieldInfoPtr__IsInPrefabIsolationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, nameof (_IsInPrefabIsolationMode));
      PrefabGizmoDrawer.NativeFieldInfoPtr__InPrefabPreviewForOtherTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, nameof (_InPrefabPreviewForOtherTarget));
      PrefabGizmoDrawer.NativeFieldInfoPtr__InPrefabStageForThisTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, nameof (_InPrefabStageForThisTarget));
      PrefabGizmoDrawer.NativeFieldInfoPtr__HasWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, nameof (_HasWorld));
      PrefabGizmoDrawer.NativeFieldInfoPtr__HasEntityPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, nameof (_HasEntityPrefab));
      PrefabGizmoDrawer.NativeFieldInfoPtr__CurrentTransformLocalToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, nameof (_CurrentTransformLocalToWorld));
      PrefabGizmoDrawer.NativeMethodInfoPtr_get_IsInPrefabIsolationMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, 100664442);
      PrefabGizmoDrawer.NativeMethodInfoPtr_get_InPrefabPreviewForOtherTarget_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, 100664443);
      PrefabGizmoDrawer.NativeMethodInfoPtr_get_InPrefabStageForThisTarget_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, 100664444);
      PrefabGizmoDrawer.NativeMethodInfoPtr_get_Prefab_Public_get_PrefabGuidComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, 100664445);
      PrefabGizmoDrawer.NativeMethodInfoPtr_set_Prefab_Public_set_Void_PrefabGuidComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, 100664446);
      PrefabGizmoDrawer.NativeMethodInfoPtr_ResetEntityPreview_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, 100664447);
      PrefabGizmoDrawer.NativeMethodInfoPtr_Update_Step1_StageState_Public_Void_GameObject_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, 100664448);
      PrefabGizmoDrawer.NativeMethodInfoPtr_Update_Step2_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, 100664449);
      PrefabGizmoDrawer.NativeMethodInfoPtr_RecalculateGizmoPositions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, 100664450);
      PrefabGizmoDrawer.NativeMethodInfoPtr_UpdateGizmoCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, 100664451);
      PrefabGizmoDrawer.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, 100664452);
      PrefabGizmoDrawer.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, 100664453);
      PrefabGizmoDrawer.NativeMethodInfoPtr_IsNaN_Private_Boolean_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, 100664454);
      PrefabGizmoDrawer.NativeMethodInfoPtr_OnDrawGizmosSelected_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, 100664455);
      PrefabGizmoDrawer.NativeMethodInfoPtr_TryGetWorld_Private_Boolean_byref_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, 100664456);
      PrefabGizmoDrawer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, 100664457);
    }

    public PrefabGizmoDrawer(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe World _PreviewWorld
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__PreviewWorld));
        return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__PreviewWorld), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _PreviewEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__PreviewEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__PreviewEntity)) = value;
      }
    }

    public unsafe GameObject _PreviewOwner
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__PreviewOwner));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__PreviewOwner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent _Prefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__Prefab));
        return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__Prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<PrefabGizmoDrawer.CachedGizmo> _Cache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__Cache));
        return pointer == System.IntPtr.Zero ? (List<PrefabGizmoDrawer.CachedGizmo>) null : new List<PrefabGizmoDrawer.CachedGizmo>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__Cache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _IsInPrefabIsolationMode
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__IsInPrefabIsolationMode));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__IsInPrefabIsolationMode)) = value;
      }
    }

    public unsafe bool _InPrefabPreviewForOtherTarget
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__InPrefabPreviewForOtherTarget));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__InPrefabPreviewForOtherTarget)) = value;
      }
    }

    public unsafe bool _InPrefabStageForThisTarget
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__InPrefabStageForThisTarget));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__InPrefabStageForThisTarget)) = value;
      }
    }

    public unsafe bool _HasWorld
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__HasWorld));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__HasWorld)) = value;
      }
    }

    public unsafe bool _HasEntityPrefab
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__HasEntityPrefab));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__HasEntityPrefab)) = value;
      }
    }

    public unsafe Matrix4x4 _CurrentTransformLocalToWorld
    {
      get
      {
        return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__CurrentTransformLocalToWorld));
      }
      [param: In] set
      {
        *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.NativeFieldInfoPtr__CurrentTransformLocalToWorld)) = value;
      }
    }

    public class CachedGizmo : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MeshFilter;
      private static readonly System.IntPtr NativeFieldInfoPtr_pos;
      private static readonly System.IntPtr NativeFieldInfoPtr_rot;
      private static readonly System.IntPtr NativeFieldInfoPtr_scale;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CachedGizmo()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabGizmoDrawer.CachedGizmo>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabGizmoDrawer.CachedGizmo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CachedGizmo()
      {
        Il2CppClassPointerStore<PrefabGizmoDrawer.CachedGizmo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabGizmoDrawer>.NativeClassPtr, nameof (CachedGizmo));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabGizmoDrawer.CachedGizmo>.NativeClassPtr);
        PrefabGizmoDrawer.CachedGizmo.NativeFieldInfoPtr_MeshFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabGizmoDrawer.CachedGizmo>.NativeClassPtr, nameof (MeshFilter));
        PrefabGizmoDrawer.CachedGizmo.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabGizmoDrawer.CachedGizmo>.NativeClassPtr, nameof (pos));
        PrefabGizmoDrawer.CachedGizmo.NativeFieldInfoPtr_rot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabGizmoDrawer.CachedGizmo>.NativeClassPtr, nameof (rot));
        PrefabGizmoDrawer.CachedGizmo.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabGizmoDrawer.CachedGizmo>.NativeClassPtr, nameof (scale));
        PrefabGizmoDrawer.CachedGizmo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabGizmoDrawer.CachedGizmo>.NativeClassPtr, 100664458);
      }

      public CachedGizmo(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe MeshFilter MeshFilter
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.CachedGizmo.NativeFieldInfoPtr_MeshFilter));
          return pointer == System.IntPtr.Zero ? (MeshFilter) null : new MeshFilter(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.CachedGizmo.NativeFieldInfoPtr_MeshFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Vector3 pos
      {
        get
        {
          return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.CachedGizmo.NativeFieldInfoPtr_pos));
        }
        [param: In] set
        {
          *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.CachedGizmo.NativeFieldInfoPtr_pos)) = value;
        }
      }

      public unsafe Quaternion rot
      {
        get
        {
          return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.CachedGizmo.NativeFieldInfoPtr_rot));
        }
        [param: In] set
        {
          *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.CachedGizmo.NativeFieldInfoPtr_rot)) = value;
        }
      }

      public unsafe Vector3 scale
      {
        get
        {
          return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.CachedGizmo.NativeFieldInfoPtr_scale));
        }
        [param: In] set
        {
          *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabGizmoDrawer.CachedGizmo.NativeFieldInfoPtr_scale)) = value;
        }
      }
    }
  }
}
