// Decompiled with JetBrains decompiler
// Type: ProjectM.ClaimedAchievementsEvent
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
  public struct ClaimedAchievementsEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_ACHIEVEMENTS;
    private static readonly System.IntPtr NativeFieldInfoPtr_DataLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_DATA_LENGTH_BYTES;
    private static readonly System.IntPtr NativeFieldInfoPtr_Data;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEvent_Public_Static_ClaimedAchievementsEvent_DynamicBuffer_1_AchievementClaimedElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadEvent_Public_Static_Void_byref_ClaimedAchievementsEvent_DynamicBuffer_1_AchievementClaimedElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    [FieldOffset(0)]
    public int DataLength;
    [FieldOffset(4)]
    public ClaimedAchievementsEvent._Data_e__FixedBuffer Data;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1062454, RefRangeEnd = 1062456, XrefRangeStart = 1062411, XrefRangeEnd = 1062454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ClaimedAchievementsEvent CreateEvent(
      DynamicBuffer<AchievementClaimedElement> claimedAchievements)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &claimedAchievements;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClaimedAchievementsEvent.NativeMethodInfoPtr_CreateEvent_Public_Static_ClaimedAchievementsEvent_DynamicBuffer_1_AchievementClaimedElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ClaimedAchievementsEvent*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1062472, RefRangeEnd = 1062474, XrefRangeStart = 1062456, XrefRangeEnd = 1062472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ReadEvent(
      [In] ref ClaimedAchievementsEvent claimedAchievementsEvent,
      DynamicBuffer<AchievementClaimedElement> claimedAchievements)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref claimedAchievementsEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &claimedAchievements;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClaimedAchievementsEvent.NativeMethodInfoPtr_ReadEvent_Public_Static_Void_byref_ClaimedAchievementsEvent_DynamicBuffer_1_AchievementClaimedElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062474, XrefRangeEnd = 1062476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClaimedAchievementsEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1062478, RefRangeEnd = 1062479, XrefRangeStart = 1062476, XrefRangeEnd = 1062478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClaimedAchievementsEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClaimedAchievementsEvent()
    {
      Il2CppClassPointerStore<ClaimedAchievementsEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ClaimedAchievementsEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClaimedAchievementsEvent>.NativeClassPtr);
      ClaimedAchievementsEvent.NativeFieldInfoPtr_MAX_ACHIEVEMENTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimedAchievementsEvent>.NativeClassPtr, nameof (MAX_ACHIEVEMENTS));
      ClaimedAchievementsEvent.NativeFieldInfoPtr_DataLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimedAchievementsEvent>.NativeClassPtr, nameof (DataLength));
      ClaimedAchievementsEvent.NativeFieldInfoPtr_MAX_DATA_LENGTH_BYTES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimedAchievementsEvent>.NativeClassPtr, nameof (MAX_DATA_LENGTH_BYTES));
      ClaimedAchievementsEvent.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimedAchievementsEvent>.NativeClassPtr, nameof (Data));
      ClaimedAchievementsEvent.NativeMethodInfoPtr_CreateEvent_Public_Static_ClaimedAchievementsEvent_DynamicBuffer_1_AchievementClaimedElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimedAchievementsEvent>.NativeClassPtr, 100683379);
      ClaimedAchievementsEvent.NativeMethodInfoPtr_ReadEvent_Public_Static_Void_byref_ClaimedAchievementsEvent_DynamicBuffer_1_AchievementClaimedElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimedAchievementsEvent>.NativeClassPtr, 100683380);
      ClaimedAchievementsEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimedAchievementsEvent>.NativeClassPtr, 100683381);
      ClaimedAchievementsEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimedAchievementsEvent>.NativeClassPtr, 100683382);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClaimedAchievementsEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int MAX_ACHIEVEMENTS
    {
      get
      {
        int maxAchievements;
        IL2CPP.il2cpp_field_static_get_value(ClaimedAchievementsEvent.NativeFieldInfoPtr_MAX_ACHIEVEMENTS, (void*) &maxAchievements);
        return maxAchievements;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ClaimedAchievementsEvent.NativeFieldInfoPtr_MAX_ACHIEVEMENTS, (void*) &value);
      }
    }

    public static unsafe int MAX_DATA_LENGTH_BYTES
    {
      get
      {
        int maxDataLengthBytes;
        IL2CPP.il2cpp_field_static_get_value(ClaimedAchievementsEvent.NativeFieldInfoPtr_MAX_DATA_LENGTH_BYTES, (void*) &maxDataLengthBytes);
        return maxDataLengthBytes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ClaimedAchievementsEvent.NativeFieldInfoPtr_MAX_DATA_LENGTH_BYTES, (void*) &value);
      }
    }

    [ObfuscatedName("ProjectM.ClaimedAchievementsEvent/<Data>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _Data_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public byte FixedElementField;

      static _Data_e__FixedBuffer()
      {
        Il2CppClassPointerStore<ClaimedAchievementsEvent._Data_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClaimedAchievementsEvent>.NativeClassPtr, "<Data>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClaimedAchievementsEvent._Data_e__FixedBuffer>.NativeClassPtr);
        ClaimedAchievementsEvent._Data_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimedAchievementsEvent._Data_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClaimedAchievementsEvent._Data_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
