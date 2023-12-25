// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Logging.LogMessageInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Logging
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LogMessageInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Category;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Message;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Level;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Category_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Category_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Message_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Message_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Level_Public_get_LogLevel_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Level_Public_set_Void_LogLevel_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogMessage_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogMessage_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LogMessage_0;
    [FieldOffset(0)]
    public System.IntPtr m_Category;
    [FieldOffset(8)]
    public System.IntPtr m_Message;
    [FieldOffset(16)]
    public LogLevel m_Level;

    public unsafe Epic.OnlineServices.Utf8String Category
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953622, XrefRangeEnd = 953626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogMessageInternal.NativeMethodInfoPtr_get_Category_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953626, XrefRangeEnd = 953630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogMessageInternal.NativeMethodInfoPtr_set_Category_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Message
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953630, XrefRangeEnd = 953634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogMessageInternal.NativeMethodInfoPtr_get_Message_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953634, XrefRangeEnd = 953638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogMessageInternal.NativeMethodInfoPtr_set_Message_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe LogLevel Level
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 23501, RefRangeEnd = 23506, XrefRangeStart = 23501, XrefRangeEnd = 23506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogMessageInternal.NativeMethodInfoPtr_get_Level_Public_get_LogLevel_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LogLevel*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogMessageInternal.NativeMethodInfoPtr_set_Level_Public_set_Void_LogLevel_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953638, XrefRangeEnd = 953646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref LogMessage other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogMessageInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogMessage_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953646, XrefRangeEnd = 953662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<LogMessage> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogMessageInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogMessage_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953662, XrefRangeEnd = 953667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogMessageInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953667, XrefRangeEnd = 953668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out LogMessage output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogMessageInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LogMessage_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref LogMessage local = ref output;
      System.IntPtr pointer = zero;
      LogMessage logMessage = pointer == System.IntPtr.Zero ? (LogMessage) null : new LogMessage(pointer);
      local = logMessage;
    }

    static LogMessageInternal()
    {
      Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Logging", nameof (LogMessageInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr);
      LogMessageInternal.NativeFieldInfoPtr_m_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, nameof (m_Category));
      LogMessageInternal.NativeFieldInfoPtr_m_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, nameof (m_Message));
      LogMessageInternal.NativeFieldInfoPtr_m_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, nameof (m_Level));
      LogMessageInternal.NativeMethodInfoPtr_get_Category_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, 100669561);
      LogMessageInternal.NativeMethodInfoPtr_set_Category_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, 100669562);
      LogMessageInternal.NativeMethodInfoPtr_get_Message_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, 100669563);
      LogMessageInternal.NativeMethodInfoPtr_set_Message_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, 100669564);
      LogMessageInternal.NativeMethodInfoPtr_get_Level_Public_get_LogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, 100669565);
      LogMessageInternal.NativeMethodInfoPtr_set_Level_Public_set_Void_LogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, 100669566);
      LogMessageInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, 100669567);
      LogMessageInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, 100669568);
      LogMessageInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, 100669569);
      LogMessageInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LogMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, 100669570);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
