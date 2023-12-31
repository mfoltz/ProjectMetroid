// Decompiled with JetBrains decompiler
// Type: ProjectM.ClientDebugSettingsSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ClientDebugSettingsSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__ClientDebugSettings;
    private static readonly IntPtr NativeMethodInfoPtr_get_ClientDebugSettings_Public_get_ClientDebugSettings_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_TryGetSettings_Public_Static_Boolean_byref_ClientDebugSettings_0;
    private static readonly IntPtr NativeMethodInfoPtr_TryGetSettings_Public_Static_Boolean_World_byref_ClientDebugSettings_0;
    private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe ClientDebugSettings ClientDebugSettings
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientDebugSettingsSystem.NativeMethodInfoPtr_get_ClientDebugSettings_Public_get_ClientDebugSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (ClientDebugSettings) null : new ClientDebugSettings(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748571, XrefRangeEnd = 748580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientDebugSettingsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientDebugSettingsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 748589, RefRangeEnd = 748593, XrefRangeStart = 748580, XrefRangeEnd = 748589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetSettings(out ClientDebugSettings settings)
    {
      IntPtr* numPtr1 = stackalloc IntPtr[1];
      IntPtr* numPtr2 = numPtr1;
      IntPtr zero = IntPtr.Zero;
      IntPtr* numPtr3 = &zero;
      *numPtr2 = (IntPtr) numPtr3;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientDebugSettingsSystem.NativeMethodInfoPtr_TryGetSettings_Public_Static_Boolean_byref_ClientDebugSettings_0, IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ClientDebugSettings local = ref settings;
      IntPtr pointer = zero;
      ClientDebugSettings clientDebugSettings = pointer == IntPtr.Zero ? (ClientDebugSettings) null : new ClientDebugSettings(pointer);
      local = clientDebugSettings;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748593, XrefRangeEnd = 748599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetSettings(World defaultWorld, out ClientDebugSettings settings)
    {
      IntPtr* numPtr1 = stackalloc IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) defaultWorld);
      IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
      IntPtr zero = IntPtr.Zero;
      IntPtr* numPtr2 = &zero;
      *(IntPtr*) num1 = (IntPtr) numPtr2;
      IntPtr exc;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClientDebugSettingsSystem.NativeMethodInfoPtr_TryGetSettings_Public_Static_Boolean_World_byref_ClientDebugSettings_0, IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ClientDebugSettings local = ref settings;
      IntPtr pointer = zero;
      ClientDebugSettings clientDebugSettings = pointer == IntPtr.Zero ? (ClientDebugSettings) null : new ClientDebugSettings(pointer);
      local = clientDebugSettings;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748599, XrefRangeEnd = 748613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Save()
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientDebugSettingsSystem.NativeMethodInfoPtr_Save_Public_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClientDebugSettingsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientDebugSettingsSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientDebugSettingsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientDebugSettingsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClientDebugSettingsSystem()
    {
      Il2CppClassPointerStore<ClientDebugSettingsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ClientDebugSettingsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientDebugSettingsSystem>.NativeClassPtr);
      ClientDebugSettingsSystem.NativeFieldInfoPtr__ClientDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientDebugSettingsSystem>.NativeClassPtr, nameof (_ClientDebugSettings));
      ClientDebugSettingsSystem.NativeMethodInfoPtr_get_ClientDebugSettings_Public_get_ClientDebugSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientDebugSettingsSystem>.NativeClassPtr, 100665905);
      ClientDebugSettingsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientDebugSettingsSystem>.NativeClassPtr, 100665906);
      ClientDebugSettingsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientDebugSettingsSystem>.NativeClassPtr, 100665907);
      ClientDebugSettingsSystem.NativeMethodInfoPtr_TryGetSettings_Public_Static_Boolean_byref_ClientDebugSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientDebugSettingsSystem>.NativeClassPtr, 100665908);
      ClientDebugSettingsSystem.NativeMethodInfoPtr_TryGetSettings_Public_Static_Boolean_World_byref_ClientDebugSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientDebugSettingsSystem>.NativeClassPtr, 100665909);
      ClientDebugSettingsSystem.NativeMethodInfoPtr_Save_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientDebugSettingsSystem>.NativeClassPtr, 100665910);
      ClientDebugSettingsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientDebugSettingsSystem>.NativeClassPtr, 100665911);
      ClientDebugSettingsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientDebugSettingsSystem>.NativeClassPtr, 100665912);
    }

    public ClientDebugSettingsSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ClientDebugSettings _ClientDebugSettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientDebugSettingsSystem.NativeFieldInfoPtr__ClientDebugSettings));
        return pointer == IntPtr.Zero ? (ClientDebugSettings) null : new ClientDebugSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientDebugSettingsSystem.NativeFieldInfoPtr__ClientDebugSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
