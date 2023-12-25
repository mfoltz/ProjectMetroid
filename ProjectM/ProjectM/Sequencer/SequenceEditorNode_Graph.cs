// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceEditorNode_Graph
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  public class SequenceEditorNode_Graph : SequenceEditorNode
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__DurationParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr__Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr__GraphData;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputMappings;
    private static readonly System.IntPtr NativeFieldInfoPtr__OutputMappings;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DurationParameter_Public_get_BlackboardParameterValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DurationParameter_Public_set_Void_BlackboardParameterValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GraphData_Public_get_SequenceGraphData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HasGraphData_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_InputMappings_Public_get_List_1_BlackboardGraphMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_InputMappings_Public_set_Void_List_1_BlackboardGraphMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OutputMappings_Public_get_List_1_BlackboardGraphMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OutputMappings_Public_set_Void_List_1_BlackboardGraphMapping_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NodeCount_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetGraphReference_Public_Void_SequenceGraphData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNodeStatus_Public_Virtual_NodeStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnVersionChanged_Protected_Virtual_Void_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe int CurrentVersion
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 29193, RefRangeEnd = 29196, XrefRangeStart = 29193, XrefRangeEnd = 29196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_Graph.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe BlackboardParameterValue DurationParameter
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Graph.NativeMethodInfoPtr_get_DurationParameter_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Graph.NativeMethodInfoPtr_set_DurationParameter_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe SequenceGraphData GraphData
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Graph.NativeMethodInfoPtr_get_GraphData_Public_get_SequenceGraphData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (SequenceGraphData) null : new SequenceGraphData(pointer);
      }
    }

    public unsafe bool HasGraphData
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1093576, RefRangeEnd = 1093577, XrefRangeStart = 1093572, XrefRangeEnd = 1093576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Graph.NativeMethodInfoPtr_get_HasGraphData_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe List<SequenceEditorNode_Graph.BlackboardGraphMapping> InputMappings
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 72810, RefRangeEnd = 72822, XrefRangeStart = 72810, XrefRangeEnd = 72822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Graph.NativeMethodInfoPtr_get_InputMappings_Public_get_List_1_BlackboardGraphMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<SequenceEditorNode_Graph.BlackboardGraphMapping>) null : new List<SequenceEditorNode_Graph.BlackboardGraphMapping>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Graph.NativeMethodInfoPtr_set_InputMappings_Public_set_Void_List_1_BlackboardGraphMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe List<SequenceEditorNode_Graph.BlackboardGraphMapping> OutputMappings
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Graph.NativeMethodInfoPtr_get_OutputMappings_Public_get_List_1_BlackboardGraphMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<SequenceEditorNode_Graph.BlackboardGraphMapping>) null : new List<SequenceEditorNode_Graph.BlackboardGraphMapping>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Graph.NativeMethodInfoPtr_set_OutputMappings_Public_set_Void_List_1_BlackboardGraphMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int NodeCount
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093577, XrefRangeEnd = 1093582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Graph.NativeMethodInfoPtr_get_NodeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_Graph.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetGraphReference(SequenceGraphData graphReference)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphReference);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Graph.NativeMethodInfoPtr_SetGraphReference_Public_Void_SequenceGraphData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093582, XrefRangeEnd = 1093586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe float GetDuration()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_Graph.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093586, XrefRangeEnd = 1093617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe NodeStatus GetNodeStatus()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_Graph.NativeMethodInfoPtr_GetNodeStatus_Public_Virtual_NodeStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NodeStatus*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093617, XrefRangeEnd = 1093619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnVersionChanged(int previousVersion, int newVersion)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &previousVersion;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newVersion;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_Graph.NativeMethodInfoPtr_OnVersionChanged_Protected_Virtual_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093619, XrefRangeEnd = 1093637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceEditorNode_Graph()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Graph.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequenceEditorNode_Graph()
    {
      Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceEditorNode_Graph));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr);
      SequenceEditorNode_Graph.NativeFieldInfoPtr__DurationParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, nameof (_DurationParameter));
      SequenceEditorNode_Graph.NativeFieldInfoPtr__Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, nameof (_Duration));
      SequenceEditorNode_Graph.NativeFieldInfoPtr__GraphData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, nameof (_GraphData));
      SequenceEditorNode_Graph.NativeFieldInfoPtr__InputMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, nameof (_InputMappings));
      SequenceEditorNode_Graph.NativeFieldInfoPtr__OutputMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, nameof (_OutputMappings));
      SequenceEditorNode_Graph.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, 100686417);
      SequenceEditorNode_Graph.NativeMethodInfoPtr_get_DurationParameter_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, 100686418);
      SequenceEditorNode_Graph.NativeMethodInfoPtr_set_DurationParameter_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, 100686419);
      SequenceEditorNode_Graph.NativeMethodInfoPtr_get_GraphData_Public_get_SequenceGraphData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, 100686420);
      SequenceEditorNode_Graph.NativeMethodInfoPtr_get_HasGraphData_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, 100686421);
      SequenceEditorNode_Graph.NativeMethodInfoPtr_get_InputMappings_Public_get_List_1_BlackboardGraphMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, 100686422);
      SequenceEditorNode_Graph.NativeMethodInfoPtr_set_InputMappings_Public_set_Void_List_1_BlackboardGraphMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, 100686423);
      SequenceEditorNode_Graph.NativeMethodInfoPtr_get_OutputMappings_Public_get_List_1_BlackboardGraphMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, 100686424);
      SequenceEditorNode_Graph.NativeMethodInfoPtr_set_OutputMappings_Public_set_Void_List_1_BlackboardGraphMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, 100686425);
      SequenceEditorNode_Graph.NativeMethodInfoPtr_get_NodeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, 100686426);
      SequenceEditorNode_Graph.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, 100686427);
      SequenceEditorNode_Graph.NativeMethodInfoPtr_SetGraphReference_Public_Void_SequenceGraphData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, 100686428);
      SequenceEditorNode_Graph.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, 100686429);
      SequenceEditorNode_Graph.NativeMethodInfoPtr_GetNodeStatus_Public_Virtual_NodeStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, 100686430);
      SequenceEditorNode_Graph.NativeMethodInfoPtr_OnVersionChanged_Protected_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, 100686431);
      SequenceEditorNode_Graph.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, 100686432);
    }

    public SequenceEditorNode_Graph(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public BlackboardParameterValue _DurationParameter
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Graph.NativeFieldInfoPtr__DurationParameter);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Graph.NativeFieldInfoPtr__DurationParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe float _Duration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Graph.NativeFieldInfoPtr__Duration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Graph.NativeFieldInfoPtr__Duration)) = value;
      }
    }

    public unsafe SequenceGraphData _GraphData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Graph.NativeFieldInfoPtr__GraphData));
        return pointer == System.IntPtr.Zero ? (SequenceGraphData) null : new SequenceGraphData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Graph.NativeFieldInfoPtr__GraphData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SequenceEditorNode_Graph.BlackboardGraphMapping> _InputMappings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Graph.NativeFieldInfoPtr__InputMappings));
        return pointer == System.IntPtr.Zero ? (List<SequenceEditorNode_Graph.BlackboardGraphMapping>) null : new List<SequenceEditorNode_Graph.BlackboardGraphMapping>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Graph.NativeFieldInfoPtr__InputMappings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SequenceEditorNode_Graph.BlackboardGraphMapping> _OutputMappings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Graph.NativeFieldInfoPtr__OutputMappings));
        return pointer == System.IntPtr.Zero ? (List<SequenceEditorNode_Graph.BlackboardGraphMapping>) null : new List<SequenceEditorNode_Graph.BlackboardGraphMapping>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Graph.NativeFieldInfoPtr__OutputMappings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public sealed class BlackboardGraphMapping : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_BlackboardValueType;
      private static readonly System.IntPtr NativeFieldInfoPtr_BlackboardValue;
      private static readonly System.IntPtr NativeFieldInfoPtr_GraphInputVisualName;
      private static readonly System.IntPtr NativeFieldInfoPtr_GraphInputSocketGuid;

      static BlackboardGraphMapping()
      {
        Il2CppClassPointerStore<SequenceEditorNode_Graph.BlackboardGraphMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceEditorNode_Graph>.NativeClassPtr, nameof (BlackboardGraphMapping));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceEditorNode_Graph.BlackboardGraphMapping>.NativeClassPtr);
        SequenceEditorNode_Graph.BlackboardGraphMapping.NativeFieldInfoPtr_BlackboardValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Graph.BlackboardGraphMapping>.NativeClassPtr, nameof (BlackboardValueType));
        SequenceEditorNode_Graph.BlackboardGraphMapping.NativeFieldInfoPtr_BlackboardValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Graph.BlackboardGraphMapping>.NativeClassPtr, nameof (BlackboardValue));
        SequenceEditorNode_Graph.BlackboardGraphMapping.NativeFieldInfoPtr_GraphInputVisualName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Graph.BlackboardGraphMapping>.NativeClassPtr, nameof (GraphInputVisualName));
        SequenceEditorNode_Graph.BlackboardGraphMapping.NativeFieldInfoPtr_GraphInputSocketGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Graph.BlackboardGraphMapping>.NativeClassPtr, nameof (GraphInputSocketGuid));
      }

      public BlackboardGraphMapping(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public BlackboardGraphMapping()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SequenceEditorNode_Graph.BlackboardGraphMapping>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SequenceEditorNode_Graph.BlackboardGraphMapping>.NativeClassPtr, data));
      }

      public unsafe BlackboardRegisterType BlackboardValueType
      {
        get
        {
          return *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Graph.BlackboardGraphMapping.NativeFieldInfoPtr_BlackboardValueType));
        }
        [param: In] set
        {
          *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Graph.BlackboardGraphMapping.NativeFieldInfoPtr_BlackboardValueType)) = value;
        }
      }

      public BlackboardParameterValue BlackboardValue
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Graph.BlackboardGraphMapping.NativeFieldInfoPtr_BlackboardValue);
          return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Graph.BlackboardGraphMapping.NativeFieldInfoPtr_BlackboardValue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe string GraphInputVisualName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Graph.BlackboardGraphMapping.NativeFieldInfoPtr_GraphInputVisualName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Graph.BlackboardGraphMapping.NativeFieldInfoPtr_GraphInputVisualName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string GraphInputSocketGuid
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Graph.BlackboardGraphMapping.NativeFieldInfoPtr_GraphInputSocketGuid)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Graph.BlackboardGraphMapping.NativeFieldInfoPtr_GraphInputSocketGuid), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }
  }
}
