// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogEventOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LogEventOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_EventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ParamsCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Params;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Params_Public_set_Void_Il2CppReferenceArray_1_LogEventParamPair_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogEventOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogEventOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_ClientHandle;
    [FieldOffset(16)]
    public uint m_EventId;
    [FieldOffset(20)]
    public uint m_ParamsCount;
    [FieldOffset(24)]
    public System.IntPtr m_Params;

    public unsafe System.IntPtr ClientHandle
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint EventId
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventOptionsInternal.NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<LogEventParamPair> Params
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 969423, RefRangeEnd = 969425, XrefRangeStart = 969417, XrefRangeEnd = 969423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventOptionsInternal.NativeMethodInfoPtr_set_Params_Public_set_Void_Il2CppReferenceArray_1_LogEventParamPair_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 969426, RefRangeEnd = 969427, XrefRangeStart = 969425, XrefRangeEnd = 969426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref LogEventOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogEventOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogEventOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969427, XrefRangeEnd = 969436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<LogEventOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogEventOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogEventOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969436, XrefRangeEnd = 969441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogEventOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LogEventOptionsInternal()
    {
      Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogEventOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr);
      LogEventOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      LogEventOptionsInternal.NativeFieldInfoPtr_m_ClientHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, nameof (m_ClientHandle));
      LogEventOptionsInternal.NativeFieldInfoPtr_m_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, nameof (m_EventId));
      LogEventOptionsInternal.NativeFieldInfoPtr_m_ParamsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, nameof (m_ParamsCount));
      LogEventOptionsInternal.NativeFieldInfoPtr_m_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, nameof (m_Params));
      LogEventOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, 100673932);
      LogEventOptionsInternal.NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, 100673933);
      LogEventOptionsInternal.NativeMethodInfoPtr_set_Params_Public_set_Void_Il2CppReferenceArray_1_LogEventParamPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, 100673934);
      LogEventOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogEventOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, 100673935);
      LogEventOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogEventOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, 100673936);
      LogEventOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, 100673937);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
