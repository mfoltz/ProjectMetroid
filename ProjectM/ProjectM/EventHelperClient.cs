// Decompiled with JetBrains decompiler
// Type: ProjectM.EventHelperClient
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Network;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class EventHelperClient : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEventResponse_Local_Public_Static_Void_EntityManager_ResponseEventType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEventResponse_Local_Public_Static_Void_EntityCommandBuffer_ResponseEventType_0;

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 995165, RefRangeEnd = 995170, XrefRangeStart = 995161, XrefRangeEnd = 995165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateEventResponse_Local(
      EntityManager entityManager,
      ResponseEventType eventType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &eventType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelperClient.NativeMethodInfoPtr_CreateEventResponse_Local_Public_Static_Void_EntityManager_ResponseEventType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 995174, RefRangeEnd = 995178, XrefRangeStart = 995170, XrefRangeEnd = 995174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateEventResponse_Local(
      EntityCommandBuffer commandBuffer,
      ResponseEventType eventType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &eventType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventHelperClient.NativeMethodInfoPtr_CreateEventResponse_Local_Public_Static_Void_EntityCommandBuffer_ResponseEventType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EventHelperClient()
    {
      Il2CppClassPointerStore<EventHelperClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (EventHelperClient));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventHelperClient>.NativeClassPtr);
      EventHelperClient.NativeMethodInfoPtr_CreateEventResponse_Local_Public_Static_Void_EntityManager_ResponseEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelperClient>.NativeClassPtr, 100676857);
      EventHelperClient.NativeMethodInfoPtr_CreateEventResponse_Local_Public_Static_Void_EntityCommandBuffer_ResponseEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelperClient>.NativeClassPtr, 100676858);
    }

    public EventHelperClient(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
