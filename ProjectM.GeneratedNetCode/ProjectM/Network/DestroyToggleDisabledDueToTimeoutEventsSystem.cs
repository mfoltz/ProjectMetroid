﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.DestroyToggleDisabledDueToTimeoutEventsSystem
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  public class DestroyToggleDisabledDueToTimeoutEventsSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__Query;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1501520, XrefRangeEnd = 1501531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyToggleDisabledDueToTimeoutEventsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyToggleDisabledDueToTimeoutEventsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DestroyToggleDisabledDueToTimeoutEventsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyToggleDisabledDueToTimeoutEventsSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyToggleDisabledDueToTimeoutEventsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyToggleDisabledDueToTimeoutEventsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DestroyToggleDisabledDueToTimeoutEventsSystem()
    {
      Il2CppClassPointerStore<DestroyToggleDisabledDueToTimeoutEventsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (DestroyToggleDisabledDueToTimeoutEventsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyToggleDisabledDueToTimeoutEventsSystem>.NativeClassPtr);
      DestroyToggleDisabledDueToTimeoutEventsSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyToggleDisabledDueToTimeoutEventsSystem>.NativeClassPtr, nameof (_Query));
      DestroyToggleDisabledDueToTimeoutEventsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyToggleDisabledDueToTimeoutEventsSystem>.NativeClassPtr, 100664078);
      DestroyToggleDisabledDueToTimeoutEventsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyToggleDisabledDueToTimeoutEventsSystem>.NativeClassPtr, 100664079);
      DestroyToggleDisabledDueToTimeoutEventsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyToggleDisabledDueToTimeoutEventsSystem>.NativeClassPtr, 100664080);
      DestroyToggleDisabledDueToTimeoutEventsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyToggleDisabledDueToTimeoutEventsSystem>.NativeClassPtr, 100664081);
    }

    public DestroyToggleDisabledDueToTimeoutEventsSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyToggleDisabledDueToTimeoutEventsSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyToggleDisabledDueToTimeoutEventsSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }
  }
}
