// Decompiled with JetBrains decompiler
// Type: SetRandomValue_Behaviour
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
public class SetRandomValue_Behaviour : StateMachineBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_Timing;
  private static readonly IntPtr NativeFieldInfoPtr_ValueType;
  private static readonly IntPtr NativeFieldInfoPtr_Parameter;
  private static readonly IntPtr NativeFieldInfoPtr_Min;
  private static readonly IntPtr NativeFieldInfoPtr_Max;
  private static readonly IntPtr NativeMethodInfoPtr_OnStateMachineEnter_Public_Virtual_Void_Animator_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnStateMachineExit_Public_Virtual_Void_Animator_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnStateUpdate_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetRandomValue_Private_Void_Boolean_Animator_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912146, XrefRangeEnd = 912148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animator);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &stateMachinePathHash;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetRandomValue_Behaviour.NativeMethodInfoPtr_OnStateMachineEnter_Public_Virtual_Void_Animator_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912148, XrefRangeEnd = 912150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnStateMachineExit(Animator animator, int stateMachinePathHash)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animator);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &stateMachinePathHash;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetRandomValue_Behaviour.NativeMethodInfoPtr_OnStateMachineExit_Public_Virtual_Void_Animator_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912150, XrefRangeEnd = 912152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetRandomValue_Behaviour.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912152, XrefRangeEnd = 912154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetRandomValue_Behaviour.NativeMethodInfoPtr_OnStateUpdate_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912154, XrefRangeEnd = 912156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetRandomValue_Behaviour.NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912156, XrefRangeEnd = 912158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetRandomValue(bool canSetValue, Animator animator)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &canSetValue;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animator);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SetRandomValue_Behaviour.NativeMethodInfoPtr_SetRandomValue_Private_Void_Boolean_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912158, XrefRangeEnd = 912159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SetRandomValue_Behaviour()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetRandomValue_Behaviour>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SetRandomValue_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SetRandomValue_Behaviour()
  {
    Il2CppClassPointerStore<SetRandomValue_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (SetRandomValue_Behaviour));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetRandomValue_Behaviour>.NativeClassPtr);
    SetRandomValue_Behaviour.NativeFieldInfoPtr_Timing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRandomValue_Behaviour>.NativeClassPtr, nameof (Timing));
    SetRandomValue_Behaviour.NativeFieldInfoPtr_ValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRandomValue_Behaviour>.NativeClassPtr, nameof (ValueType));
    SetRandomValue_Behaviour.NativeFieldInfoPtr_Parameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRandomValue_Behaviour>.NativeClassPtr, nameof (Parameter));
    SetRandomValue_Behaviour.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRandomValue_Behaviour>.NativeClassPtr, nameof (Min));
    SetRandomValue_Behaviour.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRandomValue_Behaviour>.NativeClassPtr, nameof (Max));
    SetRandomValue_Behaviour.NativeMethodInfoPtr_OnStateMachineEnter_Public_Virtual_Void_Animator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRandomValue_Behaviour>.NativeClassPtr, 100663353);
    SetRandomValue_Behaviour.NativeMethodInfoPtr_OnStateMachineExit_Public_Virtual_Void_Animator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRandomValue_Behaviour>.NativeClassPtr, 100663354);
    SetRandomValue_Behaviour.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRandomValue_Behaviour>.NativeClassPtr, 100663355);
    SetRandomValue_Behaviour.NativeMethodInfoPtr_OnStateUpdate_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRandomValue_Behaviour>.NativeClassPtr, 100663356);
    SetRandomValue_Behaviour.NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRandomValue_Behaviour>.NativeClassPtr, 100663357);
    SetRandomValue_Behaviour.NativeMethodInfoPtr_SetRandomValue_Private_Void_Boolean_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRandomValue_Behaviour>.NativeClassPtr, 100663358);
    SetRandomValue_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRandomValue_Behaviour>.NativeClassPtr, 100663359);
  }

  public SetRandomValue_Behaviour(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe SetRandomValue_Behaviour.ExecutionTiming Timing
  {
    get
    {
      return *(SetRandomValue_Behaviour.ExecutionTiming*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetRandomValue_Behaviour.NativeFieldInfoPtr_Timing));
    }
    [param: In] set
    {
      *(SetRandomValue_Behaviour.ExecutionTiming*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetRandomValue_Behaviour.NativeFieldInfoPtr_Timing)) = value;
    }
  }

  public unsafe SetRandomValue_Behaviour._ValueType ValueType
  {
    get
    {
      return *(SetRandomValue_Behaviour._ValueType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetRandomValue_Behaviour.NativeFieldInfoPtr_ValueType));
    }
    [param: In] set
    {
      *(SetRandomValue_Behaviour._ValueType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetRandomValue_Behaviour.NativeFieldInfoPtr_ValueType)) = value;
    }
  }

  public unsafe string Parameter
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetRandomValue_Behaviour.NativeFieldInfoPtr_Parameter)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetRandomValue_Behaviour.NativeFieldInfoPtr_Parameter), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe float Min
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetRandomValue_Behaviour.NativeFieldInfoPtr_Min));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetRandomValue_Behaviour.NativeFieldInfoPtr_Min)) = value;
    }
  }

  public unsafe float Max
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetRandomValue_Behaviour.NativeFieldInfoPtr_Max));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetRandomValue_Behaviour.NativeFieldInfoPtr_Max)) = value;
    }
  }

  public enum ExecutionTiming
  {
    onEnter,
    onStateMachineEnter,
    onUpdate,
    onExit,
    onStateMachineExit,
  }

  public enum _ValueType
  {
    floatValue,
    intValue,
    boolValue,
  }
}
