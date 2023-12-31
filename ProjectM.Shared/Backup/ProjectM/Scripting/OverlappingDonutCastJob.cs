// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.OverlappingDonutCastJob
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
  public struct OverlappingDonutCastJob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Hits;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitResults;
    private static readonly System.IntPtr NativeFieldInfoPtr_RaycastHits;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_InnerRadius;
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
    public float InnerRadius;
    [FieldOffset(420)]
    public CollisionFilter CollisionFilter;
    [FieldOffset(432)]
    public Entity ContextEntity;
    [FieldOffset(440)]
    public HitFilter HitFilter;
    [FieldOffset(441)]
    public bool IgnoreSpellCollisionBlock;
    [FieldOffset(442)]
    public bool ShowDebugCasts;
    [FieldOffset(443)]
    public bool DebugOneShot;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774166, XrefRangeEnd = 774190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OverlappingDonutCastJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OverlappingDonutCastJob()
    {
      Il2CppClassPointerStore<OverlappingDonutCastJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (OverlappingDonutCastJob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverlappingDonutCastJob>.NativeClassPtr);
      OverlappingDonutCastJob.NativeFieldInfoPtr_Hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingDonutCastJob>.NativeClassPtr, nameof (Hits));
      OverlappingDonutCastJob.NativeFieldInfoPtr_HitResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingDonutCastJob>.NativeClassPtr, nameof (HitResults));
      OverlappingDonutCastJob.NativeFieldInfoPtr_RaycastHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingDonutCastJob>.NativeClassPtr, nameof (RaycastHits));
      OverlappingDonutCastJob.NativeFieldInfoPtr_CollisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingDonutCastJob>.NativeClassPtr, nameof (CollisionWorld));
      OverlappingDonutCastJob.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingDonutCastJob>.NativeClassPtr, nameof (EntityManager));
      OverlappingDonutCastJob.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingDonutCastJob>.NativeClassPtr, nameof (Position));
      OverlappingDonutCastJob.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingDonutCastJob>.NativeClassPtr, nameof (Radius));
      OverlappingDonutCastJob.NativeFieldInfoPtr_InnerRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingDonutCastJob>.NativeClassPtr, nameof (InnerRadius));
      OverlappingDonutCastJob.NativeFieldInfoPtr_CollisionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingDonutCastJob>.NativeClassPtr, nameof (CollisionFilter));
      OverlappingDonutCastJob.NativeFieldInfoPtr_ContextEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingDonutCastJob>.NativeClassPtr, nameof (ContextEntity));
      OverlappingDonutCastJob.NativeFieldInfoPtr_HitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingDonutCastJob>.NativeClassPtr, nameof (HitFilter));
      OverlappingDonutCastJob.NativeFieldInfoPtr_IgnoreSpellCollisionBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingDonutCastJob>.NativeClassPtr, nameof (IgnoreSpellCollisionBlock));
      OverlappingDonutCastJob.NativeFieldInfoPtr_ShowDebugCasts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingDonutCastJob>.NativeClassPtr, nameof (ShowDebugCasts));
      OverlappingDonutCastJob.NativeFieldInfoPtr_DebugOneShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingDonutCastJob>.NativeClassPtr, nameof (DebugOneShot));
      OverlappingDonutCastJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlappingDonutCastJob>.NativeClassPtr, 100668596);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OverlappingDonutCastJob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
