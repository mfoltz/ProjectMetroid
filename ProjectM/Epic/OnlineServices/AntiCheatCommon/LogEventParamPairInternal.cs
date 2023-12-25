// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogEventParamPairInternal
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
  public struct LogEventParamPairInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ParamValue;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ParamValue_Public_get_LogEventParamPairParamValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ParamValue_Public_set_Void_LogEventParamPairParamValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogEventParamPair_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogEventParamPair_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LogEventParamPair_0;
    [FieldOffset(0)]
    public LogEventParamPairParamValueInternal m_ParamValue;

    public unsafe LogEventParamPairParamValue ParamValue
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969450, XrefRangeEnd = 969456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairInternal.NativeMethodInfoPtr_get_ParamValue_Public_get_LogEventParamPairParamValue_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new LogEventParamPairParamValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969456, XrefRangeEnd = 969462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventParamPairInternal.NativeMethodInfoPtr_set_ParamValue_Public_set_Void_LogEventParamPairParamValue_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969462, XrefRangeEnd = 969468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref LogEventParamPair other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogEventParamPair_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969468, XrefRangeEnd = 969478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<LogEventParamPair> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogEventParamPair_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969478, XrefRangeEnd = 969484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969484, XrefRangeEnd = 969485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out LogEventParamPair output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LogEventParamPair_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref LogEventParamPair local = ref output;
      System.IntPtr pointer = zero;
      LogEventParamPair logEventParamPair = pointer == System.IntPtr.Zero ? (LogEventParamPair) null : new LogEventParamPair(pointer);
      local = logEventParamPair;
    }

    static LogEventParamPairInternal()
    {
      Il2CppClassPointerStore<LogEventParamPairInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogEventParamPairInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogEventParamPairInternal>.NativeClassPtr);
      LogEventParamPairInternal.NativeFieldInfoPtr_m_ParamValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairInternal>.NativeClassPtr, nameof (m_ParamValue));
      LogEventParamPairInternal.NativeMethodInfoPtr_get_ParamValue_Public_get_LogEventParamPairParamValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairInternal>.NativeClassPtr, 100673941);
      LogEventParamPairInternal.NativeMethodInfoPtr_set_ParamValue_Public_set_Void_LogEventParamPairParamValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairInternal>.NativeClassPtr, 100673942);
      LogEventParamPairInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogEventParamPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairInternal>.NativeClassPtr, 100673943);
      LogEventParamPairInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogEventParamPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairInternal>.NativeClassPtr, 100673944);
      LogEventParamPairInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairInternal>.NativeClassPtr, 100673945);
      LogEventParamPairInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LogEventParamPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairInternal>.NativeClassPtr, 100673946);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogEventParamPairInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
