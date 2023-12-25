// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ServerListEntryComponent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Network;
using StunShared.UI;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ServerListEntryComponent : UIEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Background;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasCharacterIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerNameText;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayersText;
    private static readonly System.IntPtr NativeFieldInfoPtr_TotalPlayersText;
    private static readonly System.IntPtr NativeFieldInfoPtr_LatencyText;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayText;
    private static readonly System.IntPtr NativeFieldInfoPtr_VersionText;
    private static readonly System.IntPtr NativeFieldInfoPtr_NormalFont;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoveredFont;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedFont;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoveredGameObjects;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnhoveredGameObjects;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedGameObjects;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeSelectedGameObjects;
    private static readonly System.IntPtr NativeFieldInfoPtr_Targets;
    private static readonly System.IntPtr NativeFieldInfoPtr_NormalTargetColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoverTargetColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedTargetColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisabledTargetColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_ErrorColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_LineColors;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnEntrySelected;
    private static readonly System.IntPtr NativeFieldInfoPtr__Selected;
    private static readonly System.IntPtr NativeFieldInfoPtr__EntryIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerData;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsFull;
    private static readonly System.IntPtr NativeFieldInfoPtr__VersionMismatch;
    private static readonly System.IntPtr NativeFieldInfoPtr__HasCharacter;
    private static readonly System.IntPtr NativeFieldInfoPtr__Hover;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerNameText;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlayersText;
    private static readonly System.IntPtr NativeFieldInfoPtr__TotalPlayersText;
    private static readonly System.IntPtr NativeFieldInfoPtr__LatencyText;
    private static readonly System.IntPtr NativeFieldInfoPtr__DayText;
    private static readonly System.IntPtr NativeFieldInfoPtr__VersionText;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Selected_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Selected_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ServerData_Public_get_ServerDiscoveryData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_Int32_ServerListDataEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_Int32_ServerDiscoveryData_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool Selected
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListEntryComponent.NativeMethodInfoPtr_get_Selected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerListEntryComponent.NativeMethodInfoPtr_set_Selected_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ServerDiscoveryData ServerData
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287272, XrefRangeEnd = 1287273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ServerListEntryComponent.NativeMethodInfoPtr_get_ServerData_Public_get_ServerDiscoveryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new ServerDiscoveryData(pointer);
      }
    }

    [CallerCount(0)]
    public virtual unsafe void OnPointerEnter(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListEntryComponent.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void OnPointerExit(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListEntryComponent.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287273, XrefRangeEnd = 1287279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnSelect(BaseEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListEntryComponent.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287279, XrefRangeEnd = 1287285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnDeselect(BaseEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListEntryComponent.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287285, XrefRangeEnd = 1287288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnPointerClick(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListEntryComponent.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void SetData(int index, ServerListDataEntry server)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) server);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListEntryComponent.NativeMethodInfoPtr_SetData_Public_Void_Int32_ServerListDataEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1287319, RefRangeEnd = 1287320, XrefRangeStart = 1287288, XrefRangeEnd = 1287319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(int index, ServerDiscoveryData serverData, int gameVersion)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) serverData));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &gameVersion;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListEntryComponent.NativeMethodInfoPtr_SetData_Public_Void_Int32_ServerDiscoveryData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287320, XrefRangeEnd = 1287343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListEntryComponent.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerListEntryComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListEntryComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerListEntryComponent()
    {
      Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ServerListEntryComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr);
      ServerListEntryComponent.NativeFieldInfoPtr_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (Background));
      ServerListEntryComponent.NativeFieldInfoPtr_HasCharacterIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (HasCharacterIcon));
      ServerListEntryComponent.NativeFieldInfoPtr_ServerNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (ServerNameText));
      ServerListEntryComponent.NativeFieldInfoPtr_PlayersText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (PlayersText));
      ServerListEntryComponent.NativeFieldInfoPtr_TotalPlayersText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (TotalPlayersText));
      ServerListEntryComponent.NativeFieldInfoPtr_LatencyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (LatencyText));
      ServerListEntryComponent.NativeFieldInfoPtr_DayText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (DayText));
      ServerListEntryComponent.NativeFieldInfoPtr_VersionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (VersionText));
      ServerListEntryComponent.NativeFieldInfoPtr_NormalFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (NormalFont));
      ServerListEntryComponent.NativeFieldInfoPtr_HoveredFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (HoveredFont));
      ServerListEntryComponent.NativeFieldInfoPtr_SelectedFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (SelectedFont));
      ServerListEntryComponent.NativeFieldInfoPtr_HoveredGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (HoveredGameObjects));
      ServerListEntryComponent.NativeFieldInfoPtr_UnhoveredGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (UnhoveredGameObjects));
      ServerListEntryComponent.NativeFieldInfoPtr_SelectedGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (SelectedGameObjects));
      ServerListEntryComponent.NativeFieldInfoPtr_DeSelectedGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (DeSelectedGameObjects));
      ServerListEntryComponent.NativeFieldInfoPtr_Targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (Targets));
      ServerListEntryComponent.NativeFieldInfoPtr_NormalTargetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (NormalTargetColor));
      ServerListEntryComponent.NativeFieldInfoPtr_HoverTargetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (HoverTargetColor));
      ServerListEntryComponent.NativeFieldInfoPtr_SelectedTargetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (SelectedTargetColor));
      ServerListEntryComponent.NativeFieldInfoPtr_DisabledTargetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (DisabledTargetColor));
      ServerListEntryComponent.NativeFieldInfoPtr_ErrorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (ErrorColor));
      ServerListEntryComponent.NativeFieldInfoPtr_LineColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (LineColors));
      ServerListEntryComponent.NativeFieldInfoPtr_OnEntrySelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (OnEntrySelected));
      ServerListEntryComponent.NativeFieldInfoPtr__Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (_Selected));
      ServerListEntryComponent.NativeFieldInfoPtr__EntryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (_EntryIndex));
      ServerListEntryComponent.NativeFieldInfoPtr__ServerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (_ServerData));
      ServerListEntryComponent.NativeFieldInfoPtr__IsFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (_IsFull));
      ServerListEntryComponent.NativeFieldInfoPtr__VersionMismatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (_VersionMismatch));
      ServerListEntryComponent.NativeFieldInfoPtr__HasCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (_HasCharacter));
      ServerListEntryComponent.NativeFieldInfoPtr__Hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (_Hover));
      ServerListEntryComponent.NativeFieldInfoPtr__ServerNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (_ServerNameText));
      ServerListEntryComponent.NativeFieldInfoPtr__PlayersText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (_PlayersText));
      ServerListEntryComponent.NativeFieldInfoPtr__TotalPlayersText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (_TotalPlayersText));
      ServerListEntryComponent.NativeFieldInfoPtr__LatencyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (_LatencyText));
      ServerListEntryComponent.NativeFieldInfoPtr__DayText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (_DayText));
      ServerListEntryComponent.NativeFieldInfoPtr__VersionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, nameof (_VersionText));
      ServerListEntryComponent.NativeMethodInfoPtr_get_Selected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, 100669510);
      ServerListEntryComponent.NativeMethodInfoPtr_set_Selected_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, 100669511);
      ServerListEntryComponent.NativeMethodInfoPtr_get_ServerData_Public_get_ServerDiscoveryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, 100669512);
      ServerListEntryComponent.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, 100669513);
      ServerListEntryComponent.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, 100669514);
      ServerListEntryComponent.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, 100669515);
      ServerListEntryComponent.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, 100669516);
      ServerListEntryComponent.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, 100669517);
      ServerListEntryComponent.NativeMethodInfoPtr_SetData_Public_Void_Int32_ServerListDataEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, 100669518);
      ServerListEntryComponent.NativeMethodInfoPtr_SetData_Public_Void_Int32_ServerDiscoveryData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, 100669519);
      ServerListEntryComponent.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, 100669520);
      ServerListEntryComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListEntryComponent>.NativeClassPtr, 100669521);
    }

    public ServerListEntryComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image Background
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_Background));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_Background), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image HasCharacterIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_HasCharacterIcon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_HasCharacterIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ServerNameText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_ServerNameText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_ServerNameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text PlayersText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_PlayersText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_PlayersText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text TotalPlayersText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_TotalPlayersText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_TotalPlayersText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text LatencyText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_LatencyText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_LatencyText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text DayText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_DayText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_DayText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text VersionText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_VersionText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_VersionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_FontAsset NormalFont
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_NormalFont));
        return pointer == System.IntPtr.Zero ? (TMP_FontAsset) null : new TMP_FontAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_NormalFont), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_FontAsset HoveredFont
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_HoveredFont));
        return pointer == System.IntPtr.Zero ? (TMP_FontAsset) null : new TMP_FontAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_HoveredFont), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_FontAsset SelectedFont
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_SelectedFont));
        return pointer == System.IntPtr.Zero ? (TMP_FontAsset) null : new TMP_FontAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_SelectedFont), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<GameObject> HoveredGameObjects
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_HoveredGameObjects));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_HoveredGameObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<GameObject> UnhoveredGameObjects
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_UnhoveredGameObjects));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_UnhoveredGameObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<GameObject> SelectedGameObjects
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_SelectedGameObjects));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_SelectedGameObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<GameObject> DeSelectedGameObjects
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_DeSelectedGameObjects));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_DeSelectedGameObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<Graphic> Targets
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_Targets));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Graphic>) null : new Il2CppReferenceArray<Graphic>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_Targets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color NormalTargetColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_NormalTargetColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_NormalTargetColor)) = value;
      }
    }

    public unsafe Color HoverTargetColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_HoverTargetColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_HoverTargetColor)) = value;
      }
    }

    public unsafe Color SelectedTargetColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_SelectedTargetColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_SelectedTargetColor)) = value;
      }
    }

    public unsafe Color DisabledTargetColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_DisabledTargetColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_DisabledTargetColor)) = value;
      }
    }

    public unsafe Color ErrorColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_ErrorColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_ErrorColor)) = value;
      }
    }

    public unsafe Il2CppStructArray<Color> LineColors
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_LineColors));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Color>) null : new Il2CppStructArray<Color>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_LineColors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<ServerListEntryComponent, int> OnEntrySelected
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_OnEntrySelected));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ServerListEntryComponent, int>) null : new Il2CppSystem.Action<ServerListEntryComponent, int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr_OnEntrySelected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _Selected
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__Selected));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__Selected)) = value;
      }
    }

    public unsafe int _EntryIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__EntryIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__EntryIndex)) = value;
      }
    }

    public ServerDiscoveryData _ServerData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__ServerData);
        return new ServerDiscoveryData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__ServerData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool _IsFull
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__IsFull));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__IsFull)) = value;
      }
    }

    public unsafe bool _VersionMismatch
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__VersionMismatch));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__VersionMismatch)) = value;
      }
    }

    public unsafe bool _HasCharacter
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__HasCharacter));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__HasCharacter)) = value;
      }
    }

    public unsafe bool _Hover
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__Hover));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__Hover)) = value;
      }
    }

    public MemoizedFixedString512 _ServerNameText
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__ServerNameText);
        return new MemoizedFixedString512(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedFixedString512>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__ServerNameText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedFixedString512>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public MemoizedInteger2Text _PlayersText
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__PlayersText);
        return new MemoizedInteger2Text(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedInteger2Text>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__PlayersText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedInteger2Text>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public MemoizedIntegerText _TotalPlayersText
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__TotalPlayersText);
        return new MemoizedIntegerText(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__TotalPlayersText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public MemoizedIntegerText _LatencyText
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__LatencyText);
        return new MemoizedIntegerText(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__LatencyText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public MemoizedIntegerText _DayText
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__DayText);
        return new MemoizedIntegerText(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__DayText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public MemoizedIntegerText _VersionText
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__VersionText);
        return new MemoizedIntegerText(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryComponent.NativeFieldInfoPtr__VersionText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
