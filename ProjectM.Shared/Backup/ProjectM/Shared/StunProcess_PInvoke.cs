// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.StunProcess_PInvoke
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  public class StunProcess_PInvoke : StunProcess
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_INFINITE;
    private static readonly System.IntPtr NativeFieldInfoPtr_WAIT_ABANDONED;
    private static readonly System.IntPtr NativeFieldInfoPtr_WAIT_OBJECT_0;
    private static readonly System.IntPtr NativeFieldInfoPtr_WAIT_TIMEOUT;
    private static readonly System.IntPtr NativeFieldInfoPtr__StdInWritePipeHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr__StdInReadPipeHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr__ProcessID;
    private static readonly System.IntPtr NativeFieldInfoPtr__ProcessHandle;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateProcessW_Private_Static_Boolean_String_String_IntPtr_IntPtr_Boolean_ProcessCreationFlags_IntPtr_String_byref_STARTUPINFO_byref_PROCESS_INFORMATION_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CloseHandle_Private_Static_Boolean_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TerminateProcess_Private_Static_Boolean_IntPtr_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OpenProcess_Private_Static_IntPtr_ProcessAccessRights_Boolean_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetExitCodeProcess_Private_Static_Boolean_IntPtr_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WaitForSingleObject_Private_Static_UInt32_IntPtr_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreatePipe_Private_Static_Boolean_byref_IntPtr_byref_IntPtr_byref_SECURITY_ATTRIBUTES_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHandleInformation_Private_Static_Boolean_IntPtr_HANDLE_FLAGS_HANDLE_FLAGS_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteFile_Private_Static_Boolean_IntPtr_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ProcessId_Public_Virtual_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_UInt32_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_String_String_String_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetProcessHandle_Private_Static_IntPtr_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasProcessExited_Public_Virtual_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_KillProcess_Public_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WaitForExit_Public_Virtual_Boolean_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteLineStdIn_Public_Virtual_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetProcessById_Public_Static_StunProcess_UInt32_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803330, XrefRangeEnd = 803333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CreateProcessW(
      string lpApplicationName,
      [In] string lpCommandLine,
      System.IntPtr procSecAttrs,
      System.IntPtr threadSecAttrs,
      bool bInheritHandles,
      StunProcess_PInvoke.ProcessCreationFlags dwCreationFlags,
      System.IntPtr lpEnvironment,
      string lpCurrentDirectory,
      ref StunProcess_PInvoke.STARTUPINFO lpStartupInfo,
      ref StunProcess_PInvoke.PROCESS_INFORMATION lpProcessInformation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(lpApplicationName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(lpCommandLine);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &procSecAttrs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &threadSecAttrs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &bInheritHandles;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &dwCreationFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &lpEnvironment;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(lpCurrentDirectory);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref lpStartupInfo;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref lpProcessInformation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunProcess_PInvoke.NativeMethodInfoPtr_CreateProcessW_Private_Static_Boolean_String_String_IntPtr_IntPtr_Boolean_ProcessCreationFlags_IntPtr_String_byref_STARTUPINFO_byref_PROCESS_INFORMATION_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 803336, RefRangeEnd = 803340, XrefRangeStart = 803333, XrefRangeEnd = 803336, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CloseHandle(System.IntPtr hObject)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &hObject;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunProcess_PInvoke.NativeMethodInfoPtr_CloseHandle_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803340, XrefRangeEnd = 803343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TerminateProcess(System.IntPtr processHandle, uint exitCode)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &processHandle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &exitCode;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunProcess_PInvoke.NativeMethodInfoPtr_TerminateProcess_Private_Static_Boolean_IntPtr_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803343, XrefRangeEnd = 803346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe System.IntPtr OpenProcess(
      StunProcess_PInvoke.ProcessAccessRights access,
      bool inherit,
      uint processId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &access;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inherit;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &processId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunProcess_PInvoke.NativeMethodInfoPtr_OpenProcess_Private_Static_IntPtr_ProcessAccessRights_Boolean_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803346, XrefRangeEnd = 803349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetExitCodeProcess(System.IntPtr hProcess, out uint lpExitCode)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &hProcess;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lpExitCode;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunProcess_PInvoke.NativeMethodInfoPtr_GetExitCodeProcess_Private_Static_Boolean_IntPtr_byref_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803349, XrefRangeEnd = 803352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe uint WaitForSingleObject(System.IntPtr hHandle, uint dwMilliseconds)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &hHandle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dwMilliseconds;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunProcess_PInvoke.NativeMethodInfoPtr_WaitForSingleObject_Private_Static_UInt32_IntPtr_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803352, XrefRangeEnd = 803357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CreatePipe(
      out System.IntPtr hReadPipe,
      out System.IntPtr hWritePipe,
      ref StunProcess_PInvoke.SECURITY_ATTRIBUTES lpPipeAttributes,
      uint nSize)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref hReadPipe;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hWritePipe;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref lpPipeAttributes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nSize;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunProcess_PInvoke.NativeMethodInfoPtr_CreatePipe_Private_Static_Boolean_byref_IntPtr_byref_IntPtr_byref_SECURITY_ATTRIBUTES_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803357, XrefRangeEnd = 803360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool SetHandleInformation(
      System.IntPtr hObject,
      StunProcess_PInvoke.HANDLE_FLAGS dwMask,
      StunProcess_PInvoke.HANDLE_FLAGS dwFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &hObject;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dwMask;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dwFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunProcess_PInvoke.NativeMethodInfoPtr_SetHandleInformation_Private_Static_Boolean_IntPtr_HANDLE_FLAGS_HANDLE_FLAGS_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803360, XrefRangeEnd = 803363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool WriteFile(
      System.IntPtr hFile,
      Il2CppStructArray<byte> lpBuffer,
      uint nNumberOfBytesToWrite,
      out uint lpNumberOfBytesWritten,
      System.IntPtr lpOverlapped)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &hFile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lpBuffer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &nNumberOfBytesToWrite;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref lpNumberOfBytesWritten;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &lpOverlapped;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunProcess_PInvoke.NativeMethodInfoPtr_WriteFile_Private_Static_Boolean_IntPtr_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public override unsafe uint ProcessId
    {
      [CallerCount(36), CachedScanResults(RefRangeStart = 29682, RefRangeEnd = 29718, XrefRangeStart = 29682, XrefRangeEnd = 29718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess_PInvoke.NativeMethodInfoPtr_get_ProcessId_Public_Virtual_get_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunProcess_PInvoke()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunProcess_PInvoke.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803363, XrefRangeEnd = 803364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunProcess_PInvoke(uint processId, System.IntPtr processHandle)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &processId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &processHandle;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunProcess_PInvoke.NativeMethodInfoPtr__ctor_Private_Void_UInt32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803364, XrefRangeEnd = 803390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Start(
      string fileName,
      string arguments,
      string dir,
      bool hidden,
      bool redirectStandardInput)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fileName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(arguments);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(dir);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &hidden;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &redirectStandardInput;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess_PInvoke.NativeMethodInfoPtr_Start_Public_Virtual_Void_String_String_String_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803390, XrefRangeEnd = 803393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe System.IntPtr GetProcessHandle(uint processID)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &processID;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunProcess_PInvoke.NativeMethodInfoPtr_GetProcessHandle_Private_Static_IntPtr_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803393, XrefRangeEnd = 803396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasProcessExited()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess_PInvoke.NativeMethodInfoPtr_HasProcessExited_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803396, XrefRangeEnd = 803402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void KillProcess()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess_PInvoke.NativeMethodInfoPtr_KillProcess_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803402, XrefRangeEnd = 803407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool WaitForExit(uint waitMilliseconds)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &waitMilliseconds;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess_PInvoke.NativeMethodInfoPtr_WaitForExit_Public_Virtual_Boolean_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803407, XrefRangeEnd = 803416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void WriteLineStdIn(string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess_PInvoke.NativeMethodInfoPtr_WriteLineStdIn_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803416, XrefRangeEnd = 803453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess_PInvoke.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new static unsafe StunProcess GetProcessById(uint processId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &processId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunProcess_PInvoke.NativeMethodInfoPtr_GetProcessById_Public_Static_StunProcess_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (StunProcess) null : new StunProcess(pointer);
    }

    static StunProcess_PInvoke()
    {
      Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (StunProcess_PInvoke));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr);
      StunProcess_PInvoke.NativeFieldInfoPtr_INFINITE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, nameof (INFINITE));
      StunProcess_PInvoke.NativeFieldInfoPtr_WAIT_ABANDONED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, nameof (WAIT_ABANDONED));
      StunProcess_PInvoke.NativeFieldInfoPtr_WAIT_OBJECT_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, nameof (WAIT_OBJECT_0));
      StunProcess_PInvoke.NativeFieldInfoPtr_WAIT_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, nameof (WAIT_TIMEOUT));
      StunProcess_PInvoke.NativeFieldInfoPtr__StdInWritePipeHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, nameof (_StdInWritePipeHandle));
      StunProcess_PInvoke.NativeFieldInfoPtr__StdInReadPipeHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, nameof (_StdInReadPipeHandle));
      StunProcess_PInvoke.NativeFieldInfoPtr__ProcessID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, nameof (_ProcessID));
      StunProcess_PInvoke.NativeFieldInfoPtr__ProcessHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, nameof (_ProcessHandle));
      StunProcess_PInvoke.NativeMethodInfoPtr_CreateProcessW_Private_Static_Boolean_String_String_IntPtr_IntPtr_Boolean_ProcessCreationFlags_IntPtr_String_byref_STARTUPINFO_byref_PROCESS_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670829);
      StunProcess_PInvoke.NativeMethodInfoPtr_CloseHandle_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670830);
      StunProcess_PInvoke.NativeMethodInfoPtr_TerminateProcess_Private_Static_Boolean_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670831);
      StunProcess_PInvoke.NativeMethodInfoPtr_OpenProcess_Private_Static_IntPtr_ProcessAccessRights_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670832);
      StunProcess_PInvoke.NativeMethodInfoPtr_GetExitCodeProcess_Private_Static_Boolean_IntPtr_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670833);
      StunProcess_PInvoke.NativeMethodInfoPtr_WaitForSingleObject_Private_Static_UInt32_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670834);
      StunProcess_PInvoke.NativeMethodInfoPtr_CreatePipe_Private_Static_Boolean_byref_IntPtr_byref_IntPtr_byref_SECURITY_ATTRIBUTES_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670835);
      StunProcess_PInvoke.NativeMethodInfoPtr_SetHandleInformation_Private_Static_Boolean_IntPtr_HANDLE_FLAGS_HANDLE_FLAGS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670836);
      StunProcess_PInvoke.NativeMethodInfoPtr_WriteFile_Private_Static_Boolean_IntPtr_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670837);
      StunProcess_PInvoke.NativeMethodInfoPtr_get_ProcessId_Public_Virtual_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670838);
      StunProcess_PInvoke.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670839);
      StunProcess_PInvoke.NativeMethodInfoPtr__ctor_Private_Void_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670840);
      StunProcess_PInvoke.NativeMethodInfoPtr_Start_Public_Virtual_Void_String_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670841);
      StunProcess_PInvoke.NativeMethodInfoPtr_GetProcessHandle_Private_Static_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670842);
      StunProcess_PInvoke.NativeMethodInfoPtr_HasProcessExited_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670843);
      StunProcess_PInvoke.NativeMethodInfoPtr_KillProcess_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670844);
      StunProcess_PInvoke.NativeMethodInfoPtr_WaitForExit_Public_Virtual_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670845);
      StunProcess_PInvoke.NativeMethodInfoPtr_WriteLineStdIn_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670846);
      StunProcess_PInvoke.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670847);
      StunProcess_PInvoke.NativeMethodInfoPtr_GetProcessById_Public_Static_StunProcess_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, 100670848);
    }

    public StunProcess_PInvoke(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe uint INFINITE
    {
      get
      {
        uint infinite;
        IL2CPP.il2cpp_field_static_get_value(StunProcess_PInvoke.NativeFieldInfoPtr_INFINITE, (void*) &infinite);
        return infinite;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunProcess_PInvoke.NativeFieldInfoPtr_INFINITE, (void*) &value);
      }
    }

    public static unsafe uint WAIT_ABANDONED
    {
      get
      {
        uint waitAbandoned;
        IL2CPP.il2cpp_field_static_get_value(StunProcess_PInvoke.NativeFieldInfoPtr_WAIT_ABANDONED, (void*) &waitAbandoned);
        return waitAbandoned;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunProcess_PInvoke.NativeFieldInfoPtr_WAIT_ABANDONED, (void*) &value);
      }
    }

    public static unsafe uint WAIT_OBJECT_0
    {
      get
      {
        uint waitObject0;
        IL2CPP.il2cpp_field_static_get_value(StunProcess_PInvoke.NativeFieldInfoPtr_WAIT_OBJECT_0, (void*) &waitObject0);
        return waitObject0;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunProcess_PInvoke.NativeFieldInfoPtr_WAIT_OBJECT_0, (void*) &value);
      }
    }

    public static unsafe uint WAIT_TIMEOUT
    {
      get
      {
        uint waitTimeout;
        IL2CPP.il2cpp_field_static_get_value(StunProcess_PInvoke.NativeFieldInfoPtr_WAIT_TIMEOUT, (void*) &waitTimeout);
        return waitTimeout;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StunProcess_PInvoke.NativeFieldInfoPtr_WAIT_TIMEOUT, (void*) &value);
      }
    }

    public unsafe System.IntPtr _StdInWritePipeHandle
    {
      get
      {
        return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.NativeFieldInfoPtr__StdInWritePipeHandle));
      }
      [param: In] set
      {
        *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.NativeFieldInfoPtr__StdInWritePipeHandle)) = value;
      }
    }

    public unsafe System.IntPtr _StdInReadPipeHandle
    {
      get
      {
        return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.NativeFieldInfoPtr__StdInReadPipeHandle));
      }
      [param: In] set
      {
        *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.NativeFieldInfoPtr__StdInReadPipeHandle)) = value;
      }
    }

    public unsafe uint _ProcessID
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.NativeFieldInfoPtr__ProcessID));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.NativeFieldInfoPtr__ProcessID)) = value;
      }
    }

    public unsafe System.IntPtr _ProcessHandle
    {
      get
      {
        return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.NativeFieldInfoPtr__ProcessHandle));
      }
      [param: In] set
      {
        *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.NativeFieldInfoPtr__ProcessHandle)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SECURITY_ATTRIBUTES
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_nLength;
      private static readonly System.IntPtr NativeFieldInfoPtr_lpSecurityDescriptor;
      private static readonly System.IntPtr NativeFieldInfoPtr_bInheritHandle;
      [FieldOffset(0)]
      public int nLength;
      [FieldOffset(8)]
      public System.IntPtr lpSecurityDescriptor;
      [FieldOffset(16)]
      public bool bInheritHandle;

      static SECURITY_ATTRIBUTES()
      {
        Il2CppClassPointerStore<StunProcess_PInvoke.SECURITY_ATTRIBUTES>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, nameof (SECURITY_ATTRIBUTES));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunProcess_PInvoke.SECURITY_ATTRIBUTES>.NativeClassPtr);
        StunProcess_PInvoke.SECURITY_ATTRIBUTES.NativeFieldInfoPtr_nLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.SECURITY_ATTRIBUTES>.NativeClassPtr, nameof (nLength));
        StunProcess_PInvoke.SECURITY_ATTRIBUTES.NativeFieldInfoPtr_lpSecurityDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.SECURITY_ATTRIBUTES>.NativeClassPtr, nameof (lpSecurityDescriptor));
        StunProcess_PInvoke.SECURITY_ATTRIBUTES.NativeFieldInfoPtr_bInheritHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.SECURITY_ATTRIBUTES>.NativeClassPtr, nameof (bInheritHandle));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StunProcess_PInvoke.SECURITY_ATTRIBUTES>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [Flags]
    public enum HANDLE_FLAGS : uint
    {
      None = 0,
      INHERIT = 1,
      PROTECT_FROM_CLOSE = 2,
    }

    [Flags]
    public enum ProcessAccessRights : uint
    {
      PROCESS_CREATE_PROCESS = 128, // 0x00000080
      PROCESS_CREATE_THREAD = 2,
      PROCESS_DUP_HANDLE = 64, // 0x00000040
      PROCESS_QUERY_INFORMATION = 1024, // 0x00000400
      PROCESS_QUERY_LIMITED_INFORMATION = 4096, // 0x00001000
      PROCESS_SET_INFORMATION = 512, // 0x00000200
      PROCESS_SET_QUOTA = 256, // 0x00000100
      PROCESS_SUSPEND_RESUME = 2048, // 0x00000800
      PROCESS_TERMINATE = 1,
      PROCESS_VM_OPERATION = 8,
      PROCESS_VM_READ = 16, // 0x00000010
      PROCESS_VM_WRITE = 32, // 0x00000020
      DELETE = 65536, // 0x00010000
      READ_CONTROL = 131072, // 0x00020000
      SYNCHRONIZE = 1048576, // 0x00100000
      WRITE_DAC = 262144, // 0x00040000
      WRITE_OWNER = 524288, // 0x00080000
      STANDARD_RIGHTS_REQUIRED = WRITE_OWNER | WRITE_DAC | READ_CONTROL | DELETE, // 0x000F0000
      PROCESS_ALL_ACCESS = 2035711, // 0x001F0FFF
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct PROCESS_INFORMATION
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hProcess;
      private static readonly System.IntPtr NativeFieldInfoPtr_hThread;
      private static readonly System.IntPtr NativeFieldInfoPtr_dwProcessId;
      private static readonly System.IntPtr NativeFieldInfoPtr_dwThreadId;
      [FieldOffset(0)]
      public System.IntPtr hProcess;
      [FieldOffset(8)]
      public System.IntPtr hThread;
      [FieldOffset(16)]
      public uint dwProcessId;
      [FieldOffset(20)]
      public uint dwThreadId;

      static PROCESS_INFORMATION()
      {
        Il2CppClassPointerStore<StunProcess_PInvoke.PROCESS_INFORMATION>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, nameof (PROCESS_INFORMATION));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunProcess_PInvoke.PROCESS_INFORMATION>.NativeClassPtr);
        StunProcess_PInvoke.PROCESS_INFORMATION.NativeFieldInfoPtr_hProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.PROCESS_INFORMATION>.NativeClassPtr, nameof (hProcess));
        StunProcess_PInvoke.PROCESS_INFORMATION.NativeFieldInfoPtr_hThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.PROCESS_INFORMATION>.NativeClassPtr, nameof (hThread));
        StunProcess_PInvoke.PROCESS_INFORMATION.NativeFieldInfoPtr_dwProcessId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.PROCESS_INFORMATION>.NativeClassPtr, nameof (dwProcessId));
        StunProcess_PInvoke.PROCESS_INFORMATION.NativeFieldInfoPtr_dwThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.PROCESS_INFORMATION>.NativeClassPtr, nameof (dwThreadId));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StunProcess_PInvoke.PROCESS_INFORMATION>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct STARTUPINFO
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_cb;
      private static readonly System.IntPtr NativeFieldInfoPtr_lpReserved;
      private static readonly System.IntPtr NativeFieldInfoPtr_lpDesktop;
      private static readonly System.IntPtr NativeFieldInfoPtr_lpTitle;
      private static readonly System.IntPtr NativeFieldInfoPtr_dwX;
      private static readonly System.IntPtr NativeFieldInfoPtr_dwY;
      private static readonly System.IntPtr NativeFieldInfoPtr_dwXSize;
      private static readonly System.IntPtr NativeFieldInfoPtr_dwYSize;
      private static readonly System.IntPtr NativeFieldInfoPtr_dwXCountChars;
      private static readonly System.IntPtr NativeFieldInfoPtr_dwYCountChars;
      private static readonly System.IntPtr NativeFieldInfoPtr_dwFillAttribute;
      private static readonly System.IntPtr NativeFieldInfoPtr_dwFlags;
      private static readonly System.IntPtr NativeFieldInfoPtr_wShowWindow;
      private static readonly System.IntPtr NativeFieldInfoPtr_cbReserved2;
      private static readonly System.IntPtr NativeFieldInfoPtr_lpReserved2;
      private static readonly System.IntPtr NativeFieldInfoPtr_hStdInput;
      private static readonly System.IntPtr NativeFieldInfoPtr_hStdOutput;
      private static readonly System.IntPtr NativeFieldInfoPtr_hStdError;
      [FieldOffset(0)]
      public uint cb;
      [FieldOffset(8)]
      public System.IntPtr lpReserved;
      [FieldOffset(16)]
      public System.IntPtr lpDesktop;
      [FieldOffset(24)]
      public System.IntPtr lpTitle;
      [FieldOffset(32)]
      public uint dwX;
      [FieldOffset(36)]
      public uint dwY;
      [FieldOffset(40)]
      public uint dwXSize;
      [FieldOffset(44)]
      public uint dwYSize;
      [FieldOffset(48)]
      public uint dwXCountChars;
      [FieldOffset(52)]
      public uint dwYCountChars;
      [FieldOffset(56)]
      public uint dwFillAttribute;
      [FieldOffset(60)]
      public uint dwFlags;
      [FieldOffset(64)]
      public ushort wShowWindow;
      [FieldOffset(66)]
      public ushort cbReserved2;
      [FieldOffset(72)]
      public System.IntPtr lpReserved2;
      [FieldOffset(80)]
      public System.IntPtr hStdInput;
      [FieldOffset(88)]
      public System.IntPtr hStdOutput;
      [FieldOffset(96)]
      public System.IntPtr hStdError;

      static STARTUPINFO()
      {
        Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, nameof (STARTUPINFO));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr);
        StunProcess_PInvoke.STARTUPINFO.NativeFieldInfoPtr_cb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr, nameof (cb));
        StunProcess_PInvoke.STARTUPINFO.NativeFieldInfoPtr_lpReserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr, nameof (lpReserved));
        StunProcess_PInvoke.STARTUPINFO.NativeFieldInfoPtr_lpDesktop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr, nameof (lpDesktop));
        StunProcess_PInvoke.STARTUPINFO.NativeFieldInfoPtr_lpTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr, nameof (lpTitle));
        StunProcess_PInvoke.STARTUPINFO.NativeFieldInfoPtr_dwX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr, nameof (dwX));
        StunProcess_PInvoke.STARTUPINFO.NativeFieldInfoPtr_dwY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr, nameof (dwY));
        StunProcess_PInvoke.STARTUPINFO.NativeFieldInfoPtr_dwXSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr, nameof (dwXSize));
        StunProcess_PInvoke.STARTUPINFO.NativeFieldInfoPtr_dwYSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr, nameof (dwYSize));
        StunProcess_PInvoke.STARTUPINFO.NativeFieldInfoPtr_dwXCountChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr, nameof (dwXCountChars));
        StunProcess_PInvoke.STARTUPINFO.NativeFieldInfoPtr_dwYCountChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr, nameof (dwYCountChars));
        StunProcess_PInvoke.STARTUPINFO.NativeFieldInfoPtr_dwFillAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr, nameof (dwFillAttribute));
        StunProcess_PInvoke.STARTUPINFO.NativeFieldInfoPtr_dwFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr, nameof (dwFlags));
        StunProcess_PInvoke.STARTUPINFO.NativeFieldInfoPtr_wShowWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr, nameof (wShowWindow));
        StunProcess_PInvoke.STARTUPINFO.NativeFieldInfoPtr_cbReserved2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr, nameof (cbReserved2));
        StunProcess_PInvoke.STARTUPINFO.NativeFieldInfoPtr_lpReserved2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr, nameof (lpReserved2));
        StunProcess_PInvoke.STARTUPINFO.NativeFieldInfoPtr_hStdInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr, nameof (hStdInput));
        StunProcess_PInvoke.STARTUPINFO.NativeFieldInfoPtr_hStdOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr, nameof (hStdOutput));
        StunProcess_PInvoke.STARTUPINFO.NativeFieldInfoPtr_hStdError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr, nameof (hStdError));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StunProcess_PInvoke.STARTUPINFO>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum ShowWindowOptions : ushort
    {
      SW_HIDE = 0,
      SW_SHOWNORMAL = 1,
      SW_SHOWMINIMIZED = 2,
      SW_MAXIMIZE = 3,
      SW_SHOWMAXIMIZED = 3,
      SW_SHOWNOACTIVATE = 4,
      SW_SHOW = 5,
      SW_MINIMIZE = 6,
      SW_SHOWMINNOACTIVE = 7,
      SW_SHOWNA = 8,
      SW_RESTORE = 9,
      SW_SHOWDEFAULT = 10, // 0x000A
      SW_FORCEMINIMIZE = 11, // 0x000B
    }

    [Flags]
    public enum STARTF : uint
    {
      STARTF_USESHOWWINDOW = 1,
      STARTF_USESIZE = 2,
      STARTF_USEPOSITION = 4,
      STARTF_USECOUNTCHARS = 8,
      STARTF_USEFILLATTRIBUTE = 16, // 0x00000010
      STARTF_RUNFULLSCREEN = 32, // 0x00000020
      STARTF_FORCEONFEEDBACK = 64, // 0x00000040
      STARTF_FORCEOFFFEEDBACK = 128, // 0x00000080
      STARTF_USESTDHANDLES = 256, // 0x00000100
    }

    [Flags]
    public enum ProcessCreationFlags : uint
    {
      NONE = 0,
      CREATE_BREAKAWAY_FROM_JOB = 16777216, // 0x01000000
      CREATE_DEFAULT_ERROR_MODE = 67108864, // 0x04000000
      CREATE_NEW_CONSOLE = 16, // 0x00000010
      CREATE_NEW_PROCESS_GROUP = 512, // 0x00000200
      CREATE_NO_WINDOW = 134217728, // 0x08000000
      CREATE_PROTECTED_PROCESS = 262144, // 0x00040000
      CREATE_PRESERVE_CODE_AUTHZ_LEVEL = 33554432, // 0x02000000
      CREATE_SECURE_PROCESS = 4194304, // 0x00400000
      CREATE_SEPARATE_WOW_VDM = 2048, // 0x00000800
      CREATE_SHARED_WOW_VDM = 4096, // 0x00001000
      CREATE_SUSPENDED = 4,
      CREATE_UNICODE_ENVIRONMENT = 1024, // 0x00000400
      DEBUG_ONLY_THIS_PROCESS = 2,
      DEBUG_PROCESS = 1,
      DETACHED_PROCESS = 8,
      EXTENDED_STARTUPINFO_PRESENT = 524288, // 0x00080000
      INHERIT_PARENT_AFFINITY = 65536, // 0x00010000
    }

    [Flags]
    public enum SnapshotFlags : uint
    {
      HeapList = 1,
      Process = 2,
      Thread = 4,
      Module = 8,
      Module32 = 16, // 0x00000010
      All = Module | Thread | Process | HeapList, // 0x0000000F
      Inherit = 2147483648, // 0x80000000
      NoHeaps = 1073741824, // 0x40000000
    }

    public sealed class PROCESSENTRY32 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_dwSize;
      private static readonly System.IntPtr NativeFieldInfoPtr_cntUsage;
      private static readonly System.IntPtr NativeFieldInfoPtr_th32ProcessID;
      private static readonly System.IntPtr NativeFieldInfoPtr_th32DefaultHeapID;
      private static readonly System.IntPtr NativeFieldInfoPtr_th32ModuleID;
      private static readonly System.IntPtr NativeFieldInfoPtr_cntThreads;
      private static readonly System.IntPtr NativeFieldInfoPtr_th32ParentProcessID;
      private static readonly System.IntPtr NativeFieldInfoPtr_pcPriClassBase;
      private static readonly System.IntPtr NativeFieldInfoPtr_dwFlags;
      private static readonly System.IntPtr NativeFieldInfoPtr_szExeFile;

      static PROCESSENTRY32()
      {
        Il2CppClassPointerStore<StunProcess_PInvoke.PROCESSENTRY32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StunProcess_PInvoke>.NativeClassPtr, nameof (PROCESSENTRY32));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunProcess_PInvoke.PROCESSENTRY32>.NativeClassPtr);
        StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_dwSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.PROCESSENTRY32>.NativeClassPtr, nameof (dwSize));
        StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_cntUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.PROCESSENTRY32>.NativeClassPtr, nameof (cntUsage));
        StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_th32ProcessID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.PROCESSENTRY32>.NativeClassPtr, nameof (th32ProcessID));
        StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_th32DefaultHeapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.PROCESSENTRY32>.NativeClassPtr, nameof (th32DefaultHeapID));
        StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_th32ModuleID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.PROCESSENTRY32>.NativeClassPtr, nameof (th32ModuleID));
        StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_cntThreads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.PROCESSENTRY32>.NativeClassPtr, nameof (cntThreads));
        StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_th32ParentProcessID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.PROCESSENTRY32>.NativeClassPtr, nameof (th32ParentProcessID));
        StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_pcPriClassBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.PROCESSENTRY32>.NativeClassPtr, nameof (pcPriClassBase));
        StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_dwFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.PROCESSENTRY32>.NativeClassPtr, nameof (dwFlags));
        StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_szExeFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_PInvoke.PROCESSENTRY32>.NativeClassPtr, nameof (szExeFile));
      }

      public PROCESSENTRY32(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public PROCESSENTRY32()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StunProcess_PInvoke.PROCESSENTRY32>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StunProcess_PInvoke.PROCESSENTRY32>.NativeClassPtr, data));
      }

      public unsafe uint dwSize
      {
        get
        {
          return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_dwSize));
        }
        [param: In] set
        {
          *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_dwSize)) = value;
        }
      }

      public unsafe uint cntUsage
      {
        get
        {
          return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_cntUsage));
        }
        [param: In] set
        {
          *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_cntUsage)) = value;
        }
      }

      public unsafe uint th32ProcessID
      {
        get
        {
          return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_th32ProcessID));
        }
        [param: In] set
        {
          *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_th32ProcessID)) = value;
        }
      }

      public unsafe System.IntPtr th32DefaultHeapID
      {
        get
        {
          return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_th32DefaultHeapID));
        }
        [param: In] set
        {
          *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_th32DefaultHeapID)) = value;
        }
      }

      public unsafe uint th32ModuleID
      {
        get
        {
          return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_th32ModuleID));
        }
        [param: In] set
        {
          *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_th32ModuleID)) = value;
        }
      }

      public unsafe uint cntThreads
      {
        get
        {
          return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_cntThreads));
        }
        [param: In] set
        {
          *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_cntThreads)) = value;
        }
      }

      public unsafe uint th32ParentProcessID
      {
        get
        {
          return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_th32ParentProcessID));
        }
        [param: In] set
        {
          *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_th32ParentProcessID)) = value;
        }
      }

      public unsafe int pcPriClassBase
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_pcPriClassBase));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_pcPriClassBase)) = value;
        }
      }

      public unsafe uint dwFlags
      {
        get
        {
          return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_dwFlags));
        }
        [param: In] set
        {
          *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_dwFlags)) = value;
        }
      }

      public unsafe string szExeFile
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_szExeFile)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_PInvoke.PROCESSENTRY32.NativeFieldInfoPtr_szExeFile), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }
  }
}
