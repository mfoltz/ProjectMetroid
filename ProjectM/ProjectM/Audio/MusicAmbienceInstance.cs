// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.MusicAmbienceInstance
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using FMOD.Studio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Audio
{
  public sealed class MusicAmbienceInstance : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__StudioManagerSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr__TrackParameterName;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr__NewData;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentData;
    private static readonly System.IntPtr NativeFieldInfoPtr_Play;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideData;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsAmbience;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_StudioManagerSystem_Guid_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_MusicAmbienceData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNewData_Private_MusicAmbienceData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetParameters_Private_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142180, XrefRangeEnd = 1142182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(
      StudioManagerSystem studioManagerSystem,
      Il2CppSystem.Guid eventGuid,
      string trackParameterName,
      bool isAmbience = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) studioManagerSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &eventGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(trackParameterName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isAmbience;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MusicAmbienceInstance.NativeMethodInfoPtr_Initialize_Public_Void_StudioManagerSystem_Guid_String_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 632378, RefRangeEnd = 632382, XrefRangeStart = 632378, XrefRangeEnd = 632382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(MusicAmbienceData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MusicAmbienceInstance.NativeMethodInfoPtr_SetData_Public_Void_MusicAmbienceData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142182, XrefRangeEnd = 1142185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Stop()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MusicAmbienceInstance.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142185, XrefRangeEnd = 1142187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MusicAmbienceData GetNewData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MusicAmbienceInstance.NativeMethodInfoPtr_GetNewData_Private_MusicAmbienceData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(MusicAmbienceData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1142190, RefRangeEnd = 1142192, XrefRangeStart = 1142187, XrefRangeEnd = 1142190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MusicAmbienceInstance.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142192, XrefRangeEnd = 1142210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetParameters()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MusicAmbienceInstance.NativeMethodInfoPtr_SetParameters_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MusicAmbienceInstance()
    {
      Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (MusicAmbienceInstance));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr);
      MusicAmbienceInstance.NativeFieldInfoPtr__StudioManagerSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, nameof (_StudioManagerSystem));
      MusicAmbienceInstance.NativeFieldInfoPtr__EventGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, nameof (_EventGuid));
      MusicAmbienceInstance.NativeFieldInfoPtr__TrackParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, nameof (_TrackParameterName));
      MusicAmbienceInstance.NativeFieldInfoPtr__EventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, nameof (_EventInstance));
      MusicAmbienceInstance.NativeFieldInfoPtr__NewData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, nameof (_NewData));
      MusicAmbienceInstance.NativeFieldInfoPtr__CurrentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, nameof (_CurrentData));
      MusicAmbienceInstance.NativeFieldInfoPtr_Play = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, nameof (Play));
      MusicAmbienceInstance.NativeFieldInfoPtr_OverrideData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, nameof (OverrideData));
      MusicAmbienceInstance.NativeFieldInfoPtr__IsAmbience = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, nameof (_IsAmbience));
      MusicAmbienceInstance.NativeMethodInfoPtr_Initialize_Public_Void_StudioManagerSystem_Guid_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, 100690389);
      MusicAmbienceInstance.NativeMethodInfoPtr_SetData_Public_Void_MusicAmbienceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, 100690390);
      MusicAmbienceInstance.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, 100690391);
      MusicAmbienceInstance.NativeMethodInfoPtr_GetNewData_Private_MusicAmbienceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, 100690392);
      MusicAmbienceInstance.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, 100690393);
      MusicAmbienceInstance.NativeMethodInfoPtr_SetParameters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, 100690394);
    }

    public MusicAmbienceInstance(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public MusicAmbienceInstance()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, data));
    }

    public unsafe StudioManagerSystem _StudioManagerSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceInstance.NativeFieldInfoPtr__StudioManagerSystem));
        return pointer == System.IntPtr.Zero ? (StudioManagerSystem) null : new StudioManagerSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceInstance.NativeFieldInfoPtr__StudioManagerSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Guid _EventGuid
    {
      get
      {
        return *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceInstance.NativeFieldInfoPtr__EventGuid));
      }
      [param: In] set
      {
        *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceInstance.NativeFieldInfoPtr__EventGuid)) = value;
      }
    }

    public unsafe string _TrackParameterName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceInstance.NativeFieldInfoPtr__TrackParameterName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceInstance.NativeFieldInfoPtr__TrackParameterName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe EventInstance _EventInstance
    {
      get
      {
        return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceInstance.NativeFieldInfoPtr__EventInstance));
      }
      [param: In] set
      {
        *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceInstance.NativeFieldInfoPtr__EventInstance)) = value;
      }
    }

    public unsafe MusicAmbienceData _NewData
    {
      get
      {
        return *(MusicAmbienceData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceInstance.NativeFieldInfoPtr__NewData));
      }
      [param: In] set
      {
        *(MusicAmbienceData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceInstance.NativeFieldInfoPtr__NewData)) = value;
      }
    }

    public unsafe MusicAmbienceData _CurrentData
    {
      get
      {
        return *(MusicAmbienceData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceInstance.NativeFieldInfoPtr__CurrentData));
      }
      [param: In] set
      {
        *(MusicAmbienceData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceInstance.NativeFieldInfoPtr__CurrentData)) = value;
      }
    }

    public unsafe bool Play
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceInstance.NativeFieldInfoPtr_Play));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceInstance.NativeFieldInfoPtr_Play)) = value;
      }
    }

    public unsafe Nullable_Unboxed<MusicAmbienceData> OverrideData
    {
      get
      {
        return *(Nullable_Unboxed<MusicAmbienceData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceInstance.NativeFieldInfoPtr_OverrideData));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceInstance.NativeFieldInfoPtr_OverrideData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<MusicAmbienceData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool _IsAmbience
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceInstance.NativeFieldInfoPtr__IsAmbience));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceInstance.NativeFieldInfoPtr__IsAmbience)) = value;
      }
    }
  }
}
