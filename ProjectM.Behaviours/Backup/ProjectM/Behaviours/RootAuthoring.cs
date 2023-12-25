// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.RootAuthoring
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
  public class RootAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_BehaviourTreeNodeAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(182)]
    [CachedScanResults(RefRangeStart = 1336691, RefRangeEnd = 1336873, XrefRangeStart = 1336691, XrefRangeEnd = 1336873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RootAuthoring(
      [Optional] Il2CppReferenceArray<BehaviourTreeNodeAuthoring> children)
    {
      if (children == null)
        children = new Il2CppReferenceArray<BehaviourTreeNodeAuthoring>(0L);
      // ISSUE: explicit constructor call
      this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RootAuthoring>.NativeClassPtr));
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) children);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RootAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_BehaviourTreeNodeAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public override unsafe BehaviourTreeNodeType NodeType
    {
      [CallerCount(1474), CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RootAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public RootAuthoring(params BehaviourTreeNodeAuthoring[] children)
      : this(new Il2CppReferenceArray<BehaviourTreeNodeAuthoring>(children))
    {
    }

    static RootAuthoring()
    {
      Il2CppClassPointerStore<RootAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (RootAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RootAuthoring>.NativeClassPtr);
      RootAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootAuthoring>.NativeClassPtr, 100665017);
      RootAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootAuthoring>.NativeClassPtr, 100665018);
    }

    public RootAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
