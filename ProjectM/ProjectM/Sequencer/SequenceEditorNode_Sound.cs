// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceEditorNode_Sound
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Fmod;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  public class SequenceEditorNode_Sound : SequenceEditorNode_WithDuration
  {
    private static readonly IntPtr NativeFieldInfoPtr__Target;
    private static readonly IntPtr NativeFieldInfoPtr__Position;
    private static readonly IntPtr NativeFieldInfoPtr__Event;
    private static readonly IntPtr NativeFieldInfoPtr__SoundPlayMode;
    private static readonly IntPtr NativeFieldInfoPtr__Parameters;
    private static readonly IntPtr NativeFieldInfoPtr__CueOnStopParameter;
    private static readonly IntPtr NativeFieldInfoPtr__ForceStopOnDestroyParameter;
    private static readonly IntPtr NativeFieldInfoPtr__VolumeParameter;
    private static readonly IntPtr NativeFieldInfoPtr__PitchParameter;
    private static readonly IntPtr NativeFieldInfoPtr__MinDistanceParameter;
    private static readonly IntPtr NativeFieldInfoPtr__MaxDistanceParameter;
    private static readonly IntPtr NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Target_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Event_Public_get_FmodEvent_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Event_Public_set_Void_FmodEvent_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_SoundPlayMode_Public_get_SoundPlayModeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_SoundPlayMode_Public_set_Void_SoundPlayModeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Parameters_Public_get_List_1_SequenceSoundNodeParameter_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Parameters_Public_set_Void_List_1_SequenceSoundNodeParameter_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_CueOnStop_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_CueOnStop_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_ForceStopOnDestroy_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_ForceStopOnDestroy_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Volume_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Volume_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Pitch_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Pitch_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_MinDistanceParameter_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_MinDistanceParameter_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_MaxDistanceParameter_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_MaxDistanceParameter_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_ExtendedName_Public_Virtual_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetNodeStatus_Public_Virtual_NodeStatus_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe int CurrentVersion
    {
      [CallerCount(21), CachedScanResults(RefRangeStart = 31081, RefRangeEnd = 31102, XrefRangeStart = 31081, XrefRangeEnd = 31102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_Sound.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe BlackboardParameterValue Target
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_get_Target_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_set_Target_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue Position
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_get_Position_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_set_Position_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe FmodEvent Event
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 547960, RefRangeEnd = 547961, XrefRangeStart = 547960, XrefRangeEnd = 547961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_get_Event_Public_get_FmodEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new FmodEvent(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093779, XrefRangeEnd = 1093780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_set_Event_Public_set_Void_FmodEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe SoundPlayModeEnum SoundPlayMode
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_get_SoundPlayMode_Public_get_SoundPlayModeEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(SoundPlayModeEnum*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_set_SoundPlayMode_Public_set_Void_SoundPlayModeEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe List<SequenceSoundNodeParameter> Parameters
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_get_Parameters_Public_get_List_1_SequenceSoundNodeParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<SequenceSoundNodeParameter>) null : new List<SequenceSoundNodeParameter>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_set_Parameters_Public_set_Void_List_1_SequenceSoundNodeParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue CueOnStop
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_get_CueOnStop_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_set_CueOnStop_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue ForceStopOnDestroy
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_get_ForceStopOnDestroy_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_set_ForceStopOnDestroy_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue Volume
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_get_Volume_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_set_Volume_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue Pitch
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_get_Pitch_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_set_Pitch_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue MinDistanceParameter
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_get_MinDistanceParameter_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093780, XrefRangeEnd = 1093781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_set_MinDistanceParameter_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue MaxDistanceParameter
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_get_MaxDistanceParameter_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093781, XrefRangeEnd = 1093782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr_set_MaxDistanceParameter_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public override unsafe string ExtendedName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093782, XrefRangeEnd = 1093791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_Sound.NativeMethodInfoPtr_get_ExtendedName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public override unsafe string IconClass
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093791, XrefRangeEnd = 1093793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_Sound.NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe float GetDuration()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_Sound.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093793, XrefRangeEnd = 1093795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe NodeStatus GetNodeStatus()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_Sound.NativeMethodInfoPtr_GetNodeStatus_Public_Virtual_NodeStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NodeStatus*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093795, XrefRangeEnd = 1093815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceEditorNode_Sound()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Sound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequenceEditorNode_Sound()
    {
      Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceEditorNode_Sound));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr);
      SequenceEditorNode_Sound.NativeFieldInfoPtr__Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, nameof (_Target));
      SequenceEditorNode_Sound.NativeFieldInfoPtr__Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, nameof (_Position));
      SequenceEditorNode_Sound.NativeFieldInfoPtr__Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, nameof (_Event));
      SequenceEditorNode_Sound.NativeFieldInfoPtr__SoundPlayMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, nameof (_SoundPlayMode));
      SequenceEditorNode_Sound.NativeFieldInfoPtr__Parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, nameof (_Parameters));
      SequenceEditorNode_Sound.NativeFieldInfoPtr__CueOnStopParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, nameof (_CueOnStopParameter));
      SequenceEditorNode_Sound.NativeFieldInfoPtr__ForceStopOnDestroyParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, nameof (_ForceStopOnDestroyParameter));
      SequenceEditorNode_Sound.NativeFieldInfoPtr__VolumeParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, nameof (_VolumeParameter));
      SequenceEditorNode_Sound.NativeFieldInfoPtr__PitchParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, nameof (_PitchParameter));
      SequenceEditorNode_Sound.NativeFieldInfoPtr__MinDistanceParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, nameof (_MinDistanceParameter));
      SequenceEditorNode_Sound.NativeFieldInfoPtr__MaxDistanceParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, nameof (_MaxDistanceParameter));
      SequenceEditorNode_Sound.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686546);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_get_Target_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686547);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_set_Target_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686548);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_get_Position_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686549);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_set_Position_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686550);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_get_Event_Public_get_FmodEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686551);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_set_Event_Public_set_Void_FmodEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686552);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_get_SoundPlayMode_Public_get_SoundPlayModeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686553);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_set_SoundPlayMode_Public_set_Void_SoundPlayModeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686554);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_get_Parameters_Public_get_List_1_SequenceSoundNodeParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686555);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_set_Parameters_Public_set_Void_List_1_SequenceSoundNodeParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686556);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_get_CueOnStop_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686557);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_set_CueOnStop_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686558);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_get_ForceStopOnDestroy_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686559);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_set_ForceStopOnDestroy_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686560);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_get_Volume_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686561);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_set_Volume_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686562);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_get_Pitch_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686563);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_set_Pitch_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686564);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_get_MinDistanceParameter_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686565);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_set_MinDistanceParameter_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686566);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_get_MaxDistanceParameter_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686567);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_set_MaxDistanceParameter_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686568);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_get_ExtendedName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686569);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686570);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686571);
      SequenceEditorNode_Sound.NativeMethodInfoPtr_GetNodeStatus_Public_Virtual_NodeStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686572);
      SequenceEditorNode_Sound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Sound>.NativeClassPtr, 100686573);
    }

    public SequenceEditorNode_Sound(IntPtr pointer)
      : base(pointer)
    {
    }

    public BlackboardParameterValue _Target
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__Target);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__Target), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _Position
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__Position);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__Position), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public FmodEvent _Event
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__Event);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__Event), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe SoundPlayModeEnum _SoundPlayMode
    {
      get
      {
        return *(SoundPlayModeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__SoundPlayMode));
      }
      [param: In] set
      {
        *(SoundPlayModeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__SoundPlayMode)) = value;
      }
    }

    public unsafe List<SequenceSoundNodeParameter> _Parameters
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__Parameters));
        return pointer == IntPtr.Zero ? (List<SequenceSoundNodeParameter>) null : new List<SequenceSoundNodeParameter>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__Parameters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public BlackboardParameterValue _CueOnStopParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__CueOnStopParameter);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__CueOnStopParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _ForceStopOnDestroyParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__ForceStopOnDestroyParameter);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__ForceStopOnDestroyParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _VolumeParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__VolumeParameter);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__VolumeParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _PitchParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__PitchParameter);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__PitchParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _MinDistanceParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__MinDistanceParameter);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__MinDistanceParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _MaxDistanceParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__MaxDistanceParameter);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Sound.NativeFieldInfoPtr__MaxDistanceParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }
  }
}
