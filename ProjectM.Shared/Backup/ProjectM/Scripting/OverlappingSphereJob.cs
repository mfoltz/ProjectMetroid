// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.OverlappingSphereJob
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;

#nullable disable
namespace ProjectM.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct OverlappingSphereJob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Hits;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitResults;
    private static readonly System.IntPtr NativeFieldInfoPtr_RaycastHits;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ContextEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreSpellCollisionBlock;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowDebugCasts;
    private static readonly System.IntPtr NativeFieldInfoPtr_DebugOneShot;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public NativeList<DistanceHit> Hits;
    [FieldOffset(16)]
    public NativeList<HitResult> HitResults;
    [FieldOffset(32)]
    public NativeList<RaycastHit> RaycastHits;
    [FieldOffset(48)]
    public CollisionWorld CollisionWorld;
    [FieldOffset(392)]
    public EntityManager EntityManager;
    [FieldOffset(400)]
    public float3 Position;
    [FieldOffset(412)]
    public float Radius;
    [FieldOffset(416)]
    public CollisionFilter CollisionFilter;
    [FieldOffset(428)]
    public Entity ContextEntity;
    [FieldOffset(436)]
    public HitFilter HitFilter;
    [FieldOffset(437)]
    public bool IgnoreSpellCollisionBlock;
    [FieldOffset(438)]
    public bool ShowDebugCasts;
    [FieldOffset(439)]
    public bool DebugOneShot;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774038, XrefRangeEnd = 774062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OverlappingSphereJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OverlappingSphereJob()
    {
      Il2CppClassPointerStore<OverlappingSphereJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (OverlappingSphereJob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverlappingSphereJob>.NativeClassPtr);
      OverlappingSphereJob.NativeFieldInfoPtr_Hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingSphereJob>.NativeClassPtr, nameof (Hits));
      OverlappingSphereJob.NativeFieldInfoPtr_HitResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingSphereJob>.NativeClassPtr, nameof (HitResults));
      OverlappingSphereJob.NativeFieldInfoPtr_RaycastHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingSphereJob>.NativeClassPtr, nameof (RaycastHits));
      OverlappingSphereJob.NativeFieldInfoPtr_CollisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingSphereJob>.NativeClassPtr, nameof (CollisionWorld));
      OverlappingSphereJob.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingSphereJob>.NativeClassPtr, nameof (EntityManager));
      OverlappingSphereJob.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingSphereJob>.NativeClassPtr, nameof (Position));
      OverlappingSphereJob.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingSphereJob>.NativeClassPtr, nameof (Radius));
      OverlappingSphereJob.NativeFieldInfoPtr_CollisionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingSphereJob>.NativeClassPtr, nameof (CollisionFilter));
      OverlappingSphereJob.NativeFieldInfoPtr_ContextEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingSphereJob>.NativeClassPtr, nameof (ContextEntity));
      OverlappingSphereJob.NativeFieldInfoPtr_HitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingSphereJob>.NativeClassPtr, nameof (HitFilter));
      OverlappingSphereJob.NativeFieldInfoPtr_IgnoreSpellCollisionBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingSphereJob>.NativeClassPtr, nameof (IgnoreSpellCollisionBlock));
      OverlappingSphereJob.NativeFieldInfoPtr_ShowDebugCasts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingSphereJob>.NativeClassPtr, nameof (ShowDebugCasts));
      OverlappingSphereJob.NativeFieldInfoPtr_DebugOneShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingSphereJob>.NativeClassPtr, nameof (DebugOneShot));
      OverlappingSphereJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlappingSphereJob>.NativeClassPtr, 100668591);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OverlappingSphereJob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
