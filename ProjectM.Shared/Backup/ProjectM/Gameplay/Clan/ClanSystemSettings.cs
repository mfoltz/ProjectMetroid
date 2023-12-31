// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Clan.ClanSystemSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Fmod;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Gameplay.Clan
{
  public class ClanSystemSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_InvitationReceivedSound;
    private static readonly IntPtr NativeFieldInfoPtr_MemberJoinedSound;
    private static readonly IntPtr NativeFieldInfoPtr_MemberOnlineSound;
    private static readonly IntPtr NativeFieldInfoPtr_MemberLeftSound;
    private static readonly IntPtr NativeFieldInfoPtr_Raiding_Attacked;
    private static readonly IntPtr NativeFieldInfoPtr_Raiding_Breached;
    private static readonly IntPtr NativeFieldInfoPtr_Raiding_GolemSummoned;
    private static readonly IntPtr NativeFieldInfoPtr_ClanInviteReceivedKey;
    private static readonly IntPtr NativeFieldInfoPtr_PlayerInviteResultKey_Success;
    private static readonly IntPtr NativeFieldInfoPtr_PlayerInviteResultKey_NotOnline;
    private static readonly IntPtr NativeFieldInfoPtr_PlayerInviteResultKey_NoPlayerWithThatName;
    private static readonly IntPtr NativeFieldInfoPtr_PlayerInviteResultKey_AlreadyInClan;
    private static readonly IntPtr NativeFieldInfoPtr_PlayerInviteResultKey_AlreadyHasPendingInvite;
    private static readonly IntPtr NativeFieldInfoPtr_PlayerInviteResultKey_ClanIsFull;
    private static readonly IntPtr NativeFieldInfoPtr_PlayerInviteResultKey_NoSlotsToInvite;
    private static readonly IntPtr NativeFieldInfoPtr_PlayerInviteResultKey_CantInviteSelf;
    private static readonly IntPtr NativeFieldInfoPtr_PlayerInviteRequestResponseKey_Accept;
    private static readonly IntPtr NativeFieldInfoPtr_PlayerInviteRequestResponseKey_Decline;
    private static readonly IntPtr NativeFieldInfoPtr_PlayerInviteRequestResponseKey_TimeOut;
    private static readonly IntPtr NativeFieldInfoPtr_LeaveClanResultKey_Success;
    private static readonly IntPtr NativeFieldInfoPtr_LeaveClanResultKey_IsNotInClan;
    private static readonly IntPtr NativeFieldInfoPtr_LeaveClanResultKey_ClanDoesNotExist;
    private static readonly IntPtr NativeFieldInfoPtr_AcceptClanInviteResultKey_Success;
    private static readonly IntPtr NativeFieldInfoPtr_AcceptClanInviteResultKey_NoInvitePresent;
    private static readonly IntPtr NativeFieldInfoPtr_AcceptClanInviteResultKey_UnknownClan;
    private static readonly IntPtr NativeFieldInfoPtr_AcceptClanInviteResultKey_IsAlreadyInClan;
    private static readonly IntPtr NativeFieldInfoPtr_MemberOnlineMessage;
    private static readonly IntPtr NativeFieldInfoPtr_MemberOfflineMessage;
    private static readonly IntPtr NativeFieldInfoPtr_KickedMessage;
    private static readonly IntPtr NativeFieldInfoPtr_RoleChangedMessage;
    private static readonly IntPtr NativeFieldInfoPtr_Leader;
    private static readonly IntPtr NativeFieldInfoPtr_Officer;
    private static readonly IntPtr NativeFieldInfoPtr_Member;
    private static readonly IntPtr NativeFieldInfoPtr_CastleWallBreached;
    private static readonly IntPtr NativeFieldInfoPtr_CastleAttacked;
    private static readonly IntPtr NativeFieldInfoPtr_NewSiegeWeapon;
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe int GuidHash
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 789978, XrefRangeEnd = 789979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClanSystemSettings.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 789979, XrefRangeEnd = 790006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanSystemSettings.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetPrefabGUID()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClanSystemSettings.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClanSystemSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanSystemSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClanSystemSettings()
    {
      Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Gameplay.Clan", nameof (ClanSystemSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr);
      ClanSystemSettings.NativeFieldInfoPtr_InvitationReceivedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (InvitationReceivedSound));
      ClanSystemSettings.NativeFieldInfoPtr_MemberJoinedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (MemberJoinedSound));
      ClanSystemSettings.NativeFieldInfoPtr_MemberOnlineSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (MemberOnlineSound));
      ClanSystemSettings.NativeFieldInfoPtr_MemberLeftSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (MemberLeftSound));
      ClanSystemSettings.NativeFieldInfoPtr_Raiding_Attacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (Raiding_Attacked));
      ClanSystemSettings.NativeFieldInfoPtr_Raiding_Breached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (Raiding_Breached));
      ClanSystemSettings.NativeFieldInfoPtr_Raiding_GolemSummoned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (Raiding_GolemSummoned));
      ClanSystemSettings.NativeFieldInfoPtr_ClanInviteReceivedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (ClanInviteReceivedKey));
      ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (PlayerInviteResultKey_Success));
      ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_NotOnline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (PlayerInviteResultKey_NotOnline));
      ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_NoPlayerWithThatName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (PlayerInviteResultKey_NoPlayerWithThatName));
      ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_AlreadyInClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (PlayerInviteResultKey_AlreadyInClan));
      ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_AlreadyHasPendingInvite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (PlayerInviteResultKey_AlreadyHasPendingInvite));
      ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_ClanIsFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (PlayerInviteResultKey_ClanIsFull));
      ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_NoSlotsToInvite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (PlayerInviteResultKey_NoSlotsToInvite));
      ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_CantInviteSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (PlayerInviteResultKey_CantInviteSelf));
      ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteRequestResponseKey_Accept = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (PlayerInviteRequestResponseKey_Accept));
      ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteRequestResponseKey_Decline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (PlayerInviteRequestResponseKey_Decline));
      ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteRequestResponseKey_TimeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (PlayerInviteRequestResponseKey_TimeOut));
      ClanSystemSettings.NativeFieldInfoPtr_LeaveClanResultKey_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (LeaveClanResultKey_Success));
      ClanSystemSettings.NativeFieldInfoPtr_LeaveClanResultKey_IsNotInClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (LeaveClanResultKey_IsNotInClan));
      ClanSystemSettings.NativeFieldInfoPtr_LeaveClanResultKey_ClanDoesNotExist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (LeaveClanResultKey_ClanDoesNotExist));
      ClanSystemSettings.NativeFieldInfoPtr_AcceptClanInviteResultKey_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (AcceptClanInviteResultKey_Success));
      ClanSystemSettings.NativeFieldInfoPtr_AcceptClanInviteResultKey_NoInvitePresent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (AcceptClanInviteResultKey_NoInvitePresent));
      ClanSystemSettings.NativeFieldInfoPtr_AcceptClanInviteResultKey_UnknownClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (AcceptClanInviteResultKey_UnknownClan));
      ClanSystemSettings.NativeFieldInfoPtr_AcceptClanInviteResultKey_IsAlreadyInClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (AcceptClanInviteResultKey_IsAlreadyInClan));
      ClanSystemSettings.NativeFieldInfoPtr_MemberOnlineMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (MemberOnlineMessage));
      ClanSystemSettings.NativeFieldInfoPtr_MemberOfflineMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (MemberOfflineMessage));
      ClanSystemSettings.NativeFieldInfoPtr_KickedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (KickedMessage));
      ClanSystemSettings.NativeFieldInfoPtr_RoleChangedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (RoleChangedMessage));
      ClanSystemSettings.NativeFieldInfoPtr_Leader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (Leader));
      ClanSystemSettings.NativeFieldInfoPtr_Officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (Officer));
      ClanSystemSettings.NativeFieldInfoPtr_Member = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (Member));
      ClanSystemSettings.NativeFieldInfoPtr_CastleWallBreached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (CastleWallBreached));
      ClanSystemSettings.NativeFieldInfoPtr_CastleAttacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (CastleAttacked));
      ClanSystemSettings.NativeFieldInfoPtr_NewSiegeWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (NewSiegeWeapon));
      ClanSystemSettings.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, nameof (_Guid));
      ClanSystemSettings.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, 100669506);
      ClanSystemSettings.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, 100669507);
      ClanSystemSettings.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, 100669508);
      ClanSystemSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanSystemSettings>.NativeClassPtr, 100669509);
    }

    public ClanSystemSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public FmodEvent InvitationReceivedSound
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_InvitationReceivedSound);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_InvitationReceivedSound), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public FmodEvent MemberJoinedSound
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_MemberJoinedSound);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_MemberJoinedSound), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public FmodEvent MemberOnlineSound
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_MemberOnlineSound);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_MemberOnlineSound), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public FmodEvent MemberLeftSound
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_MemberLeftSound);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_MemberLeftSound), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public FmodEvent Raiding_Attacked
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_Raiding_Attacked);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_Raiding_Attacked), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public FmodEvent Raiding_Breached
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_Raiding_Breached);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_Raiding_Breached), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public FmodEvent Raiding_GolemSummoned
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_Raiding_GolemSummoned);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_Raiding_GolemSummoned), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe LocalizationKey ClanInviteReceivedKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_ClanInviteReceivedKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_ClanInviteReceivedKey)) = value;
      }
    }

    public unsafe LocalizationKey PlayerInviteResultKey_Success
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_Success));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_Success)) = value;
      }
    }

    public unsafe LocalizationKey PlayerInviteResultKey_NotOnline
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_NotOnline));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_NotOnline)) = value;
      }
    }

    public unsafe LocalizationKey PlayerInviteResultKey_NoPlayerWithThatName
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_NoPlayerWithThatName));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_NoPlayerWithThatName)) = value;
      }
    }

    public unsafe LocalizationKey PlayerInviteResultKey_AlreadyInClan
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_AlreadyInClan));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_AlreadyInClan)) = value;
      }
    }

    public unsafe LocalizationKey PlayerInviteResultKey_AlreadyHasPendingInvite
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_AlreadyHasPendingInvite));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_AlreadyHasPendingInvite)) = value;
      }
    }

    public unsafe LocalizationKey PlayerInviteResultKey_ClanIsFull
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_ClanIsFull));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_ClanIsFull)) = value;
      }
    }

    public unsafe LocalizationKey PlayerInviteResultKey_NoSlotsToInvite
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_NoSlotsToInvite));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_NoSlotsToInvite)) = value;
      }
    }

    public unsafe LocalizationKey PlayerInviteResultKey_CantInviteSelf
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_CantInviteSelf));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteResultKey_CantInviteSelf)) = value;
      }
    }

    public unsafe LocalizationKey PlayerInviteRequestResponseKey_Accept
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteRequestResponseKey_Accept));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteRequestResponseKey_Accept)) = value;
      }
    }

    public unsafe LocalizationKey PlayerInviteRequestResponseKey_Decline
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteRequestResponseKey_Decline));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteRequestResponseKey_Decline)) = value;
      }
    }

    public unsafe LocalizationKey PlayerInviteRequestResponseKey_TimeOut
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteRequestResponseKey_TimeOut));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_PlayerInviteRequestResponseKey_TimeOut)) = value;
      }
    }

    public unsafe LocalizationKey LeaveClanResultKey_Success
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_LeaveClanResultKey_Success));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_LeaveClanResultKey_Success)) = value;
      }
    }

    public unsafe LocalizationKey LeaveClanResultKey_IsNotInClan
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_LeaveClanResultKey_IsNotInClan));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_LeaveClanResultKey_IsNotInClan)) = value;
      }
    }

    public unsafe LocalizationKey LeaveClanResultKey_ClanDoesNotExist
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_LeaveClanResultKey_ClanDoesNotExist));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_LeaveClanResultKey_ClanDoesNotExist)) = value;
      }
    }

    public unsafe LocalizationKey AcceptClanInviteResultKey_Success
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_AcceptClanInviteResultKey_Success));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_AcceptClanInviteResultKey_Success)) = value;
      }
    }

    public unsafe LocalizationKey AcceptClanInviteResultKey_NoInvitePresent
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_AcceptClanInviteResultKey_NoInvitePresent));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_AcceptClanInviteResultKey_NoInvitePresent)) = value;
      }
    }

    public unsafe LocalizationKey AcceptClanInviteResultKey_UnknownClan
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_AcceptClanInviteResultKey_UnknownClan));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_AcceptClanInviteResultKey_UnknownClan)) = value;
      }
    }

    public unsafe LocalizationKey AcceptClanInviteResultKey_IsAlreadyInClan
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_AcceptClanInviteResultKey_IsAlreadyInClan));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_AcceptClanInviteResultKey_IsAlreadyInClan)) = value;
      }
    }

    public unsafe LocalizationKey MemberOnlineMessage
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_MemberOnlineMessage));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_MemberOnlineMessage)) = value;
      }
    }

    public unsafe LocalizationKey MemberOfflineMessage
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_MemberOfflineMessage));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_MemberOfflineMessage)) = value;
      }
    }

    public unsafe LocalizationKey KickedMessage
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_KickedMessage));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_KickedMessage)) = value;
      }
    }

    public unsafe LocalizationKey RoleChangedMessage
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_RoleChangedMessage));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_RoleChangedMessage)) = value;
      }
    }

    public unsafe LocalizationKey Leader
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_Leader));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_Leader)) = value;
      }
    }

    public unsafe LocalizationKey Officer
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_Officer));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_Officer)) = value;
      }
    }

    public unsafe LocalizationKey Member
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_Member));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_Member)) = value;
      }
    }

    public unsafe LocalizationKey CastleWallBreached
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_CastleWallBreached));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_CastleWallBreached)) = value;
      }
    }

    public unsafe LocalizationKey CastleAttacked
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_CastleAttacked));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_CastleAttacked)) = value;
      }
    }

    public unsafe LocalizationKey NewSiegeWeapon
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_NewSiegeWeapon));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr_NewSiegeWeapon)) = value;
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanSystemSettings.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
