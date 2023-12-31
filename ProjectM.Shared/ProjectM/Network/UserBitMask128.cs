// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.UserBitMask128
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UserBitMask128
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_None_Public_Static_get_UserBitMask128_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetUserBit_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsUserBitSet_Public_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveUserBit_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasUserBit_Public_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_UserBitMask128_UserBitMask128_UserBitMask128_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_UserBitMask128_UserBitMask128_UserBitMask128_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_UserBitMask128_UserBitMask128_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BitwiseAndIntoAInverted_Public_Static_Void_NativeArray_1_UserBitMask128_NativeArray_1_UserBitMask128_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BitwiseAndIntoA_Public_Static_Void_NativeArray_1_UserBitMask128_NativeArray_1_UserBitMask128_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AnySet_Public_Static_Boolean_NativeArray_1_UserBitMask128_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUsers_Public_Void_NativeList_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUsers_Public_Void_NativeList_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUsers_Private_Static_Void_Int32_Int32_NativeList_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUsers_Private_Static_Void_Int32_Int32_NativeList_1_Byte_0;
    [FieldOffset(0)]
    public int4 Value;

    public static unsafe UserBitMask128 None
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 533439, RefRangeEnd = 533493, XrefRangeStart = 533439, XrefRangeEnd = 533493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserBitMask128.NativeMethodInfoPtr_get_None_Public_Static_get_UserBitMask128_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(UserBitMask128*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsEmpty
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 785750, RefRangeEnd = 785753, XrefRangeStart = 785750, XrefRangeEnd = 785750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserBitMask128.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 785755, RefRangeEnd = 785766, XrefRangeStart = 785753, XrefRangeEnd = 785755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetUserBit(int userIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &userIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserBitMask128.NativeMethodInfoPtr_SetUserBit_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785766, XrefRangeEnd = 785768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsUserBitSet(int userIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &userIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserBitMask128.NativeMethodInfoPtr_IsUserBitSet_Public_Boolean_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 785770, RefRangeEnd = 785776, XrefRangeStart = 785768, XrefRangeEnd = 785770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveUserBit(int userIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &userIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserBitMask128.NativeMethodInfoPtr_RemoveUserBit_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785778, RefRangeEnd = 785779, XrefRangeStart = 785776, XrefRangeEnd = 785778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasUserBit(int userIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &userIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserBitMask128.NativeMethodInfoPtr_HasUserBit_Public_Boolean_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe UserBitMask128 operator &(UserBitMask128 left, UserBitMask128 right)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &left;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &right;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserBitMask128.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_UserBitMask128_UserBitMask128_UserBitMask128_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UserBitMask128*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe UserBitMask128 operator |(UserBitMask128 left, UserBitMask128 right)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &left;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &right;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserBitMask128.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_UserBitMask128_UserBitMask128_UserBitMask128_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UserBitMask128*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe UserBitMask128 operator ~(UserBitMask128 value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserBitMask128.NativeMethodInfoPtr_op_OnesComplement_Public_Static_UserBitMask128_UserBitMask128_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UserBitMask128*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785779, XrefRangeEnd = 785786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void BitwiseAndIntoAInverted(
      NativeArray<UserBitMask128> a,
      NativeArray<UserBitMask128> b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserBitMask128.NativeMethodInfoPtr_BitwiseAndIntoAInverted_Public_Static_Void_NativeArray_1_UserBitMask128_NativeArray_1_UserBitMask128_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785786, XrefRangeEnd = 785793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void BitwiseAndIntoA(
      NativeArray<UserBitMask128> a,
      NativeArray<UserBitMask128> b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserBitMask128.NativeMethodInfoPtr_BitwiseAndIntoA_Public_Static_Void_NativeArray_1_UserBitMask128_NativeArray_1_UserBitMask128_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785793, XrefRangeEnd = 785796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool AnySet(NativeArray<UserBitMask128> a)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &a;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserBitMask128.NativeMethodInfoPtr_AnySet_Public_Static_Boolean_NativeArray_1_UserBitMask128_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 785800, RefRangeEnd = 785803, XrefRangeStart = 785796, XrefRangeEnd = 785800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetUsers(NativeList<int> users)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &users;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserBitMask128.NativeMethodInfoPtr_GetUsers_Public_Void_NativeList_1_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785803, XrefRangeEnd = 785807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetUsers(NativeList<byte> users)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &users;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserBitMask128.NativeMethodInfoPtr_GetUsers_Public_Void_NativeList_1_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 785810, RefRangeEnd = 785814, XrefRangeStart = 785807, XrefRangeEnd = 785810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetUsers(int bitset, int userOffset, NativeList<int> users)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &bitset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &users;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserBitMask128.NativeMethodInfoPtr_GetUsers_Private_Static_Void_Int32_Int32_NativeList_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 785817, RefRangeEnd = 785821, XrefRangeStart = 785814, XrefRangeEnd = 785817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetUsers(int bitset, int userOffset, NativeList<byte> users)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &bitset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &users;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserBitMask128.NativeMethodInfoPtr_GetUsers_Private_Static_Void_Int32_Int32_NativeList_1_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UserBitMask128()
    {
      Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (UserBitMask128));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr);
      UserBitMask128.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr, nameof (Value));
      UserBitMask128.NativeMethodInfoPtr_get_None_Public_Static_get_UserBitMask128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr, 100669246);
      UserBitMask128.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr, 100669247);
      UserBitMask128.NativeMethodInfoPtr_SetUserBit_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr, 100669248);
      UserBitMask128.NativeMethodInfoPtr_IsUserBitSet_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr, 100669249);
      UserBitMask128.NativeMethodInfoPtr_RemoveUserBit_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr, 100669250);
      UserBitMask128.NativeMethodInfoPtr_HasUserBit_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr, 100669251);
      UserBitMask128.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_UserBitMask128_UserBitMask128_UserBitMask128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr, 100669252);
      UserBitMask128.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_UserBitMask128_UserBitMask128_UserBitMask128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr, 100669253);
      UserBitMask128.NativeMethodInfoPtr_op_OnesComplement_Public_Static_UserBitMask128_UserBitMask128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr, 100669254);
      UserBitMask128.NativeMethodInfoPtr_BitwiseAndIntoAInverted_Public_Static_Void_NativeArray_1_UserBitMask128_NativeArray_1_UserBitMask128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr, 100669255);
      UserBitMask128.NativeMethodInfoPtr_BitwiseAndIntoA_Public_Static_Void_NativeArray_1_UserBitMask128_NativeArray_1_UserBitMask128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr, 100669256);
      UserBitMask128.NativeMethodInfoPtr_AnySet_Public_Static_Boolean_NativeArray_1_UserBitMask128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr, 100669257);
      UserBitMask128.NativeMethodInfoPtr_GetUsers_Public_Void_NativeList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr, 100669258);
      UserBitMask128.NativeMethodInfoPtr_GetUsers_Public_Void_NativeList_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr, 100669259);
      UserBitMask128.NativeMethodInfoPtr_GetUsers_Private_Static_Void_Int32_Int32_NativeList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr, 100669260);
      UserBitMask128.NativeMethodInfoPtr_GetUsers_Private_Static_Void_Int32_Int32_NativeList_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr, 100669261);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserBitMask128>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
