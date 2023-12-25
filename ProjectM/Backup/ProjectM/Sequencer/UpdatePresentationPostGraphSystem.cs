// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.UpdatePresentationPostGraphSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Audio;
using Stunlock.Fmod;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Sequencer
{
  public class UpdatePresentationPostGraphSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__ParticlePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__SoundPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__VoicePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__ThisFrameParticles;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastFrameParticles;
    private static readonly System.IntPtr NativeFieldInfoPtr__ParticlePrefabsToWarmup;
    private static readonly System.IntPtr NativeFieldInfoPtr__ThisFrameSounds;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastFrameSounds;
    private static readonly System.IntPtr NativeFieldInfoPtr__ThisFrameWindMotors;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastFrameWindMotors;
    private static readonly System.IntPtr NativeFieldInfoPtr__ThisFrameAdditionalMaterialData;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastFrameAdditionalMaterialData;
    private static readonly System.IntPtr NativeFieldInfoPtr__ThisFrameVoiceEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastFrameVoiceEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr__VolumeProfileOutput;
    private static readonly System.IntPtr NativeFieldInfoPtr___CanOutputEntity_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CanOutputEntity_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___TheRest_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___TheRest_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_HybridCameraData_51;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_52;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_CameraTarget_53;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateParticleEvent_Private_Static_Void_byref_ParticleEvent_byref_InputData_byref_UpdateData_NativeList_1_VisualEffectOutput_NativeList_1_LineRendererOutput_NativeList_1_ParticleOutput_NativeList_1_SequenceAssetReference_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAdditionalMaterial_Private_Static_Void_EntityManager_byref_AdditionalMaterialEvent_byref_InputData_NativeList_1_AdditionalMaterialOutput_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVolumeProfile_Private_Static_Void_byref_VolumeProfileEvent_byref_InputData_byref_UpdateData_NativeList_1_VolumeProfileOutput_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVoiceEvent_Private_Static_Void_byref_UpdateData_byref_VoiceEvent_byref_InputData_NativeList_1_VoiceEventOutput_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHideMaterialEvent_Private_Static_Void_EntityManager_byref_HideMaterialEvent_byref_InputData_NativeList_1_MaterialEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMaterialChangeEvent_Private_Static_Void_EntityManager_byref_MaterialChangeEvent_byref_InputData_NativeList_1_MaterialEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMaterialPropertyEvent_Private_Static_Void_EntityManager_byref_MaterialPropertyEvent_byref_InputData_NativeList_1_Entry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateZoomModifierEvent_Private_Static_Void_byref_CameraTarget_byref_ZoomModifierEvent_byref_InputData_NativeList_1_ZoomModifier_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateWindMotorEvent_Private_Static_Void_EntityManager_Int32_float3_float3_Single_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWindMotorEvent_Private_Static_Void_byref_WindMotorEvent_byref_InputData_NativeList_1_WindMotorOutput_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWindMotors_Private_Static_Void_EntityManager_WindMotorData_WindMotorData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSoundEvent_Private_Static_Void_byref_SoundEvent_byref_InputData_byref_UpdateData_NativeList_1_SoundOutput_NativeList_1_SoundParameterOutput_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSounds_Private_Static_Void_EntityManager_SoundData_SoundData_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateStudioEvent_Private_Static_Void_EntityManager_Entity_FmodEventGuid_StudioEventStopModeEnum_PrefabGUID_Single_Single_Single_Single_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldOverwriteCurrentVoiceLine_Private_Static_Boolean_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVoiceEvents_Private_Static_Void_EntityManager_VoiceData_VoiceData_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateParticles_Private_Static_Void_EntityManager_ParticleData_ParticleData_NativeList_1_SequenceAssetReference_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAdditionalMaterials_Private_Static_Void_EntityManager_AdditionalMaterialData_AdditionalMaterialData_NativeReference_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCanOutputEntity_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForTheRest_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107726, XrefRangeEnd = 1107805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107805, XrefRangeEnd = 1107821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107821, XrefRangeEnd = 1107965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108036, RefRangeEnd = 1108037, XrefRangeStart = 1107965, XrefRangeEnd = 1108036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateParticleEvent(
      ref ParticleEvent particleEvent,
      ref InputData input,
      [In] ref UpdateData updateData,
      NativeList<VisualEffectOutput> visualEffectOutputs,
      NativeList<LineRendererOutput> lineRendererOutputs,
      NativeList<ParticleOutput> particleOutputs,
      NativeList<SequenceAssetReference> warmupPrefabs)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) ref particleEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref updateData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &visualEffectOutputs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &lineRendererOutputs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &particleOutputs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &warmupPrefabs;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateParticleEvent_Private_Static_Void_byref_ParticleEvent_byref_InputData_byref_UpdateData_NativeList_1_VisualEffectOutput_NativeList_1_LineRendererOutput_NativeList_1_ParticleOutput_NativeList_1_SequenceAssetReference_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108048, RefRangeEnd = 1108049, XrefRangeStart = 1108037, XrefRangeEnd = 1108048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateAdditionalMaterial(
      EntityManager entityManager,
      ref AdditionalMaterialEvent additionalMaterialEvent,
      ref InputData input,
      NativeList<AdditionalMaterialOutput> additionalMaterials)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref additionalMaterialEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &additionalMaterials;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateAdditionalMaterial_Private_Static_Void_EntityManager_byref_AdditionalMaterialEvent_byref_InputData_NativeList_1_AdditionalMaterialOutput_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108068, RefRangeEnd = 1108069, XrefRangeStart = 1108049, XrefRangeEnd = 1108068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateVolumeProfile(
      ref VolumeProfileEvent volumeProfileEvent,
      ref InputData input,
      [In] ref UpdateData updateData,
      NativeList<VolumeProfileOutput> volumeProfileOutput)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref volumeProfileEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref updateData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &volumeProfileOutput;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateVolumeProfile_Private_Static_Void_byref_VolumeProfileEvent_byref_InputData_byref_UpdateData_NativeList_1_VolumeProfileOutput_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108081, RefRangeEnd = 1108082, XrefRangeStart = 1108069, XrefRangeEnd = 1108081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateVoiceEvent(
      [In] ref UpdateData updateData,
      ref VoiceEvent voiceEvent,
      ref InputData input,
      NativeList<VoiceEventOutput> thisFrameVoiceEvents)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref updateData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref voiceEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &thisFrameVoiceEvents;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateVoiceEvent_Private_Static_Void_byref_UpdateData_byref_VoiceEvent_byref_InputData_NativeList_1_VoiceEventOutput_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108089, RefRangeEnd = 1108090, XrefRangeStart = 1108082, XrefRangeEnd = 1108089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateHideMaterialEvent(
      EntityManager entityManager,
      ref HideMaterialEvent hideMaterialEvent,
      ref InputData input,
      NativeList<HideMaterialSystem.MaterialEntry> hideMaterials)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hideMaterialEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &hideMaterials;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateHideMaterialEvent_Private_Static_Void_EntityManager_byref_HideMaterialEvent_byref_InputData_NativeList_1_MaterialEntry_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108097, RefRangeEnd = 1108098, XrefRangeStart = 1108090, XrefRangeEnd = 1108097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateMaterialChangeEvent(
      EntityManager entityManager,
      ref MaterialChangeEvent materialChangeEvent,
      ref InputData input,
      NativeList<MaterialChangeSystem.MaterialEntry> materialChanges)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref materialChangeEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &materialChanges;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateMaterialChangeEvent_Private_Static_Void_EntityManager_byref_MaterialChangeEvent_byref_InputData_NativeList_1_MaterialEntry_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108111, RefRangeEnd = 1108112, XrefRangeStart = 1108098, XrefRangeEnd = 1108111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateMaterialPropertyEvent(
      EntityManager entityManager,
      ref MaterialPropertyEvent materialPropertyEvent,
      ref InputData input,
      NativeList<MaterialPropertySystem.Entry> materialProperties)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref materialPropertyEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &materialProperties;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateMaterialPropertyEvent_Private_Static_Void_EntityManager_byref_MaterialPropertyEvent_byref_InputData_NativeList_1_Entry_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108133, RefRangeEnd = 1108134, XrefRangeStart = 1108112, XrefRangeEnd = 1108133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateZoomModifierEvent(
      [In] ref CameraTarget cameraTargetSingleton,
      ref ZoomModifierEvent zoomModifierEvent,
      ref InputData input,
      NativeList<ZoomModifier> zoomModifiers)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref cameraTargetSingleton;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref zoomModifierEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &zoomModifiers;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateZoomModifierEvent_Private_Static_Void_byref_CameraTarget_byref_ZoomModifierEvent_byref_InputData_NativeList_1_ZoomModifier_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108143, RefRangeEnd = 1108144, XrefRangeStart = 1108134, XrefRangeEnd = 1108143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateWindMotorEvent(
      EntityManager entityManager,
      int motorType,
      float3 position,
      float3 force,
      float range,
      out Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &motorType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &force;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &range;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_CreateWindMotorEvent_Private_Static_Void_EntityManager_Int32_float3_float3_Single_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108159, RefRangeEnd = 1108160, XrefRangeStart = 1108144, XrefRangeEnd = 1108159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateWindMotorEvent(
      ref WindMotorEvent windMotorEvent,
      ref InputData input,
      NativeList<WindMotorOutput> windMotorOutputs)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref windMotorEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &windMotorOutputs;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateWindMotorEvent_Private_Static_Void_byref_WindMotorEvent_byref_InputData_NativeList_1_WindMotorOutput_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108208, RefRangeEnd = 1108209, XrefRangeStart = 1108160, XrefRangeEnd = 1108208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateWindMotors(
      EntityManager entityManager,
      WindMotorData thisFrame,
      WindMotorData lastFrame)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &thisFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &lastFrame;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateWindMotors_Private_Static_Void_EntityManager_WindMotorData_WindMotorData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108252, RefRangeEnd = 1108253, XrefRangeStart = 1108209, XrefRangeEnd = 1108252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateSoundEvent(
      ref SoundEvent soundEvent,
      ref InputData input,
      [In] ref UpdateData updateData,
      NativeList<SoundOutput> soundOutputs,
      NativeList<SoundParameterOutput> soundParameterOutputs)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref soundEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref updateData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &soundOutputs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &soundParameterOutputs;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateSoundEvent_Private_Static_Void_byref_SoundEvent_byref_InputData_byref_UpdateData_NativeList_1_SoundOutput_NativeList_1_SoundParameterOutput_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108324, RefRangeEnd = 1108325, XrefRangeStart = 1108253, XrefRangeEnd = 1108324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateSounds(
      EntityManager entityManager,
      SoundData thisFrame,
      SoundData lastFrame,
      Entity soundPrefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &thisFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &lastFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &soundPrefab;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateSounds_Private_Static_Void_EntityManager_SoundData_SoundData_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1108342, RefRangeEnd = 1108344, XrefRangeStart = 1108325, XrefRangeEnd = 1108342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateStudioEvent(
      EntityManager entityManager,
      Entity soundPrefab,
      FmodEventGuid eventGUID,
      StudioEventStopModeEnum stopMode,
      PrefabGUID fromPrefabGUID,
      float volume,
      float pitch,
      float minDistance,
      float maxDistance,
      out Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &soundPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &eventGUID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &stopMode;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &fromPrefabGUID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &volume;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &pitch;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &minDistance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &maxDistance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_CreateStudioEvent_Private_Static_Void_EntityManager_Entity_FmodEventGuid_StudioEventStopModeEnum_PrefabGUID_Single_Single_Single_Single_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe bool ShouldOverwriteCurrentVoiceLine(
      int currentVoicePriority,
      int newVoicePriority)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &currentVoicePriority;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newVoicePriority;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_ShouldOverwriteCurrentVoiceLine_Private_Static_Boolean_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108447, RefRangeEnd = 1108448, XrefRangeStart = 1108344, XrefRangeEnd = 1108447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateVoiceEvents(
      EntityManager entityManager,
      VoiceData thisFrame,
      VoiceData lastFrame,
      Entity soundPrefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &thisFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &lastFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &soundPrefab;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateVoiceEvents_Private_Static_Void_EntityManager_VoiceData_VoiceData_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108610, RefRangeEnd = 1108611, XrefRangeStart = 1108448, XrefRangeEnd = 1108610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateParticles(
      EntityManager entityManager,
      ParticleData thisFrame,
      ParticleData lastFrame,
      NativeList<SequenceAssetReference> particlePrefabsToWarmup,
      Entity _ParticlePrefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &thisFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &lastFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &particlePrefabsToWarmup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &_ParticlePrefab;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateParticles_Private_Static_Void_EntityManager_ParticleData_ParticleData_NativeList_1_SequenceAssetReference_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108664, RefRangeEnd = 1108665, XrefRangeStart = 1108611, XrefRangeEnd = 1108664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateAdditionalMaterials(
      EntityManager entityManager,
      AdditionalMaterialData thisFrame,
      AdditionalMaterialData lastFrame,
      NativeReference<int> entityAssociationIdCounter)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &thisFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &lastFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityAssociationIdCounter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateAdditionalMaterials_Private_Static_Void_EntityManager_AdditionalMaterialData_AdditionalMaterialData_NativeReference_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UpdatePresentationPostGraphSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108665, XrefRangeEnd = 1108718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108743, RefRangeEnd = 1108744, XrefRangeStart = 1108718, XrefRangeEnd = 1108743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCanOutputEntity_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr___GetEntityQuery_ForCanOutputEntity_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108769, RefRangeEnd = 1108770, XrefRangeStart = 1108744, XrefRangeEnd = 1108769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForTheRest_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr___GetEntityQuery_ForTheRest_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108774, RefRangeEnd = 1108775, XrefRangeStart = 1108770, XrefRangeEnd = 1108774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1108779, RefRangeEnd = 1108780, XrefRangeStart = 1108775, XrefRangeEnd = 1108779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UpdatePresentationPostGraphSystem()
    {
      Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (UpdatePresentationPostGraphSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr);
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, nameof (_Query));
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ParticlePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, nameof (_ParticlePrefab));
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__SoundPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, nameof (_SoundPrefab));
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__VoicePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, nameof (_VoicePrefab));
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ThisFrameParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, nameof (_ThisFrameParticles));
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__LastFrameParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, nameof (_LastFrameParticles));
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ParticlePrefabsToWarmup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, nameof (_ParticlePrefabsToWarmup));
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ThisFrameSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, nameof (_ThisFrameSounds));
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__LastFrameSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, nameof (_LastFrameSounds));
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ThisFrameWindMotors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, nameof (_ThisFrameWindMotors));
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__LastFrameWindMotors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, nameof (_LastFrameWindMotors));
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ThisFrameAdditionalMaterialData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, nameof (_ThisFrameAdditionalMaterialData));
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__LastFrameAdditionalMaterialData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, nameof (_LastFrameAdditionalMaterialData));
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ThisFrameVoiceEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, nameof (_ThisFrameVoiceEvents));
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__LastFrameVoiceEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, nameof (_LastFrameVoiceEvents));
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__VolumeProfileOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, nameof (_VolumeProfileOutput));
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr___CanOutputEntity_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, "<>CanOutputEntity_entityQuery");
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr___CanOutputEntity_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, "<>CanOutputEntity_profilerMarker");
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr___TheRest_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, "<>TheRest_entityQuery");
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr___TheRest_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, "<>TheRest_profilerMarker");
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__SingletonEntityQuery_HybridCameraData_51 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_HybridCameraData_51));
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_52 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalCharacter_52));
      UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__SingletonEntityQuery_CameraTarget_53 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_CameraTarget_53));
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687729);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687730);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687731);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateParticleEvent_Private_Static_Void_byref_ParticleEvent_byref_InputData_byref_UpdateData_NativeList_1_VisualEffectOutput_NativeList_1_LineRendererOutput_NativeList_1_ParticleOutput_NativeList_1_SequenceAssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687732);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateAdditionalMaterial_Private_Static_Void_EntityManager_byref_AdditionalMaterialEvent_byref_InputData_NativeList_1_AdditionalMaterialOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687733);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateVolumeProfile_Private_Static_Void_byref_VolumeProfileEvent_byref_InputData_byref_UpdateData_NativeList_1_VolumeProfileOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687734);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateVoiceEvent_Private_Static_Void_byref_UpdateData_byref_VoiceEvent_byref_InputData_NativeList_1_VoiceEventOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687735);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateHideMaterialEvent_Private_Static_Void_EntityManager_byref_HideMaterialEvent_byref_InputData_NativeList_1_MaterialEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687736);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateMaterialChangeEvent_Private_Static_Void_EntityManager_byref_MaterialChangeEvent_byref_InputData_NativeList_1_MaterialEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687737);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateMaterialPropertyEvent_Private_Static_Void_EntityManager_byref_MaterialPropertyEvent_byref_InputData_NativeList_1_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687738);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateZoomModifierEvent_Private_Static_Void_byref_CameraTarget_byref_ZoomModifierEvent_byref_InputData_NativeList_1_ZoomModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687739);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_CreateWindMotorEvent_Private_Static_Void_EntityManager_Int32_float3_float3_Single_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687740);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateWindMotorEvent_Private_Static_Void_byref_WindMotorEvent_byref_InputData_NativeList_1_WindMotorOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687741);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateWindMotors_Private_Static_Void_EntityManager_WindMotorData_WindMotorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687742);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateSoundEvent_Private_Static_Void_byref_SoundEvent_byref_InputData_byref_UpdateData_NativeList_1_SoundOutput_NativeList_1_SoundParameterOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687743);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateSounds_Private_Static_Void_EntityManager_SoundData_SoundData_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687744);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_CreateStudioEvent_Private_Static_Void_EntityManager_Entity_FmodEventGuid_StudioEventStopModeEnum_PrefabGUID_Single_Single_Single_Single_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687745);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_ShouldOverwriteCurrentVoiceLine_Private_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687746);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateVoiceEvents_Private_Static_Void_EntityManager_VoiceData_VoiceData_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687747);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateParticles_Private_Static_Void_EntityManager_ParticleData_ParticleData_NativeList_1_SequenceAssetReference_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687748);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_UpdateAdditionalMaterials_Private_Static_Void_EntityManager_AdditionalMaterialData_AdditionalMaterialData_NativeReference_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687749);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687750);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687751);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr___GetEntityQuery_ForCanOutputEntity_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687752);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr___GetEntityQuery_ForTheRest_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687753);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687754);
      UpdatePresentationPostGraphSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, 100687755);
    }

    public UpdatePresentationPostGraphSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe Entity _ParticlePrefab
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ParticlePrefab));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ParticlePrefab)) = value;
      }
    }

    public unsafe Entity _SoundPrefab
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__SoundPrefab));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__SoundPrefab)) = value;
      }
    }

    public unsafe Entity _VoicePrefab
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__VoicePrefab));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__VoicePrefab)) = value;
      }
    }

    public unsafe ParticleData _ThisFrameParticles
    {
      get
      {
        return *(ParticleData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ThisFrameParticles));
      }
      [param: In] set
      {
        *(ParticleData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ThisFrameParticles)) = value;
      }
    }

    public unsafe ParticleData _LastFrameParticles
    {
      get
      {
        return *(ParticleData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__LastFrameParticles));
      }
      [param: In] set
      {
        *(ParticleData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__LastFrameParticles)) = value;
      }
    }

    public unsafe NativeList<SequenceAssetReference> _ParticlePrefabsToWarmup
    {
      get
      {
        return *(NativeList<SequenceAssetReference>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ParticlePrefabsToWarmup));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ParticlePrefabsToWarmup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<SequenceAssetReference>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SoundData _ThisFrameSounds
    {
      get
      {
        return *(SoundData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ThisFrameSounds));
      }
      [param: In] set
      {
        *(SoundData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ThisFrameSounds)) = value;
      }
    }

    public unsafe SoundData _LastFrameSounds
    {
      get
      {
        return *(SoundData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__LastFrameSounds));
      }
      [param: In] set
      {
        *(SoundData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__LastFrameSounds)) = value;
      }
    }

    public unsafe WindMotorData _ThisFrameWindMotors
    {
      get
      {
        return *(WindMotorData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ThisFrameWindMotors));
      }
      [param: In] set
      {
        *(WindMotorData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ThisFrameWindMotors)) = value;
      }
    }

    public unsafe WindMotorData _LastFrameWindMotors
    {
      get
      {
        return *(WindMotorData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__LastFrameWindMotors));
      }
      [param: In] set
      {
        *(WindMotorData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__LastFrameWindMotors)) = value;
      }
    }

    public unsafe AdditionalMaterialData _ThisFrameAdditionalMaterialData
    {
      get
      {
        return *(AdditionalMaterialData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ThisFrameAdditionalMaterialData));
      }
      [param: In] set
      {
        *(AdditionalMaterialData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ThisFrameAdditionalMaterialData)) = value;
      }
    }

    public unsafe AdditionalMaterialData _LastFrameAdditionalMaterialData
    {
      get
      {
        return *(AdditionalMaterialData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__LastFrameAdditionalMaterialData));
      }
      [param: In] set
      {
        *(AdditionalMaterialData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__LastFrameAdditionalMaterialData)) = value;
      }
    }

    public unsafe VoiceData _ThisFrameVoiceEvents
    {
      get
      {
        return *(VoiceData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ThisFrameVoiceEvents));
      }
      [param: In] set
      {
        *(VoiceData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__ThisFrameVoiceEvents)) = value;
      }
    }

    public unsafe VoiceData _LastFrameVoiceEvents
    {
      get
      {
        return *(VoiceData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__LastFrameVoiceEvents));
      }
      [param: In] set
      {
        *(VoiceData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__LastFrameVoiceEvents)) = value;
      }
    }

    public unsafe NativeList<VolumeProfileOutput> _VolumeProfileOutput
    {
      get
      {
        return *(NativeList<VolumeProfileOutput>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__VolumeProfileOutput));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__VolumeProfileOutput), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<VolumeProfileOutput>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __CanOutputEntity_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr___CanOutputEntity_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr___CanOutputEntity_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CanOutputEntity_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr___CanOutputEntity_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr___CanOutputEntity_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __TheRest_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr___TheRest_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr___TheRest_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __TheRest_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr___TheRest_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr___TheRest_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_HybridCameraData_51
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__SingletonEntityQuery_HybridCameraData_51));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__SingletonEntityQuery_HybridCameraData_51)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalCharacter_52
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_52));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_52)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_CameraTarget_53
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__SingletonEntityQuery_CameraTarget_53));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdatePresentationPostGraphSystem.NativeFieldInfoPtr__SingletonEntityQuery_CameraTarget_53)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.UpdatePresentationPostGraphSystem/<>c__DisplayClass18_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass18_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_currentTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_particlesEnabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_updateData;
      private static readonly System.IntPtr NativeFieldInfoPtr_visualEffects;
      private static readonly System.IntPtr NativeFieldInfoPtr_lineRenderers;
      private static readonly System.IntPtr NativeFieldInfoPtr_particles;
      private static readonly System.IntPtr NativeFieldInfoPtr_particlePrefabsToWarmup;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_additionalMaterials;
      private static readonly System.IntPtr NativeFieldInfoPtr_sounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_soundParameters;
      private static readonly System.IntPtr NativeFieldInfoPtr_windMotors;
      private static readonly System.IntPtr NativeFieldInfoPtr_voices;
      private static readonly System.IntPtr NativeFieldInfoPtr_volumes;
      private static readonly System.IntPtr NativeFieldInfoPtr_materialProperties;
      private static readonly System.IntPtr NativeFieldInfoPtr_hideMaterials;
      private static readonly System.IntPtr NativeFieldInfoPtr_materialChangeEnabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_materialChanges;
      private static readonly System.IntPtr NativeFieldInfoPtr_cameraTargetSingleton;
      private static readonly System.IntPtr NativeFieldInfoPtr_zoomModifiers;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_SequenceInstance_byref_DynamicBuffer_1_EventStateElement_byref_DynamicBuffer_1_BlackboardElement_byref_SequenceAsset_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_SequenceInstance_byref_DynamicBuffer_1_EventStateElement_byref_DynamicBuffer_1_BlackboardElement_byref_SequenceAsset_0;
      [FieldOffset(0)]
      public float currentTime;
      [FieldOffset(4)]
      public int currentFrame;
      [FieldOffset(8)]
      public bool particlesEnabled;
      [FieldOffset(16)]
      public UpdateData updateData;
      [FieldOffset(64)]
      public NativeList<VisualEffectOutput> visualEffects;
      [FieldOffset(80)]
      public NativeList<LineRendererOutput> lineRenderers;
      [FieldOffset(96)]
      public NativeList<ParticleOutput> particles;
      [FieldOffset(112)]
      public NativeList<SequenceAssetReference> particlePrefabsToWarmup;
      [FieldOffset(128)]
      public EntityManager entityManager;
      [FieldOffset(136)]
      public NativeList<AdditionalMaterialOutput> additionalMaterials;
      [FieldOffset(152)]
      public NativeList<SoundOutput> sounds;
      [FieldOffset(168)]
      public NativeList<SoundParameterOutput> soundParameters;
      [FieldOffset(184)]
      public NativeList<WindMotorOutput> windMotors;
      [FieldOffset(200)]
      public NativeList<VoiceEventOutput> voices;
      [FieldOffset(216)]
      public NativeList<VolumeProfileOutput> volumes;
      [FieldOffset(232)]
      public NativeList<MaterialPropertySystem.Entry> materialProperties;
      [FieldOffset(248)]
      public NativeList<HideMaterialSystem.MaterialEntry> hideMaterials;
      [FieldOffset(264)]
      public bool materialChangeEnabled;
      [FieldOffset(272)]
      public NativeList<MaterialChangeSystem.MaterialEntry> materialChanges;
      [FieldOffset(288)]
      public CameraTarget cameraTargetSingleton;
      [FieldOffset(296)]
      public NativeList<ZoomModifier> zoomModifiers;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass18_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref SequenceInstance sequenceInstance,
        ref DynamicBuffer<EventStateElement> eventStates,
        ref DynamicBuffer<BlackboardElement> blackBoardBuffer,
        [In] ref SequenceAsset sequenceAsset)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceInstance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventStates;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref blackBoardBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceAsset;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_SequenceInstance_byref_DynamicBuffer_1_EventStateElement_byref_DynamicBuffer_1_BlackboardElement_byref_SequenceAsset_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        ref SequenceInstance sequenceInstance,
        ref DynamicBuffer<EventStateElement> eventStates,
        ref DynamicBuffer<BlackboardElement> blackBoardBuffer,
        [In] ref SequenceAsset sequenceAsset)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceInstance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventStates;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref blackBoardBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceAsset;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_SequenceInstance_byref_DynamicBuffer_1_EventStateElement_byref_DynamicBuffer_1_BlackboardElement_byref_SequenceAsset_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass18_0()
      {
        Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, "<>c__DisplayClass18_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr);
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (currentTime));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_currentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (currentFrame));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_particlesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (particlesEnabled));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_updateData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (updateData));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_visualEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (visualEffects));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_lineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (lineRenderers));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (particles));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_particlePrefabsToWarmup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (particlePrefabsToWarmup));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (entityManager));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_additionalMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (additionalMaterials));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_sounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (sounds));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_soundParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (soundParameters));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_windMotors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (windMotors));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_voices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (voices));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_volumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (volumes));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_materialProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (materialProperties));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_hideMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (hideMaterials));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_materialChangeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (materialChangeEnabled));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_materialChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (materialChanges));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_cameraTargetSingleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (cameraTargetSingleton));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_zoomModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (zoomModifiers));
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, 100687756);
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_SequenceInstance_byref_DynamicBuffer_1_EventStateElement_byref_DynamicBuffer_1_BlackboardElement_byref_SequenceAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, 100687757);
        UpdatePresentationPostGraphSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_SequenceInstance_byref_DynamicBuffer_1_EventStateElement_byref_DynamicBuffer_1_BlackboardElement_byref_SequenceAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, 100687758);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass18_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.UpdatePresentationPostGraphSystem/ProjectM.Sequencer.<>c__DisplayClass_CanOutputEntity")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CanOutputEntity
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_currentTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_particlesEnabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_updateData;
      private static readonly System.IntPtr NativeFieldInfoPtr_visualEffects;
      private static readonly System.IntPtr NativeFieldInfoPtr_lineRenderers;
      private static readonly System.IntPtr NativeFieldInfoPtr_particles;
      private static readonly System.IntPtr NativeFieldInfoPtr_particlePrefabsToWarmup;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_additionalMaterials;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SequenceInstance_byref_DynamicBuffer_1_EventStateElement_byref_DynamicBuffer_1_BlackboardElement_byref_SequenceAsset_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdatePresentationPostGraphSystem_byref___c__DisplayClass18_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float currentTime;
      [FieldOffset(4)]
      public int currentFrame;
      [FieldOffset(8)]
      public bool particlesEnabled;
      [FieldOffset(16)]
      public UpdateData updateData;
      [FieldOffset(64)]
      public NativeList<VisualEffectOutput> visualEffects;
      [FieldOffset(80)]
      public NativeList<LineRendererOutput> lineRenderers;
      [FieldOffset(96)]
      public NativeList<ParticleOutput> particles;
      [FieldOffset(112)]
      public NativeList<SequenceAssetReference> particlePrefabsToWarmup;
      [FieldOffset(128)]
      public EntityManager entityManager;
      [FieldOffset(136)]
      public NativeList<AdditionalMaterialOutput> additionalMaterials;
      [FieldOffset(152)]
      public UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(304)]
      public unsafe UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107495, XrefRangeEnd = 1107511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref SequenceInstance sequenceInstance,
        ref DynamicBuffer<EventStateElement> eventStates,
        ref DynamicBuffer<BlackboardElement> blackBoardBuffer,
        [In] ref SequenceAsset sequenceAsset)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceInstance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventStates;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref blackBoardBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceAsset;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SequenceInstance_byref_DynamicBuffer_1_EventStateElement_byref_DynamicBuffer_1_BlackboardElement_byref_SequenceAsset_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1107511, RefRangeEnd = 1107512, XrefRangeStart = 1107511, XrefRangeEnd = 1107511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref UpdatePresentationPostGraphSystem.__c__DisplayClass18_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1107512, RefRangeEnd = 1107513, XrefRangeStart = 1107512, XrefRangeEnd = 1107512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref UpdatePresentationPostGraphSystem.__c__DisplayClass18_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107513, XrefRangeEnd = 1107515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1107530, RefRangeEnd = 1107531, XrefRangeStart = 1107515, XrefRangeEnd = 1107530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1107533, RefRangeEnd = 1107534, XrefRangeStart = 1107531, XrefRangeEnd = 1107533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        UpdatePresentationPostGraphSystem componentSystem,
        ref UpdatePresentationPostGraphSystem.__c__DisplayClass18_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdatePresentationPostGraphSystem_byref___c__DisplayClass18_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107534, XrefRangeEnd = 1107538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107538, XrefRangeEnd = 1107544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CanOutputEntity()
      {
        Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, "<>c__DisplayClass_CanOutputEntity");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr);
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, nameof (currentTime));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeFieldInfoPtr_currentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, nameof (currentFrame));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeFieldInfoPtr_particlesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, nameof (particlesEnabled));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeFieldInfoPtr_updateData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, nameof (updateData));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeFieldInfoPtr_visualEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, nameof (visualEffects));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeFieldInfoPtr_lineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, nameof (lineRenderers));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeFieldInfoPtr_particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, nameof (particles));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeFieldInfoPtr_particlePrefabsToWarmup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, nameof (particlePrefabsToWarmup));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, nameof (entityManager));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeFieldInfoPtr_additionalMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, nameof (additionalMaterials));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, nameof (_runtimes));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SequenceInstance_byref_DynamicBuffer_1_EventStateElement_byref_DynamicBuffer_1_BlackboardElement_byref_SequenceAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, 100687759);
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, 100687760);
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, 100687761);
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, 100687762);
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, 100687763);
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdatePresentationPostGraphSystem_byref___c__DisplayClass18_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, 100687764);
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, 100687765);
        UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, 100687766);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_sequenceInstance;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_eventStates;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_blackBoardBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_sequenceAsset;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdatePresentationPostGraphSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SequenceInstance> forParameter_sequenceInstance;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<EventStateElement> forParameter_eventStates;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_DynamicBuffer<BlackboardElement> forParameter_blackBoardBuffer;
        [FieldOffset(120)]
        public LambdaParameterValueProvider_IComponentData<SequenceAsset> forParameter_sequenceAsset;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1107405, RefRangeEnd = 1107406, XrefRangeStart = 1107392, XrefRangeEnd = 1107405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(UpdatePresentationPostGraphSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdatePresentationPostGraphSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1107419, RefRangeEnd = 1107420, XrefRangeStart = 1107406, XrefRangeEnd = 1107419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_sequenceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_sequenceInstance));
          UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_eventStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_eventStates));
          UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_blackBoardBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_blackBoardBuffer));
          UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_sequenceAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_sequenceAsset));
          UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdatePresentationPostGraphSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders>.NativeClassPtr, 100687767);
          UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders>.NativeClassPtr, 100687768);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_sequenceInstance;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_eventStates;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_blackBoardBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_sequenceAsset;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<SequenceInstance>.Runtime runtime_sequenceInstance;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<EventStateElement>.Runtime runtime_eventStates;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_DynamicBuffer<BlackboardElement>.Runtime runtime_blackBoardBuffer;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<SequenceAsset>.Runtime runtime_sequenceAsset;

          static Runtimes()
          {
            Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_sequenceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_sequenceInstance));
            UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_eventStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_eventStates));
            UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_blackBoardBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_blackBoardBuffer));
            UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_sequenceAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_sequenceAsset));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Sequencer.UpdatePresentationPostGraphSystem/ProjectM.Sequencer.<>c__DisplayClass_CanOutputEntity/ProjectM.Sequencer.RunWithoutJobSystem_000055BB$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, "RunWithoutJobSystem_000055BB$PostfixBurstDelegate");
          UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687769);
          UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687770);
          UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687771);
          UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687772);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Sequencer.UpdatePresentationPostGraphSystem/ProjectM.Sequencer.<>c__DisplayClass_CanOutputEntity/ProjectM.Sequencer.RunWithoutJobSystem_000055BB$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107420, XrefRangeEnd = 1107434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107434, XrefRangeEnd = 1107452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107452, XrefRangeEnd = 1107467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1107494, RefRangeEnd = 1107495, XrefRangeStart = 1107467, XrefRangeEnd = 1107494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity>.NativeClassPtr, "RunWithoutJobSystem_000055BB$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687773);
          UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687774);
          UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687775);
          UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687776);
          UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687778);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UpdatePresentationPostGraphSystem.__c__DisplayClass_CanOutputEntity.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.UpdatePresentationPostGraphSystem/ProjectM.Sequencer.<>c__DisplayClass_TheRest")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_TheRest
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_currentTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_updateData;
      private static readonly System.IntPtr NativeFieldInfoPtr_sounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_soundParameters;
      private static readonly System.IntPtr NativeFieldInfoPtr_windMotors;
      private static readonly System.IntPtr NativeFieldInfoPtr_voices;
      private static readonly System.IntPtr NativeFieldInfoPtr_volumes;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_materialProperties;
      private static readonly System.IntPtr NativeFieldInfoPtr_hideMaterials;
      private static readonly System.IntPtr NativeFieldInfoPtr_materialChangeEnabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_materialChanges;
      private static readonly System.IntPtr NativeFieldInfoPtr_cameraTargetSingleton;
      private static readonly System.IntPtr NativeFieldInfoPtr_zoomModifiers;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SequenceInstance_byref_DynamicBuffer_1_EventStateElement_byref_DynamicBuffer_1_BlackboardElement_byref_SequenceAsset_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdatePresentationPostGraphSystem_byref___c__DisplayClass18_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float currentTime;
      [FieldOffset(4)]
      public int currentFrame;
      [FieldOffset(8)]
      public UpdateData updateData;
      [FieldOffset(56)]
      public NativeList<SoundOutput> sounds;
      [FieldOffset(72)]
      public NativeList<SoundParameterOutput> soundParameters;
      [FieldOffset(88)]
      public NativeList<WindMotorOutput> windMotors;
      [FieldOffset(104)]
      public NativeList<VoiceEventOutput> voices;
      [FieldOffset(120)]
      public NativeList<VolumeProfileOutput> volumes;
      [FieldOffset(136)]
      public EntityManager entityManager;
      [FieldOffset(144)]
      public NativeList<MaterialPropertySystem.Entry> materialProperties;
      [FieldOffset(160)]
      public NativeList<HideMaterialSystem.MaterialEntry> hideMaterials;
      [FieldOffset(176)]
      public bool materialChangeEnabled;
      [FieldOffset(184)]
      public NativeList<MaterialChangeSystem.MaterialEntry> materialChanges;
      [FieldOffset(200)]
      public CameraTarget cameraTargetSingleton;
      [FieldOffset(208)]
      public NativeList<ZoomModifier> zoomModifiers;
      [FieldOffset(224)]
      public UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(376)]
      public unsafe UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107647, XrefRangeEnd = 1107693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref SequenceInstance sequenceInstance,
        ref DynamicBuffer<EventStateElement> eventStates,
        ref DynamicBuffer<BlackboardElement> blackBoardBuffer,
        [In] ref SequenceAsset sequenceAsset)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceInstance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventStates;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref blackBoardBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceAsset;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SequenceInstance_byref_DynamicBuffer_1_EventStateElement_byref_DynamicBuffer_1_BlackboardElement_byref_SequenceAsset_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1107693, RefRangeEnd = 1107694, XrefRangeStart = 1107693, XrefRangeEnd = 1107693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref UpdatePresentationPostGraphSystem.__c__DisplayClass18_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1107694, RefRangeEnd = 1107695, XrefRangeStart = 1107694, XrefRangeEnd = 1107694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref UpdatePresentationPostGraphSystem.__c__DisplayClass18_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107695, XrefRangeEnd = 1107697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1107712, RefRangeEnd = 1107713, XrefRangeStart = 1107697, XrefRangeEnd = 1107712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1107715, RefRangeEnd = 1107716, XrefRangeStart = 1107713, XrefRangeEnd = 1107715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        UpdatePresentationPostGraphSystem componentSystem,
        ref UpdatePresentationPostGraphSystem.__c__DisplayClass18_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdatePresentationPostGraphSystem_byref___c__DisplayClass18_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107716, XrefRangeEnd = 1107720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107720, XrefRangeEnd = 1107726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_TheRest()
      {
        Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem>.NativeClassPtr, "<>c__DisplayClass_TheRest");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr);
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (currentTime));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_currentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (currentFrame));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_updateData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (updateData));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_sounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (sounds));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_soundParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (soundParameters));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_windMotors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (windMotors));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_voices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (voices));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_volumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (volumes));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (entityManager));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_materialProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (materialProperties));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_hideMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (hideMaterials));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_materialChangeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (materialChangeEnabled));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_materialChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (materialChanges));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_cameraTargetSingleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (cameraTargetSingleton));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_zoomModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (zoomModifiers));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (_runtimes));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SequenceInstance_byref_DynamicBuffer_1_EventStateElement_byref_DynamicBuffer_1_BlackboardElement_byref_SequenceAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, 100687779);
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, 100687780);
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, 100687781);
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, 100687782);
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, 100687783);
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdatePresentationPostGraphSystem_byref___c__DisplayClass18_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, 100687784);
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, 100687785);
        UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, 100687786);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_sequenceInstance;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_eventStates;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_blackBoardBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_sequenceAsset;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdatePresentationPostGraphSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SequenceInstance> forParameter_sequenceInstance;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<EventStateElement> forParameter_eventStates;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_DynamicBuffer<BlackboardElement> forParameter_blackBoardBuffer;
        [FieldOffset(120)]
        public LambdaParameterValueProvider_IComponentData<SequenceAsset> forParameter_sequenceAsset;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1107557, RefRangeEnd = 1107558, XrefRangeStart = 1107544, XrefRangeEnd = 1107557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(UpdatePresentationPostGraphSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdatePresentationPostGraphSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1107571, RefRangeEnd = 1107572, XrefRangeStart = 1107558, XrefRangeEnd = 1107571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_sequenceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_sequenceInstance));
          UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_eventStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_eventStates));
          UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_blackBoardBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_blackBoardBuffer));
          UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_sequenceAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_sequenceAsset));
          UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdatePresentationPostGraphSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders>.NativeClassPtr, 100687787);
          UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders>.NativeClassPtr, 100687788);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_sequenceInstance;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_eventStates;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_blackBoardBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_sequenceAsset;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<SequenceInstance>.Runtime runtime_sequenceInstance;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<EventStateElement>.Runtime runtime_eventStates;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_DynamicBuffer<BlackboardElement>.Runtime runtime_blackBoardBuffer;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<SequenceAsset>.Runtime runtime_sequenceAsset;

          static Runtimes()
          {
            Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_sequenceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_sequenceInstance));
            UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_eventStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_eventStates));
            UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_blackBoardBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_blackBoardBuffer));
            UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_sequenceAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_sequenceAsset));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Sequencer.UpdatePresentationPostGraphSystem/ProjectM.Sequencer.<>c__DisplayClass_TheRest/ProjectM.Sequencer.RunWithoutJobSystem_000055C4$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, "RunWithoutJobSystem_000055C4$PostfixBurstDelegate");
          UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687789);
          UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687790);
          UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687791);
          UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687792);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Sequencer.UpdatePresentationPostGraphSystem/ProjectM.Sequencer.<>c__DisplayClass_TheRest/ProjectM.Sequencer.RunWithoutJobSystem_000055C4$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107572, XrefRangeEnd = 1107586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107586, XrefRangeEnd = 1107604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107604, XrefRangeEnd = 1107619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1107646, RefRangeEnd = 1107647, XrefRangeStart = 1107619, XrefRangeEnd = 1107646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest>.NativeClassPtr, "RunWithoutJobSystem_000055C4$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687793);
          UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687794);
          UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687795);
          UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687796);
          UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687798);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UpdatePresentationPostGraphSystem.__c__DisplayClass_TheRest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
