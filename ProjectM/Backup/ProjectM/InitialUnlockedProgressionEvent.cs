// Decompiled with JetBrains decompiler
// Type: ProjectM.InitialUnlockedProgressionEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct InitialUnlockedProgressionEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_UNLOCKED_PROGRESSION;
    private static readonly System.IntPtr NativeFieldInfoPtr_DataLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_DATA_LENGTH_BYTES;
    private static readonly System.IntPtr NativeFieldInfoPtr_Data;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEvent_Public_Static_InitialUnlockedProgressionEvent_DynamicBuffer_1_UnlockedProgressionElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadEvent_Public_Static_Void_byref_InitialUnlockedProgressionEvent_DynamicBuffer_1_UnlockedProgressionElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    [FieldOffset(0)]
    public int DataLength;
    [FieldOffset(4)]
    public InitialUnlockedProgressionEvent._Data_e__FixedBuffer Data;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1062523, RefRangeEnd = 1062525, XrefRangeStart = 1062479, XrefRangeEnd = 1062523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe InitialUnlockedProgressionEvent CreateEvent(
      DynamicBuffer<UnlockedProgressionElement> unlockedProgression)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &unlockedProgression;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitialUnlockedProgressionEvent.NativeMethodInfoPtr_CreateEvent_Public_Static_InitialUnlockedProgressionEvent_DynamicBuffer_1_UnlockedProgressionElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(InitialUnlockedProgressionEvent*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1062549, RefRangeEnd = 1062551, XrefRangeStart = 1062525, XrefRangeEnd = 1062549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ReadEvent(
      [In] ref InitialUnlockedProgressionEvent initialUnlockedProgressionEvent,
      DynamicBuffer<UnlockedProgressionElement> unlockedProgression)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref initialUnlockedProgressionEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &unlockedProgression;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InitialUnlockedProgressionEvent.NativeMethodInfoPtr_ReadEvent_Public_Static_Void_byref_InitialUnlockedProgressionEvent_DynamicBuffer_1_UnlockedProgressionElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062551, XrefRangeEnd = 1062553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InitialUnlockedProgressionEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1062555, RefRangeEnd = 1062556, XrefRangeStart = 1062553, XrefRangeEnd = 1062555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InitialUnlockedProgressionEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InitialUnlockedProgressionEvent()
    {
      Il2CppClassPointerStore<InitialUnlockedProgressionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (InitialUnlockedProgressionEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitialUnlockedProgressionEvent>.NativeClassPtr);
      InitialUnlockedProgressionEvent.NativeFieldInfoPtr_MAX_UNLOCKED_PROGRESSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialUnlockedProgressionEvent>.NativeClassPtr, nameof (MAX_UNLOCKED_PROGRESSION));
      InitialUnlockedProgressionEvent.NativeFieldInfoPtr_DataLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialUnlockedProgressionEvent>.NativeClassPtr, nameof (DataLength));
      InitialUnlockedProgressionEvent.NativeFieldInfoPtr_MAX_DATA_LENGTH_BYTES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialUnlockedProgressionEvent>.NativeClassPtr, nameof (MAX_DATA_LENGTH_BYTES));
      InitialUnlockedProgressionEvent.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialUnlockedProgressionEvent>.NativeClassPtr, nameof (Data));
      InitialUnlockedProgressionEvent.NativeMethodInfoPtr_CreateEvent_Public_Static_InitialUnlockedProgressionEvent_DynamicBuffer_1_UnlockedProgressionElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialUnlockedProgressionEvent>.NativeClassPtr, 100683383);
      InitialUnlockedProgressionEvent.NativeMethodInfoPtr_ReadEvent_Public_Static_Void_byref_InitialUnlockedProgressionEvent_DynamicBuffer_1_UnlockedProgressionElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialUnlockedProgressionEvent>.NativeClassPtr, 100683384);
      InitialUnlockedProgressionEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialUnlockedProgressionEvent>.NativeClassPtr, 100683385);
      InitialUnlockedProgressionEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialUnlockedProgressionEvent>.NativeClassPtr, 100683386);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InitialUnlockedProgressionEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int MAX_UNLOCKED_PROGRESSION
    {
      get
      {
        int unlockedProgression;
        IL2CPP.il2cpp_field_static_get_value(InitialUnlockedProgressionEvent.NativeFieldInfoPtr_MAX_UNLOCKED_PROGRESSION, (void*) &unlockedProgression);
        return unlockedProgression;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InitialUnlockedProgressionEvent.NativeFieldInfoPtr_MAX_UNLOCKED_PROGRESSION, (void*) &value);
      }
    }

    public static unsafe int MAX_DATA_LENGTH_BYTES
    {
      get
      {
        int maxDataLengthBytes;
        IL2CPP.il2cpp_field_static_get_value(InitialUnlockedProgressionEvent.NativeFieldInfoPtr_MAX_DATA_LENGTH_BYTES, (void*) &maxDataLengthBytes);
        return maxDataLengthBytes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InitialUnlockedProgressionEvent.NativeFieldInfoPtr_MAX_DATA_LENGTH_BYTES, (void*) &value);
      }
    }

    [ObfuscatedName("ProjectM.InitialUnlockedProgressionEvent/<Data>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _Data_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public byte FixedElementField;

      static _Data_e__FixedBuffer()
      {
        Il2CppClassPointerStore<InitialUnlockedProgressionEvent._Data_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitialUnlockedProgressionEvent>.NativeClassPtr, "<Data>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitialUnlockedProgressionEvent._Data_e__FixedBuffer>.NativeClassPtr);
        InitialUnlockedProgressionEvent._Data_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialUnlockedProgressionEvent._Data_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InitialUnlockedProgressionEvent._Data_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
