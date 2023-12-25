// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.BlinkEntityEvent
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
  public struct BlinkEntityEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_BLINKS;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Generation;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    [FieldOffset(0)]
    public int Count;
    [FieldOffset(4)]
    public BlinkEntityEvent._NetworkIndex_e__FixedBuffer NetworkIndex;
    [FieldOffset(36)]
    public BlinkEntityEvent._Generation_e__FixedBuffer Generation;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145097, XrefRangeEnd = 1145100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlinkEntityEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1145103, RefRangeEnd = 1145104, XrefRangeStart = 1145100, XrefRangeEnd = 1145103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlinkEntityEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BlinkEntityEvent()
    {
      Il2CppClassPointerStore<BlinkEntityEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (BlinkEntityEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlinkEntityEvent>.NativeClassPtr);
      BlinkEntityEvent.NativeFieldInfoPtr_MAX_BLINKS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkEntityEvent>.NativeClassPtr, nameof (MAX_BLINKS));
      BlinkEntityEvent.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkEntityEvent>.NativeClassPtr, nameof (Count));
      BlinkEntityEvent.NativeFieldInfoPtr_NetworkIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkEntityEvent>.NativeClassPtr, nameof (NetworkIndex));
      BlinkEntityEvent.NativeFieldInfoPtr_Generation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkEntityEvent>.NativeClassPtr, nameof (Generation));
      BlinkEntityEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkEntityEvent>.NativeClassPtr, 100690639);
      BlinkEntityEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkEntityEvent>.NativeClassPtr, 100690640);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlinkEntityEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int MAX_BLINKS
    {
      get
      {
        int maxBlinks;
        IL2CPP.il2cpp_field_static_get_value(BlinkEntityEvent.NativeFieldInfoPtr_MAX_BLINKS, (void*) &maxBlinks);
        return maxBlinks;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BlinkEntityEvent.NativeFieldInfoPtr_MAX_BLINKS, (void*) &value);
      }
    }

    [ObfuscatedName("ProjectM.Network.BlinkEntityEvent/<NetworkIndex>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _NetworkIndex_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public int FixedElementField;

      static _NetworkIndex_e__FixedBuffer()
      {
        Il2CppClassPointerStore<BlinkEntityEvent._NetworkIndex_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlinkEntityEvent>.NativeClassPtr, "<NetworkIndex>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlinkEntityEvent._NetworkIndex_e__FixedBuffer>.NativeClassPtr);
        BlinkEntityEvent._NetworkIndex_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkEntityEvent._NetworkIndex_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlinkEntityEvent._NetworkIndex_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Network.BlinkEntityEvent/<Generation>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _Generation_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public byte FixedElementField;

      static _Generation_e__FixedBuffer()
      {
        Il2CppClassPointerStore<BlinkEntityEvent._Generation_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlinkEntityEvent>.NativeClassPtr, "<Generation>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlinkEntityEvent._Generation_e__FixedBuffer>.NativeClassPtr);
        BlinkEntityEvent._Generation_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkEntityEvent._Generation_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlinkEntityEvent._Generation_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
