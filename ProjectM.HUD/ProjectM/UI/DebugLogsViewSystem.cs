// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.DebugLogsViewSystem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public class DebugLogsViewSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr_ServerDebugLogs;
    private static readonly IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerDebugLogs_30;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277707, XrefRangeEnd = 1277710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugLogsViewSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugLogsViewSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugLogsViewSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugLogsViewSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277710, XrefRangeEnd = 1277718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugLogsViewSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DebugLogsViewSystem()
    {
      Il2CppClassPointerStore<DebugLogsViewSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (DebugLogsViewSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugLogsViewSystem>.NativeClassPtr);
      DebugLogsViewSystem.NativeFieldInfoPtr_ServerDebugLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugLogsViewSystem>.NativeClassPtr, nameof (ServerDebugLogs));
      DebugLogsViewSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerDebugLogs_30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugLogsViewSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerDebugLogs_30));
      DebugLogsViewSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogsViewSystem>.NativeClassPtr, 100668728);
      DebugLogsViewSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogsViewSystem>.NativeClassPtr, 100668729);
      DebugLogsViewSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogsViewSystem>.NativeClassPtr, 100668730);
    }

    public DebugLogsViewSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ServerDebugLogs ServerDebugLogs
    {
      get
      {
        return *(ServerDebugLogs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsViewSystem.NativeFieldInfoPtr_ServerDebugLogs));
      }
      [param: In] set
      {
        *(ServerDebugLogs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsViewSystem.NativeFieldInfoPtr_ServerDebugLogs)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerDebugLogs_30
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsViewSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerDebugLogs_30));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsViewSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerDebugLogs_30)) = value;
      }
    }
  }
}
