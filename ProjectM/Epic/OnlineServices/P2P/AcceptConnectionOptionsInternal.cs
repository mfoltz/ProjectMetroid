// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.AcceptConnectionOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AcceptConnectionOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RemoteUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SocketId;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RemoteUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SocketId_Public_set_Void_Nullable_1_SocketId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AcceptConnectionOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AcceptConnectionOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public System.IntPtr m_RemoteUserId;
    [FieldOffset(24)]
    public System.IntPtr m_SocketId;

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950854, XrefRangeEnd = 950858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AcceptConnectionOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId RemoteUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950858, XrefRangeEnd = 950862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AcceptConnectionOptionsInternal.NativeMethodInfoPtr_set_RemoteUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppSystem.Nullable<Epic.OnlineServices.P2P.SocketId> SocketId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950862, XrefRangeEnd = 950868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AcceptConnectionOptionsInternal.NativeMethodInfoPtr_set_SocketId_Public_set_Void_Nullable_1_SocketId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 950882, RefRangeEnd = 950883, XrefRangeStart = 950868, XrefRangeEnd = 950882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref AcceptConnectionOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AcceptConnectionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AcceptConnectionOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950883, XrefRangeEnd = 950905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<AcceptConnectionOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AcceptConnectionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AcceptConnectionOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 950911, RefRangeEnd = 950912, XrefRangeStart = 950905, XrefRangeEnd = 950911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AcceptConnectionOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AcceptConnectionOptionsInternal()
    {
      Il2CppClassPointerStore<AcceptConnectionOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.P2P", nameof (AcceptConnectionOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AcceptConnectionOptionsInternal>.NativeClassPtr);
      AcceptConnectionOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcceptConnectionOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      AcceptConnectionOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcceptConnectionOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      AcceptConnectionOptionsInternal.NativeFieldInfoPtr_m_RemoteUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcceptConnectionOptionsInternal>.NativeClassPtr, nameof (m_RemoteUserId));
      AcceptConnectionOptionsInternal.NativeFieldInfoPtr_m_SocketId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcceptConnectionOptionsInternal>.NativeClassPtr, nameof (m_SocketId));
      AcceptConnectionOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcceptConnectionOptionsInternal>.NativeClassPtr, 100668831);
      AcceptConnectionOptionsInternal.NativeMethodInfoPtr_set_RemoteUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcceptConnectionOptionsInternal>.NativeClassPtr, 100668832);
      AcceptConnectionOptionsInternal.NativeMethodInfoPtr_set_SocketId_Public_set_Void_Nullable_1_SocketId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcceptConnectionOptionsInternal>.NativeClassPtr, 100668833);
      AcceptConnectionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AcceptConnectionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcceptConnectionOptionsInternal>.NativeClassPtr, 100668834);
      AcceptConnectionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AcceptConnectionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcceptConnectionOptionsInternal>.NativeClassPtr, 100668835);
      AcceptConnectionOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcceptConnectionOptionsInternal>.NativeClassPtr, 100668836);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AcceptConnectionOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
