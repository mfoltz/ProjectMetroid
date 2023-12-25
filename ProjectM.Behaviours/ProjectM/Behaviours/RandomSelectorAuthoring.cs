// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.RandomSelectorAuthoring
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
  public class RandomSelectorAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(182)]
    [CachedScanResults(RefRangeStart = 1336691, RefRangeEnd = 1336873, XrefRangeStart = 1336691, XrefRangeEnd = 1336873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RandomSelectorAuthoring(
      [Optional] Il2CppReferenceArray<BehaviourTreeNodeAuthoring> children)
    {
      if (children == null)
        children = new Il2CppReferenceArray<BehaviourTreeNodeAuthoring>(0L);
      // ISSUE: explicit constructor call
      this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomSelectorAuthoring>.NativeClassPtr));
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) children);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RandomSelectorAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339998, XrefRangeEnd = 1340007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RandomSelectorAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr nativeObject = num;
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
    }

    public override unsafe BehaviourTreeNodeType NodeType
    {
      [CallerCount(26), CachedScanResults(RefRangeStart = 35341, RefRangeEnd = 35367, XrefRangeStart = 35341, XrefRangeEnd = 35367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RandomSelectorAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public RandomSelectorAuthoring(params BehaviourTreeNodeAuthoring[] children)
      : this(new Il2CppReferenceArray<BehaviourTreeNodeAuthoring>(children))
    {
    }

    static RandomSelectorAuthoring()
    {
      Il2CppClassPointerStore<RandomSelectorAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (RandomSelectorAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomSelectorAuthoring>.NativeClassPtr);
      RandomSelectorAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomSelectorAuthoring>.NativeClassPtr, 100665011);
      RandomSelectorAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomSelectorAuthoring>.NativeClassPtr, 100665012);
      RandomSelectorAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomSelectorAuthoring>.NativeClassPtr, 100665013);
    }

    public RandomSelectorAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
