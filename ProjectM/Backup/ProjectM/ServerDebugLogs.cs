// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerDebugLogs
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServerDebugLogs
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LogCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_WarningCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_ErrorCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExceptionCount;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Public_Static_ServerDebugLogs_ComponentSystemBase_0;
    [FieldOffset(0)]
    public int LogCount;
    [FieldOffset(4)]
    public int WarningCount;
    [FieldOffset(8)]
    public int ErrorCount;
    [FieldOffset(12)]
    public int ExceptionCount;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 850239, RefRangeEnd = 850242, XrefRangeStart = 850239, XrefRangeEnd = 850242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerDebugLogs.NativeMethodInfoPtr_Initialize_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1050207, RefRangeEnd = 1050208, XrefRangeStart = 1050201, XrefRangeEnd = 1050207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ServerDebugLogs GetData(ComponentSystemBase systemBase)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerDebugLogs.NativeMethodInfoPtr_GetData_Public_Static_ServerDebugLogs_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ServerDebugLogs*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ServerDebugLogs()
    {
      Il2CppClassPointerStore<ServerDebugLogs>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServerDebugLogs));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerDebugLogs>.NativeClassPtr);
      ServerDebugLogs.NativeFieldInfoPtr_LogCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugLogs>.NativeClassPtr, nameof (LogCount));
      ServerDebugLogs.NativeFieldInfoPtr_WarningCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugLogs>.NativeClassPtr, nameof (WarningCount));
      ServerDebugLogs.NativeFieldInfoPtr_ErrorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugLogs>.NativeClassPtr, nameof (ErrorCount));
      ServerDebugLogs.NativeFieldInfoPtr_ExceptionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugLogs>.NativeClassPtr, nameof (ExceptionCount));
      ServerDebugLogs.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerDebugLogs>.NativeClassPtr, 100682445);
      ServerDebugLogs.NativeMethodInfoPtr_GetData_Public_Static_ServerDebugLogs_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerDebugLogs>.NativeClassPtr, 100682446);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerDebugLogs>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
