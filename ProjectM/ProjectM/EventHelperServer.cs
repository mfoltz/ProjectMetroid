// Decompiled with JetBrains decompiler
// Type: ProjectM.EventHelperServer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Network;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class EventHelperServer : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_SendEventResponse_Public_Static_Void_EntityManager_Entity_Boolean_ResponseEventType_ResponseEventType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendEventResponse_Public_Static_Void_EntityManager_User_Boolean_ResponseEventType_ResponseEventType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendEventResponse_Public_Static_Void_EntityManager_Entity_ResponseEventType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendEventResponse_Public_Static_Void_EntityManager_User_ResponseEventType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendGetTerritoryOwnerResponse_Public_Static_Void_EntityManager_Entity_Int32_FixedString64_0;

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 995109, RefRangeEnd = 995124, XrefRangeStart = 995100, XrefRangeEnd = 995109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendEventResponse(
      EntityManager entityManager,
      Entity userEntity,
      bool boolean,
      ResponseEventType trueResponse,
      ResponseEventType falseResponse)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &boolean;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &trueResponse;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &falseResponse;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelperServer.NativeMethodInfoPtr_SendEventResponse_Public_Static_Void_EntityManager_Entity_Boolean_ResponseEventType_ResponseEventType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995124, XrefRangeEnd = 995127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendEventResponse(
      EntityManager entityManager,
      User user,
      bool boolean,
      ResponseEventType trueResponse,
      ResponseEventType falseResponse)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &boolean;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &trueResponse;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &falseResponse;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelperServer.NativeMethodInfoPtr_SendEventResponse_Public_Static_Void_EntityManager_User_Boolean_ResponseEventType_ResponseEventType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 995136, RefRangeEnd = 995148, XrefRangeStart = 995127, XrefRangeEnd = 995136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendEventResponse(
      EntityManager entityManager,
      Entity userEntity,
      ResponseEventType responseType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &responseType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelperServer.NativeMethodInfoPtr_SendEventResponse_Public_Static_Void_EntityManager_Entity_ResponseEventType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995148, XrefRangeEnd = 995151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendEventResponse(
      EntityManager entityManager,
      User user,
      ResponseEventType responseType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &responseType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelperServer.NativeMethodInfoPtr_SendEventResponse_Public_Static_Void_EntityManager_User_ResponseEventType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 995160, RefRangeEnd = 995161, XrefRangeStart = 995151, XrefRangeEnd = 995160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendGetTerritoryOwnerResponse(
      EntityManager entityManager,
      Entity userEntity,
      int territoryIndex,
      FixedString64 name)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &territoryIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &name;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelperServer.NativeMethodInfoPtr_SendGetTerritoryOwnerResponse_Public_Static_Void_EntityManager_Entity_Int32_FixedString64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EventHelperServer()
    {
      Il2CppClassPointerStore<EventHelperServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (EventHelperServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventHelperServer>.NativeClassPtr);
      EventHelperServer.NativeMethodInfoPtr_SendEventResponse_Public_Static_Void_EntityManager_Entity_Boolean_ResponseEventType_ResponseEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelperServer>.NativeClassPtr, 100676852);
      EventHelperServer.NativeMethodInfoPtr_SendEventResponse_Public_Static_Void_EntityManager_User_Boolean_ResponseEventType_ResponseEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelperServer>.NativeClassPtr, 100676853);
      EventHelperServer.NativeMethodInfoPtr_SendEventResponse_Public_Static_Void_EntityManager_Entity_ResponseEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelperServer>.NativeClassPtr, 100676854);
      EventHelperServer.NativeMethodInfoPtr_SendEventResponse_Public_Static_Void_EntityManager_User_ResponseEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelperServer>.NativeClassPtr, 100676855);
      EventHelperServer.NativeMethodInfoPtr_SendGetTerritoryOwnerResponse_Public_Static_Void_EntityManager_Entity_Int32_FixedString64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelperServer>.NativeClassPtr, 100676856);
    }

    public EventHelperServer(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
