// Decompiled with JetBrains decompiler
// Type: ProjectM.AddItemResponse
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AddItemResponse
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Result;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_RemainingAmount;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_AddItemResponse_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Success_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemsRemaining_Public_get_Boolean_0;
    [FieldOffset(0)]
    public AddItemResult Result;
    [FieldOffset(4)]
    public Entity NewEntity;
    [FieldOffset(12)]
    public int RemainingAmount;

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 738432, RefRangeEnd = 738449, XrefRangeStart = 738432, XrefRangeEnd = 738432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator bool(AddItemResponse response)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &response;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AddItemResponse.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_AddItemResponse_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public unsafe bool Success
    {
      [CallerCount(17), CachedScanResults(RefRangeStart = 738432, RefRangeEnd = 738449, XrefRangeStart = 738432, XrefRangeEnd = 738449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AddItemResponse.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool ItemsRemaining
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AddItemResponse.NativeMethodInfoPtr_get_ItemsRemaining_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static AddItemResponse()
    {
      Il2CppClassPointerStore<AddItemResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AddItemResponse));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddItemResponse>.NativeClassPtr);
      AddItemResponse.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddItemResponse>.NativeClassPtr, nameof (Result));
      AddItemResponse.NativeFieldInfoPtr_NewEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddItemResponse>.NativeClassPtr, nameof (NewEntity));
      AddItemResponse.NativeFieldInfoPtr_RemainingAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddItemResponse>.NativeClassPtr, nameof (RemainingAmount));
      AddItemResponse.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_AddItemResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddItemResponse>.NativeClassPtr, 100665204);
      AddItemResponse.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddItemResponse>.NativeClassPtr, 100665205);
      AddItemResponse.NativeMethodInfoPtr_get_ItemsRemaining_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddItemResponse>.NativeClassPtr, 100665206);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddItemResponse>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
