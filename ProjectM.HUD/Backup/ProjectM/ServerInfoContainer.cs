// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerInfoContainer
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.UI;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM
{
  public class ServerInfoContainer : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SettingsLocalizationMapping;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameText;
    private static readonly System.IntPtr NativeFieldInfoPtr_DescriptionParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_DescriptionText;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameModeText;
    private static readonly System.IntPtr NativeFieldInfoPtr_HardcoreIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayersText;
    private static readonly System.IntPtr NativeFieldInfoPtr_DaysPlayedText;
    private static readonly System.IntPtr NativeFieldInfoPtr_DaysUntilResetText;
    private static readonly System.IntPtr NativeFieldInfoPtr_LatencyText;
    private static readonly System.IntPtr NativeFieldInfoPtr_StandardSettingsIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_DedicatedServerIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasCharacterIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_FriendsPlayingIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_MoreDetailsButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerInfoRect;
    private static readonly System.IntPtr NativeFieldInfoPtr_NoServerSelectedRect;
    private static readonly System.IntPtr NativeFieldInfoPtr_PasswordRoot;
    private static readonly System.IntPtr NativeFieldInfoPtr_PasswordInputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_TogglePasswordButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayersRoot;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayersInputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_LANHostToggleRoot;
    private static readonly System.IntPtr NativeFieldInfoPtr_LANHostToggle;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScarySettingsParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodBoundItems;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodFountainDestroyMode;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_Nullable_1_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1211632, RefRangeEnd = 1211634, XrefRangeStart = 1211516, XrefRangeEnd = 1211632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(Il2CppSystem.Nullable<ServerInfoContainer.Data> d)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) d));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerInfoContainer.NativeMethodInfoPtr_SetData_Public_Void_Nullable_1_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerInfoContainer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerInfoContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerInfoContainer()
    {
      Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM", nameof (ServerInfoContainer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr);
      ServerInfoContainer.NativeFieldInfoPtr_SettingsLocalizationMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (SettingsLocalizationMapping));
      ServerInfoContainer.NativeFieldInfoPtr_NameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (NameText));
      ServerInfoContainer.NativeFieldInfoPtr_DescriptionParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (DescriptionParent));
      ServerInfoContainer.NativeFieldInfoPtr_DescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (DescriptionText));
      ServerInfoContainer.NativeFieldInfoPtr_GameModeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (GameModeText));
      ServerInfoContainer.NativeFieldInfoPtr_HardcoreIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (HardcoreIcon));
      ServerInfoContainer.NativeFieldInfoPtr_PlayersText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (PlayersText));
      ServerInfoContainer.NativeFieldInfoPtr_DaysPlayedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (DaysPlayedText));
      ServerInfoContainer.NativeFieldInfoPtr_DaysUntilResetText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (DaysUntilResetText));
      ServerInfoContainer.NativeFieldInfoPtr_LatencyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (LatencyText));
      ServerInfoContainer.NativeFieldInfoPtr_StandardSettingsIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (StandardSettingsIcon));
      ServerInfoContainer.NativeFieldInfoPtr_DedicatedServerIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (DedicatedServerIcon));
      ServerInfoContainer.NativeFieldInfoPtr_HasCharacterIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (HasCharacterIcon));
      ServerInfoContainer.NativeFieldInfoPtr_FriendsPlayingIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (FriendsPlayingIcon));
      ServerInfoContainer.NativeFieldInfoPtr_MoreDetailsButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (MoreDetailsButton));
      ServerInfoContainer.NativeFieldInfoPtr_ServerInfoRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (ServerInfoRect));
      ServerInfoContainer.NativeFieldInfoPtr_NoServerSelectedRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (NoServerSelectedRect));
      ServerInfoContainer.NativeFieldInfoPtr_PasswordRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (PasswordRoot));
      ServerInfoContainer.NativeFieldInfoPtr_PasswordInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (PasswordInputField));
      ServerInfoContainer.NativeFieldInfoPtr_TogglePasswordButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (TogglePasswordButton));
      ServerInfoContainer.NativeFieldInfoPtr_PlayersRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (PlayersRoot));
      ServerInfoContainer.NativeFieldInfoPtr_PlayersInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (PlayersInputField));
      ServerInfoContainer.NativeFieldInfoPtr_LANHostToggleRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (LANHostToggleRoot));
      ServerInfoContainer.NativeFieldInfoPtr_LANHostToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (LANHostToggle));
      ServerInfoContainer.NativeFieldInfoPtr_ScarySettingsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (ScarySettingsParent));
      ServerInfoContainer.NativeFieldInfoPtr_BloodBoundItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (BloodBoundItems));
      ServerInfoContainer.NativeFieldInfoPtr_BloodFountainDestroyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (BloodFountainDestroyMode));
      ServerInfoContainer.NativeMethodInfoPtr_SetData_Public_Void_Nullable_1_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, 100663766);
      ServerInfoContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, 100663767);
    }

    public ServerInfoContainer(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameBalanceSettingsMapping SettingsLocalizationMapping
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_SettingsLocalizationMapping));
        return pointer == System.IntPtr.Zero ? (GameBalanceSettingsMapping) null : new GameBalanceSettingsMapping(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_SettingsLocalizationMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text NameText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_NameText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_NameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform DescriptionParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_DescriptionParent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_DescriptionParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text DescriptionText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_DescriptionText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_DescriptionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText GameModeText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_GameModeText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_GameModeText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton HardcoreIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_HardcoreIcon));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_HardcoreIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText PlayersText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_PlayersText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_PlayersText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText DaysPlayedText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_DaysPlayedText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_DaysPlayedText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText DaysUntilResetText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_DaysUntilResetText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_DaysUntilResetText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText LatencyText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_LatencyText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_LatencyText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton StandardSettingsIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_StandardSettingsIcon));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_StandardSettingsIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton DedicatedServerIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_DedicatedServerIcon));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_DedicatedServerIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton HasCharacterIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_HasCharacterIcon));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_HasCharacterIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton FriendsPlayingIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_FriendsPlayingIcon));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_FriendsPlayingIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton MoreDetailsButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_MoreDetailsButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_MoreDetailsButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ServerInfoRect
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_ServerInfoRect));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_ServerInfoRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform NoServerSelectedRect
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_NoServerSelectedRect));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_NoServerSelectedRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform PasswordRoot
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_PasswordRoot));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_PasswordRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField PasswordInputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_PasswordInputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_PasswordInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TogglePasswordButton TogglePasswordButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_TogglePasswordButton));
        return pointer == System.IntPtr.Zero ? (TogglePasswordButton) null : new TogglePasswordButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_TogglePasswordButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform PlayersRoot
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_PlayersRoot));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_PlayersRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField PlayersInputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_PlayersInputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_PlayersInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform LANHostToggleRoot
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_LANHostToggleRoot));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_LANHostToggleRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle LANHostToggle
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_LANHostToggle));
        return pointer == System.IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_LANHostToggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ScarySettingsParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_ScarySettingsParent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_ScarySettingsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText BloodBoundItems
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_BloodBoundItems));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_BloodBoundItems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText BloodFountainDestroyMode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_BloodFountainDestroyMode));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.NativeFieldInfoPtr_BloodFountainDestroyMode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_Description;
      private static readonly System.IntPtr NativeFieldInfoPtr_Password;
      private static readonly System.IntPtr NativeFieldInfoPtr_ShowPassword;
      private static readonly System.IntPtr NativeFieldInfoPtr_StreamerMode;
      private static readonly System.IntPtr NativeFieldInfoPtr_SetPasswordFocus;
      private static readonly System.IntPtr NativeFieldInfoPtr_GameModeType;
      private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeartDamageMode;
      private static readonly System.IntPtr NativeFieldInfoPtr_Latency;
      private static readonly System.IntPtr NativeFieldInfoPtr_CurrentPlayers;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxPlayers;
      private static readonly System.IntPtr NativeFieldInfoPtr_DaysPlayed;
      private static readonly System.IntPtr NativeFieldInfoPtr_DaysUntilReset;
      private static readonly System.IntPtr NativeFieldInfoPtr_HostMaxPlayers;
      private static readonly System.IntPtr NativeFieldInfoPtr_HostIsLAN;
      private static readonly System.IntPtr NativeFieldInfoPtr_CanSetPassword;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsHardCore;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasStandardSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsDedicatedServer;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasCharacter;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasFriends;
      private static readonly System.IntPtr NativeFieldInfoPtr_BloodBoundEnabled;

      static Data()
      {
        Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerInfoContainer>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr);
        ServerInfoContainer.Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (Name));
        ServerInfoContainer.Data.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (Description));
        ServerInfoContainer.Data.NativeFieldInfoPtr_Password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (Password));
        ServerInfoContainer.Data.NativeFieldInfoPtr_ShowPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (ShowPassword));
        ServerInfoContainer.Data.NativeFieldInfoPtr_StreamerMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (StreamerMode));
        ServerInfoContainer.Data.NativeFieldInfoPtr_SetPasswordFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (SetPasswordFocus));
        ServerInfoContainer.Data.NativeFieldInfoPtr_GameModeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (GameModeType));
        ServerInfoContainer.Data.NativeFieldInfoPtr_CastleHeartDamageMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (CastleHeartDamageMode));
        ServerInfoContainer.Data.NativeFieldInfoPtr_Latency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (Latency));
        ServerInfoContainer.Data.NativeFieldInfoPtr_CurrentPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (CurrentPlayers));
        ServerInfoContainer.Data.NativeFieldInfoPtr_MaxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (MaxPlayers));
        ServerInfoContainer.Data.NativeFieldInfoPtr_DaysPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (DaysPlayed));
        ServerInfoContainer.Data.NativeFieldInfoPtr_DaysUntilReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (DaysUntilReset));
        ServerInfoContainer.Data.NativeFieldInfoPtr_HostMaxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (HostMaxPlayers));
        ServerInfoContainer.Data.NativeFieldInfoPtr_HostIsLAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (HostIsLAN));
        ServerInfoContainer.Data.NativeFieldInfoPtr_CanSetPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (CanSetPassword));
        ServerInfoContainer.Data.NativeFieldInfoPtr_IsHardCore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (IsHardCore));
        ServerInfoContainer.Data.NativeFieldInfoPtr_HasStandardSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (HasStandardSettings));
        ServerInfoContainer.Data.NativeFieldInfoPtr_IsDedicatedServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (IsDedicatedServer));
        ServerInfoContainer.Data.NativeFieldInfoPtr_HasCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (HasCharacter));
        ServerInfoContainer.Data.NativeFieldInfoPtr_HasFriends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (HasFriends));
        ServerInfoContainer.Data.NativeFieldInfoPtr_BloodBoundEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, nameof (BloodBoundEnabled));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerInfoContainer.Data>.NativeClassPtr, data));
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string Description
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_Description)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string Password
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_Password)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_Password), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe bool ShowPassword
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_ShowPassword));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_ShowPassword)) = value;
        }
      }

      public unsafe bool StreamerMode
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_StreamerMode));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_StreamerMode)) = value;
        }
      }

      public unsafe bool SetPasswordFocus
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_SetPasswordFocus));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_SetPasswordFocus)) = value;
        }
      }

      public unsafe GameModeType GameModeType
      {
        get
        {
          return *(GameModeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_GameModeType));
        }
        [param: In] set
        {
          *(GameModeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_GameModeType)) = value;
        }
      }

      public unsafe Nullable_Unboxed<CastleHeartDamageMode> CastleHeartDamageMode
      {
        get
        {
          return *(Nullable_Unboxed<CastleHeartDamageMode>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_CastleHeartDamageMode));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_CastleHeartDamageMode), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<CastleHeartDamageMode>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Nullable_Unboxed<int> Latency
      {
        get
        {
          return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_Latency));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_Latency), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Nullable_Unboxed<int> CurrentPlayers
      {
        get
        {
          return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_CurrentPlayers));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_CurrentPlayers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Nullable_Unboxed<int> MaxPlayers
      {
        get
        {
          return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_MaxPlayers));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_MaxPlayers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Nullable_Unboxed<int> DaysPlayed
      {
        get
        {
          return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_DaysPlayed));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_DaysPlayed), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Nullable_Unboxed<int> DaysUntilReset
      {
        get
        {
          return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_DaysUntilReset));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_DaysUntilReset), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Nullable_Unboxed<int> HostMaxPlayers
      {
        get
        {
          return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_HostMaxPlayers));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_HostMaxPlayers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Nullable_Unboxed<bool> HostIsLAN
      {
        get
        {
          return *(Nullable_Unboxed<bool>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_HostIsLAN));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_HostIsLAN), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe bool CanSetPassword
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_CanSetPassword));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_CanSetPassword)) = value;
        }
      }

      public unsafe bool IsHardCore
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_IsHardCore));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_IsHardCore)) = value;
        }
      }

      public unsafe bool HasStandardSettings
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_HasStandardSettings));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_HasStandardSettings)) = value;
        }
      }

      public unsafe bool IsDedicatedServer
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_IsDedicatedServer));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_IsDedicatedServer)) = value;
        }
      }

      public unsafe bool HasCharacter
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_HasCharacter));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_HasCharacter)) = value;
        }
      }

      public unsafe bool HasFriends
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_HasFriends));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_HasFriends)) = value;
        }
      }

      public unsafe Nullable_Unboxed<bool> BloodBoundEnabled
      {
        get
        {
          return *(Nullable_Unboxed<bool>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_BloodBoundEnabled));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerInfoContainer.Data.NativeFieldInfoPtr_BloodBoundEnabled), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }
}
