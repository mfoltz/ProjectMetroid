// Decompiled with JetBrains decompiler
// Type: ProjectM.LogCatcher
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.IO;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public static class LogCatcher : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerStarted;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientStarted;
    private static readonly System.IntPtr NativeFieldInfoPtr__FirstError;
    private static readonly System.IntPtr NativeFieldInfoPtr__Data;
    private static readonly System.IntPtr NativeFieldInfoPtr__LogFile;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrevLogLine;
    private static readonly System.IntPtr NativeFieldInfoPtr__RepeatCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrevHour;
    private static readonly System.IntPtr NativeFieldInfoPtr__Options;
    private static readonly System.IntPtr NativeFieldInfoPtr_CUSTOM_LOG_NAME;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Data_Public_Static_get_LogData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Options_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQuit_Private_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetLog_Private_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLogMessageReceived_Private_Static_Void_String_String_LogType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ServerStarted_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClientStarted_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Started_Private_Static_Void_0;

    public static unsafe LogCatcher.LogData Data
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720501, XrefRangeEnd = 720505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogCatcher.NativeMethodInfoPtr_get_Data_Public_Static_get_LogData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LogCatcher.LogData*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 720605, RefRangeEnd = 720606, XrefRangeStart = 720505, XrefRangeEnd = 720605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Initialize(LogCatcher.Options options, string customLogName = "custom")
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(customLogName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogCatcher.NativeMethodInfoPtr_Initialize_Public_Static_Void_Options_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720606, XrefRangeEnd = 720610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQuit()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogCatcher.NativeMethodInfoPtr_OnQuit_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 720619, RefRangeEnd = 720620, XrefRangeStart = 720610, XrefRangeEnd = 720619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Reset()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogCatcher.NativeMethodInfoPtr_Reset_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 720635, RefRangeEnd = 720638, XrefRangeStart = 720620, XrefRangeEnd = 720635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ResetLog()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogCatcher.NativeMethodInfoPtr_ResetLog_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720638, XrefRangeEnd = 720739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnLogMessageReceived(string logLine, string stackTrace, LogType type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(logLine);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogCatcher.NativeMethodInfoPtr_OnLogMessageReceived_Private_Static_Void_String_String_LogType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 720750, RefRangeEnd = 720751, XrefRangeStart = 720739, XrefRangeEnd = 720750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ServerStarted()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogCatcher.NativeMethodInfoPtr_ServerStarted_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 720762, RefRangeEnd = 720763, XrefRangeStart = 720751, XrefRangeEnd = 720762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ClientStarted()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogCatcher.NativeMethodInfoPtr_ClientStarted_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720763, XrefRangeEnd = 720770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Started()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogCatcher.NativeMethodInfoPtr_Started_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LogCatcher()
    {
      Il2CppClassPointerStore<LogCatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (LogCatcher));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr);
      LogCatcher.NativeFieldInfoPtr__ServerStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, nameof (_ServerStarted));
      LogCatcher.NativeFieldInfoPtr__ClientStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, nameof (_ClientStarted));
      LogCatcher.NativeFieldInfoPtr__FirstError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, nameof (_FirstError));
      LogCatcher.NativeFieldInfoPtr__Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, nameof (_Data));
      LogCatcher.NativeFieldInfoPtr__LogFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, nameof (_LogFile));
      LogCatcher.NativeFieldInfoPtr__PrevLogLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, nameof (_PrevLogLine));
      LogCatcher.NativeFieldInfoPtr__RepeatCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, nameof (_RepeatCounter));
      LogCatcher.NativeFieldInfoPtr__PrevHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, nameof (_PrevHour));
      LogCatcher.NativeFieldInfoPtr__Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, nameof (_Options));
      LogCatcher.NativeFieldInfoPtr_CUSTOM_LOG_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, nameof (CUSTOM_LOG_NAME));
      LogCatcher.NativeMethodInfoPtr_get_Data_Public_Static_get_LogData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, 100663674);
      LogCatcher.NativeMethodInfoPtr_Initialize_Public_Static_Void_Options_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, 100663675);
      LogCatcher.NativeMethodInfoPtr_OnQuit_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, 100663676);
      LogCatcher.NativeMethodInfoPtr_Reset_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, 100663677);
      LogCatcher.NativeMethodInfoPtr_ResetLog_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, 100663678);
      LogCatcher.NativeMethodInfoPtr_OnLogMessageReceived_Private_Static_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, 100663679);
      LogCatcher.NativeMethodInfoPtr_ServerStarted_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, 100663680);
      LogCatcher.NativeMethodInfoPtr_ClientStarted_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, 100663681);
      LogCatcher.NativeMethodInfoPtr_Started_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, 100663682);
    }

    public LogCatcher(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe bool _ServerStarted
    {
      get
      {
        bool serverStarted;
        IL2CPP.il2cpp_field_static_get_value(LogCatcher.NativeFieldInfoPtr__ServerStarted, (void*) &serverStarted);
        return serverStarted;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LogCatcher.NativeFieldInfoPtr__ServerStarted, (void*) &value);
      }
    }

    public static unsafe bool _ClientStarted
    {
      get
      {
        bool clientStarted;
        IL2CPP.il2cpp_field_static_get_value(LogCatcher.NativeFieldInfoPtr__ClientStarted, (void*) &clientStarted);
        return clientStarted;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LogCatcher.NativeFieldInfoPtr__ClientStarted, (void*) &value);
      }
    }

    public static unsafe string _FirstError
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(LogCatcher.NativeFieldInfoPtr__FirstError, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LogCatcher.NativeFieldInfoPtr__FirstError, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe LogCatcher.LogData _Data
    {
      get
      {
        LogCatcher.LogData data;
        IL2CPP.il2cpp_field_static_get_value(LogCatcher.NativeFieldInfoPtr__Data, (void*) &data);
        return data;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LogCatcher.NativeFieldInfoPtr__Data, (void*) &value);
      }
    }

    public static unsafe StreamWriter _LogFile
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(LogCatcher.NativeFieldInfoPtr__LogFile, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (StreamWriter) null : new StreamWriter(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LogCatcher.NativeFieldInfoPtr__LogFile, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe string _PrevLogLine
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(LogCatcher.NativeFieldInfoPtr__PrevLogLine, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LogCatcher.NativeFieldInfoPtr__PrevLogLine, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe int _RepeatCounter
    {
      get
      {
        int repeatCounter;
        IL2CPP.il2cpp_field_static_get_value(LogCatcher.NativeFieldInfoPtr__RepeatCounter, (void*) &repeatCounter);
        return repeatCounter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LogCatcher.NativeFieldInfoPtr__RepeatCounter, (void*) &value);
      }
    }

    public static unsafe int _PrevHour
    {
      get
      {
        int prevHour;
        IL2CPP.il2cpp_field_static_get_value(LogCatcher.NativeFieldInfoPtr__PrevHour, (void*) &prevHour);
        return prevHour;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LogCatcher.NativeFieldInfoPtr__PrevHour, (void*) &value);
      }
    }

    public static unsafe LogCatcher.Options _Options
    {
      get
      {
        LogCatcher.Options options;
        IL2CPP.il2cpp_field_static_get_value(LogCatcher.NativeFieldInfoPtr__Options, (void*) &options);
        return options;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LogCatcher.NativeFieldInfoPtr__Options, (void*) &value);
      }
    }

    public static unsafe string CUSTOM_LOG_NAME
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(LogCatcher.NativeFieldInfoPtr_CUSTOM_LOG_NAME, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LogCatcher.NativeFieldInfoPtr_CUSTOM_LOG_NAME, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LogData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_LogCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_WarningCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_ErrorCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_ExceptionCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_AssertCount;
      [FieldOffset(0)]
      public int LogCount;
      [FieldOffset(4)]
      public int WarningCount;
      [FieldOffset(8)]
      public int ErrorCount;
      [FieldOffset(12)]
      public int ExceptionCount;
      [FieldOffset(16)]
      public int AssertCount;

      static LogData()
      {
        Il2CppClassPointerStore<LogCatcher.LogData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LogCatcher>.NativeClassPtr, nameof (LogData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogCatcher.LogData>.NativeClassPtr);
        LogCatcher.LogData.NativeFieldInfoPtr_LogCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogCatcher.LogData>.NativeClassPtr, nameof (LogCount));
        LogCatcher.LogData.NativeFieldInfoPtr_WarningCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogCatcher.LogData>.NativeClassPtr, nameof (WarningCount));
        LogCatcher.LogData.NativeFieldInfoPtr_ErrorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogCatcher.LogData>.NativeClassPtr, nameof (ErrorCount));
        LogCatcher.LogData.NativeFieldInfoPtr_ExceptionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogCatcher.LogData>.NativeClassPtr, nameof (ExceptionCount));
        LogCatcher.LogData.NativeFieldInfoPtr_AssertCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogCatcher.LogData>.NativeClassPtr, nameof (AssertCount));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogCatcher.LogData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [Flags]
    public enum Options
    {
      None = 0,
      UseCustomLog = 1,
      MergeRepeates = 2,
      PrintStackTraces = 4,
      FlushEachLog = 8,
      All = 255, // 0x000000FF
    }
  }
}
