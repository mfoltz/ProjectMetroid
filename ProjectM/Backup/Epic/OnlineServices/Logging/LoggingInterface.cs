// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Logging.LoggingInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Epic.OnlineServices.Logging
{
  public sealed class LoggingInterface : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCallback_Public_Static_Result_LogMessageFunc_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetLogLevel_Public_Static_Result_LogCategory_LogLevel_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogMessageFuncInternalImplementation_Internal_Static_Void_byref_LogMessageInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 953692, RefRangeEnd = 953693, XrefRangeStart = 953676, XrefRangeEnd = 953692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Result SetCallback(LogMessageFunc callback)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LoggingInterface.NativeMethodInfoPtr_SetCallback_Public_Static_Result_LogMessageFunc_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 953694, RefRangeEnd = 953695, XrefRangeStart = 953693, XrefRangeEnd = 953694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Result SetLogLevel(LogCategory logCategory, LogLevel logLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &logCategory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &logLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LoggingInterface.NativeMethodInfoPtr_SetLogLevel_Public_Static_Result_LogCategory_LogLevel_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953695, XrefRangeEnd = 953709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void LogMessageFuncInternalImplementation(ref LogMessageInternal message)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref message;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoggingInterface.NativeMethodInfoPtr_LogMessageFuncInternalImplementation_Internal_Static_Void_byref_LogMessageInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LoggingInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoggingInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoggingInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LoggingInterface()
    {
      Il2CppClassPointerStore<LoggingInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Logging", nameof (LoggingInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoggingInterface>.NativeClassPtr);
      LoggingInterface.NativeMethodInfoPtr_SetCallback_Public_Static_Result_LogMessageFunc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggingInterface>.NativeClassPtr, 100669579);
      LoggingInterface.NativeMethodInfoPtr_SetLogLevel_Public_Static_Result_LogCategory_LogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggingInterface>.NativeClassPtr, 100669580);
      LoggingInterface.NativeMethodInfoPtr_LogMessageFuncInternalImplementation_Internal_Static_Void_byref_LogMessageInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggingInterface>.NativeClassPtr, 100669581);
      LoggingInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggingInterface>.NativeClassPtr, 100669582);
    }

    public LoggingInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
