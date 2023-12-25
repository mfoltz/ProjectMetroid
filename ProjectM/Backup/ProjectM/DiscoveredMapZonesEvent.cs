// Decompiled with JetBrains decompiler
// Type: ProjectM.DiscoveredMapZonesEvent
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
  public struct DiscoveredMapZonesEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_ZONES;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapZoneDataLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_DATA_LENGTH_BYTES;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapZoneData;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEvent_Public_Static_DiscoveredMapZonesEvent_DynamicBuffer_1_DiscoveredMapZoneElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadEvent_Public_Static_Void_byref_DiscoveredMapZonesEvent_DynamicBuffer_1_DiscoveredMapZoneElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    [FieldOffset(0)]
    public int MapZoneDataLength;
    [FieldOffset(4)]
    public DiscoveredMapZonesEvent._MapZoneData_e__FixedBuffer MapZoneData;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1048147, RefRangeEnd = 1048149, XrefRangeStart = 1048101, XrefRangeEnd = 1048147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe DiscoveredMapZonesEvent CreateEvent(
      DynamicBuffer<DiscoveredMapZoneElement> discoveredMapZoneElements)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &discoveredMapZoneElements;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DiscoveredMapZonesEvent.NativeMethodInfoPtr_CreateEvent_Public_Static_DiscoveredMapZonesEvent_DynamicBuffer_1_DiscoveredMapZoneElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DiscoveredMapZonesEvent*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1048168, RefRangeEnd = 1048170, XrefRangeStart = 1048149, XrefRangeEnd = 1048168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ReadEvent(
      [In] ref DiscoveredMapZonesEvent discoveredMapZonesEvent,
      DynamicBuffer<DiscoveredMapZoneElement> discoveredMapZoneElements)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref discoveredMapZonesEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &discoveredMapZoneElements;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DiscoveredMapZonesEvent.NativeMethodInfoPtr_ReadEvent_Public_Static_Void_byref_DiscoveredMapZonesEvent_DynamicBuffer_1_DiscoveredMapZoneElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048170, XrefRangeEnd = 1048172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DiscoveredMapZonesEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1048174, RefRangeEnd = 1048175, XrefRangeStart = 1048172, XrefRangeEnd = 1048174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DiscoveredMapZonesEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DiscoveredMapZonesEvent()
    {
      Il2CppClassPointerStore<DiscoveredMapZonesEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DiscoveredMapZonesEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscoveredMapZonesEvent>.NativeClassPtr);
      DiscoveredMapZonesEvent.NativeFieldInfoPtr_MAX_ZONES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscoveredMapZonesEvent>.NativeClassPtr, nameof (MAX_ZONES));
      DiscoveredMapZonesEvent.NativeFieldInfoPtr_MapZoneDataLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscoveredMapZonesEvent>.NativeClassPtr, nameof (MapZoneDataLength));
      DiscoveredMapZonesEvent.NativeFieldInfoPtr_MAX_DATA_LENGTH_BYTES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscoveredMapZonesEvent>.NativeClassPtr, nameof (MAX_DATA_LENGTH_BYTES));
      DiscoveredMapZonesEvent.NativeFieldInfoPtr_MapZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscoveredMapZonesEvent>.NativeClassPtr, nameof (MapZoneData));
      DiscoveredMapZonesEvent.NativeMethodInfoPtr_CreateEvent_Public_Static_DiscoveredMapZonesEvent_DynamicBuffer_1_DiscoveredMapZoneElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscoveredMapZonesEvent>.NativeClassPtr, 100682198);
      DiscoveredMapZonesEvent.NativeMethodInfoPtr_ReadEvent_Public_Static_Void_byref_DiscoveredMapZonesEvent_DynamicBuffer_1_DiscoveredMapZoneElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscoveredMapZonesEvent>.NativeClassPtr, 100682199);
      DiscoveredMapZonesEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscoveredMapZonesEvent>.NativeClassPtr, 100682200);
      DiscoveredMapZonesEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscoveredMapZonesEvent>.NativeClassPtr, 100682201);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DiscoveredMapZonesEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int MAX_ZONES
    {
      get
      {
        int maxZones;
        IL2CPP.il2cpp_field_static_get_value(DiscoveredMapZonesEvent.NativeFieldInfoPtr_MAX_ZONES, (void*) &maxZones);
        return maxZones;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DiscoveredMapZonesEvent.NativeFieldInfoPtr_MAX_ZONES, (void*) &value);
      }
    }

    public static unsafe int MAX_DATA_LENGTH_BYTES
    {
      get
      {
        int maxDataLengthBytes;
        IL2CPP.il2cpp_field_static_get_value(DiscoveredMapZonesEvent.NativeFieldInfoPtr_MAX_DATA_LENGTH_BYTES, (void*) &maxDataLengthBytes);
        return maxDataLengthBytes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DiscoveredMapZonesEvent.NativeFieldInfoPtr_MAX_DATA_LENGTH_BYTES, (void*) &value);
      }
    }

    [ObfuscatedName("ProjectM.DiscoveredMapZonesEvent/<MapZoneData>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _MapZoneData_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public byte FixedElementField;

      static _MapZoneData_e__FixedBuffer()
      {
        Il2CppClassPointerStore<DiscoveredMapZonesEvent._MapZoneData_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DiscoveredMapZonesEvent>.NativeClassPtr, "<MapZoneData>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscoveredMapZonesEvent._MapZoneData_e__FixedBuffer>.NativeClassPtr);
        DiscoveredMapZonesEvent._MapZoneData_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscoveredMapZonesEvent._MapZoneData_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DiscoveredMapZonesEvent._MapZoneData_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
