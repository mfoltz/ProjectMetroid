// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.ParallelAuthoring
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
  public class ParallelAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_SuccessPolicy;
    private static readonly IntPtr NativeFieldInfoPtr_FailPolicy;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ParallelPolicy_ParallelPolicy_Il2CppReferenceArray_1_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(33)]
    [CachedScanResults(RefRangeStart = 1339948, RefRangeEnd = 1339981, XrefRangeStart = 1339947, XrefRangeEnd = 1339948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ParallelAuthoring(
      ParallelPolicy successPolicy,
      ParallelPolicy failPolicy,
      [Optional] Il2CppReferenceArray<BehaviourTreeNodeAuthoring> children)
    {
      if (children == null)
        children = new Il2CppReferenceArray<BehaviourTreeNodeAuthoring>(0L);
      // ISSUE: explicit constructor call
      this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParallelAuthoring>.NativeClassPtr));
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &successPolicy;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &failPolicy;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) children);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParallelAuthoring.NativeMethodInfoPtr__ctor_Public_Void_ParallelPolicy_ParallelPolicy_Il2CppReferenceArray_1_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339981, XrefRangeEnd = 1339998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ParallelAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ParallelAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public ParallelAuthoring(
      ParallelPolicy successPolicy,
      ParallelPolicy failPolicy,
      params BehaviourTreeNodeAuthoring[] children)
      : this(successPolicy, failPolicy, new Il2CppReferenceArray<BehaviourTreeNodeAuthoring>(children))
    {
    }

    static ParallelAuthoring()
    {
      Il2CppClassPointerStore<ParallelAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (ParallelAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParallelAuthoring>.NativeClassPtr);
      ParallelAuthoring.NativeFieldInfoPtr_SuccessPolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParallelAuthoring>.NativeClassPtr, nameof (SuccessPolicy));
      ParallelAuthoring.NativeFieldInfoPtr_FailPolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParallelAuthoring>.NativeClassPtr, nameof (FailPolicy));
      ParallelAuthoring.NativeMethodInfoPtr__ctor_Public_Void_ParallelPolicy_ParallelPolicy_Il2CppReferenceArray_1_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParallelAuthoring>.NativeClassPtr, 100665006);
      ParallelAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParallelAuthoring>.NativeClassPtr, 100665007);
      ParallelAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParallelAuthoring>.NativeClassPtr, 100665008);
    }

    public ParallelAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ParallelPolicy SuccessPolicy
    {
      get
      {
        return *(ParallelPolicy*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParallelAuthoring.NativeFieldInfoPtr_SuccessPolicy));
      }
      [param: In] set
      {
        *(ParallelPolicy*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParallelAuthoring.NativeFieldInfoPtr_SuccessPolicy)) = value;
      }
    }

    public unsafe ParallelPolicy FailPolicy
    {
      get
      {
        return *(ParallelPolicy*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParallelAuthoring.NativeFieldInfoPtr_FailPolicy));
      }
      [param: In] set
      {
        *(ParallelPolicy*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParallelAuthoring.NativeFieldInfoPtr_FailPolicy)) = value;
      }
    }
  }
}
