// Decompiled with JetBrains decompiler
// Type: SetRandomFloatValueOnEntry_Behaviour
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
public class SetRandomFloatValueOnEntry_Behaviour : StateMachineBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_Parameter;
  private static readonly IntPtr NativeFieldInfoPtr_Min;
  private static readonly IntPtr NativeFieldInfoPtr_Max;
  private static readonly IntPtr NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnStateUpdate_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912142, XrefRangeEnd = 912145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetRandomFloatValueOnEntry_Behaviour.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetRandomFloatValueOnEntry_Behaviour.NativeMethodInfoPtr_OnStateUpdate_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetRandomFloatValueOnEntry_Behaviour.NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912145, XrefRangeEnd = 912146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SetRandomFloatValueOnEntry_Behaviour()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetRandomFloatValueOnEntry_Behaviour>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SetRandomFloatValueOnEntry_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SetRandomFloatValueOnEntry_Behaviour()
  {
    Il2CppClassPointerStore<SetRandomFloatValueOnEntry_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (SetRandomFloatValueOnEntry_Behaviour));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetRandomFloatValueOnEntry_Behaviour>.NativeClassPtr);
    SetRandomFloatValueOnEntry_Behaviour.NativeFieldInfoPtr_Parameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRandomFloatValueOnEntry_Behaviour>.NativeClassPtr, nameof (Parameter));
    SetRandomFloatValueOnEntry_Behaviour.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRandomFloatValueOnEntry_Behaviour>.NativeClassPtr, nameof (Min));
    SetRandomFloatValueOnEntry_Behaviour.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRandomFloatValueOnEntry_Behaviour>.NativeClassPtr, nameof (Max));
    SetRandomFloatValueOnEntry_Behaviour.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRandomFloatValueOnEntry_Behaviour>.NativeClassPtr, 100663349);
    SetRandomFloatValueOnEntry_Behaviour.NativeMethodInfoPtr_OnStateUpdate_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRandomFloatValueOnEntry_Behaviour>.NativeClassPtr, 100663350);
    SetRandomFloatValueOnEntry_Behaviour.NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRandomFloatValueOnEntry_Behaviour>.NativeClassPtr, 100663351);
    SetRandomFloatValueOnEntry_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRandomFloatValueOnEntry_Behaviour>.NativeClassPtr, 100663352);
  }

  public SetRandomFloatValueOnEntry_Behaviour(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string Parameter
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetRandomFloatValueOnEntry_Behaviour.NativeFieldInfoPtr_Parameter)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetRandomFloatValueOnEntry_Behaviour.NativeFieldInfoPtr_Parameter), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe float Min
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetRandomFloatValueOnEntry_Behaviour.NativeFieldInfoPtr_Min));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetRandomFloatValueOnEntry_Behaviour.NativeFieldInfoPtr_Min)) = value;
    }
  }

  public unsafe float Max
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetRandomFloatValueOnEntry_Behaviour.NativeFieldInfoPtr_Max));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetRandomFloatValueOnEntry_Behaviour.NativeFieldInfoPtr_Max)) = value;
    }
  }
}
