// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.StunProcess_MONO
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Diagnostics;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  public class StunProcess_MONO : StunProcess
  {
    private static readonly IntPtr NativeFieldInfoPtr__Process;
    private static readonly IntPtr NativeMethodInfoPtr_get_ProcessId_Public_Virtual_get_UInt32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Process_0;
    private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_HasProcessExited_Public_Virtual_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_KillProcess_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_String_String_String_Boolean_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_WaitForExit_Public_Virtual_Boolean_UInt32_0;
    private static readonly IntPtr NativeMethodInfoPtr_WriteLineStdIn_Public_Virtual_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetProcessById_Public_Static_StunProcess_UInt32_0;

    public override unsafe uint ProcessId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803301, XrefRangeEnd = 803303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess_MONO.NativeMethodInfoPtr_get_ProcessId_Public_Virtual_get_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunProcess_MONO()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunProcess_MONO>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunProcess_MONO.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(126)]
    [CachedScanResults(RefRangeStart = 39465, RefRangeEnd = 39591, XrefRangeStart = 39465, XrefRangeEnd = 39591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunProcess_MONO(Process process)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunProcess_MONO>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) process);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunProcess_MONO.NativeMethodInfoPtr__ctor_Private_Void_Process_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803303, XrefRangeEnd = 803305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess_MONO.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803305, XrefRangeEnd = 803307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasProcessExited()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess_MONO.NativeMethodInfoPtr_HasProcessExited_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803307, XrefRangeEnd = 803309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void KillProcess()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess_MONO.NativeMethodInfoPtr_KillProcess_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803309, XrefRangeEnd = 803320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Start(
      string path,
      string arguments,
      string dir,
      bool hidden,
      bool redirectStandardInput)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(path);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(arguments);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(dir);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &hidden;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &redirectStandardInput;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess_MONO.NativeMethodInfoPtr_Start_Public_Virtual_Void_String_String_String_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803320, XrefRangeEnd = 803322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool WaitForExit(uint waitMilliseconds)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &waitMilliseconds;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess_MONO.NativeMethodInfoPtr_WaitForExit_Public_Virtual_Boolean_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803322, XrefRangeEnd = 803324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void WriteLineStdIn(string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess_MONO.NativeMethodInfoPtr_WriteLineStdIn_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803324, XrefRangeEnd = 803330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new static unsafe StunProcess GetProcessById(uint processId)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &processId;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunProcess_MONO.NativeMethodInfoPtr_GetProcessById_Public_Static_StunProcess_UInt32_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (StunProcess) null : new StunProcess(pointer);
    }

    static StunProcess_MONO()
    {
      Il2CppClassPointerStore<StunProcess_MONO>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (StunProcess_MONO));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunProcess_MONO>.NativeClassPtr);
      StunProcess_MONO.NativeFieldInfoPtr__Process = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunProcess_MONO>.NativeClassPtr, nameof (_Process));
      StunProcess_MONO.NativeMethodInfoPtr_get_ProcessId_Public_Virtual_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_MONO>.NativeClassPtr, 100670819);
      StunProcess_MONO.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_MONO>.NativeClassPtr, 100670820);
      StunProcess_MONO.NativeMethodInfoPtr__ctor_Private_Void_Process_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_MONO>.NativeClassPtr, 100670821);
      StunProcess_MONO.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_MONO>.NativeClassPtr, 100670822);
      StunProcess_MONO.NativeMethodInfoPtr_HasProcessExited_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_MONO>.NativeClassPtr, 100670823);
      StunProcess_MONO.NativeMethodInfoPtr_KillProcess_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_MONO>.NativeClassPtr, 100670824);
      StunProcess_MONO.NativeMethodInfoPtr_Start_Public_Virtual_Void_String_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_MONO>.NativeClassPtr, 100670825);
      StunProcess_MONO.NativeMethodInfoPtr_WaitForExit_Public_Virtual_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_MONO>.NativeClassPtr, 100670826);
      StunProcess_MONO.NativeMethodInfoPtr_WriteLineStdIn_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_MONO>.NativeClassPtr, 100670827);
      StunProcess_MONO.NativeMethodInfoPtr_GetProcessById_Public_Static_StunProcess_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess_MONO>.NativeClassPtr, 100670828);
    }

    public StunProcess_MONO(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Process _Process
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_MONO.NativeFieldInfoPtr__Process));
        return pointer == IntPtr.Zero ? (Process) null : new Process(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunProcess_MONO.NativeFieldInfoPtr__Process), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
