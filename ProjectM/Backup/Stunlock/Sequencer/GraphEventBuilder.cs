// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.GraphEventBuilder
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace Stunlock.Sequencer
{
  public class GraphEventBuilder : SequencerEventBuilder
  {
    private static readonly IntPtr NativeFieldInfoPtr_GRAPH_END_PROGRAM;
    private static readonly IntPtr NativeFieldInfoPtr_GraphBuilder;
    private static readonly IntPtr NativeFieldInfoPtr_PlaybackType;
    private static readonly IntPtr NativeFieldInfoPtr__DurationParameterGuid;
    private static readonly IntPtr NativeFieldInfoPtr__TimeParameterGuid;
    private static readonly IntPtr NativeFieldInfoPtr_GraphDurationIndex;
    private static readonly IntPtr NativeFieldInfoPtr_GraphTimeIndex;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 923494, RefRangeEnd = 923495, XrefRangeStart = 923491, XrefRangeEnd = 923494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GraphEventBuilder(string durationBlackboardGuid, string timeBlackboardGuid)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphEventBuilder>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(durationBlackboardGuid);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(timeBlackboardGuid);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphEventBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923495, XrefRangeEnd = 923498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
      Entity entity,
      EntityManager entityManager,
      BlackboardBuilder blackboardBuilder,
      SequenceEditorObject sequenceEditorObject)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sequenceEditorObject);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GraphEventBuilder.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public override unsafe NodeTypeEnum GetNodeType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GraphEventBuilder.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NodeTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923498, XrefRangeEnd = 923504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string GetDebugName()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GraphEventBuilder.NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static GraphEventBuilder()
    {
      Il2CppClassPointerStore<GraphEventBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer", nameof (GraphEventBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphEventBuilder>.NativeClassPtr);
      GraphEventBuilder.NativeFieldInfoPtr_GRAPH_END_PROGRAM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphEventBuilder>.NativeClassPtr, nameof (GRAPH_END_PROGRAM));
      GraphEventBuilder.NativeFieldInfoPtr_GraphBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphEventBuilder>.NativeClassPtr, nameof (GraphBuilder));
      GraphEventBuilder.NativeFieldInfoPtr_PlaybackType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphEventBuilder>.NativeClassPtr, nameof (PlaybackType));
      GraphEventBuilder.NativeFieldInfoPtr__DurationParameterGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphEventBuilder>.NativeClassPtr, nameof (_DurationParameterGuid));
      GraphEventBuilder.NativeFieldInfoPtr__TimeParameterGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphEventBuilder>.NativeClassPtr, nameof (_TimeParameterGuid));
      GraphEventBuilder.NativeFieldInfoPtr_GraphDurationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphEventBuilder>.NativeClassPtr, nameof (GraphDurationIndex));
      GraphEventBuilder.NativeFieldInfoPtr_GraphTimeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphEventBuilder>.NativeClassPtr, nameof (GraphTimeIndex));
      GraphEventBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphEventBuilder>.NativeClassPtr, 100663884);
      GraphEventBuilder.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphEventBuilder>.NativeClassPtr, 100663885);
      GraphEventBuilder.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphEventBuilder>.NativeClassPtr, 100663886);
      GraphEventBuilder.NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphEventBuilder>.NativeClassPtr, 100663887);
    }

    public GraphEventBuilder(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int GRAPH_END_PROGRAM
    {
      get
      {
        int graphEndProgram;
        IL2CPP.il2cpp_field_static_get_value(GraphEventBuilder.NativeFieldInfoPtr_GRAPH_END_PROGRAM, (void*) &graphEndProgram);
        return graphEndProgram;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GraphEventBuilder.NativeFieldInfoPtr_GRAPH_END_PROGRAM, (void*) &value);
      }
    }

    public unsafe GraphBuilder GraphBuilder
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphEventBuilder.NativeFieldInfoPtr_GraphBuilder));
        return pointer == IntPtr.Zero ? (GraphBuilder) null : new GraphBuilder(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphEventBuilder.NativeFieldInfoPtr_GraphBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GraphPlaybackType PlaybackType
    {
      get
      {
        return *(GraphPlaybackType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphEventBuilder.NativeFieldInfoPtr_PlaybackType));
      }
      [param: In] set
      {
        *(GraphPlaybackType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphEventBuilder.NativeFieldInfoPtr_PlaybackType)) = value;
      }
    }

    public unsafe string _DurationParameterGuid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphEventBuilder.NativeFieldInfoPtr__DurationParameterGuid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphEventBuilder.NativeFieldInfoPtr__DurationParameterGuid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _TimeParameterGuid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphEventBuilder.NativeFieldInfoPtr__TimeParameterGuid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphEventBuilder.NativeFieldInfoPtr__TimeParameterGuid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int GraphDurationIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphEventBuilder.NativeFieldInfoPtr_GraphDurationIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphEventBuilder.NativeFieldInfoPtr_GraphDurationIndex)) = value;
      }
    }

    public unsafe int GraphTimeIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphEventBuilder.NativeFieldInfoPtr_GraphTimeIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphEventBuilder.NativeFieldInfoPtr_GraphTimeIndex)) = value;
      }
    }
  }
}
