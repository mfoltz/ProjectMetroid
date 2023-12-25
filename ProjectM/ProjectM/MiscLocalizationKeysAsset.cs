// Decompiled with JetBrains decompiler
// Type: ProjectM.MiscLocalizationKeysAsset
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
  public class MiscLocalizationKeysAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_AdminUsedConsoleCommandMessage;
    private static readonly IntPtr NativeFieldInfoPtr_ForceJoinClan_AdminJoinedYourClanMessage;
    private static readonly IntPtr NativeFieldInfoPtr_ForceJoinClan_SenderAlreadyInClanError;
    private static readonly IntPtr NativeFieldInfoPtr_ForceJoinClan_NoPlayerFoundError;
    private static readonly IntPtr NativeFieldInfoPtr_ForceJoinClan_TargetNotInAClanError;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnUnit_UnitNotFoundError;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051507, XrefRangeEnd = 1051511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MiscLocalizationKeysAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MiscLocalizationKeysAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiscLocalizationKeysAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MiscLocalizationKeysAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MiscLocalizationKeysAsset()
    {
      Il2CppClassPointerStore<MiscLocalizationKeysAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (MiscLocalizationKeysAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiscLocalizationKeysAsset>.NativeClassPtr);
      MiscLocalizationKeysAsset.NativeFieldInfoPtr_AdminUsedConsoleCommandMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscLocalizationKeysAsset>.NativeClassPtr, nameof (AdminUsedConsoleCommandMessage));
      MiscLocalizationKeysAsset.NativeFieldInfoPtr_ForceJoinClan_AdminJoinedYourClanMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscLocalizationKeysAsset>.NativeClassPtr, nameof (ForceJoinClan_AdminJoinedYourClanMessage));
      MiscLocalizationKeysAsset.NativeFieldInfoPtr_ForceJoinClan_SenderAlreadyInClanError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscLocalizationKeysAsset>.NativeClassPtr, nameof (ForceJoinClan_SenderAlreadyInClanError));
      MiscLocalizationKeysAsset.NativeFieldInfoPtr_ForceJoinClan_NoPlayerFoundError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscLocalizationKeysAsset>.NativeClassPtr, nameof (ForceJoinClan_NoPlayerFoundError));
      MiscLocalizationKeysAsset.NativeFieldInfoPtr_ForceJoinClan_TargetNotInAClanError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscLocalizationKeysAsset>.NativeClassPtr, nameof (ForceJoinClan_TargetNotInAClanError));
      MiscLocalizationKeysAsset.NativeFieldInfoPtr_SpawnUnit_UnitNotFoundError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscLocalizationKeysAsset>.NativeClassPtr, nameof (SpawnUnit_UnitNotFoundError));
      MiscLocalizationKeysAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscLocalizationKeysAsset>.NativeClassPtr, 100682607);
      MiscLocalizationKeysAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscLocalizationKeysAsset>.NativeClassPtr, 100682608);
    }

    public MiscLocalizationKeysAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey AdminUsedConsoleCommandMessage
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiscLocalizationKeysAsset.NativeFieldInfoPtr_AdminUsedConsoleCommandMessage));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiscLocalizationKeysAsset.NativeFieldInfoPtr_AdminUsedConsoleCommandMessage)) = value;
      }
    }

    public unsafe LocalizationKey ForceJoinClan_AdminJoinedYourClanMessage
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiscLocalizationKeysAsset.NativeFieldInfoPtr_ForceJoinClan_AdminJoinedYourClanMessage));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiscLocalizationKeysAsset.NativeFieldInfoPtr_ForceJoinClan_AdminJoinedYourClanMessage)) = value;
      }
    }

    public unsafe LocalizationKey ForceJoinClan_SenderAlreadyInClanError
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiscLocalizationKeysAsset.NativeFieldInfoPtr_ForceJoinClan_SenderAlreadyInClanError));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiscLocalizationKeysAsset.NativeFieldInfoPtr_ForceJoinClan_SenderAlreadyInClanError)) = value;
      }
    }

    public unsafe LocalizationKey ForceJoinClan_NoPlayerFoundError
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiscLocalizationKeysAsset.NativeFieldInfoPtr_ForceJoinClan_NoPlayerFoundError));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiscLocalizationKeysAsset.NativeFieldInfoPtr_ForceJoinClan_NoPlayerFoundError)) = value;
      }
    }

    public unsafe LocalizationKey ForceJoinClan_TargetNotInAClanError
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiscLocalizationKeysAsset.NativeFieldInfoPtr_ForceJoinClan_TargetNotInAClanError));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiscLocalizationKeysAsset.NativeFieldInfoPtr_ForceJoinClan_TargetNotInAClanError)) = value;
      }
    }

    public unsafe LocalizationKey SpawnUnit_UnitNotFoundError
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiscLocalizationKeysAsset.NativeFieldInfoPtr_SpawnUnit_UnitNotFoundError));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiscLocalizationKeysAsset.NativeFieldInfoPtr_SpawnUnit_UnitNotFoundError)) = value;
      }
    }
  }
}
