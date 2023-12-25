// Decompiled with JetBrains decompiler
// Type: SetLocomotionCycle_Behaviour
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
public class SetLocomotionCycle_Behaviour : StateMachineBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_FloatParameter;
  private static readonly IntPtr NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912106, XrefRangeEnd = 912109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetLocomotionCycle_Behaviour.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetLocomotionCycle_Behaviour.NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SetLocomotionCycle_Behaviour()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetLocomotionCycle_Behaviour>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SetLocomotionCycle_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SetLocomotionCycle_Behaviour()
  {
    Il2CppClassPointerStore<SetLocomotionCycle_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (SetLocomotionCycle_Behaviour));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetLocomotionCycle_Behaviour>.NativeClassPtr);
    SetLocomotionCycle_Behaviour.NativeFieldInfoPtr_FloatParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetLocomotionCycle_Behaviour>.NativeClassPtr, nameof (FloatParameter));
    SetLocomotionCycle_Behaviour.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLocomotionCycle_Behaviour>.NativeClassPtr, 100663342);
    SetLocomotionCycle_Behaviour.NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLocomotionCycle_Behaviour>.NativeClassPtr, 100663343);
    SetLocomotionCycle_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLocomotionCycle_Behaviour>.NativeClassPtr, 100663344);
  }

  public SetLocomotionCycle_Behaviour(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string FloatParameter
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetLocomotionCycle_Behaviour.NativeFieldInfoPtr_FloatParameter)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetLocomotionCycle_Behaviour.NativeFieldInfoPtr_FloatParameter), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
