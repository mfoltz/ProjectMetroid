﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.HasFollowTargetInstantAuthoring
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Sequencer;
using System;

#nullable disable
namespace ProjectM.Behaviours
{
  public class HasFollowTargetInstantAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1338103, RefRangeEnd = 1338104, XrefRangeStart = 1338099, XrefRangeEnd = 1338103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HasFollowTargetInstantAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasFollowTargetInstantAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HasFollowTargetInstantAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338104, XrefRangeEnd = 1338107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HasFollowTargetInstantAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HasFollowTargetInstantAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static HasFollowTargetInstantAuthoring()
    {
      Il2CppClassPointerStore<HasFollowTargetInstantAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (HasFollowTargetInstantAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasFollowTargetInstantAuthoring>.NativeClassPtr);
      HasFollowTargetInstantAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFollowTargetInstantAuthoring>.NativeClassPtr, 100664644);
      HasFollowTargetInstantAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFollowTargetInstantAuthoring>.NativeClassPtr, 100664645);
      HasFollowTargetInstantAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasFollowTargetInstantAuthoring>.NativeClassPtr, 100664646);
    }

    public HasFollowTargetInstantAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
