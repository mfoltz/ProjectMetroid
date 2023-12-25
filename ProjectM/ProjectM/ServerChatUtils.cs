// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerChatUtils
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class ServerChatUtils : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_SendSystemMessageToAllClients_Public_Static_Void_EntityManager_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendSystemMessageToAllClients_Public_Static_Void_EntityCommandBuffer_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendSystemMessageToClient_Public_Static_Void_EntityManager_User_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendSystemMessageToClient_Public_Static_Void_EntityCommandBuffer_User_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendChatMessage_Public_Static_Void_EntityCommandBuffer_byref_User_byref_FixedString512_byref_NetworkId_byref_NetworkId_ServerChatMessageType_Int64_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003423, XrefRangeEnd = 1003429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendSystemMessageToAllClients(
      EntityManager entityManager,
      string messageText)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(messageText);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerChatUtils.NativeMethodInfoPtr_SendSystemMessageToAllClients_Public_Static_Void_EntityManager_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003429, XrefRangeEnd = 1003435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendSystemMessageToAllClients(
      EntityCommandBuffer commandBuffer,
      string messageText)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(messageText);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerChatUtils.NativeMethodInfoPtr_SendSystemMessageToAllClients_Public_Static_Void_EntityCommandBuffer_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 1003441, RefRangeEnd = 1003451, XrefRangeStart = 1003435, XrefRangeEnd = 1003441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendSystemMessageToClient(
      EntityManager entityManager,
      User user,
      string messageText)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(messageText);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerChatUtils.NativeMethodInfoPtr_SendSystemMessageToClient_Public_Static_Void_EntityManager_User_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003451, XrefRangeEnd = 1003457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendSystemMessageToClient(
      EntityCommandBuffer commandBuffer,
      User user,
      string messageText)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(messageText);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerChatUtils.NativeMethodInfoPtr_SendSystemMessageToClient_Public_Static_Void_EntityCommandBuffer_User_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1003460, RefRangeEnd = 1003466, XrefRangeStart = 1003457, XrefRangeEnd = 1003460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendChatMessage(
      EntityCommandBuffer commandBuffer,
      [In] ref User toUser,
      [In] ref FixedString512 messageText,
      [In] ref NetworkId fromUser,
      [In] ref NetworkId fromCharacter,
      ServerChatMessageType messageType,
      long timeUTC)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref toUser;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref messageText;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromUser;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &messageType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &timeUTC;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerChatUtils.NativeMethodInfoPtr_SendChatMessage_Public_Static_Void_EntityCommandBuffer_byref_User_byref_FixedString512_byref_NetworkId_byref_NetworkId_ServerChatMessageType_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerChatUtils()
    {
      Il2CppClassPointerStore<ServerChatUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServerChatUtils));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerChatUtils>.NativeClassPtr);
      ServerChatUtils.NativeMethodInfoPtr_SendSystemMessageToAllClients_Public_Static_Void_EntityManager_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerChatUtils>.NativeClassPtr, 100677773);
      ServerChatUtils.NativeMethodInfoPtr_SendSystemMessageToAllClients_Public_Static_Void_EntityCommandBuffer_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerChatUtils>.NativeClassPtr, 100677774);
      ServerChatUtils.NativeMethodInfoPtr_SendSystemMessageToClient_Public_Static_Void_EntityManager_User_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerChatUtils>.NativeClassPtr, 100677775);
      ServerChatUtils.NativeMethodInfoPtr_SendSystemMessageToClient_Public_Static_Void_EntityCommandBuffer_User_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerChatUtils>.NativeClassPtr, 100677776);
      ServerChatUtils.NativeMethodInfoPtr_SendChatMessage_Public_Static_Void_EntityCommandBuffer_byref_User_byref_FixedString512_byref_NetworkId_byref_NetworkId_ServerChatMessageType_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerChatUtils>.NativeClassPtr, 100677777);
    }

    public ServerChatUtils(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
