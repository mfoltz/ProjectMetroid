// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.RandomAuthoring
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  public class RandomAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(182)]
    [CachedScanResults(RefRangeStart = 1336691, RefRangeEnd = 1336873, XrefRangeStart = 1336691, XrefRangeEnd = 1336873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RandomAuthoring(
      [Optional] Il2CppReferenceArray<BehaviourTreeNodeAuthoring> children)
    {
      if (children == null)
        children = new Il2CppReferenceArray<BehaviourTreeNodeAuthoring>(0L);
      // ISSUE: explicit constructor call
      this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomAuthoring>.NativeClassPtr));
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) children);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RandomAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public override unsafe BehaviourTreeNodeType NodeType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RandomAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public RandomAuthoring(params BehaviourTreeNodeAuthoring[] children)
      : this(new Il2CppReferenceArray<BehaviourTreeNodeAuthoring>(children))
    {
    }

    static RandomAuthoring()
    {
      Il2CppClassPointerStore<RandomAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (RandomAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomAuthoring>.NativeClassPtr);
      RandomAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomAuthoring>.NativeClassPtr, 100665009);
      RandomAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomAuthoring>.NativeClassPtr, 100665010);
    }

    public RandomAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
