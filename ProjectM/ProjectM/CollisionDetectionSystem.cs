// Decompiled with JetBrains decompiler
// Type: ProjectM.CollisionDetectionSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class CollisionDetectionSystem : CollisionDetectionSystem_Base
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__EntityMap;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__WriterHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputJobHandle;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCollisionDetectionAsync_Public_Virtual_CollisionDetection_byref_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCollisionDetectionAndComplete_Public_Virtual_CollisionDetection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddInputJobHandle_Public_Virtual_Void_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    public override unsafe CollisionDetection GetCollisionDetectionAsync(out JobHandle dependency)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref dependency;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CollisionDetectionSystem.NativeMethodInfoPtr_GetCollisionDetectionAsync_Public_Virtual_CollisionDetection_byref_JobHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CollisionDetection*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987545, XrefRangeEnd = 987546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe CollisionDetection GetCollisionDetectionAndComplete()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CollisionDetectionSystem.NativeMethodInfoPtr_GetCollisionDetectionAndComplete_Public_Virtual_CollisionDetection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CollisionDetection*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 792843, RefRangeEnd = 792856, XrefRangeStart = 792843, XrefRangeEnd = 792856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void AddInputJobHandle(JobHandle jobHandle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &jobHandle;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CollisionDetectionSystem.NativeMethodInfoPtr_AddInputJobHandle_Public_Virtual_Void_JobHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987546, XrefRangeEnd = 987582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CollisionDetectionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987582, XrefRangeEnd = 987586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CollisionDetectionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987586, XrefRangeEnd = 987651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CollisionDetectionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CollisionDetectionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollisionDetectionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CollisionDetectionSystem.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CollisionDetectionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CollisionDetectionSystem()
    {
      Il2CppClassPointerStore<CollisionDetectionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CollisionDetectionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollisionDetectionSystem>.NativeClassPtr);
      CollisionDetectionSystem.NativeFieldInfoPtr__EntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionDetectionSystem>.NativeClassPtr, nameof (_EntityMap));
      CollisionDetectionSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionDetectionSystem>.NativeClassPtr, nameof (_Query));
      CollisionDetectionSystem.NativeFieldInfoPtr__WriterHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionDetectionSystem>.NativeClassPtr, nameof (_WriterHandle));
      CollisionDetectionSystem.NativeFieldInfoPtr__InputJobHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionDetectionSystem>.NativeClassPtr, nameof (_InputJobHandle));
      CollisionDetectionSystem.NativeMethodInfoPtr_GetCollisionDetectionAsync_Public_Virtual_CollisionDetection_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetectionSystem>.NativeClassPtr, 100676169);
      CollisionDetectionSystem.NativeMethodInfoPtr_GetCollisionDetectionAndComplete_Public_Virtual_CollisionDetection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetectionSystem>.NativeClassPtr, 100676170);
      CollisionDetectionSystem.NativeMethodInfoPtr_AddInputJobHandle_Public_Virtual_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetectionSystem>.NativeClassPtr, 100676171);
      CollisionDetectionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetectionSystem>.NativeClassPtr, 100676172);
      CollisionDetectionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetectionSystem>.NativeClassPtr, 100676173);
      CollisionDetectionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetectionSystem>.NativeClassPtr, 100676174);
      CollisionDetectionSystem.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetectionSystem>.NativeClassPtr, 100676175);
      CollisionDetectionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetectionSystem>.NativeClassPtr, 100676176);
    }

    public CollisionDetectionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeMultiHashMap<int2, DetectedEntity> _EntityMap
    {
      get
      {
        return *(NativeMultiHashMap<int2, DetectedEntity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollisionDetectionSystem.NativeFieldInfoPtr__EntityMap));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollisionDetectionSystem.NativeFieldInfoPtr__EntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeMultiHashMap<int2, DetectedEntity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollisionDetectionSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollisionDetectionSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe JobHandle _WriterHandle
    {
      get
      {
        return *(JobHandle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollisionDetectionSystem.NativeFieldInfoPtr__WriterHandle));
      }
      [param: In] set
      {
        *(JobHandle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollisionDetectionSystem.NativeFieldInfoPtr__WriterHandle)) = value;
      }
    }

    public unsafe JobHandleManager _InputJobHandle
    {
      get
      {
        return *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollisionDetectionSystem.NativeFieldInfoPtr__InputJobHandle));
      }
      [param: In] set
      {
        *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollisionDetectionSystem.NativeFieldInfoPtr__InputJobHandle)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct AddEntity
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_TranslationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_CollisionRadiusType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TeamType;
      private static readonly System.IntPtr NativeFieldInfoPtr_AggroableType;
      private static readonly System.IntPtr NativeFieldInfoPtr_DeadType;
      private static readonly System.IntPtr NativeFieldInfoPtr_AiPointOfInterestType;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public NativeMultiHashMap<int2, DetectedEntity>.ParallelWriter EntityMap;
      [FieldOffset(16)]
      public ComponentTypeHandle<Translation> TranslationType;
      [FieldOffset(48)]
      public ComponentTypeHandle<CollisionRadius> CollisionRadiusType;
      [FieldOffset(80)]
      public ComponentTypeHandle<Team> TeamType;
      [FieldOffset(112)]
      public ComponentTypeHandle<Aggroable> AggroableType;
      [FieldOffset(144)]
      public ComponentTypeHandle<Dead> DeadType;
      [FieldOffset(176)]
      public ComponentTypeHandle<AiPointOfInterest> AiPointOfInterestType;
      [FieldOffset(208)]
      public EntityTypeHandle EntityType;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987509, XrefRangeEnd = 987545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CollisionDetectionSystem.AddEntity.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AddEntity()
      {
        Il2CppClassPointerStore<CollisionDetectionSystem.AddEntity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CollisionDetectionSystem>.NativeClassPtr, nameof (AddEntity));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollisionDetectionSystem.AddEntity>.NativeClassPtr);
        CollisionDetectionSystem.AddEntity.NativeFieldInfoPtr_EntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionDetectionSystem.AddEntity>.NativeClassPtr, nameof (EntityMap));
        CollisionDetectionSystem.AddEntity.NativeFieldInfoPtr_TranslationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionDetectionSystem.AddEntity>.NativeClassPtr, nameof (TranslationType));
        CollisionDetectionSystem.AddEntity.NativeFieldInfoPtr_CollisionRadiusType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionDetectionSystem.AddEntity>.NativeClassPtr, nameof (CollisionRadiusType));
        CollisionDetectionSystem.AddEntity.NativeFieldInfoPtr_TeamType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionDetectionSystem.AddEntity>.NativeClassPtr, nameof (TeamType));
        CollisionDetectionSystem.AddEntity.NativeFieldInfoPtr_AggroableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionDetectionSystem.AddEntity>.NativeClassPtr, nameof (AggroableType));
        CollisionDetectionSystem.AddEntity.NativeFieldInfoPtr_DeadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionDetectionSystem.AddEntity>.NativeClassPtr, nameof (DeadType));
        CollisionDetectionSystem.AddEntity.NativeFieldInfoPtr_AiPointOfInterestType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionDetectionSystem.AddEntity>.NativeClassPtr, nameof (AiPointOfInterestType));
        CollisionDetectionSystem.AddEntity.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionDetectionSystem.AddEntity>.NativeClassPtr, nameof (EntityType));
        CollisionDetectionSystem.AddEntity.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetectionSystem.AddEntity>.NativeClassPtr, 100676177);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CollisionDetectionSystem.AddEntity>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
