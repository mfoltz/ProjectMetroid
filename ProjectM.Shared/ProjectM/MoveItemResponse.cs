// Decompiled with JetBrains decompiler
// Type: ProjectM.MoveItemResponse
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MoveItemResponse
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Result;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_MoveItemResponse_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Success_Public_get_Boolean_0;
    [FieldOffset(0)]
    public MoveItemResult Result;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 738449, RefRangeEnd = 738453, XrefRangeStart = 738449, XrefRangeEnd = 738449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator bool(MoveItemResponse response)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &response;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MoveItemResponse.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_MoveItemResponse_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public unsafe bool Success
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 738453, RefRangeEnd = 738456, XrefRangeStart = 738453, XrefRangeEnd = 738453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MoveItemResponse.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static MoveItemResponse()
    {
      Il2CppClassPointerStore<MoveItemResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MoveItemResponse));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemResponse>.NativeClassPtr);
      MoveItemResponse.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemResponse>.NativeClassPtr, nameof (Result));
      MoveItemResponse.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_MoveItemResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemResponse>.NativeClassPtr, 100665207);
      MoveItemResponse.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemResponse>.NativeClassPtr, 100665208);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveItemResponse>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
