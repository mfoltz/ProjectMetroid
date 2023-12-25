// Decompiled with JetBrains decompiler
// Type: ProjectM.SunUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Physics;
using Unity.Mathematics;
using Unity.Physics;

#nullable disable
namespace ProjectM
{
  public static class SunUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPos_Public_Static_float3_float3_Sun_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RaycastTo_Public_Static_Boolean_float3_Sun_byref_CollisionWorld_CollisionFilterFlags_byref_RaycastHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRay_Public_Static_RaycastInput_float3_Sun_CollisionFilterFlags_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1024968, RefRangeEnd = 1024971, XrefRangeStart = 1024957, XrefRangeEnd = 1024968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float3 GetPos(float3 relativeTo, Sun sun)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &relativeTo;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sun;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SunUtility.NativeMethodInfoPtr_GetPos_Public_Static_float3_float3_Sun_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1024980, RefRangeEnd = 1024982, XrefRangeStart = 1024971, XrefRangeEnd = 1024980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool RaycastTo(
      float3 pos,
      Sun sun,
      ref CollisionWorld collisionWorld,
      CollisionFilterFlags collidesWith,
      out RaycastHit result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sun;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesWith;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SunUtility.NativeMethodInfoPtr_RaycastTo_Public_Static_Boolean_float3_Sun_byref_CollisionWorld_CollisionFilterFlags_byref_RaycastHit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024982, XrefRangeEnd = 1024987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RaycastInput GetRay(
      float3 pos,
      Sun sun,
      CollisionFilterFlags collidesWith)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sun;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesWith;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SunUtility.NativeMethodInfoPtr_GetRay_Public_Static_RaycastInput_float3_Sun_CollisionFilterFlags_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RaycastInput*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SunUtility()
    {
      Il2CppClassPointerStore<SunUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SunUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SunUtility>.NativeClassPtr);
      SunUtility.NativeMethodInfoPtr_GetPos_Public_Static_float3_float3_Sun_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunUtility>.NativeClassPtr, 100680076);
      SunUtility.NativeMethodInfoPtr_RaycastTo_Public_Static_Boolean_float3_Sun_byref_CollisionWorld_CollisionFilterFlags_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunUtility>.NativeClassPtr, 100680077);
      SunUtility.NativeMethodInfoPtr_GetRay_Public_Static_RaycastInput_float3_Sun_CollisionFilterFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunUtility>.NativeClassPtr, 100680078);
    }

    public SunUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
