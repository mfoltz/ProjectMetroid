// Decompiled with JetBrains decompiler
// Type: ProjectM.ChannelHandler
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
  public class ChannelHandler : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ChannelConnecting;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChannelConnected;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChannelDisconnecting;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChannelDisconnected;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_ChannelConnecting_Public_Static_add_Void_Action_1_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_ChannelConnecting_Public_Static_rem_Void_Action_1_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_ChannelConnected_Public_Static_add_Void_Action_1_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_ChannelConnected_Public_Static_rem_Void_Action_1_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_ChannelDisconnecting_Public_Static_add_Void_Action_1_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_ChannelDisconnecting_Public_Static_rem_Void_Action_1_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_ChannelDisconnected_Public_Static_add_Void_Action_1_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_ChannelDisconnected_Public_Static_rem_Void_Action_1_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Subscribe_Public_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Unsubscribe_Public_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnChannelConnecting_Private_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnChannelConnected_Private_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnChannelDisconnecting_Private_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnChannelDisconnected_Private_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnChannelStatePropertyChanged_Private_Void_Object_PropertyChangedEventArgs_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1081021, RefRangeEnd = 1081022, XrefRangeStart = 1081014, XrefRangeEnd = 1081021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void add_ChannelConnecting(Il2CppSystem.Action<IChannelSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChannelHandler.NativeMethodInfoPtr_add_ChannelConnecting_Public_Static_add_Void_Action_1_IChannelSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081022, XrefRangeEnd = 1081029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void remove_ChannelConnecting(Il2CppSystem.Action<IChannelSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChannelHandler.NativeMethodInfoPtr_remove_ChannelConnecting_Public_Static_rem_Void_Action_1_IChannelSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1081036, RefRangeEnd = 1081037, XrefRangeStart = 1081029, XrefRangeEnd = 1081036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void add_ChannelConnected(Il2CppSystem.Action<IChannelSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChannelHandler.NativeMethodInfoPtr_add_ChannelConnected_Public_Static_add_Void_Action_1_IChannelSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081037, XrefRangeEnd = 1081044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void remove_ChannelConnected(Il2CppSystem.Action<IChannelSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChannelHandler.NativeMethodInfoPtr_remove_ChannelConnected_Public_Static_rem_Void_Action_1_IChannelSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1081051, RefRangeEnd = 1081052, XrefRangeStart = 1081044, XrefRangeEnd = 1081051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void add_ChannelDisconnecting(Il2CppSystem.Action<IChannelSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChannelHandler.NativeMethodInfoPtr_add_ChannelDisconnecting_Public_Static_add_Void_Action_1_IChannelSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081052, XrefRangeEnd = 1081059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void remove_ChannelDisconnecting(Il2CppSystem.Action<IChannelSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChannelHandler.NativeMethodInfoPtr_remove_ChannelDisconnecting_Public_Static_rem_Void_Action_1_IChannelSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1081066, RefRangeEnd = 1081067, XrefRangeStart = 1081059, XrefRangeEnd = 1081066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void add_ChannelDisconnected(Il2CppSystem.Action<IChannelSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChannelHandler.NativeMethodInfoPtr_add_ChannelDisconnected_Public_Static_add_Void_Action_1_IChannelSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081067, XrefRangeEnd = 1081074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void remove_ChannelDisconnected(Il2CppSystem.Action<IChannelSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChannelHandler.NativeMethodInfoPtr_remove_ChannelDisconnected_Public_Static_rem_Void_Action_1_IChannelSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1081084, RefRangeEnd = 1081085, XrefRangeStart = 1081074, XrefRangeEnd = 1081084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Subscribe(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChannelHandler.NativeMethodInfoPtr_Subscribe_Public_Void_IChannelSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1081095, RefRangeEnd = 1081098, XrefRangeStart = 1081085, XrefRangeEnd = 1081095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Unsubscribe(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChannelHandler.NativeMethodInfoPtr_Unsubscribe_Public_Void_IChannelSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081098, XrefRangeEnd = 1081103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnChannelConnecting(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChannelHandler.NativeMethodInfoPtr_OnChannelConnecting_Private_Void_IChannelSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081103, XrefRangeEnd = 1081108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnChannelConnected(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChannelHandler.NativeMethodInfoPtr_OnChannelConnected_Private_Void_IChannelSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081108, XrefRangeEnd = 1081113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnChannelDisconnecting(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChannelHandler.NativeMethodInfoPtr_OnChannelDisconnecting_Private_Void_IChannelSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081113, XrefRangeEnd = 1081128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnChannelDisconnected(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChannelHandler.NativeMethodInfoPtr_OnChannelDisconnected_Private_Void_IChannelSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081128, XrefRangeEnd = 1081150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnChannelStatePropertyChanged(
      Il2CppSystem.Object sender,
      PropertyChangedEventArgs channelArgs)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sender);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelArgs);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChannelHandler.NativeMethodInfoPtr_OnChannelStatePropertyChanged_Private_Void_Object_PropertyChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChannelHandler()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChannelHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChannelHandler()
    {
      Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ChannelHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr);
      ChannelHandler.NativeFieldInfoPtr_ChannelConnecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, nameof (ChannelConnecting));
      ChannelHandler.NativeFieldInfoPtr_ChannelConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, nameof (ChannelConnected));
      ChannelHandler.NativeFieldInfoPtr_ChannelDisconnecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, nameof (ChannelDisconnecting));
      ChannelHandler.NativeFieldInfoPtr_ChannelDisconnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, nameof (ChannelDisconnected));
      ChannelHandler.NativeMethodInfoPtr_add_ChannelConnecting_Public_Static_add_Void_Action_1_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, 100685127);
      ChannelHandler.NativeMethodInfoPtr_remove_ChannelConnecting_Public_Static_rem_Void_Action_1_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, 100685128);
      ChannelHandler.NativeMethodInfoPtr_add_ChannelConnected_Public_Static_add_Void_Action_1_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, 100685129);
      ChannelHandler.NativeMethodInfoPtr_remove_ChannelConnected_Public_Static_rem_Void_Action_1_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, 100685130);
      ChannelHandler.NativeMethodInfoPtr_add_ChannelDisconnecting_Public_Static_add_Void_Action_1_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, 100685131);
      ChannelHandler.NativeMethodInfoPtr_remove_ChannelDisconnecting_Public_Static_rem_Void_Action_1_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, 100685132);
      ChannelHandler.NativeMethodInfoPtr_add_ChannelDisconnected_Public_Static_add_Void_Action_1_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, 100685133);
      ChannelHandler.NativeMethodInfoPtr_remove_ChannelDisconnected_Public_Static_rem_Void_Action_1_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, 100685134);
      ChannelHandler.NativeMethodInfoPtr_Subscribe_Public_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, 100685135);
      ChannelHandler.NativeMethodInfoPtr_Unsubscribe_Public_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, 100685136);
      ChannelHandler.NativeMethodInfoPtr_OnChannelConnecting_Private_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, 100685137);
      ChannelHandler.NativeMethodInfoPtr_OnChannelConnected_Private_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, 100685138);
      ChannelHandler.NativeMethodInfoPtr_OnChannelDisconnecting_Private_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, 100685139);
      ChannelHandler.NativeMethodInfoPtr_OnChannelDisconnected_Private_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, 100685140);
      ChannelHandler.NativeMethodInfoPtr_OnChannelStatePropertyChanged_Private_Void_Object_PropertyChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, 100685141);
      ChannelHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelHandler>.NativeClassPtr, 100685142);
    }

    public ChannelHandler(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Il2CppSystem.Action<IChannelSession> ChannelConnecting
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ChannelHandler.NativeFieldInfoPtr_ChannelConnecting, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<IChannelSession>) null : new Il2CppSystem.Action<IChannelSession>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ChannelHandler.NativeFieldInfoPtr_ChannelConnecting, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<IChannelSession> ChannelConnected
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ChannelHandler.NativeFieldInfoPtr_ChannelConnected, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<IChannelSession>) null : new Il2CppSystem.Action<IChannelSession>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ChannelHandler.NativeFieldInfoPtr_ChannelConnected, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<IChannelSession> ChannelDisconnecting
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ChannelHandler.NativeFieldInfoPtr_ChannelDisconnecting, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<IChannelSession>) null : new Il2CppSystem.Action<IChannelSession>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ChannelHandler.NativeFieldInfoPtr_ChannelDisconnecting, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<IChannelSession> ChannelDisconnected
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ChannelHandler.NativeFieldInfoPtr_ChannelDisconnected, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<IChannelSession>) null : new Il2CppSystem.Action<IChannelSession>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ChannelHandler.NativeFieldInfoPtr_ChannelDisconnected, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
