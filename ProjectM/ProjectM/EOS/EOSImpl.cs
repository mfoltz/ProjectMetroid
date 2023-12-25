// Decompiled with JetBrains decompiler
// Type: ProjectM.EOS.EOSImpl
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices;
using Epic.OnlineServices.Connect;
using Epic.OnlineServices.Logging;
using Epic.OnlineServices.Platform;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.EOS
{
  public class EOSImpl : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LogHeader;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreatePlatformInterface_Public_Static_CreatePlatformInterfaceResult_InitializeOptions_Options_byref_PlatformInterface_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyPlatformInterface_Public_Static_Void_byref_PlatformInterface_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogCallback_Private_Static_Void_byref_LogMessage_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterAuthExpirationNotificationCallback_Public_Static_UInt64_PlatformInterface_EOSAuthExpirationNotification_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterAuthExpirationNotificationCallback_Public_Static_Void_PlatformInterface_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogInWithSteamAsync_Public_Static_Void_PlatformInterface_Il2CppStructArray_1_Byte_EOSLoginCompletedHandler_EOSOperationNotificationHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SteamIdToProductUserIdAsync_Public_Static_Void_PlatformInterface_UInt64_GetProductUserIdComplete_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121617, XrefRangeEnd = 1121632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EOSImpl.CreatePlatformInterfaceResult CreatePlatformInterface(
      InitializeOptions initOptions,
      Epic.OnlineServices.Platform.Options interfaceOptions,
      out PlatformInterface platformInterface)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) initOptions));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) interfaceOptions));
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EOSImpl.NativeMethodInfoPtr_CreatePlatformInterface_Public_Static_CreatePlatformInterfaceResult_InitializeOptions_Options_byref_PlatformInterface_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PlatformInterface local = ref platformInterface;
      System.IntPtr pointer = zero;
      PlatformInterface platformInterface1 = pointer == System.IntPtr.Zero ? (PlatformInterface) null : new PlatformInterface(pointer);
      local = platformInterface1;
      return *(EOSImpl.CreatePlatformInterfaceResult*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121632, XrefRangeEnd = 1121647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DestroyPlatformInterface(ref PlatformInterface platformInterface)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformInterface);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EOSImpl.NativeMethodInfoPtr_DestroyPlatformInterface_Public_Static_Void_byref_PlatformInterface_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PlatformInterface local = ref platformInterface;
      System.IntPtr pointer = ptr;
      PlatformInterface platformInterface1 = pointer == System.IntPtr.Zero ? (PlatformInterface) null : new PlatformInterface(pointer);
      local = platformInterface1;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121647, XrefRangeEnd = 1121679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void LogCallback(ref LogMessage msg)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) msg);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EOSImpl.NativeMethodInfoPtr_LogCallback_Private_Static_Void_byref_LogMessage_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121679, XrefRangeEnd = 1121692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ulong RegisterAuthExpirationNotificationCallback(
      PlatformInterface platformInterface,
      EOSImpl.EOSAuthExpirationNotification authExpirationNotificationCallback)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformInterface);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) authExpirationNotificationCallback);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSImpl.NativeMethodInfoPtr_RegisterAuthExpirationNotificationCallback_Public_Static_UInt64_PlatformInterface_EOSAuthExpirationNotification_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121692, XrefRangeEnd = 1121695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UnregisterAuthExpirationNotificationCallback(
      PlatformInterface platformInterface,
      ulong callbackHandle)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformInterface);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &callbackHandle;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EOSImpl.NativeMethodInfoPtr_UnregisterAuthExpirationNotificationCallback_Public_Static_Void_PlatformInterface_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121695, XrefRangeEnd = 1121711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void LogInWithSteamAsync(
      PlatformInterface platformInterface,
      Il2CppStructArray<byte> encryptedAppTicket,
      EOSImpl.EOSLoginCompletedHandler loginCompleteCallback,
      EOSOperationNotificationHandler loginInternalRetryCallback)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformInterface);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) encryptedAppTicket);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) loginCompleteCallback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) loginInternalRetryCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EOSImpl.NativeMethodInfoPtr_LogInWithSteamAsync_Public_Static_Void_PlatformInterface_Il2CppStructArray_1_Byte_EOSLoginCompletedHandler_EOSOperationNotificationHandler_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121711, XrefRangeEnd = 1121736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SteamIdToProductUserIdAsync(
      PlatformInterface platformInterface,
      ulong steamId,
      EOSImpl.GetProductUserIdComplete completeCallback)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformInterface);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &steamId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completeCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EOSImpl.NativeMethodInfoPtr_SteamIdToProductUserIdAsync_Public_Static_Void_PlatformInterface_UInt64_GetProductUserIdComplete_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EOSImpl()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EOSImpl>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EOSImpl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EOSImpl()
    {
      Il2CppClassPointerStore<EOSImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.EOS", nameof (EOSImpl));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EOSImpl>.NativeClassPtr);
      EOSImpl.NativeFieldInfoPtr_LogHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSImpl>.NativeClassPtr, nameof (LogHeader));
      EOSImpl.NativeMethodInfoPtr_CreatePlatformInterface_Public_Static_CreatePlatformInterfaceResult_InitializeOptions_Options_byref_PlatformInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl>.NativeClassPtr, 100688998);
      EOSImpl.NativeMethodInfoPtr_DestroyPlatformInterface_Public_Static_Void_byref_PlatformInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl>.NativeClassPtr, 100688999);
      EOSImpl.NativeMethodInfoPtr_LogCallback_Private_Static_Void_byref_LogMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl>.NativeClassPtr, 100689000);
      EOSImpl.NativeMethodInfoPtr_RegisterAuthExpirationNotificationCallback_Public_Static_UInt64_PlatformInterface_EOSAuthExpirationNotification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl>.NativeClassPtr, 100689001);
      EOSImpl.NativeMethodInfoPtr_UnregisterAuthExpirationNotificationCallback_Public_Static_Void_PlatformInterface_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl>.NativeClassPtr, 100689002);
      EOSImpl.NativeMethodInfoPtr_LogInWithSteamAsync_Public_Static_Void_PlatformInterface_Il2CppStructArray_1_Byte_EOSLoginCompletedHandler_EOSOperationNotificationHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl>.NativeClassPtr, 100689003);
      EOSImpl.NativeMethodInfoPtr_SteamIdToProductUserIdAsync_Public_Static_Void_PlatformInterface_UInt64_GetProductUserIdComplete_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl>.NativeClassPtr, 100689004);
      EOSImpl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl>.NativeClassPtr, 100689005);
    }

    public EOSImpl(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string LogHeader
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSImpl.NativeFieldInfoPtr_LogHeader, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSImpl.NativeFieldInfoPtr_LogHeader, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public class UnmanagedAllocationsOwner : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MarkAsCleanedUp_Protected_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe UnmanagedAllocationsOwner()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EOSImpl.UnmanagedAllocationsOwner>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSImpl.UnmanagedAllocationsOwner.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public virtual unsafe void Release()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EOSImpl.UnmanagedAllocationsOwner.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void MarkAsCleanedUp()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSImpl.UnmanagedAllocationsOwner.NativeMethodInfoPtr_MarkAsCleanedUp_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UnmanagedAllocationsOwner()
      {
        Il2CppClassPointerStore<EOSImpl.UnmanagedAllocationsOwner>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EOSImpl>.NativeClassPtr, nameof (UnmanagedAllocationsOwner));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EOSImpl.UnmanagedAllocationsOwner>.NativeClassPtr);
        EOSImpl.UnmanagedAllocationsOwner.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.UnmanagedAllocationsOwner>.NativeClassPtr, 100689006);
        EOSImpl.UnmanagedAllocationsOwner.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.UnmanagedAllocationsOwner>.NativeClassPtr, 100689007);
        EOSImpl.UnmanagedAllocationsOwner.NativeMethodInfoPtr_MarkAsCleanedUp_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.UnmanagedAllocationsOwner>.NativeClassPtr, 100689008);
      }

      public UnmanagedAllocationsOwner(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public enum CreatePlatformInterfaceResult
    {
      Success,
      FailedToInitialize,
      FailedToCreate,
      DllNotFound,
    }

    public sealed class EOSAuthExpirationNotification : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ProductUserId_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ProductUserId_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe EOSAuthExpirationNotification(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EOSImpl.EOSAuthExpirationNotification>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSImpl.EOSAuthExpirationNotification.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12)]
      [CachedScanResults(RefRangeStart = 457887, RefRangeEnd = 457899, XrefRangeStart = 457887, XrefRangeEnd = 457899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(ProductUserId userId)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) userId);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSImpl.EOSAuthExpirationNotification.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 43644, RefRangeEnd = 43648, XrefRangeStart = 43644, XrefRangeEnd = 43648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ProductUserId userId,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) userId);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSImpl.EOSAuthExpirationNotification.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ProductUserId_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSImpl.EOSAuthExpirationNotification.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static EOSAuthExpirationNotification()
      {
        Il2CppClassPointerStore<EOSImpl.EOSAuthExpirationNotification>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EOSImpl>.NativeClassPtr, nameof (EOSAuthExpirationNotification));
        EOSImpl.EOSAuthExpirationNotification.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.EOSAuthExpirationNotification>.NativeClassPtr, 100689009);
        EOSImpl.EOSAuthExpirationNotification.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.EOSAuthExpirationNotification>.NativeClassPtr, 100689010);
        EOSImpl.EOSAuthExpirationNotification.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ProductUserId_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.EOSAuthExpirationNotification>.NativeClassPtr, 100689011);
        EOSImpl.EOSAuthExpirationNotification.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.EOSAuthExpirationNotification>.NativeClassPtr, 100689012);
      }

      public EOSAuthExpirationNotification(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static implicit operator EOSImpl.EOSAuthExpirationNotification(
        [In] System.Action<ProductUserId> obj0)
      {
        return DelegateSupport.ConvertDelegate<EOSImpl.EOSAuthExpirationNotification>((System.Delegate) obj0);
      }

      public static EOSImpl.EOSAuthExpirationNotification operator +(
        [In] EOSImpl.EOSAuthExpirationNotification obj0,
        [In] EOSImpl.EOSAuthExpirationNotification obj1)
      {
        return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<EOSImpl.EOSAuthExpirationNotification>();
      }

      public static EOSImpl.EOSAuthExpirationNotification operator -(
        [In] EOSImpl.EOSAuthExpirationNotification obj0,
        [In] EOSImpl.EOSAuthExpirationNotification obj1)
      {
        Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
        return (object) @delegate == null ? (EOSImpl.EOSAuthExpirationNotification) @delegate : @delegate.Cast<EOSImpl.EOSAuthExpirationNotification>();
      }
    }

    public sealed class EOSLoginCompletedHandler : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_ProductUserId_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_ProductUserId_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe EOSLoginCompletedHandler(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EOSImpl.EOSLoginCompletedHandler>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSImpl.EOSLoginCompletedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1121521, RefRangeEnd = 1121522, XrefRangeStart = 1121506, XrefRangeEnd = 1121521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(bool success, ProductUserId userId)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &success;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) userId);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSImpl.EOSLoginCompletedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121522, XrefRangeEnd = 1121526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        bool success,
        ProductUserId userId,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &success;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) userId);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSImpl.EOSLoginCompletedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_ProductUserId_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSImpl.EOSLoginCompletedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static EOSLoginCompletedHandler()
      {
        Il2CppClassPointerStore<EOSImpl.EOSLoginCompletedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EOSImpl>.NativeClassPtr, nameof (EOSLoginCompletedHandler));
        EOSImpl.EOSLoginCompletedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.EOSLoginCompletedHandler>.NativeClassPtr, 100689013);
        EOSImpl.EOSLoginCompletedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.EOSLoginCompletedHandler>.NativeClassPtr, 100689014);
        EOSImpl.EOSLoginCompletedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_ProductUserId_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.EOSLoginCompletedHandler>.NativeClassPtr, 100689015);
        EOSImpl.EOSLoginCompletedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.EOSLoginCompletedHandler>.NativeClassPtr, 100689016);
      }

      public EOSLoginCompletedHandler(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static implicit operator EOSImpl.EOSLoginCompletedHandler(
        [In] System.Action<bool, ProductUserId> obj0)
      {
        return DelegateSupport.ConvertDelegate<EOSImpl.EOSLoginCompletedHandler>((System.Delegate) obj0);
      }

      public static EOSImpl.EOSLoginCompletedHandler operator +(
        [In] EOSImpl.EOSLoginCompletedHandler obj0,
        [In] EOSImpl.EOSLoginCompletedHandler obj1)
      {
        return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<EOSImpl.EOSLoginCompletedHandler>();
      }

      public static EOSImpl.EOSLoginCompletedHandler operator -(
        [In] EOSImpl.EOSLoginCompletedHandler obj0,
        [In] EOSImpl.EOSLoginCompletedHandler obj1)
      {
        Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
        return (object) @delegate == null ? (EOSImpl.EOSLoginCompletedHandler) @delegate : @delegate.Cast<EOSImpl.EOSLoginCompletedHandler>();
      }
    }

    public sealed class GetProductUserIdComplete : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_ProductUserId_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_ProductUserId_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe GetProductUserIdComplete(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EOSImpl.GetProductUserIdComplete>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSImpl.GetProductUserIdComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1121521, RefRangeEnd = 1121522, XrefRangeStart = 1121521, XrefRangeEnd = 1121522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(bool success, ProductUserId id)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &success;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) id);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSImpl.GetProductUserIdComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121526, XrefRangeEnd = 1121530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        bool success,
        ProductUserId id,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &success;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) id);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSImpl.GetProductUserIdComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_ProductUserId_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSImpl.GetProductUserIdComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static GetProductUserIdComplete()
      {
        Il2CppClassPointerStore<EOSImpl.GetProductUserIdComplete>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EOSImpl>.NativeClassPtr, nameof (GetProductUserIdComplete));
        EOSImpl.GetProductUserIdComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.GetProductUserIdComplete>.NativeClassPtr, 100689017);
        EOSImpl.GetProductUserIdComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.GetProductUserIdComplete>.NativeClassPtr, 100689018);
        EOSImpl.GetProductUserIdComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_ProductUserId_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.GetProductUserIdComplete>.NativeClassPtr, 100689019);
        EOSImpl.GetProductUserIdComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.GetProductUserIdComplete>.NativeClassPtr, 100689020);
      }

      public GetProductUserIdComplete(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static implicit operator EOSImpl.GetProductUserIdComplete(
        [In] System.Action<bool, ProductUserId> obj0)
      {
        return DelegateSupport.ConvertDelegate<EOSImpl.GetProductUserIdComplete>((System.Delegate) obj0);
      }

      public static EOSImpl.GetProductUserIdComplete operator +(
        [In] EOSImpl.GetProductUserIdComplete obj0,
        [In] EOSImpl.GetProductUserIdComplete obj1)
      {
        return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<EOSImpl.GetProductUserIdComplete>();
      }

      public static EOSImpl.GetProductUserIdComplete operator -(
        [In] EOSImpl.GetProductUserIdComplete obj0,
        [In] EOSImpl.GetProductUserIdComplete obj1)
      {
        Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
        return (object) @delegate == null ? (EOSImpl.GetProductUserIdComplete) @delegate : @delegate.Cast<EOSImpl.GetProductUserIdComplete>();
      }
    }

    [ObfuscatedName("ProjectM.EOS.EOSImpl/<>c__DisplayClass7_0")]
    public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_authExpirationNotificationCallback;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterAuthExpirationNotificationCallback_b__0_Internal_Void_byref_AuthExpirationCallbackInfo_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass7_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSImpl.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121530, XrefRangeEnd = 1121532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterAuthExpirationNotificationCallback_b__0(
        ref AuthExpirationCallbackInfo data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSImpl.__c__DisplayClass7_0.NativeMethodInfoPtr__RegisterAuthExpirationNotificationCallback_b__0_Internal_Void_byref_AuthExpirationCallbackInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_0()
      {
        Il2CppClassPointerStore<EOSImpl.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EOSImpl>.NativeClassPtr, "<>c__DisplayClass7_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass7_0>.NativeClassPtr);
        EOSImpl.__c__DisplayClass7_0.NativeFieldInfoPtr_authExpirationNotificationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass7_0>.NativeClassPtr, nameof (authExpirationNotificationCallback));
        EOSImpl.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass7_0>.NativeClassPtr, 100689021);
        EOSImpl.__c__DisplayClass7_0.NativeMethodInfoPtr__RegisterAuthExpirationNotificationCallback_b__0_Internal_Void_byref_AuthExpirationCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass7_0>.NativeClassPtr, 100689022);
      }

      public __c__DisplayClass7_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe EOSImpl.EOSAuthExpirationNotification authExpirationNotificationCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSImpl.__c__DisplayClass7_0.NativeFieldInfoPtr_authExpirationNotificationCallback));
          return pointer == System.IntPtr.Zero ? (EOSImpl.EOSAuthExpirationNotification) null : new EOSImpl.EOSAuthExpirationNotification(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EOSImpl.__c__DisplayClass7_0.NativeFieldInfoPtr_authExpirationNotificationCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.EOS.EOSImpl/<>c__DisplayClass10_0")]
    public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_encryptedAppTicket;
      private static readonly System.IntPtr NativeFieldInfoPtr_loginCompleteCallback;
      private static readonly System.IntPtr NativeFieldInfoPtr_platformInterface;
      private static readonly System.IntPtr NativeFieldInfoPtr_loginInternalRetryCallback;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_byref_LoginCallbackInfo_PDM_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_byref_CreateUserCallbackInfo_PDM_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass10_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass10_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSImpl.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1121556, RefRangeEnd = 1121559, XrefRangeStart = 1121532, XrefRangeEnd = 1121556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSImpl.__c__DisplayClass10_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121559, XrefRangeEnd = 1121566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_byref_LoginCallbackInfo_PDM_0(
        ref LoginCallbackInfo loginCallbackInfo)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) loginCallbackInfo);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSImpl.__c__DisplayClass10_0.NativeMethodInfoPtr_Method_Internal_Void_byref_LoginCallbackInfo_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121566, XrefRangeEnd = 1121585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_byref_CreateUserCallbackInfo_PDM_0(
        ref CreateUserCallbackInfo createUserCallbackInfo)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) createUserCallbackInfo);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSImpl.__c__DisplayClass10_0.NativeMethodInfoPtr_Method_Internal_Void_byref_CreateUserCallbackInfo_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass10_0()
      {
        Il2CppClassPointerStore<EOSImpl.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EOSImpl>.NativeClassPtr, "<>c__DisplayClass10_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass10_0>.NativeClassPtr);
        EOSImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_encryptedAppTicket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass10_0>.NativeClassPtr, nameof (encryptedAppTicket));
        EOSImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_loginCompleteCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass10_0>.NativeClassPtr, nameof (loginCompleteCallback));
        EOSImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_platformInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass10_0>.NativeClassPtr, nameof (platformInterface));
        EOSImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_loginInternalRetryCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass10_0>.NativeClassPtr, nameof (loginInternalRetryCallback));
        EOSImpl.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass10_0>.NativeClassPtr, 100689023);
        EOSImpl.__c__DisplayClass10_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass10_0>.NativeClassPtr, 100689024);
        EOSImpl.__c__DisplayClass10_0.NativeMethodInfoPtr_Method_Internal_Void_byref_LoginCallbackInfo_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass10_0>.NativeClassPtr, 100689025);
        EOSImpl.__c__DisplayClass10_0.NativeMethodInfoPtr_Method_Internal_Void_byref_CreateUserCallbackInfo_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass10_0>.NativeClassPtr, 100689026);
      }

      public __c__DisplayClass10_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Il2CppStructArray<byte> encryptedAppTicket
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_encryptedAppTicket));
          return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EOSImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_encryptedAppTicket), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EOSImpl.EOSLoginCompletedHandler loginCompleteCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_loginCompleteCallback));
          return pointer == System.IntPtr.Zero ? (EOSImpl.EOSLoginCompletedHandler) null : new EOSImpl.EOSLoginCompletedHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EOSImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_loginCompleteCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PlatformInterface platformInterface
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_platformInterface));
          return pointer == System.IntPtr.Zero ? (PlatformInterface) null : new PlatformInterface(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EOSImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_platformInterface), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EOSOperationNotificationHandler loginInternalRetryCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_loginInternalRetryCallback));
          return pointer == System.IntPtr.Zero ? (EOSOperationNotificationHandler) null : new EOSOperationNotificationHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EOSImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_loginInternalRetryCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.EOS.EOSImpl/<>c__DisplayClass12_0")]
    public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_platformInterface;
      private static readonly System.IntPtr NativeFieldInfoPtr_steamId;
      private static readonly System.IntPtr NativeFieldInfoPtr_completeCallback;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_byref_QueryExternalAccountMappingsCallbackInfo_PDM_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass12_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass12_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSImpl.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121585, XrefRangeEnd = 1121617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_byref_QueryExternalAccountMappingsCallbackInfo_PDM_0(
        ref QueryExternalAccountMappingsCallbackInfo data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSImpl.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_Void_byref_QueryExternalAccountMappingsCallbackInfo_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass12_0()
      {
        Il2CppClassPointerStore<EOSImpl.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EOSImpl>.NativeClassPtr, "<>c__DisplayClass12_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass12_0>.NativeClassPtr);
        EOSImpl.__c__DisplayClass12_0.NativeFieldInfoPtr_platformInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass12_0>.NativeClassPtr, nameof (platformInterface));
        EOSImpl.__c__DisplayClass12_0.NativeFieldInfoPtr_steamId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass12_0>.NativeClassPtr, nameof (steamId));
        EOSImpl.__c__DisplayClass12_0.NativeFieldInfoPtr_completeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass12_0>.NativeClassPtr, nameof (completeCallback));
        EOSImpl.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass12_0>.NativeClassPtr, 100689027);
        EOSImpl.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_Void_byref_QueryExternalAccountMappingsCallbackInfo_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSImpl.__c__DisplayClass12_0>.NativeClassPtr, 100689028);
      }

      public __c__DisplayClass12_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe PlatformInterface platformInterface
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSImpl.__c__DisplayClass12_0.NativeFieldInfoPtr_platformInterface));
          return pointer == System.IntPtr.Zero ? (PlatformInterface) null : new PlatformInterface(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EOSImpl.__c__DisplayClass12_0.NativeFieldInfoPtr_platformInterface), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ulong steamId
      {
        get
        {
          return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSImpl.__c__DisplayClass12_0.NativeFieldInfoPtr_steamId));
        }
        [param: In] set
        {
          *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSImpl.__c__DisplayClass12_0.NativeFieldInfoPtr_steamId)) = value;
        }
      }

      public unsafe EOSImpl.GetProductUserIdComplete completeCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSImpl.__c__DisplayClass12_0.NativeFieldInfoPtr_completeCallback));
          return pointer == System.IntPtr.Zero ? (EOSImpl.GetProductUserIdComplete) null : new EOSImpl.GetProductUserIdComplete(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EOSImpl.__c__DisplayClass12_0.NativeFieldInfoPtr_completeCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
