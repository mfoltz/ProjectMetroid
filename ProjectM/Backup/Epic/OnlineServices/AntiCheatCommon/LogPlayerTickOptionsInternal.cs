// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogPlayerTickOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LogPlayerTickOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerViewRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_IsPlayerViewZoomed;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerMovementState;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerHealth_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerMovementState_Public_set_Void_AntiCheatCommonPlayerMovementState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogPlayerTickOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_LogPlayerTickOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_PlayerHandle;
    [FieldOffset(16)]
    public System.IntPtr m_PlayerPosition;
    [FieldOffset(24)]
    public System.IntPtr m_PlayerViewRotation;
    [FieldOffset(32)]
    public int m_IsPlayerViewZoomed;
    [FieldOffset(36)]
    public float m_PlayerHealth;
    [FieldOffset(40)]
    public AntiCheatCommonPlayerMovementState m_PlayerMovementState;

    public unsafe System.IntPtr PlayerHandle
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Vec3f> PlayerPosition
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970258, XrefRangeEnd = 970264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Quat> PlayerViewRotation
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970264, XrefRangeEnd = 970270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool IsPlayerViewZoomed
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970270, XrefRangeEnd = 970274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float PlayerHealth
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 538767, RefRangeEnd = 538768, XrefRangeStart = 538767, XrefRangeEnd = 538768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerHealth_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonPlayerMovementState PlayerMovementState
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerMovementState_Public_set_Void_AntiCheatCommonPlayerMovementState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 970290, RefRangeEnd = 970291, XrefRangeStart = 970274, XrefRangeEnd = 970290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref LogPlayerTickOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogPlayerTickOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970291, XrefRangeEnd = 970321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Nullable_Unboxed<LogPlayerTickOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_LogPlayerTickOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970321, XrefRangeEnd = 970327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LogPlayerTickOptionsInternal()
    {
      Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogPlayerTickOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr);
      LogPlayerTickOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      LogPlayerTickOptionsInternal.NativeFieldInfoPtr_m_PlayerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, nameof (m_PlayerHandle));
      LogPlayerTickOptionsInternal.NativeFieldInfoPtr_m_PlayerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, nameof (m_PlayerPosition));
      LogPlayerTickOptionsInternal.NativeFieldInfoPtr_m_PlayerViewRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, nameof (m_PlayerViewRotation));
      LogPlayerTickOptionsInternal.NativeFieldInfoPtr_m_IsPlayerViewZoomed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, nameof (m_IsPlayerViewZoomed));
      LogPlayerTickOptionsInternal.NativeFieldInfoPtr_m_PlayerHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, nameof (m_PlayerHealth));
      LogPlayerTickOptionsInternal.NativeFieldInfoPtr_m_PlayerMovementState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, nameof (m_PlayerMovementState));
      LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, 100674112);
      LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Nullable_Unboxed_1_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, 100674113);
      LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Nullable_Unboxed_1_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, 100674114);
      LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, 100674115);
      LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerHealth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, 100674116);
      LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerMovementState_Public_set_Void_AntiCheatCommonPlayerMovementState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, 100674117);
      LogPlayerTickOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogPlayerTickOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, 100674118);
      LogPlayerTickOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_LogPlayerTickOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, 100674119);
      LogPlayerTickOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, 100674120);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
