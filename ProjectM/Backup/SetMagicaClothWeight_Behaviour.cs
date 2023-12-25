// Decompiled with JetBrains decompiler
// Type: SetMagicaClothWeight_Behaviour
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using MagicaCloth;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class SetMagicaClothWeight_Behaviour : StateMachineBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_MagicaClothIndex;
  private static readonly IntPtr NativeFieldInfoPtr_TargetWeight;
  private static readonly IntPtr NativeFieldInfoPtr_OverrideTransitionParameters;
  private static readonly IntPtr NativeFieldInfoPtr_FixedDuration;
  private static readonly IntPtr NativeFieldInfoPtr_Transition;
  private static readonly IntPtr NativeFieldInfoPtr__Cloth;
  private static readonly IntPtr NativeFieldInfoPtr__StartWeight;
  private static readonly IntPtr NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnStateUpdate_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912109, XrefRangeEnd = 912125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetMagicaClothWeight_Behaviour.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912125, XrefRangeEnd = 912142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetMagicaClothWeight_Behaviour.NativeMethodInfoPtr_OnStateUpdate_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetMagicaClothWeight_Behaviour.NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SetMagicaClothWeight_Behaviour()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetMagicaClothWeight_Behaviour>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SetMagicaClothWeight_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SetMagicaClothWeight_Behaviour()
  {
    Il2CppClassPointerStore<SetMagicaClothWeight_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (SetMagicaClothWeight_Behaviour));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetMagicaClothWeight_Behaviour>.NativeClassPtr);
    SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr_MagicaClothIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetMagicaClothWeight_Behaviour>.NativeClassPtr, nameof (MagicaClothIndex));
    SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr_TargetWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetMagicaClothWeight_Behaviour>.NativeClassPtr, nameof (TargetWeight));
    SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr_OverrideTransitionParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetMagicaClothWeight_Behaviour>.NativeClassPtr, nameof (OverrideTransitionParameters));
    SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr_FixedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetMagicaClothWeight_Behaviour>.NativeClassPtr, nameof (FixedDuration));
    SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr_Transition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetMagicaClothWeight_Behaviour>.NativeClassPtr, nameof (Transition));
    SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr__Cloth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetMagicaClothWeight_Behaviour>.NativeClassPtr, nameof (_Cloth));
    SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr__StartWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetMagicaClothWeight_Behaviour>.NativeClassPtr, nameof (_StartWeight));
    SetMagicaClothWeight_Behaviour.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetMagicaClothWeight_Behaviour>.NativeClassPtr, 100663345);
    SetMagicaClothWeight_Behaviour.NativeMethodInfoPtr_OnStateUpdate_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetMagicaClothWeight_Behaviour>.NativeClassPtr, 100663346);
    SetMagicaClothWeight_Behaviour.NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetMagicaClothWeight_Behaviour>.NativeClassPtr, 100663347);
    SetMagicaClothWeight_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetMagicaClothWeight_Behaviour>.NativeClassPtr, 100663348);
  }

  public SetMagicaClothWeight_Behaviour(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int MagicaClothIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr_MagicaClothIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr_MagicaClothIndex)) = value;
    }
  }

  public unsafe float TargetWeight
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr_TargetWeight));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr_TargetWeight)) = value;
    }
  }

  public unsafe bool OverrideTransitionParameters
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr_OverrideTransitionParameters));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr_OverrideTransitionParameters)) = value;
    }
  }

  public unsafe bool FixedDuration
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr_FixedDuration));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr_FixedDuration)) = value;
    }
  }

  public unsafe float Transition
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr_Transition));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr_Transition)) = value;
    }
  }

  public unsafe BaseCloth _Cloth
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr__Cloth));
      return pointer == IntPtr.Zero ? (BaseCloth) null : new BaseCloth(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr__Cloth), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float _StartWeight
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr__StartWeight));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetMagicaClothWeight_Behaviour.NativeFieldInfoPtr__StartWeight)) = value;
    }
  }
}
