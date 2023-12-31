// Decompiled with JetBrains decompiler
// Type: ProjectM.GetInventoryResponse
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
  public struct GetInventoryResponse
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Success;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_GetInventoryResponse_0;
    [FieldOffset(0)]
    public bool Success;

    [CallerCount(59)]
    [CachedScanResults(RefRangeStart = 562577, RefRangeEnd = 562636, XrefRangeStart = 562577, XrefRangeEnd = 562636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator bool(GetInventoryResponse response)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &response;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetInventoryResponse.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_GetInventoryResponse_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static GetInventoryResponse()
    {
      Il2CppClassPointerStore<GetInventoryResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GetInventoryResponse));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetInventoryResponse>.NativeClassPtr);
      GetInventoryResponse.NativeFieldInfoPtr_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetInventoryResponse>.NativeClassPtr, nameof (Success));
      GetInventoryResponse.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_GetInventoryResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetInventoryResponse>.NativeClassPtr, 100665210);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetInventoryResponse>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
