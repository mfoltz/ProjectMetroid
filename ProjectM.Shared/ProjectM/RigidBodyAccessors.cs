// Decompiled with JetBrains decompiler
// Type: ProjectM.RigidBodyAccessors
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Physics;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RigidBodyAccessors
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalToWorldType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParentType;
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionType;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_PhysicsColliderType;
    private static readonly System.IntPtr NativeFieldInfoPtr_PhysicsCustomTagsType;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkData_Public_Static_ChunkData_byref_RigidBodyAccessors_byref_ArchetypeChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateRigidBody_Public_Static_RigidBody_byref_ChunkData_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateRigidBody_Public_Static_RigidBody_byref_EntityAccessors_Entity_0;
    [FieldOffset(0)]
    public EntityTypeHandle EntityType;
    [FieldOffset(8)]
    public ComponentTypeHandle<LocalToWorld> LocalToWorldType;
    [FieldOffset(40)]
    public ComponentTypeHandle<Parent> ParentType;
    [FieldOffset(72)]
    public ComponentTypeHandle<Translation> PositionType;
    [FieldOffset(104)]
    public ComponentTypeHandle<Rotation> RotationType;
    [FieldOffset(136)]
    public ComponentTypeHandle<PhysicsCollider> PhysicsColliderType;
    [FieldOffset(168)]
    public ComponentTypeHandle<PhysicsCustomTags> PhysicsCustomTagsType;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 761543, RefRangeEnd = 761546, XrefRangeStart = 761524, XrefRangeEnd = 761543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RigidBodyAccessors.ChunkData GetChunkData(
      ref RigidBodyAccessors accessors,
      ref ArchetypeChunk chunk)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref accessors;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref chunk;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RigidBodyAccessors.NativeMethodInfoPtr_GetChunkData_Public_Static_ChunkData_byref_RigidBodyAccessors_byref_ArchetypeChunk_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RigidBodyAccessors.ChunkData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 761564, RefRangeEnd = 761567, XrefRangeStart = 761546, XrefRangeEnd = 761564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RigidBody CreateRigidBody(
      ref RigidBodyAccessors.ChunkData chunkData,
      int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref chunkData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RigidBodyAccessors.NativeMethodInfoPtr_CreateRigidBody_Public_Static_RigidBody_byref_ChunkData_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RigidBody*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761567, XrefRangeEnd = 761619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RigidBody CreateRigidBody(
      ref RigidBodyAccessors.EntityAccessors entityAccessors,
      Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entityAccessors;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RigidBodyAccessors.NativeMethodInfoPtr_CreateRigidBody_Public_Static_RigidBody_byref_EntityAccessors_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RigidBody*) IL2CPP.il2cpp_object_unbox(num);
    }

    static RigidBodyAccessors()
    {
      Il2CppClassPointerStore<RigidBodyAccessors>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RigidBodyAccessors));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RigidBodyAccessors>.NativeClassPtr);
      RigidBodyAccessors.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors>.NativeClassPtr, nameof (EntityType));
      RigidBodyAccessors.NativeFieldInfoPtr_LocalToWorldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors>.NativeClassPtr, nameof (LocalToWorldType));
      RigidBodyAccessors.NativeFieldInfoPtr_ParentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors>.NativeClassPtr, nameof (ParentType));
      RigidBodyAccessors.NativeFieldInfoPtr_PositionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors>.NativeClassPtr, nameof (PositionType));
      RigidBodyAccessors.NativeFieldInfoPtr_RotationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors>.NativeClassPtr, nameof (RotationType));
      RigidBodyAccessors.NativeFieldInfoPtr_PhysicsColliderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors>.NativeClassPtr, nameof (PhysicsColliderType));
      RigidBodyAccessors.NativeFieldInfoPtr_PhysicsCustomTagsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors>.NativeClassPtr, nameof (PhysicsCustomTagsType));
      RigidBodyAccessors.NativeMethodInfoPtr_GetChunkData_Public_Static_ChunkData_byref_RigidBodyAccessors_byref_ArchetypeChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidBodyAccessors>.NativeClassPtr, 100667205);
      RigidBodyAccessors.NativeMethodInfoPtr_CreateRigidBody_Public_Static_RigidBody_byref_ChunkData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidBodyAccessors>.NativeClassPtr, 100667206);
      RigidBodyAccessors.NativeMethodInfoPtr_CreateRigidBody_Public_Static_RigidBody_byref_EntityAccessors_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidBodyAccessors>.NativeClassPtr, 100667207);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RigidBodyAccessors>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ChunkData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_HasChunkParentType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkColliders;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkLocalToWorlds;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkPositions;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkRotations;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkCustomTags;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChunkPhysicsColliderType_Public_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChunkPhysicsCustomTagsType_Public_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChunkLocalToWorldType_Public_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChunkPositionType_Public_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChunkRotationType_Public_get_Boolean_0;
      [FieldOffset(0)]
      public bool HasChunkParentType;
      [FieldOffset(8)]
      public NativeArray<PhysicsCollider> ChunkColliders;
      [FieldOffset(24)]
      public NativeArray<LocalToWorld> ChunkLocalToWorlds;
      [FieldOffset(40)]
      public NativeArray<Translation> ChunkPositions;
      [FieldOffset(56)]
      public NativeArray<Rotation> ChunkRotations;
      [FieldOffset(72)]
      public NativeArray<Entity> ChunkEntities;
      [FieldOffset(88)]
      public NativeArray<PhysicsCustomTags> ChunkCustomTags;

      public unsafe bool HasChunkPhysicsColliderType
      {
        [CallerCount(1), CachedScanResults(RefRangeStart = 761505, RefRangeEnd = 761506, XrefRangeStart = 761502, XrefRangeEnd = 761505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RigidBodyAccessors.ChunkData.NativeMethodInfoPtr_get_HasChunkPhysicsColliderType_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public unsafe bool HasChunkPhysicsCustomTagsType
      {
        [CallerCount(1), CachedScanResults(RefRangeStart = 761509, RefRangeEnd = 761510, XrefRangeStart = 761506, XrefRangeEnd = 761509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RigidBodyAccessors.ChunkData.NativeMethodInfoPtr_get_HasChunkPhysicsCustomTagsType_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public unsafe bool HasChunkLocalToWorldType
      {
        [CallerCount(3), CachedScanResults(RefRangeStart = 761513, RefRangeEnd = 761516, XrefRangeStart = 761510, XrefRangeEnd = 761513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RigidBodyAccessors.ChunkData.NativeMethodInfoPtr_get_HasChunkLocalToWorldType_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public unsafe bool HasChunkPositionType
      {
        [CallerCount(1), CachedScanResults(RefRangeStart = 761519, RefRangeEnd = 761520, XrefRangeStart = 761516, XrefRangeEnd = 761519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RigidBodyAccessors.ChunkData.NativeMethodInfoPtr_get_HasChunkPositionType_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public unsafe bool HasChunkRotationType
      {
        [CallerCount(1), CachedScanResults(RefRangeStart = 761523, RefRangeEnd = 761524, XrefRangeStart = 761520, XrefRangeEnd = 761523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RigidBodyAccessors.ChunkData.NativeMethodInfoPtr_get_HasChunkRotationType_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      static ChunkData()
      {
        Il2CppClassPointerStore<RigidBodyAccessors.ChunkData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RigidBodyAccessors>.NativeClassPtr, nameof (ChunkData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RigidBodyAccessors.ChunkData>.NativeClassPtr);
        RigidBodyAccessors.ChunkData.NativeFieldInfoPtr_HasChunkParentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors.ChunkData>.NativeClassPtr, nameof (HasChunkParentType));
        RigidBodyAccessors.ChunkData.NativeFieldInfoPtr_ChunkColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors.ChunkData>.NativeClassPtr, nameof (ChunkColliders));
        RigidBodyAccessors.ChunkData.NativeFieldInfoPtr_ChunkLocalToWorlds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors.ChunkData>.NativeClassPtr, nameof (ChunkLocalToWorlds));
        RigidBodyAccessors.ChunkData.NativeFieldInfoPtr_ChunkPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors.ChunkData>.NativeClassPtr, nameof (ChunkPositions));
        RigidBodyAccessors.ChunkData.NativeFieldInfoPtr_ChunkRotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors.ChunkData>.NativeClassPtr, nameof (ChunkRotations));
        RigidBodyAccessors.ChunkData.NativeFieldInfoPtr_ChunkEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors.ChunkData>.NativeClassPtr, nameof (ChunkEntities));
        RigidBodyAccessors.ChunkData.NativeFieldInfoPtr_ChunkCustomTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors.ChunkData>.NativeClassPtr, nameof (ChunkCustomTags));
        RigidBodyAccessors.ChunkData.NativeMethodInfoPtr_get_HasChunkPhysicsColliderType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidBodyAccessors.ChunkData>.NativeClassPtr, 100667208);
        RigidBodyAccessors.ChunkData.NativeMethodInfoPtr_get_HasChunkPhysicsCustomTagsType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidBodyAccessors.ChunkData>.NativeClassPtr, 100667209);
        RigidBodyAccessors.ChunkData.NativeMethodInfoPtr_get_HasChunkLocalToWorldType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidBodyAccessors.ChunkData>.NativeClassPtr, 100667210);
        RigidBodyAccessors.ChunkData.NativeMethodInfoPtr_get_HasChunkPositionType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidBodyAccessors.ChunkData>.NativeClassPtr, 100667211);
        RigidBodyAccessors.ChunkData.NativeMethodInfoPtr_get_HasChunkRotationType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidBodyAccessors.ChunkData>.NativeClassPtr, 100667212);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RigidBodyAccessors.ChunkData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct EntityAccessors
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_GetParent;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPhysicsCollider;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLocalToWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCustomTags;
      [FieldOffset(0)]
      public ComponentDataFromEntity<Parent> GetParent;
      [FieldOffset(32)]
      public ComponentDataFromEntity<PhysicsCollider> GetPhysicsCollider;
      [FieldOffset(64)]
      public ComponentDataFromEntity<LocalToWorld> GetLocalToWorld;
      [FieldOffset(96)]
      public ComponentDataFromEntity<Translation> GetPosition;
      [FieldOffset(128)]
      public ComponentDataFromEntity<Rotation> GetRotation;
      [FieldOffset(160)]
      public ComponentDataFromEntity<PhysicsCustomTags> GetCustomTags;

      static EntityAccessors()
      {
        Il2CppClassPointerStore<RigidBodyAccessors.EntityAccessors>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RigidBodyAccessors>.NativeClassPtr, nameof (EntityAccessors));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RigidBodyAccessors.EntityAccessors>.NativeClassPtr);
        RigidBodyAccessors.EntityAccessors.NativeFieldInfoPtr_GetParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors.EntityAccessors>.NativeClassPtr, nameof (GetParent));
        RigidBodyAccessors.EntityAccessors.NativeFieldInfoPtr_GetPhysicsCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors.EntityAccessors>.NativeClassPtr, nameof (GetPhysicsCollider));
        RigidBodyAccessors.EntityAccessors.NativeFieldInfoPtr_GetLocalToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors.EntityAccessors>.NativeClassPtr, nameof (GetLocalToWorld));
        RigidBodyAccessors.EntityAccessors.NativeFieldInfoPtr_GetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors.EntityAccessors>.NativeClassPtr, nameof (GetPosition));
        RigidBodyAccessors.EntityAccessors.NativeFieldInfoPtr_GetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors.EntityAccessors>.NativeClassPtr, nameof (GetRotation));
        RigidBodyAccessors.EntityAccessors.NativeFieldInfoPtr_GetCustomTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidBodyAccessors.EntityAccessors>.NativeClassPtr, nameof (GetCustomTags));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RigidBodyAccessors.EntityAccessors>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
