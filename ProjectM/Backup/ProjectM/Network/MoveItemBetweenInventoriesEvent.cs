// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.MoveItemBetweenInventoriesEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MoveItemBetweenInventoriesEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FromInventory;
    private static readonly System.IntPtr NativeFieldInfoPtr_FromSlot;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToInventory;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToSlot;
    private static readonly System.IntPtr NativeFieldInfoPtr_TransferMethod;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    [FieldOffset(0)]
    public NetworkId FromInventory;
    [FieldOffset(8)]
    public int FromSlot;
    [FieldOffset(12)]
    public NetworkId ToInventory;
    [FieldOffset(20)]
    public int ToSlot;
    [FieldOffset(24)]
    public ItemTransferMethod TransferMethod;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145574, XrefRangeEnd = 1145582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoveItemBetweenInventoriesEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1145590, RefRangeEnd = 1145591, XrefRangeStart = 1145582, XrefRangeEnd = 1145590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoveItemBetweenInventoriesEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MoveItemBetweenInventoriesEvent()
    {
      Il2CppClassPointerStore<MoveItemBetweenInventoriesEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (MoveItemBetweenInventoriesEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemBetweenInventoriesEvent>.NativeClassPtr);
      MoveItemBetweenInventoriesEvent.NativeFieldInfoPtr_FromInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesEvent>.NativeClassPtr, nameof (FromInventory));
      MoveItemBetweenInventoriesEvent.NativeFieldInfoPtr_FromSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesEvent>.NativeClassPtr, nameof (FromSlot));
      MoveItemBetweenInventoriesEvent.NativeFieldInfoPtr_ToInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesEvent>.NativeClassPtr, nameof (ToInventory));
      MoveItemBetweenInventoriesEvent.NativeFieldInfoPtr_ToSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesEvent>.NativeClassPtr, nameof (ToSlot));
      MoveItemBetweenInventoriesEvent.NativeFieldInfoPtr_TransferMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesEvent>.NativeClassPtr, nameof (TransferMethod));
      MoveItemBetweenInventoriesEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBetweenInventoriesEvent>.NativeClassPtr, 100690808);
      MoveItemBetweenInventoriesEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBetweenInventoriesEvent>.NativeClassPtr, 100690809);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveItemBetweenInventoriesEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
