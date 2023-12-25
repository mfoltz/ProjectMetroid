// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogGameRoundStartOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LogGameRoundStartOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SessionIdentifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LevelName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ModeName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RoundTimeSeconds;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionIdentifier_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LevelName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ModeName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RoundTimeSeconds_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogGameRoundStartOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogGameRoundStartOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_SessionIdentifier;
    [FieldOffset(16)]
    public System.IntPtr m_LevelName;
    [FieldOffset(24)]
    public System.IntPtr m_ModeName;
    [FieldOffset(32)]
    public uint m_RoundTimeSeconds;

    public unsafe Epic.OnlineServices.Utf8String SessionIdentifier
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969977, XrefRangeEnd = 969981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_set_SessionIdentifier_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String LevelName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969981, XrefRangeEnd = 969985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_set_LevelName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ModeName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969985, XrefRangeEnd = 969989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_set_ModeName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint RoundTimeSeconds
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_set_RoundTimeSeconds_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 970001, RefRangeEnd = 970002, XrefRangeStart = 969989, XrefRangeEnd = 970001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref LogGameRoundStartOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogGameRoundStartOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970002, XrefRangeEnd = 970024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<LogGameRoundStartOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogGameRoundStartOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970024, XrefRangeEnd = 970030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LogGameRoundStartOptionsInternal()
    {
      Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogGameRoundStartOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr);
      LogGameRoundStartOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      LogGameRoundStartOptionsInternal.NativeFieldInfoPtr_m_SessionIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, nameof (m_SessionIdentifier));
      LogGameRoundStartOptionsInternal.NativeFieldInfoPtr_m_LevelName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, nameof (m_LevelName));
      LogGameRoundStartOptionsInternal.NativeFieldInfoPtr_m_ModeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, nameof (m_ModeName));
      LogGameRoundStartOptionsInternal.NativeFieldInfoPtr_m_RoundTimeSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, nameof (m_RoundTimeSeconds));
      LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_set_SessionIdentifier_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, 100674009);
      LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_set_LevelName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, 100674010);
      LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_set_ModeName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, 100674011);
      LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_set_RoundTimeSeconds_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, 100674012);
      LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogGameRoundStartOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, 100674013);
      LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogGameRoundStartOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, 100674014);
      LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, 100674015);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
