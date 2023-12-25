// Decompiled with JetBrains decompiler
// Type: ProjectM.SnappingPointUtilities
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public static class SnappingPointUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindSnappingPoint_Public_Static_Boolean_EntityManager_byref_CollisionWorld_PrefabLookupMap_PrefabGUID_Ray_float3_Boolean_Single_NativeList_1_Entity_byref_ClosestSnappingPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FilterPointMatchingRotation_Private_Static_Boolean_EntityManager_SnappingPoint_Entity_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInPointPrefabsSet_Private_Static_Boolean_EntityManager_PrefabLookupMap_SnappingPoint_Entity_PrefabGUID_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1075544, RefRangeEnd = 1075547, XrefRangeStart = 1075391, XrefRangeEnd = 1075544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindSnappingPoint(
      EntityManager entityManager,
      ref CollisionWorld collisionWorld,
      PrefabLookupMap prefabLookupMap,
      PrefabGUID forBlueprintPrefab,
      ProjectM.Shared.Mathematics.Ray mouseRay,
      float3 mouseWorldPosition,
      bool requireRaycastHit,
      float rotationToMatch,
      NativeList<Entity> targetEntities,
      out SnappingPointUtilities.ClosestSnappingPoint result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &forBlueprintPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mouseRay;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &mouseWorldPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &requireRaycastHit;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &rotationToMatch;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SnappingPointUtilities.NativeMethodInfoPtr_TryFindSnappingPoint_Public_Static_Boolean_EntityManager_byref_CollisionWorld_PrefabLookupMap_PrefabGUID_Ray_float3_Boolean_Single_NativeList_1_Entity_byref_ClosestSnappingPoint_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1075555, RefRangeEnd = 1075558, XrefRangeStart = 1075547, XrefRangeEnd = 1075555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool FilterPointMatchingRotation(
      EntityManager entityManager,
      SnappingPoint point,
      Entity tileModel,
      float userRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &point;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &userRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SnappingPointUtilities.NativeMethodInfoPtr_FilterPointMatchingRotation_Private_Static_Boolean_EntityManager_SnappingPoint_Entity_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1075591, RefRangeEnd = 1075594, XrefRangeStart = 1075558, XrefRangeEnd = 1075591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsInPointPrefabsSet(
      EntityManager entityManager,
      PrefabLookupMap prefabLookupMap,
      SnappingPoint point,
      Entity pointOwnerEntity,
      PrefabGUID prefabToPlaceOrMove)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &point;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &pointOwnerEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabToPlaceOrMove;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SnappingPointUtilities.NativeMethodInfoPtr_IsInPointPrefabsSet_Private_Static_Boolean_EntityManager_PrefabLookupMap_SnappingPoint_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SnappingPointUtilities()
    {
      Il2CppClassPointerStore<SnappingPointUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SnappingPointUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnappingPointUtilities>.NativeClassPtr);
      SnappingPointUtilities.NativeMethodInfoPtr_TryFindSnappingPoint_Public_Static_Boolean_EntityManager_byref_CollisionWorld_PrefabLookupMap_PrefabGUID_Ray_float3_Boolean_Single_NativeList_1_Entity_byref_ClosestSnappingPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnappingPointUtilities>.NativeClassPtr, 100684713);
      SnappingPointUtilities.NativeMethodInfoPtr_FilterPointMatchingRotation_Private_Static_Boolean_EntityManager_SnappingPoint_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnappingPointUtilities>.NativeClassPtr, 100684714);
      SnappingPointUtilities.NativeMethodInfoPtr_IsInPointPrefabsSet_Private_Static_Boolean_EntityManager_PrefabLookupMap_SnappingPoint_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnappingPointUtilities>.NativeClassPtr, 100684715);
    }

    public SnappingPointUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ClosestSnappingPoint
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Point;
      private static readonly System.IntPtr NativeFieldInfoPtr_ParentLocalToWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_PointParentEntity;
      [FieldOffset(0)]
      public SnappingPoint Point;
      [FieldOffset(28)]
      public LocalToWorld ParentLocalToWorld;
      [FieldOffset(92)]
      public Entity PointParentEntity;

      static ClosestSnappingPoint()
      {
        Il2CppClassPointerStore<SnappingPointUtilities.ClosestSnappingPoint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SnappingPointUtilities>.NativeClassPtr, nameof (ClosestSnappingPoint));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnappingPointUtilities.ClosestSnappingPoint>.NativeClassPtr);
        SnappingPointUtilities.ClosestSnappingPoint.NativeFieldInfoPtr_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPointUtilities.ClosestSnappingPoint>.NativeClassPtr, nameof (Point));
        SnappingPointUtilities.ClosestSnappingPoint.NativeFieldInfoPtr_ParentLocalToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPointUtilities.ClosestSnappingPoint>.NativeClassPtr, nameof (ParentLocalToWorld));
        SnappingPointUtilities.ClosestSnappingPoint.NativeFieldInfoPtr_PointParentEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPointUtilities.ClosestSnappingPoint>.NativeClassPtr, nameof (PointParentEntity));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SnappingPointUtilities.ClosestSnappingPoint>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
