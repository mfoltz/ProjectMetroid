// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.PacketBookkeeperData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PacketBookkeeperData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PacketInfos;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntitiesInPacket;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyedInPacket;
    private static readonly System.IntPtr NativeFieldInfoPtr_Frame;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxUserCount;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginFrame_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIndexInPacketInfos_Public_Int32_PacketId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPacketInfo_Public_PacketInfo_PacketId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesInPacket_Public_NativeSlice_1_NetworkId_PacketId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDestroyedInPacket_Public_NativeSlice_1_Entity_PacketId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetPacketContentAndConfirm_Public_Boolean_PacketId_byref_NativeSlice_1_NetworkId_byref_NativeSlice_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsPacketIdWithinSavedRange_Public_Boolean_PacketId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntityStartIndex_Public_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDestroyStartIndex_Public_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearForUser_Public_Void_Int32_0;
    [FieldOffset(0)]
    public NativeArray<PacketInfo> PacketInfos;
    [FieldOffset(16)]
    public NativeArray<NetworkId> EntitiesInPacket;
    [FieldOffset(32)]
    public NativeArray<Entity> DestroyedInPacket;
    [FieldOffset(48)]
    public int Frame;
    [FieldOffset(52)]
    public readonly int MaxUserCount;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785247, RefRangeEnd = 785248, XrefRangeStart = 785238, XrefRangeEnd = 785247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PacketBookkeeperData(int maxUserCount, Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &maxUserCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PacketBookkeeperData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785257, RefRangeEnd = 785258, XrefRangeStart = 785248, XrefRangeEnd = 785257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PacketBookkeeperData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 42947, RefRangeEnd = 42948, XrefRangeStart = 42947, XrefRangeEnd = 42948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BeginFrame(int frame)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &frame;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PacketBookkeeperData.NativeMethodInfoPtr_BeginFrame_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe int GetIndexInPacketInfos(PacketId packetId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &packetId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketBookkeeperData.NativeMethodInfoPtr_GetIndexInPacketInfos_Public_Int32_PacketId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe PacketInfo GetPacketInfo(PacketId packetId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &packetId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketBookkeeperData.NativeMethodInfoPtr_GetPacketInfo_Public_PacketInfo_PacketId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PacketInfo*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785258, XrefRangeEnd = 785262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeSlice<NetworkId> GetEntitiesInPacket(PacketId packetId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &packetId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketBookkeeperData.NativeMethodInfoPtr_GetEntitiesInPacket_Public_NativeSlice_1_NetworkId_PacketId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeSlice<NetworkId>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785262, XrefRangeEnd = 785266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeSlice<Entity> GetDestroyedInPacket(PacketId packetId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &packetId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketBookkeeperData.NativeMethodInfoPtr_GetDestroyedInPacket_Public_NativeSlice_1_Entity_PacketId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeSlice<Entity>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785286, RefRangeEnd = 785287, XrefRangeStart = 785266, XrefRangeEnd = 785286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetPacketContentAndConfirm(
      PacketId packetId,
      out NativeSlice<NetworkId> entitiesInPacket,
      out NativeSlice<Entity> destroyedInPacket)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &packetId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entitiesInPacket;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref destroyedInPacket;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketBookkeeperData.NativeMethodInfoPtr_TryGetPacketContentAndConfirm_Public_Boolean_PacketId_byref_NativeSlice_1_NetworkId_byref_NativeSlice_1_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 785289, RefRangeEnd = 785291, XrefRangeStart = 785287, XrefRangeEnd = 785289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsPacketIdWithinSavedRange(PacketId packetId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &packetId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketBookkeeperData.NativeMethodInfoPtr_IsPacketIdWithinSavedRange_Public_Boolean_PacketId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe int GetEntityStartIndex(int frame, int userIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &frame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketBookkeeperData.NativeMethodInfoPtr_GetEntityStartIndex_Public_Int32_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe int GetDestroyStartIndex(int frame, int userIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &frame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketBookkeeperData.NativeMethodInfoPtr_GetDestroyStartIndex_Public_Int32_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785291, RefRangeEnd = 785292, XrefRangeStart = 785291, XrefRangeEnd = 785291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearForUser(int userIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &userIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PacketBookkeeperData.NativeMethodInfoPtr_ClearForUser_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PacketBookkeeperData()
    {
      Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (PacketBookkeeperData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr);
      PacketBookkeeperData.NativeFieldInfoPtr_PacketInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr, nameof (PacketInfos));
      PacketBookkeeperData.NativeFieldInfoPtr_EntitiesInPacket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr, nameof (EntitiesInPacket));
      PacketBookkeeperData.NativeFieldInfoPtr_DestroyedInPacket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr, nameof (DestroyedInPacket));
      PacketBookkeeperData.NativeFieldInfoPtr_Frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr, nameof (Frame));
      PacketBookkeeperData.NativeFieldInfoPtr_MaxUserCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr, nameof (MaxUserCount));
      PacketBookkeeperData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr, 100669174);
      PacketBookkeeperData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr, 100669175);
      PacketBookkeeperData.NativeMethodInfoPtr_BeginFrame_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr, 100669176);
      PacketBookkeeperData.NativeMethodInfoPtr_GetIndexInPacketInfos_Public_Int32_PacketId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr, 100669177);
      PacketBookkeeperData.NativeMethodInfoPtr_GetPacketInfo_Public_PacketInfo_PacketId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr, 100669178);
      PacketBookkeeperData.NativeMethodInfoPtr_GetEntitiesInPacket_Public_NativeSlice_1_NetworkId_PacketId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr, 100669179);
      PacketBookkeeperData.NativeMethodInfoPtr_GetDestroyedInPacket_Public_NativeSlice_1_Entity_PacketId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr, 100669180);
      PacketBookkeeperData.NativeMethodInfoPtr_TryGetPacketContentAndConfirm_Public_Boolean_PacketId_byref_NativeSlice_1_NetworkId_byref_NativeSlice_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr, 100669181);
      PacketBookkeeperData.NativeMethodInfoPtr_IsPacketIdWithinSavedRange_Public_Boolean_PacketId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr, 100669182);
      PacketBookkeeperData.NativeMethodInfoPtr_GetEntityStartIndex_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr, 100669183);
      PacketBookkeeperData.NativeMethodInfoPtr_GetDestroyStartIndex_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr, 100669184);
      PacketBookkeeperData.NativeMethodInfoPtr_ClearForUser_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr, 100669185);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PacketBookkeeperData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
