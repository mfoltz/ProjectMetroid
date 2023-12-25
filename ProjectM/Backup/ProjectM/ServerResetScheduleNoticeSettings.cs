// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerResetScheduleNoticeSettings
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ServerResetScheduleNoticeSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_LKey_ResetEnabledNotice_Singular;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_ResetEnabledNotice_Plural;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_ResetDisabledNotice;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034137, XrefRangeEnd = 1034141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerResetScheduleNoticeSettings.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerResetScheduleNoticeSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerResetScheduleNoticeSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerResetScheduleNoticeSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerResetScheduleNoticeSettings()
    {
      Il2CppClassPointerStore<ServerResetScheduleNoticeSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServerResetScheduleNoticeSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerResetScheduleNoticeSettings>.NativeClassPtr);
      ServerResetScheduleNoticeSettings.NativeFieldInfoPtr_LKey_ResetEnabledNotice_Singular = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleNoticeSettings>.NativeClassPtr, nameof (LKey_ResetEnabledNotice_Singular));
      ServerResetScheduleNoticeSettings.NativeFieldInfoPtr_LKey_ResetEnabledNotice_Plural = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleNoticeSettings>.NativeClassPtr, nameof (LKey_ResetEnabledNotice_Plural));
      ServerResetScheduleNoticeSettings.NativeFieldInfoPtr_LKey_ResetDisabledNotice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleNoticeSettings>.NativeClassPtr, nameof (LKey_ResetDisabledNotice));
      ServerResetScheduleNoticeSettings.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerResetScheduleNoticeSettings>.NativeClassPtr, 100680800);
      ServerResetScheduleNoticeSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerResetScheduleNoticeSettings>.NativeClassPtr, 100680801);
    }

    public ServerResetScheduleNoticeSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey LKey_ResetEnabledNotice_Singular
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerResetScheduleNoticeSettings.NativeFieldInfoPtr_LKey_ResetEnabledNotice_Singular));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerResetScheduleNoticeSettings.NativeFieldInfoPtr_LKey_ResetEnabledNotice_Singular)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ResetEnabledNotice_Plural
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerResetScheduleNoticeSettings.NativeFieldInfoPtr_LKey_ResetEnabledNotice_Plural));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerResetScheduleNoticeSettings.NativeFieldInfoPtr_LKey_ResetEnabledNotice_Plural)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ResetDisabledNotice
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerResetScheduleNoticeSettings.NativeFieldInfoPtr_LKey_ResetDisabledNotice));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerResetScheduleNoticeSettings.NativeFieldInfoPtr_LKey_ResetDisabledNotice)) = value;
      }
    }
  }
}
