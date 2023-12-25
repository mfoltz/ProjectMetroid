// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.RegisterPlayersOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RegisterPlayersOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SessionName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayersToRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayersToRegisterCount;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayersToRegister_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_RegisterPlayersOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_RegisterPlayersOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_SessionName;
    [FieldOffset(16)]
    public System.IntPtr m_PlayersToRegister;
    [FieldOffset(24)]
    public uint m_PlayersToRegisterCount;

    public unsafe Epic.OnlineServices.Utf8String SessionName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941280, XrefRangeEnd = 941284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterPlayersOptionsInternal.NativeMethodInfoPtr_set_SessionName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<ProductUserId> PlayersToRegister
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 941290, RefRangeEnd = 941292, XrefRangeStart = 941284, XrefRangeEnd = 941290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterPlayersOptionsInternal.NativeMethodInfoPtr_set_PlayersToRegister_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 941297, RefRangeEnd = 941299, XrefRangeStart = 941292, XrefRangeEnd = 941297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref RegisterPlayersOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RegisterPlayersOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_RegisterPlayersOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941299, XrefRangeEnd = 941310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<RegisterPlayersOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RegisterPlayersOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_RegisterPlayersOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941310, XrefRangeEnd = 941315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RegisterPlayersOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RegisterPlayersOptionsInternal()
    {
      Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sessions", nameof (RegisterPlayersOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr);
      RegisterPlayersOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      RegisterPlayersOptionsInternal.NativeFieldInfoPtr_m_SessionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, nameof (m_SessionName));
      RegisterPlayersOptionsInternal.NativeFieldInfoPtr_m_PlayersToRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, nameof (m_PlayersToRegister));
      RegisterPlayersOptionsInternal.NativeFieldInfoPtr_m_PlayersToRegisterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, nameof (m_PlayersToRegisterCount));
      RegisterPlayersOptionsInternal.NativeMethodInfoPtr_set_SessionName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, 100666269);
      RegisterPlayersOptionsInternal.NativeMethodInfoPtr_set_PlayersToRegister_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, 100666270);
      RegisterPlayersOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_RegisterPlayersOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, 100666271);
      RegisterPlayersOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_RegisterPlayersOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, 100666272);
      RegisterPlayersOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, 100666273);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
