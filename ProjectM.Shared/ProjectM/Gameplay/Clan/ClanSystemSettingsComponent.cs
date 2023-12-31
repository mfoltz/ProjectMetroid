// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Clan.ClanSystemSettingsComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Stunlock.Fmod;
using Stunlock.Localization;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Clan
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ClanSystemSettingsComponent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InvitationReceivedSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_MemberJoinedSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_MemberOnlineSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_MemberLeftSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_Raiding_Attacked;
    private static readonly System.IntPtr NativeFieldInfoPtr_Raiding_Breached;
    private static readonly System.IntPtr NativeFieldInfoPtr_Raiding_GolemSummoned;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerInviteResultKey_Success;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerInviteResultKey_NotOnline;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerInviteResultKey_NoPlayerWithThatName;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerInviteResultKey_AlreadyInClan;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerInviteResultKey_AlreadyHasPendingInvite;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerInviteResultKey_ClanIsFull;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerInviteResultKey_NoSlotsToInvite;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerInviteResultKey_CantInviteSelf;
    private static readonly System.IntPtr NativeFieldInfoPtr_LeaveClanResultKey_Success;
    private static readonly System.IntPtr NativeFieldInfoPtr_LeaveClanResultKey_IsNotInClan;
    private static readonly System.IntPtr NativeFieldInfoPtr_LeaveClanResultKey_ClanDoesNotExist;
    private static readonly System.IntPtr NativeFieldInfoPtr_AcceptClanInviteResultKey_Success;
    private static readonly System.IntPtr NativeFieldInfoPtr_AcceptClanInviteResultKey_NoInvitePresent;
    private static readonly System.IntPtr NativeFieldInfoPtr_AcceptClanInviteResultKey_UnknownClan;
    private static readonly System.IntPtr NativeFieldInfoPtr_AcceptClanInviteResultKey_IsAlreadyInClan;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerInviteRequestResponseKey_Accept;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerInviteRequestResponseKey_Decline;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerInviteRequestResponseKey_TimeOut;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanInviteReceivedKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_MemberOnlineMessage;
    private static readonly System.IntPtr NativeFieldInfoPtr_MemberOfflineMessage;
    private static readonly System.IntPtr NativeFieldInfoPtr_KickedMessage;
    private static readonly System.IntPtr NativeFieldInfoPtr_RoleChangedMessage;
    private static readonly System.IntPtr NativeFieldInfoPtr_Leader;
    private static readonly System.IntPtr NativeFieldInfoPtr_Officer;
    private static readonly System.IntPtr NativeFieldInfoPtr_Member;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleWallBreached;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewSiegeWeapon;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleAttacked;
    [FieldOffset(0)]
    public FmodEventGuid InvitationReceivedSound;
    [FieldOffset(16)]
    public FmodEventGuid MemberJoinedSound;
    [FieldOffset(32)]
    public FmodEventGuid MemberOnlineSound;
    [FieldOffset(48)]
    public FmodEventGuid MemberLeftSound;
    [FieldOffset(64)]
    public FmodEventGuid Raiding_Attacked;
    [FieldOffset(80)]
    public FmodEventGuid Raiding_Breached;
    [FieldOffset(96)]
    public FmodEventGuid Raiding_GolemSummoned;
    [FieldOffset(112)]
    public LocalizationKey PlayerInviteResultKey_Success;
    [FieldOffset(128)]
    public LocalizationKey PlayerInviteResultKey_NotOnline;
    [FieldOffset(144)]
    public LocalizationKey PlayerInviteResultKey_NoPlayerWithThatName;
    [FieldOffset(160)]
    public LocalizationKey PlayerInviteResultKey_AlreadyInClan;
    [FieldOffset(176)]
    public LocalizationKey PlayerInviteResultKey_AlreadyHasPendingInvite;
    [FieldOffset(192)]
    public LocalizationKey PlayerInviteResultKey_ClanIsFull;
    [FieldOffset(208)]
    public LocalizationKey PlayerInviteResultKey_NoSlotsToInvite;
    [FieldOffset(224)]
    public LocalizationKey PlayerInviteResultKey_CantInviteSelf;
    [FieldOffset(240)]
    public LocalizationKey LeaveClanResultKey_Success;
    [FieldOffset(256)]
    public LocalizationKey LeaveClanResultKey_IsNotInClan;
    [FieldOffset(272)]
    public LocalizationKey LeaveClanResultKey_ClanDoesNotExist;
    [FieldOffset(288)]
    public LocalizationKey AcceptClanInviteResultKey_Success;
    [FieldOffset(304)]
    public LocalizationKey AcceptClanInviteResultKey_NoInvitePresent;
    [FieldOffset(320)]
    public LocalizationKey AcceptClanInviteResultKey_UnknownClan;
    [FieldOffset(336)]
    public LocalizationKey AcceptClanInviteResultKey_IsAlreadyInClan;
    [FieldOffset(352)]
    public LocalizationKey PlayerInviteRequestResponseKey_Accept;
    [FieldOffset(368)]
    public LocalizationKey PlayerInviteRequestResponseKey_Decline;
    [FieldOffset(384)]
    public LocalizationKey PlayerInviteRequestResponseKey_TimeOut;
    [FieldOffset(400)]
    public LocalizationKey ClanInviteReceivedKey;
    [FieldOffset(416)]
    public LocalizationKey MemberOnlineMessage;
    [FieldOffset(432)]
    public LocalizationKey MemberOfflineMessage;
    [FieldOffset(448)]
    public LocalizationKey KickedMessage;
    [FieldOffset(464)]
    public LocalizationKey RoleChangedMessage;
    [FieldOffset(480)]
    public LocalizationKey Leader;
    [FieldOffset(496)]
    public LocalizationKey Officer;
    [FieldOffset(512)]
    public LocalizationKey Member;
    [FieldOffset(528)]
    public LocalizationKey CastleWallBreached;
    [FieldOffset(544)]
    public LocalizationKey NewSiegeWeapon;
    [FieldOffset(560)]
    public LocalizationKey CastleAttacked;

    static ClanSystemSettingsComponent()
    {
      Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Gameplay.Clan", nameof (ClanSystemSettingsComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr);
      ClanSystemSettingsComponent.NativeFieldInfoPtr_InvitationReceivedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (InvitationReceivedSound));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_MemberJoinedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (MemberJoinedSound));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_MemberOnlineSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (MemberOnlineSound));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_MemberLeftSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (MemberLeftSound));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_Raiding_Attacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (Raiding_Attacked));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_Raiding_Breached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (Raiding_Breached));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_Raiding_GolemSummoned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (Raiding_GolemSummoned));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_PlayerInviteResultKey_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (PlayerInviteResultKey_Success));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_PlayerInviteResultKey_NotOnline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (PlayerInviteResultKey_NotOnline));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_PlayerInviteResultKey_NoPlayerWithThatName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (PlayerInviteResultKey_NoPlayerWithThatName));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_PlayerInviteResultKey_AlreadyInClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (PlayerInviteResultKey_AlreadyInClan));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_PlayerInviteResultKey_AlreadyHasPendingInvite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (PlayerInviteResultKey_AlreadyHasPendingInvite));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_PlayerInviteResultKey_ClanIsFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (PlayerInviteResultKey_ClanIsFull));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_PlayerInviteResultKey_NoSlotsToInvite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (PlayerInviteResultKey_NoSlotsToInvite));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_PlayerInviteResultKey_CantInviteSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (PlayerInviteResultKey_CantInviteSelf));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_LeaveClanResultKey_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (LeaveClanResultKey_Success));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_LeaveClanResultKey_IsNotInClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (LeaveClanResultKey_IsNotInClan));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_LeaveClanResultKey_ClanDoesNotExist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (LeaveClanResultKey_ClanDoesNotExist));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_AcceptClanInviteResultKey_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (AcceptClanInviteResultKey_Success));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_AcceptClanInviteResultKey_NoInvitePresent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (AcceptClanInviteResultKey_NoInvitePresent));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_AcceptClanInviteResultKey_UnknownClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (AcceptClanInviteResultKey_UnknownClan));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_AcceptClanInviteResultKey_IsAlreadyInClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (AcceptClanInviteResultKey_IsAlreadyInClan));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_PlayerInviteRequestResponseKey_Accept = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (PlayerInviteRequestResponseKey_Accept));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_PlayerInviteRequestResponseKey_Decline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (PlayerInviteRequestResponseKey_Decline));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_PlayerInviteRequestResponseKey_TimeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (PlayerInviteRequestResponseKey_TimeOut));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_ClanInviteReceivedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (ClanInviteReceivedKey));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_MemberOnlineMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (MemberOnlineMessage));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_MemberOfflineMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (MemberOfflineMessage));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_KickedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (KickedMessage));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_RoleChangedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (RoleChangedMessage));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_Leader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (Leader));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_Officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (Officer));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_Member = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (Member));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_CastleWallBreached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (CastleWallBreached));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_NewSiegeWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (NewSiegeWeapon));
      ClanSystemSettingsComponent.NativeFieldInfoPtr_CastleAttacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, nameof (CastleAttacked));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanSystemSettingsComponent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
