// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.UpdateGraphSystemBase
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Hybrid;
using ProjectM.UI;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Sequencer
{
  public class UpdateGraphSystemBase : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurveCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__MouseWorldPositionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__HybridModelBoneSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_47;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_CameraTarget_48;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPlaybackType_Protected_Abstract_Virtual_New_GraphPlaybackType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntityQuery_Protected_Abstract_Virtual_New_EntityQuery_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    public virtual unsafe GraphPlaybackType GetPlaybackType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateGraphSystemBase.NativeMethodInfoPtr_GetPlaybackType_Protected_Abstract_Virtual_New_GraphPlaybackType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GraphPlaybackType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe EntityQuery GetEntityQuery()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateGraphSystemBase.NativeMethodInfoPtr_GetEntityQuery_Protected_Abstract_Virtual_New_EntityQuery_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106605, XrefRangeEnd = 1106621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateGraphSystemBase.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106621, XrefRangeEnd = 1106681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateGraphSystemBase.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UpdateGraphSystemBase()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateGraphSystemBase>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateGraphSystemBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1106695, RefRangeEnd = 1106698, XrefRangeStart = 1106681, XrefRangeEnd = 1106695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateGraphSystemBase.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UpdateGraphSystemBase()
    {
      Il2CppClassPointerStore<UpdateGraphSystemBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (UpdateGraphSystemBase));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateGraphSystemBase>.NativeClassPtr);
      UpdateGraphSystemBase.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase>.NativeClassPtr, nameof (_Query));
      UpdateGraphSystemBase.NativeFieldInfoPtr__CurveCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase>.NativeClassPtr, nameof (_CurveCollectionSystem));
      UpdateGraphSystemBase.NativeFieldInfoPtr__MouseWorldPositionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase>.NativeClassPtr, nameof (_MouseWorldPositionSystem));
      UpdateGraphSystemBase.NativeFieldInfoPtr__HybridModelBoneSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase>.NativeClassPtr, nameof (_HybridModelBoneSystem));
      UpdateGraphSystemBase.NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_47 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalControlled_47));
      UpdateGraphSystemBase.NativeFieldInfoPtr__SingletonEntityQuery_CameraTarget_48 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase>.NativeClassPtr, nameof (_SingletonEntityQuery_CameraTarget_48));
      UpdateGraphSystemBase.NativeMethodInfoPtr_GetPlaybackType_Protected_Abstract_Virtual_New_GraphPlaybackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateGraphSystemBase>.NativeClassPtr, 100687669);
      UpdateGraphSystemBase.NativeMethodInfoPtr_GetEntityQuery_Protected_Abstract_Virtual_New_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateGraphSystemBase>.NativeClassPtr, 100687670);
      UpdateGraphSystemBase.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateGraphSystemBase>.NativeClassPtr, 100687671);
      UpdateGraphSystemBase.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateGraphSystemBase>.NativeClassPtr, 100687672);
      UpdateGraphSystemBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateGraphSystemBase>.NativeClassPtr, 100687673);
      UpdateGraphSystemBase.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateGraphSystemBase>.NativeClassPtr, 100687674);
    }

    public UpdateGraphSystemBase(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateGraphSystemBase.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateGraphSystemBase.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe CurveCollectionSystem _CurveCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateGraphSystemBase.NativeFieldInfoPtr__CurveCollectionSystem));
        return pointer == System.IntPtr.Zero ? (CurveCollectionSystem) null : new CurveCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateGraphSystemBase.NativeFieldInfoPtr__CurveCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MouseWorldPositionSystem _MouseWorldPositionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateGraphSystemBase.NativeFieldInfoPtr__MouseWorldPositionSystem));
        return pointer == System.IntPtr.Zero ? (MouseWorldPositionSystem) null : new MouseWorldPositionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateGraphSystemBase.NativeFieldInfoPtr__MouseWorldPositionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HybridModelBoneSystem _HybridModelBoneSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateGraphSystemBase.NativeFieldInfoPtr__HybridModelBoneSystem));
        return pointer == System.IntPtr.Zero ? (HybridModelBoneSystem) null : new HybridModelBoneSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateGraphSystemBase.NativeFieldInfoPtr__HybridModelBoneSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalControlled_47
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateGraphSystemBase.NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_47));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateGraphSystemBase.NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_47)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_CameraTarget_48
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateGraphSystemBase.NativeFieldInfoPtr__SingletonEntityQuery_CameraTarget_48));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateGraphSystemBase.NativeFieldInfoPtr__SingletonEntityQuery_CameraTarget_48)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RunGraphJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PlaybackType;
      private static readonly System.IntPtr NativeFieldInfoPtr_BoneRequests;
      private static readonly System.IntPtr NativeFieldInfoPtr_BoneResults;
      private static readonly System.IntPtr NativeFieldInfoPtr_BlackboardBufferType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GraphProgramElementType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GraphEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_EventStateElementType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLocalToWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetHybridModelUser;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCharacterHeightHUD;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetHybridModelParticleScale;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetAge;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLifeTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetHealth;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetInventoryOwner;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetInventoryBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_LocalCharacterEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_CameraTargetEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_MousePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_CurveCollection;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunGraph_Private_Void_byref_Blackboard_NativeArray_1_Byte_Int32_0;
      [FieldOffset(0)]
      public GraphPlaybackType PlaybackType;
      [FieldOffset(8)]
      public NativeList<BoneRequest> BoneRequests;
      [FieldOffset(24)]
      public NativeList<LocalToWorld> BoneResults;
      [FieldOffset(40)]
      public BufferTypeHandle<BlackboardElement> BlackboardBufferType;
      [FieldOffset(80)]
      public BufferTypeHandle<GraphProgramElement> GraphProgramElementType;
      [FieldOffset(120)]
      public BufferTypeHandle<GraphEvent> GraphEventType;
      [FieldOffset(160)]
      public BufferTypeHandle<EventStateElement> EventStateElementType;
      [FieldOffset(200)]
      public ComponentDataFromEntity<LocalToWorld> GetLocalToWorld;
      [FieldOffset(232)]
      public ComponentDataFromEntity<HybridModelUser> GetHybridModelUser;
      [FieldOffset(264)]
      public ComponentDataFromEntity<CharacterHeightHUD> GetCharacterHeightHUD;
      [FieldOffset(296)]
      public ComponentDataFromEntity<HybridModelParticleScale> GetHybridModelParticleScale;
      [FieldOffset(328)]
      public ComponentDataFromEntity<Age> GetAge;
      [FieldOffset(360)]
      public ComponentDataFromEntity<LifeTime> GetLifeTime;
      [FieldOffset(392)]
      public ComponentDataFromEntity<Team> GetTeam;
      [FieldOffset(424)]
      public ComponentDataFromEntity<Health> GetHealth;
      [FieldOffset(456)]
      public BufferFromEntity<InventoryInstanceElement> GetInventoryOwner;
      [FieldOffset(496)]
      public BufferFromEntity<InventoryBuffer> GetInventoryBuffer;
      [FieldOffset(536)]
      public Entity LocalCharacterEntity;
      [FieldOffset(544)]
      public Entity CameraTargetEntity;
      [FieldOffset(552)]
      public float3 MousePosition;
      [FieldOffset(568)]
      public CurveCollection CurveCollection;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106433, XrefRangeEnd = 1106487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(UpdateGraphSystemBase.RunGraphJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1106604, RefRangeEnd = 1106605, XrefRangeStart = 1106487, XrefRangeEnd = 1106604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void RunGraph(
        ref Blackboard blackboard,
        NativeArray<byte> graphBuffer,
        int startIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref blackboard;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &graphBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &startIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateGraphSystemBase.RunGraphJob.NativeMethodInfoPtr_RunGraph_Private_Void_byref_Blackboard_NativeArray_1_Byte_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RunGraphJob()
      {
        Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateGraphSystemBase>.NativeClassPtr, nameof (RunGraphJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr);
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_PlaybackType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (PlaybackType));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_BoneRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (BoneRequests));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_BoneResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (BoneResults));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_BlackboardBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (BlackboardBufferType));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_GraphProgramElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (GraphProgramElementType));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_GraphEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (GraphEventType));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_EventStateElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (EventStateElementType));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_GetLocalToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (GetLocalToWorld));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_GetHybridModelUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (GetHybridModelUser));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_GetCharacterHeightHUD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (GetCharacterHeightHUD));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_GetHybridModelParticleScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (GetHybridModelParticleScale));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_GetAge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (GetAge));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_GetLifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (GetLifeTime));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_GetTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (GetTeam));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_GetHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (GetHealth));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_GetInventoryOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (GetInventoryOwner));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_GetInventoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (GetInventoryBuffer));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_LocalCharacterEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (LocalCharacterEntity));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_CameraTargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (CameraTargetEntity));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_MousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (MousePosition));
        UpdateGraphSystemBase.RunGraphJob.NativeFieldInfoPtr_CurveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, nameof (CurveCollection));
        UpdateGraphSystemBase.RunGraphJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, 100687675);
        UpdateGraphSystemBase.RunGraphJob.NativeMethodInfoPtr_RunGraph_Private_Void_byref_Blackboard_NativeArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, 100687676);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateGraphSystemBase.RunGraphJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
