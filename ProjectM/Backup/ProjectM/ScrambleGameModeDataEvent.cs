// Decompiled with JetBrains decompiler
// Type: ProjectM.ScrambleGameModeDataEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ScrambleGameModeDataEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_VBLOOD_UNITS;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_VBLOOD_ABILITIES;
    private static readonly System.IntPtr NativeFieldInfoPtr_DataLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_DATA_LENGTH_BYTES;
    private static readonly System.IntPtr NativeFieldInfoPtr_Data;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEvent_Public_Static_ScrambleGameModeDataEvent_ScrambleGameModeSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadEvent_Public_Static_ScrambleGameModeSettings_byref_ScrambleGameModeDataEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    [FieldOffset(0)]
    public int DataLength;
    [FieldOffset(4)]
    public ScrambleGameModeDataEvent._Data_e__FixedBuffer Data;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1062868, RefRangeEnd = 1062870, XrefRangeStart = 1062848, XrefRangeEnd = 1062868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ScrambleGameModeDataEvent CreateEvent(
      ScrambleGameModeSettings scrambleGameModeSettings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) scrambleGameModeSettings));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeDataEvent.NativeMethodInfoPtr_CreateEvent_Public_Static_ScrambleGameModeDataEvent_ScrambleGameModeSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ScrambleGameModeDataEvent*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1062881, RefRangeEnd = 1062882, XrefRangeStart = 1062870, XrefRangeEnd = 1062881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ScrambleGameModeSettings ReadEvent(
      [In] ref ScrambleGameModeDataEvent initialUnlockedProgressionEvent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref initialUnlockedProgressionEvent;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeDataEvent.NativeMethodInfoPtr_ReadEvent_Public_Static_ScrambleGameModeSettings_byref_ScrambleGameModeDataEvent_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new ScrambleGameModeSettings(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062882, XrefRangeEnd = 1062884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeDataEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1062886, RefRangeEnd = 1062887, XrefRangeStart = 1062884, XrefRangeEnd = 1062886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeDataEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ScrambleGameModeDataEvent()
    {
      Il2CppClassPointerStore<ScrambleGameModeDataEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ScrambleGameModeDataEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrambleGameModeDataEvent>.NativeClassPtr);
      ScrambleGameModeDataEvent.NativeFieldInfoPtr_MAX_VBLOOD_UNITS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeDataEvent>.NativeClassPtr, nameof (MAX_VBLOOD_UNITS));
      ScrambleGameModeDataEvent.NativeFieldInfoPtr_MAX_VBLOOD_ABILITIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeDataEvent>.NativeClassPtr, nameof (MAX_VBLOOD_ABILITIES));
      ScrambleGameModeDataEvent.NativeFieldInfoPtr_DataLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeDataEvent>.NativeClassPtr, nameof (DataLength));
      ScrambleGameModeDataEvent.NativeFieldInfoPtr_MAX_DATA_LENGTH_BYTES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeDataEvent>.NativeClassPtr, nameof (MAX_DATA_LENGTH_BYTES));
      ScrambleGameModeDataEvent.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeDataEvent>.NativeClassPtr, nameof (Data));
      ScrambleGameModeDataEvent.NativeMethodInfoPtr_CreateEvent_Public_Static_ScrambleGameModeDataEvent_ScrambleGameModeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeDataEvent>.NativeClassPtr, 100683427);
      ScrambleGameModeDataEvent.NativeMethodInfoPtr_ReadEvent_Public_Static_ScrambleGameModeSettings_byref_ScrambleGameModeDataEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeDataEvent>.NativeClassPtr, 100683428);
      ScrambleGameModeDataEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeDataEvent>.NativeClassPtr, 100683429);
      ScrambleGameModeDataEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeDataEvent>.NativeClassPtr, 100683430);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScrambleGameModeDataEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int MAX_VBLOOD_UNITS
    {
      get
      {
        int maxVbloodUnits;
        IL2CPP.il2cpp_field_static_get_value(ScrambleGameModeDataEvent.NativeFieldInfoPtr_MAX_VBLOOD_UNITS, (void*) &maxVbloodUnits);
        return maxVbloodUnits;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ScrambleGameModeDataEvent.NativeFieldInfoPtr_MAX_VBLOOD_UNITS, (void*) &value);
      }
    }

    public static unsafe int MAX_VBLOOD_ABILITIES
    {
      get
      {
        int maxVbloodAbilities;
        IL2CPP.il2cpp_field_static_get_value(ScrambleGameModeDataEvent.NativeFieldInfoPtr_MAX_VBLOOD_ABILITIES, (void*) &maxVbloodAbilities);
        return maxVbloodAbilities;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ScrambleGameModeDataEvent.NativeFieldInfoPtr_MAX_VBLOOD_ABILITIES, (void*) &value);
      }
    }

    public static unsafe int MAX_DATA_LENGTH_BYTES
    {
      get
      {
        int maxDataLengthBytes;
        IL2CPP.il2cpp_field_static_get_value(ScrambleGameModeDataEvent.NativeFieldInfoPtr_MAX_DATA_LENGTH_BYTES, (void*) &maxDataLengthBytes);
        return maxDataLengthBytes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ScrambleGameModeDataEvent.NativeFieldInfoPtr_MAX_DATA_LENGTH_BYTES, (void*) &value);
      }
    }

    [ObfuscatedName("ProjectM.ScrambleGameModeDataEvent/<Data>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _Data_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public byte FixedElementField;

      static _Data_e__FixedBuffer()
      {
        Il2CppClassPointerStore<ScrambleGameModeDataEvent._Data_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrambleGameModeDataEvent>.NativeClassPtr, "<Data>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrambleGameModeDataEvent._Data_e__FixedBuffer>.NativeClassPtr);
        ScrambleGameModeDataEvent._Data_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeDataEvent._Data_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScrambleGameModeDataEvent._Data_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
