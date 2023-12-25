// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.UnregisterPlayersOptionsInternal
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
  public struct UnregisterPlayersOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SessionName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayersToUnregister;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayersToUnregisterCount;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayersToUnregister_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UnregisterPlayersOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UnregisterPlayersOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_SessionName;
    [FieldOffset(16)]
    public System.IntPtr m_PlayersToUnregister;
    [FieldOffset(24)]
    public uint m_PlayersToUnregisterCount;

    public unsafe Epic.OnlineServices.Utf8String SessionName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943092, XrefRangeEnd = 943096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnregisterPlayersOptionsInternal.NativeMethodInfoPtr_set_SessionName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<ProductUserId> PlayersToUnregister
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 943102, RefRangeEnd = 943104, XrefRangeStart = 943096, XrefRangeEnd = 943102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnregisterPlayersOptionsInternal.NativeMethodInfoPtr_set_PlayersToUnregister_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 943109, RefRangeEnd = 943111, XrefRangeStart = 943104, XrefRangeEnd = 943109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref UnregisterPlayersOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnregisterPlayersOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UnregisterPlayersOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943111, XrefRangeEnd = 943122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<UnregisterPlayersOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnregisterPlayersOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UnregisterPlayersOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943122, XrefRangeEnd = 943127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnregisterPlayersOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnregisterPlayersOptionsInternal()
    {
      Il2CppClassPointerStore<UnregisterPlayersOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sessions", nameof (UnregisterPlayersOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnregisterPlayersOptionsInternal>.NativeClassPtr);
      UnregisterPlayersOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnregisterPlayersOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      UnregisterPlayersOptionsInternal.NativeFieldInfoPtr_m_SessionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnregisterPlayersOptionsInternal>.NativeClassPtr, nameof (m_SessionName));
      UnregisterPlayersOptionsInternal.NativeFieldInfoPtr_m_PlayersToUnregister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnregisterPlayersOptionsInternal>.NativeClassPtr, nameof (m_PlayersToUnregister));
      UnregisterPlayersOptionsInternal.NativeFieldInfoPtr_m_PlayersToUnregisterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnregisterPlayersOptionsInternal>.NativeClassPtr, nameof (m_PlayersToUnregisterCount));
      UnregisterPlayersOptionsInternal.NativeMethodInfoPtr_set_SessionName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnregisterPlayersOptionsInternal>.NativeClassPtr, 100666698);
      UnregisterPlayersOptionsInternal.NativeMethodInfoPtr_set_PlayersToUnregister_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnregisterPlayersOptionsInternal>.NativeClassPtr, 100666699);
      UnregisterPlayersOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UnregisterPlayersOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnregisterPlayersOptionsInternal>.NativeClassPtr, 100666700);
      UnregisterPlayersOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UnregisterPlayersOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnregisterPlayersOptionsInternal>.NativeClassPtr, 100666701);
      UnregisterPlayersOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnregisterPlayersOptionsInternal>.NativeClassPtr, 100666702);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnregisterPlayersOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
