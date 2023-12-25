// Decompiled with JetBrains decompiler
// Type: ProjectM.ForgeEvents
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Network;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ForgeEvents
  {
    static ForgeEvents()
    {
      Il2CppClassPointerStore<ForgeEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ForgeEvents));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgeEvents>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForgeEvents>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InsertItem
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FromInventory;
      private static readonly System.IntPtr NativeFieldInfoPtr_InventoryIndex;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public NetworkId FromInventory;
      [FieldOffset(8)]
      public int InventoryIndex;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051545, XrefRangeEnd = 1051550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ForgeEvents.InsertItem.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1051555, RefRangeEnd = 1051556, XrefRangeStart = 1051550, XrefRangeEnd = 1051555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ForgeEvents.InsertItem.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static InsertItem()
      {
        Il2CppClassPointerStore<ForgeEvents.InsertItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForgeEvents>.NativeClassPtr, nameof (InsertItem));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgeEvents.InsertItem>.NativeClassPtr);
        ForgeEvents.InsertItem.NativeFieldInfoPtr_FromInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeEvents.InsertItem>.NativeClassPtr, nameof (FromInventory));
        ForgeEvents.InsertItem.NativeFieldInfoPtr_InventoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeEvents.InsertItem>.NativeClassPtr, nameof (InventoryIndex));
        ForgeEvents.InsertItem.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeEvents.InsertItem>.NativeClassPtr, 100682621);
        ForgeEvents.InsertItem.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeEvents.InsertItem>.NativeClassPtr, 100682622);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForgeEvents.InsertItem>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RemoveItem
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ToInventory;
      private static readonly System.IntPtr NativeFieldInfoPtr_InventoryIndex;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public NetworkId ToInventory;
      [FieldOffset(8)]
      public int InventoryIndex;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051556, XrefRangeEnd = 1051561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ForgeEvents.RemoveItem.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1051566, RefRangeEnd = 1051567, XrefRangeStart = 1051561, XrefRangeEnd = 1051566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ForgeEvents.RemoveItem.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RemoveItem()
      {
        Il2CppClassPointerStore<ForgeEvents.RemoveItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForgeEvents>.NativeClassPtr, nameof (RemoveItem));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgeEvents.RemoveItem>.NativeClassPtr);
        ForgeEvents.RemoveItem.NativeFieldInfoPtr_ToInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeEvents.RemoveItem>.NativeClassPtr, nameof (ToInventory));
        ForgeEvents.RemoveItem.NativeFieldInfoPtr_InventoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeEvents.RemoveItem>.NativeClassPtr, nameof (InventoryIndex));
        ForgeEvents.RemoveItem.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeEvents.RemoveItem>.NativeClassPtr, 100682623);
        ForgeEvents.RemoveItem.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeEvents.RemoveItem>.NativeClassPtr, 100682624);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForgeEvents.RemoveItem>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct StartRepair
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ForgeEvents.StartRepair.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ForgeEvents.StartRepair.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static StartRepair()
      {
        Il2CppClassPointerStore<ForgeEvents.StartRepair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForgeEvents>.NativeClassPtr, nameof (StartRepair));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgeEvents.StartRepair>.NativeClassPtr);
        ForgeEvents.StartRepair.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeEvents.StartRepair>.NativeClassPtr, 100682625);
        ForgeEvents.StartRepair.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeEvents.StartRepair>.NativeClassPtr, 100682626);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForgeEvents.StartRepair>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CancelRepair
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ForgeEvents.CancelRepair.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ForgeEvents.CancelRepair.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CancelRepair()
      {
        Il2CppClassPointerStore<ForgeEvents.CancelRepair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForgeEvents>.NativeClassPtr, nameof (CancelRepair));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgeEvents.CancelRepair>.NativeClassPtr);
        ForgeEvents.CancelRepair.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeEvents.CancelRepair>.NativeClassPtr, 100682627);
        ForgeEvents.CancelRepair.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeEvents.CancelRepair>.NativeClassPtr, 100682628);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForgeEvents.CancelRepair>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ClaimItem
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ForgeEvents.ClaimItem.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ForgeEvents.ClaimItem.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ClaimItem()
      {
        Il2CppClassPointerStore<ForgeEvents.ClaimItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForgeEvents>.NativeClassPtr, nameof (ClaimItem));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgeEvents.ClaimItem>.NativeClassPtr);
        ForgeEvents.ClaimItem.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeEvents.ClaimItem>.NativeClassPtr, 100682629);
        ForgeEvents.ClaimItem.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeEvents.ClaimItem>.NativeClassPtr, 100682630);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForgeEvents.ClaimItem>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
