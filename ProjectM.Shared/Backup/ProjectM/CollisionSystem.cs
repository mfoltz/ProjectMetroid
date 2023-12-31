// Decompiled with JetBrains decompiler
// Type: ProjectM.CollisionSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Jobs;
using Unity.Physics;
using Unity.Physics.Systems;

#nullable disable
namespace ProjectM
{
  public class CollisionSystem : ComponentSystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__BuildPhysicsWorld;
    private static readonly IntPtr NativeFieldInfoPtr__StaticBodyWorld;
    private static readonly IntPtr NativeFieldInfoPtr__BeforeCollisionBarrier;
    private static readonly IntPtr NativeFieldInfoPtr__IsServer;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetCollisionWorldAndComplete_Public_byref_CollisionWorld_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetCollisionWorldAsync_Public_byref_CollisionWorld_byref_JobHandle_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddCollisionWorldDependency_Public_Void_JobHandle_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750486, XrefRangeEnd = 750505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CollisionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(46)]
    [CachedScanResults(RefRangeStart = 750506, RefRangeEnd = 750552, XrefRangeStart = 750505, XrefRangeEnd = 750506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public ref CollisionWorld GetCollisionWorldAndComplete()
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 750552, RefRangeEnd = 750554, XrefRangeStart = 750552, XrefRangeEnd = 750552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public ref CollisionWorld GetCollisionWorldAsync(out JobHandle collisionWorldDeps)
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 750555, RefRangeEnd = 750557, XrefRangeStart = 750554, XrefRangeEnd = 750555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddCollisionWorldDependency(JobHandle dependency)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &dependency;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CollisionSystem.NativeMethodInfoPtr_AddCollisionWorldDependency_Public_Void_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CollisionSystem.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CollisionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollisionSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CollisionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CollisionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CollisionSystem()
    {
      Il2CppClassPointerStore<CollisionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CollisionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollisionSystem>.NativeClassPtr);
      CollisionSystem.NativeFieldInfoPtr__BuildPhysicsWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionSystem>.NativeClassPtr, nameof (_BuildPhysicsWorld));
      CollisionSystem.NativeFieldInfoPtr__StaticBodyWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionSystem>.NativeClassPtr, nameof (_StaticBodyWorld));
      CollisionSystem.NativeFieldInfoPtr__BeforeCollisionBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionSystem>.NativeClassPtr, nameof (_BeforeCollisionBarrier));
      CollisionSystem.NativeFieldInfoPtr__IsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionSystem>.NativeClassPtr, nameof (_IsServer));
      CollisionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionSystem>.NativeClassPtr, 100666065);
      CollisionSystem.NativeMethodInfoPtr_GetCollisionWorldAndComplete_Public_byref_CollisionWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionSystem>.NativeClassPtr, 100666066);
      CollisionSystem.NativeMethodInfoPtr_GetCollisionWorldAsync_Public_byref_CollisionWorld_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionSystem>.NativeClassPtr, 100666067);
      CollisionSystem.NativeMethodInfoPtr_AddCollisionWorldDependency_Public_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionSystem>.NativeClassPtr, 100666068);
      CollisionSystem.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionSystem>.NativeClassPtr, 100666069);
      CollisionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionSystem>.NativeClassPtr, 100666070);
      CollisionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionSystem>.NativeClassPtr, 100666071);
    }

    public CollisionSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BuildPhysicsWorld _BuildPhysicsWorld
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollisionSystem.NativeFieldInfoPtr__BuildPhysicsWorld));
        return pointer == IntPtr.Zero ? (BuildPhysicsWorld) null : new BuildPhysicsWorld(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CollisionSystem.NativeFieldInfoPtr__BuildPhysicsWorld), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BuildStaticPhysicsWorld _StaticBodyWorld
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollisionSystem.NativeFieldInfoPtr__StaticBodyWorld));
        return pointer == IntPtr.Zero ? (BuildStaticPhysicsWorld) null : new BuildStaticPhysicsWorld(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CollisionSystem.NativeFieldInfoPtr__StaticBodyWorld), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BeforeCollisionBarrier _BeforeCollisionBarrier
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollisionSystem.NativeFieldInfoPtr__BeforeCollisionBarrier));
        return pointer == IntPtr.Zero ? (BeforeCollisionBarrier) null : new BeforeCollisionBarrier(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CollisionSystem.NativeFieldInfoPtr__BeforeCollisionBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _IsServer
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollisionSystem.NativeFieldInfoPtr__IsServer));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollisionSystem.NativeFieldInfoPtr__IsServer)) = value;
      }
    }
  }
}
