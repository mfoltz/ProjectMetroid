// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ClanInvitePlayerEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Stunlock.Localization;
using StunShared.UI;
using System.Runtime.InteropServices;
using TMPro;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ClanInvitePlayerEntry : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Text;
    private static readonly System.IntPtr NativeFieldInfoPtr_RightPanel;
    private static readonly System.IntPtr NativeFieldInfoPtr_InviteParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_PanelButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_InviteButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_CancelButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_Motion;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_InvitePlayer;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_PendingInvite;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowInvitePanel;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnShowInvitePanel;
    private static readonly System.IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Internal_Static_Void_ClanInvitePlayerEntry_Data_ControllerType_GridSelectionGroup_2_ClanInvitePlayerEntry_Data_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__12_0_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__12_1_Private_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221120, XrefRangeEnd = 1221134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanInvitePlayerEntry.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221134, XrefRangeEnd = 1221139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanInvitePlayerEntry.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221139, XrefRangeEnd = 1221150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RefreshData(
      ClanInvitePlayerEntry entry,
      ClanInvitePlayerEntry.Data data,
      ControllerType controllerType,
      GridSelectionGroup<ClanInvitePlayerEntry, ClanInvitePlayerEntry.Data> parent,
      bool showPanel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &showPanel;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanInvitePlayerEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_ClanInvitePlayerEntry_Data_ControllerType_GridSelectionGroup_2_ClanInvitePlayerEntry_Data_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClanInvitePlayerEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanInvitePlayerEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221150, XrefRangeEnd = 1221154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__12_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanInvitePlayerEntry.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__12_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__12_1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanInvitePlayerEntry.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__12_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClanInvitePlayerEntry()
    {
      Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ClanInvitePlayerEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr);
      ClanInvitePlayerEntry.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr, nameof (Text));
      ClanInvitePlayerEntry.NativeFieldInfoPtr_RightPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr, nameof (RightPanel));
      ClanInvitePlayerEntry.NativeFieldInfoPtr_InviteParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr, nameof (InviteParent));
      ClanInvitePlayerEntry.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr, nameof (InputField));
      ClanInvitePlayerEntry.NativeFieldInfoPtr_PanelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr, nameof (PanelButton));
      ClanInvitePlayerEntry.NativeFieldInfoPtr_InviteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr, nameof (InviteButton));
      ClanInvitePlayerEntry.NativeFieldInfoPtr_CancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr, nameof (CancelButton));
      ClanInvitePlayerEntry.NativeFieldInfoPtr_Motion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr, nameof (Motion));
      ClanInvitePlayerEntry.NativeFieldInfoPtr_LKey_InvitePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr, nameof (LKey_InvitePlayer));
      ClanInvitePlayerEntry.NativeFieldInfoPtr_LKey_PendingInvite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr, nameof (LKey_PendingInvite));
      ClanInvitePlayerEntry.NativeFieldInfoPtr_ShowInvitePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr, nameof (ShowInvitePanel));
      ClanInvitePlayerEntry.NativeFieldInfoPtr_OnShowInvitePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr, nameof (OnShowInvitePanel));
      ClanInvitePlayerEntry.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr, 100664652);
      ClanInvitePlayerEntry.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr, 100664653);
      ClanInvitePlayerEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_ClanInvitePlayerEntry_Data_ControllerType_GridSelectionGroup_2_ClanInvitePlayerEntry_Data_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr, 100664654);
      ClanInvitePlayerEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr, 100664655);
      ClanInvitePlayerEntry.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__12_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr, 100664656);
      ClanInvitePlayerEntry.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__12_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr, 100664657);
    }

    public ClanInvitePlayerEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText Text
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_Text));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject RightPanel
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_RightPanel));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_RightPanel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject InviteParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_InviteParent));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_InviteParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField InputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_InputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Button PanelButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_PanelButton));
        return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_PanelButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton InviteButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_InviteButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_InviteButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton CancelButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_CancelButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_CancelButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DInOut Motion
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_Motion));
        return pointer == System.IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_Motion), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_InvitePlayer
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_LKey_InvitePlayer));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_LKey_InvitePlayer)) = value;
      }
    }

    public unsafe LocalizationKey LKey_PendingInvite
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_LKey_PendingInvite));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_LKey_PendingInvite)) = value;
      }
    }

    public unsafe bool ShowInvitePanel
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_ShowInvitePanel));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_ShowInvitePanel)) = value;
      }
    }

    public unsafe UnityAction OnShowInvitePanel
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_OnShowInvitePanel));
        return pointer == System.IntPtr.Zero ? (UnityAction) null : new UnityAction(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitePlayerEntry.NativeFieldInfoPtr_OnShowInvitePanel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Data
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_InvitedPlayer;
      private static readonly System.IntPtr NativeFieldInfoPtr_PendingTime;
      [FieldOffset(0)]
      public FixedString64 InvitedPlayer;
      [FieldOffset(64)]
      public Nullable_Unboxed<float> PendingTime;

      static Data()
      {
        Il2CppClassPointerStore<ClanInvitePlayerEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanInvitePlayerEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanInvitePlayerEntry.Data>.NativeClassPtr);
        ClanInvitePlayerEntry.Data.NativeFieldInfoPtr_InvitedPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitePlayerEntry.Data>.NativeClassPtr, nameof (InvitedPlayer));
        ClanInvitePlayerEntry.Data.NativeFieldInfoPtr_PendingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitePlayerEntry.Data>.NativeClassPtr, nameof (PendingTime));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanInvitePlayerEntry.Data>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
