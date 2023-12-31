// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.RayCastJob
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
  public struct RayCastJob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Hits;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitResults;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_From;
    private static readonly System.IntPtr NativeFieldInfoPtr_To;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ContextEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreSpellCollisionBlock;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowDebugCasts;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public NativeList<RaycastHit> Hits;
    [FieldOffset(16)]
    public NativeList<HitResult> HitResults;
    [FieldOffset(32)]
    public CollisionWorld CollisionWorld;
    [FieldOffset(376)]
    public EntityManager EntityManager;
    [FieldOffset(384)]
    public float3 From;
    [FieldOffset(396)]
    public float3 To;
    [FieldOffset(408)]
    public CollisionFilter CollisionFilter;
    [FieldOffset(420)]
    public Entity ContextEntity;
    [FieldOffset(428)]
    public HitFilter HitFilter;
    [FieldOffset(429)]
    public bool IgnoreSpellCollisionBlock;
    [FieldOffset(430)]
    public bool ShowDebugCasts;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774112, XrefRangeEnd = 774160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RayCastJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RayCastJob()
    {
      Il2CppClassPointerStore<RayCastJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (RayCastJob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayCastJob>.NativeClassPtr);
      RayCastJob.NativeFieldInfoPtr_Hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayCastJob>.NativeClassPtr, nameof (Hits));
      RayCastJob.NativeFieldInfoPtr_HitResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayCastJob>.NativeClassPtr, nameof (HitResults));
      RayCastJob.NativeFieldInfoPtr_CollisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayCastJob>.NativeClassPtr, nameof (CollisionWorld));
      RayCastJob.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayCastJob>.NativeClassPtr, nameof (EntityManager));
      RayCastJob.NativeFieldInfoPtr_From = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayCastJob>.NativeClassPtr, nameof (From));
      RayCastJob.NativeFieldInfoPtr_To = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayCastJob>.NativeClassPtr, nameof (To));
      RayCastJob.NativeFieldInfoPtr_CollisionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayCastJob>.NativeClassPtr, nameof (CollisionFilter));
      RayCastJob.NativeFieldInfoPtr_ContextEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayCastJob>.NativeClassPtr, nameof (ContextEntity));
      RayCastJob.NativeFieldInfoPtr_HitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayCastJob>.NativeClassPtr, nameof (HitFilter));
      RayCastJob.NativeFieldInfoPtr_IgnoreSpellCollisionBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayCastJob>.NativeClassPtr, nameof (IgnoreSpellCollisionBlock));
      RayCastJob.NativeFieldInfoPtr_ShowDebugCasts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayCastJob>.NativeClassPtr, nameof (ShowDebugCasts));
      RayCastJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayCastJob>.NativeClassPtr, 100668594);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RayCastJob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
