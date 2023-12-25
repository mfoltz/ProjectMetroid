// Decompiled with JetBrains decompiler
// Type: ProjectM.ClientSystemChatUtils
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
  public static class ClientSystemChatUtils : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_AddLocalSystemMessage_Public_Static_Void_EntityCommandBuffer_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddLocalSystemMessage_Public_Static_Void_EntityManager_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddLocalMessage_Public_Static_Void_EntityCommandBuffer_String_ServerChatMessageType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddLocalMessage_Public_Static_Void_EntityManager_String_ServerChatMessageType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNameWithColor_Public_Static_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNameWithColor_Public_Static_String_FixedString64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddLocalMessage_Public_Static_Void_EntityManager_String_ServerChatMessageType_NetworkId_NetworkId_NetworkId_0;

    [CallerCount(19)]
    [CachedScanResults(RefRangeStart = 1003322, RefRangeEnd = 1003341, XrefRangeStart = 1003308, XrefRangeEnd = 1003322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddLocalSystemMessage(
      EntityCommandBuffer commandBuffer,
      string message)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientSystemChatUtils.NativeMethodInfoPtr_AddLocalSystemMessage_Public_Static_Void_EntityCommandBuffer_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1003355, RefRangeEnd = 1003360, XrefRangeStart = 1003341, XrefRangeEnd = 1003355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddLocalSystemMessage(EntityManager entityManager, string message)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientSystemChatUtils.NativeMethodInfoPtr_AddLocalSystemMessage_Public_Static_Void_EntityManager_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003360, XrefRangeEnd = 1003374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddLocalMessage(
      EntityCommandBuffer commandBuffer,
      string message,
      ServerChatMessageType messageType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &messageType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientSystemChatUtils.NativeMethodInfoPtr_AddLocalMessage_Public_Static_Void_EntityCommandBuffer_String_ServerChatMessageType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1003388, RefRangeEnd = 1003390, XrefRangeStart = 1003374, XrefRangeEnd = 1003388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddLocalMessage(
      EntityManager entityManager,
      string message,
      ServerChatMessageType messageType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &messageType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientSystemChatUtils.NativeMethodInfoPtr_AddLocalMessage_Public_Static_Void_EntityManager_String_ServerChatMessageType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003390, XrefRangeEnd = 1003395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetNameWithColor(string name)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ClientSystemChatUtils.NativeMethodInfoPtr_GetNameWithColor_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1003403, RefRangeEnd = 1003408, XrefRangeStart = 1003395, XrefRangeEnd = 1003403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetNameWithColor(FixedString64 name)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &name;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ClientSystemChatUtils.NativeMethodInfoPtr_GetNameWithColor_Public_Static_String_FixedString64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1003422, RefRangeEnd = 1003423, XrefRangeStart = 1003408, XrefRangeEnd = 1003422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddLocalMessage(
      EntityManager entityManager,
      string message,
      ServerChatMessageType messageType,
      NetworkId fromUser,
      NetworkId fromCharacter,
      NetworkId toUser = default (NetworkId))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &messageType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &fromUser;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &fromCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &toUser;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientSystemChatUtils.NativeMethodInfoPtr_AddLocalMessage_Public_Static_Void_EntityManager_String_ServerChatMessageType_NetworkId_NetworkId_NetworkId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClientSystemChatUtils()
    {
      Il2CppClassPointerStore<ClientSystemChatUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ClientSystemChatUtils));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientSystemChatUtils>.NativeClassPtr);
      ClientSystemChatUtils.NativeMethodInfoPtr_AddLocalSystemMessage_Public_Static_Void_EntityCommandBuffer_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSystemChatUtils>.NativeClassPtr, 100677766);
      ClientSystemChatUtils.NativeMethodInfoPtr_AddLocalSystemMessage_Public_Static_Void_EntityManager_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSystemChatUtils>.NativeClassPtr, 100677767);
      ClientSystemChatUtils.NativeMethodInfoPtr_AddLocalMessage_Public_Static_Void_EntityCommandBuffer_String_ServerChatMessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSystemChatUtils>.NativeClassPtr, 100677768);
      ClientSystemChatUtils.NativeMethodInfoPtr_AddLocalMessage_Public_Static_Void_EntityManager_String_ServerChatMessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSystemChatUtils>.NativeClassPtr, 100677769);
      ClientSystemChatUtils.NativeMethodInfoPtr_GetNameWithColor_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSystemChatUtils>.NativeClassPtr, 100677770);
      ClientSystemChatUtils.NativeMethodInfoPtr_GetNameWithColor_Public_Static_String_FixedString64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSystemChatUtils>.NativeClassPtr, 100677771);
      ClientSystemChatUtils.NativeMethodInfoPtr_AddLocalMessage_Public_Static_Void_EntityManager_String_ServerChatMessageType_NetworkId_NetworkId_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSystemChatUtils>.NativeClassPtr, 100677772);
    }

    public ClientSystemChatUtils(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
