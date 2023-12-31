// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.BoxCastJob
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
  public struct BoxCastJob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Hits;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitResults;
    private static readonly System.IntPtr NativeFieldInfoPtr_RaycastHits;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_From;
    private static readonly System.IntPtr NativeFieldInfoPtr_To;
    private static readonly System.IntPtr NativeFieldInfoPtr_Size;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ContextEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetY;
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
    public float3 From;
    [FieldOffset(412)]
    public float3 To;
    [FieldOffset(424)]
    public float3 Size;
    [FieldOffset(436)]
    public quaternion Rotation;
    [FieldOffset(452)]
    public CollisionFilter CollisionFilter;
    [FieldOffset(464)]
    public Entity ContextEntity;
    [FieldOffset(472)]
    public HitFilter HitFilter;
    [FieldOffset(476)]
    public float OffsetY;
    [FieldOffset(480)]
    public bool IgnoreSpellCollisionBlock;
    [FieldOffset(481)]
    public bool ShowDebugCasts;
    [FieldOffset(482)]
    public bool DebugOneShot;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774062, XrefRangeEnd = 774087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BoxCastJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BoxCastJob()
    {
      Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (BoxCastJob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr);
      BoxCastJob.NativeFieldInfoPtr_Hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr, nameof (Hits));
      BoxCastJob.NativeFieldInfoPtr_HitResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr, nameof (HitResults));
      BoxCastJob.NativeFieldInfoPtr_RaycastHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr, nameof (RaycastHits));
      BoxCastJob.NativeFieldInfoPtr_CollisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr, nameof (CollisionWorld));
      BoxCastJob.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr, nameof (EntityManager));
      BoxCastJob.NativeFieldInfoPtr_From = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr, nameof (From));
      BoxCastJob.NativeFieldInfoPtr_To = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr, nameof (To));
      BoxCastJob.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr, nameof (Size));
      BoxCastJob.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr, nameof (Rotation));
      BoxCastJob.NativeFieldInfoPtr_CollisionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr, nameof (CollisionFilter));
      BoxCastJob.NativeFieldInfoPtr_ContextEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr, nameof (ContextEntity));
      BoxCastJob.NativeFieldInfoPtr_HitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr, nameof (HitFilter));
      BoxCastJob.NativeFieldInfoPtr_OffsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr, nameof (OffsetY));
      BoxCastJob.NativeFieldInfoPtr_IgnoreSpellCollisionBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr, nameof (IgnoreSpellCollisionBlock));
      BoxCastJob.NativeFieldInfoPtr_ShowDebugCasts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr, nameof (ShowDebugCasts));
      BoxCastJob.NativeFieldInfoPtr_DebugOneShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr, nameof (DebugOneShot));
      BoxCastJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr, 100668592);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoxCastJob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
