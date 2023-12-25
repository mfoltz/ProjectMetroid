// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SendOnMissionEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SendOnMissionEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Throne;
    private static readonly System.IntPtr NativeFieldInfoPtr_Servant1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Servant2;
    private static readonly System.IntPtr NativeFieldInfoPtr_Servant3;
    private static readonly System.IntPtr NativeFieldInfoPtr_MissionDataID;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapZoneId;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    [FieldOffset(0)]
    public NetworkId Throne;
    [FieldOffset(8)]
    public NetworkId Servant1;
    [FieldOffset(16)]
    public NetworkId Servant2;
    [FieldOffset(24)]
    public NetworkId Servant3;
    [FieldOffset(32)]
    public int MissionDataID;
    [FieldOffset(36)]
    public MapZoneId MapZoneId;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145886, XrefRangeEnd = 1145895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SendOnMissionEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1145904, RefRangeEnd = 1145905, XrefRangeStart = 1145895, XrefRangeEnd = 1145904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SendOnMissionEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SendOnMissionEvent()
    {
      Il2CppClassPointerStore<SendOnMissionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (SendOnMissionEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendOnMissionEvent>.NativeClassPtr);
      SendOnMissionEvent.NativeFieldInfoPtr_Throne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendOnMissionEvent>.NativeClassPtr, nameof (Throne));
      SendOnMissionEvent.NativeFieldInfoPtr_Servant1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendOnMissionEvent>.NativeClassPtr, nameof (Servant1));
      SendOnMissionEvent.NativeFieldInfoPtr_Servant2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendOnMissionEvent>.NativeClassPtr, nameof (Servant2));
      SendOnMissionEvent.NativeFieldInfoPtr_Servant3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendOnMissionEvent>.NativeClassPtr, nameof (Servant3));
      SendOnMissionEvent.NativeFieldInfoPtr_MissionDataID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendOnMissionEvent>.NativeClassPtr, nameof (MissionDataID));
      SendOnMissionEvent.NativeFieldInfoPtr_MapZoneId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendOnMissionEvent>.NativeClassPtr, nameof (MapZoneId));
      SendOnMissionEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendOnMissionEvent>.NativeClassPtr, 100690874);
      SendOnMissionEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendOnMissionEvent>.NativeClassPtr, 100690875);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SendOnMissionEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
