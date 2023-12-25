// Decompiled with JetBrains decompiler
// Type: ProjectM.RevealedMapEvent
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
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RevealedMapEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldZoneId;
    private static readonly System.IntPtr NativeFieldInfoPtr_PackedBufferLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_PackedRevealData;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEvent_Public_Static_RevealedMapEvent_WorldZoneId_DynamicBuffer_1_UserMapZonePackedRevealElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    [FieldOffset(0)]
    public WorldZoneId WorldZoneId;
    [FieldOffset(16)]
    public int PackedBufferLength;
    [FieldOffset(20)]
    public RevealedMapEvent._PackedRevealData_e__FixedBuffer PackedRevealData;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1048878, RefRangeEnd = 1048879, XrefRangeStart = 1048863, XrefRangeEnd = 1048878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RevealedMapEvent CreateEvent(
      WorldZoneId worldZoneId,
      DynamicBuffer<UserMapZonePackedRevealElement> revealedBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &worldZoneId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &revealedBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RevealedMapEvent.NativeMethodInfoPtr_CreateEvent_Public_Static_RevealedMapEvent_WorldZoneId_DynamicBuffer_1_UserMapZonePackedRevealElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RevealedMapEvent*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048879, XrefRangeEnd = 1048887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RevealedMapEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1048893, RefRangeEnd = 1048894, XrefRangeStart = 1048887, XrefRangeEnd = 1048893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RevealedMapEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RevealedMapEvent()
    {
      Il2CppClassPointerStore<RevealedMapEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RevealedMapEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevealedMapEvent>.NativeClassPtr);
      RevealedMapEvent.NativeFieldInfoPtr_WorldZoneId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealedMapEvent>.NativeClassPtr, nameof (WorldZoneId));
      RevealedMapEvent.NativeFieldInfoPtr_PackedBufferLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealedMapEvent>.NativeClassPtr, nameof (PackedBufferLength));
      RevealedMapEvent.NativeFieldInfoPtr_PackedRevealData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealedMapEvent>.NativeClassPtr, nameof (PackedRevealData));
      RevealedMapEvent.NativeMethodInfoPtr_CreateEvent_Public_Static_RevealedMapEvent_WorldZoneId_DynamicBuffer_1_UserMapZonePackedRevealElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealedMapEvent>.NativeClassPtr, 100682278);
      RevealedMapEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealedMapEvent>.NativeClassPtr, 100682279);
      RevealedMapEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealedMapEvent>.NativeClassPtr, 100682280);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RevealedMapEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [ObfuscatedName("ProjectM.RevealedMapEvent/<PackedRevealData>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _PackedRevealData_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public byte FixedElementField;

      static _PackedRevealData_e__FixedBuffer()
      {
        Il2CppClassPointerStore<RevealedMapEvent._PackedRevealData_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RevealedMapEvent>.NativeClassPtr, "<PackedRevealData>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevealedMapEvent._PackedRevealData_e__FixedBuffer>.NativeClassPtr);
        RevealedMapEvent._PackedRevealData_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealedMapEvent._PackedRevealData_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RevealedMapEvent._PackedRevealData_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
