// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.SpawnPointUtilities
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Terrain
{
  public static class SpawnPointUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_FillAndSpreadOutPointsAroundCenter_Public_Static_Void_NativeArray_1_float3_float3_Single_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 767105, RefRangeEnd = 767106, XrefRangeStart = 767090, XrefRangeEnd = 767105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FillAndSpreadOutPointsAroundCenter(
      NativeArray<float3> points,
      float3 center,
      float pointRadius)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &points;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &center;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pointRadius;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnPointUtilities.NativeMethodInfoPtr_FillAndSpreadOutPointsAroundCenter_Public_Static_Void_NativeArray_1_float3_float3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpawnPointUtilities()
    {
      Il2CppClassPointerStore<SpawnPointUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (SpawnPointUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnPointUtilities>.NativeClassPtr);
      SpawnPointUtilities.NativeMethodInfoPtr_FillAndSpreadOutPointsAroundCenter_Public_Static_Void_NativeArray_1_float3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnPointUtilities>.NativeClassPtr, 100667846);
    }

    public SpawnPointUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
