// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.StunProcess
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace ProjectM.Shared
{
  public class StunProcess : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ProcessId_Public_Abstract_Virtual_New_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasProcessExited_Public_Abstract_Virtual_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_KillProcess_Public_Abstract_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_Void_String_String_String_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WaitForExit_Public_Abstract_Virtual_New_Boolean_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteLineStdIn_Public_Abstract_Virtual_New_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetProcessById_Public_Static_StunProcess_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    public virtual unsafe uint ProcessId
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess.NativeMethodInfoPtr_get_ProcessId_Public_Abstract_Virtual_New_get_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    public virtual unsafe void Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe bool HasProcessExited()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess.NativeMethodInfoPtr_HasProcessExited_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe void KillProcess()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess.NativeMethodInfoPtr_KillProcess_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void Start(
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess.NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_Void_String_String_String_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe bool WaitForExit(uint waitMilliseconds)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &waitMilliseconds;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess.NativeMethodInfoPtr_WaitForExit_Public_Abstract_Virtual_New_Boolean_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe void WriteLineStdIn(string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunProcess.NativeMethodInfoPtr_WriteLineStdIn_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803294, XrefRangeEnd = 803301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe StunProcess GetProcessById(uint processId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &processId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunProcess.NativeMethodInfoPtr_GetProcessById_Public_Static_StunProcess_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (StunProcess) null : new StunProcess(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunProcess()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunProcess>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunProcess.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StunProcess()
    {
      Il2CppClassPointerStore<StunProcess>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (StunProcess));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunProcess>.NativeClassPtr);
      StunProcess.NativeMethodInfoPtr_get_ProcessId_Public_Abstract_Virtual_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess>.NativeClassPtr, 100670810);
      StunProcess.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess>.NativeClassPtr, 100670811);
      StunProcess.NativeMethodInfoPtr_HasProcessExited_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess>.NativeClassPtr, 100670812);
      StunProcess.NativeMethodInfoPtr_KillProcess_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess>.NativeClassPtr, 100670813);
      StunProcess.NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_Void_String_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess>.NativeClassPtr, 100670814);
      StunProcess.NativeMethodInfoPtr_WaitForExit_Public_Abstract_Virtual_New_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess>.NativeClassPtr, 100670815);
      StunProcess.NativeMethodInfoPtr_WriteLineStdIn_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess>.NativeClassPtr, 100670816);
      StunProcess.NativeMethodInfoPtr_GetProcessById_Public_Static_StunProcess_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess>.NativeClassPtr, 100670817);
      StunProcess.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunProcess>.NativeClassPtr, 100670818);
    }

    public StunProcess(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
