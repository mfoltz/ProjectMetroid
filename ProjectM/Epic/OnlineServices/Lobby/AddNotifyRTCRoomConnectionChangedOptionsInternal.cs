// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.AddNotifyRTCRoomConnectionChangedOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AddNotifyRTCRoomConnectionChangedOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LobbyId_DEPRECATED;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId_DEPRECATED;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LobbyId_DEPRECATED_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_DEPRECATED_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AddNotifyRTCRoomConnectionChangedOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AddNotifyRTCRoomConnectionChangedOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LobbyId_DEPRECATED;
    [FieldOffset(16)]
    public System.IntPtr m_LocalUserId_DEPRECATED;

    public unsafe Epic.OnlineServices.Utf8String LobbyId_DEPRECATED
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953716, XrefRangeEnd = 953720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AddNotifyRTCRoomConnectionChangedOptionsInternal.NativeMethodInfoPtr_set_LobbyId_DEPRECATED_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId LocalUserId_DEPRECATED
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953720, XrefRangeEnd = 953724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AddNotifyRTCRoomConnectionChangedOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_DEPRECATED_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 953732, RefRangeEnd = 953733, XrefRangeStart = 953724, XrefRangeEnd = 953732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref AddNotifyRTCRoomConnectionChangedOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AddNotifyRTCRoomConnectionChangedOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AddNotifyRTCRoomConnectionChangedOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953733, XrefRangeEnd = 953747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<AddNotifyRTCRoomConnectionChangedOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AddNotifyRTCRoomConnectionChangedOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AddNotifyRTCRoomConnectionChangedOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953747, XrefRangeEnd = 953752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AddNotifyRTCRoomConnectionChangedOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AddNotifyRTCRoomConnectionChangedOptionsInternal()
    {
      Il2CppClassPointerStore<AddNotifyRTCRoomConnectionChangedOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Lobby", nameof (AddNotifyRTCRoomConnectionChangedOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddNotifyRTCRoomConnectionChangedOptionsInternal>.NativeClassPtr);
      AddNotifyRTCRoomConnectionChangedOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddNotifyRTCRoomConnectionChangedOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      AddNotifyRTCRoomConnectionChangedOptionsInternal.NativeFieldInfoPtr_m_LobbyId_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddNotifyRTCRoomConnectionChangedOptionsInternal>.NativeClassPtr, nameof (m_LobbyId_DEPRECATED));
      AddNotifyRTCRoomConnectionChangedOptionsInternal.NativeFieldInfoPtr_m_LocalUserId_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddNotifyRTCRoomConnectionChangedOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId_DEPRECATED));
      AddNotifyRTCRoomConnectionChangedOptionsInternal.NativeMethodInfoPtr_set_LobbyId_DEPRECATED_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyRTCRoomConnectionChangedOptionsInternal>.NativeClassPtr, 100669608);
      AddNotifyRTCRoomConnectionChangedOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_DEPRECATED_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyRTCRoomConnectionChangedOptionsInternal>.NativeClassPtr, 100669609);
      AddNotifyRTCRoomConnectionChangedOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AddNotifyRTCRoomConnectionChangedOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyRTCRoomConnectionChangedOptionsInternal>.NativeClassPtr, 100669610);
      AddNotifyRTCRoomConnectionChangedOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AddNotifyRTCRoomConnectionChangedOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyRTCRoomConnectionChangedOptionsInternal>.NativeClassPtr, 100669611);
      AddNotifyRTCRoomConnectionChangedOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyRTCRoomConnectionChangedOptionsInternal>.NativeClassPtr, 100669612);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddNotifyRTCRoomConnectionChangedOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
