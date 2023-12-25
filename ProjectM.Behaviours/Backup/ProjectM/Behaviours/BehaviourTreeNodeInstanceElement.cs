// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeNodeInstanceElement
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BehaviourTreeNodeInstanceElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BehaviourTreeNodeInstance_BehaviourTreeNodeInstanceElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BehaviourTreeNodeInstanceElement_BehaviourTreeNodeInstance_0;
    [FieldOffset(0)]
    public BehaviourTreeNodeInstance Value;

    [CallerCount(504)]
    [CachedScanResults(RefRangeStart = 279526, RefRangeEnd = 280030, XrefRangeStart = 279526, XrefRangeEnd = 280030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator BehaviourTreeNodeInstance(
      BehaviourTreeNodeInstanceElement e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeNodeInstanceElement.NativeMethodInfoPtr_op_Implicit_Public_Static_BehaviourTreeNodeInstance_BehaviourTreeNodeInstanceElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeNodeInstance*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(504)]
    [CachedScanResults(RefRangeStart = 279526, RefRangeEnd = 280030, XrefRangeStart = 279526, XrefRangeEnd = 280030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator BehaviourTreeNodeInstanceElement(
      BehaviourTreeNodeInstance e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeNodeInstanceElement.NativeMethodInfoPtr_op_Implicit_Public_Static_BehaviourTreeNodeInstanceElement_BehaviourTreeNodeInstance_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeNodeInstanceElement*) IL2CPP.il2cpp_object_unbox(num);
    }

    static BehaviourTreeNodeInstanceElement()
    {
      Il2CppClassPointerStore<BehaviourTreeNodeInstanceElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (BehaviourTreeNodeInstanceElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeNodeInstanceElement>.NativeClassPtr);
      BehaviourTreeNodeInstanceElement.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeNodeInstanceElement>.NativeClassPtr, nameof (Value));
      BehaviourTreeNodeInstanceElement.NativeMethodInfoPtr_op_Implicit_Public_Static_BehaviourTreeNodeInstance_BehaviourTreeNodeInstanceElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeNodeInstanceElement>.NativeClassPtr, 100665042);
      BehaviourTreeNodeInstanceElement.NativeMethodInfoPtr_op_Implicit_Public_Static_BehaviourTreeNodeInstanceElement_BehaviourTreeNodeInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeNodeInstanceElement>.NativeClassPtr, 100665043);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeNodeInstanceElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
