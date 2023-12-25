// Decompiled with JetBrains decompiler
// Type: ScrambleGameModeSettings
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM;
using Stunlock.Network;
using System.Runtime.InteropServices;

#nullable disable
public sealed class ScrambleGameModeSettings : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Remappings;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_NetBufferOut_ScrambleGameModeSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_ScrambleGameModeSettings_byref_NetBufferIn_0;

  public unsafe bool Initialized
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 322178, RefRangeEnd = 322183, XrefRangeStart = 322178, XrefRangeEnd = 322183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSettings.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 914110, RefRangeEnd = 914112, XrefRangeStart = 914076, XrefRangeEnd = 914110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Serialize(ref NetBufferOut netBuffer, ScrambleGameModeSettings settings)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref netBuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) settings));
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSettings.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_NetBufferOut_ScrambleGameModeSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 914147, RefRangeEnd = 914149, XrefRangeStart = 914112, XrefRangeEnd = 914147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ScrambleGameModeSettings Deserialize(ref NetBufferIn netBuffer)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) ref netBuffer;
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSettings.NativeMethodInfoPtr_Deserialize_Public_Static_ScrambleGameModeSettings_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return new ScrambleGameModeSettings(pointer);
  }

  static ScrambleGameModeSettings()
  {
    Il2CppClassPointerStore<ScrambleGameModeSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (ScrambleGameModeSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrambleGameModeSettings>.NativeClassPtr);
    ScrambleGameModeSettings.NativeFieldInfoPtr_Remappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeSettings>.NativeClassPtr, nameof (Remappings));
    ScrambleGameModeSettings.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSettings>.NativeClassPtr, 100663513);
    ScrambleGameModeSettings.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_NetBufferOut_ScrambleGameModeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSettings>.NativeClassPtr, 100663514);
    ScrambleGameModeSettings.NativeMethodInfoPtr_Deserialize_Public_Static_ScrambleGameModeSettings_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSettings>.NativeClassPtr, 100663515);
  }

  public ScrambleGameModeSettings(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public ScrambleGameModeSettings()
  {
    // ISSUE: cast to a reference type
    // ISSUE: untyped stack allocation
    System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ScrambleGameModeSettings>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    // ISSUE: explicit constructor call
    base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScrambleGameModeSettings>.NativeClassPtr, data));
  }

  public unsafe Dictionary<PrefabGUID, ScrambleGameModeSettings.RemappingData> Remappings
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSettings.NativeFieldInfoPtr_Remappings));
      return pointer == System.IntPtr.Zero ? (Dictionary<PrefabGUID, ScrambleGameModeSettings.RemappingData>) null : new Dictionary<PrefabGUID, ScrambleGameModeSettings.RemappingData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSettings.NativeFieldInfoPtr_Remappings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class RemappingData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NewVBloodUnitGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewTechTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_Abilities;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShapeShifts;

    static RemappingData()
    {
      Il2CppClassPointerStore<ScrambleGameModeSettings.RemappingData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrambleGameModeSettings>.NativeClassPtr, nameof (RemappingData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrambleGameModeSettings.RemappingData>.NativeClassPtr);
      ScrambleGameModeSettings.RemappingData.NativeFieldInfoPtr_NewVBloodUnitGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeSettings.RemappingData>.NativeClassPtr, nameof (NewVBloodUnitGUID));
      ScrambleGameModeSettings.RemappingData.NativeFieldInfoPtr_NewTechTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeSettings.RemappingData>.NativeClassPtr, nameof (NewTechTarget));
      ScrambleGameModeSettings.RemappingData.NativeFieldInfoPtr_Abilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeSettings.RemappingData>.NativeClassPtr, nameof (Abilities));
      ScrambleGameModeSettings.RemappingData.NativeFieldInfoPtr_ShapeShifts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeSettings.RemappingData>.NativeClassPtr, nameof (ShapeShifts));
    }

    public RemappingData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public RemappingData()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ScrambleGameModeSettings.RemappingData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScrambleGameModeSettings.RemappingData>.NativeClassPtr, data));
    }

    public unsafe PrefabGUID NewVBloodUnitGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSettings.RemappingData.NativeFieldInfoPtr_NewVBloodUnitGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSettings.RemappingData.NativeFieldInfoPtr_NewVBloodUnitGUID)) = value;
      }
    }

    public unsafe PrefabGUID NewTechTarget
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSettings.RemappingData.NativeFieldInfoPtr_NewTechTarget));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSettings.RemappingData.NativeFieldInfoPtr_NewTechTarget)) = value;
      }
    }

    public unsafe List<PrefabGUID> Abilities
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSettings.RemappingData.NativeFieldInfoPtr_Abilities));
        return pointer == System.IntPtr.Zero ? (List<PrefabGUID>) null : new List<PrefabGUID>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSettings.RemappingData.NativeFieldInfoPtr_Abilities), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<PrefabGUID> ShapeShifts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSettings.RemappingData.NativeFieldInfoPtr_ShapeShifts));
        return pointer == System.IntPtr.Zero ? (List<PrefabGUID>) null : new List<PrefabGUID>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSettings.RemappingData.NativeFieldInfoPtr_ShapeShifts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
