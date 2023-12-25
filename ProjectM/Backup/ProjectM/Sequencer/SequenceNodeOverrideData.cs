// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceNodeOverrideData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Stunlock.Fmod;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class SequenceNodeOverrideData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayOnStealthedUnits;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayInFlyMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimationCollectionGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParticleNodeOverrides;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScreenShakeNodeOverrides;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaterialChangeNodeOverrides;
    private static readonly System.IntPtr NativeFieldInfoPtr_SoundNodeOverrides;
    private static readonly System.IntPtr NativeFieldInfoPtr_WindMotorNodeOverrides;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimationNodeOverrides;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimatorParameterNodeOverrides;
    private static readonly System.IntPtr NativeFieldInfoPtr_FullscreenEffectNodeOverrides;
    private static readonly System.IntPtr NativeFieldInfoPtr_VoiceNodeOverrides;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlackboardParameters;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllOverrideLists_Private_List_1_IEnumerable_1_SequenceNodeOverride_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOverridenDurationIfExists_Public_Boolean_String_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetParticleOverrides_Public_ParticleNodeOverride_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetVisualEffectParameters_Public_List_1_VisualEffectOverride_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetScreenShake_Public_ScreenShakeNodeOverride_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSoundEvent_Public_FmodEvent_String_FmodEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSoundNodeOverride_Public_SoundNodeOverride_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWindMotorNodeOverride_Public_WindMotorNodeOverride_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAnimationOverride_Public_AnimationNodeOverride_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAnimatorParameterOverride_Public_AnimatorParameterNodeOverride_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterialChangeOverride_Public_MaterialChangeNodeOverride_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFullscreenEffect_Public_FullscreenEffectNodeOverride_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetVoiceType_Public_VoiceOverType_String_VoiceOverType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetVoiceNodeOverride_Public_VoiceNodeOverride_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDeterministicHash_Public_Int32_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGameObjectReferences_Internal_Il2CppReferenceArray_1_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasOverrides_Public_Boolean_SequenceEditorObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasAnyOverride_Private_Boolean_List_1_SequenceEditorNode_IEnumerable_1_SequenceNodeOverride_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_NodeExistsInExposedNodes_Private_Boolean_List_1_SequenceEditorNode_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ParameterExistsInExposedParameters_Private_Boolean_List_1_BlackboardParameter_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1098234, RefRangeEnd = 1098238, XrefRangeStart = 1098209, XrefRangeEnd = 1098234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<IEnumerable<SequenceNodeOverride>> GetAllOverrideLists()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_GetAllOverrideLists_Private_List_1_IEnumerable_1_SequenceNodeOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<IEnumerable<SequenceNodeOverride>>) null : new List<IEnumerable<SequenceNodeOverride>>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098238, XrefRangeEnd = 1098269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetOverridenDurationIfExists(string nodeGUID, ref bool overriddenDuration)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGUID);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref overriddenDuration;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_GetOverridenDurationIfExists_Public_Boolean_String_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1098287, RefRangeEnd = 1098288, XrefRangeStart = 1098269, XrefRangeEnd = 1098287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ParticleNodeOverride GetParticleOverrides(string nodeGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_GetParticleOverrides_Public_ParticleNodeOverride_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ParticleNodeOverride) null : new ParticleNodeOverride(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1098309, RefRangeEnd = 1098310, XrefRangeStart = 1098288, XrefRangeEnd = 1098309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<VisualEffectOverride> GetVisualEffectParameters(string particleNodeGUID)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(particleNodeGUID);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_GetVisualEffectParameters_Public_List_1_VisualEffectOverride_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<VisualEffectOverride>) null : new List<VisualEffectOverride>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098310, XrefRangeEnd = 1098328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ScreenShakeNodeOverride GetScreenShake(string nodeGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_GetScreenShake_Public_ScreenShakeNodeOverride_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ScreenShakeNodeOverride) null : new ScreenShakeNodeOverride(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098328, XrefRangeEnd = 1098346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FmodEvent GetSoundEvent(string nodeGuid, FmodEvent originalFmodEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) originalFmodEvent));
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_GetSoundEvent_Public_FmodEvent_String_FmodEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new FmodEvent(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098346, XrefRangeEnd = 1098364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SoundNodeOverride GetSoundNodeOverride(string nodeGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_GetSoundNodeOverride_Public_SoundNodeOverride_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SoundNodeOverride) null : new SoundNodeOverride(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098364, XrefRangeEnd = 1098383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WindMotorNodeOverride GetWindMotorNodeOverride(string nodeGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_GetWindMotorNodeOverride_Public_WindMotorNodeOverride_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (WindMotorNodeOverride) null : new WindMotorNodeOverride(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098383, XrefRangeEnd = 1098401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AnimationNodeOverride GetAnimationOverride(string nodeGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_GetAnimationOverride_Public_AnimationNodeOverride_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (AnimationNodeOverride) null : new AnimationNodeOverride(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098401, XrefRangeEnd = 1098419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AnimatorParameterNodeOverride GetAnimatorParameterOverride(string nodeGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_GetAnimatorParameterOverride_Public_AnimatorParameterNodeOverride_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (AnimatorParameterNodeOverride) null : new AnimatorParameterNodeOverride(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098419, XrefRangeEnd = 1098437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MaterialChangeNodeOverride GetMaterialChangeOverride(string nodeGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_GetMaterialChangeOverride_Public_MaterialChangeNodeOverride_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (MaterialChangeNodeOverride) null : new MaterialChangeNodeOverride(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098437, XrefRangeEnd = 1098455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FullscreenEffectNodeOverride GetFullscreenEffect(string nodeGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_GetFullscreenEffect_Public_FullscreenEffectNodeOverride_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (FullscreenEffectNodeOverride) null : new FullscreenEffectNodeOverride(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098455, XrefRangeEnd = 1098476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VoiceOverType GetVoiceType(string nodeGuid, VoiceOverType originalVoiceType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) originalVoiceType);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_GetVoiceType_Public_VoiceOverType_String_VoiceOverType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (VoiceOverType) null : new VoiceOverType(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098476, XrefRangeEnd = 1098494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VoiceNodeOverride GetVoiceNodeOverride(string nodeGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_GetVoiceNodeOverride_Public_VoiceNodeOverride_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (VoiceNodeOverride) null : new VoiceNodeOverride(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1098536, RefRangeEnd = 1098537, XrefRangeStart = 1098494, XrefRangeEnd = 1098536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetDeterministicHash(UnityEngine.Object sourceAsset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceAsset);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_GetDeterministicHash_Public_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1098573, RefRangeEnd = 1098574, XrefRangeStart = 1098537, XrefRangeEnd = 1098573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppReferenceArray<GameObject> GetGameObjectReferences()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_GetGameObjectReferences_Internal_Il2CppReferenceArray_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1098615, RefRangeEnd = 1098617, XrefRangeStart = 1098574, XrefRangeEnd = 1098615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasOverrides(SequenceEditorObject sequence)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sequence);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_HasOverrides_Public_Boolean_SequenceEditorObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1098636, RefRangeEnd = 1098637, XrefRangeStart = 1098617, XrefRangeEnd = 1098636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasAnyOverride(
      List<SequenceEditorNode> exposedNodes,
      IEnumerable<SequenceNodeOverride> nodes)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) exposedNodes);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) nodes);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_HasAnyOverride_Private_Boolean_List_1_SequenceEditorNode_IEnumerable_1_SequenceNodeOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098637, XrefRangeEnd = 1098642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool NodeExistsInExposedNodes(
      List<SequenceEditorNode> exposedNodes,
      string nodeGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) exposedNodes);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_NodeExistsInExposedNodes_Private_Boolean_List_1_SequenceEditorNode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098642, XrefRangeEnd = 1098647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ParameterExistsInExposedParameters(
      List<BlackboardParameter> exposedParameters,
      string parameterGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) exposedParameters);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(parameterGuid);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr_ParameterExistsInExposedParameters_Private_Boolean_List_1_BlackboardParameter_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1098718, RefRangeEnd = 1098720, XrefRangeStart = 1098647, XrefRangeEnd = 1098718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceNodeOverrideData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverrideData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequenceNodeOverrideData()
    {
      Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceNodeOverrideData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr);
      SequenceNodeOverrideData.NativeFieldInfoPtr_PlayOnStealthedUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, nameof (PlayOnStealthedUnits));
      SequenceNodeOverrideData.NativeFieldInfoPtr_PlayInFlyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, nameof (PlayInFlyMode));
      SequenceNodeOverrideData.NativeFieldInfoPtr_AnimationCollectionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, nameof (AnimationCollectionGUID));
      SequenceNodeOverrideData.NativeFieldInfoPtr_ParticleNodeOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, nameof (ParticleNodeOverrides));
      SequenceNodeOverrideData.NativeFieldInfoPtr_ScreenShakeNodeOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, nameof (ScreenShakeNodeOverrides));
      SequenceNodeOverrideData.NativeFieldInfoPtr_MaterialChangeNodeOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, nameof (MaterialChangeNodeOverrides));
      SequenceNodeOverrideData.NativeFieldInfoPtr_SoundNodeOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, nameof (SoundNodeOverrides));
      SequenceNodeOverrideData.NativeFieldInfoPtr_WindMotorNodeOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, nameof (WindMotorNodeOverrides));
      SequenceNodeOverrideData.NativeFieldInfoPtr_AnimationNodeOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, nameof (AnimationNodeOverrides));
      SequenceNodeOverrideData.NativeFieldInfoPtr_AnimatorParameterNodeOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, nameof (AnimatorParameterNodeOverrides));
      SequenceNodeOverrideData.NativeFieldInfoPtr_FullscreenEffectNodeOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, nameof (FullscreenEffectNodeOverrides));
      SequenceNodeOverrideData.NativeFieldInfoPtr_VoiceNodeOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, nameof (VoiceNodeOverrides));
      SequenceNodeOverrideData.NativeFieldInfoPtr_BlackboardParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, nameof (BlackboardParameters));
      SequenceNodeOverrideData.NativeMethodInfoPtr_GetAllOverrideLists_Private_List_1_IEnumerable_1_SequenceNodeOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687221);
      SequenceNodeOverrideData.NativeMethodInfoPtr_GetOverridenDurationIfExists_Public_Boolean_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687222);
      SequenceNodeOverrideData.NativeMethodInfoPtr_GetParticleOverrides_Public_ParticleNodeOverride_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687223);
      SequenceNodeOverrideData.NativeMethodInfoPtr_GetVisualEffectParameters_Public_List_1_VisualEffectOverride_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687224);
      SequenceNodeOverrideData.NativeMethodInfoPtr_GetScreenShake_Public_ScreenShakeNodeOverride_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687225);
      SequenceNodeOverrideData.NativeMethodInfoPtr_GetSoundEvent_Public_FmodEvent_String_FmodEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687226);
      SequenceNodeOverrideData.NativeMethodInfoPtr_GetSoundNodeOverride_Public_SoundNodeOverride_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687227);
      SequenceNodeOverrideData.NativeMethodInfoPtr_GetWindMotorNodeOverride_Public_WindMotorNodeOverride_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687228);
      SequenceNodeOverrideData.NativeMethodInfoPtr_GetAnimationOverride_Public_AnimationNodeOverride_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687229);
      SequenceNodeOverrideData.NativeMethodInfoPtr_GetAnimatorParameterOverride_Public_AnimatorParameterNodeOverride_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687230);
      SequenceNodeOverrideData.NativeMethodInfoPtr_GetMaterialChangeOverride_Public_MaterialChangeNodeOverride_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687231);
      SequenceNodeOverrideData.NativeMethodInfoPtr_GetFullscreenEffect_Public_FullscreenEffectNodeOverride_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687232);
      SequenceNodeOverrideData.NativeMethodInfoPtr_GetVoiceType_Public_VoiceOverType_String_VoiceOverType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687233);
      SequenceNodeOverrideData.NativeMethodInfoPtr_GetVoiceNodeOverride_Public_VoiceNodeOverride_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687234);
      SequenceNodeOverrideData.NativeMethodInfoPtr_GetDeterministicHash_Public_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687235);
      SequenceNodeOverrideData.NativeMethodInfoPtr_GetGameObjectReferences_Internal_Il2CppReferenceArray_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687236);
      SequenceNodeOverrideData.NativeMethodInfoPtr_HasOverrides_Public_Boolean_SequenceEditorObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687237);
      SequenceNodeOverrideData.NativeMethodInfoPtr_HasAnyOverride_Private_Boolean_List_1_SequenceEditorNode_IEnumerable_1_SequenceNodeOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687238);
      SequenceNodeOverrideData.NativeMethodInfoPtr_NodeExistsInExposedNodes_Private_Boolean_List_1_SequenceEditorNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687239);
      SequenceNodeOverrideData.NativeMethodInfoPtr_ParameterExistsInExposedParameters_Private_Boolean_List_1_BlackboardParameter_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687240);
      SequenceNodeOverrideData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverrideData>.NativeClassPtr, 100687241);
    }

    public SequenceNodeOverrideData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool PlayOnStealthedUnits
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_PlayOnStealthedUnits));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_PlayOnStealthedUnits)) = value;
      }
    }

    public unsafe bool PlayInFlyMode
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_PlayInFlyMode));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_PlayInFlyMode)) = value;
      }
    }

    public unsafe string AnimationCollectionGUID
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_AnimationCollectionGUID)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_AnimationCollectionGUID), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe List<ParticleNodeOverride> ParticleNodeOverrides
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_ParticleNodeOverrides));
        return pointer == System.IntPtr.Zero ? (List<ParticleNodeOverride>) null : new List<ParticleNodeOverride>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_ParticleNodeOverrides), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ScreenShakeNodeOverride> ScreenShakeNodeOverrides
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_ScreenShakeNodeOverrides));
        return pointer == System.IntPtr.Zero ? (List<ScreenShakeNodeOverride>) null : new List<ScreenShakeNodeOverride>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_ScreenShakeNodeOverrides), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<MaterialChangeNodeOverride> MaterialChangeNodeOverrides
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_MaterialChangeNodeOverrides));
        return pointer == System.IntPtr.Zero ? (List<MaterialChangeNodeOverride>) null : new List<MaterialChangeNodeOverride>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_MaterialChangeNodeOverrides), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SoundNodeOverride> SoundNodeOverrides
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_SoundNodeOverrides));
        return pointer == System.IntPtr.Zero ? (List<SoundNodeOverride>) null : new List<SoundNodeOverride>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_SoundNodeOverrides), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<WindMotorNodeOverride> WindMotorNodeOverrides
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_WindMotorNodeOverrides));
        return pointer == System.IntPtr.Zero ? (List<WindMotorNodeOverride>) null : new List<WindMotorNodeOverride>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_WindMotorNodeOverrides), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<AnimationNodeOverride> AnimationNodeOverrides
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_AnimationNodeOverrides));
        return pointer == System.IntPtr.Zero ? (List<AnimationNodeOverride>) null : new List<AnimationNodeOverride>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_AnimationNodeOverrides), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<AnimatorParameterNodeOverride> AnimatorParameterNodeOverrides
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_AnimatorParameterNodeOverrides));
        return pointer == System.IntPtr.Zero ? (List<AnimatorParameterNodeOverride>) null : new List<AnimatorParameterNodeOverride>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_AnimatorParameterNodeOverrides), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<FullscreenEffectNodeOverride> FullscreenEffectNodeOverrides
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_FullscreenEffectNodeOverrides));
        return pointer == System.IntPtr.Zero ? (List<FullscreenEffectNodeOverride>) null : new List<FullscreenEffectNodeOverride>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_FullscreenEffectNodeOverrides), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<VoiceNodeOverride> VoiceNodeOverrides
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_VoiceNodeOverrides));
        return pointer == System.IntPtr.Zero ? (List<VoiceNodeOverride>) null : new List<VoiceNodeOverride>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_VoiceNodeOverrides), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<BlackboardParameterMapper> BlackboardParameters
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_BlackboardParameters));
        return pointer == System.IntPtr.Zero ? (List<BlackboardParameterMapper>) null : new List<BlackboardParameterMapper>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverrideData.NativeFieldInfoPtr_BlackboardParameters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
