﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.IsMovingMonitorAuthoring
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
  public class IsMovingMonitorAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_Invert;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338576, XrefRangeEnd = 1338580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IsMovingMonitorAuthoring(bool invert = false)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsMovingMonitorAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &invert;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IsMovingMonitorAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338580, XrefRangeEnd = 1338592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IsMovingMonitorAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr nativeObject = num;
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
    }

    public override unsafe BehaviourTreeNodeType NodeType
    {
      [CallerCount(10), CachedScanResults(RefRangeStart = 1338592, RefRangeEnd = 1338602, XrefRangeStart = 1338592, XrefRangeEnd = 1338592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IsMovingMonitorAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static IsMovingMonitorAuthoring()
    {
      Il2CppClassPointerStore<IsMovingMonitorAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (IsMovingMonitorAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsMovingMonitorAuthoring>.NativeClassPtr);
      IsMovingMonitorAuthoring.NativeFieldInfoPtr_Invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsMovingMonitorAuthoring>.NativeClassPtr, nameof (Invert));
      IsMovingMonitorAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsMovingMonitorAuthoring>.NativeClassPtr, 100664762);
      IsMovingMonitorAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsMovingMonitorAuthoring>.NativeClassPtr, 100664763);
      IsMovingMonitorAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsMovingMonitorAuthoring>.NativeClassPtr, 100664764);
    }

    public IsMovingMonitorAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool Invert
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IsMovingMonitorAuthoring.NativeFieldInfoPtr_Invert));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IsMovingMonitorAuthoring.NativeFieldInfoPtr_Invert)) = value;
      }
    }
  }
}
