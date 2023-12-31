// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.SphereCastJob
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
  public struct SphereCastJob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Hits;
    private static readonly System.IntPtr NativeFieldInfoPtr_RaycastHits;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_From;
    private static readonly System.IntPtr NativeFieldInfoPtr_To;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreSpellCollisionBlock;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowDebugCasts;
    private static readonly System.IntPtr NativeFieldInfoPtr_DebugOneShot;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public NativeList<ColliderCastHit> Hits;
    [FieldOffset(16)]
    public NativeList<RaycastHit> RaycastHits;
    [FieldOffset(32)]
    public CollisionWorld CollisionWorld;
    [FieldOffset(376)]
    public EntityManager EntityManager;
    [FieldOffset(384)]
    public float3 From;
    [FieldOffset(396)]
    public float3 To;
    [FieldOffset(408)]
    public float Radius;
    [FieldOffset(412)]
    public CollisionFilter CollisionFilter;
    [FieldOffset(424)]
    public bool IgnoreSpellCollisionBlock;
    [FieldOffset(425)]
    public bool ShowDebugCasts;
    [FieldOffset(426)]
    public bool DebugOneShot;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774022, XrefRangeEnd = 774038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SphereCastJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SphereCastJob()
    {
      Il2CppClassPointerStore<SphereCastJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (SphereCastJob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphereCastJob>.NativeClassPtr);
      SphereCastJob.NativeFieldInfoPtr_Hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereCastJob>.NativeClassPtr, nameof (Hits));
      SphereCastJob.NativeFieldInfoPtr_RaycastHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereCastJob>.NativeClassPtr, nameof (RaycastHits));
      SphereCastJob.NativeFieldInfoPtr_CollisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereCastJob>.NativeClassPtr, nameof (CollisionWorld));
      SphereCastJob.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereCastJob>.NativeClassPtr, nameof (EntityManager));
      SphereCastJob.NativeFieldInfoPtr_From = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereCastJob>.NativeClassPtr, nameof (From));
      SphereCastJob.NativeFieldInfoPtr_To = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereCastJob>.NativeClassPtr, nameof (To));
      SphereCastJob.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereCastJob>.NativeClassPtr, nameof (Radius));
      SphereCastJob.NativeFieldInfoPtr_CollisionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereCastJob>.NativeClassPtr, nameof (CollisionFilter));
      SphereCastJob.NativeFieldInfoPtr_IgnoreSpellCollisionBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereCastJob>.NativeClassPtr, nameof (IgnoreSpellCollisionBlock));
      SphereCastJob.NativeFieldInfoPtr_ShowDebugCasts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereCastJob>.NativeClassPtr, nameof (ShowDebugCasts));
      SphereCastJob.NativeFieldInfoPtr_DebugOneShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereCastJob>.NativeClassPtr, nameof (DebugOneShot));
      SphereCastJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereCastJob>.NativeClassPtr, 100668590);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SphereCastJob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
