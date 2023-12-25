// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceEditorNode_WithDuration
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class SequenceEditorNode_WithDuration : SequenceEditorNode
  {
    private static readonly IntPtr NativeFieldInfoPtr__DurationParameter;
    private static readonly IntPtr NativeMethodInfoPtr_get_DurationParameter_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_DurationParameter_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    public unsafe BlackboardParameterValue DurationParameter
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_WithDuration.NativeMethodInfoPtr_get_DurationParameter_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_WithDuration.NativeMethodInfoPtr_set_DurationParameter_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 1094156, RefRangeEnd = 1094167, XrefRangeStart = 1094150, XrefRangeEnd = 1094156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceEditorNode_WithDuration()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceEditorNode_WithDuration>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_WithDuration.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequenceEditorNode_WithDuration()
    {
      Il2CppClassPointerStore<SequenceEditorNode_WithDuration>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceEditorNode_WithDuration));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceEditorNode_WithDuration>.NativeClassPtr);
      SequenceEditorNode_WithDuration.NativeFieldInfoPtr__DurationParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_WithDuration>.NativeClassPtr, nameof (_DurationParameter));
      SequenceEditorNode_WithDuration.NativeMethodInfoPtr_get_DurationParameter_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_WithDuration>.NativeClassPtr, 100686686);
      SequenceEditorNode_WithDuration.NativeMethodInfoPtr_set_DurationParameter_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_WithDuration>.NativeClassPtr, 100686687);
      SequenceEditorNode_WithDuration.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_WithDuration>.NativeClassPtr, 100686688);
    }

    public SequenceEditorNode_WithDuration(IntPtr pointer)
      : base(pointer)
    {
    }

    public BlackboardParameterValue _DurationParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_WithDuration.NativeFieldInfoPtr__DurationParameter);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_WithDuration.NativeFieldInfoPtr__DurationParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }
  }
}
