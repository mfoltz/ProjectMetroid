// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ConnectionFeedbackSystem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using ProjectM.Replays;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public class ConnectionFeedbackSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr_ICON_MIN_TIME;
    private static readonly IntPtr NativeFieldInfoPtr_ICON_MAX_TIME;
    private static readonly IntPtr NativeFieldInfoPtr_POPUP_TIME;
    private static readonly IntPtr NativeFieldInfoPtr_POPUP_FRAMES;
    private static readonly IntPtr NativeFieldInfoPtr__ClientNetworkStateAccessor;
    private static readonly IntPtr NativeFieldInfoPtr__ClientReplayPlayerEnabledAccessor;
    private static readonly IntPtr NativeFieldInfoPtr__ClientBootstrapSystem;
    private static readonly IntPtr NativeFieldInfoPtr__UIDataSystem;
    private static readonly IntPtr NativeFieldInfoPtr__Icon;
    private static readonly IntPtr NativeFieldInfoPtr__Popup;
    private static readonly IntPtr NativeFieldInfoPtr__LostConnectionString;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnButtonClick_Private_Static_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221849, XrefRangeEnd = 1221868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConnectionFeedbackSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221868, XrefRangeEnd = 1221941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConnectionFeedbackSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221941, XrefRangeEnd = 1221942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnButtonClick()
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectionFeedbackSystem.NativeMethodInfoPtr_OnButtonClick_Private_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConnectionFeedbackSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionFeedbackSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectionFeedbackSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConnectionFeedbackSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ConnectionFeedbackSystem()
    {
      Il2CppClassPointerStore<ConnectionFeedbackSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ConnectionFeedbackSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionFeedbackSystem>.NativeClassPtr);
      ConnectionFeedbackSystem.NativeFieldInfoPtr_ICON_MIN_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionFeedbackSystem>.NativeClassPtr, nameof (ICON_MIN_TIME));
      ConnectionFeedbackSystem.NativeFieldInfoPtr_ICON_MAX_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionFeedbackSystem>.NativeClassPtr, nameof (ICON_MAX_TIME));
      ConnectionFeedbackSystem.NativeFieldInfoPtr_POPUP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionFeedbackSystem>.NativeClassPtr, nameof (POPUP_TIME));
      ConnectionFeedbackSystem.NativeFieldInfoPtr_POPUP_FRAMES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionFeedbackSystem>.NativeClassPtr, nameof (POPUP_FRAMES));
      ConnectionFeedbackSystem.NativeFieldInfoPtr__ClientNetworkStateAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionFeedbackSystem>.NativeClassPtr, nameof (_ClientNetworkStateAccessor));
      ConnectionFeedbackSystem.NativeFieldInfoPtr__ClientReplayPlayerEnabledAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionFeedbackSystem>.NativeClassPtr, nameof (_ClientReplayPlayerEnabledAccessor));
      ConnectionFeedbackSystem.NativeFieldInfoPtr__ClientBootstrapSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionFeedbackSystem>.NativeClassPtr, nameof (_ClientBootstrapSystem));
      ConnectionFeedbackSystem.NativeFieldInfoPtr__UIDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionFeedbackSystem>.NativeClassPtr, nameof (_UIDataSystem));
      ConnectionFeedbackSystem.NativeFieldInfoPtr__Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionFeedbackSystem>.NativeClassPtr, nameof (_Icon));
      ConnectionFeedbackSystem.NativeFieldInfoPtr__Popup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionFeedbackSystem>.NativeClassPtr, nameof (_Popup));
      ConnectionFeedbackSystem.NativeFieldInfoPtr__LostConnectionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionFeedbackSystem>.NativeClassPtr, nameof (_LostConnectionString));
      ConnectionFeedbackSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionFeedbackSystem>.NativeClassPtr, 100664720);
      ConnectionFeedbackSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionFeedbackSystem>.NativeClassPtr, 100664721);
      ConnectionFeedbackSystem.NativeMethodInfoPtr_OnButtonClick_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionFeedbackSystem>.NativeClassPtr, 100664722);
      ConnectionFeedbackSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionFeedbackSystem>.NativeClassPtr, 100664723);
      ConnectionFeedbackSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionFeedbackSystem>.NativeClassPtr, 100664724);
    }

    public ConnectionFeedbackSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe float ICON_MIN_TIME
    {
      get
      {
        float iconMinTime;
        IL2CPP.il2cpp_field_static_get_value(ConnectionFeedbackSystem.NativeFieldInfoPtr_ICON_MIN_TIME, (void*) &iconMinTime);
        return iconMinTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectionFeedbackSystem.NativeFieldInfoPtr_ICON_MIN_TIME, (void*) &value);
      }
    }

    public static unsafe float ICON_MAX_TIME
    {
      get
      {
        float iconMaxTime;
        IL2CPP.il2cpp_field_static_get_value(ConnectionFeedbackSystem.NativeFieldInfoPtr_ICON_MAX_TIME, (void*) &iconMaxTime);
        return iconMaxTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectionFeedbackSystem.NativeFieldInfoPtr_ICON_MAX_TIME, (void*) &value);
      }
    }

    public static unsafe float POPUP_TIME
    {
      get
      {
        float popupTime;
        IL2CPP.il2cpp_field_static_get_value(ConnectionFeedbackSystem.NativeFieldInfoPtr_POPUP_TIME, (void*) &popupTime);
        return popupTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectionFeedbackSystem.NativeFieldInfoPtr_POPUP_TIME, (void*) &value);
      }
    }

    public static unsafe int POPUP_FRAMES
    {
      get
      {
        int popupFrames;
        IL2CPP.il2cpp_field_static_get_value(ConnectionFeedbackSystem.NativeFieldInfoPtr_POPUP_FRAMES, (void*) &popupFrames);
        return popupFrames;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectionFeedbackSystem.NativeFieldInfoPtr_POPUP_FRAMES, (void*) &value);
      }
    }

    public unsafe SingletonAccessor<ClientNetworkState> _ClientNetworkStateAccessor
    {
      get
      {
        return *(SingletonAccessor<ClientNetworkState>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectionFeedbackSystem.NativeFieldInfoPtr__ClientNetworkStateAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectionFeedbackSystem.NativeFieldInfoPtr__ClientNetworkStateAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ClientNetworkState>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ClientReplayPlayerEnabled> _ClientReplayPlayerEnabledAccessor
    {
      get
      {
        return *(SingletonAccessor<ClientReplayPlayerEnabled>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectionFeedbackSystem.NativeFieldInfoPtr__ClientReplayPlayerEnabledAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectionFeedbackSystem.NativeFieldInfoPtr__ClientReplayPlayerEnabledAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ClientReplayPlayerEnabled>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe ClientBootstrapSystem _ClientBootstrapSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectionFeedbackSystem.NativeFieldInfoPtr__ClientBootstrapSystem));
        return pointer == IntPtr.Zero ? (ClientBootstrapSystem) null : new ClientBootstrapSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConnectionFeedbackSystem.NativeFieldInfoPtr__ClientBootstrapSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIDataSystem _UIDataSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectionFeedbackSystem.NativeFieldInfoPtr__UIDataSystem));
        return pointer == IntPtr.Zero ? (UIDataSystem) null : new UIDataSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConnectionFeedbackSystem.NativeFieldInfoPtr__UIDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SlowConnectionIcon _Icon
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectionFeedbackSystem.NativeFieldInfoPtr__Icon));
        return pointer == IntPtr.Zero ? (SlowConnectionIcon) null : new SlowConnectionIcon(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConnectionFeedbackSystem.NativeFieldInfoPtr__Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimplePopup _Popup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectionFeedbackSystem.NativeFieldInfoPtr__Popup));
        return pointer == IntPtr.Zero ? (SimplePopup) null : new SimplePopup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConnectionFeedbackSystem.NativeFieldInfoPtr__Popup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public LocalizedString _LostConnectionString
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectionFeedbackSystem.NativeFieldInfoPtr__LostConnectionString);
        return new LocalizedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectionFeedbackSystem.NativeFieldInfoPtr__LostConnectionString), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }
  }
}
