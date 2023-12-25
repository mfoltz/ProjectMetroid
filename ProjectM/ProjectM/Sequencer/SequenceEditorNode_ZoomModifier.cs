// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceEditorNode_ZoomModifier
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
  public class SequenceEditorNode_ZoomModifier : SequenceEditorNode
  {
    private static readonly IntPtr NativeFieldInfoPtr__Importance;
    private static readonly IntPtr NativeFieldInfoPtr__Duration;
    private static readonly IntPtr NativeFieldInfoPtr__Weight;
    private static readonly IntPtr NativeFieldInfoPtr__MinZoomBonus;
    private static readonly IntPtr NativeFieldInfoPtr__MaxZoomBonus;
    private static readonly IntPtr NativeFieldInfoPtr__MinPitchBonus;
    private static readonly IntPtr NativeFieldInfoPtr__MaxPitchBonus;
    private static readonly IntPtr NativeFieldInfoPtr__CustomCameraTarget;
    private static readonly IntPtr NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Duration_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Duration_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Weight_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Weight_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_MinZoomBonus_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_MinZoomBonus_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_MaxZoomBonus_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_MaxZoomBonus_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_MinPitchBonus_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_MinPitchBonus_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_MaxPitchBonus_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_MaxPitchBonus_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_CustomCameraTarget_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_CustomCameraTarget_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Importance_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Importance_Public_set_Void_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Protected_Virtual_Void_Int32_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe int CurrentVersion
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 29193, RefRangeEnd = 29196, XrefRangeStart = 29193, XrefRangeEnd = 29196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe BlackboardParameterValue Duration
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_Duration_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_set_Duration_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_Weight_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_set_Weight_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue MinZoomBonus
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_MinZoomBonus_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_set_MinZoomBonus_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue MaxZoomBonus
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_MaxZoomBonus_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_set_MaxZoomBonus_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue MinPitchBonus
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_MinPitchBonus_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_set_MinPitchBonus_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue MaxPitchBonus
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_MaxPitchBonus_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_set_MaxPitchBonus_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue CustomCameraTarget
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_CustomCameraTarget_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_set_CustomCameraTarget_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public override unsafe string IconClass
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093838, XrefRangeEnd = 1093840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe int Importance
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_Importance_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(9), CachedScanResults(RefRangeStart = 70661, RefRangeEnd = 70670, XrefRangeStart = 70661, XrefRangeEnd = 70670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_set_Importance_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093840, XrefRangeEnd = 1093841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe float GetDuration()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_OnVersionChanged_Protected_Virtual_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceEditorNode_ZoomModifier()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequenceEditorNode_ZoomModifier()
    {
      Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceEditorNode_ZoomModifier));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr);
      SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, nameof (_Importance));
      SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, nameof (_Duration));
      SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, nameof (_Weight));
      SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__MinZoomBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, nameof (_MinZoomBonus));
      SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__MaxZoomBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, nameof (_MaxZoomBonus));
      SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__MinPitchBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, nameof (_MinPitchBonus));
      SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__MaxPitchBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, nameof (_MaxPitchBonus));
      SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__CustomCameraTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, nameof (_CustomCameraTarget));
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686599);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_Duration_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686600);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_set_Duration_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686601);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_Weight_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686602);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_set_Weight_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686603);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_MinZoomBonus_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686604);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_set_MinZoomBonus_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686605);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_MaxZoomBonus_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686606);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_set_MaxZoomBonus_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686607);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_MinPitchBonus_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686608);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_set_MinPitchBonus_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686609);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_MaxPitchBonus_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686610);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_set_MaxPitchBonus_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686611);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_CustomCameraTarget_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686612);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_set_CustomCameraTarget_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686613);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686614);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_get_Importance_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686615);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_set_Importance_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686616);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686617);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr_OnVersionChanged_Protected_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686618);
      SequenceEditorNode_ZoomModifier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_ZoomModifier>.NativeClassPtr, 100686619);
    }

    public SequenceEditorNode_ZoomModifier(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int _Importance
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__Importance));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__Importance)) = value;
      }
    }

    public BlackboardParameterValue _Duration
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__Duration);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__Duration), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _Weight
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__Weight);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__Weight), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _MinZoomBonus
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__MinZoomBonus);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__MinZoomBonus), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _MaxZoomBonus
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__MaxZoomBonus);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__MaxZoomBonus), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _MinPitchBonus
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__MinPitchBonus);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__MinPitchBonus), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _MaxPitchBonus
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__MaxPitchBonus);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__MaxPitchBonus), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _CustomCameraTarget
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__CustomCameraTarget);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_ZoomModifier.NativeFieldInfoPtr__CustomCameraTarget), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }
  }
}
