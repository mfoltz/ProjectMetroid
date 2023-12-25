// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.LoginOptions
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
  public sealed class LoginOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Credentials_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__UserLoginInfo_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Credentials_Public_get_Nullable_1_Credentials_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Credentials_Public_set_Void_Nullable_1_Credentials_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UserLoginInfo_Public_get_Nullable_1_UserLoginInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UserLoginInfo_Public_set_Void_Nullable_1_UserLoginInfo_0;

    public unsafe Il2CppSystem.Nullable<Epic.OnlineServices.Connect.Credentials> Credentials
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 242918, RefRangeEnd = 242920, XrefRangeStart = 242918, XrefRangeEnd = 242920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LoginOptions.NativeMethodInfoPtr_get_Credentials_Public_get_Nullable_1_Credentials_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new Il2CppSystem.Nullable<Epic.OnlineServices.Connect.Credentials>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965985, XrefRangeEnd = 965986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LoginOptions.NativeMethodInfoPtr_set_Credentials_Public_set_Void_Nullable_1_Credentials_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppSystem.Nullable<Epic.OnlineServices.Connect.UserLoginInfo> UserLoginInfo
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 73358, RefRangeEnd = 73412, XrefRangeStart = 73358, XrefRangeEnd = 73412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LoginOptions.NativeMethodInfoPtr_get_UserLoginInfo_Public_get_Nullable_1_UserLoginInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new Il2CppSystem.Nullable<Epic.OnlineServices.Connect.UserLoginInfo>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LoginOptions.NativeMethodInfoPtr_set_UserLoginInfo_Public_set_Void_Nullable_1_UserLoginInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static LoginOptions()
    {
      Il2CppClassPointerStore<LoginOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Connect", nameof (LoginOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoginOptions>.NativeClassPtr);
      LoginOptions.NativeFieldInfoPtr__Credentials_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginOptions>.NativeClassPtr, "<Credentials>k__BackingField");
      LoginOptions.NativeFieldInfoPtr__UserLoginInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginOptions>.NativeClassPtr, "<UserLoginInfo>k__BackingField");
      LoginOptions.NativeMethodInfoPtr_get_Credentials_Public_get_Nullable_1_Credentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptions>.NativeClassPtr, 100672920);
      LoginOptions.NativeMethodInfoPtr_set_Credentials_Public_set_Void_Nullable_1_Credentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptions>.NativeClassPtr, 100672921);
      LoginOptions.NativeMethodInfoPtr_get_UserLoginInfo_Public_get_Nullable_1_UserLoginInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptions>.NativeClassPtr, 100672922);
      LoginOptions.NativeMethodInfoPtr_set_UserLoginInfo_Public_set_Void_Nullable_1_UserLoginInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptions>.NativeClassPtr, 100672923);
    }

    public LoginOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public LoginOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LoginOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LoginOptions>.NativeClassPtr, data));
    }

    public Il2CppSystem.Nullable<Epic.OnlineServices.Connect.Credentials> _Credentials_k__BackingField
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoginOptions.NativeFieldInfoPtr__Credentials_k__BackingField);
        return new Il2CppSystem.Nullable<Epic.OnlineServices.Connect.Credentials>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<Epic.OnlineServices.Connect.Credentials>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoginOptions.NativeFieldInfoPtr__Credentials_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<Epic.OnlineServices.Connect.Credentials>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public Il2CppSystem.Nullable<Epic.OnlineServices.Connect.UserLoginInfo> _UserLoginInfo_k__BackingField
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoginOptions.NativeFieldInfoPtr__UserLoginInfo_k__BackingField);
        return new Il2CppSystem.Nullable<Epic.OnlineServices.Connect.UserLoginInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<Epic.OnlineServices.Connect.UserLoginInfo>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoginOptions.NativeFieldInfoPtr__UserLoginInfo_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<Epic.OnlineServices.Connect.UserLoginInfo>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
