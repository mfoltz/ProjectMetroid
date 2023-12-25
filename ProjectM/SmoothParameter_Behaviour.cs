// Decompiled with JetBrains decompiler
// Type: SmoothParameter_Behaviour
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
public class SmoothParameter_Behaviour : StateMachineBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_InputParameter;
  private static readonly IntPtr NativeFieldInfoPtr_OutputParameter;
  private static readonly IntPtr NativeFieldInfoPtr_Speed;
  private static readonly IntPtr NativeFieldInfoPtr__LastValue;
  private static readonly IntPtr NativeMethodInfoPtr_OnStateUpdate_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912162, XrefRangeEnd = 912166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SmoothParameter_Behaviour.NativeMethodInfoPtr_OnStateUpdate_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SmoothParameter_Behaviour()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothParameter_Behaviour>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SmoothParameter_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SmoothParameter_Behaviour()
  {
    Il2CppClassPointerStore<SmoothParameter_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (SmoothParameter_Behaviour));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothParameter_Behaviour>.NativeClassPtr);
    SmoothParameter_Behaviour.NativeFieldInfoPtr_InputParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothParameter_Behaviour>.NativeClassPtr, nameof (InputParameter));
    SmoothParameter_Behaviour.NativeFieldInfoPtr_OutputParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothParameter_Behaviour>.NativeClassPtr, nameof (OutputParameter));
    SmoothParameter_Behaviour.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothParameter_Behaviour>.NativeClassPtr, nameof (Speed));
    SmoothParameter_Behaviour.NativeFieldInfoPtr__LastValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothParameter_Behaviour>.NativeClassPtr, nameof (_LastValue));
    SmoothParameter_Behaviour.NativeMethodInfoPtr_OnStateUpdate_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothParameter_Behaviour>.NativeClassPtr, 100663364);
    SmoothParameter_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothParameter_Behaviour>.NativeClassPtr, 100663365);
  }

  public SmoothParameter_Behaviour(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string InputParameter
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SmoothParameter_Behaviour.NativeFieldInfoPtr_InputParameter)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SmoothParameter_Behaviour.NativeFieldInfoPtr_InputParameter), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string OutputParameter
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SmoothParameter_Behaviour.NativeFieldInfoPtr_OutputParameter)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SmoothParameter_Behaviour.NativeFieldInfoPtr_OutputParameter), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe float Speed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SmoothParameter_Behaviour.NativeFieldInfoPtr_Speed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SmoothParameter_Behaviour.NativeFieldInfoPtr_Speed)) = value;
    }
  }

  public unsafe float _LastValue
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SmoothParameter_Behaviour.NativeFieldInfoPtr__LastValue));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SmoothParameter_Behaviour.NativeFieldInfoPtr__LastValue)) = value;
    }
  }
}
