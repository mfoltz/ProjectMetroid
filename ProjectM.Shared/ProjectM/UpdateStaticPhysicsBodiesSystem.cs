// Decompiled with JetBrains decompiler
// Type: ProjectM.UpdateStaticPhysicsBodiesSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Physics;
using Unity.Physics.Systems;

#nullable disable
namespace ProjectM
{
  public class UpdateStaticPhysicsBodiesSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__BuildStaticPhysicsWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr__InvalidBodiesDebugQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ActiveStaticBodiesQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ActiveSuperStaticBodiesQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__BodiesToUpdateQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__StaticTransformElementsQuery;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DebugInvalidBodies_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761254, XrefRangeEnd = 761389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateStaticPhysicsBodiesSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761389, XrefRangeEnd = 761484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateStaticPhysicsBodiesSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761484, XrefRangeEnd = 761502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DebugInvalidBodies()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateStaticPhysicsBodiesSystem.NativeMethodInfoPtr_DebugInvalidBodies_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UpdateStaticPhysicsBodiesSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateStaticPhysicsBodiesSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateStaticPhysicsBodiesSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UpdateStaticPhysicsBodiesSystem()
    {
      Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UpdateStaticPhysicsBodiesSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem>.NativeClassPtr);
      UpdateStaticPhysicsBodiesSystem.NativeFieldInfoPtr__BuildStaticPhysicsWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem>.NativeClassPtr, nameof (_BuildStaticPhysicsWorld));
      UpdateStaticPhysicsBodiesSystem.NativeFieldInfoPtr__InvalidBodiesDebugQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem>.NativeClassPtr, nameof (_InvalidBodiesDebugQuery));
      UpdateStaticPhysicsBodiesSystem.NativeFieldInfoPtr__ActiveStaticBodiesQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem>.NativeClassPtr, nameof (_ActiveStaticBodiesQuery));
      UpdateStaticPhysicsBodiesSystem.NativeFieldInfoPtr__ActiveSuperStaticBodiesQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem>.NativeClassPtr, nameof (_ActiveSuperStaticBodiesQuery));
      UpdateStaticPhysicsBodiesSystem.NativeFieldInfoPtr__BodiesToUpdateQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem>.NativeClassPtr, nameof (_BodiesToUpdateQuery));
      UpdateStaticPhysicsBodiesSystem.NativeFieldInfoPtr__StaticTransformElementsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem>.NativeClassPtr, nameof (_StaticTransformElementsQuery));
      UpdateStaticPhysicsBodiesSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem>.NativeClassPtr, 100667196);
      UpdateStaticPhysicsBodiesSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem>.NativeClassPtr, 100667197);
      UpdateStaticPhysicsBodiesSystem.NativeMethodInfoPtr_DebugInvalidBodies_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem>.NativeClassPtr, 100667198);
      UpdateStaticPhysicsBodiesSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem>.NativeClassPtr, 100667199);
      UpdateStaticPhysicsBodiesSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem>.NativeClassPtr, 100667200);
    }

    public UpdateStaticPhysicsBodiesSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BuildStaticPhysicsWorld _BuildStaticPhysicsWorld
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateStaticPhysicsBodiesSystem.NativeFieldInfoPtr__BuildStaticPhysicsWorld));
        return pointer == System.IntPtr.Zero ? (BuildStaticPhysicsWorld) null : new BuildStaticPhysicsWorld(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateStaticPhysicsBodiesSystem.NativeFieldInfoPtr__BuildStaticPhysicsWorld), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _InvalidBodiesDebugQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateStaticPhysicsBodiesSystem.NativeFieldInfoPtr__InvalidBodiesDebugQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateStaticPhysicsBodiesSystem.NativeFieldInfoPtr__InvalidBodiesDebugQuery)) = value;
      }
    }

    public unsafe EntityQuery _ActiveStaticBodiesQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateStaticPhysicsBodiesSystem.NativeFieldInfoPtr__ActiveStaticBodiesQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateStaticPhysicsBodiesSystem.NativeFieldInfoPtr__ActiveStaticBodiesQuery)) = value;
      }
    }

    public unsafe EntityQuery _ActiveSuperStaticBodiesQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateStaticPhysicsBodiesSystem.NativeFieldInfoPtr__ActiveSuperStaticBodiesQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateStaticPhysicsBodiesSystem.NativeFieldInfoPtr__ActiveSuperStaticBodiesQuery)) = value;
      }
    }

    public unsafe EntityQuery _BodiesToUpdateQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateStaticPhysicsBodiesSystem.NativeFieldInfoPtr__BodiesToUpdateQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateStaticPhysicsBodiesSystem.NativeFieldInfoPtr__BodiesToUpdateQuery)) = value;
      }
    }

    public unsafe EntityQuery _StaticTransformElementsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateStaticPhysicsBodiesSystem.NativeFieldInfoPtr__StaticTransformElementsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateStaticPhysicsBodiesSystem.NativeFieldInfoPtr__StaticTransformElementsQuery)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CollectAllStaticTransformIndices
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformIndexType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkSceneIdType;
      private static readonly System.IntPtr NativeFieldInfoPtr_Positions;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public BufferTypeHandle<StaticTransformElement> StaticTransformIndexType;
      [FieldOffset(40)]
      public ComponentTypeHandle<ChunkSceneId> ChunkSceneIdType;
      [FieldOffset(72)]
      public NativeList<SuperStaticPosition> Positions;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761198, XrefRangeEnd = 761219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateStaticPhysicsBodiesSystem.CollectAllStaticTransformIndices.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CollectAllStaticTransformIndices()
      {
        Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.CollectAllStaticTransformIndices>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem>.NativeClassPtr, nameof (CollectAllStaticTransformIndices));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.CollectAllStaticTransformIndices>.NativeClassPtr);
        UpdateStaticPhysicsBodiesSystem.CollectAllStaticTransformIndices.NativeFieldInfoPtr_StaticTransformIndexType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.CollectAllStaticTransformIndices>.NativeClassPtr, nameof (StaticTransformIndexType));
        UpdateStaticPhysicsBodiesSystem.CollectAllStaticTransformIndices.NativeFieldInfoPtr_ChunkSceneIdType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.CollectAllStaticTransformIndices>.NativeClassPtr, nameof (ChunkSceneIdType));
        UpdateStaticPhysicsBodiesSystem.CollectAllStaticTransformIndices.NativeFieldInfoPtr_Positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.CollectAllStaticTransformIndices>.NativeClassPtr, nameof (Positions));
        UpdateStaticPhysicsBodiesSystem.CollectAllStaticTransformIndices.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.CollectAllStaticTransformIndices>.NativeClassPtr, 100667201);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.CollectAllStaticTransformIndices>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct UpdateSuperStaticRigidBodyRegistration
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TreatAllAsNew;
      private static readonly System.IntPtr NativeFieldInfoPtr_RigidBodyAccessors;
      private static readonly System.IntPtr NativeFieldInfoPtr_NewRigidBodies;
      private static readonly System.IntPtr NativeFieldInfoPtr_ActiveRegistrationArray;
      private static readonly System.IntPtr NativeFieldInfoPtr_BodyIndexType;
      private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatibleType;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public bool TreatAllAsNew;
      [FieldOffset(8)]
      public RigidBodyAccessors RigidBodyAccessors;
      [FieldOffset(208)]
      public NativeList<RigidBodyWithOwner> NewRigidBodies;
      [FieldOffset(224)]
      public UnsafeBitArray ActiveRegistrationArray;
      [FieldOffset(240)]
      public ComponentTypeHandle<StaticPhysicsWorldBodyIndex> BodyIndexType;
      [FieldOffset(272)]
      public ComponentTypeHandle<StaticTransformCompatible> StaticTransformCompatibleType;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761219, XrefRangeEnd = 761235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateStaticPhysicsBodiesSystem.UpdateSuperStaticRigidBodyRegistration.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UpdateSuperStaticRigidBodyRegistration()
      {
        Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateSuperStaticRigidBodyRegistration>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem>.NativeClassPtr, nameof (UpdateSuperStaticRigidBodyRegistration));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateSuperStaticRigidBodyRegistration>.NativeClassPtr);
        UpdateStaticPhysicsBodiesSystem.UpdateSuperStaticRigidBodyRegistration.NativeFieldInfoPtr_TreatAllAsNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateSuperStaticRigidBodyRegistration>.NativeClassPtr, nameof (TreatAllAsNew));
        UpdateStaticPhysicsBodiesSystem.UpdateSuperStaticRigidBodyRegistration.NativeFieldInfoPtr_RigidBodyAccessors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateSuperStaticRigidBodyRegistration>.NativeClassPtr, nameof (RigidBodyAccessors));
        UpdateStaticPhysicsBodiesSystem.UpdateSuperStaticRigidBodyRegistration.NativeFieldInfoPtr_NewRigidBodies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateSuperStaticRigidBodyRegistration>.NativeClassPtr, nameof (NewRigidBodies));
        UpdateStaticPhysicsBodiesSystem.UpdateSuperStaticRigidBodyRegistration.NativeFieldInfoPtr_ActiveRegistrationArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateSuperStaticRigidBodyRegistration>.NativeClassPtr, nameof (ActiveRegistrationArray));
        UpdateStaticPhysicsBodiesSystem.UpdateSuperStaticRigidBodyRegistration.NativeFieldInfoPtr_BodyIndexType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateSuperStaticRigidBodyRegistration>.NativeClassPtr, nameof (BodyIndexType));
        UpdateStaticPhysicsBodiesSystem.UpdateSuperStaticRigidBodyRegistration.NativeFieldInfoPtr_StaticTransformCompatibleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateSuperStaticRigidBodyRegistration>.NativeClassPtr, nameof (StaticTransformCompatibleType));
        UpdateStaticPhysicsBodiesSystem.UpdateSuperStaticRigidBodyRegistration.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateSuperStaticRigidBodyRegistration>.NativeClassPtr, 100667202);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateSuperStaticRigidBodyRegistration>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct UpdateRigidBodyRegistration
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_RigidBodyAccessors;
      private static readonly System.IntPtr NativeFieldInfoPtr_NewRigidBodies;
      private static readonly System.IntPtr NativeFieldInfoPtr_ActiveRegistrationArray;
      private static readonly System.IntPtr NativeFieldInfoPtr_BodyIndexType;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public RigidBodyAccessors RigidBodyAccessors;
      [FieldOffset(200)]
      public NativeList<RigidBody> NewRigidBodies;
      [FieldOffset(216)]
      public NativeArray<bool> ActiveRegistrationArray;
      [FieldOffset(232)]
      public ComponentTypeHandle<StaticPhysicsWorldBodyIndex> BodyIndexType;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761235, XrefRangeEnd = 761247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateStaticPhysicsBodiesSystem.UpdateRigidBodyRegistration.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UpdateRigidBodyRegistration()
      {
        Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateRigidBodyRegistration>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem>.NativeClassPtr, nameof (UpdateRigidBodyRegistration));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateRigidBodyRegistration>.NativeClassPtr);
        UpdateStaticPhysicsBodiesSystem.UpdateRigidBodyRegistration.NativeFieldInfoPtr_RigidBodyAccessors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateRigidBodyRegistration>.NativeClassPtr, nameof (RigidBodyAccessors));
        UpdateStaticPhysicsBodiesSystem.UpdateRigidBodyRegistration.NativeFieldInfoPtr_NewRigidBodies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateRigidBodyRegistration>.NativeClassPtr, nameof (NewRigidBodies));
        UpdateStaticPhysicsBodiesSystem.UpdateRigidBodyRegistration.NativeFieldInfoPtr_ActiveRegistrationArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateRigidBodyRegistration>.NativeClassPtr, nameof (ActiveRegistrationArray));
        UpdateStaticPhysicsBodiesSystem.UpdateRigidBodyRegistration.NativeFieldInfoPtr_BodyIndexType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateRigidBodyRegistration>.NativeClassPtr, nameof (BodyIndexType));
        UpdateStaticPhysicsBodiesSystem.UpdateRigidBodyRegistration.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateRigidBodyRegistration>.NativeClassPtr, 100667203);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateRigidBodyRegistration>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct UpdateRigidBodies
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_RigidBodyAccessors;
      private static readonly System.IntPtr NativeFieldInfoPtr_RigidBodies;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public RigidBodyAccessors RigidBodyAccessors;
      [FieldOffset(200)]
      public NativeList<RigidBody> RigidBodies;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761247, XrefRangeEnd = 761254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateStaticPhysicsBodiesSystem.UpdateRigidBodies.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UpdateRigidBodies()
      {
        Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateRigidBodies>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem>.NativeClassPtr, nameof (UpdateRigidBodies));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateRigidBodies>.NativeClassPtr);
        UpdateStaticPhysicsBodiesSystem.UpdateRigidBodies.NativeFieldInfoPtr_RigidBodyAccessors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateRigidBodies>.NativeClassPtr, nameof (RigidBodyAccessors));
        UpdateStaticPhysicsBodiesSystem.UpdateRigidBodies.NativeFieldInfoPtr_RigidBodies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateRigidBodies>.NativeClassPtr, nameof (RigidBodies));
        UpdateStaticPhysicsBodiesSystem.UpdateRigidBodies.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateRigidBodies>.NativeClassPtr, 100667204);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateStaticPhysicsBodiesSystem.UpdateRigidBodies>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
