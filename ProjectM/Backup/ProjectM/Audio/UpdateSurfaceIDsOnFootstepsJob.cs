// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.UpdateSurfaceIDsOnFootstepsJob
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;

#nullable disable
namespace ProjectM.Audio
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UpdateSurfaceIDsOnFootstepsJob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunkLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetFootstepSurfaceOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetSurfaceTypeElement;
    private static readonly System.IntPtr NativeFieldInfoPtr_Surfaces;
    private static readonly System.IntPtr NativeFieldInfoPtr_FootstepEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpRay;
    private static readonly System.IntPtr NativeFieldInfoPtr_DownRay;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;
    [FieldOffset(0)]
    public CollisionWorld CollisionWorld;
    [FieldOffset(344)]
    public TerrainChunkLookup TerrainChunkLookup;
    [FieldOffset(360)]
    public ComponentDataFromEntity<FootstepSurfaceOverride> GetFootstepSurfaceOverride;
    [FieldOffset(392)]
    public BufferFromEntity<SurfaceTypeElement> GetSurfaceTypeElement;
    [FieldOffset(432)]
    public NativeArray<ChunkSurfaceData> Surfaces;
    [FieldOffset(448)]
    public NativeArray<FootstepEvent> FootstepEvents;
    [FieldOffset(464)]
    public float3 UpRay;
    [FieldOffset(476)]
    public float3 DownRay;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1140942, RefRangeEnd = 1140943, XrefRangeStart = 1140916, XrefRangeEnd = 1140942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute(int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateSurfaceIDsOnFootstepsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UpdateSurfaceIDsOnFootstepsJob()
    {
      Il2CppClassPointerStore<UpdateSurfaceIDsOnFootstepsJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (UpdateSurfaceIDsOnFootstepsJob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateSurfaceIDsOnFootstepsJob>.NativeClassPtr);
      UpdateSurfaceIDsOnFootstepsJob.NativeFieldInfoPtr_CollisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSurfaceIDsOnFootstepsJob>.NativeClassPtr, nameof (CollisionWorld));
      UpdateSurfaceIDsOnFootstepsJob.NativeFieldInfoPtr_TerrainChunkLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSurfaceIDsOnFootstepsJob>.NativeClassPtr, nameof (TerrainChunkLookup));
      UpdateSurfaceIDsOnFootstepsJob.NativeFieldInfoPtr_GetFootstepSurfaceOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSurfaceIDsOnFootstepsJob>.NativeClassPtr, nameof (GetFootstepSurfaceOverride));
      UpdateSurfaceIDsOnFootstepsJob.NativeFieldInfoPtr_GetSurfaceTypeElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSurfaceIDsOnFootstepsJob>.NativeClassPtr, nameof (GetSurfaceTypeElement));
      UpdateSurfaceIDsOnFootstepsJob.NativeFieldInfoPtr_Surfaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSurfaceIDsOnFootstepsJob>.NativeClassPtr, nameof (Surfaces));
      UpdateSurfaceIDsOnFootstepsJob.NativeFieldInfoPtr_FootstepEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSurfaceIDsOnFootstepsJob>.NativeClassPtr, nameof (FootstepEvents));
      UpdateSurfaceIDsOnFootstepsJob.NativeFieldInfoPtr_UpRay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSurfaceIDsOnFootstepsJob>.NativeClassPtr, nameof (UpRay));
      UpdateSurfaceIDsOnFootstepsJob.NativeFieldInfoPtr_DownRay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSurfaceIDsOnFootstepsJob>.NativeClassPtr, nameof (DownRay));
      UpdateSurfaceIDsOnFootstepsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSurfaceIDsOnFootstepsJob>.NativeClassPtr, 100690264);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateSurfaceIDsOnFootstepsJob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
