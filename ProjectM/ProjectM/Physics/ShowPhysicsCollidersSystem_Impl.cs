// Decompiled with JetBrains decompiler
// Type: ProjectM.Physics.ShowPhysicsCollidersSystem_Impl
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Physics;
using Unity.Physics.Authoring;

#nullable disable
namespace ProjectM.Physics
{
  public class ShowPhysicsCollidersSystem_Impl : DisplayBodyColliders.ShowPhysicsCollidersSystem
  {
    private static readonly IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly IntPtr NativeFieldInfoPtr__RaycastHits;
    private static readonly IntPtr NativeFieldInfoPtr__HighlightedEntities;
    private static readonly IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ShowPhysicsColliders_54;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_RenderDebugInfo_Private_Static_Void_CommonClientDataSystem_EntityManager_byref_CollisionWorld_byref_ShowPhysicsColliders_NativeList_1_RaycastHit_NativeList_1_HighlightedCollider_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110369, XrefRangeEnd = 1110381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowPhysicsCollidersSystem_Impl.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110381, XrefRangeEnd = 1110388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowPhysicsCollidersSystem_Impl.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110388, XrefRangeEnd = 1110412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowPhysicsCollidersSystem_Impl.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1110486, RefRangeEnd = 1110487, XrefRangeStart = 1110412, XrefRangeEnd = 1110486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RenderDebugInfo(
      CommonClientDataSystem commonClientDataSystem,
      EntityManager entityManager,
      ref CollisionWorld collisionWorld,
      [In] ref ShowPhysicsColliders showPhysicsColliders,
      NativeList<RaycastHit> raycastHits,
      NativeList<DisplayBodyColliders.ShowPhysicsCollidersSystem.HighlightedCollider> highlightEntities)
    {
      IntPtr* numPtr = stackalloc IntPtr[6];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) commonClientDataSystem);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref collisionWorld;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) ref showPhysicsColliders;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &raycastHits;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &highlightEntities;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowPhysicsCollidersSystem_Impl.NativeMethodInfoPtr_RenderDebugInfo_Private_Static_Void_CommonClientDataSystem_EntityManager_byref_CollisionWorld_byref_ShowPhysicsColliders_NativeList_1_RaycastHit_NativeList_1_HighlightedCollider_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110487, XrefRangeEnd = 1110488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ShowPhysicsCollidersSystem_Impl()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowPhysicsCollidersSystem_Impl>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowPhysicsCollidersSystem_Impl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110488, XrefRangeEnd = 1110496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowPhysicsCollidersSystem_Impl.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ShowPhysicsCollidersSystem_Impl()
    {
      Il2CppClassPointerStore<ShowPhysicsCollidersSystem_Impl>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Physics", nameof (ShowPhysicsCollidersSystem_Impl));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowPhysicsCollidersSystem_Impl>.NativeClassPtr);
      ShowPhysicsCollidersSystem_Impl.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowPhysicsCollidersSystem_Impl>.NativeClassPtr, nameof (_CommonClientDataSystem));
      ShowPhysicsCollidersSystem_Impl.NativeFieldInfoPtr__RaycastHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowPhysicsCollidersSystem_Impl>.NativeClassPtr, nameof (_RaycastHits));
      ShowPhysicsCollidersSystem_Impl.NativeFieldInfoPtr__HighlightedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowPhysicsCollidersSystem_Impl>.NativeClassPtr, nameof (_HighlightedEntities));
      ShowPhysicsCollidersSystem_Impl.NativeFieldInfoPtr__SingletonEntityQuery_ShowPhysicsColliders_54 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowPhysicsCollidersSystem_Impl>.NativeClassPtr, nameof (_SingletonEntityQuery_ShowPhysicsColliders_54));
      ShowPhysicsCollidersSystem_Impl.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowPhysicsCollidersSystem_Impl>.NativeClassPtr, 100687919);
      ShowPhysicsCollidersSystem_Impl.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowPhysicsCollidersSystem_Impl>.NativeClassPtr, 100687920);
      ShowPhysicsCollidersSystem_Impl.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowPhysicsCollidersSystem_Impl>.NativeClassPtr, 100687921);
      ShowPhysicsCollidersSystem_Impl.NativeMethodInfoPtr_RenderDebugInfo_Private_Static_Void_CommonClientDataSystem_EntityManager_byref_CollisionWorld_byref_ShowPhysicsColliders_NativeList_1_RaycastHit_NativeList_1_HighlightedCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowPhysicsCollidersSystem_Impl>.NativeClassPtr, 100687922);
      ShowPhysicsCollidersSystem_Impl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowPhysicsCollidersSystem_Impl>.NativeClassPtr, 100687923);
      ShowPhysicsCollidersSystem_Impl.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowPhysicsCollidersSystem_Impl>.NativeClassPtr, 100687924);
    }

    public ShowPhysicsCollidersSystem_Impl(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowPhysicsCollidersSystem_Impl.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowPhysicsCollidersSystem_Impl.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<RaycastHit> _RaycastHits
    {
      get
      {
        return *(NativeList<RaycastHit>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowPhysicsCollidersSystem_Impl.NativeFieldInfoPtr__RaycastHits));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowPhysicsCollidersSystem_Impl.NativeFieldInfoPtr__RaycastHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<RaycastHit>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe NativeList<DisplayBodyColliders.ShowPhysicsCollidersSystem.HighlightedCollider> _HighlightedEntities
    {
      get
      {
        return *(NativeList<DisplayBodyColliders.ShowPhysicsCollidersSystem.HighlightedCollider>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowPhysicsCollidersSystem_Impl.NativeFieldInfoPtr__HighlightedEntities));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowPhysicsCollidersSystem_Impl.NativeFieldInfoPtr__HighlightedEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DisplayBodyColliders.ShowPhysicsCollidersSystem.HighlightedCollider>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ShowPhysicsColliders_54
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowPhysicsCollidersSystem_Impl.NativeFieldInfoPtr__SingletonEntityQuery_ShowPhysicsColliders_54));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowPhysicsCollidersSystem_Impl.NativeFieldInfoPtr__SingletonEntityQuery_ShowPhysicsColliders_54)) = value;
      }
    }
  }
}
