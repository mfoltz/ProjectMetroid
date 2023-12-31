// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.UserNetBuffer
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
  public struct UserNetBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Byte_UserNetBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UserNetBuffer_Byte_0;
    [FieldOffset(0)]
    public byte Value;

    [CallerCount(59)]
    [CachedScanResults(RefRangeStart = 562577, RefRangeEnd = 562636, XrefRangeStart = 562577, XrefRangeEnd = 562636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator byte(UserNetBuffer e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserNetBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_Byte_UserNetBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(59)]
    [CachedScanResults(RefRangeStart = 562577, RefRangeEnd = 562636, XrefRangeStart = 562577, XrefRangeEnd = 562636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator UserNetBuffer(byte e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserNetBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_UserNetBuffer_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UserNetBuffer*) IL2CPP.il2cpp_object_unbox(num);
    }

    static UserNetBuffer()
    {
      Il2CppClassPointerStore<UserNetBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (UserNetBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserNetBuffer>.NativeClassPtr);
      UserNetBuffer.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserNetBuffer>.NativeClassPtr, nameof (Value));
      UserNetBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_Byte_UserNetBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserNetBuffer>.NativeClassPtr, 100669224);
      UserNetBuffer.NativeMethodInfoPtr_op_Implicit_Public_Static_UserNetBuffer_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserNetBuffer>.NativeClassPtr, 100669225);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserNetBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
