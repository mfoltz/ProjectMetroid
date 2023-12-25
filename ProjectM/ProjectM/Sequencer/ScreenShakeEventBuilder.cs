// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.ScreenShakeEventBuilder
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Sequencer
{
  public class ScreenShakeEventBuilder : SequencerEventBuilder
  {
    private static readonly IntPtr NativeFieldInfoPtr_ScreenShakeSettings;
    private static readonly IntPtr NativeFieldInfoPtr_ForceParameter;
    private static readonly IntPtr NativeFieldInfoPtr_SideForceParameter;
    private static readonly IntPtr NativeFieldInfoPtr_DirectionParameter;
    private static readonly IntPtr NativeFieldInfoPtr_TargetParameter;
    private static readonly IntPtr NativeFieldInfoPtr_PositionParameter;
    private static readonly IntPtr NativeFieldInfoPtr_MinRangeParameter;
    private static readonly IntPtr NativeFieldInfoPtr_MaxRangeParameter;
    private static readonly IntPtr NativeFieldInfoPtr_ScreenShakeSpace;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090013, XrefRangeEnd = 1090021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScreenShakeEventBuilder.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 56402, RefRangeEnd = 56403, XrefRangeStart = 56402, XrefRangeEnd = 56403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe NodeTypeEnum GetNodeType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScreenShakeEventBuilder.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NodeTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090021, XrefRangeEnd = 1090023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string GetDebugName()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScreenShakeEventBuilder.NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ScreenShakeEventBuilder()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenShakeEventBuilder>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScreenShakeEventBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ScreenShakeEventBuilder()
    {
      Il2CppClassPointerStore<ScreenShakeEventBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (ScreenShakeEventBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenShakeEventBuilder>.NativeClassPtr);
      ScreenShakeEventBuilder.NativeFieldInfoPtr_ScreenShakeSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeEventBuilder>.NativeClassPtr, nameof (ScreenShakeSettings));
      ScreenShakeEventBuilder.NativeFieldInfoPtr_ForceParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeEventBuilder>.NativeClassPtr, nameof (ForceParameter));
      ScreenShakeEventBuilder.NativeFieldInfoPtr_SideForceParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeEventBuilder>.NativeClassPtr, nameof (SideForceParameter));
      ScreenShakeEventBuilder.NativeFieldInfoPtr_DirectionParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeEventBuilder>.NativeClassPtr, nameof (DirectionParameter));
      ScreenShakeEventBuilder.NativeFieldInfoPtr_TargetParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeEventBuilder>.NativeClassPtr, nameof (TargetParameter));
      ScreenShakeEventBuilder.NativeFieldInfoPtr_PositionParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeEventBuilder>.NativeClassPtr, nameof (PositionParameter));
      ScreenShakeEventBuilder.NativeFieldInfoPtr_MinRangeParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeEventBuilder>.NativeClassPtr, nameof (MinRangeParameter));
      ScreenShakeEventBuilder.NativeFieldInfoPtr_MaxRangeParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeEventBuilder>.NativeClassPtr, nameof (MaxRangeParameter));
      ScreenShakeEventBuilder.NativeFieldInfoPtr_ScreenShakeSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeEventBuilder>.NativeClassPtr, nameof (ScreenShakeSpace));
      ScreenShakeEventBuilder.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenShakeEventBuilder>.NativeClassPtr, 100685874);
      ScreenShakeEventBuilder.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenShakeEventBuilder>.NativeClassPtr, 100685875);
      ScreenShakeEventBuilder.NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenShakeEventBuilder>.NativeClassPtr, 100685876);
      ScreenShakeEventBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenShakeEventBuilder>.NativeClassPtr, 100685877);
    }

    public ScreenShakeEventBuilder(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ScreenShakeSettings ScreenShakeSettings
    {
      get
      {
        return *(ScreenShakeSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeEventBuilder.NativeFieldInfoPtr_ScreenShakeSettings));
      }
      [param: In] set
      {
        *(ScreenShakeSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeEventBuilder.NativeFieldInfoPtr_ScreenShakeSettings)) = value;
      }
    }

    public BlackboardParameterBuilder ForceParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeEventBuilder.NativeFieldInfoPtr_ForceParameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeEventBuilder.NativeFieldInfoPtr_ForceParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterBuilder SideForceParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeEventBuilder.NativeFieldInfoPtr_SideForceParameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeEventBuilder.NativeFieldInfoPtr_SideForceParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterBuilder DirectionParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeEventBuilder.NativeFieldInfoPtr_DirectionParameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeEventBuilder.NativeFieldInfoPtr_DirectionParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterBuilder TargetParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeEventBuilder.NativeFieldInfoPtr_TargetParameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeEventBuilder.NativeFieldInfoPtr_TargetParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterBuilder PositionParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeEventBuilder.NativeFieldInfoPtr_PositionParameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeEventBuilder.NativeFieldInfoPtr_PositionParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterBuilder MinRangeParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeEventBuilder.NativeFieldInfoPtr_MinRangeParameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeEventBuilder.NativeFieldInfoPtr_MinRangeParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterBuilder MaxRangeParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeEventBuilder.NativeFieldInfoPtr_MaxRangeParameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeEventBuilder.NativeFieldInfoPtr_MaxRangeParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe ScreenShakeSpaceEnum ScreenShakeSpace
    {
      get
      {
        return *(ScreenShakeSpaceEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeEventBuilder.NativeFieldInfoPtr_ScreenShakeSpace));
      }
      [param: In] set
      {
        *(ScreenShakeSpaceEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenShakeEventBuilder.NativeFieldInfoPtr_ScreenShakeSpace)) = value;
      }
    }
  }
}
