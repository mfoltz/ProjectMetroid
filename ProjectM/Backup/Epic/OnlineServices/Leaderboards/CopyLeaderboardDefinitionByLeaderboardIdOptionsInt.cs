// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Leaderboards
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LeaderboardId;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LeaderboardId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CopyLeaderboardDefinitionByLeaderboardIdOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CopyLeaderboardDefinitionByLeaderboardIdOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LeaderboardId;

    public unsafe Epic.OnlineServices.Utf8String LeaderboardId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958440, XrefRangeEnd = 958444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeMethodInfoPtr_set_LeaderboardId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 958448, RefRangeEnd = 958449, XrefRangeStart = 958444, XrefRangeEnd = 958448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref CopyLeaderboardDefinitionByLeaderboardIdOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CopyLeaderboardDefinitionByLeaderboardIdOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958449, XrefRangeEnd = 958457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<CopyLeaderboardDefinitionByLeaderboardIdOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CopyLeaderboardDefinitionByLeaderboardIdOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958457, XrefRangeEnd = 958461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal()
    {
      Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Leaderboards", nameof (CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal>.NativeClassPtr);
      CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeFieldInfoPtr_m_LeaderboardId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal>.NativeClassPtr, nameof (m_LeaderboardId));
      CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeMethodInfoPtr_set_LeaderboardId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal>.NativeClassPtr, 100670868);
      CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CopyLeaderboardDefinitionByLeaderboardIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal>.NativeClassPtr, 100670869);
      CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CopyLeaderboardDefinitionByLeaderboardIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal>.NativeClassPtr, 100670870);
      CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal>.NativeClassPtr, 100670871);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
