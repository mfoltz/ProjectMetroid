﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.LookAtPositionAuthoring
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  public class LookAtPositionAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_SucceedOnCompletion;
    private static readonly IntPtr NativeFieldInfoPtr_Register;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1338759, RefRangeEnd = 1338760, XrefRangeStart = 1338754, XrefRangeEnd = 1338759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LookAtPositionAuthoring(bool succeedOnCompletion, string register)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LookAtPositionAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &succeedOnCompletion;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(register);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LookAtPositionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338760, XrefRangeEnd = 1338769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LookAtPositionAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr nativeObject = num;
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
    }

    public override unsafe BehaviourTreeNodeType NodeType
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 1338769, RefRangeEnd = 1338771, XrefRangeStart = 1338769, XrefRangeEnd = 1338769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LookAtPositionAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static LookAtPositionAuthoring()
    {
      Il2CppClassPointerStore<LookAtPositionAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (LookAtPositionAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LookAtPositionAuthoring>.NativeClassPtr);
      LookAtPositionAuthoring.NativeFieldInfoPtr_SucceedOnCompletion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtPositionAuthoring>.NativeClassPtr, nameof (SucceedOnCompletion));
      LookAtPositionAuthoring.NativeFieldInfoPtr_Register = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtPositionAuthoring>.NativeClassPtr, nameof (Register));
      LookAtPositionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtPositionAuthoring>.NativeClassPtr, 100664809);
      LookAtPositionAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtPositionAuthoring>.NativeClassPtr, 100664810);
      LookAtPositionAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtPositionAuthoring>.NativeClassPtr, 100664811);
    }

    public LookAtPositionAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool SucceedOnCompletion
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LookAtPositionAuthoring.NativeFieldInfoPtr_SucceedOnCompletion));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LookAtPositionAuthoring.NativeFieldInfoPtr_SucceedOnCompletion)) = value;
      }
    }

    public unsafe string Register
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LookAtPositionAuthoring.NativeFieldInfoPtr_Register)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LookAtPositionAuthoring.NativeFieldInfoPtr_Register), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
