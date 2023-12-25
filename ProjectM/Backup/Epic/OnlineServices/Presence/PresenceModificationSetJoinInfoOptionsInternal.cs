// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Presence.PresenceModificationSetJoinInfoOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Presence
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PresenceModificationSetJoinInfoOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_JoinInfo;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_JoinInfo_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PresenceModificationSetJoinInfoOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_PresenceModificationSetJoinInfoOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_JoinInfo;

    public unsafe Epic.OnlineServices.Utf8String JoinInfo
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948910, XrefRangeEnd = 948914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetJoinInfoOptionsInternal.NativeMethodInfoPtr_set_JoinInfo_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948914, XrefRangeEnd = 948918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref PresenceModificationSetJoinInfoOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetJoinInfoOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PresenceModificationSetJoinInfoOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948918, XrefRangeEnd = 948926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<PresenceModificationSetJoinInfoOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetJoinInfoOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_PresenceModificationSetJoinInfoOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948926, XrefRangeEnd = 948930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetJoinInfoOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PresenceModificationSetJoinInfoOptionsInternal()
    {
      Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Presence", nameof (PresenceModificationSetJoinInfoOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptionsInternal>.NativeClassPtr);
      PresenceModificationSetJoinInfoOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      PresenceModificationSetJoinInfoOptionsInternal.NativeFieldInfoPtr_m_JoinInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptionsInternal>.NativeClassPtr, nameof (m_JoinInfo));
      PresenceModificationSetJoinInfoOptionsInternal.NativeMethodInfoPtr_set_JoinInfo_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptionsInternal>.NativeClassPtr, 100668280);
      PresenceModificationSetJoinInfoOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PresenceModificationSetJoinInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptionsInternal>.NativeClassPtr, 100668281);
      PresenceModificationSetJoinInfoOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_PresenceModificationSetJoinInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptionsInternal>.NativeClassPtr, 100668282);
      PresenceModificationSetJoinInfoOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptionsInternal>.NativeClassPtr, 100668283);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
