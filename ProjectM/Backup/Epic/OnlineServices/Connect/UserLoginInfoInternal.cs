// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.UserLoginInfoInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UserLoginInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayName;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DisplayName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UserLoginInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UserLoginInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_UserLoginInfo_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_DisplayName;

    public unsafe Epic.OnlineServices.Utf8String DisplayName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966579, XrefRangeEnd = 966583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserLoginInfoInternal.NativeMethodInfoPtr_get_DisplayName_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966583, XrefRangeEnd = 966587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserLoginInfoInternal.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966587, XrefRangeEnd = 966591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref UserLoginInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserLoginInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UserLoginInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966591, XrefRangeEnd = 966599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<UserLoginInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserLoginInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UserLoginInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966599, XrefRangeEnd = 966603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserLoginInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966603, XrefRangeEnd = 966604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out UserLoginInfo output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserLoginInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_UserLoginInfo_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref UserLoginInfo local = ref output;
      System.IntPtr pointer = zero;
      UserLoginInfo userLoginInfo = pointer == System.IntPtr.Zero ? (UserLoginInfo) null : new UserLoginInfo(pointer);
      local = userLoginInfo;
    }

    static UserLoginInfoInternal()
    {
      Il2CppClassPointerStore<UserLoginInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Connect", nameof (UserLoginInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserLoginInfoInternal>.NativeClassPtr);
      UserLoginInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserLoginInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
      UserLoginInfoInternal.NativeFieldInfoPtr_m_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserLoginInfoInternal>.NativeClassPtr, nameof (m_DisplayName));
      UserLoginInfoInternal.NativeMethodInfoPtr_get_DisplayName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLoginInfoInternal>.NativeClassPtr, 100673169);
      UserLoginInfoInternal.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLoginInfoInternal>.NativeClassPtr, 100673170);
      UserLoginInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UserLoginInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLoginInfoInternal>.NativeClassPtr, 100673171);
      UserLoginInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UserLoginInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLoginInfoInternal>.NativeClassPtr, 100673172);
      UserLoginInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLoginInfoInternal>.NativeClassPtr, 100673173);
      UserLoginInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_UserLoginInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLoginInfoInternal>.NativeClassPtr, 100673174);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserLoginInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
