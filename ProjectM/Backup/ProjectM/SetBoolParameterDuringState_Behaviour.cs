// Decompiled with JetBrains decompiler
// Type: ProjectM.SetBoolParameterDuringState_Behaviour
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
namespace ProjectM
{
  public class SetBoolParameterDuringState_Behaviour : StateMachineBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Parameter;
    private static readonly IntPtr NativeFieldInfoPtr_TrueInState;
    private static readonly IntPtr NativeFieldInfoPtr_NegativeUntilEntry;
    private static readonly IntPtr NativeFieldInfoPtr_DontNeutralize;
    private static readonly IntPtr NativeFieldInfoPtr_NormalizedTimeOfEntry;
    private static readonly IntPtr NativeFieldInfoPtr_NormalizedTimeOfExit;
    private static readonly IntPtr NativeFieldInfoPtr_LayerWeightMinThreshold;
    private static readonly IntPtr NativeFieldInfoPtr__HasNeutralized;
    private static readonly IntPtr NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnStateUpdate_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976595, XrefRangeEnd = 976599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStateEnter(
      Animator animator,
      AnimatorStateInfo stateInfo,
      int layerIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animator);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &stateInfo;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &layerIndex;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetBoolParameterDuringState_Behaviour.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976599, XrefRangeEnd = 976606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStateUpdate(
      Animator animator,
      AnimatorStateInfo stateInfo,
      int layerIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animator);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &stateInfo;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &layerIndex;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetBoolParameterDuringState_Behaviour.NativeMethodInfoPtr_OnStateUpdate_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976606, XrefRangeEnd = 976607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStateExit(
      Animator animator,
      AnimatorStateInfo stateInfo,
      int layerIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animator);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &stateInfo;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &layerIndex;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetBoolParameterDuringState_Behaviour.NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SetBoolParameterDuringState_Behaviour()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetBoolParameterDuringState_Behaviour>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetBoolParameterDuringState_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetBoolParameterDuringState_Behaviour()
    {
      Il2CppClassPointerStore<SetBoolParameterDuringState_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SetBoolParameterDuringState_Behaviour));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetBoolParameterDuringState_Behaviour>.NativeClassPtr);
      SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_Parameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetBoolParameterDuringState_Behaviour>.NativeClassPtr, nameof (Parameter));
      SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_TrueInState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetBoolParameterDuringState_Behaviour>.NativeClassPtr, nameof (TrueInState));
      SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_NegativeUntilEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetBoolParameterDuringState_Behaviour>.NativeClassPtr, nameof (NegativeUntilEntry));
      SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_DontNeutralize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetBoolParameterDuringState_Behaviour>.NativeClassPtr, nameof (DontNeutralize));
      SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_NormalizedTimeOfEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetBoolParameterDuringState_Behaviour>.NativeClassPtr, nameof (NormalizedTimeOfEntry));
      SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_NormalizedTimeOfExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetBoolParameterDuringState_Behaviour>.NativeClassPtr, nameof (NormalizedTimeOfExit));
      SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_LayerWeightMinThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetBoolParameterDuringState_Behaviour>.NativeClassPtr, nameof (LayerWeightMinThreshold));
      SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr__HasNeutralized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetBoolParameterDuringState_Behaviour>.NativeClassPtr, nameof (_HasNeutralized));
      SetBoolParameterDuringState_Behaviour.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetBoolParameterDuringState_Behaviour>.NativeClassPtr, 100675479);
      SetBoolParameterDuringState_Behaviour.NativeMethodInfoPtr_OnStateUpdate_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetBoolParameterDuringState_Behaviour>.NativeClassPtr, 100675480);
      SetBoolParameterDuringState_Behaviour.NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetBoolParameterDuringState_Behaviour>.NativeClassPtr, 100675481);
      SetBoolParameterDuringState_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetBoolParameterDuringState_Behaviour>.NativeClassPtr, 100675482);
    }

    public SetBoolParameterDuringState_Behaviour(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string Parameter
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_Parameter)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_Parameter), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool TrueInState
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_TrueInState));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_TrueInState)) = value;
      }
    }

    public unsafe bool NegativeUntilEntry
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_NegativeUntilEntry));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_NegativeUntilEntry)) = value;
      }
    }

    public unsafe bool DontNeutralize
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_DontNeutralize));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_DontNeutralize)) = value;
      }
    }

    public unsafe float NormalizedTimeOfEntry
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_NormalizedTimeOfEntry));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_NormalizedTimeOfEntry)) = value;
      }
    }

    public unsafe float NormalizedTimeOfExit
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_NormalizedTimeOfExit));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_NormalizedTimeOfExit)) = value;
      }
    }

    public unsafe float LayerWeightMinThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_LayerWeightMinThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr_LayerWeightMinThreshold)) = value;
      }
    }

    public unsafe bool _HasNeutralized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr__HasNeutralized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBoolParameterDuringState_Behaviour.NativeFieldInfoPtr__HasNeutralized)) = value;
      }
    }
  }
}
