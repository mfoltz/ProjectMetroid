// Decompiled with JetBrains decompiler
// Type: ProjectM.ConsoleCommandSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Engine.Console;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ConsoleCommandSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ConsoleCommands;
    private static readonly System.IntPtr NativeFieldInfoPtr__WasAllowed;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddCommand_Private_Void_ConsoleCommand_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterCommand_Protected_DefaultConsoleCommand_String_String_Action_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterCommand_Protected_DefaultConsoleCommand_String_String_Delegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Final_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Final_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Abstract_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroyConsoleCommands_Protected_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateConsoleCommands_Protected_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Allowed_Protected_Abstract_Virtual_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Final_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 732486, RefRangeEnd = 732488, XrefRangeStart = 732472, XrefRangeEnd = 732486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddCommand(ConsoleCommand command)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) command);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConsoleCommandSystem.NativeMethodInfoPtr_AddCommand_Private_Void_ConsoleCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(39)]
    [CachedScanResults(RefRangeStart = 732498, RefRangeEnd = 732537, XrefRangeStart = 732488, XrefRangeEnd = 732498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DefaultConsoleCommand RegisterCommand(
      string command,
      string commandDescription,
      Il2CppSystem.Action commandDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(command);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(commandDescription);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) commandDelegate);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConsoleCommandSystem.NativeMethodInfoPtr_RegisterCommand_Protected_DefaultConsoleCommand_String_String_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (DefaultConsoleCommand) null : new DefaultConsoleCommand(pointer);
    }

    [CallerCount(113)]
    [CachedScanResults(RefRangeStart = 732547, RefRangeEnd = 732660, XrefRangeStart = 732537, XrefRangeEnd = 732547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DefaultConsoleCommand RegisterCommand(
      string command,
      string commandDescription,
      Il2CppSystem.Delegate commandDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(command);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(commandDescription);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) commandDelegate);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConsoleCommandSystem.NativeMethodInfoPtr_RegisterCommand_Protected_DefaultConsoleCommand_String_String_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (DefaultConsoleCommand) null : new DefaultConsoleCommand(pointer);
    }

    [CallerCount(0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConsoleCommandSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732660, XrefRangeEnd = 732682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConsoleCommandSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void OnCreateConsoleCommands()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConsoleCommandSystem.NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnDestroyConsoleCommands()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConsoleCommandSystem.NativeMethodInfoPtr_OnDestroyConsoleCommands_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnUpdateConsoleCommands()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConsoleCommandSystem.NativeMethodInfoPtr_OnUpdateConsoleCommands_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe bool Allowed()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConsoleCommandSystem.NativeMethodInfoPtr_Allowed_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Initialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConsoleCommandSystem.NativeMethodInfoPtr_Initialize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732682, XrefRangeEnd = 732715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConsoleCommandSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 732723, RefRangeEnd = 732730, XrefRangeStart = 732715, XrefRangeEnd = 732723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConsoleCommandSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleCommandSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConsoleCommandSystem.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConsoleCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ConsoleCommandSystem()
    {
      Il2CppClassPointerStore<ConsoleCommandSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ConsoleCommandSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleCommandSystem>.NativeClassPtr);
      ConsoleCommandSystem.NativeFieldInfoPtr__ConsoleCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleCommandSystem>.NativeClassPtr, nameof (_ConsoleCommands));
      ConsoleCommandSystem.NativeFieldInfoPtr__WasAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleCommandSystem>.NativeClassPtr, nameof (_WasAllowed));
      ConsoleCommandSystem.NativeMethodInfoPtr_AddCommand_Private_Void_ConsoleCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCommandSystem>.NativeClassPtr, 100664731);
      ConsoleCommandSystem.NativeMethodInfoPtr_RegisterCommand_Protected_DefaultConsoleCommand_String_String_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCommandSystem>.NativeClassPtr, 100664732);
      ConsoleCommandSystem.NativeMethodInfoPtr_RegisterCommand_Protected_DefaultConsoleCommand_String_String_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCommandSystem>.NativeClassPtr, 100664733);
      ConsoleCommandSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCommandSystem>.NativeClassPtr, 100664734);
      ConsoleCommandSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCommandSystem>.NativeClassPtr, 100664735);
      ConsoleCommandSystem.NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCommandSystem>.NativeClassPtr, 100664736);
      ConsoleCommandSystem.NativeMethodInfoPtr_OnDestroyConsoleCommands_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCommandSystem>.NativeClassPtr, 100664737);
      ConsoleCommandSystem.NativeMethodInfoPtr_OnUpdateConsoleCommands_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCommandSystem>.NativeClassPtr, 100664738);
      ConsoleCommandSystem.NativeMethodInfoPtr_Allowed_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCommandSystem>.NativeClassPtr, 100664739);
      ConsoleCommandSystem.NativeMethodInfoPtr_Initialize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCommandSystem>.NativeClassPtr, 100664740);
      ConsoleCommandSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCommandSystem>.NativeClassPtr, 100664741);
      ConsoleCommandSystem.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCommandSystem>.NativeClassPtr, 100664742);
      ConsoleCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCommandSystem>.NativeClassPtr, 100664743);
    }

    public ConsoleCommandSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<ConsoleCommand> _ConsoleCommands
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleCommandSystem.NativeFieldInfoPtr__ConsoleCommands));
        return pointer == System.IntPtr.Zero ? (List<ConsoleCommand>) null : new List<ConsoleCommand>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConsoleCommandSystem.NativeFieldInfoPtr__ConsoleCommands), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _WasAllowed
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleCommandSystem.NativeFieldInfoPtr__WasAllowed));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleCommandSystem.NativeFieldInfoPtr__WasAllowed)) = value;
      }
    }
  }
}
