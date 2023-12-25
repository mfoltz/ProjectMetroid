// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.PlaySelectModeMenuView
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class PlaySelectModeMenuView : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GameModePVE_Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameModePVP_Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameModeFullLootPVP_Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameModeSoloPVP_Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameModeDuoPVP_Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanSize1Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanSize2Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanSize4Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_BackButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_FindServersButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameModeHeaderText;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameModeDescriptionText;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanSizeText;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Default_Header;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_GameMode_PvE_Header;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_GameMode_PvP_Header;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_GameMode_FullLootPvp_Header;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_GameMode_SoloPvP_Header;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_GameMode_DuoPvP_Header;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Default_Description;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_GameMode_PvE;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_GameMode_PvP;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_GameMode_FullLootPvp;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_GameMode_SoloPvP;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_GameMode_DuoPvP;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ClanSize_PvP;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ClanSize_PvE;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ClanSize_PvPlus;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedGameMode2;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedClanSize;
    private static readonly System.IntPtr NativeFieldInfoPtr__TimeSet;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStuff_Private_Void_SimpleStunButton_GameModeSelectionFlow2_ClanSizeFilterSetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindServersButton_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GameModeButton_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGotoFindServers_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GoBack_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285615, XrefRangeEnd = 1285654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectModeMenuView.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285654, XrefRangeEnd = 1285671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetStuff(
      SimpleStunButton button,
      GameModeSelectionFlow2 gameMode,
      ClanSizeFilterSetting clanSize)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) button);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gameMode;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &clanSize;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectModeMenuView.NativeMethodInfoPtr_SetStuff_Private_Void_SimpleStunButton_GameModeSelectionFlow2_ClanSizeFilterSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285671, XrefRangeEnd = 1285674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectModeMenuView.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285674, XrefRangeEnd = 1285680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FindServersButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectModeMenuView.NativeMethodInfoPtr_FindServersButton_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285680, XrefRangeEnd = 1285696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GameModeButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectModeMenuView.NativeMethodInfoPtr_GameModeButton_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TryGotoFindServers()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectModeMenuView.NativeMethodInfoPtr_TryGotoFindServers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285696, XrefRangeEnd = 1285702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectModeMenuView.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285702, XrefRangeEnd = 1285704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectModeMenuView.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetConsumedInputs(ref BlockInputState blockInputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref blockInputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectModeMenuView.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285704, XrefRangeEnd = 1285706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectModeMenuView.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GoBack()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectModeMenuView.NativeMethodInfoPtr_GoBack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlaySelectModeMenuView()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectModeMenuView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlaySelectModeMenuView()
    {
      Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (PlaySelectModeMenuView));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr);
      PlaySelectModeMenuView.NativeFieldInfoPtr_GameModePVE_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (GameModePVE_Button));
      PlaySelectModeMenuView.NativeFieldInfoPtr_GameModePVP_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (GameModePVP_Button));
      PlaySelectModeMenuView.NativeFieldInfoPtr_GameModeFullLootPVP_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (GameModeFullLootPVP_Button));
      PlaySelectModeMenuView.NativeFieldInfoPtr_GameModeSoloPVP_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (GameModeSoloPVP_Button));
      PlaySelectModeMenuView.NativeFieldInfoPtr_GameModeDuoPVP_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (GameModeDuoPVP_Button));
      PlaySelectModeMenuView.NativeFieldInfoPtr_ClanSize1Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (ClanSize1Button));
      PlaySelectModeMenuView.NativeFieldInfoPtr_ClanSize2Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (ClanSize2Button));
      PlaySelectModeMenuView.NativeFieldInfoPtr_ClanSize4Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (ClanSize4Button));
      PlaySelectModeMenuView.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (BackButton));
      PlaySelectModeMenuView.NativeFieldInfoPtr_FindServersButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (FindServersButton));
      PlaySelectModeMenuView.NativeFieldInfoPtr_GameModeHeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (GameModeHeaderText));
      PlaySelectModeMenuView.NativeFieldInfoPtr_GameModeDescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (GameModeDescriptionText));
      PlaySelectModeMenuView.NativeFieldInfoPtr_ClanSizeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (ClanSizeText));
      PlaySelectModeMenuView.NativeFieldInfoPtr_LK_Default_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (LK_Default_Header));
      PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_PvE_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (LK_GameMode_PvE_Header));
      PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_PvP_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (LK_GameMode_PvP_Header));
      PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_FullLootPvp_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (LK_GameMode_FullLootPvp_Header));
      PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_SoloPvP_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (LK_GameMode_SoloPvP_Header));
      PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_DuoPvP_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (LK_GameMode_DuoPvP_Header));
      PlaySelectModeMenuView.NativeFieldInfoPtr_LK_Default_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (LK_Default_Description));
      PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_PvE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (LK_GameMode_PvE));
      PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_PvP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (LK_GameMode_PvP));
      PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_FullLootPvp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (LK_GameMode_FullLootPvp));
      PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_SoloPvP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (LK_GameMode_SoloPvP));
      PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_DuoPvP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (LK_GameMode_DuoPvP));
      PlaySelectModeMenuView.NativeFieldInfoPtr_LK_ClanSize_PvP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (LK_ClanSize_PvP));
      PlaySelectModeMenuView.NativeFieldInfoPtr_LK_ClanSize_PvE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (LK_ClanSize_PvE));
      PlaySelectModeMenuView.NativeFieldInfoPtr_LK_ClanSize_PvPlus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (LK_ClanSize_PvPlus));
      PlaySelectModeMenuView.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (_InputSystem));
      PlaySelectModeMenuView.NativeFieldInfoPtr__SelectedGameMode2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (_SelectedGameMode2));
      PlaySelectModeMenuView.NativeFieldInfoPtr__SelectedClanSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (_SelectedClanSize));
      PlaySelectModeMenuView.NativeFieldInfoPtr__TimeSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, nameof (_TimeSet));
      PlaySelectModeMenuView.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, 100669423);
      PlaySelectModeMenuView.NativeMethodInfoPtr_SetStuff_Private_Void_SimpleStunButton_GameModeSelectionFlow2_ClanSizeFilterSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, 100669424);
      PlaySelectModeMenuView.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, 100669425);
      PlaySelectModeMenuView.NativeMethodInfoPtr_FindServersButton_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, 100669426);
      PlaySelectModeMenuView.NativeMethodInfoPtr_GameModeButton_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, 100669427);
      PlaySelectModeMenuView.NativeMethodInfoPtr_TryGotoFindServers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, 100669428);
      PlaySelectModeMenuView.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, 100669429);
      PlaySelectModeMenuView.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, 100669430);
      PlaySelectModeMenuView.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, 100669431);
      PlaySelectModeMenuView.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, 100669432);
      PlaySelectModeMenuView.NativeMethodInfoPtr_GoBack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, 100669433);
      PlaySelectModeMenuView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectModeMenuView>.NativeClassPtr, 100669434);
    }

    public PlaySelectModeMenuView(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SimpleStunButton GameModePVE_Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_GameModePVE_Button));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_GameModePVE_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton GameModePVP_Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_GameModePVP_Button));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_GameModePVP_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton GameModeFullLootPVP_Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_GameModeFullLootPVP_Button));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_GameModeFullLootPVP_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton GameModeSoloPVP_Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_GameModeSoloPVP_Button));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_GameModeSoloPVP_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton GameModeDuoPVP_Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_GameModeDuoPVP_Button));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_GameModeDuoPVP_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ClanSize1Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_ClanSize1Button));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_ClanSize1Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ClanSize2Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_ClanSize2Button));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_ClanSize2Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ClanSize4Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_ClanSize4Button));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_ClanSize4Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton BackButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_BackButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton FindServersButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_FindServersButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_FindServersButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText GameModeHeaderText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_GameModeHeaderText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_GameModeHeaderText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText GameModeDescriptionText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_GameModeDescriptionText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_GameModeDescriptionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ClanSizeText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_ClanSizeText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_ClanSizeText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_Default_Header
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_Default_Header));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_Default_Header)) = value;
      }
    }

    public unsafe LocalizationKey LK_GameMode_PvE_Header
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_PvE_Header));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_PvE_Header)) = value;
      }
    }

    public unsafe LocalizationKey LK_GameMode_PvP_Header
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_PvP_Header));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_PvP_Header)) = value;
      }
    }

    public unsafe LocalizationKey LK_GameMode_FullLootPvp_Header
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_FullLootPvp_Header));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_FullLootPvp_Header)) = value;
      }
    }

    public unsafe LocalizationKey LK_GameMode_SoloPvP_Header
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_SoloPvP_Header));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_SoloPvP_Header)) = value;
      }
    }

    public unsafe LocalizationKey LK_GameMode_DuoPvP_Header
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_DuoPvP_Header));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_DuoPvP_Header)) = value;
      }
    }

    public unsafe LocalizationKey LK_Default_Description
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_Default_Description));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_Default_Description)) = value;
      }
    }

    public unsafe LocalizationKey LK_GameMode_PvE
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_PvE));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_PvE)) = value;
      }
    }

    public unsafe LocalizationKey LK_GameMode_PvP
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_PvP));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_PvP)) = value;
      }
    }

    public unsafe LocalizationKey LK_GameMode_FullLootPvp
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_FullLootPvp));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_FullLootPvp)) = value;
      }
    }

    public unsafe LocalizationKey LK_GameMode_SoloPvP
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_SoloPvP));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_SoloPvP)) = value;
      }
    }

    public unsafe LocalizationKey LK_GameMode_DuoPvP
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_DuoPvP));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_GameMode_DuoPvP)) = value;
      }
    }

    public unsafe LocalizationKey LK_ClanSize_PvP
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_ClanSize_PvP));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_ClanSize_PvP)) = value;
      }
    }

    public unsafe LocalizationKey LK_ClanSize_PvE
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_ClanSize_PvE));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_ClanSize_PvE)) = value;
      }
    }

    public unsafe LocalizationKey LK_ClanSize_PvPlus
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_ClanSize_PvPlus));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr_LK_ClanSize_PvPlus)) = value;
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Nullable_Unboxed<GameModeSelectionFlow2> _SelectedGameMode2
    {
      get
      {
        return *(Nullable_Unboxed<GameModeSelectionFlow2>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr__SelectedGameMode2));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr__SelectedGameMode2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<GameModeSelectionFlow2>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<ClanSizeFilterSetting> _SelectedClanSize
    {
      get
      {
        return *(Nullable_Unboxed<ClanSizeFilterSetting>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr__SelectedClanSize));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr__SelectedClanSize), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<ClanSizeFilterSetting>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe float _TimeSet
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr__TimeSet));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectModeMenuView.NativeFieldInfoPtr__TimeSet)) = value;
      }
    }
  }
}
