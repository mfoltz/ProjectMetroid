﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.EntityPositionToBlackboardAuthoring
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
  public class EntityPositionToBlackboardAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_InRegister;
    private static readonly IntPtr NativeFieldInfoPtr_OutRegister;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 1337449, RefRangeEnd = 1337458, XrefRangeStart = 1337443, XrefRangeEnd = 1337449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EntityPositionToBlackboardAuthoring(string inRegister, string outRegister)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityPositionToBlackboardAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(inRegister);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(outRegister);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntityPositionToBlackboardAuthoring.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1337458, XrefRangeEnd = 1337472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EntityPositionToBlackboardAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr nativeObject = num;
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
    }

    public override unsafe BehaviourTreeNodeType NodeType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EntityPositionToBlackboardAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static EntityPositionToBlackboardAuthoring()
    {
      Il2CppClassPointerStore<EntityPositionToBlackboardAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (EntityPositionToBlackboardAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityPositionToBlackboardAuthoring>.NativeClassPtr);
      EntityPositionToBlackboardAuthoring.NativeFieldInfoPtr_InRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityPositionToBlackboardAuthoring>.NativeClassPtr, nameof (InRegister));
      EntityPositionToBlackboardAuthoring.NativeFieldInfoPtr_OutRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityPositionToBlackboardAuthoring>.NativeClassPtr, nameof (OutRegister));
      EntityPositionToBlackboardAuthoring.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityPositionToBlackboardAuthoring>.NativeClassPtr, 100664545);
      EntityPositionToBlackboardAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityPositionToBlackboardAuthoring>.NativeClassPtr, 100664546);
      EntityPositionToBlackboardAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityPositionToBlackboardAuthoring>.NativeClassPtr, 100664547);
    }

    public EntityPositionToBlackboardAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string InRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityPositionToBlackboardAuthoring.NativeFieldInfoPtr_InRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EntityPositionToBlackboardAuthoring.NativeFieldInfoPtr_InRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string OutRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityPositionToBlackboardAuthoring.NativeFieldInfoPtr_OutRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EntityPositionToBlackboardAuthoring.NativeFieldInfoPtr_OutRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}