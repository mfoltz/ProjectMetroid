// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.OverlappingConeJob
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
  public struct OverlappingConeJob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Hits;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitResults;
    private static readonly System.IntPtr NativeFieldInfoPtr_RaycastHits;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Direction;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_Angle;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ContextEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreSpellCollisionBlock;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowDebugCasts;
    private static readonly System.IntPtr NativeFieldInfoPtr_DebugOneShot;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public NativeList<ColliderCastHit> Hits;
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
    public float3 Direction;
    [FieldOffset(424)]
    public float Radius;
    [FieldOffset(428)]
    public float Angle;
    [FieldOffset(432)]
    public CollisionFilter CollisionFilter;
    [FieldOffset(444)]
    public Entity ContextEntity;
    [FieldOffset(452)]
    public HitFilter HitFilter;
    [FieldOffset(453)]
    public bool IgnoreSpellCollisionBlock;
    [FieldOffset(454)]
    public bool ShowDebugCasts;
    [FieldOffset(455)]
    public bool DebugOneShot;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774087, XrefRangeEnd = 774112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OverlappingConeJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OverlappingConeJob()
    {
      Il2CppClassPointerStore<OverlappingConeJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (OverlappingConeJob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverlappingConeJob>.NativeClassPtr);
      OverlappingConeJob.NativeFieldInfoPtr_Hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingConeJob>.NativeClassPtr, nameof (Hits));
      OverlappingConeJob.NativeFieldInfoPtr_HitResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingConeJob>.NativeClassPtr, nameof (HitResults));
      OverlappingConeJob.NativeFieldInfoPtr_RaycastHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingConeJob>.NativeClassPtr, nameof (RaycastHits));
      OverlappingConeJob.NativeFieldInfoPtr_CollisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingConeJob>.NativeClassPtr, nameof (CollisionWorld));
      OverlappingConeJob.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingConeJob>.NativeClassPtr, nameof (EntityManager));
      OverlappingConeJob.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingConeJob>.NativeClassPtr, nameof (Position));
      OverlappingConeJob.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingConeJob>.NativeClassPtr, nameof (Direction));
      OverlappingConeJob.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingConeJob>.NativeClassPtr, nameof (Radius));
      OverlappingConeJob.NativeFieldInfoPtr_Angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingConeJob>.NativeClassPtr, nameof (Angle));
      OverlappingConeJob.NativeFieldInfoPtr_CollisionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingConeJob>.NativeClassPtr, nameof (CollisionFilter));
      OverlappingConeJob.NativeFieldInfoPtr_ContextEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingConeJob>.NativeClassPtr, nameof (ContextEntity));
      OverlappingConeJob.NativeFieldInfoPtr_HitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingConeJob>.NativeClassPtr, nameof (HitFilter));
      OverlappingConeJob.NativeFieldInfoPtr_IgnoreSpellCollisionBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingConeJob>.NativeClassPtr, nameof (IgnoreSpellCollisionBlock));
      OverlappingConeJob.NativeFieldInfoPtr_ShowDebugCasts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingConeJob>.NativeClassPtr, nameof (ShowDebugCasts));
      OverlappingConeJob.NativeFieldInfoPtr_DebugOneShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlappingConeJob>.NativeClassPtr, nameof (DebugOneShot));
      OverlappingConeJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlappingConeJob>.NativeClassPtr, 100668593);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OverlappingConeJob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
