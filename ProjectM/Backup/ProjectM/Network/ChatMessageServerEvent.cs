// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.ChatMessageServerEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ChatMessageServerEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeUTC;
    private static readonly System.IntPtr NativeFieldInfoPtr_MessageType;
    private static readonly System.IntPtr NativeFieldInfoPtr_MessageText;
    private static readonly System.IntPtr NativeFieldInfoPtr_FromUser;
    private static readonly System.IntPtr NativeFieldInfoPtr_FromCharacter;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    [FieldOffset(0)]
    public long TimeUTC;
    [FieldOffset(8)]
    public ServerChatMessageType MessageType;
    [FieldOffset(12)]
    public FixedString512 MessageText;
    [FieldOffset(524)]
    public NetworkId FromUser;
    [FieldOffset(532)]
    public NetworkId FromCharacter;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1146454, XrefRangeEnd = 1146462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChatMessageServerEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1146470, RefRangeEnd = 1146471, XrefRangeStart = 1146462, XrefRangeEnd = 1146470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChatMessageServerEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChatMessageServerEvent()
    {
      Il2CppClassPointerStore<ChatMessageServerEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (ChatMessageServerEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatMessageServerEvent>.NativeClassPtr);
      ChatMessageServerEvent.NativeFieldInfoPtr_TimeUTC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageServerEvent>.NativeClassPtr, nameof (TimeUTC));
      ChatMessageServerEvent.NativeFieldInfoPtr_MessageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageServerEvent>.NativeClassPtr, nameof (MessageType));
      ChatMessageServerEvent.NativeFieldInfoPtr_MessageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageServerEvent>.NativeClassPtr, nameof (MessageText));
      ChatMessageServerEvent.NativeFieldInfoPtr_FromUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageServerEvent>.NativeClassPtr, nameof (FromUser));
      ChatMessageServerEvent.NativeFieldInfoPtr_FromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageServerEvent>.NativeClassPtr, nameof (FromCharacter));
      ChatMessageServerEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageServerEvent>.NativeClassPtr, 100691008);
      ChatMessageServerEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageServerEvent>.NativeClassPtr, 100691009);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChatMessageServerEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
