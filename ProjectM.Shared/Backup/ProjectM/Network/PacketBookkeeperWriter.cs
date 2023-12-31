// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.PacketBookkeeperWriter
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PacketBookkeeperWriter
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Data;
    private static readonly System.IntPtr NativeFieldInfoPtr__PacketId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityStart;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyedStart;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasBegun;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PacketId_Public_get_PacketId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_PacketBookkeeperData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginPacket_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddEntity_Public_Void_NetworkId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddDestroyed_Public_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EntityInPacket_Public_Boolean_NetworkId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FinalizePacket_Public_Void_0;
    [FieldOffset(0)]
    public PacketBookkeeperData Data;
    [FieldOffset(56)]
    public readonly PacketId _PacketId_k__BackingField;
    [FieldOffset(64)]
    public readonly int EntityStart;
    [FieldOffset(68)]
    public readonly int DestroyedStart;
    [FieldOffset(72)]
    public int EntityCount;
    [FieldOffset(76)]
    public int DestroyCount;
    [FieldOffset(80)]
    public bool HasBegun;

    public unsafe PacketId PacketId
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 22398, RefRangeEnd = 22405, XrefRangeStart = 22398, XrefRangeEnd = 22405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketBookkeeperWriter.NativeMethodInfoPtr_get_PacketId_Public_get_PacketId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PacketId*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    public unsafe PacketBookkeeperWriter(int userIndex, PacketBookkeeperData data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &userIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PacketBookkeeperWriter.NativeMethodInfoPtr__ctor_Public_Void_Int32_PacketBookkeeperData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785292, XrefRangeEnd = 785294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BeginPacket()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PacketBookkeeperWriter.NativeMethodInfoPtr_BeginPacket_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785294, XrefRangeEnd = 785296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddEntity(NetworkId networkId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &networkId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PacketBookkeeperWriter.NativeMethodInfoPtr_AddEntity_Public_Void_NetworkId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785296, XrefRangeEnd = 785298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddDestroyed(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PacketBookkeeperWriter.NativeMethodInfoPtr_AddDestroyed_Public_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785298, XrefRangeEnd = 785302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool EntityInPacket(NetworkId networkId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &networkId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketBookkeeperWriter.NativeMethodInfoPtr_EntityInPacket_Public_Boolean_NetworkId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785302, XrefRangeEnd = 785303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FinalizePacket()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PacketBookkeeperWriter.NativeMethodInfoPtr_FinalizePacket_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PacketBookkeeperWriter()
    {
      Il2CppClassPointerStore<PacketBookkeeperWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (PacketBookkeeperWriter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PacketBookkeeperWriter>.NativeClassPtr);
      PacketBookkeeperWriter.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketBookkeeperWriter>.NativeClassPtr, nameof (Data));
      PacketBookkeeperWriter.NativeFieldInfoPtr__PacketId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketBookkeeperWriter>.NativeClassPtr, "<PacketId>k__BackingField");
      PacketBookkeeperWriter.NativeFieldInfoPtr_EntityStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketBookkeeperWriter>.NativeClassPtr, nameof (EntityStart));
      PacketBookkeeperWriter.NativeFieldInfoPtr_DestroyedStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketBookkeeperWriter>.NativeClassPtr, nameof (DestroyedStart));
      PacketBookkeeperWriter.NativeFieldInfoPtr_EntityCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketBookkeeperWriter>.NativeClassPtr, nameof (EntityCount));
      PacketBookkeeperWriter.NativeFieldInfoPtr_DestroyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketBookkeeperWriter>.NativeClassPtr, nameof (DestroyCount));
      PacketBookkeeperWriter.NativeFieldInfoPtr_HasBegun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketBookkeeperWriter>.NativeClassPtr, nameof (HasBegun));
      PacketBookkeeperWriter.NativeMethodInfoPtr_get_PacketId_Public_get_PacketId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketBookkeeperWriter>.NativeClassPtr, 100669186);
      PacketBookkeeperWriter.NativeMethodInfoPtr__ctor_Public_Void_Int32_PacketBookkeeperData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketBookkeeperWriter>.NativeClassPtr, 100669187);
      PacketBookkeeperWriter.NativeMethodInfoPtr_BeginPacket_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketBookkeeperWriter>.NativeClassPtr, 100669188);
      PacketBookkeeperWriter.NativeMethodInfoPtr_AddEntity_Public_Void_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketBookkeeperWriter>.NativeClassPtr, 100669189);
      PacketBookkeeperWriter.NativeMethodInfoPtr_AddDestroyed_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketBookkeeperWriter>.NativeClassPtr, 100669190);
      PacketBookkeeperWriter.NativeMethodInfoPtr_EntityInPacket_Public_Boolean_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketBookkeeperWriter>.NativeClassPtr, 100669191);
      PacketBookkeeperWriter.NativeMethodInfoPtr_FinalizePacket_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketBookkeeperWriter>.NativeClassPtr, 100669192);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PacketBookkeeperWriter>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
