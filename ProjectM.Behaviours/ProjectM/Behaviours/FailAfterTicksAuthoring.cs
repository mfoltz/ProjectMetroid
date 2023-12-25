﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.FailAfterTicksAuthoring
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
  public class FailAfterTicksAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_Ticks;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1337533, XrefRangeEnd = 1337537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FailAfterTicksAuthoring(int ticks)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FailAfterTicksAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &ticks;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FailAfterTicksAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1337537, XrefRangeEnd = 1337549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FailAfterTicksAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FailAfterTicksAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static FailAfterTicksAuthoring()
    {
      Il2CppClassPointerStore<FailAfterTicksAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (FailAfterTicksAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FailAfterTicksAuthoring>.NativeClassPtr);
      FailAfterTicksAuthoring.NativeFieldInfoPtr_Ticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FailAfterTicksAuthoring>.NativeClassPtr, nameof (Ticks));
      FailAfterTicksAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailAfterTicksAuthoring>.NativeClassPtr, 100664554);
      FailAfterTicksAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailAfterTicksAuthoring>.NativeClassPtr, 100664555);
      FailAfterTicksAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailAfterTicksAuthoring>.NativeClassPtr, 100664556);
    }

    public FailAfterTicksAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int Ticks
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FailAfterTicksAuthoring.NativeFieldInfoPtr_Ticks));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FailAfterTicksAuthoring.NativeFieldInfoPtr_Ticks)) = value;
      }
    }
  }
}
