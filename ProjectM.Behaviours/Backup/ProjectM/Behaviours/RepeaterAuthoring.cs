// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.RepeaterAuthoring
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
  public class RepeaterAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_Policy;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RepeaterPolicy_Il2CppReferenceArray_1_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(136)]
    [CachedScanResults(RefRangeStart = 1339808, RefRangeEnd = 1339944, XrefRangeStart = 1339808, XrefRangeEnd = 1339944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RepeaterAuthoring(
      RepeaterPolicy policy,
      [Optional] Il2CppReferenceArray<BehaviourTreeNodeAuthoring> children)
    {
      if (children == null)
        children = new Il2CppReferenceArray<BehaviourTreeNodeAuthoring>(0L);
      // ISSUE: explicit constructor call
      this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RepeaterAuthoring>.NativeClassPtr));
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &policy;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) children);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RepeaterAuthoring.NativeMethodInfoPtr__ctor_Public_Void_RepeaterPolicy_Il2CppReferenceArray_1_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340007, XrefRangeEnd = 1340010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RepeaterAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr nativeObject = num;
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
    }

    public override unsafe BehaviourTreeNodeType NodeType
    {
      [CallerCount(48), CachedScanResults(RefRangeStart = 53682, RefRangeEnd = 53730, XrefRangeStart = 53682, XrefRangeEnd = 53730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RepeaterAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public RepeaterAuthoring(RepeaterPolicy policy, params BehaviourTreeNodeAuthoring[] children)
      : this(policy, new Il2CppReferenceArray<BehaviourTreeNodeAuthoring>(children))
    {
    }

    static RepeaterAuthoring()
    {
      Il2CppClassPointerStore<RepeaterAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (RepeaterAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepeaterAuthoring>.NativeClassPtr);
      RepeaterAuthoring.NativeFieldInfoPtr_Policy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeaterAuthoring>.NativeClassPtr, nameof (Policy));
      RepeaterAuthoring.NativeMethodInfoPtr__ctor_Public_Void_RepeaterPolicy_Il2CppReferenceArray_1_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeaterAuthoring>.NativeClassPtr, 100665014);
      RepeaterAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeaterAuthoring>.NativeClassPtr, 100665015);
      RepeaterAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeaterAuthoring>.NativeClassPtr, 100665016);
    }

    public RepeaterAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RepeaterPolicy Policy
    {
      get
      {
        return *(RepeaterPolicy*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeaterAuthoring.NativeFieldInfoPtr_Policy));
      }
      [param: In] set
      {
        *(RepeaterPolicy*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeaterAuthoring.NativeFieldInfoPtr_Policy)) = value;
      }
    }
  }
}
