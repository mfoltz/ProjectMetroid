// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.PlaySelectMenuView
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class PlaySelectMenuView : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SoloCoopButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_HostServerButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_JoinGuideButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_JoinAdvancedButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_BackButton;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedGameMode;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_JoinGuideButton_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_JoinAdvancedButton_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SoloCoopButton_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HostServerButton_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitInitData_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GoBack_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285507, XrefRangeEnd = 1285539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectMenuView.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285539, XrefRangeEnd = 1285544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void JoinGuideButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectMenuView.NativeMethodInfoPtr_JoinGuideButton_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285544, XrefRangeEnd = 1285554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void JoinAdvancedButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectMenuView.NativeMethodInfoPtr_JoinAdvancedButton_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285554, XrefRangeEnd = 1285560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SoloCoopButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectMenuView.NativeMethodInfoPtr_SoloCoopButton_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285560, XrefRangeEnd = 1285566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HostServerButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectMenuView.NativeMethodInfoPtr_HostServerButton_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285566, XrefRangeEnd = 1285573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectMenuView.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1285601, RefRangeEnd = 1285602, XrefRangeStart = 1285573, XrefRangeEnd = 1285601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitInitData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectMenuView.NativeMethodInfoPtr_InitInitData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285602, XrefRangeEnd = 1285615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectMenuView.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectMenuView.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(PlaySelectMenuView.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectMenuView.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GoBack()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectMenuView.NativeMethodInfoPtr_GoBack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlaySelectMenuView()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySelectMenuView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlaySelectMenuView()
    {
      Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (PlaySelectMenuView));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr);
      PlaySelectMenuView.NativeFieldInfoPtr_SoloCoopButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, nameof (SoloCoopButton));
      PlaySelectMenuView.NativeFieldInfoPtr_HostServerButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, nameof (HostServerButton));
      PlaySelectMenuView.NativeFieldInfoPtr_JoinGuideButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, nameof (JoinGuideButton));
      PlaySelectMenuView.NativeFieldInfoPtr_JoinAdvancedButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, nameof (JoinAdvancedButton));
      PlaySelectMenuView.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, nameof (BackButton));
      PlaySelectMenuView.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, nameof (_InputSystem));
      PlaySelectMenuView.NativeFieldInfoPtr__SelectedGameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, nameof (_SelectedGameMode));
      PlaySelectMenuView.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, 100669410);
      PlaySelectMenuView.NativeMethodInfoPtr_JoinGuideButton_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, 100669411);
      PlaySelectMenuView.NativeMethodInfoPtr_JoinAdvancedButton_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, 100669412);
      PlaySelectMenuView.NativeMethodInfoPtr_SoloCoopButton_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, 100669413);
      PlaySelectMenuView.NativeMethodInfoPtr_HostServerButton_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, 100669414);
      PlaySelectMenuView.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, 100669415);
      PlaySelectMenuView.NativeMethodInfoPtr_InitInitData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, 100669416);
      PlaySelectMenuView.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, 100669417);
      PlaySelectMenuView.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, 100669418);
      PlaySelectMenuView.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, 100669419);
      PlaySelectMenuView.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, 100669420);
      PlaySelectMenuView.NativeMethodInfoPtr_GoBack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, 100669421);
      PlaySelectMenuView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, 100669422);
    }

    public PlaySelectMenuView(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SimpleStunButton SoloCoopButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectMenuView.NativeFieldInfoPtr_SoloCoopButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectMenuView.NativeFieldInfoPtr_SoloCoopButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton HostServerButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectMenuView.NativeFieldInfoPtr_HostServerButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectMenuView.NativeFieldInfoPtr_HostServerButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton JoinGuideButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectMenuView.NativeFieldInfoPtr_JoinGuideButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectMenuView.NativeFieldInfoPtr_JoinGuideButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton JoinAdvancedButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectMenuView.NativeFieldInfoPtr_JoinAdvancedButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectMenuView.NativeFieldInfoPtr_JoinAdvancedButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton BackButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectMenuView.NativeFieldInfoPtr_BackButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectMenuView.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectMenuView.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectMenuView.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameModeSelectionFlow _SelectedGameMode
    {
      get
      {
        return *(GameModeSelectionFlow*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectMenuView.NativeFieldInfoPtr__SelectedGameMode));
      }
      [param: In] set
      {
        *(GameModeSelectionFlow*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySelectMenuView.NativeFieldInfoPtr__SelectedGameMode)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InitData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_GameMode;
      [FieldOffset(0)]
      public GameModeSelectionFlow GameMode;

      static InitData()
      {
        Il2CppClassPointerStore<PlaySelectMenuView.InitData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlaySelectMenuView>.NativeClassPtr, nameof (InitData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaySelectMenuView.InitData>.NativeClassPtr);
        PlaySelectMenuView.InitData.NativeFieldInfoPtr_GameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySelectMenuView.InitData>.NativeClassPtr, nameof (GameMode));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlaySelectMenuView.InitData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
