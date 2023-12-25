// Decompiled with JetBrains decompiler
// Type: ProjectM.DayNightCycleComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Sequencer;
using Stunlock.Fmod;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine.Rendering.HighDefinition;

#nullable disable
namespace ProjectM
{
  public class DayNightCycleComponent : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DuskSequenceField;
    private static readonly System.IntPtr NativeFieldInfoPtr_DawnSequenceField;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameStartHour;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameStartMinute;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayNightCycleAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr_DurationBeforeSunDamageAfterSunrise;
    private static readonly System.IntPtr NativeFieldInfoPtr_AmbientEvent;
    private static readonly System.IntPtr NativeFieldInfoPtr_AmbientBiome;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cloudiness;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayTimeSpan;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024012, XrefRangeEnd = 1024029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DayNightCycleComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024029, XrefRangeEnd = 1024033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DayNightCycleComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024033, XrefRangeEnd = 1024034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DayNightCycleComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DayNightCycleComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DayNightCycleComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DayNightCycleComponent()
    {
      Il2CppClassPointerStore<DayNightCycleComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DayNightCycleComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DayNightCycleComponent>.NativeClassPtr);
      DayNightCycleComponent.NativeFieldInfoPtr_DuskSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleComponent>.NativeClassPtr, nameof (DuskSequenceField));
      DayNightCycleComponent.NativeFieldInfoPtr_DawnSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleComponent>.NativeClassPtr, nameof (DawnSequenceField));
      DayNightCycleComponent.NativeFieldInfoPtr_GameStartHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleComponent>.NativeClassPtr, nameof (GameStartHour));
      DayNightCycleComponent.NativeFieldInfoPtr_GameStartMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleComponent>.NativeClassPtr, nameof (GameStartMinute));
      DayNightCycleComponent.NativeFieldInfoPtr_DayNightCycleAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleComponent>.NativeClassPtr, nameof (DayNightCycleAsset));
      DayNightCycleComponent.NativeFieldInfoPtr_DurationBeforeSunDamageAfterSunrise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleComponent>.NativeClassPtr, nameof (DurationBeforeSunDamageAfterSunrise));
      DayNightCycleComponent.NativeFieldInfoPtr_AmbientEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleComponent>.NativeClassPtr, nameof (AmbientEvent));
      DayNightCycleComponent.NativeFieldInfoPtr_AmbientBiome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleComponent>.NativeClassPtr, nameof (AmbientBiome));
      DayNightCycleComponent.NativeFieldInfoPtr_Cloudiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleComponent>.NativeClassPtr, nameof (Cloudiness));
      DayNightCycleComponent.NativeFieldInfoPtr_DayTimeSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleComponent>.NativeClassPtr, nameof (DayTimeSpan));
      DayNightCycleComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleComponent>.NativeClassPtr, 100679971);
      DayNightCycleComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleComponent>.NativeClassPtr, 100679972);
      DayNightCycleComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleComponent>.NativeClassPtr, 100679973);
    }

    public DayNightCycleComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SequenceField DuskSequenceField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_DuskSequenceField));
        return pointer == System.IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_DuskSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField DawnSequenceField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_DawnSequenceField));
        return pointer == System.IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_DawnSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int GameStartHour
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_GameStartHour));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_GameStartHour)) = value;
      }
    }

    public unsafe int GameStartMinute
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_GameStartMinute));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_GameStartMinute)) = value;
      }
    }

    public unsafe DayNightCycleAsset DayNightCycleAsset
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_DayNightCycleAsset));
        return pointer == System.IntPtr.Zero ? (DayNightCycleAsset) null : new DayNightCycleAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_DayNightCycleAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float DurationBeforeSunDamageAfterSunrise
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_DurationBeforeSunDamageAfterSunrise));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_DurationBeforeSunDamageAfterSunrise)) = value;
      }
    }

    public FmodEvent AmbientEvent
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_AmbientEvent);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_AmbientEvent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int AmbientBiome
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_AmbientBiome));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_AmbientBiome)) = value;
      }
    }

    public unsafe float Cloudiness
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_Cloudiness));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_Cloudiness)) = value;
      }
    }

    public unsafe DayTimeSpanSettings DayTimeSpan
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_DayTimeSpan));
        return pointer == System.IntPtr.Zero ? (DayTimeSpanSettings) null : new DayTimeSpanSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DayNightCycleComponent.NativeFieldInfoPtr_DayTimeSpan), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DataClient
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DuskSequence;
      private static readonly System.IntPtr NativeFieldInfoPtr_DuskSequenceState;
      private static readonly System.IntPtr NativeFieldInfoPtr_DawnSequence;
      private static readonly System.IntPtr NativeFieldInfoPtr_DawnSequenceState;
      private static readonly System.IntPtr NativeFieldInfoPtr_PreviousIsDay;
      [FieldOffset(0)]
      public SequenceGUID DuskSequence;
      [FieldOffset(4)]
      public SequenceState DuskSequenceState;
      [FieldOffset(12)]
      public SequenceGUID DawnSequence;
      [FieldOffset(16)]
      public SequenceState DawnSequenceState;
      [FieldOffset(24)]
      public bool PreviousIsDay;

      static DataClient()
      {
        Il2CppClassPointerStore<DayNightCycleComponent.DataClient>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DayNightCycleComponent>.NativeClassPtr, nameof (DataClient));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DayNightCycleComponent.DataClient>.NativeClassPtr);
        DayNightCycleComponent.DataClient.NativeFieldInfoPtr_DuskSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleComponent.DataClient>.NativeClassPtr, nameof (DuskSequence));
        DayNightCycleComponent.DataClient.NativeFieldInfoPtr_DuskSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleComponent.DataClient>.NativeClassPtr, nameof (DuskSequenceState));
        DayNightCycleComponent.DataClient.NativeFieldInfoPtr_DawnSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleComponent.DataClient>.NativeClassPtr, nameof (DawnSequence));
        DayNightCycleComponent.DataClient.NativeFieldInfoPtr_DawnSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleComponent.DataClient>.NativeClassPtr, nameof (DawnSequenceState));
        DayNightCycleComponent.DataClient.NativeFieldInfoPtr_PreviousIsDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleComponent.DataClient>.NativeClassPtr, nameof (PreviousIsDay));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DayNightCycleComponent.DataClient>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
