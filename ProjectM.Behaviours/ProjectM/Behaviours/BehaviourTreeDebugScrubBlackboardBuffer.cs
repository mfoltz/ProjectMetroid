// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeDebugScrubBlackboardBuffer
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BehaviourTreeDebugScrubBlackboardBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BlackboardElement_BehaviourTreeDebugScrubBlackboardBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BehaviourTreeDebugScrubBlackboardBuffer_BlackboardElement_0;
    [FieldOffset(0)]
    public byte Value;

    [CallerCount(59)]
    [CachedScanResults(RefRangeStart = 562577, RefRangeEnd = 562636, XrefRangeStart = 562577, XrefRangeEnd = 562636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator BlackboardElement(
      BehaviourTreeDebugScrubBlackboardBuffer e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeDebugScrubBlackboardBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_BlackboardElement_BehaviourTreeDebugScrubBlackboardBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BlackboardElement*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(59)]
    [CachedScanResults(RefRangeStart = 562577, RefRangeEnd = 562636, XrefRangeStart = 562577, XrefRangeEnd = 562636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator BehaviourTreeDebugScrubBlackboardBuffer(
      BlackboardElement e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeDebugScrubBlackboardBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_BehaviourTreeDebugScrubBlackboardBuffer_BlackboardElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeDebugScrubBlackboardBuffer*) IL2CPP.il2cpp_object_unbox(num);
    }

    static BehaviourTreeDebugScrubBlackboardBuffer()
    {
      Il2CppClassPointerStore<BehaviourTreeDebugScrubBlackboardBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (BehaviourTreeDebugScrubBlackboardBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeDebugScrubBlackboardBuffer>.NativeClassPtr);
      BehaviourTreeDebugScrubBlackboardBuffer.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeDebugScrubBlackboardBuffer>.NativeClassPtr, nameof (Value));
      BehaviourTreeDebugScrubBlackboardBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_BlackboardElement_BehaviourTreeDebugScrubBlackboardBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeDebugScrubBlackboardBuffer>.NativeClassPtr, 100665278);
      BehaviourTreeDebugScrubBlackboardBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_BehaviourTreeDebugScrubBlackboardBuffer_BlackboardElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeDebugScrubBlackboardBuffer>.NativeClassPtr, 100665279);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeDebugScrubBlackboardBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
