// Decompiled with JetBrains decompiler
// Type: ProjectM.CollisionDetection
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CollisionDetection
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GRID_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_RADIUS;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityMap;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NativeMultiHashMap_2_int2_DetectedEntity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToCell_Public_Static_int2_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OverlappingCircle_Public_NativeList_1_CastResult_float3_Single_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OverlappingCircle_Public_Boolean_float3_Single_NativeList_1_CastResult_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OverlappingCircleSortedClosestFirst_Public_NativeList_1_CastResult_float3_Single_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OverlappingCircleSortedClosestFirst_Public_Boolean_float3_Single_NativeList_1_CastResult_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsColliding_Private_Static_Boolean_float2_Single_byref_DetectedEntity_byref_Single_0;
    [FieldOffset(0)]
    public NativeMultiHashMap<int2, DetectedEntity> EntityMap;

    [CallerCount(103)]
    [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CollisionDetection(NativeMultiHashMap<int2, DetectedEntity> entityMap)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityMap;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CollisionDetection.NativeMethodInfoPtr__ctor_Public_Void_NativeMultiHashMap_2_int2_DetectedEntity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 722879, RefRangeEnd = 722882, XrefRangeStart = 722870, XrefRangeEnd = 722879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 ToCell(float3 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CollisionDetection.NativeMethodInfoPtr_ToCell_Public_Static_int2_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 722886, RefRangeEnd = 722893, XrefRangeStart = 722882, XrefRangeEnd = 722886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeList<CastResult> OverlappingCircle(
      float3 position,
      float radius,
      bool includeDead = false,
      bool ignoreOtherRadius = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &includeDead;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreOtherRadius;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CollisionDetection.NativeMethodInfoPtr_OverlappingCircle_Public_NativeList_1_CastResult_float3_Single_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<CastResult>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 722910, RefRangeEnd = 722914, XrefRangeStart = 722893, XrefRangeEnd = 722910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool OverlappingCircle(
      float3 position,
      float radius,
      NativeList<CastResult> results,
      bool includeDead = false,
      bool ignoreOtherRadius = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &results;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &includeDead;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreOtherRadius;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CollisionDetection.NativeMethodInfoPtr_OverlappingCircle_Public_Boolean_float3_Single_NativeList_1_CastResult_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 722921, RefRangeEnd = 722931, XrefRangeStart = 722914, XrefRangeEnd = 722921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeList<CastResult> OverlappingCircleSortedClosestFirst(
      float3 position,
      float radius,
      bool includeDead = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &includeDead;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CollisionDetection.NativeMethodInfoPtr_OverlappingCircleSortedClosestFirst_Public_NativeList_1_CastResult_float3_Single_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<CastResult>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 722938, RefRangeEnd = 722939, XrefRangeStart = 722931, XrefRangeEnd = 722938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool OverlappingCircleSortedClosestFirst(
      float3 position,
      float radius,
      NativeList<CastResult> results,
      bool includeDead = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &results;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &includeDead;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CollisionDetection.NativeMethodInfoPtr_OverlappingCircleSortedClosestFirst_Public_Boolean_float3_Single_NativeList_1_CastResult_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool IsColliding(
      float2 position,
      float radius,
      [In] ref DetectedEntity detectedEntity,
      out float distanceSqr)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref detectedEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref distanceSqr;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CollisionDetection.NativeMethodInfoPtr_IsColliding_Private_Static_Boolean_float2_Single_byref_DetectedEntity_byref_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CollisionDetection()
    {
      Il2CppClassPointerStore<CollisionDetection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CollisionDetection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollisionDetection>.NativeClassPtr);
      CollisionDetection.NativeFieldInfoPtr_GRID_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionDetection>.NativeClassPtr, nameof (GRID_SIZE));
      CollisionDetection.NativeFieldInfoPtr_MAX_RADIUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionDetection>.NativeClassPtr, nameof (MAX_RADIUS));
      CollisionDetection.NativeFieldInfoPtr_EntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionDetection>.NativeClassPtr, nameof (EntityMap));
      CollisionDetection.NativeMethodInfoPtr__ctor_Public_Void_NativeMultiHashMap_2_int2_DetectedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetection>.NativeClassPtr, 100663858);
      CollisionDetection.NativeMethodInfoPtr_ToCell_Public_Static_int2_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetection>.NativeClassPtr, 100663859);
      CollisionDetection.NativeMethodInfoPtr_OverlappingCircle_Public_NativeList_1_CastResult_float3_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetection>.NativeClassPtr, 100663860);
      CollisionDetection.NativeMethodInfoPtr_OverlappingCircle_Public_Boolean_float3_Single_NativeList_1_CastResult_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetection>.NativeClassPtr, 100663861);
      CollisionDetection.NativeMethodInfoPtr_OverlappingCircleSortedClosestFirst_Public_NativeList_1_CastResult_float3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetection>.NativeClassPtr, 100663862);
      CollisionDetection.NativeMethodInfoPtr_OverlappingCircleSortedClosestFirst_Public_Boolean_float3_Single_NativeList_1_CastResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetection>.NativeClassPtr, 100663863);
      CollisionDetection.NativeMethodInfoPtr_IsColliding_Private_Static_Boolean_float2_Single_byref_DetectedEntity_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetection>.NativeClassPtr, 100663864);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CollisionDetection>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int GRID_SIZE
    {
      get
      {
        int gridSize;
        IL2CPP.il2cpp_field_static_get_value(CollisionDetection.NativeFieldInfoPtr_GRID_SIZE, (void*) &gridSize);
        return gridSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CollisionDetection.NativeFieldInfoPtr_GRID_SIZE, (void*) &value);
      }
    }

    public static unsafe int MAX_RADIUS
    {
      get
      {
        int maxRadius;
        IL2CPP.il2cpp_field_static_get_value(CollisionDetection.NativeFieldInfoPtr_MAX_RADIUS, (void*) &maxRadius);
        return maxRadius;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CollisionDetection.NativeFieldInfoPtr_MAX_RADIUS, (void*) &value);
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SortResultByDistance
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_CastResult_CastResult_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722869, XrefRangeEnd = 722870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int Compare(CastResult x, CastResult y)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CollisionDetection.SortResultByDistance.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_CastResult_CastResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static SortResultByDistance()
      {
        Il2CppClassPointerStore<CollisionDetection.SortResultByDistance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CollisionDetection>.NativeClassPtr, nameof (SortResultByDistance));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollisionDetection.SortResultByDistance>.NativeClassPtr);
        CollisionDetection.SortResultByDistance.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_CastResult_CastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetection.SortResultByDistance>.NativeClassPtr, 100663865);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CollisionDetection.SortResultByDistance>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
