// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceEditorNode_FullscreenEffect
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM.Sequencer
{
  public class SequenceEditorNode_FullscreenEffect : SequenceEditorNode_WithDuration
  {
    private static readonly IntPtr NativeFieldInfoPtr__ImportanceParameter;
    private static readonly IntPtr NativeFieldInfoPtr__Target;
    private static readonly IntPtr NativeFieldInfoPtr__Weight;
    private static readonly IntPtr NativeFieldInfoPtr__FadeInTime;
    private static readonly IntPtr NativeFieldInfoPtr__FadeOutTime;
    private static readonly IntPtr NativeFieldInfoPtr__VolumeProfile;
    private static readonly IntPtr NativeFieldInfoPtr__FullscreenEffectType;
    private static readonly IntPtr NativeMethodInfoPtr_get_ImportanceParameter_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_ImportanceParameter_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Target_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Weight_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Weight_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_FadeInTime_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_FadeInTime_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_FadeOutTime_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_FadeOutTime_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_VolumeProfile_Public_get_VolumeProfile_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_VolumeProfile_Public_set_Void_VolumeProfile_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_FullscreenEffectType_Public_get_FullscreenEffectTypeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_FullscreenEffectType_Public_set_Void_FullscreenEffectTypeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_HasVolumeProfile_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_ExtendedName_Public_Virtual_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetNodeStatus_Public_Virtual_NodeStatus_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe BlackboardParameterValue ImportanceParameter
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_ImportanceParameter_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_set_ImportanceParameter_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue Target
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_Target_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_set_Target_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue Weight
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_Weight_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093553, XrefRangeEnd = 1093554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_set_Weight_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue FadeInTime
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_FadeInTime_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093554, XrefRangeEnd = 1093555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_set_FadeInTime_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue FadeOutTime
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_FadeOutTime_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093555, XrefRangeEnd = 1093556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_set_FadeOutTime_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe VolumeProfile VolumeProfile
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_VolumeProfile_Public_get_VolumeProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (VolumeProfile) null : new VolumeProfile(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_set_VolumeProfile_Public_set_Void_VolumeProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe FullscreenEffectTypeEnum FullscreenEffectType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_FullscreenEffectType_Public_get_FullscreenEffectTypeEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(FullscreenEffectTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_set_FullscreenEffectType_Public_set_Void_FullscreenEffectTypeEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool HasVolumeProfile
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093556, XrefRangeEnd = 1093560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_HasVolumeProfile_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public override unsafe string IconClass
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093560, XrefRangeEnd = 1093562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public override unsafe string ExtendedName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093562, XrefRangeEnd = 1093566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_ExtendedName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093566, XrefRangeEnd = 1093567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe NodeStatus GetNodeStatus()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_GetNodeStatus_Public_Virtual_NodeStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NodeStatus*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093567, XrefRangeEnd = 1093572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceEditorNode_FullscreenEffect()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequenceEditorNode_FullscreenEffect()
    {
      Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceEditorNode_FullscreenEffect));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr);
      SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__ImportanceParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, nameof (_ImportanceParameter));
      SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, nameof (_Target));
      SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, nameof (_Weight));
      SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__FadeInTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, nameof (_FadeInTime));
      SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__FadeOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, nameof (_FadeOutTime));
      SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__VolumeProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, nameof (_VolumeProfile));
      SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__FullscreenEffectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, nameof (_FullscreenEffectType));
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_ImportanceParameter_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686394);
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_set_ImportanceParameter_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686395);
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_Target_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686396);
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_set_Target_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686397);
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_Weight_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686398);
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_set_Weight_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686399);
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_FadeInTime_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686400);
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_set_FadeInTime_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686401);
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_FadeOutTime_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686402);
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_set_FadeOutTime_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686403);
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_VolumeProfile_Public_get_VolumeProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686404);
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_set_VolumeProfile_Public_set_Void_VolumeProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686405);
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_FullscreenEffectType_Public_get_FullscreenEffectTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686406);
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_set_FullscreenEffectType_Public_set_Void_FullscreenEffectTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686407);
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_HasVolumeProfile_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686408);
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686409);
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_get_ExtendedName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686410);
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686411);
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr_GetNodeStatus_Public_Virtual_NodeStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686412);
      SequenceEditorNode_FullscreenEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_FullscreenEffect>.NativeClassPtr, 100686413);
    }

    public SequenceEditorNode_FullscreenEffect(IntPtr pointer)
      : base(pointer)
    {
    }

    public BlackboardParameterValue _ImportanceParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__ImportanceParameter);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__ImportanceParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _Target
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__Target);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__Target), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _Weight
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__Weight);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__Weight), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _FadeInTime
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__FadeInTime);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__FadeInTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _FadeOutTime
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__FadeOutTime);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__FadeOutTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe VolumeProfile _VolumeProfile
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__VolumeProfile));
        return pointer == IntPtr.Zero ? (VolumeProfile) null : new VolumeProfile(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__VolumeProfile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FullscreenEffectTypeEnum _FullscreenEffectType
    {
      get
      {
        return *(FullscreenEffectTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__FullscreenEffectType));
      }
      [param: In] set
      {
        *(FullscreenEffectTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_FullscreenEffect.NativeFieldInfoPtr__FullscreenEffectType)) = value;
      }
    }
  }
}
