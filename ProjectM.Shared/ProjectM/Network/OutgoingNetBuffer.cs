// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.OutgoingNetBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct OutgoingNetBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Byte_OutgoingNetBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_OutgoingNetBuffer_Byte_0;
    [FieldOffset(0)]
    public byte Value;

    [CallerCount(59)]
    [CachedScanResults(RefRangeStart = 562577, RefRangeEnd = 562636, XrefRangeStart = 562577, XrefRangeEnd = 562636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator byte(OutgoingNetBuffer e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OutgoingNetBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_Byte_OutgoingNetBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(59)]
    [CachedScanResults(RefRangeStart = 562577, RefRangeEnd = 562636, XrefRangeStart = 562577, XrefRangeEnd = 562636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator OutgoingNetBuffer(byte e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OutgoingNetBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_OutgoingNetBuffer_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(OutgoingNetBuffer*) IL2CPP.il2cpp_object_unbox(num);
    }

    static OutgoingNetBuffer()
    {
      Il2CppClassPointerStore<OutgoingNetBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (OutgoingNetBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutgoingNetBuffer>.NativeClassPtr);
      OutgoingNetBuffer.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutgoingNetBuffer>.NativeClassPtr, nameof (Value));
      OutgoingNetBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_Byte_OutgoingNetBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingNetBuffer>.NativeClassPtr, 100669045);
      OutgoingNetBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_OutgoingNetBuffer_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingNetBuffer>.NativeClassPtr, 100669046);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OutgoingNetBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
