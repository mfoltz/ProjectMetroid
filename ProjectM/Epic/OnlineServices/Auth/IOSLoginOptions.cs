// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.IOSLoginOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Auth
{
  public sealed class IOSLoginOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Credentials_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ScopeFlags_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Credentials_Public_get_Nullable_1_IOSCredentials_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Credentials_Public_set_Void_Nullable_1_IOSCredentials_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ScopeFlags_Public_get_AuthScopeFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ScopeFlags_Public_set_Void_AuthScopeFlags_0;

    public unsafe Il2CppSystem.Nullable<IOSCredentials> Credentials
    {
      [CallerCount(10), CachedScanResults(RefRangeStart = 968849, RefRangeEnd = 968859, XrefRangeStart = 968849, XrefRangeEnd = 968849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IOSLoginOptions.NativeMethodInfoPtr_get_Credentials_Public_get_Nullable_1_IOSCredentials_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new Il2CppSystem.Nullable<IOSCredentials>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968859, XrefRangeEnd = 968860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IOSLoginOptions.NativeMethodInfoPtr_set_Credentials_Public_set_Void_Nullable_1_IOSCredentials_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AuthScopeFlags ScopeFlags
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IOSLoginOptions.NativeMethodInfoPtr_get_ScopeFlags_Public_get_AuthScopeFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AuthScopeFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IOSLoginOptions.NativeMethodInfoPtr_set_ScopeFlags_Public_set_Void_AuthScopeFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static IOSLoginOptions()
    {
      Il2CppClassPointerStore<IOSLoginOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Auth", nameof (IOSLoginOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOSLoginOptions>.NativeClassPtr);
      IOSLoginOptions.NativeFieldInfoPtr__Credentials_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSLoginOptions>.NativeClassPtr, "<Credentials>k__BackingField");
      IOSLoginOptions.NativeFieldInfoPtr__ScopeFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSLoginOptions>.NativeClassPtr, "<ScopeFlags>k__BackingField");
      IOSLoginOptions.NativeMethodInfoPtr_get_Credentials_Public_get_Nullable_1_IOSCredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSLoginOptions>.NativeClassPtr, 100673757);
      IOSLoginOptions.NativeMethodInfoPtr_set_Credentials_Public_set_Void_Nullable_1_IOSCredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSLoginOptions>.NativeClassPtr, 100673758);
      IOSLoginOptions.NativeMethodInfoPtr_get_ScopeFlags_Public_get_AuthScopeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSLoginOptions>.NativeClassPtr, 100673759);
      IOSLoginOptions.NativeMethodInfoPtr_set_ScopeFlags_Public_set_Void_AuthScopeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSLoginOptions>.NativeClassPtr, 100673760);
    }

    public IOSLoginOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public IOSLoginOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<IOSLoginOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IOSLoginOptions>.NativeClassPtr, data));
    }

    public Il2CppSystem.Nullable<IOSCredentials> _Credentials_k__BackingField
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IOSLoginOptions.NativeFieldInfoPtr__Credentials_k__BackingField);
        return new Il2CppSystem.Nullable<IOSCredentials>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<IOSCredentials>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IOSLoginOptions.NativeFieldInfoPtr__Credentials_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<IOSCredentials>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe AuthScopeFlags _ScopeFlags_k__BackingField
    {
      get
      {
        return *(AuthScopeFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IOSLoginOptions.NativeFieldInfoPtr__ScopeFlags_k__BackingField));
      }
      [param: In] set
      {
        *(AuthScopeFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IOSLoginOptions.NativeFieldInfoPtr__ScopeFlags_k__BackingField)) = value;
      }
    }
  }
}
