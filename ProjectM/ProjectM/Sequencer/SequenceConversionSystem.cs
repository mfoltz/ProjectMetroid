// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceConversionSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  public class SequenceConversionSystem : GameObjectConversionSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Log;
    private static readonly System.IntPtr NativeFieldInfoPtr__SequencesToConvert;
    private static readonly System.IntPtr NativeFieldInfoPtr__SequencesAdded;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSequence_Public_SequenceGUID_Object_SequenceEditorObject_SequenceNodeOverrideData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSequenceWithCreatData_Public_SequenceGUID_CreateData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertSequenceAssetToSequenceBuilder_Private_SequenceBuilder_SequenceEditorObject_SequenceNodeOverrideData_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertNodes_Private_SequencerEventBuilder_SequenceEditorNode_BlackboardBuilder_SequenceNodeOverrideData_String_HashSet_1_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDyeVariationDataGuid_Public_Static_String_BlackboardBuilder_ParticleEventBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetDurationData_Private_Void_BlackboardBuilder_SequencerEventBuilder_SequenceEditorNode_WithDuration_SequenceNodeOverride_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertParameter_Public_Static_BlackboardParameterBuilder_BlackboardBuilder_BlackboardParameterValue_BlackboardRegisterType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNodesRecursive_Public_Static_Void_SequenceEditorNode_Graph_SequenceGraphNode_GraphBuilder_BlackboardBuilder_HashSet_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddGraphNodes_Public_Static_Void_SequenceGraphNode_GraphBuilder_BlackboardBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConnectionGuid_Private_Static_String_GraphNodeInSocket_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddDefaultValue_Public_Static_Void_GraphBuilder_BlackboardRegisterType_SocketDefaultValue_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogIfRegisterIsMissing_Private_Static_Void_Int32_String_SequenceEditorObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1104881, RefRangeEnd = 1104887, XrefRangeStart = 1104873, XrefRangeEnd = 1104881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceGUID AddSequence(
      UnityEngine.Object creator,
      SequenceEditorObject sequenceAsset,
      SequenceNodeOverrideData overrideData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) creator);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sequenceAsset);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) overrideData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceConversionSystem.NativeMethodInfoPtr_AddSequence_Public_SequenceGUID_Object_SequenceEditorObject_SequenceNodeOverrideData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SequenceGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104887, XrefRangeEnd = 1104890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceGUID AddSequenceWithCreatData(
      SequenceConversionSystem.CreateData createData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) createData));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceConversionSystem.NativeMethodInfoPtr_AddSequenceWithCreatData_Public_SequenceGUID_CreateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SequenceGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104890, XrefRangeEnd = 1105268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1105309, RefRangeEnd = 1105310, XrefRangeStart = 1105268, XrefRangeEnd = 1105309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceBuilder ConvertSequenceAssetToSequenceBuilder(
      SequenceEditorObject sequenceAsset,
      SequenceNodeOverrideData overrideData,
      string creatorName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sequenceAsset);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) overrideData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(creatorName);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceConversionSystem.NativeMethodInfoPtr_ConvertSequenceAssetToSequenceBuilder_Private_SequenceBuilder_SequenceEditorObject_SequenceNodeOverrideData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SequenceBuilder) null : new SequenceBuilder(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1105683, RefRangeEnd = 1105685, XrefRangeStart = 1105310, XrefRangeEnd = 1105683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequencerEventBuilder ConvertNodes(
      SequenceEditorNode node,
      BlackboardBuilder blackboardBuilder,
      SequenceNodeOverrideData overrideData,
      string creatorName,
      HashSet<UnityEngine.Object> conversionDependencies)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) overrideData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(creatorName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionDependencies);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceConversionSystem.NativeMethodInfoPtr_ConvertNodes_Private_SequencerEventBuilder_SequenceEditorNode_BlackboardBuilder_SequenceNodeOverrideData_String_HashSet_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SequencerEventBuilder) null : new SequencerEventBuilder(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1105696, RefRangeEnd = 1105698, XrefRangeStart = 1105685, XrefRangeEnd = 1105696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetDyeVariationDataGuid(
      BlackboardBuilder blackboardBuilder,
      ParticleEventBuilder eventBuilder)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventBuilder);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceConversionSystem.NativeMethodInfoPtr_GetDyeVariationDataGuid_Public_Static_String_BlackboardBuilder_ParticleEventBuilder_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1105708, RefRangeEnd = 1105709, XrefRangeStart = 1105698, XrefRangeEnd = 1105708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetDurationData(
      BlackboardBuilder blackboardBuilder,
      SequencerEventBuilder outNode,
      SequenceEditorNode_WithDuration sequenceNode,
      SequenceNodeOverride overrideData = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outNode);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sequenceNode);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) overrideData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceConversionSystem.NativeMethodInfoPtr_SetDurationData_Private_Void_BlackboardBuilder_SequencerEventBuilder_SequenceEditorNode_WithDuration_SequenceNodeOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(29)]
    [CachedScanResults(RefRangeStart = 1105715, RefRangeEnd = 1105744, XrefRangeStart = 1105709, XrefRangeEnd = 1105715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BlackboardParameterBuilder ConvertParameter(
      BlackboardBuilder blackboardBuilder,
      BlackboardParameterValue parameterValue,
      BlackboardRegisterType type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) parameterValue));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceConversionSystem.NativeMethodInfoPtr_ConvertParameter_Public_Static_BlackboardParameterBuilder_BlackboardBuilder_BlackboardParameterValue_BlackboardRegisterType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new BlackboardParameterBuilder(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1105777, RefRangeEnd = 1105778, XrefRangeStart = 1105744, XrefRangeEnd = 1105777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddNodesRecursive(
      SequenceEditorNode_Graph rootNode,
      SequenceGraphNode graphNode,
      GraphBuilder graphBuilder,
      BlackboardBuilder blackboardBuilder,
      HashSet<string> processedNodes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rootNode);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphNode);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) processedNodes);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceConversionSystem.NativeMethodInfoPtr_AddNodesRecursive_Public_Static_Void_SequenceEditorNode_Graph_SequenceGraphNode_GraphBuilder_BlackboardBuilder_HashSet_1_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1105873, RefRangeEnd = 1105875, XrefRangeStart = 1105778, XrefRangeEnd = 1105873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddGraphNodes(
      SequenceGraphNode graphNode,
      GraphBuilder graphBuilder,
      BlackboardBuilder blackboardBuilder)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphNode);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceConversionSystem.NativeMethodInfoPtr_AddGraphNodes_Public_Static_Void_SequenceGraphNode_GraphBuilder_BlackboardBuilder_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1105875, XrefRangeEnd = 1105876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetConnectionGuid(GraphNodeInSocket inSocket)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inSocket);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceConversionSystem.NativeMethodInfoPtr_GetConnectionGuid_Private_Static_String_GraphNodeInSocket_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(30)]
    [CachedScanResults(RefRangeStart = 1105891, RefRangeEnd = 1105921, XrefRangeStart = 1105876, XrefRangeEnd = 1105891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddDefaultValue(
      GraphBuilder graphBuilder,
      BlackboardRegisterType socketType,
      SocketDefaultValue defaultValue,
      string socketGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &socketType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(socketGuid);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceConversionSystem.NativeMethodInfoPtr_AddDefaultValue_Public_Static_Void_GraphBuilder_BlackboardRegisterType_SocketDefaultValue_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 1105956, RefRangeEnd = 1105963, XrefRangeStart = 1105921, XrefRangeEnd = 1105956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void LogIfRegisterIsMissing(
      int register,
      string registerName,
      SequenceEditorObject sequenceAsset)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &register;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(registerName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sequenceAsset);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceConversionSystem.NativeMethodInfoPtr_LogIfRegisterIsMissing_Private_Static_Void_Int32_String_SequenceEditorObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1105963, XrefRangeEnd = 1105971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceConversionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequenceConversionSystem()
    {
      Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceConversionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr);
      SequenceConversionSystem.NativeFieldInfoPtr_Log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr, nameof (Log));
      SequenceConversionSystem.NativeFieldInfoPtr__SequencesToConvert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr, nameof (_SequencesToConvert));
      SequenceConversionSystem.NativeFieldInfoPtr__SequencesAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr, nameof (_SequencesAdded));
      SequenceConversionSystem.NativeMethodInfoPtr_AddSequence_Public_SequenceGUID_Object_SequenceEditorObject_SequenceNodeOverrideData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr, 100687604);
      SequenceConversionSystem.NativeMethodInfoPtr_AddSequenceWithCreatData_Public_SequenceGUID_CreateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr, 100687605);
      SequenceConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr, 100687606);
      SequenceConversionSystem.NativeMethodInfoPtr_ConvertSequenceAssetToSequenceBuilder_Private_SequenceBuilder_SequenceEditorObject_SequenceNodeOverrideData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr, 100687607);
      SequenceConversionSystem.NativeMethodInfoPtr_ConvertNodes_Private_SequencerEventBuilder_SequenceEditorNode_BlackboardBuilder_SequenceNodeOverrideData_String_HashSet_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr, 100687608);
      SequenceConversionSystem.NativeMethodInfoPtr_GetDyeVariationDataGuid_Public_Static_String_BlackboardBuilder_ParticleEventBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr, 100687609);
      SequenceConversionSystem.NativeMethodInfoPtr_SetDurationData_Private_Void_BlackboardBuilder_SequencerEventBuilder_SequenceEditorNode_WithDuration_SequenceNodeOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr, 100687610);
      SequenceConversionSystem.NativeMethodInfoPtr_ConvertParameter_Public_Static_BlackboardParameterBuilder_BlackboardBuilder_BlackboardParameterValue_BlackboardRegisterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr, 100687611);
      SequenceConversionSystem.NativeMethodInfoPtr_AddNodesRecursive_Public_Static_Void_SequenceEditorNode_Graph_SequenceGraphNode_GraphBuilder_BlackboardBuilder_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr, 100687612);
      SequenceConversionSystem.NativeMethodInfoPtr_AddGraphNodes_Public_Static_Void_SequenceGraphNode_GraphBuilder_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr, 100687613);
      SequenceConversionSystem.NativeMethodInfoPtr_GetConnectionGuid_Private_Static_String_GraphNodeInSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr, 100687614);
      SequenceConversionSystem.NativeMethodInfoPtr_AddDefaultValue_Public_Static_Void_GraphBuilder_BlackboardRegisterType_SocketDefaultValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr, 100687615);
      SequenceConversionSystem.NativeMethodInfoPtr_LogIfRegisterIsMissing_Private_Static_Void_Int32_String_SequenceEditorObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr, 100687616);
      SequenceConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr, 100687617);
      SequenceConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr, 100687618);
    }

    public SequenceConversionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool Log
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceConversionSystem.NativeFieldInfoPtr_Log));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceConversionSystem.NativeFieldInfoPtr_Log)) = value;
      }
    }

    public unsafe Dictionary<int, SequenceConversionSystem.CreateData> _SequencesToConvert
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceConversionSystem.NativeFieldInfoPtr__SequencesToConvert));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, SequenceConversionSystem.CreateData>) null : new Dictionary<int, SequenceConversionSystem.CreateData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceConversionSystem.NativeFieldInfoPtr__SequencesToConvert), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _SequencesAdded
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceConversionSystem.NativeFieldInfoPtr__SequencesAdded));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceConversionSystem.NativeFieldInfoPtr__SequencesAdded)) = value;
      }
    }

    public sealed class CreateData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SequenceAsset;
      private static readonly System.IntPtr NativeFieldInfoPtr_Creator;
      private static readonly System.IntPtr NativeFieldInfoPtr_OverrideData;
      private static readonly System.IntPtr NativeFieldInfoPtr_GeneratedGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_Reconverted;

      static CreateData()
      {
        Il2CppClassPointerStore<SequenceConversionSystem.CreateData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceConversionSystem>.NativeClassPtr, nameof (CreateData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceConversionSystem.CreateData>.NativeClassPtr);
        SequenceConversionSystem.CreateData.NativeFieldInfoPtr_SequenceAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceConversionSystem.CreateData>.NativeClassPtr, nameof (SequenceAsset));
        SequenceConversionSystem.CreateData.NativeFieldInfoPtr_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceConversionSystem.CreateData>.NativeClassPtr, nameof (Creator));
        SequenceConversionSystem.CreateData.NativeFieldInfoPtr_OverrideData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceConversionSystem.CreateData>.NativeClassPtr, nameof (OverrideData));
        SequenceConversionSystem.CreateData.NativeFieldInfoPtr_GeneratedGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceConversionSystem.CreateData>.NativeClassPtr, nameof (GeneratedGuid));
        SequenceConversionSystem.CreateData.NativeFieldInfoPtr_Reconverted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceConversionSystem.CreateData>.NativeClassPtr, nameof (Reconverted));
      }

      public CreateData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public CreateData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SequenceConversionSystem.CreateData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SequenceConversionSystem.CreateData>.NativeClassPtr, data));
      }

      public unsafe SequenceEditorObject SequenceAsset
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceConversionSystem.CreateData.NativeFieldInfoPtr_SequenceAsset));
          return pointer == System.IntPtr.Zero ? (SequenceEditorObject) null : new SequenceEditorObject(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceConversionSystem.CreateData.NativeFieldInfoPtr_SequenceAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UnityEngine.Object Creator
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceConversionSystem.CreateData.NativeFieldInfoPtr_Creator));
          return pointer == System.IntPtr.Zero ? (UnityEngine.Object) null : new UnityEngine.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceConversionSystem.CreateData.NativeFieldInfoPtr_Creator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SequenceNodeOverrideData OverrideData
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceConversionSystem.CreateData.NativeFieldInfoPtr_OverrideData));
          return pointer == System.IntPtr.Zero ? (SequenceNodeOverrideData) null : new SequenceNodeOverrideData(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceConversionSystem.CreateData.NativeFieldInfoPtr_OverrideData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int GeneratedGuid
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceConversionSystem.CreateData.NativeFieldInfoPtr_GeneratedGuid));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceConversionSystem.CreateData.NativeFieldInfoPtr_GeneratedGuid)) = value;
        }
      }

      public unsafe bool Reconverted
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceConversionSystem.CreateData.NativeFieldInfoPtr_Reconverted));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceConversionSystem.CreateData.NativeFieldInfoPtr_Reconverted)) = value;
        }
      }
    }
  }
}
