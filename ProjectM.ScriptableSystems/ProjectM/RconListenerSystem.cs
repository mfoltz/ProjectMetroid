// Decompiled with JetBrains decompiler
// Type: ProjectM.RconListenerSystem
// Assembly: ProjectM.ScriptableSystems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4FC41C5A-90E3-4DE6-83F1-AE360FF7C5FF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.ScriptableSystems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;
using RCONServerLib;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class RconListenerSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Server;
    private static readonly System.IntPtr NativeFieldInfoPtr__MainThreadActions;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Join_Private_String_String_IList_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Join_Private_String_IList_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommand_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreate_b__2_0_Private_String_String_IList_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreate_b__2_1_Private_String_String_IList_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreate_b__2_2_Private_String_String_IList_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreate_b__2_3_Private_String_String_IList_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650031, XrefRangeEnd = 1650117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RconListenerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1650144, RefRangeEnd = 1650145, XrefRangeStart = 1650117, XrefRangeEnd = 1650144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string Join(string command, IList<string> arguments)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(command);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arguments);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(RconListenerSystem.NativeMethodInfoPtr_Join_Private_String_String_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1650172, RefRangeEnd = 1650173, XrefRangeStart = 1650145, XrefRangeEnd = 1650172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string Join(IList<string> arguments)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arguments);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(RconListenerSystem.NativeMethodInfoPtr_Join_Private_String_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1650195, RefRangeEnd = 1650198, XrefRangeStart = 1650173, XrefRangeEnd = 1650195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ExecuteCommand(string command)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(command);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RconListenerSystem.NativeMethodInfoPtr_ExecuteCommand_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650198, XrefRangeEnd = 1650199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RconListenerSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650199, XrefRangeEnd = 1650204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RconListenerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650204, XrefRangeEnd = 1650212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RconListenerSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RconListenerSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RconListenerSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650212, XrefRangeEnd = 1650216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _OnCreate_b__2_0(string _, IList<string> arguments)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(_);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arguments);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(RconListenerSystem.NativeMethodInfoPtr__OnCreate_b__2_0_Private_String_String_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650216, XrefRangeEnd = 1650226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _OnCreate_b__2_1(string _, IList<string> arguments)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(_);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arguments);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(RconListenerSystem.NativeMethodInfoPtr__OnCreate_b__2_1_Private_String_String_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650226, XrefRangeEnd = 1650244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _OnCreate_b__2_2(string _, IList<string> arguments)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(_);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arguments);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(RconListenerSystem.NativeMethodInfoPtr__OnCreate_b__2_2_Private_String_String_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650244, XrefRangeEnd = 1650285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _OnCreate_b__2_3(string _, IList<string> arguments)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(_);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arguments);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(RconListenerSystem.NativeMethodInfoPtr__OnCreate_b__2_3_Private_String_String_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RconListenerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RconListenerSystem()
    {
      Il2CppClassPointerStore<RconListenerSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.ScriptableSystems.dll", "ProjectM", nameof (RconListenerSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RconListenerSystem>.NativeClassPtr);
      RconListenerSystem.NativeFieldInfoPtr__Server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RconListenerSystem>.NativeClassPtr, nameof (_Server));
      RconListenerSystem.NativeFieldInfoPtr__MainThreadActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RconListenerSystem>.NativeClassPtr, nameof (_MainThreadActions));
      RconListenerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RconListenerSystem>.NativeClassPtr, 100663860);
      RconListenerSystem.NativeMethodInfoPtr_Join_Private_String_String_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RconListenerSystem>.NativeClassPtr, 100663861);
      RconListenerSystem.NativeMethodInfoPtr_Join_Private_String_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RconListenerSystem>.NativeClassPtr, 100663862);
      RconListenerSystem.NativeMethodInfoPtr_ExecuteCommand_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RconListenerSystem>.NativeClassPtr, 100663863);
      RconListenerSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RconListenerSystem>.NativeClassPtr, 100663864);
      RconListenerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RconListenerSystem>.NativeClassPtr, 100663865);
      RconListenerSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RconListenerSystem>.NativeClassPtr, 100663866);
      RconListenerSystem.NativeMethodInfoPtr__OnCreate_b__2_0_Private_String_String_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RconListenerSystem>.NativeClassPtr, 100663867);
      RconListenerSystem.NativeMethodInfoPtr__OnCreate_b__2_1_Private_String_String_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RconListenerSystem>.NativeClassPtr, 100663868);
      RconListenerSystem.NativeMethodInfoPtr__OnCreate_b__2_2_Private_String_String_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RconListenerSystem>.NativeClassPtr, 100663869);
      RconListenerSystem.NativeMethodInfoPtr__OnCreate_b__2_3_Private_String_String_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RconListenerSystem>.NativeClassPtr, 100663870);
      RconListenerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RconListenerSystem>.NativeClassPtr, 100663871);
    }

    public RconListenerSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RemoteConServer _Server
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconListenerSystem.NativeFieldInfoPtr__Server));
        return pointer == System.IntPtr.Zero ? (RemoteConServer) null : new RemoteConServer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RconListenerSystem.NativeFieldInfoPtr__Server), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ConcurrentQueue<Il2CppSystem.Action> _MainThreadActions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconListenerSystem.NativeFieldInfoPtr__MainThreadActions));
        return pointer == System.IntPtr.Zero ? (ConcurrentQueue<Il2CppSystem.Action>) null : new ConcurrentQueue<Il2CppSystem.Action>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RconListenerSystem.NativeFieldInfoPtr__MainThreadActions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.RconListenerSystem/<>c__DisplayClass5_0")]
    public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_command;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ExecuteCommand_b__0_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass5_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RconListenerSystem.__c__DisplayClass5_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RconListenerSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650021, XrefRangeEnd = 1650031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ExecuteCommand_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RconListenerSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ExecuteCommand_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass5_0()
      {
        Il2CppClassPointerStore<RconListenerSystem.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RconListenerSystem>.NativeClassPtr, "<>c__DisplayClass5_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RconListenerSystem.__c__DisplayClass5_0>.NativeClassPtr);
        RconListenerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RconListenerSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (command));
        RconListenerSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RconListenerSystem.__c__DisplayClass5_0>.NativeClassPtr, 100663872);
        RconListenerSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ExecuteCommand_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RconListenerSystem.__c__DisplayClass5_0>.NativeClassPtr, 100663873);
      }

      public __c__DisplayClass5_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe string command
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconListenerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_command)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RconListenerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_command), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }
  }
}
