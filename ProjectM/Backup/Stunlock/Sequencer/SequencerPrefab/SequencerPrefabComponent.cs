// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.SequencerPrefab.SequencerPrefabComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Sequencer;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Stunlock.Sequencer.SequencerPrefab
{
  public class SequencerPrefabComponent : MonoBehaviour
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSequenceData_Public_Abstract_Virtual_New_List_1_SequencerEventBuilder_BlackboardBuilder_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetDurationData_Protected_Void_BlackboardBuilder_TriggerAndTimingData_SequencerEventBuilder_byref_BlackboardParameterBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBeamData_Protected_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_byref_VFXControllerData_ParticleEventBuilder_BlackboardParameterBuilder_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupBeamOriginData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_byref_VFXControllerData_ParticleEventBuilder_BlackboardParameterBuilder_BlackboardRegister_Int32_BlackboardParameterValue_Boolean_String_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTransformationData_Protected_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_ParticleEventBuilder_BlackboardParameterBuilder_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupOriginData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_OriginType_byref_TransformationData_ParticleEventBuilder_BlackboardParameterBuilder_BlackboardRegister_Boolean_Boolean_Int32_BlackboardParameterValue_BlackboardParameterValue_Boolean_String_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupWorldGraphData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_ParticleEventBuilder_BlackboardRegister_Boolean_Boolean_Boolean_String_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupWorldGraphData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_BlackboardRegister_Boolean_String_byref_String_String_String_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupBoneGraphData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_BlackboardParameterBuilder_BlackboardRegister_Boolean_String_byref_String_String_String_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupLocalGraphData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_BlackboardParameterBuilder_BlackboardRegister_Boolean_String_byref_String_String_String_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupLocalGraphData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_ParticleEventBuilder_BlackboardParameterBuilder_BlackboardRegister_Boolean_Boolean_Boolean_String_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupBoneGraphData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_ParticleEventBuilder_BlackboardParameterBuilder_BlackboardRegister_Boolean_Boolean_Boolean_String_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRegisterIfExists_Public_Static_Boolean_BlackboardBuilder_String_byref_BlackboardRegister_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateFlowNode_Protected_Static_FlowEventBuilder_FlowTypeEnum_BlackboardParameterBuilder_BlackboardParameterBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateNewParameter_Public_Static_BlackboardParameterBuilder_BlackboardBuilder_BlackboardRegisterType_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OffsetPosition_Private_GraphEventBuilder_BlackboardBuilder_String_String_Boolean_BlackboardParameterBuilder_float3_String_String_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OffsetPosition_Private_GraphEventBuilder_BlackboardBuilder_String_String_Boolean_BlackboardParameterBuilder_float3_BlackboardRegister_String_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OffsetPosition_Private_GraphEventBuilder_BlackboardBuilder_String_String_Boolean_BlackboardParameterBuilder_float3_BlackboardParameterBuilder_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OffsetRotation_Private_GraphEventBuilder_BlackboardBuilder_String_String_Boolean_BlackboardParameterBuilder_float3_BlackboardParameterBuilder_Int32_byref_BlackboardParameterBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildGraphNode_Private_GraphEventBuilder_SequenceGraphLibraryTag_String_String_Boolean_BlackboardParameterBuilder_UnityAction_4_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNodesRecursive_Private_Void_SequenceGraphData_SequenceGraphNode_GraphBuilder_BlackboardBuilder_HashSet_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConnectionGuid_Private_String_GraphNodeInSocket_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    [CallerCount(0)]
    public virtual unsafe List<SequencerEventBuilder> GetSequenceData(
      BlackboardBuilder blackboardBuilder,
      int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequencerPrefabComponent.NativeMethodInfoPtr_GetSequenceData_Public_Abstract_Virtual_New_List_1_SequencerEventBuilder_BlackboardBuilder_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<SequencerEventBuilder>) null : new List<SequencerEventBuilder>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 924795, RefRangeEnd = 924796, XrefRangeStart = 924788, XrefRangeEnd = 924795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetDurationData(
      BlackboardBuilder blackboardBuilder,
      TriggerAndTimingData timingData,
      SequencerEventBuilder outNode,
      out BlackboardParameterBuilder durationParameter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &timingData;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outNode);
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_SetDurationData_Protected_Void_BlackboardBuilder_TriggerAndTimingData_SequencerEventBuilder_byref_BlackboardParameterBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref BlackboardParameterBuilder local = ref durationParameter;
      System.IntPtr pointer = zero;
      BlackboardParameterBuilder parameterBuilder = pointer == System.IntPtr.Zero ? (BlackboardParameterBuilder) null : new BlackboardParameterBuilder(pointer);
      local = parameterBuilder;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 924820, RefRangeEnd = 924821, XrefRangeStart = 924796, XrefRangeEnd = 924820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetBeamData(
      BlackboardBuilder blackboardBuilder,
      ref List<SequencerEventBuilder> children,
      ref VFXControllerData entry,
      ParticleEventBuilder eventBuilder,
      BlackboardParameterBuilder durationParameter,
      bool infiniteDuration,
      int effectIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[7];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr1 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) children);
      System.IntPtr* numPtr2 = &ptr1;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      System.IntPtr* numPtr3 = &ptr2;
      *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) durationParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &infiniteDuration;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &effectIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_SetBeamData_Protected_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_byref_VFXControllerData_ParticleEventBuilder_BlackboardParameterBuilder_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<SequencerEventBuilder> local1 = ref children;
      System.IntPtr pointer1 = ptr1;
      List<> list = pointer1 == System.IntPtr.Zero ? (List<>) null : new List<>(pointer1);
      local1 = (List<SequencerEventBuilder>) list;
      ref VFXControllerData local2 = ref entry;
      System.IntPtr pointer2 = ptr2;
      VFXControllerData vfxControllerData = pointer2 == System.IntPtr.Zero ? (VFXControllerData) null : new VFXControllerData(pointer2);
      local2 = vfxControllerData;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 924885, RefRangeEnd = 924886, XrefRangeStart = 924821, XrefRangeEnd = 924885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupBeamOriginData(
      BlackboardBuilder blackboardBuilder,
      ref List<SequencerEventBuilder> children,
      ref VFXControllerData entry,
      ParticleEventBuilder eventBuilder,
      BlackboardParameterBuilder durationParameter,
      BlackboardRegister entityParameter,
      int registerIndex,
      BlackboardParameterValue posParam,
      bool infiniteDuration,
      string graphDurationGuid,
      string graphTimeGuid,
      int effectIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[12];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr1 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) children);
      System.IntPtr* numPtr2 = &ptr1;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      System.IntPtr* numPtr3 = &ptr2;
      *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) durationParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) entityParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &registerIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) posParam));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &infiniteDuration;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphDurationGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphTimeGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &effectIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_SetupBeamOriginData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_byref_VFXControllerData_ParticleEventBuilder_BlackboardParameterBuilder_BlackboardRegister_Int32_BlackboardParameterValue_Boolean_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<SequencerEventBuilder> local1 = ref children;
      System.IntPtr pointer1 = ptr1;
      List<> list = pointer1 == System.IntPtr.Zero ? (List<>) null : new List<>(pointer1);
      local1 = (List<SequencerEventBuilder>) list;
      ref VFXControllerData local2 = ref entry;
      System.IntPtr pointer2 = ptr2;
      VFXControllerData vfxControllerData = pointer2 == System.IntPtr.Zero ? (VFXControllerData) null : new VFXControllerData(pointer2);
      local2 = vfxControllerData;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 924930, RefRangeEnd = 924931, XrefRangeStart = 924886, XrefRangeEnd = 924930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetTransformationData(
      BlackboardBuilder blackboardBuilder,
      ref List<SequencerEventBuilder> children,
      TransformationData transformationData,
      ParticleEventBuilder eventBuilder,
      BlackboardParameterBuilder durationParameter,
      bool infiniteDuration,
      int effectIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[7];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) children);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transformationData);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) durationParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &infiniteDuration;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &effectIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_SetTransformationData_Protected_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_ParticleEventBuilder_BlackboardParameterBuilder_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<SequencerEventBuilder> local = ref children;
      System.IntPtr pointer = ptr;
      List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<SequencerEventBuilder>) list;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 924951, RefRangeEnd = 924953, XrefRangeStart = 924931, XrefRangeEnd = 924951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupOriginData(
      BlackboardBuilder blackboardBuilder,
      ref List<SequencerEventBuilder> children,
      OriginType originType,
      [In] ref TransformationData transformationData,
      ParticleEventBuilder eventBuilder,
      BlackboardParameterBuilder durationParameter,
      BlackboardRegister entityParameter,
      bool buildPosParam,
      bool buildRotParam,
      int registerIndex,
      BlackboardParameterValue posParam,
      BlackboardParameterValue rotParam,
      bool infiniteDuration,
      string graphDurationGuid,
      string graphTimeGuid,
      int effectIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[16];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr1 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) children);
      System.IntPtr* numPtr2 = &ptr1;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &originType;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transformationData);
      System.IntPtr* numPtr3 = &ptr2;
      *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) durationParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) entityParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &buildPosParam;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &buildRotParam;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &registerIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) posParam));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) rotParam));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = (System.IntPtr) &infiniteDuration;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(13) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphDurationGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(14) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphTimeGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(15) * sizeof (System.IntPtr))) = (System.IntPtr) &effectIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_SetupOriginData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_OriginType_byref_TransformationData_ParticleEventBuilder_BlackboardParameterBuilder_BlackboardRegister_Boolean_Boolean_Int32_BlackboardParameterValue_BlackboardParameterValue_Boolean_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<SequencerEventBuilder> local1 = ref children;
      System.IntPtr pointer1 = ptr1;
      List<> list = pointer1 == System.IntPtr.Zero ? (List<>) null : new List<>(pointer1);
      local1 = (List<SequencerEventBuilder>) list;
      ref TransformationData local2 = ref transformationData;
      System.IntPtr pointer2 = ptr2;
      TransformationData transformationData1 = pointer2 == System.IntPtr.Zero ? (TransformationData) null : new TransformationData(pointer2);
      local2 = transformationData1;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924953, XrefRangeEnd = 924993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupWorldGraphData(
      BlackboardBuilder blackboardBuilder,
      ref List<SequencerEventBuilder> children,
      TransformationData transformationData,
      ParticleEventBuilder eventBuilder,
      BlackboardRegister entityParameter,
      bool buildPosParam,
      bool buildRotParam,
      bool infiniteDuration,
      string graphDurationGuid,
      string graphTimeGuid,
      int effectIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[11];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) children);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transformationData);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) entityParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &buildPosParam;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &buildRotParam;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &infiniteDuration;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphDurationGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphTimeGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &effectIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_SetupWorldGraphData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_ParticleEventBuilder_BlackboardRegister_Boolean_Boolean_Boolean_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<SequencerEventBuilder> local = ref children;
      System.IntPtr pointer = ptr;
      List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<SequencerEventBuilder>) list;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924993, XrefRangeEnd = 925022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupWorldGraphData(
      BlackboardBuilder blackboardBuilder,
      ref List<SequencerEventBuilder> children,
      TransformationData transformationData,
      BlackboardRegister entityParameter,
      bool infiniteDuration,
      string prefix,
      out string positionListenerParamName,
      string graphDurationGuid,
      string graphTimeGuid,
      out string posParamGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[10];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) children);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transformationData);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) entityParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &infiniteDuration;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr));
      System.IntPtr zero1 = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero1;
      *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphDurationGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphTimeGuid);
      System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(9) * sizeof (System.IntPtr));
      System.IntPtr zero2 = System.IntPtr.Zero;
      System.IntPtr* numPtr4 = &zero2;
      *(System.IntPtr*) num3 = (System.IntPtr) numPtr4;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_SetupWorldGraphData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_BlackboardRegister_Boolean_String_byref_String_String_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<SequencerEventBuilder> local = ref children;
      System.IntPtr pointer = ptr;
      List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<SequencerEventBuilder>) list;
      positionListenerParamName = IL2CPP.Il2CppStringToManaged(zero1);
      posParamGuid = IL2CPP.Il2CppStringToManaged(zero2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925022, XrefRangeEnd = 925051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupBoneGraphData(
      BlackboardBuilder blackboardBuilder,
      ref List<SequencerEventBuilder> children,
      TransformationData transformationData,
      BlackboardParameterBuilder durationParameter,
      BlackboardRegister entityParameter,
      bool infiniteDuration,
      string prefix,
      out string positionListenerParamName,
      string graphDurationGuid,
      string graphTimeGuid,
      out string posParamGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[11];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) children);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transformationData);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) durationParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) entityParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &infiniteDuration;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr));
      System.IntPtr zero1 = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero1;
      *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphDurationGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphTimeGuid);
      System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(10) * sizeof (System.IntPtr));
      System.IntPtr zero2 = System.IntPtr.Zero;
      System.IntPtr* numPtr4 = &zero2;
      *(System.IntPtr*) num3 = (System.IntPtr) numPtr4;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_SetupBoneGraphData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_BlackboardParameterBuilder_BlackboardRegister_Boolean_String_byref_String_String_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<SequencerEventBuilder> local = ref children;
      System.IntPtr pointer = ptr;
      List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<SequencerEventBuilder>) list;
      positionListenerParamName = IL2CPP.Il2CppStringToManaged(zero1);
      posParamGuid = IL2CPP.Il2CppStringToManaged(zero2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925051, XrefRangeEnd = 925080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupLocalGraphData(
      BlackboardBuilder blackboardBuilder,
      ref List<SequencerEventBuilder> children,
      TransformationData transformationData,
      BlackboardParameterBuilder durationParameter,
      BlackboardRegister entityParameter,
      bool infiniteDuration,
      string prefix,
      out string positionListenerParamName,
      string graphDurationGuid,
      string graphTimeGuid,
      out string posParamGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[11];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) children);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transformationData);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) durationParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) entityParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &infiniteDuration;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr));
      System.IntPtr zero1 = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero1;
      *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphDurationGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphTimeGuid);
      System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(10) * sizeof (System.IntPtr));
      System.IntPtr zero2 = System.IntPtr.Zero;
      System.IntPtr* numPtr4 = &zero2;
      *(System.IntPtr*) num3 = (System.IntPtr) numPtr4;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_SetupLocalGraphData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_BlackboardParameterBuilder_BlackboardRegister_Boolean_String_byref_String_String_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<SequencerEventBuilder> local = ref children;
      System.IntPtr pointer = ptr;
      List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<SequencerEventBuilder>) list;
      positionListenerParamName = IL2CPP.Il2CppStringToManaged(zero1);
      posParamGuid = IL2CPP.Il2CppStringToManaged(zero2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925080, XrefRangeEnd = 925123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupLocalGraphData(
      BlackboardBuilder blackboardBuilder,
      ref List<SequencerEventBuilder> children,
      TransformationData transformationData,
      ParticleEventBuilder eventBuilder,
      BlackboardParameterBuilder durationParameter,
      BlackboardRegister entityParameter,
      bool buildPosParam,
      bool buildRotParam,
      bool infiniteDuration,
      string graphDurationGuid,
      string graphTimeGuid,
      int effectIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[12];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) children);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transformationData);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) durationParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) entityParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &buildPosParam;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &buildRotParam;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &infiniteDuration;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphDurationGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphTimeGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &effectIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_SetupLocalGraphData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_ParticleEventBuilder_BlackboardParameterBuilder_BlackboardRegister_Boolean_Boolean_Boolean_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<SequencerEventBuilder> local = ref children;
      System.IntPtr pointer = ptr;
      List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<SequencerEventBuilder>) list;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925123, XrefRangeEnd = 925167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupBoneGraphData(
      BlackboardBuilder blackboardBuilder,
      ref List<SequencerEventBuilder> children,
      TransformationData transformationData,
      ParticleEventBuilder eventBuilder,
      BlackboardParameterBuilder durationParameter,
      BlackboardRegister entityParameter,
      bool buildPosParam,
      bool buildRotParam,
      bool infiniteDuration,
      string graphDurationGuid,
      string graphTimeGuid,
      int effectIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[12];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) children);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transformationData);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) durationParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) entityParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &buildPosParam;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &buildRotParam;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &infiniteDuration;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphDurationGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphTimeGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &effectIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_SetupBoneGraphData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_ParticleEventBuilder_BlackboardParameterBuilder_BlackboardRegister_Boolean_Boolean_Boolean_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<SequencerEventBuilder> local = ref children;
      System.IntPtr pointer = ptr;
      List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<SequencerEventBuilder>) list;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 925168, RefRangeEnd = 925170, XrefRangeStart = 925167, XrefRangeEnd = 925168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetRegisterIfExists(
      BlackboardBuilder blackboardBuilder,
      string registerName,
      out BlackboardRegister register)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(registerName);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_GetRegisterIfExists_Public_Static_Boolean_BlackboardBuilder_String_byref_BlackboardRegister_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref BlackboardRegister local = ref register;
      System.IntPtr pointer = zero;
      BlackboardRegister blackboardRegister = pointer == System.IntPtr.Zero ? (BlackboardRegister) null : new BlackboardRegister(pointer);
      local = blackboardRegister;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 925184, RefRangeEnd = 925186, XrefRangeStart = 925170, XrefRangeEnd = 925184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe FlowEventBuilder CreateFlowNode(
      FlowTypeEnum flowType,
      BlackboardParameterBuilder speedParam,
      BlackboardParameterBuilder repeatsParam)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &flowType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) speedParam));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) repeatsParam));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_CreateFlowNode_Protected_Static_FlowEventBuilder_FlowTypeEnum_BlackboardParameterBuilder_BlackboardParameterBuilder_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (FlowEventBuilder) null : new FlowEventBuilder(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925186, XrefRangeEnd = 925188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BlackboardParameterBuilder CreateNewParameter(
      BlackboardBuilder blackboardBuilder,
      BlackboardRegisterType type,
      string name)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_CreateNewParameter_Public_Static_BlackboardParameterBuilder_BlackboardBuilder_BlackboardRegisterType_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new BlackboardParameterBuilder(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925188, XrefRangeEnd = 925214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GraphEventBuilder OffsetPosition(
      BlackboardBuilder blackboardBuilder,
      string graphDurationGuid,
      string graphTimeGuid,
      bool infiniteDuration,
      BlackboardParameterBuilder durationParameter,
      float3 offset,
      string positionParameterGuid,
      string prefix,
      out string offsetPositionParameterName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[9];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphDurationGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphTimeGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &infiniteDuration;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) durationParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(positionParameterGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(8) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_OffsetPosition_Private_GraphEventBuilder_BlackboardBuilder_String_String_Boolean_BlackboardParameterBuilder_float3_String_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      offsetPositionParameterName = IL2CPP.Il2CppStringToManaged(zero);
      System.IntPtr pointer = num2;
      return pointer == System.IntPtr.Zero ? (GraphEventBuilder) null : new GraphEventBuilder(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925214, XrefRangeEnd = 925240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GraphEventBuilder OffsetPosition(
      BlackboardBuilder blackboardBuilder,
      string graphDurationGuid,
      string graphTimeGuid,
      bool infiniteDuration,
      BlackboardParameterBuilder durationParameter,
      float3 offset,
      BlackboardRegister positionParameter,
      string prefix,
      out string offsetPositionParameterName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[9];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphDurationGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphTimeGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &infiniteDuration;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) durationParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) positionParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(8) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_OffsetPosition_Private_GraphEventBuilder_BlackboardBuilder_String_String_Boolean_BlackboardParameterBuilder_float3_BlackboardRegister_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      offsetPositionParameterName = IL2CPP.Il2CppStringToManaged(zero);
      System.IntPtr pointer = num2;
      return pointer == System.IntPtr.Zero ? (GraphEventBuilder) null : new GraphEventBuilder(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 925262, RefRangeEnd = 925263, XrefRangeStart = 925240, XrefRangeEnd = 925262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GraphEventBuilder OffsetPosition(
      BlackboardBuilder blackboardBuilder,
      string graphDurationGuid,
      string graphTimeGuid,
      bool infiniteDuration,
      BlackboardParameterBuilder durationParameter,
      float3 offset,
      BlackboardParameterBuilder positionParameter,
      out string offsetPositionParameterGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[8];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphDurationGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphTimeGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &infiniteDuration;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) durationParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) positionParameter));
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_OffsetPosition_Private_GraphEventBuilder_BlackboardBuilder_String_String_Boolean_BlackboardParameterBuilder_float3_BlackboardParameterBuilder_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      offsetPositionParameterGuid = IL2CPP.Il2CppStringToManaged(zero);
      System.IntPtr pointer = num2;
      return pointer == System.IntPtr.Zero ? (GraphEventBuilder) null : new GraphEventBuilder(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 925292, RefRangeEnd = 925293, XrefRangeStart = 925263, XrefRangeEnd = 925292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GraphEventBuilder OffsetRotation(
      BlackboardBuilder blackboardBuilder,
      string graphDurationGuid,
      string graphTimeGuid,
      bool infiniteDuration,
      BlackboardParameterBuilder durationParameter,
      float3 offset,
      BlackboardParameterBuilder rotationParameter,
      int effectIndex,
      out BlackboardParameterBuilder newRotationParameter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[9];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphDurationGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphTimeGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &infiniteDuration;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) durationParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) rotationParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &effectIndex;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(8) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_OffsetRotation_Private_GraphEventBuilder_BlackboardBuilder_String_String_Boolean_BlackboardParameterBuilder_float3_BlackboardParameterBuilder_Int32_byref_BlackboardParameterBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref BlackboardParameterBuilder local = ref newRotationParameter;
      System.IntPtr pointer1 = zero;
      BlackboardParameterBuilder parameterBuilder = pointer1 == System.IntPtr.Zero ? (BlackboardParameterBuilder) null : new BlackboardParameterBuilder(pointer1);
      local = parameterBuilder;
      System.IntPtr pointer2 = num2;
      return pointer2 == System.IntPtr.Zero ? (GraphEventBuilder) null : new GraphEventBuilder(pointer2);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 925355, RefRangeEnd = 925365, XrefRangeStart = 925293, XrefRangeEnd = 925355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GraphEventBuilder BuildGraphNode(
      SequenceGraphLibraryTag graphTag,
      string graphDurationGuid,
      string graphTimeGuid,
      bool infiniteDuration,
      BlackboardParameterBuilder durationParameter,
      UnityAction<GraphBuilder, SequenceGraphData, List<SequenceEditorNode_Graph.BlackboardGraphMapping>, List<SequenceEditorNode_Graph.BlackboardGraphMapping>> setupInputOutputFunc)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &graphTag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphDurationGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(graphTimeGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &infiniteDuration;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) durationParameter));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) setupInputOutputFunc);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_BuildGraphNode_Private_GraphEventBuilder_SequenceGraphLibraryTag_String_String_Boolean_BlackboardParameterBuilder_UnityAction_4_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GraphEventBuilder) null : new GraphEventBuilder(pointer);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 925398, RefRangeEnd = 925409, XrefRangeStart = 925365, XrefRangeEnd = 925398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddNodesRecursive(
      SequenceGraphData graphData,
      SequenceGraphNode graphNode,
      GraphBuilder graphBuilder,
      BlackboardBuilder blackboardBuilder,
      HashSet<string> processedNodes)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphNode);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) processedNodes);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_AddNodesRecursive_Private_Void_SequenceGraphData_SequenceGraphNode_GraphBuilder_BlackboardBuilder_HashSet_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 925410, RefRangeEnd = 925426, XrefRangeStart = 925409, XrefRangeEnd = 925410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetConnectionGuid(GraphNodeInSocket inSocket)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inSocket);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr_GetConnectionGuid_Private_String_GraphNodeInSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequencerPrefabComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequencerPrefabComponent()
    {
      Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer.SequencerPrefab", nameof (SequencerPrefabComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr);
      SequencerPrefabComponent.NativeMethodInfoPtr_GetSequenceData_Public_Abstract_Virtual_New_List_1_SequencerEventBuilder_BlackboardBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663920);
      SequencerPrefabComponent.NativeMethodInfoPtr_SetDurationData_Protected_Void_BlackboardBuilder_TriggerAndTimingData_SequencerEventBuilder_byref_BlackboardParameterBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663921);
      SequencerPrefabComponent.NativeMethodInfoPtr_SetBeamData_Protected_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_byref_VFXControllerData_ParticleEventBuilder_BlackboardParameterBuilder_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663922);
      SequencerPrefabComponent.NativeMethodInfoPtr_SetupBeamOriginData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_byref_VFXControllerData_ParticleEventBuilder_BlackboardParameterBuilder_BlackboardRegister_Int32_BlackboardParameterValue_Boolean_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663923);
      SequencerPrefabComponent.NativeMethodInfoPtr_SetTransformationData_Protected_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_ParticleEventBuilder_BlackboardParameterBuilder_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663924);
      SequencerPrefabComponent.NativeMethodInfoPtr_SetupOriginData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_OriginType_byref_TransformationData_ParticleEventBuilder_BlackboardParameterBuilder_BlackboardRegister_Boolean_Boolean_Int32_BlackboardParameterValue_BlackboardParameterValue_Boolean_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663925);
      SequencerPrefabComponent.NativeMethodInfoPtr_SetupWorldGraphData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_ParticleEventBuilder_BlackboardRegister_Boolean_Boolean_Boolean_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663926);
      SequencerPrefabComponent.NativeMethodInfoPtr_SetupWorldGraphData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_BlackboardRegister_Boolean_String_byref_String_String_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663927);
      SequencerPrefabComponent.NativeMethodInfoPtr_SetupBoneGraphData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_BlackboardParameterBuilder_BlackboardRegister_Boolean_String_byref_String_String_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663928);
      SequencerPrefabComponent.NativeMethodInfoPtr_SetupLocalGraphData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_BlackboardParameterBuilder_BlackboardRegister_Boolean_String_byref_String_String_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663929);
      SequencerPrefabComponent.NativeMethodInfoPtr_SetupLocalGraphData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_ParticleEventBuilder_BlackboardParameterBuilder_BlackboardRegister_Boolean_Boolean_Boolean_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663930);
      SequencerPrefabComponent.NativeMethodInfoPtr_SetupBoneGraphData_Private_Void_BlackboardBuilder_byref_List_1_SequencerEventBuilder_TransformationData_ParticleEventBuilder_BlackboardParameterBuilder_BlackboardRegister_Boolean_Boolean_Boolean_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663931);
      SequencerPrefabComponent.NativeMethodInfoPtr_GetRegisterIfExists_Public_Static_Boolean_BlackboardBuilder_String_byref_BlackboardRegister_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663932);
      SequencerPrefabComponent.NativeMethodInfoPtr_CreateFlowNode_Protected_Static_FlowEventBuilder_FlowTypeEnum_BlackboardParameterBuilder_BlackboardParameterBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663933);
      SequencerPrefabComponent.NativeMethodInfoPtr_CreateNewParameter_Public_Static_BlackboardParameterBuilder_BlackboardBuilder_BlackboardRegisterType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663934);
      SequencerPrefabComponent.NativeMethodInfoPtr_OffsetPosition_Private_GraphEventBuilder_BlackboardBuilder_String_String_Boolean_BlackboardParameterBuilder_float3_String_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663935);
      SequencerPrefabComponent.NativeMethodInfoPtr_OffsetPosition_Private_GraphEventBuilder_BlackboardBuilder_String_String_Boolean_BlackboardParameterBuilder_float3_BlackboardRegister_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663936);
      SequencerPrefabComponent.NativeMethodInfoPtr_OffsetPosition_Private_GraphEventBuilder_BlackboardBuilder_String_String_Boolean_BlackboardParameterBuilder_float3_BlackboardParameterBuilder_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663937);
      SequencerPrefabComponent.NativeMethodInfoPtr_OffsetRotation_Private_GraphEventBuilder_BlackboardBuilder_String_String_Boolean_BlackboardParameterBuilder_float3_BlackboardParameterBuilder_Int32_byref_BlackboardParameterBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663938);
      SequencerPrefabComponent.NativeMethodInfoPtr_BuildGraphNode_Private_GraphEventBuilder_SequenceGraphLibraryTag_String_String_Boolean_BlackboardParameterBuilder_UnityAction_4_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663939);
      SequencerPrefabComponent.NativeMethodInfoPtr_AddNodesRecursive_Private_Void_SequenceGraphData_SequenceGraphNode_GraphBuilder_BlackboardBuilder_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663940);
      SequencerPrefabComponent.NativeMethodInfoPtr_GetConnectionGuid_Private_String_GraphNodeInSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663941);
      SequencerPrefabComponent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, 100663942);
    }

    public SequencerPrefabComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("Stunlock.Sequencer.SequencerPrefab.SequencerPrefabComponent/<>c__DisplayClass6_0")]
    public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_blackboardBuilder;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityParameter;
      private static readonly System.IntPtr NativeFieldInfoPtr_transformationData;
      private static readonly System.IntPtr NativeFieldInfoPtr_buildPosParam;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_eventBuilder;
      private static readonly System.IntPtr NativeFieldInfoPtr_buildRotParam;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupWorldGraphData_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass6_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924223, XrefRangeEnd = 924289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupWorldGraphData_b__0(
        GraphBuilder graphBuilder,
        SequenceGraphData graphData,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> inputs,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> outputs)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphBuilder);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphData);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputs);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outputs);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass6_0.NativeMethodInfoPtr__SetupWorldGraphData_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass6_0()
      {
        Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, "<>c__DisplayClass6_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass6_0>.NativeClassPtr);
        SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr_blackboardBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass6_0>.NativeClassPtr, nameof (blackboardBuilder));
        SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr_entityParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass6_0>.NativeClassPtr, nameof (entityParameter));
        SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr_transformationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass6_0>.NativeClassPtr, nameof (transformationData));
        SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr_buildPosParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass6_0>.NativeClassPtr, nameof (buildPosParam));
        SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
        SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr_eventBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass6_0>.NativeClassPtr, nameof (eventBuilder));
        SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr_buildRotParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass6_0>.NativeClassPtr, nameof (buildRotParam));
        SequencerPrefabComponent.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass6_0>.NativeClassPtr, 100663943);
        SequencerPrefabComponent.__c__DisplayClass6_0.NativeMethodInfoPtr__SetupWorldGraphData_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass6_0>.NativeClassPtr, 100663944);
      }

      public __c__DisplayClass6_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe BlackboardBuilder blackboardBuilder
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr_blackboardBuilder));
          return pointer == System.IntPtr.Zero ? (BlackboardBuilder) null : new BlackboardBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr_blackboardBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public BlackboardRegister entityParameter
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr_entityParameter);
          return new BlackboardRegister(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardRegister>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr_entityParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardRegister>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe TransformationData transformationData
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr_transformationData));
          return pointer == System.IntPtr.Zero ? (TransformationData) null : new TransformationData(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr_transformationData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool buildPosParam
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr_buildPosParam));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr_buildPosParam)) = value;
        }
      }

      public unsafe SequencerPrefabComponent __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SequencerPrefabComponent) null : new SequencerPrefabComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ParticleEventBuilder eventBuilder
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr_eventBuilder));
          return pointer == System.IntPtr.Zero ? (ParticleEventBuilder) null : new ParticleEventBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr_eventBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool buildRotParam
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr_buildRotParam));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass6_0.NativeFieldInfoPtr_buildRotParam)) = value;
        }
      }
    }

    [ObfuscatedName("Stunlock.Sequencer.SequencerPrefab.SequencerPrefabComponent/<>c__DisplayClass7_0")]
    public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_blackboardBuilder;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityParameter;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_listenPosParameter;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupWorldGraphData_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass7_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924289, XrefRangeEnd = 924343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupWorldGraphData_b__0(
        GraphBuilder graphBuilder,
        SequenceGraphData graphData,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> inputs,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> outputs)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphBuilder);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphData);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputs);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outputs);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass7_0.NativeMethodInfoPtr__SetupWorldGraphData_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_0()
      {
        Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, "<>c__DisplayClass7_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass7_0>.NativeClassPtr);
        SequencerPrefabComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_blackboardBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass7_0>.NativeClassPtr, nameof (blackboardBuilder));
        SequencerPrefabComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_entityParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass7_0>.NativeClassPtr, nameof (entityParameter));
        SequencerPrefabComponent.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
        SequencerPrefabComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_listenPosParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass7_0>.NativeClassPtr, nameof (listenPosParameter));
        SequencerPrefabComponent.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass7_0>.NativeClassPtr, 100663945);
        SequencerPrefabComponent.__c__DisplayClass7_0.NativeMethodInfoPtr__SetupWorldGraphData_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass7_0>.NativeClassPtr, 100663946);
      }

      public __c__DisplayClass7_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe BlackboardBuilder blackboardBuilder
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_blackboardBuilder));
          return pointer == System.IntPtr.Zero ? (BlackboardBuilder) null : new BlackboardBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_blackboardBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public BlackboardRegister entityParameter
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_entityParameter);
          return new BlackboardRegister(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardRegister>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_entityParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardRegister>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SequencerPrefabComponent __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SequencerPrefabComponent) null : new SequencerPrefabComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public BlackboardParameterBuilder listenPosParameter
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_listenPosParameter);
          return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_listenPosParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("Stunlock.Sequencer.SequencerPrefab.SequencerPrefabComponent/<>c__DisplayClass8_0")]
    public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_blackboardBuilder;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityParameter;
      private static readonly System.IntPtr NativeFieldInfoPtr_boneParameter;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_listenPosParameter;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupBoneGraphData_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass8_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924343, XrefRangeEnd = 924402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupBoneGraphData_b__0(
        GraphBuilder graphBuilder,
        SequenceGraphData graphData,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> inputs,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> outputs)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphBuilder);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphData);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputs);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outputs);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass8_0.NativeMethodInfoPtr__SetupBoneGraphData_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_0()
      {
        Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, "<>c__DisplayClass8_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass8_0>.NativeClassPtr);
        SequencerPrefabComponent.__c__DisplayClass8_0.NativeFieldInfoPtr_blackboardBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass8_0>.NativeClassPtr, nameof (blackboardBuilder));
        SequencerPrefabComponent.__c__DisplayClass8_0.NativeFieldInfoPtr_entityParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass8_0>.NativeClassPtr, nameof (entityParameter));
        SequencerPrefabComponent.__c__DisplayClass8_0.NativeFieldInfoPtr_boneParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass8_0>.NativeClassPtr, nameof (boneParameter));
        SequencerPrefabComponent.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
        SequencerPrefabComponent.__c__DisplayClass8_0.NativeFieldInfoPtr_listenPosParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass8_0>.NativeClassPtr, nameof (listenPosParameter));
        SequencerPrefabComponent.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass8_0>.NativeClassPtr, 100663947);
        SequencerPrefabComponent.__c__DisplayClass8_0.NativeMethodInfoPtr__SetupBoneGraphData_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass8_0>.NativeClassPtr, 100663948);
      }

      public __c__DisplayClass8_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe BlackboardBuilder blackboardBuilder
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass8_0.NativeFieldInfoPtr_blackboardBuilder));
          return pointer == System.IntPtr.Zero ? (BlackboardBuilder) null : new BlackboardBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass8_0.NativeFieldInfoPtr_blackboardBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public BlackboardRegister entityParameter
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass8_0.NativeFieldInfoPtr_entityParameter);
          return new BlackboardRegister(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardRegister>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass8_0.NativeFieldInfoPtr_entityParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardRegister>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe HybridBoneEnum boneParameter
      {
        get
        {
          return *(HybridBoneEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass8_0.NativeFieldInfoPtr_boneParameter));
        }
        [param: In] set
        {
          *(HybridBoneEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass8_0.NativeFieldInfoPtr_boneParameter)) = value;
        }
      }

      public unsafe SequencerPrefabComponent __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SequencerPrefabComponent) null : new SequencerPrefabComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public BlackboardParameterBuilder listenPosParameter
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass8_0.NativeFieldInfoPtr_listenPosParameter);
          return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass8_0.NativeFieldInfoPtr_listenPosParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("Stunlock.Sequencer.SequencerPrefab.SequencerPrefabComponent/<>c__DisplayClass9_0")]
    public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_blackboardBuilder;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityParameter;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_listenPosParameter;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupLocalGraphData_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass9_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass9_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924402, XrefRangeEnd = 924456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupLocalGraphData_b__0(
        GraphBuilder graphBuilder,
        SequenceGraphData graphData,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> inputs,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> outputs)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphBuilder);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphData);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputs);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outputs);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass9_0.NativeMethodInfoPtr__SetupLocalGraphData_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass9_0()
      {
        Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, "<>c__DisplayClass9_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass9_0>.NativeClassPtr);
        SequencerPrefabComponent.__c__DisplayClass9_0.NativeFieldInfoPtr_blackboardBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass9_0>.NativeClassPtr, nameof (blackboardBuilder));
        SequencerPrefabComponent.__c__DisplayClass9_0.NativeFieldInfoPtr_entityParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass9_0>.NativeClassPtr, nameof (entityParameter));
        SequencerPrefabComponent.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
        SequencerPrefabComponent.__c__DisplayClass9_0.NativeFieldInfoPtr_listenPosParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass9_0>.NativeClassPtr, nameof (listenPosParameter));
        SequencerPrefabComponent.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass9_0>.NativeClassPtr, 100663949);
        SequencerPrefabComponent.__c__DisplayClass9_0.NativeMethodInfoPtr__SetupLocalGraphData_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass9_0>.NativeClassPtr, 100663950);
      }

      public __c__DisplayClass9_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe BlackboardBuilder blackboardBuilder
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass9_0.NativeFieldInfoPtr_blackboardBuilder));
          return pointer == System.IntPtr.Zero ? (BlackboardBuilder) null : new BlackboardBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass9_0.NativeFieldInfoPtr_blackboardBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public BlackboardRegister entityParameter
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass9_0.NativeFieldInfoPtr_entityParameter);
          return new BlackboardRegister(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardRegister>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass9_0.NativeFieldInfoPtr_entityParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardRegister>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SequencerPrefabComponent __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SequencerPrefabComponent) null : new SequencerPrefabComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public BlackboardParameterBuilder listenPosParameter
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass9_0.NativeFieldInfoPtr_listenPosParameter);
          return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass9_0.NativeFieldInfoPtr_listenPosParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("Stunlock.Sequencer.SequencerPrefab.SequencerPrefabComponent/<>c__DisplayClass10_0")]
    public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_blackboardBuilder;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityParameter;
      private static readonly System.IntPtr NativeFieldInfoPtr_transformationData;
      private static readonly System.IntPtr NativeFieldInfoPtr_buildPosParam;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_eventBuilder;
      private static readonly System.IntPtr NativeFieldInfoPtr_buildRotParam;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupLocalGraphData_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass10_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass10_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924456, XrefRangeEnd = 924522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupLocalGraphData_b__0(
        GraphBuilder graphBuilder,
        SequenceGraphData graphData,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> inputs,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> outputs)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphBuilder);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphData);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputs);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outputs);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass10_0.NativeMethodInfoPtr__SetupLocalGraphData_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass10_0()
      {
        Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, "<>c__DisplayClass10_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass10_0>.NativeClassPtr);
        SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr_blackboardBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass10_0>.NativeClassPtr, nameof (blackboardBuilder));
        SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr_entityParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass10_0>.NativeClassPtr, nameof (entityParameter));
        SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr_transformationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass10_0>.NativeClassPtr, nameof (transformationData));
        SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr_buildPosParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass10_0>.NativeClassPtr, nameof (buildPosParam));
        SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
        SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr_eventBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass10_0>.NativeClassPtr, nameof (eventBuilder));
        SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr_buildRotParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass10_0>.NativeClassPtr, nameof (buildRotParam));
        SequencerPrefabComponent.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass10_0>.NativeClassPtr, 100663951);
        SequencerPrefabComponent.__c__DisplayClass10_0.NativeMethodInfoPtr__SetupLocalGraphData_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass10_0>.NativeClassPtr, 100663952);
      }

      public __c__DisplayClass10_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe BlackboardBuilder blackboardBuilder
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr_blackboardBuilder));
          return pointer == System.IntPtr.Zero ? (BlackboardBuilder) null : new BlackboardBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr_blackboardBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public BlackboardRegister entityParameter
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr_entityParameter);
          return new BlackboardRegister(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardRegister>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr_entityParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardRegister>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe TransformationData transformationData
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr_transformationData));
          return pointer == System.IntPtr.Zero ? (TransformationData) null : new TransformationData(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr_transformationData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool buildPosParam
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr_buildPosParam));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr_buildPosParam)) = value;
        }
      }

      public unsafe SequencerPrefabComponent __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SequencerPrefabComponent) null : new SequencerPrefabComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ParticleEventBuilder eventBuilder
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr_eventBuilder));
          return pointer == System.IntPtr.Zero ? (ParticleEventBuilder) null : new ParticleEventBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr_eventBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool buildRotParam
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr_buildRotParam));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass10_0.NativeFieldInfoPtr_buildRotParam)) = value;
        }
      }
    }

    [ObfuscatedName("Stunlock.Sequencer.SequencerPrefab.SequencerPrefabComponent/<>c__DisplayClass11_0")]
    public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_blackboardBuilder;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityParameter;
      private static readonly System.IntPtr NativeFieldInfoPtr_transformationData;
      private static readonly System.IntPtr NativeFieldInfoPtr_buildPosParam;
      private static readonly System.IntPtr NativeFieldInfoPtr_boneParameter;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_eventBuilder;
      private static readonly System.IntPtr NativeFieldInfoPtr_buildRotParam;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupBoneGraphData_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass11_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass11_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924522, XrefRangeEnd = 924584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupBoneGraphData_b__0(
        GraphBuilder graphBuilder,
        SequenceGraphData graphData,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> inputs,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> outputs)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphBuilder);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphData);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputs);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outputs);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass11_0.NativeMethodInfoPtr__SetupBoneGraphData_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass11_0()
      {
        Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, "<>c__DisplayClass11_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass11_0>.NativeClassPtr);
        SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_blackboardBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass11_0>.NativeClassPtr, nameof (blackboardBuilder));
        SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_entityParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass11_0>.NativeClassPtr, nameof (entityParameter));
        SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_transformationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass11_0>.NativeClassPtr, nameof (transformationData));
        SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_buildPosParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass11_0>.NativeClassPtr, nameof (buildPosParam));
        SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_boneParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass11_0>.NativeClassPtr, nameof (boneParameter));
        SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
        SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_eventBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass11_0>.NativeClassPtr, nameof (eventBuilder));
        SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_buildRotParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass11_0>.NativeClassPtr, nameof (buildRotParam));
        SequencerPrefabComponent.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass11_0>.NativeClassPtr, 100663953);
        SequencerPrefabComponent.__c__DisplayClass11_0.NativeMethodInfoPtr__SetupBoneGraphData_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass11_0>.NativeClassPtr, 100663954);
      }

      public __c__DisplayClass11_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe BlackboardBuilder blackboardBuilder
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_blackboardBuilder));
          return pointer == System.IntPtr.Zero ? (BlackboardBuilder) null : new BlackboardBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_blackboardBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public BlackboardRegister entityParameter
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_entityParameter);
          return new BlackboardRegister(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardRegister>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_entityParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardRegister>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe TransformationData transformationData
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_transformationData));
          return pointer == System.IntPtr.Zero ? (TransformationData) null : new TransformationData(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_transformationData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool buildPosParam
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_buildPosParam));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_buildPosParam)) = value;
        }
      }

      public unsafe HybridBoneEnum boneParameter
      {
        get
        {
          return *(HybridBoneEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_boneParameter));
        }
        [param: In] set
        {
          *(HybridBoneEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_boneParameter)) = value;
        }
      }

      public unsafe SequencerPrefabComponent __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SequencerPrefabComponent) null : new SequencerPrefabComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ParticleEventBuilder eventBuilder
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_eventBuilder));
          return pointer == System.IntPtr.Zero ? (ParticleEventBuilder) null : new ParticleEventBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_eventBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool buildRotParam
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_buildRotParam));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_buildRotParam)) = value;
        }
      }
    }

    [ObfuscatedName("Stunlock.Sequencer.SequencerPrefab.SequencerPrefabComponent/<>c__DisplayClass15_0")]
    public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_blackboardBuilder;
      private static readonly System.IntPtr NativeFieldInfoPtr_offsetParameter;
      private static readonly System.IntPtr NativeFieldInfoPtr_positionParameterGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_offsetPositionParameter;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OffsetPosition_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass15_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass15_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924584, XrefRangeEnd = 924635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OffsetPosition_b__0(
        GraphBuilder graphBuilder,
        SequenceGraphData graphData,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> inputs,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> outputs)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphBuilder);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphData);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputs);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outputs);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass15_0.NativeMethodInfoPtr__OffsetPosition_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass15_0()
      {
        Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, "<>c__DisplayClass15_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass15_0>.NativeClassPtr);
        SequencerPrefabComponent.__c__DisplayClass15_0.NativeFieldInfoPtr_blackboardBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass15_0>.NativeClassPtr, nameof (blackboardBuilder));
        SequencerPrefabComponent.__c__DisplayClass15_0.NativeFieldInfoPtr_offsetParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass15_0>.NativeClassPtr, nameof (offsetParameter));
        SequencerPrefabComponent.__c__DisplayClass15_0.NativeFieldInfoPtr_positionParameterGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass15_0>.NativeClassPtr, nameof (positionParameterGuid));
        SequencerPrefabComponent.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
        SequencerPrefabComponent.__c__DisplayClass15_0.NativeFieldInfoPtr_offsetPositionParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass15_0>.NativeClassPtr, nameof (offsetPositionParameter));
        SequencerPrefabComponent.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass15_0>.NativeClassPtr, 100663955);
        SequencerPrefabComponent.__c__DisplayClass15_0.NativeMethodInfoPtr__OffsetPosition_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass15_0>.NativeClassPtr, 100663956);
      }

      public __c__DisplayClass15_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe BlackboardBuilder blackboardBuilder
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass15_0.NativeFieldInfoPtr_blackboardBuilder));
          return pointer == System.IntPtr.Zero ? (BlackboardBuilder) null : new BlackboardBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass15_0.NativeFieldInfoPtr_blackboardBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public BlackboardParameterBuilder offsetParameter
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass15_0.NativeFieldInfoPtr_offsetParameter);
          return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass15_0.NativeFieldInfoPtr_offsetParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe string positionParameterGuid
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass15_0.NativeFieldInfoPtr_positionParameterGuid)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass15_0.NativeFieldInfoPtr_positionParameterGuid), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe SequencerPrefabComponent __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SequencerPrefabComponent) null : new SequencerPrefabComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public BlackboardParameterBuilder offsetPositionParameter
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass15_0.NativeFieldInfoPtr_offsetPositionParameter);
          return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass15_0.NativeFieldInfoPtr_offsetPositionParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("Stunlock.Sequencer.SequencerPrefab.SequencerPrefabComponent/<>c__DisplayClass16_0")]
    public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_blackboardBuilder;
      private static readonly System.IntPtr NativeFieldInfoPtr_offsetParameter;
      private static readonly System.IntPtr NativeFieldInfoPtr_positionParameter;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_offsetPositionParameter;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OffsetPosition_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass16_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass16_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924635, XrefRangeEnd = 924686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OffsetPosition_b__0(
        GraphBuilder graphBuilder,
        SequenceGraphData graphData,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> inputs,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> outputs)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphBuilder);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphData);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputs);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outputs);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass16_0.NativeMethodInfoPtr__OffsetPosition_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass16_0()
      {
        Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, "<>c__DisplayClass16_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass16_0>.NativeClassPtr);
        SequencerPrefabComponent.__c__DisplayClass16_0.NativeFieldInfoPtr_blackboardBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass16_0>.NativeClassPtr, nameof (blackboardBuilder));
        SequencerPrefabComponent.__c__DisplayClass16_0.NativeFieldInfoPtr_offsetParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass16_0>.NativeClassPtr, nameof (offsetParameter));
        SequencerPrefabComponent.__c__DisplayClass16_0.NativeFieldInfoPtr_positionParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass16_0>.NativeClassPtr, nameof (positionParameter));
        SequencerPrefabComponent.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
        SequencerPrefabComponent.__c__DisplayClass16_0.NativeFieldInfoPtr_offsetPositionParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass16_0>.NativeClassPtr, nameof (offsetPositionParameter));
        SequencerPrefabComponent.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass16_0>.NativeClassPtr, 100663957);
        SequencerPrefabComponent.__c__DisplayClass16_0.NativeMethodInfoPtr__OffsetPosition_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass16_0>.NativeClassPtr, 100663958);
      }

      public __c__DisplayClass16_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe BlackboardBuilder blackboardBuilder
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass16_0.NativeFieldInfoPtr_blackboardBuilder));
          return pointer == System.IntPtr.Zero ? (BlackboardBuilder) null : new BlackboardBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass16_0.NativeFieldInfoPtr_blackboardBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public BlackboardParameterBuilder offsetParameter
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass16_0.NativeFieldInfoPtr_offsetParameter);
          return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass16_0.NativeFieldInfoPtr_offsetParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public BlackboardRegister positionParameter
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass16_0.NativeFieldInfoPtr_positionParameter);
          return new BlackboardRegister(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardRegister>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass16_0.NativeFieldInfoPtr_positionParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardRegister>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SequencerPrefabComponent __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SequencerPrefabComponent) null : new SequencerPrefabComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public BlackboardParameterBuilder offsetPositionParameter
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass16_0.NativeFieldInfoPtr_offsetPositionParameter);
          return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass16_0.NativeFieldInfoPtr_offsetPositionParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("Stunlock.Sequencer.SequencerPrefab.SequencerPrefabComponent/<>c__DisplayClass17_0")]
    public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_blackboardBuilder;
      private static readonly System.IntPtr NativeFieldInfoPtr_offsetParameter;
      private static readonly System.IntPtr NativeFieldInfoPtr_positionParameter;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_offsetPositionParameter;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OffsetPosition_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass17_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass17_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924686, XrefRangeEnd = 924737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OffsetPosition_b__0(
        GraphBuilder graphBuilder,
        SequenceGraphData graphData,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> inputs,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> outputs)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphBuilder);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphData);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputs);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outputs);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__OffsetPosition_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass17_0()
      {
        Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, "<>c__DisplayClass17_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass17_0>.NativeClassPtr);
        SequencerPrefabComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_blackboardBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass17_0>.NativeClassPtr, nameof (blackboardBuilder));
        SequencerPrefabComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_offsetParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass17_0>.NativeClassPtr, nameof (offsetParameter));
        SequencerPrefabComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_positionParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass17_0>.NativeClassPtr, nameof (positionParameter));
        SequencerPrefabComponent.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
        SequencerPrefabComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_offsetPositionParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass17_0>.NativeClassPtr, nameof (offsetPositionParameter));
        SequencerPrefabComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass17_0>.NativeClassPtr, 100663959);
        SequencerPrefabComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__OffsetPosition_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass17_0>.NativeClassPtr, 100663960);
      }

      public __c__DisplayClass17_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe BlackboardBuilder blackboardBuilder
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_blackboardBuilder));
          return pointer == System.IntPtr.Zero ? (BlackboardBuilder) null : new BlackboardBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_blackboardBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public BlackboardParameterBuilder offsetParameter
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_offsetParameter);
          return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_offsetParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public BlackboardParameterBuilder positionParameter
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_positionParameter);
          return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_positionParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SequencerPrefabComponent __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SequencerPrefabComponent) null : new SequencerPrefabComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public BlackboardParameterBuilder offsetPositionParameter
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_offsetPositionParameter);
          return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_offsetPositionParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("Stunlock.Sequencer.SequencerPrefab.SequencerPrefabComponent/<>c__DisplayClass18_0")]
    public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_blackboardBuilder;
      private static readonly System.IntPtr NativeFieldInfoPtr_offsetParameter;
      private static readonly System.IntPtr NativeFieldInfoPtr_rotationParameter;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_newRotGuid;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OffsetRotation_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass18_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass18_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924737, XrefRangeEnd = 924788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OffsetRotation_b__0(
        GraphBuilder graphBuilder,
        SequenceGraphData graphData,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> inputs,
        List<SequenceEditorNode_Graph.BlackboardGraphMapping> outputs)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphBuilder);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphData);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputs);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outputs);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerPrefabComponent.__c__DisplayClass18_0.NativeMethodInfoPtr__OffsetRotation_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass18_0()
      {
        Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequencerPrefabComponent>.NativeClassPtr, "<>c__DisplayClass18_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass18_0>.NativeClassPtr);
        SequencerPrefabComponent.__c__DisplayClass18_0.NativeFieldInfoPtr_blackboardBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass18_0>.NativeClassPtr, nameof (blackboardBuilder));
        SequencerPrefabComponent.__c__DisplayClass18_0.NativeFieldInfoPtr_offsetParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass18_0>.NativeClassPtr, nameof (offsetParameter));
        SequencerPrefabComponent.__c__DisplayClass18_0.NativeFieldInfoPtr_rotationParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass18_0>.NativeClassPtr, nameof (rotationParameter));
        SequencerPrefabComponent.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
        SequencerPrefabComponent.__c__DisplayClass18_0.NativeFieldInfoPtr_newRotGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass18_0>.NativeClassPtr, nameof (newRotGuid));
        SequencerPrefabComponent.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass18_0>.NativeClassPtr, 100663961);
        SequencerPrefabComponent.__c__DisplayClass18_0.NativeMethodInfoPtr__OffsetRotation_b__0_Internal_Void_GraphBuilder_SequenceGraphData_List_1_BlackboardGraphMapping_List_1_BlackboardGraphMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerPrefabComponent.__c__DisplayClass18_0>.NativeClassPtr, 100663962);
      }

      public __c__DisplayClass18_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe BlackboardBuilder blackboardBuilder
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass18_0.NativeFieldInfoPtr_blackboardBuilder));
          return pointer == System.IntPtr.Zero ? (BlackboardBuilder) null : new BlackboardBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass18_0.NativeFieldInfoPtr_blackboardBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public BlackboardParameterBuilder offsetParameter
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass18_0.NativeFieldInfoPtr_offsetParameter);
          return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass18_0.NativeFieldInfoPtr_offsetParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public BlackboardParameterBuilder rotationParameter
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass18_0.NativeFieldInfoPtr_rotationParameter);
          return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass18_0.NativeFieldInfoPtr_rotationParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SequencerPrefabComponent __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SequencerPrefabComponent) null : new SequencerPrefabComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe string newRotGuid
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass18_0.NativeFieldInfoPtr_newRotGuid)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerPrefabComponent.__c__DisplayClass18_0.NativeFieldInfoPtr_newRotGuid), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }
  }
}
