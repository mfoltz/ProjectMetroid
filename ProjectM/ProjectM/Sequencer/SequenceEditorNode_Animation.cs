// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceEditorNode_Animation
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  public class SequenceEditorNode_Animation : SequenceEditorNode_WithDuration
  {
    private static readonly IntPtr NativeFieldInfoPtr__Target;
    private static readonly IntPtr NativeFieldInfoPtr__Importance;
    private static readonly IntPtr NativeFieldInfoPtr__AnimationScaleMode;
    private static readonly IntPtr NativeFieldInfoPtr__AnimationName;
    private static readonly IntPtr NativeFieldInfoPtr__CanPlayMultipleTimes;
    private static readonly IntPtr NativeFieldInfoPtr__FinishPlaying;
    private static readonly IntPtr NativeFieldInfoPtr__UseChestAimIk;
    private static readonly IntPtr NativeFieldInfoPtr__AnimationType;
    private static readonly IntPtr NativeFieldInfoPtr__BlendIn;
    private static readonly IntPtr NativeFieldInfoPtr__BlendOut;
    private static readonly IntPtr NativeFieldInfoPtr__BlendOutIfRunning;
    private static readonly IntPtr NativeFieldInfoPtr__ExitIfRunning;
    private static readonly IntPtr NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Importance_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_AnimationType_Public_get_AnimationTypeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_BlendIn_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_BlendOut_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_BlendOutIfRunning_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_ExitIfRunning_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_AnimationName_Public_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_AnimationName_Public_set_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_AnimationScaleMode_Public_get_AnimationScaleModeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_CanPlayMultipleTimes_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_FinishPlaying_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_UseChestAimIk_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_ExtendedName_Public_Virtual_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_TryGetAnimationDuration_Public_Boolean_byref_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetAnimationClip_Public_AnimationClip_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Protected_Virtual_Void_Int32_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe int CurrentVersion
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_Animation.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Animation.NativeMethodInfoPtr_get_Target_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
    }

    public unsafe BlackboardParameterValue Importance
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Animation.NativeMethodInfoPtr_get_Importance_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
    }

    public unsafe AnimationTypeEnum AnimationType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Animation.NativeMethodInfoPtr_get_AnimationType_Public_get_AnimationTypeEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AnimationTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe BlackboardParameterValue BlendIn
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Animation.NativeMethodInfoPtr_get_BlendIn_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
    }

    public unsafe BlackboardParameterValue BlendOut
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Animation.NativeMethodInfoPtr_get_BlendOut_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
    }

    public unsafe BlackboardParameterValue BlendOutIfRunning
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Animation.NativeMethodInfoPtr_get_BlendOutIfRunning_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
    }

    public unsafe BlackboardParameterValue ExitIfRunning
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Animation.NativeMethodInfoPtr_get_ExitIfRunning_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
    }

    public unsafe string AnimationName
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Animation.NativeMethodInfoPtr_get_AnimationName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Animation.NativeMethodInfoPtr_set_AnimationName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AnimationScaleModeEnum AnimationScaleMode
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Animation.NativeMethodInfoPtr_get_AnimationScaleMode_Public_get_AnimationScaleModeEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AnimationScaleModeEnum*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool CanPlayMultipleTimes
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Animation.NativeMethodInfoPtr_get_CanPlayMultipleTimes_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool FinishPlaying
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Animation.NativeMethodInfoPtr_get_FinishPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool UseChestAimIk
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Animation.NativeMethodInfoPtr_get_UseChestAimIk_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public override unsafe string IconClass
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093256, XrefRangeEnd = 1093258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_Animation.NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public override unsafe string ExtendedName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093258, XrefRangeEnd = 1093267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_Animation.NativeMethodInfoPtr_get_ExtendedName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093267, XrefRangeEnd = 1093271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetAnimationDuration(out float duration)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref duration;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Animation.NativeMethodInfoPtr_TryGetAnimationDuration_Public_Boolean_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1474)]
    [CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AnimationClip GetAnimationClip()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Animation.NativeMethodInfoPtr_GetAnimationClip_Public_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (AnimationClip) null : new AnimationClip(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093271, XrefRangeEnd = 1093272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe float GetDuration()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_Animation.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnVersionChanged(int previousVersion, int newVersion)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &previousVersion;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &newVersion;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_Animation.NativeMethodInfoPtr_OnVersionChanged_Protected_Virtual_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093272, XrefRangeEnd = 1093273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceEditorNode_Animation()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_Animation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequenceEditorNode_Animation()
    {
      Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceEditorNode_Animation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr);
      SequenceEditorNode_Animation.NativeFieldInfoPtr__Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, nameof (_Target));
      SequenceEditorNode_Animation.NativeFieldInfoPtr__Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, nameof (_Importance));
      SequenceEditorNode_Animation.NativeFieldInfoPtr__AnimationScaleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, nameof (_AnimationScaleMode));
      SequenceEditorNode_Animation.NativeFieldInfoPtr__AnimationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, nameof (_AnimationName));
      SequenceEditorNode_Animation.NativeFieldInfoPtr__CanPlayMultipleTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, nameof (_CanPlayMultipleTimes));
      SequenceEditorNode_Animation.NativeFieldInfoPtr__FinishPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, nameof (_FinishPlaying));
      SequenceEditorNode_Animation.NativeFieldInfoPtr__UseChestAimIk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, nameof (_UseChestAimIk));
      SequenceEditorNode_Animation.NativeFieldInfoPtr__AnimationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, nameof (_AnimationType));
      SequenceEditorNode_Animation.NativeFieldInfoPtr__BlendIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, nameof (_BlendIn));
      SequenceEditorNode_Animation.NativeFieldInfoPtr__BlendOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, nameof (_BlendOut));
      SequenceEditorNode_Animation.NativeFieldInfoPtr__BlendOutIfRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, nameof (_BlendOutIfRunning));
      SequenceEditorNode_Animation.NativeFieldInfoPtr__ExitIfRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, nameof (_ExitIfRunning));
      SequenceEditorNode_Animation.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686289);
      SequenceEditorNode_Animation.NativeMethodInfoPtr_get_Target_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686290);
      SequenceEditorNode_Animation.NativeMethodInfoPtr_get_Importance_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686291);
      SequenceEditorNode_Animation.NativeMethodInfoPtr_get_AnimationType_Public_get_AnimationTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686292);
      SequenceEditorNode_Animation.NativeMethodInfoPtr_get_BlendIn_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686293);
      SequenceEditorNode_Animation.NativeMethodInfoPtr_get_BlendOut_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686294);
      SequenceEditorNode_Animation.NativeMethodInfoPtr_get_BlendOutIfRunning_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686295);
      SequenceEditorNode_Animation.NativeMethodInfoPtr_get_ExitIfRunning_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686296);
      SequenceEditorNode_Animation.NativeMethodInfoPtr_get_AnimationName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686297);
      SequenceEditorNode_Animation.NativeMethodInfoPtr_set_AnimationName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686298);
      SequenceEditorNode_Animation.NativeMethodInfoPtr_get_AnimationScaleMode_Public_get_AnimationScaleModeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686299);
      SequenceEditorNode_Animation.NativeMethodInfoPtr_get_CanPlayMultipleTimes_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686300);
      SequenceEditorNode_Animation.NativeMethodInfoPtr_get_FinishPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686301);
      SequenceEditorNode_Animation.NativeMethodInfoPtr_get_UseChestAimIk_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686302);
      SequenceEditorNode_Animation.NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686303);
      SequenceEditorNode_Animation.NativeMethodInfoPtr_get_ExtendedName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686304);
      SequenceEditorNode_Animation.NativeMethodInfoPtr_TryGetAnimationDuration_Public_Boolean_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686305);
      SequenceEditorNode_Animation.NativeMethodInfoPtr_GetAnimationClip_Public_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686306);
      SequenceEditorNode_Animation.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686307);
      SequenceEditorNode_Animation.NativeMethodInfoPtr_OnVersionChanged_Protected_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686308);
      SequenceEditorNode_Animation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_Animation>.NativeClassPtr, 100686309);
    }

    public SequenceEditorNode_Animation(IntPtr pointer)
      : base(pointer)
    {
    }

    public BlackboardParameterValue _Target
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__Target);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__Target), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _Importance
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__Importance);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__Importance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe AnimationScaleModeEnum _AnimationScaleMode
    {
      get
      {
        return *(AnimationScaleModeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__AnimationScaleMode));
      }
      [param: In] set
      {
        *(AnimationScaleModeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__AnimationScaleMode)) = value;
      }
    }

    public unsafe string _AnimationName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__AnimationName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__AnimationName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool _CanPlayMultipleTimes
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__CanPlayMultipleTimes));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__CanPlayMultipleTimes)) = value;
      }
    }

    public unsafe bool _FinishPlaying
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__FinishPlaying));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__FinishPlaying)) = value;
      }
    }

    public unsafe bool _UseChestAimIk
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__UseChestAimIk));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__UseChestAimIk)) = value;
      }
    }

    public unsafe AnimationTypeEnum _AnimationType
    {
      get
      {
        return *(AnimationTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__AnimationType));
      }
      [param: In] set
      {
        *(AnimationTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__AnimationType)) = value;
      }
    }

    public BlackboardParameterValue _BlendIn
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__BlendIn);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__BlendIn), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _BlendOut
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__BlendOut);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__BlendOut), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _BlendOutIfRunning
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__BlendOutIfRunning);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__BlendOutIfRunning), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _ExitIfRunning
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__ExitIfRunning);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_Animation.NativeFieldInfoPtr__ExitIfRunning), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }
  }
}
