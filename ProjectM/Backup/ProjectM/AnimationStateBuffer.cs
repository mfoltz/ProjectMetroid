// Decompiled with JetBrains decompiler
// Type: ProjectM.AnimationStateBuffer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AnimationStateBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AnimationState_AnimationStateBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AnimationStateBuffer_AnimationState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AnimationStateBuffer_0;
    [FieldOffset(0)]
    public AnimationState Value;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 794224, RefRangeEnd = 794226, XrefRangeStart = 794224, XrefRangeEnd = 794226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator AnimationState(AnimationStateBuffer e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AnimationStateBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_AnimationState_AnimationStateBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AnimationState*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 794224, RefRangeEnd = 794226, XrefRangeStart = 794224, XrefRangeEnd = 794226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator AnimationStateBuffer(AnimationState e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AnimationStateBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_AnimationStateBuffer_AnimationState_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AnimationStateBuffer*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 998535, RefRangeEnd = 998536, XrefRangeStart = 998533, XrefRangeEnd = 998535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe int CompareTo(AnimationStateBuffer other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AnimationStateBuffer.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AnimationStateBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AnimationStateBuffer()
    {
      Il2CppClassPointerStore<AnimationStateBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AnimationStateBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationStateBuffer>.NativeClassPtr);
      AnimationStateBuffer.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStateBuffer>.NativeClassPtr, nameof (Value));
      AnimationStateBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_AnimationState_AnimationStateBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStateBuffer>.NativeClassPtr, 100677227);
      AnimationStateBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_AnimationStateBuffer_AnimationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStateBuffer>.NativeClassPtr, 100677228);
      AnimationStateBuffer.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AnimationStateBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStateBuffer>.NativeClassPtr, 100677229);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationStateBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
