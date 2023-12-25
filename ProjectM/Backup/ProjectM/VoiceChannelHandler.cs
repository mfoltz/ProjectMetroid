// Decompiled with JetBrains decompiler
// Type: ProjectM.VoiceChannelHandler
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using VivoxUnity;

#nullable disable
namespace ProjectM
{
  public class VoiceChannelHandler : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_VoiceChannelConnecting;
    private static readonly System.IntPtr NativeFieldInfoPtr_VoiceChannelConnected;
    private static readonly System.IntPtr NativeFieldInfoPtr_VoiceChannelDisconnecting;
    private static readonly System.IntPtr NativeFieldInfoPtr_VoiceChannelDisconnected;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_VoiceChannelConnecting_Public_Static_add_Void_Action_1_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_VoiceChannelConnecting_Public_Static_rem_Void_Action_1_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_VoiceChannelConnected_Public_Static_add_Void_Action_1_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_VoiceChannelConnected_Public_Static_rem_Void_Action_1_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_VoiceChannelDisconnecting_Public_Static_add_Void_Action_1_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_VoiceChannelDisconnecting_Public_Static_rem_Void_Action_1_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_VoiceChannelDisconnected_Public_Static_add_Void_Action_1_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_VoiceChannelDisconnected_Public_Static_rem_Void_Action_1_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Subscribe_Public_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Unsubscribe_Public_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioChannelConnecting_Private_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioChannelConnected_Private_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioChannelDisconnecting_Private_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioChannelDisconnected_Private_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToggleAudioChannelActive_Public_Void_IChannelSession_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnChannelAudioPropertyChanged_Private_Void_Object_PropertyChangedEventArgs_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080848, XrefRangeEnd = 1080855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void add_VoiceChannelConnecting(Il2CppSystem.Action<IChannelSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceChannelHandler.NativeMethodInfoPtr_add_VoiceChannelConnecting_Public_Static_add_Void_Action_1_IChannelSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080855, XrefRangeEnd = 1080862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void remove_VoiceChannelConnecting(Il2CppSystem.Action<IChannelSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceChannelHandler.NativeMethodInfoPtr_remove_VoiceChannelConnecting_Public_Static_rem_Void_Action_1_IChannelSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1080869, RefRangeEnd = 1080871, XrefRangeStart = 1080862, XrefRangeEnd = 1080869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void add_VoiceChannelConnected(Il2CppSystem.Action<IChannelSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceChannelHandler.NativeMethodInfoPtr_add_VoiceChannelConnected_Public_Static_add_Void_Action_1_IChannelSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080871, XrefRangeEnd = 1080878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void remove_VoiceChannelConnected(Il2CppSystem.Action<IChannelSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceChannelHandler.NativeMethodInfoPtr_remove_VoiceChannelConnected_Public_Static_rem_Void_Action_1_IChannelSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080878, XrefRangeEnd = 1080885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void add_VoiceChannelDisconnecting(Il2CppSystem.Action<IChannelSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceChannelHandler.NativeMethodInfoPtr_add_VoiceChannelDisconnecting_Public_Static_add_Void_Action_1_IChannelSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080885, XrefRangeEnd = 1080892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void remove_VoiceChannelDisconnecting(Il2CppSystem.Action<IChannelSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceChannelHandler.NativeMethodInfoPtr_remove_VoiceChannelDisconnecting_Public_Static_rem_Void_Action_1_IChannelSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080892, XrefRangeEnd = 1080899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void add_VoiceChannelDisconnected(Il2CppSystem.Action<IChannelSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceChannelHandler.NativeMethodInfoPtr_add_VoiceChannelDisconnected_Public_Static_add_Void_Action_1_IChannelSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080899, XrefRangeEnd = 1080906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void remove_VoiceChannelDisconnected(Il2CppSystem.Action<IChannelSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceChannelHandler.NativeMethodInfoPtr_remove_VoiceChannelDisconnected_Public_Static_rem_Void_Action_1_IChannelSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080906, XrefRangeEnd = 1080916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Subscribe(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceChannelHandler.NativeMethodInfoPtr_Subscribe_Public_Void_IChannelSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1080926, RefRangeEnd = 1080930, XrefRangeStart = 1080916, XrefRangeEnd = 1080926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Unsubscribe(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceChannelHandler.NativeMethodInfoPtr_Unsubscribe_Public_Void_IChannelSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080930, XrefRangeEnd = 1080935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnAudioChannelConnecting(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceChannelHandler.NativeMethodInfoPtr_OnAudioChannelConnecting_Private_Void_IChannelSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080935, XrefRangeEnd = 1080940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnAudioChannelConnected(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceChannelHandler.NativeMethodInfoPtr_OnAudioChannelConnected_Private_Void_IChannelSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080940, XrefRangeEnd = 1080945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnAudioChannelDisconnecting(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceChannelHandler.NativeMethodInfoPtr_OnAudioChannelDisconnecting_Private_Void_IChannelSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080945, XrefRangeEnd = 1080959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnAudioChannelDisconnected(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceChannelHandler.NativeMethodInfoPtr_OnAudioChannelDisconnected_Private_Void_IChannelSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080959, XrefRangeEnd = 1080992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ToggleAudioChannelActive(IChannelSession channelSession, bool join)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &join;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceChannelHandler.NativeMethodInfoPtr_ToggleAudioChannelActive_Public_Void_IChannelSession_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080992, XrefRangeEnd = 1081014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnChannelAudioPropertyChanged(
      Il2CppSystem.Object sender,
      PropertyChangedEventArgs propArgs)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sender);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) propArgs);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceChannelHandler.NativeMethodInfoPtr_OnChannelAudioPropertyChanged_Private_Void_Object_PropertyChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VoiceChannelHandler()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceChannelHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VoiceChannelHandler()
    {
      Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (VoiceChannelHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr);
      VoiceChannelHandler.NativeFieldInfoPtr_VoiceChannelConnecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, nameof (VoiceChannelConnecting));
      VoiceChannelHandler.NativeFieldInfoPtr_VoiceChannelConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, nameof (VoiceChannelConnected));
      VoiceChannelHandler.NativeFieldInfoPtr_VoiceChannelDisconnecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, nameof (VoiceChannelDisconnecting));
      VoiceChannelHandler.NativeFieldInfoPtr_VoiceChannelDisconnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, nameof (VoiceChannelDisconnected));
      VoiceChannelHandler.NativeMethodInfoPtr_add_VoiceChannelConnecting_Public_Static_add_Void_Action_1_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, 100685108);
      VoiceChannelHandler.NativeMethodInfoPtr_remove_VoiceChannelConnecting_Public_Static_rem_Void_Action_1_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, 100685109);
      VoiceChannelHandler.NativeMethodInfoPtr_add_VoiceChannelConnected_Public_Static_add_Void_Action_1_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, 100685110);
      VoiceChannelHandler.NativeMethodInfoPtr_remove_VoiceChannelConnected_Public_Static_rem_Void_Action_1_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, 100685111);
      VoiceChannelHandler.NativeMethodInfoPtr_add_VoiceChannelDisconnecting_Public_Static_add_Void_Action_1_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, 100685112);
      VoiceChannelHandler.NativeMethodInfoPtr_remove_VoiceChannelDisconnecting_Public_Static_rem_Void_Action_1_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, 100685113);
      VoiceChannelHandler.NativeMethodInfoPtr_add_VoiceChannelDisconnected_Public_Static_add_Void_Action_1_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, 100685114);
      VoiceChannelHandler.NativeMethodInfoPtr_remove_VoiceChannelDisconnected_Public_Static_rem_Void_Action_1_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, 100685115);
      VoiceChannelHandler.NativeMethodInfoPtr_Subscribe_Public_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, 100685116);
      VoiceChannelHandler.NativeMethodInfoPtr_Unsubscribe_Public_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, 100685117);
      VoiceChannelHandler.NativeMethodInfoPtr_OnAudioChannelConnecting_Private_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, 100685118);
      VoiceChannelHandler.NativeMethodInfoPtr_OnAudioChannelConnected_Private_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, 100685119);
      VoiceChannelHandler.NativeMethodInfoPtr_OnAudioChannelDisconnecting_Private_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, 100685120);
      VoiceChannelHandler.NativeMethodInfoPtr_OnAudioChannelDisconnected_Private_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, 100685121);
      VoiceChannelHandler.NativeMethodInfoPtr_ToggleAudioChannelActive_Public_Void_IChannelSession_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, 100685122);
      VoiceChannelHandler.NativeMethodInfoPtr_OnChannelAudioPropertyChanged_Private_Void_Object_PropertyChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, 100685123);
      VoiceChannelHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, 100685124);
    }

    public VoiceChannelHandler(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Il2CppSystem.Action<IChannelSession> VoiceChannelConnecting
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VoiceChannelHandler.NativeFieldInfoPtr_VoiceChannelConnecting, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<IChannelSession>) null : new Il2CppSystem.Action<IChannelSession>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VoiceChannelHandler.NativeFieldInfoPtr_VoiceChannelConnecting, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<IChannelSession> VoiceChannelConnected
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VoiceChannelHandler.NativeFieldInfoPtr_VoiceChannelConnected, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<IChannelSession>) null : new Il2CppSystem.Action<IChannelSession>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VoiceChannelHandler.NativeFieldInfoPtr_VoiceChannelConnected, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<IChannelSession> VoiceChannelDisconnecting
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VoiceChannelHandler.NativeFieldInfoPtr_VoiceChannelDisconnecting, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<IChannelSession>) null : new Il2CppSystem.Action<IChannelSession>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VoiceChannelHandler.NativeFieldInfoPtr_VoiceChannelDisconnecting, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<IChannelSession> VoiceChannelDisconnected
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VoiceChannelHandler.NativeFieldInfoPtr_VoiceChannelDisconnected, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<IChannelSession>) null : new Il2CppSystem.Action<IChannelSession>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VoiceChannelHandler.NativeFieldInfoPtr_VoiceChannelDisconnected, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.VoiceChannelHandler/<>c__DisplayClass18_0")]
    public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_channelSession;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ToggleAudioChannelActive_b__0_Internal_Void_IAsyncResult_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass18_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceChannelHandler.__c__DisplayClass18_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VoiceChannelHandler.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080837, XrefRangeEnd = 1080848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ToggleAudioChannelActive_b__0(Il2CppSystem.IAsyncResult ar)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ar);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VoiceChannelHandler.__c__DisplayClass18_0.NativeMethodInfoPtr__ToggleAudioChannelActive_b__0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass18_0()
      {
        Il2CppClassPointerStore<VoiceChannelHandler.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoiceChannelHandler>.NativeClassPtr, "<>c__DisplayClass18_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoiceChannelHandler.__c__DisplayClass18_0>.NativeClassPtr);
        VoiceChannelHandler.__c__DisplayClass18_0.NativeFieldInfoPtr_channelSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceChannelHandler.__c__DisplayClass18_0>.NativeClassPtr, nameof (channelSession));
        VoiceChannelHandler.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceChannelHandler.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
        VoiceChannelHandler.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceChannelHandler.__c__DisplayClass18_0>.NativeClassPtr, 100685125);
        VoiceChannelHandler.__c__DisplayClass18_0.NativeMethodInfoPtr__ToggleAudioChannelActive_b__0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceChannelHandler.__c__DisplayClass18_0>.NativeClassPtr, 100685126);
      }

      public __c__DisplayClass18_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe IChannelSession channelSession
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceChannelHandler.__c__DisplayClass18_0.NativeFieldInfoPtr_channelSession));
          return pointer == System.IntPtr.Zero ? (IChannelSession) null : new IChannelSession(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VoiceChannelHandler.__c__DisplayClass18_0.NativeFieldInfoPtr_channelSession), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe VoiceChannelHandler __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceChannelHandler.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (VoiceChannelHandler) null : new VoiceChannelHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VoiceChannelHandler.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
