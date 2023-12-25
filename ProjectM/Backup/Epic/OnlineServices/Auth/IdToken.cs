﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.IdToken
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
  public sealed class IdToken : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__AccountId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__JsonWebToken_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AccountId_Public_get_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountId_Public_set_Void_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_JsonWebToken_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_JsonWebToken_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_IdTokenInternal_0;

    public unsafe EpicAccountId AccountId
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdToken.NativeMethodInfoPtr_get_AccountId_Public_get_EpicAccountId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdToken.NativeMethodInfoPtr_set_AccountId_Public_set_Void_EpicAccountId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String JsonWebToken
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdToken.NativeMethodInfoPtr_get_JsonWebToken_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 318047, RefRangeEnd = 318048, XrefRangeStart = 318047, XrefRangeEnd = 318048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdToken.NativeMethodInfoPtr_set_JsonWebToken_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 967384, RefRangeEnd = 967385, XrefRangeStart = 967377, XrefRangeEnd = 967384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref IdTokenInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IdToken.NativeMethodInfoPtr_Set_Internal_Void_byref_IdTokenInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IdToken()
    {
      Il2CppClassPointerStore<IdToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Auth", nameof (IdToken));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdToken>.NativeClassPtr);
      IdToken.NativeFieldInfoPtr__AccountId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdToken>.NativeClassPtr, "<AccountId>k__BackingField");
      IdToken.NativeFieldInfoPtr__JsonWebToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdToken>.NativeClassPtr, "<JsonWebToken>k__BackingField");
      IdToken.NativeMethodInfoPtr_get_AccountId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdToken>.NativeClassPtr, 100673331);
      IdToken.NativeMethodInfoPtr_set_AccountId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdToken>.NativeClassPtr, 100673332);
      IdToken.NativeMethodInfoPtr_get_JsonWebToken_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdToken>.NativeClassPtr, 100673333);
      IdToken.NativeMethodInfoPtr_set_JsonWebToken_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdToken>.NativeClassPtr, 100673334);
      IdToken.NativeMethodInfoPtr_Set_Internal_Void_byref_IdTokenInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdToken>.NativeClassPtr, 100673335);
    }

    public IdToken(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public IdToken()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<IdToken>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdToken>.NativeClassPtr, data));
    }

    public unsafe EpicAccountId _AccountId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdToken.NativeFieldInfoPtr__AccountId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IdToken.NativeFieldInfoPtr__AccountId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _JsonWebToken_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdToken.NativeFieldInfoPtr__JsonWebToken_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IdToken.NativeFieldInfoPtr__JsonWebToken_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
