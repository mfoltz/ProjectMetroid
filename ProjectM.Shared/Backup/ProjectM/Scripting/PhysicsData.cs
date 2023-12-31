// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.PhysicsData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Physics;

#nullable disable
namespace ProjectM.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PhysicsData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_DistanceHits;
    private static readonly System.IntPtr NativeFieldInfoPtr_ColliderCastHits;
    private static readonly System.IntPtr NativeFieldInfoPtr_RaycastHits;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitResults;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowDebugCasts;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetFrameData_Public_Void_CollisionWorld_NativeList_1_DistanceHit_NativeList_1_ColliderCastHit_NativeList_1_RaycastHit_NativeList_1_HitResult_Boolean_0;
    [FieldOffset(0)]
    public CollisionWorld CollisionWorld;
    [FieldOffset(344)]
    public NativeList<DistanceHit> DistanceHits;
    [FieldOffset(360)]
    public NativeList<ColliderCastHit> ColliderCastHits;
    [FieldOffset(376)]
    public NativeList<RaycastHit> RaycastHits;
    [FieldOffset(392)]
    public NativeList<HitResult> HitResults;
    [FieldOffset(408)]
    public bool ShowDebugCasts;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 774020, RefRangeEnd = 774022, XrefRangeStart = 774020, XrefRangeEnd = 774020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetFrameData(
      CollisionWorld collisionWorld,
      NativeList<DistanceHit> distanceHits,
      NativeList<ColliderCastHit> colliderCastHits,
      NativeList<RaycastHit> raycastHits,
      NativeList<HitResult> hitResults,
      bool showDebugCasts)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &distanceHits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &colliderCastHits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &raycastHits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &hitResults;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &showDebugCasts;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PhysicsData.NativeMethodInfoPtr_SetFrameData_Public_Void_CollisionWorld_NativeList_1_DistanceHit_NativeList_1_ColliderCastHit_NativeList_1_RaycastHit_NativeList_1_HitResult_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhysicsData()
    {
      Il2CppClassPointerStore<PhysicsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (PhysicsData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsData>.NativeClassPtr);
      PhysicsData.NativeFieldInfoPtr_CollisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsData>.NativeClassPtr, nameof (CollisionWorld));
      PhysicsData.NativeFieldInfoPtr_DistanceHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsData>.NativeClassPtr, nameof (DistanceHits));
      PhysicsData.NativeFieldInfoPtr_ColliderCastHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsData>.NativeClassPtr, nameof (ColliderCastHits));
      PhysicsData.NativeFieldInfoPtr_RaycastHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsData>.NativeClassPtr, nameof (RaycastHits));
      PhysicsData.NativeFieldInfoPtr_HitResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsData>.NativeClassPtr, nameof (HitResults));
      PhysicsData.NativeFieldInfoPtr_ShowDebugCasts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsData>.NativeClassPtr, nameof (ShowDebugCasts));
      PhysicsData.NativeMethodInfoPtr_SetFrameData_Public_Void_CollisionWorld_NativeList_1_DistanceHit_NativeList_1_ColliderCastHit_NativeList_1_RaycastHit_NativeList_1_HitResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsData>.NativeClassPtr, 100668589);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhysicsData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
