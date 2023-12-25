// Decompiled with JetBrains decompiler
// Type: ProjectM.Community.SteamRichPresenceSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Auth;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Community
{
  public class SteamRichPresenceSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__SteamPlatformSystem;
    private static readonly IntPtr NativeFieldInfoPtr__LastSteamDisplayUpdate;
    private static readonly IntPtr NativeFieldInfoPtr__NextSteamPresenceUpdateTime;
    private static readonly IntPtr NativeFieldInfoPtr__SteamPresenceUpdateFrequency;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetSteamDisplayKey_Private_Static_String_PlayerPresence_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125731, XrefRangeEnd = 1125738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SteamRichPresenceSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125738, XrefRangeEnd = 1125856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SteamRichPresenceSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125856, XrefRangeEnd = 1125873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetSteamDisplayKey(PlayerPresence playerPresence)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &playerPresence;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SteamRichPresenceSystem.NativeMethodInfoPtr_GetSteamDisplayKey_Private_Static_String_PlayerPresence_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SteamRichPresenceSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamRichPresenceSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamRichPresenceSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SteamRichPresenceSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SteamRichPresenceSystem()
    {
      Il2CppClassPointerStore<SteamRichPresenceSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Community", nameof (SteamRichPresenceSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamRichPresenceSystem>.NativeClassPtr);
      SteamRichPresenceSystem.NativeFieldInfoPtr__SteamPlatformSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRichPresenceSystem>.NativeClassPtr, nameof (_SteamPlatformSystem));
      SteamRichPresenceSystem.NativeFieldInfoPtr__LastSteamDisplayUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRichPresenceSystem>.NativeClassPtr, nameof (_LastSteamDisplayUpdate));
      SteamRichPresenceSystem.NativeFieldInfoPtr__NextSteamPresenceUpdateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRichPresenceSystem>.NativeClassPtr, nameof (_NextSteamPresenceUpdateTime));
      SteamRichPresenceSystem.NativeFieldInfoPtr__SteamPresenceUpdateFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRichPresenceSystem>.NativeClassPtr, nameof (_SteamPresenceUpdateFrequency));
      SteamRichPresenceSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRichPresenceSystem>.NativeClassPtr, 100689304);
      SteamRichPresenceSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRichPresenceSystem>.NativeClassPtr, 100689305);
      SteamRichPresenceSystem.NativeMethodInfoPtr_GetSteamDisplayKey_Private_Static_String_PlayerPresence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRichPresenceSystem>.NativeClassPtr, 100689306);
      SteamRichPresenceSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRichPresenceSystem>.NativeClassPtr, 100689307);
      SteamRichPresenceSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRichPresenceSystem>.NativeClassPtr, 100689308);
    }

    public SteamRichPresenceSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SteamPlatformSystem _SteamPlatformSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamRichPresenceSystem.NativeFieldInfoPtr__SteamPlatformSystem));
        return pointer == IntPtr.Zero ? (SteamPlatformSystem) null : new SteamPlatformSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamRichPresenceSystem.NativeFieldInfoPtr__SteamPlatformSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe double _LastSteamDisplayUpdate
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamRichPresenceSystem.NativeFieldInfoPtr__LastSteamDisplayUpdate));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamRichPresenceSystem.NativeFieldInfoPtr__LastSteamDisplayUpdate)) = value;
      }
    }

    public unsafe double _NextSteamPresenceUpdateTime
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamRichPresenceSystem.NativeFieldInfoPtr__NextSteamPresenceUpdateTime));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamRichPresenceSystem.NativeFieldInfoPtr__NextSteamPresenceUpdateTime)) = value;
      }
    }

    public static unsafe double _SteamPresenceUpdateFrequency
    {
      get
      {
        double presenceUpdateFrequency;
        IL2CPP.il2cpp_field_static_get_value(SteamRichPresenceSystem.NativeFieldInfoPtr__SteamPresenceUpdateFrequency, (void*) &presenceUpdateFrequency);
        return presenceUpdateFrequency;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SteamRichPresenceSystem.NativeFieldInfoPtr__SteamPresenceUpdateFrequency, (void*) &value);
      }
    }
  }
}
