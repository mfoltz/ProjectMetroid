// Decompiled with JetBrains decompiler
// Type: ProjectM.ColliderPicking
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Physics.Authoring;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public static class ColliderPicking : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_CompareColliders_Public_Static_Boolean_BlobAssetReference_1_Collider_Translation_ChildCollider_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ComparePolygonColliders_Private_Static_Boolean_PolygonCollider_PolygonCollider_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AlmostEquals_Private_Static_Boolean_float3_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AlmostEquals_Private_Static_Boolean_float4_float4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryCreateColliderBlob_Public_Static_Boolean_PhysicsShapeAuthoring_byref_BlobAssetReference_1_Collider_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterial_Private_Static_Material_PhysicsShapeAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPlanePoints_Private_Static_Void_float3_float2_quaternion_byref_float3_byref_float3_byref_float3_byref_float3_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 742635, RefRangeEnd = 742636, XrefRangeStart = 742614, XrefRangeEnd = 742635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CompareColliders(
      BlobAssetReference<Collider> blobColliderA,
      Translation colliderTranslationA,
      ChildCollider childColliderB)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &blobColliderA;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &colliderTranslationA;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &childColliderB;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColliderPicking.NativeMethodInfoPtr_CompareColliders_Public_Static_Boolean_BlobAssetReference_1_Collider_Translation_ChildCollider_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 742661, RefRangeEnd = 742662, XrefRangeStart = 742636, XrefRangeEnd = 742661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ComparePolygonColliders(
      PolygonCollider colliderA,
      PolygonCollider colliderB)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &colliderA;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &colliderB;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColliderPicking.NativeMethodInfoPtr_ComparePolygonColliders_Private_Static_Boolean_PolygonCollider_PolygonCollider_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool AlmostEquals(float3 valueA, float3 valueB)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &valueA;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &valueB;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColliderPicking.NativeMethodInfoPtr_AlmostEquals_Private_Static_Boolean_float3_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool AlmostEquals(float4 valueA, float4 valueB)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &valueA;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &valueB;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColliderPicking.NativeMethodInfoPtr_AlmostEquals_Private_Static_Boolean_float4_float4_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 742662, RefRangeEnd = 742663, XrefRangeStart = 742662, XrefRangeEnd = 742662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryCreateColliderBlob(
      PhysicsShapeAuthoring physicsShape,
      out BlobAssetReference<Collider> collider)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) physicsShape);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collider;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColliderPicking.NativeMethodInfoPtr_TryCreateColliderBlob_Public_Static_Boolean_PhysicsShapeAuthoring_byref_BlobAssetReference_1_Collider_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742663, XrefRangeEnd = 742673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Material GetMaterial(PhysicsShapeAuthoring shape)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shape);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColliderPicking.NativeMethodInfoPtr_GetMaterial_Private_Static_Material_PhysicsShapeAuthoring_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Material*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742673, XrefRangeEnd = 742674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetPlanePoints(
      float3 center,
      float2 size,
      quaternion orientation,
      out float3 vertex0,
      out float3 vertex1,
      out float3 vertex2,
      out float3 vertex3)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &center;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &orientation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref vertex0;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref vertex1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref vertex2;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref vertex3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ColliderPicking.NativeMethodInfoPtr_GetPlanePoints_Private_Static_Void_float3_float2_quaternion_byref_float3_byref_float3_byref_float3_byref_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ColliderPicking()
    {
      Il2CppClassPointerStore<ColliderPicking>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ColliderPicking));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColliderPicking>.NativeClassPtr);
      ColliderPicking.NativeMethodInfoPtr_CompareColliders_Public_Static_Boolean_BlobAssetReference_1_Collider_Translation_ChildCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderPicking>.NativeClassPtr, 100665478);
      ColliderPicking.NativeMethodInfoPtr_ComparePolygonColliders_Private_Static_Boolean_PolygonCollider_PolygonCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderPicking>.NativeClassPtr, 100665479);
      ColliderPicking.NativeMethodInfoPtr_AlmostEquals_Private_Static_Boolean_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderPicking>.NativeClassPtr, 100665480);
      ColliderPicking.NativeMethodInfoPtr_AlmostEquals_Private_Static_Boolean_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderPicking>.NativeClassPtr, 100665481);
      ColliderPicking.NativeMethodInfoPtr_TryCreateColliderBlob_Public_Static_Boolean_PhysicsShapeAuthoring_byref_BlobAssetReference_1_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderPicking>.NativeClassPtr, 100665482);
      ColliderPicking.NativeMethodInfoPtr_GetMaterial_Private_Static_Material_PhysicsShapeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderPicking>.NativeClassPtr, 100665483);
      ColliderPicking.NativeMethodInfoPtr_GetPlanePoints_Private_Static_Void_float3_float2_quaternion_byref_float3_byref_float3_byref_float3_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderPicking>.NativeClassPtr, 100665484);
    }

    public ColliderPicking(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
