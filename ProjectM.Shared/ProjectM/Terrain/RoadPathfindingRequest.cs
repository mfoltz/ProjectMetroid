// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.RoadPathfindingRequest
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RoadPathfindingRequest
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_End;
    private static readonly System.IntPtr NativeFieldInfoPtr_Status;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeightSettingOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_SolverResult;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_RoadPathfindingRequest_Entity_BusStopId_BusStopId_0;
    [FieldOffset(0)]
    public BusStopId Start;
    [FieldOffset(24)]
    public BusStopId End;
    [FieldOffset(48)]
    public RoadPathRequestStatus Status;
    [FieldOffset(52)]
    public Entity WeightSettingOwner;
    [FieldOffset(60)]
    public RoadPathfinding.SolverResult SolverResult;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 768644, RefRangeEnd = 768645, XrefRangeStart = 768644, XrefRangeEnd = 768644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RoadPathfindingRequest Create(
      Entity weightSettingOwner,
      BusStopId start,
      BusStopId end)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &weightSettingOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoadPathfindingRequest.NativeMethodInfoPtr_Create_Public_Static_RoadPathfindingRequest_Entity_BusStopId_BusStopId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RoadPathfindingRequest*) IL2CPP.il2cpp_object_unbox(num);
    }

    static RoadPathfindingRequest()
    {
      Il2CppClassPointerStore<RoadPathfindingRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (RoadPathfindingRequest));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadPathfindingRequest>.NativeClassPtr);
      RoadPathfindingRequest.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPathfindingRequest>.NativeClassPtr, nameof (Start));
      RoadPathfindingRequest.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPathfindingRequest>.NativeClassPtr, nameof (End));
      RoadPathfindingRequest.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPathfindingRequest>.NativeClassPtr, nameof (Status));
      RoadPathfindingRequest.NativeFieldInfoPtr_WeightSettingOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPathfindingRequest>.NativeClassPtr, nameof (WeightSettingOwner));
      RoadPathfindingRequest.NativeFieldInfoPtr_SolverResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPathfindingRequest>.NativeClassPtr, nameof (SolverResult));
      RoadPathfindingRequest.NativeMethodInfoPtr_Create_Public_Static_RoadPathfindingRequest_Entity_BusStopId_BusStopId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadPathfindingRequest>.NativeClassPtr, 100668000);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoadPathfindingRequest>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
