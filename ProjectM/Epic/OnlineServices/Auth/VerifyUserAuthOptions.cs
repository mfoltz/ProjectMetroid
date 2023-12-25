// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.VerifyUserAuthOptions
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
  public sealed class VerifyUserAuthOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__AuthToken_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AuthToken_Public_get_Nullable_1_Token_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AuthToken_Public_set_Void_Nullable_1_Token_0;

    public unsafe Il2CppSystem.Nullable<Token> AuthToken
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(VerifyUserAuthOptions.NativeMethodInfoPtr_get_AuthToken_Public_get_Nullable_1_Token_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new Il2CppSystem.Nullable<Token>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968721, XrefRangeEnd = 968722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VerifyUserAuthOptions.NativeMethodInfoPtr_set_AuthToken_Public_set_Void_Nullable_1_Token_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static VerifyUserAuthOptions()
    {
      Il2CppClassPointerStore<VerifyUserAuthOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Auth", nameof (VerifyUserAuthOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerifyUserAuthOptions>.NativeClassPtr);
      VerifyUserAuthOptions.NativeFieldInfoPtr__AuthToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyUserAuthOptions>.NativeClassPtr, "<AuthToken>k__BackingField");
      VerifyUserAuthOptions.NativeMethodInfoPtr_get_AuthToken_Public_get_Nullable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyUserAuthOptions>.NativeClassPtr, 100673717);
      VerifyUserAuthOptions.NativeMethodInfoPtr_set_AuthToken_Public_set_Void_Nullable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyUserAuthOptions>.NativeClassPtr, 100673718);
    }

    public VerifyUserAuthOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public VerifyUserAuthOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VerifyUserAuthOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VerifyUserAuthOptions>.NativeClassPtr, data));
    }

    public Il2CppSystem.Nullable<Token> _AuthToken_k__BackingField
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyUserAuthOptions.NativeFieldInfoPtr__AuthToken_k__BackingField);
        return new Il2CppSystem.Nullable<Token>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<Token>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyUserAuthOptions.NativeFieldInfoPtr__AuthToken_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<Token>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
