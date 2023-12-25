// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.HttpServiceReceiveThread
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net;
using Il2CppSystem.Text;
using Il2CppSystem.Text.RegularExpressions;
using Il2CppSystem.Threading;
using ProjectM.Network.HttpService;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  public class HttpServiceReceiveThread : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__UseSynchronousHandling;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsRunning;
    private static readonly System.IntPtr NativeFieldInfoPtr__Listener;
    private static readonly System.IntPtr NativeFieldInfoPtr__handleContextCallback;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReceiveThread;
    private static readonly System.IntPtr NativeFieldInfoPtr__RegexRoutes;
    private static readonly System.IntPtr NativeFieldInfoPtr__AccessList;
    private static readonly System.IntPtr NativeFieldInfoPtr__OkResponse;
    private static readonly System.IntPtr NativeFieldInfoPtr__BadRequestResponse;
    private static readonly System.IntPtr NativeFieldInfoPtr__ForbiddenRequestResponse;
    private static readonly System.IntPtr NativeFieldInfoPtr__NotFoundResponse;
    private static readonly System.IntPtr NativeFieldInfoPtr__MethodNotAllowedResponse;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastMessageReceived;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastMessageReceivedTicks;
    private static readonly System.IntPtr NativeFieldInfoPtr_TryBuildPrometheusResponse;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConsoleCommand;
    private static readonly System.IntPtr NativeFieldInfoPtr_HandleConsoleCommand;
    private static readonly System.IntPtr NativeFieldInfoPtr_HandleSave;
    private static readonly System.IntPtr NativeFieldInfoPtr_HandleShutdown;
    private static readonly System.IntPtr NativeFieldInfoPtr_HandleMessage;
    private static readonly System.IntPtr NativeFieldInfoPtr__MessageResponse;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrometheusStringBuilder;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Shutdown_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddRoutes_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddRoute_Private_Void_Route_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnApiSave_Private_Void_HttpListenerContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnApiShutdown_Private_Void_HttpListenerContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnConsoleCommand_Private_Void_HttpListenerContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnApiMessage_Private_Void_HttpListenerContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleContext_Private_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleContext_Private_Void_HttpListenerContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendOkResponse_Private_Void_HttpListenerContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendNotFoundResponse_Private_Void_HttpListenerContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendMethodNotAllowedResponse_Private_Void_HttpListenerContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendBadRequest_Private_Void_HttpListenerContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendForbiddenRequest_Private_Void_HttpListenerContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveLoop_Private_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAllowed_Private_Boolean_HttpListenerContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPrometheusScrapeManual_Private_Void_HttpListenerContext_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1144711, RefRangeEnd = 1144712, XrefRangeStart = 1144619, XrefRangeEnd = 1144711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HttpServiceReceiveThread(Il2CppStringArray bindHosts)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bindHosts);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1144725, RefRangeEnd = 1144726, XrefRangeStart = 1144712, XrefRangeEnd = 1144725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Shutdown()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.NativeMethodInfoPtr_Shutdown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1144812, RefRangeEnd = 1144813, XrefRangeStart = 1144726, XrefRangeEnd = 1144812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddRoutes(string basePath)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(basePath);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.NativeMethodInfoPtr_AddRoutes_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1144824, RefRangeEnd = 1144829, XrefRangeStart = 1144813, XrefRangeEnd = 1144824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddRoute(HttpServiceReceiveThread.Route route)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) route));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.NativeMethodInfoPtr_AddRoute_Private_Void_Route_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144829, XrefRangeEnd = 1144835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnApiSave(HttpListenerContext context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.NativeMethodInfoPtr_OnApiSave_Private_Void_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144835, XrefRangeEnd = 1144847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnApiShutdown(HttpListenerContext context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.NativeMethodInfoPtr_OnApiShutdown_Private_Void_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144847, XrefRangeEnd = 1144871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnConsoleCommand(HttpListenerContext context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.NativeMethodInfoPtr_OnConsoleCommand_Private_Void_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144871, XrefRangeEnd = 1144888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnApiMessage(HttpListenerContext context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.NativeMethodInfoPtr_OnApiMessage_Private_Void_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144888, XrefRangeEnd = 1144892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleContext(Il2CppSystem.Object context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.NativeMethodInfoPtr_HandleContext_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1144961, RefRangeEnd = 1144963, XrefRangeStart = 1144892, XrefRangeEnd = 1144961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleContext(HttpListenerContext context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.NativeMethodInfoPtr_HandleContext_Private_Void_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendOkResponse(HttpListenerContext context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.NativeMethodInfoPtr_SendOkResponse_Private_Void_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144963, XrefRangeEnd = 1144976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendNotFoundResponse(HttpListenerContext context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.NativeMethodInfoPtr_SendNotFoundResponse_Private_Void_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144976, XrefRangeEnd = 1144989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendMethodNotAllowedResponse(HttpListenerContext context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.NativeMethodInfoPtr_SendMethodNotAllowedResponse_Private_Void_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1144995, RefRangeEnd = 1144996, XrefRangeStart = 1144989, XrefRangeEnd = 1144995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendBadRequest(HttpListenerContext context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.NativeMethodInfoPtr_SendBadRequest_Private_Void_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1145002, RefRangeEnd = 1145003, XrefRangeStart = 1144996, XrefRangeEnd = 1145002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendForbiddenRequest(HttpListenerContext context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.NativeMethodInfoPtr_SendForbiddenRequest_Private_Void_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145003, XrefRangeEnd = 1145046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ReceiveLoop(Il2CppSystem.Object state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) state);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.NativeMethodInfoPtr_ReceiveLoop_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1145051, RefRangeEnd = 1145052, XrefRangeStart = 1145046, XrefRangeEnd = 1145051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAllowed(HttpListenerContext context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.NativeMethodInfoPtr_IsAllowed_Private_Boolean_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145052, XrefRangeEnd = 1145097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnPrometheusScrapeManual(HttpListenerContext context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.NativeMethodInfoPtr_OnPrometheusScrapeManual_Private_Void_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HttpServiceReceiveThread()
    {
      Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (HttpServiceReceiveThread));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr);
      HttpServiceReceiveThread.NativeFieldInfoPtr__UseSynchronousHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (_UseSynchronousHandling));
      HttpServiceReceiveThread.NativeFieldInfoPtr__IsRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (_IsRunning));
      HttpServiceReceiveThread.NativeFieldInfoPtr__Listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (_Listener));
      HttpServiceReceiveThread.NativeFieldInfoPtr__handleContextCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (_handleContextCallback));
      HttpServiceReceiveThread.NativeFieldInfoPtr__ReceiveThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (_ReceiveThread));
      HttpServiceReceiveThread.NativeFieldInfoPtr__RegexRoutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (_RegexRoutes));
      HttpServiceReceiveThread.NativeFieldInfoPtr__AccessList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (_AccessList));
      HttpServiceReceiveThread.NativeFieldInfoPtr__OkResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (_OkResponse));
      HttpServiceReceiveThread.NativeFieldInfoPtr__BadRequestResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (_BadRequestResponse));
      HttpServiceReceiveThread.NativeFieldInfoPtr__ForbiddenRequestResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (_ForbiddenRequestResponse));
      HttpServiceReceiveThread.NativeFieldInfoPtr__NotFoundResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (_NotFoundResponse));
      HttpServiceReceiveThread.NativeFieldInfoPtr__MethodNotAllowedResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (_MethodNotAllowedResponse));
      HttpServiceReceiveThread.NativeFieldInfoPtr_LastMessageReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (LastMessageReceived));
      HttpServiceReceiveThread.NativeFieldInfoPtr_LastMessageReceivedTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (LastMessageReceivedTicks));
      HttpServiceReceiveThread.NativeFieldInfoPtr_TryBuildPrometheusResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (TryBuildPrometheusResponse));
      HttpServiceReceiveThread.NativeFieldInfoPtr_ConsoleCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (ConsoleCommand));
      HttpServiceReceiveThread.NativeFieldInfoPtr_HandleConsoleCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (HandleConsoleCommand));
      HttpServiceReceiveThread.NativeFieldInfoPtr_HandleSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (HandleSave));
      HttpServiceReceiveThread.NativeFieldInfoPtr_HandleShutdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (HandleShutdown));
      HttpServiceReceiveThread.NativeFieldInfoPtr_HandleMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (HandleMessage));
      HttpServiceReceiveThread.NativeFieldInfoPtr__MessageResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (_MessageResponse));
      HttpServiceReceiveThread.NativeFieldInfoPtr__PrometheusStringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (_PrometheusStringBuilder));
      HttpServiceReceiveThread.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, 100690616);
      HttpServiceReceiveThread.NativeMethodInfoPtr_Shutdown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, 100690617);
      HttpServiceReceiveThread.NativeMethodInfoPtr_AddRoutes_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, 100690618);
      HttpServiceReceiveThread.NativeMethodInfoPtr_AddRoute_Private_Void_Route_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, 100690619);
      HttpServiceReceiveThread.NativeMethodInfoPtr_OnApiSave_Private_Void_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, 100690620);
      HttpServiceReceiveThread.NativeMethodInfoPtr_OnApiShutdown_Private_Void_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, 100690621);
      HttpServiceReceiveThread.NativeMethodInfoPtr_OnConsoleCommand_Private_Void_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, 100690622);
      HttpServiceReceiveThread.NativeMethodInfoPtr_OnApiMessage_Private_Void_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, 100690623);
      HttpServiceReceiveThread.NativeMethodInfoPtr_HandleContext_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, 100690624);
      HttpServiceReceiveThread.NativeMethodInfoPtr_HandleContext_Private_Void_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, 100690625);
      HttpServiceReceiveThread.NativeMethodInfoPtr_SendOkResponse_Private_Void_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, 100690626);
      HttpServiceReceiveThread.NativeMethodInfoPtr_SendNotFoundResponse_Private_Void_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, 100690627);
      HttpServiceReceiveThread.NativeMethodInfoPtr_SendMethodNotAllowedResponse_Private_Void_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, 100690628);
      HttpServiceReceiveThread.NativeMethodInfoPtr_SendBadRequest_Private_Void_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, 100690629);
      HttpServiceReceiveThread.NativeMethodInfoPtr_SendForbiddenRequest_Private_Void_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, 100690630);
      HttpServiceReceiveThread.NativeMethodInfoPtr_ReceiveLoop_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, 100690631);
      HttpServiceReceiveThread.NativeMethodInfoPtr_IsAllowed_Private_Boolean_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, 100690632);
      HttpServiceReceiveThread.NativeMethodInfoPtr_OnPrometheusScrapeManual_Private_Void_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, 100690633);
    }

    public HttpServiceReceiveThread(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool _UseSynchronousHandling
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__UseSynchronousHandling));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__UseSynchronousHandling)) = value;
      }
    }

    public unsafe bool _IsRunning
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__IsRunning));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__IsRunning)) = value;
      }
    }

    public unsafe HttpListener _Listener
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__Listener));
        return pointer == System.IntPtr.Zero ? (HttpListener) null : new HttpListener(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__Listener), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WaitCallback _handleContextCallback
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__handleContextCallback));
        return pointer == System.IntPtr.Zero ? (WaitCallback) null : new WaitCallback(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__handleContextCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Thread _ReceiveThread
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__ReceiveThread));
        return pointer == System.IntPtr.Zero ? (Thread) null : new Thread(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__ReceiveThread), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<HttpServiceReceiveThread.Route> _RegexRoutes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__RegexRoutes));
        return pointer == System.IntPtr.Zero ? (List<HttpServiceReceiveThread.Route>) null : new List<HttpServiceReceiveThread.Route>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__RegexRoutes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<IPAddress> _AccessList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__AccessList));
        return pointer == System.IntPtr.Zero ? (List<IPAddress>) null : new List<IPAddress>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__AccessList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HttpListenerResponse _OkResponse
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__OkResponse));
        return pointer == System.IntPtr.Zero ? (HttpListenerResponse) null : new HttpListenerResponse(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__OkResponse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HttpListenerResponse _BadRequestResponse
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__BadRequestResponse));
        return pointer == System.IntPtr.Zero ? (HttpListenerResponse) null : new HttpListenerResponse(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__BadRequestResponse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HttpListenerResponse _ForbiddenRequestResponse
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__ForbiddenRequestResponse));
        return pointer == System.IntPtr.Zero ? (HttpListenerResponse) null : new HttpListenerResponse(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__ForbiddenRequestResponse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HttpListenerResponse _NotFoundResponse
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__NotFoundResponse));
        return pointer == System.IntPtr.Zero ? (HttpListenerResponse) null : new HttpListenerResponse(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__NotFoundResponse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HttpListenerResponse _MethodNotAllowedResponse
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__MethodNotAllowedResponse));
        return pointer == System.IntPtr.Zero ? (HttpListenerResponse) null : new HttpListenerResponse(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__MethodNotAllowedResponse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe string LastMessageReceived
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(HttpServiceReceiveThread.NativeFieldInfoPtr_LastMessageReceived, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HttpServiceReceiveThread.NativeFieldInfoPtr_LastMessageReceived, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe long LastMessageReceivedTicks
    {
      get
      {
        long messageReceivedTicks;
        IL2CPP.il2cpp_field_static_get_value(HttpServiceReceiveThread.NativeFieldInfoPtr_LastMessageReceivedTicks, (void*) &messageReceivedTicks);
        return messageReceivedTicks;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HttpServiceReceiveThread.NativeFieldInfoPtr_LastMessageReceivedTicks, (void*) &value);
      }
    }

    public unsafe Il2CppSystem.Func<StringBuilder, bool> TryBuildPrometheusResponse
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr_TryBuildPrometheusResponse));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<StringBuilder, bool>) null : new Il2CppSystem.Func<StringBuilder, bool>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr_TryBuildPrometheusResponse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<string> ConsoleCommand
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr_ConsoleCommand));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<string>) null : new Il2CppSystem.Action<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr_ConsoleCommand), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<string> HandleConsoleCommand
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr_HandleConsoleCommand));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<string>) null : new Il2CppSystem.Action<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr_HandleConsoleCommand), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action HandleSave
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr_HandleSave));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr_HandleSave), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action HandleShutdown
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr_HandleShutdown));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr_HandleShutdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<string> HandleMessage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr_HandleMessage));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<string>) null : new Il2CppSystem.Action<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr_HandleMessage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MessageResponse _MessageResponse
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__MessageResponse));
        return pointer == System.IntPtr.Zero ? (MessageResponse) null : new MessageResponse(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__MessageResponse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StringBuilder _PrometheusStringBuilder
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__PrometheusStringBuilder));
        return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.NativeFieldInfoPtr__PrometheusStringBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Route : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Regex;
      private static readonly System.IntPtr NativeFieldInfoPtr_Method;
      private static readonly System.IntPtr NativeFieldInfoPtr_Handler;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Regex_String_RequestHandler_0;

      [CallerCount(15)]
      [CachedScanResults(RefRangeStart = 41534, RefRangeEnd = 41549, XrefRangeStart = 41534, XrefRangeEnd = 41549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Route(
        Regex regex,
        string method,
        HttpServiceReceiveThread.RequestHandler handler)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpServiceReceiveThread.Route>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) regex);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(method);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) handler);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.Route.NativeMethodInfoPtr__ctor_Public_Void_Regex_String_RequestHandler_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Route()
      {
        Il2CppClassPointerStore<HttpServiceReceiveThread.Route>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (Route));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpServiceReceiveThread.Route>.NativeClassPtr);
        HttpServiceReceiveThread.Route.NativeFieldInfoPtr_Regex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread.Route>.NativeClassPtr, nameof (Regex));
        HttpServiceReceiveThread.Route.NativeFieldInfoPtr_Method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread.Route>.NativeClassPtr, nameof (Method));
        HttpServiceReceiveThread.Route.NativeFieldInfoPtr_Handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceReceiveThread.Route>.NativeClassPtr, nameof (Handler));
        HttpServiceReceiveThread.Route.NativeMethodInfoPtr__ctor_Public_Void_Regex_String_RequestHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread.Route>.NativeClassPtr, 100690634);
      }

      public Route(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Route()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HttpServiceReceiveThread.Route>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HttpServiceReceiveThread.Route>.NativeClassPtr, data));
      }

      public unsafe Regex Regex
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.Route.NativeFieldInfoPtr_Regex));
          return pointer == System.IntPtr.Zero ? (Regex) null : new Regex(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.Route.NativeFieldInfoPtr_Regex), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe string Method
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.Route.NativeFieldInfoPtr_Method)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.Route.NativeFieldInfoPtr_Method), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe HttpServiceReceiveThread.RequestHandler Handler
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.Route.NativeFieldInfoPtr_Handler));
          return pointer == System.IntPtr.Zero ? (HttpServiceReceiveThread.RequestHandler) null : new HttpServiceReceiveThread.RequestHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HttpServiceReceiveThread.Route.NativeFieldInfoPtr_Handler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public sealed class RequestHandler : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HttpListenerContext_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HttpListenerContext_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe RequestHandler(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpServiceReceiveThread.RequestHandler>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.RequestHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12)]
      [CachedScanResults(RefRangeStart = 457887, RefRangeEnd = 457899, XrefRangeStart = 457887, XrefRangeEnd = 457899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(HttpListenerContext context)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.RequestHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 43644, RefRangeEnd = 43648, XrefRangeStart = 43644, XrefRangeEnd = 43648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        HttpListenerContext context,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.RequestHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HttpListenerContext_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(HttpServiceReceiveThread.RequestHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RequestHandler()
      {
        Il2CppClassPointerStore<HttpServiceReceiveThread.RequestHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpServiceReceiveThread>.NativeClassPtr, nameof (RequestHandler));
        HttpServiceReceiveThread.RequestHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread.RequestHandler>.NativeClassPtr, 100690635);
        HttpServiceReceiveThread.RequestHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread.RequestHandler>.NativeClassPtr, 100690636);
        HttpServiceReceiveThread.RequestHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_HttpListenerContext_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread.RequestHandler>.NativeClassPtr, 100690637);
        HttpServiceReceiveThread.RequestHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceReceiveThread.RequestHandler>.NativeClassPtr, 100690638);
      }

      public RequestHandler(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static implicit operator HttpServiceReceiveThread.RequestHandler(
        [In] System.Action<HttpListenerContext> obj0)
      {
        return DelegateSupport.ConvertDelegate<HttpServiceReceiveThread.RequestHandler>((System.Delegate) obj0);
      }

      public static HttpServiceReceiveThread.RequestHandler operator +(
        [In] HttpServiceReceiveThread.RequestHandler obj0,
        [In] HttpServiceReceiveThread.RequestHandler obj1)
      {
        return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<HttpServiceReceiveThread.RequestHandler>();
      }

      public static HttpServiceReceiveThread.RequestHandler operator -(
        [In] HttpServiceReceiveThread.RequestHandler obj0,
        [In] HttpServiceReceiveThread.RequestHandler obj1)
      {
        Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
        return (object) @delegate == null ? (HttpServiceReceiveThread.RequestHandler) @delegate : @delegate.Cast<HttpServiceReceiveThread.RequestHandler>();
      }
    }
  }
}
