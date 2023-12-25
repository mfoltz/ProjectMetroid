// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.GraphBuilder
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace Stunlock.Sequencer
{
  public class GraphBuilder : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__DurationParameterGuid_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__TimeParameterGuid_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Nodes;
    private static readonly System.IntPtr NativeFieldInfoPtr__DebugNodes;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DurationParameterGuid_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DurationParameterGuid_Private_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeParameterGuid_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeParameterGuid_Private_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DebugNodes_Public_get_IEnumerable_1_DebugGraphNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNode_Public_Void_GraphNodeBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddDebugNode_Public_Void_DebugGraphNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Void_DynamicBuffer_1_GraphProgramElement_BlackboardBuilder_String_0;

    public unsafe string DurationParameterGuid
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GraphBuilder.NativeMethodInfoPtr_get_DurationParameterGuid_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(4), CachedScanResults(RefRangeStart = 16451, RefRangeEnd = 16455, XrefRangeStart = 16451, XrefRangeEnd = 16455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GraphBuilder.NativeMethodInfoPtr_set_DurationParameterGuid_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe string TimeParameterGuid
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GraphBuilder.NativeMethodInfoPtr_get_TimeParameterGuid_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GraphBuilder.NativeMethodInfoPtr_set_TimeParameterGuid_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe IEnumerable<DebugGraphNode> DebugNodes
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 22440, RefRangeEnd = 22452, XrefRangeStart = 22440, XrefRangeEnd = 22452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphBuilder.NativeMethodInfoPtr_get_DebugNodes_Public_get_IEnumerable_1_DebugGraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerable<DebugGraphNode>) null : new IEnumerable<DebugGraphNode>(pointer);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 923632, RefRangeEnd = 923633, XrefRangeStart = 923615, XrefRangeEnd = 923632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GraphBuilder(string durationParameterGuid, string timeParameterGuid)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphBuilder>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(durationParameterGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(timeParameterGuid);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(32)]
    [CachedScanResults(RefRangeStart = 923637, RefRangeEnd = 923669, XrefRangeStart = 923633, XrefRangeEnd = 923637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddNode(GraphNodeBase node)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphBuilder.NativeMethodInfoPtr_AddNode_Public_Void_GraphNodeBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923669, XrefRangeEnd = 923672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddDebugNode(DebugGraphNode node)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) node));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphBuilder.NativeMethodInfoPtr_AddDebugNode_Public_Void_DebugGraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 923734, RefRangeEnd = 923735, XrefRangeStart = 923672, XrefRangeEnd = 923734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Convert(
      DynamicBuffer<GraphProgramElement> programBuffer,
      BlackboardBuilder blackboardBuilder,
      string sequenceName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &programBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(sequenceName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphBuilder.NativeMethodInfoPtr_Convert_Public_Void_DynamicBuffer_1_GraphProgramElement_BlackboardBuilder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GraphBuilder()
    {
      Il2CppClassPointerStore<GraphBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer", nameof (GraphBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphBuilder>.NativeClassPtr);
      GraphBuilder.NativeFieldInfoPtr__DurationParameterGuid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphBuilder>.NativeClassPtr, "<DurationParameterGuid>k__BackingField");
      GraphBuilder.NativeFieldInfoPtr__TimeParameterGuid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphBuilder>.NativeClassPtr, "<TimeParameterGuid>k__BackingField");
      GraphBuilder.NativeFieldInfoPtr__Nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphBuilder>.NativeClassPtr, nameof (_Nodes));
      GraphBuilder.NativeFieldInfoPtr__DebugNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphBuilder>.NativeClassPtr, nameof (_DebugNodes));
      GraphBuilder.NativeMethodInfoPtr_get_DurationParameterGuid_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphBuilder>.NativeClassPtr, 100663897);
      GraphBuilder.NativeMethodInfoPtr_set_DurationParameterGuid_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphBuilder>.NativeClassPtr, 100663898);
      GraphBuilder.NativeMethodInfoPtr_get_TimeParameterGuid_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphBuilder>.NativeClassPtr, 100663899);
      GraphBuilder.NativeMethodInfoPtr_set_TimeParameterGuid_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphBuilder>.NativeClassPtr, 100663900);
      GraphBuilder.NativeMethodInfoPtr_get_DebugNodes_Public_get_IEnumerable_1_DebugGraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphBuilder>.NativeClassPtr, 100663901);
      GraphBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphBuilder>.NativeClassPtr, 100663902);
      GraphBuilder.NativeMethodInfoPtr_AddNode_Public_Void_GraphNodeBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphBuilder>.NativeClassPtr, 100663903);
      GraphBuilder.NativeMethodInfoPtr_AddDebugNode_Public_Void_DebugGraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphBuilder>.NativeClassPtr, 100663904);
      GraphBuilder.NativeMethodInfoPtr_Convert_Public_Void_DynamicBuffer_1_GraphProgramElement_BlackboardBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphBuilder>.NativeClassPtr, 100663905);
    }

    public GraphBuilder(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _DurationParameterGuid_k__BackingField
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphBuilder.NativeFieldInfoPtr__DurationParameterGuid_k__BackingField)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphBuilder.NativeFieldInfoPtr__DurationParameterGuid_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _TimeParameterGuid_k__BackingField
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphBuilder.NativeFieldInfoPtr__TimeParameterGuid_k__BackingField)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphBuilder.NativeFieldInfoPtr__TimeParameterGuid_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe List<GraphNodeBase> _Nodes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphBuilder.NativeFieldInfoPtr__Nodes));
        return pointer == System.IntPtr.Zero ? (List<GraphNodeBase>) null : new List<GraphNodeBase>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphBuilder.NativeFieldInfoPtr__Nodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<DebugGraphNode> _DebugNodes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphBuilder.NativeFieldInfoPtr__DebugNodes));
        return pointer == System.IntPtr.Zero ? (List<DebugGraphNode>) null : new List<DebugGraphNode>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphBuilder.NativeFieldInfoPtr__DebugNodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
