// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.EquipBagFromInventoryEvent
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
  public struct EquipBagFromInventoryEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FromInventory;
    private static readonly System.IntPtr NativeFieldInfoPtr_FromInventoryIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToBagSlotIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    [FieldOffset(0)]
    public NetworkId FromInventory;
    [FieldOffset(8)]
    public int FromInventoryIndex;
    [FieldOffset(12)]
    public int ToBagSlotIndex;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145537, XrefRangeEnd = 1145543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EquipBagFromInventoryEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1145549, RefRangeEnd = 1145550, XrefRangeStart = 1145543, XrefRangeEnd = 1145549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EquipBagFromInventoryEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EquipBagFromInventoryEvent()
    {
      Il2CppClassPointerStore<EquipBagFromInventoryEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (EquipBagFromInventoryEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipBagFromInventoryEvent>.NativeClassPtr);
      EquipBagFromInventoryEvent.NativeFieldInfoPtr_FromInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipBagFromInventoryEvent>.NativeClassPtr, nameof (FromInventory));
      EquipBagFromInventoryEvent.NativeFieldInfoPtr_FromInventoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipBagFromInventoryEvent>.NativeClassPtr, nameof (FromInventoryIndex));
      EquipBagFromInventoryEvent.NativeFieldInfoPtr_ToBagSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipBagFromInventoryEvent>.NativeClassPtr, nameof (ToBagSlotIndex));
      EquipBagFromInventoryEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipBagFromInventoryEvent>.NativeClassPtr, 100690794);
      EquipBagFromInventoryEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipBagFromInventoryEvent>.NativeClassPtr, 100690795);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EquipBagFromInventoryEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
