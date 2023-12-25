// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.WindMotorEventBuilder
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Wind;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Sequencer
{
  public class WindMotorEventBuilder : SequencerEventBuilder
  {
    private static readonly IntPtr NativeFieldInfoPtr_MotorTypeParameter;
    private static readonly IntPtr NativeFieldInfoPtr_PositionParameter;
    private static readonly IntPtr NativeFieldInfoPtr_ForceParameter;
    private static readonly IntPtr NativeFieldInfoPtr_RangeParameter;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090005, XrefRangeEnd = 1090009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
      Entity entity,
      EntityManager entityManager,
      BlackboardBuilder blackboardBuilder,
      SequenceEditorObject sequenceEditorObject)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sequenceEditorObject);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WindMotorEventBuilder.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090009, XrefRangeEnd = 1090011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string GetDebugName()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WindMotorEventBuilder.NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 75050, RefRangeEnd = 75060, XrefRangeStart = 75050, XrefRangeEnd = 75060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe NodeTypeEnum GetNodeType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WindMotorEventBuilder.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NodeTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WindMotorEventBuilder()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindMotorEventBuilder>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WindMotorEventBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WindMotorEventBuilder()
    {
      Il2CppClassPointerStore<WindMotorEventBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (WindMotorEventBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindMotorEventBuilder>.NativeClassPtr);
      WindMotorEventBuilder.NativeFieldInfoPtr_MotorTypeParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorEventBuilder>.NativeClassPtr, nameof (MotorTypeParameter));
      WindMotorEventBuilder.NativeFieldInfoPtr_PositionParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorEventBuilder>.NativeClassPtr, nameof (PositionParameter));
      WindMotorEventBuilder.NativeFieldInfoPtr_ForceParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorEventBuilder>.NativeClassPtr, nameof (ForceParameter));
      WindMotorEventBuilder.NativeFieldInfoPtr_RangeParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorEventBuilder>.NativeClassPtr, nameof (RangeParameter));
      WindMotorEventBuilder.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindMotorEventBuilder>.NativeClassPtr, 100685866);
      WindMotorEventBuilder.NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindMotorEventBuilder>.NativeClassPtr, 100685867);
      WindMotorEventBuilder.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindMotorEventBuilder>.NativeClassPtr, 100685868);
      WindMotorEventBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindMotorEventBuilder>.NativeClassPtr, 100685869);
    }

    public WindMotorEventBuilder(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WindMotorTypes MotorTypeParameter
    {
      get
      {
        return *(WindMotorTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindMotorEventBuilder.NativeFieldInfoPtr_MotorTypeParameter));
      }
      [param: In] set
      {
        *(WindMotorTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindMotorEventBuilder.NativeFieldInfoPtr_MotorTypeParameter)) = value;
      }
    }

    public BlackboardParameterBuilder PositionParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindMotorEventBuilder.NativeFieldInfoPtr_PositionParameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindMotorEventBuilder.NativeFieldInfoPtr_PositionParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterBuilder ForceParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindMotorEventBuilder.NativeFieldInfoPtr_ForceParameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindMotorEventBuilder.NativeFieldInfoPtr_ForceParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterBuilder RangeParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindMotorEventBuilder.NativeFieldInfoPtr_RangeParameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindMotorEventBuilder.NativeFieldInfoPtr_RangeParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }
  }
}
