// Decompiled with JetBrains decompiler
// Type: NewServerListEntryComponent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using ProjectM.UI;
using Stunlock.Localization;
using StunShared.UI;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
public class NewServerListEntryComponent : UIEntry
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Button;
  private static readonly System.IntPtr NativeFieldInfoPtr_NameText;
  private static readonly System.IntPtr NativeFieldInfoPtr_GameModeText;
  private static readonly System.IntPtr NativeFieldInfoPtr_HardCoreIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_ScrambledVBloodIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_PlayersConnectedText;
  private static readonly System.IntPtr NativeFieldInfoPtr_ClanSizeText;
  private static readonly System.IntPtr NativeFieldInfoPtr_ActivityText;
  private static readonly System.IntPtr NativeFieldInfoPtr_Data;
  private static readonly System.IntPtr NativeFieldInfoPtr_RecommendedIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_ScheduledWipesIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_HasPasswordIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_DedicatedServerIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_ApprovedSettingsIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_HasCharacterIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_FriendsPlayingIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_DeleteEntryIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_OfficialIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_TrustedIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_DefaultIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_RecommendedKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_HasPasswordKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_DedicatedServerKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_ApprovedSettingsKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_HasCharacterKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_FriendsPlayingKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_HardCoreKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_OfficialServerKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_TrustedServerKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_UnknownServerKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnlineNode;
  private static readonly System.IntPtr NativeFieldInfoPtr_OfflineText;
  private static readonly System.IntPtr NativeFieldInfoPtr_ServerOfflineKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_ServerWrongVersionKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_OfflineNode;
  private static readonly System.IntPtr NativeFieldInfoPtr_ServerFullColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_ServerNotFullColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_Color_GameMode_PvE;
  private static readonly System.IntPtr NativeFieldInfoPtr_Color_GameMode_PvP;
  private static readonly System.IntPtr NativeFieldInfoPtr_Color_GameMode_MPvP;
  private static readonly System.IntPtr NativeFieldInfoPtr__ListMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_CrowdedKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_MediumKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_SparseKey;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ListMode_Action_1_NewServerListEntryComponent_Action_1_NewServerListEntryComponent_Action_1_NewServerListEntryComponent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Void_ServerListEntryUIData_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGameModeColor_Private_Color_GameModeType_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowIcon_Private_Void_SimpleStunButton_LocalizationKey_PivotPresets_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowIcon_Private_Void_SimpleStunButton_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 1208938, RefRangeEnd = 1208940, XrefRangeStart = 1208875, XrefRangeEnd = 1208938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Initialize(
    NewServerListEntryComponent.ListMode listMode,
    Il2CppSystem.Action<NewServerListEntryComponent> onClick,
    Il2CppSystem.Action<NewServerListEntryComponent> onDoubleClick,
    Il2CppSystem.Action<NewServerListEntryComponent> onDeleteClicked = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &listMode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onClick);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onDoubleClick);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onDeleteClicked);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NewServerListEntryComponent.NativeMethodInfoPtr_Initialize_Public_Void_ListMode_Action_1_NewServerListEntryComponent_Action_1_NewServerListEntryComponent_Action_1_NewServerListEntryComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 1209054, RefRangeEnd = 1209056, XrefRangeStart = 1208940, XrefRangeEnd = 1209054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RefreshData(ServerListEntryUIData uiData, bool isSelected)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) uiData));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isSelected;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NewServerListEntryComponent.NativeMethodInfoPtr_RefreshData_Public_Void_ServerListEntryUIData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe Color GetGameModeColor(GameModeType gameMode, bool isHardCore)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &gameMode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isHardCore;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewServerListEntryComponent.NativeMethodInfoPtr_GetGameModeColor_Private_Color_GameModeType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209056, XrefRangeEnd = 1209061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowIcon(
    SimpleStunButton button,
    LocalizationKey key,
    PivotPresets pivot = PivotPresets.MiddleRight,
    float offset = 0.0f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) button);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &key;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NewServerListEntryComponent.NativeMethodInfoPtr_ShowIcon_Private_Void_SimpleStunButton_LocalizationKey_PivotPresets_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209061, XrefRangeEnd = 1209066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowIcon(SimpleStunButton button, string text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) button);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NewServerListEntryComponent.NativeMethodInfoPtr_ShowIcon_Private_Void_SimpleStunButton_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(41)]
  [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NewServerListEntryComponent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NewServerListEntryComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static NewServerListEntryComponent()
  {
    Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (NewServerListEntryComponent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr);
    NewServerListEntryComponent.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (Button));
    NewServerListEntryComponent.NativeFieldInfoPtr_NameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (NameText));
    NewServerListEntryComponent.NativeFieldInfoPtr_GameModeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (GameModeText));
    NewServerListEntryComponent.NativeFieldInfoPtr_HardCoreIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (HardCoreIcon));
    NewServerListEntryComponent.NativeFieldInfoPtr_ScrambledVBloodIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (ScrambledVBloodIcon));
    NewServerListEntryComponent.NativeFieldInfoPtr_PlayersConnectedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (PlayersConnectedText));
    NewServerListEntryComponent.NativeFieldInfoPtr_ClanSizeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (ClanSizeText));
    NewServerListEntryComponent.NativeFieldInfoPtr_ActivityText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (ActivityText));
    NewServerListEntryComponent.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (Data));
    NewServerListEntryComponent.NativeFieldInfoPtr_RecommendedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (RecommendedIcon));
    NewServerListEntryComponent.NativeFieldInfoPtr_ScheduledWipesIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (ScheduledWipesIcon));
    NewServerListEntryComponent.NativeFieldInfoPtr_HasPasswordIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (HasPasswordIcon));
    NewServerListEntryComponent.NativeFieldInfoPtr_DedicatedServerIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (DedicatedServerIcon));
    NewServerListEntryComponent.NativeFieldInfoPtr_ApprovedSettingsIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (ApprovedSettingsIcon));
    NewServerListEntryComponent.NativeFieldInfoPtr_HasCharacterIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (HasCharacterIcon));
    NewServerListEntryComponent.NativeFieldInfoPtr_FriendsPlayingIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (FriendsPlayingIcon));
    NewServerListEntryComponent.NativeFieldInfoPtr_DeleteEntryIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (DeleteEntryIcon));
    NewServerListEntryComponent.NativeFieldInfoPtr_OfficialIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (OfficialIcon));
    NewServerListEntryComponent.NativeFieldInfoPtr_TrustedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (TrustedIcon));
    NewServerListEntryComponent.NativeFieldInfoPtr_DefaultIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (DefaultIcon));
    NewServerListEntryComponent.NativeFieldInfoPtr_RecommendedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (RecommendedKey));
    NewServerListEntryComponent.NativeFieldInfoPtr_HasPasswordKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (HasPasswordKey));
    NewServerListEntryComponent.NativeFieldInfoPtr_DedicatedServerKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (DedicatedServerKey));
    NewServerListEntryComponent.NativeFieldInfoPtr_ApprovedSettingsKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (ApprovedSettingsKey));
    NewServerListEntryComponent.NativeFieldInfoPtr_HasCharacterKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (HasCharacterKey));
    NewServerListEntryComponent.NativeFieldInfoPtr_FriendsPlayingKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (FriendsPlayingKey));
    NewServerListEntryComponent.NativeFieldInfoPtr_HardCoreKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (HardCoreKey));
    NewServerListEntryComponent.NativeFieldInfoPtr_OfficialServerKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (OfficialServerKey));
    NewServerListEntryComponent.NativeFieldInfoPtr_TrustedServerKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (TrustedServerKey));
    NewServerListEntryComponent.NativeFieldInfoPtr_UnknownServerKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (UnknownServerKey));
    NewServerListEntryComponent.NativeFieldInfoPtr_OnlineNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (OnlineNode));
    NewServerListEntryComponent.NativeFieldInfoPtr_OfflineText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (OfflineText));
    NewServerListEntryComponent.NativeFieldInfoPtr_ServerOfflineKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (ServerOfflineKey));
    NewServerListEntryComponent.NativeFieldInfoPtr_ServerWrongVersionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (ServerWrongVersionKey));
    NewServerListEntryComponent.NativeFieldInfoPtr_OfflineNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (OfflineNode));
    NewServerListEntryComponent.NativeFieldInfoPtr_ServerFullColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (ServerFullColor));
    NewServerListEntryComponent.NativeFieldInfoPtr_ServerNotFullColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (ServerNotFullColor));
    NewServerListEntryComponent.NativeFieldInfoPtr_Color_GameMode_PvE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (Color_GameMode_PvE));
    NewServerListEntryComponent.NativeFieldInfoPtr_Color_GameMode_PvP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (Color_GameMode_PvP));
    NewServerListEntryComponent.NativeFieldInfoPtr_Color_GameMode_MPvP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (Color_GameMode_MPvP));
    NewServerListEntryComponent.NativeFieldInfoPtr__ListMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (_ListMode));
    NewServerListEntryComponent.NativeFieldInfoPtr_CrowdedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (CrowdedKey));
    NewServerListEntryComponent.NativeFieldInfoPtr_MediumKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (MediumKey));
    NewServerListEntryComponent.NativeFieldInfoPtr_SparseKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, nameof (SparseKey));
    NewServerListEntryComponent.NativeMethodInfoPtr_Initialize_Public_Void_ListMode_Action_1_NewServerListEntryComponent_Action_1_NewServerListEntryComponent_Action_1_NewServerListEntryComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, 100663550);
    NewServerListEntryComponent.NativeMethodInfoPtr_RefreshData_Public_Void_ServerListEntryUIData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, 100663551);
    NewServerListEntryComponent.NativeMethodInfoPtr_GetGameModeColor_Private_Color_GameModeType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, 100663552);
    NewServerListEntryComponent.NativeMethodInfoPtr_ShowIcon_Private_Void_SimpleStunButton_LocalizationKey_PivotPresets_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, 100663553);
    NewServerListEntryComponent.NativeMethodInfoPtr_ShowIcon_Private_Void_SimpleStunButton_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, 100663554);
    NewServerListEntryComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, 100663555);
  }

  public NewServerListEntryComponent(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe SimpleStunButton Button
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_Button));
      return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText NameText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_NameText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_NameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText GameModeText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_GameModeText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_GameModeText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SimpleStunButton HardCoreIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_HardCoreIcon));
      return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_HardCoreIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SimpleStunButton ScrambledVBloodIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ScrambledVBloodIcon));
      return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ScrambledVBloodIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text PlayersConnectedText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_PlayersConnectedText));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_PlayersConnectedText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text ClanSizeText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ClanSizeText));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ClanSizeText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text ActivityText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ActivityText));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ActivityText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public ServerListEntryUIData Data
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_Data);
      return new ServerListEntryUIData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerListEntryUIData>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_Data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerListEntryUIData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe SimpleStunButton RecommendedIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_RecommendedIcon));
      return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_RecommendedIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SimpleStunButton ScheduledWipesIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ScheduledWipesIcon));
      return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ScheduledWipesIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SimpleStunButton HasPasswordIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_HasPasswordIcon));
      return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_HasPasswordIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SimpleStunButton DedicatedServerIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_DedicatedServerIcon));
      return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_DedicatedServerIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SimpleStunButton ApprovedSettingsIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ApprovedSettingsIcon));
      return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ApprovedSettingsIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SimpleStunButton HasCharacterIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_HasCharacterIcon));
      return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_HasCharacterIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SimpleStunButton FriendsPlayingIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_FriendsPlayingIcon));
      return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_FriendsPlayingIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SimpleStunButton DeleteEntryIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_DeleteEntryIcon));
      return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_DeleteEntryIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SimpleStunButton OfficialIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_OfficialIcon));
      return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_OfficialIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SimpleStunButton TrustedIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_TrustedIcon));
      return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_TrustedIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SimpleStunButton DefaultIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_DefaultIcon));
      return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_DefaultIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizationKey RecommendedKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_RecommendedKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_RecommendedKey)) = value;
    }
  }

  public unsafe LocalizationKey HasPasswordKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_HasPasswordKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_HasPasswordKey)) = value;
    }
  }

  public unsafe LocalizationKey DedicatedServerKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_DedicatedServerKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_DedicatedServerKey)) = value;
    }
  }

  public unsafe LocalizationKey ApprovedSettingsKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ApprovedSettingsKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ApprovedSettingsKey)) = value;
    }
  }

  public unsafe LocalizationKey HasCharacterKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_HasCharacterKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_HasCharacterKey)) = value;
    }
  }

  public unsafe LocalizationKey FriendsPlayingKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_FriendsPlayingKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_FriendsPlayingKey)) = value;
    }
  }

  public unsafe LocalizationKey HardCoreKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_HardCoreKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_HardCoreKey)) = value;
    }
  }

  public unsafe LocalizationKey OfficialServerKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_OfficialServerKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_OfficialServerKey)) = value;
    }
  }

  public unsafe LocalizationKey TrustedServerKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_TrustedServerKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_TrustedServerKey)) = value;
    }
  }

  public unsafe LocalizationKey UnknownServerKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_UnknownServerKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_UnknownServerKey)) = value;
    }
  }

  public unsafe RectTransform OnlineNode
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_OnlineNode));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_OnlineNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText OfflineText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_OfflineText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_OfflineText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizationKey ServerOfflineKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ServerOfflineKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ServerOfflineKey)) = value;
    }
  }

  public unsafe LocalizationKey ServerWrongVersionKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ServerWrongVersionKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ServerWrongVersionKey)) = value;
    }
  }

  public unsafe RectTransform OfflineNode
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_OfflineNode));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_OfflineNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color ServerFullColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ServerFullColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ServerFullColor)) = value;
    }
  }

  public unsafe Color ServerNotFullColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ServerNotFullColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_ServerNotFullColor)) = value;
    }
  }

  public unsafe Color Color_GameMode_PvE
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_Color_GameMode_PvE));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_Color_GameMode_PvE)) = value;
    }
  }

  public unsafe Color Color_GameMode_PvP
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_Color_GameMode_PvP));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_Color_GameMode_PvP)) = value;
    }
  }

  public unsafe Color Color_GameMode_MPvP
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_Color_GameMode_MPvP));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_Color_GameMode_MPvP)) = value;
    }
  }

  public unsafe NewServerListEntryComponent.ListMode _ListMode
  {
    get
    {
      return *(NewServerListEntryComponent.ListMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr__ListMode));
    }
    [param: In] set
    {
      *(NewServerListEntryComponent.ListMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr__ListMode)) = value;
    }
  }

  public unsafe LocalizationKey CrowdedKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_CrowdedKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_CrowdedKey)) = value;
    }
  }

  public unsafe LocalizationKey MediumKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_MediumKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_MediumKey)) = value;
    }
  }

  public unsafe LocalizationKey SparseKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_SparseKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.NativeFieldInfoPtr_SparseKey)) = value;
    }
  }

  public enum ListMode
  {
    Join,
    Continue,
  }

  [ObfuscatedName("NewServerListEntryComponent/<>c__DisplayClass45_0")]
  public sealed class __c__DisplayClass45_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_onClick;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_onDeleteClicked;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__1_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__2_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__3_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__4_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__5_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__6_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__7_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__8_Internal_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass45_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewServerListEntryComponent.__c__DisplayClass45_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208839, XrefRangeEnd = 1208843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208843, XrefRangeEnd = 1208847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__Initialize_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208847, XrefRangeEnd = 1208851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__Initialize_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208851, XrefRangeEnd = 1208855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__3()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__Initialize_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208855, XrefRangeEnd = 1208859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__4()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__Initialize_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208859, XrefRangeEnd = 1208863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__5()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__Initialize_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208863, XrefRangeEnd = 1208867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__6()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__Initialize_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208867, XrefRangeEnd = 1208871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__7()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__Initialize_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208871, XrefRangeEnd = 1208875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__8()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__Initialize_b__8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass45_0()
    {
      Il2CppClassPointerStore<NewServerListEntryComponent.__c__DisplayClass45_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewServerListEntryComponent>.NativeClassPtr, "<>c__DisplayClass45_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewServerListEntryComponent.__c__DisplayClass45_0>.NativeClassPtr);
      NewServerListEntryComponent.__c__DisplayClass45_0.NativeFieldInfoPtr_onClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent.__c__DisplayClass45_0>.NativeClassPtr, nameof (onClick));
      NewServerListEntryComponent.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent.__c__DisplayClass45_0>.NativeClassPtr, "<>4__this");
      NewServerListEntryComponent.__c__DisplayClass45_0.NativeFieldInfoPtr_onDeleteClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewServerListEntryComponent.__c__DisplayClass45_0>.NativeClassPtr, nameof (onDeleteClicked));
      NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewServerListEntryComponent.__c__DisplayClass45_0>.NativeClassPtr, 100663556);
      NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewServerListEntryComponent.__c__DisplayClass45_0>.NativeClassPtr, 100663557);
      NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__Initialize_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewServerListEntryComponent.__c__DisplayClass45_0>.NativeClassPtr, 100663558);
      NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__Initialize_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewServerListEntryComponent.__c__DisplayClass45_0>.NativeClassPtr, 100663559);
      NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__Initialize_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewServerListEntryComponent.__c__DisplayClass45_0>.NativeClassPtr, 100663560);
      NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__Initialize_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewServerListEntryComponent.__c__DisplayClass45_0>.NativeClassPtr, 100663561);
      NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__Initialize_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewServerListEntryComponent.__c__DisplayClass45_0>.NativeClassPtr, 100663562);
      NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__Initialize_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewServerListEntryComponent.__c__DisplayClass45_0>.NativeClassPtr, 100663563);
      NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__Initialize_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewServerListEntryComponent.__c__DisplayClass45_0>.NativeClassPtr, 100663564);
      NewServerListEntryComponent.__c__DisplayClass45_0.NativeMethodInfoPtr__Initialize_b__8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewServerListEntryComponent.__c__DisplayClass45_0>.NativeClassPtr, 100663565);
    }

    public __c__DisplayClass45_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppSystem.Action<NewServerListEntryComponent> onClick
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.__c__DisplayClass45_0.NativeFieldInfoPtr_onClick));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<NewServerListEntryComponent>) null : new Il2CppSystem.Action<NewServerListEntryComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.__c__DisplayClass45_0.NativeFieldInfoPtr_onClick), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NewServerListEntryComponent __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (NewServerListEntryComponent) null : new NewServerListEntryComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<NewServerListEntryComponent> onDeleteClicked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.__c__DisplayClass45_0.NativeFieldInfoPtr_onDeleteClicked));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<NewServerListEntryComponent>) null : new Il2CppSystem.Action<NewServerListEntryComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewServerListEntryComponent.__c__DisplayClass45_0.NativeFieldInfoPtr_onDeleteClicked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
