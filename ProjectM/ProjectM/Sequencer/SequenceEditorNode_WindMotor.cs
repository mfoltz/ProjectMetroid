// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceEditorNode_WindMotor
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Wind;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  public class SequenceEditorNode_WindMotor : SequenceEditorNode_WithDuration
  {
    private static readonly IntPtr NativeFieldInfoPtr__MotorType;
    private static readonly IntPtr NativeFieldInfoPtr__Position;
    private static readonly IntPtr NativeFieldInfoPtr__Force;
    private static readonly IntPtr NativeFieldInfoPtr__Range;
    private static readonly IntPtr NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_MotorType_Public_get_WindMotorTypes_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_MotorType_Public_set_Void_WindMotorTypes_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Force_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Force_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Range_Public_get_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Range_Public_set_Void_BlackboardParameterValue_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetNodeStatus_Public_Virtual_NodeStatus_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Protected_Virtual_Void_Int32_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe int CurrentVersion
    {
      [CallerCount(1474), CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_WindMotor.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe WindMotorTypes MotorType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_WindMotor.NativeMethodInfoPtr_get_MotorType_Public_get_WindMotorTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(WindMotorTypes*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_WindMotor.NativeMethodInfoPtr_set_MotorType_Public_set_Void_WindMotorTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue Position
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_WindMotor.NativeMethodInfoPtr_get_Position_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_WindMotor.NativeMethodInfoPtr_set_Position_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue Force
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_WindMotor.NativeMethodInfoPtr_get_Force_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_WindMotor.NativeMethodInfoPtr_set_Force_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BlackboardParameterValue Range
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_WindMotor.NativeMethodInfoPtr_get_Range_Public_get_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new BlackboardParameterValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_WindMotor.NativeMethodInfoPtr_set_Range_Public_set_Void_BlackboardParameterValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public override unsafe string IconClass
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093836, XrefRangeEnd = 1093838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_WindMotor.NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe float GetDuration()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_WindMotor.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1474)]
    [CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe NodeStatus GetNodeStatus()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_WindMotor.NativeMethodInfoPtr_GetNodeStatus_Public_Virtual_NodeStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NodeStatus*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnVersionChanged(int previousVersion, int newVersion)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &previousVersion;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &newVersion;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorNode_WindMotor.NativeMethodInfoPtr_OnVersionChanged_Protected_Virtual_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceEditorNode_WindMotor()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorNode_WindMotor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequenceEditorNode_WindMotor()
    {
      Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceEditorNode_WindMotor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr);
      SequenceEditorNode_WindMotor.NativeFieldInfoPtr__MotorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr, nameof (_MotorType));
      SequenceEditorNode_WindMotor.NativeFieldInfoPtr__Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr, nameof (_Position));
      SequenceEditorNode_WindMotor.NativeFieldInfoPtr__Force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr, nameof (_Force));
      SequenceEditorNode_WindMotor.NativeFieldInfoPtr__Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr, nameof (_Range));
      SequenceEditorNode_WindMotor.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr, 100686585);
      SequenceEditorNode_WindMotor.NativeMethodInfoPtr_get_MotorType_Public_get_WindMotorTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr, 100686586);
      SequenceEditorNode_WindMotor.NativeMethodInfoPtr_set_MotorType_Public_set_Void_WindMotorTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr, 100686587);
      SequenceEditorNode_WindMotor.NativeMethodInfoPtr_get_Position_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr, 100686588);
      SequenceEditorNode_WindMotor.NativeMethodInfoPtr_set_Position_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr, 100686589);
      SequenceEditorNode_WindMotor.NativeMethodInfoPtr_get_Force_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr, 100686590);
      SequenceEditorNode_WindMotor.NativeMethodInfoPtr_set_Force_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr, 100686591);
      SequenceEditorNode_WindMotor.NativeMethodInfoPtr_get_Range_Public_get_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr, 100686592);
      SequenceEditorNode_WindMotor.NativeMethodInfoPtr_set_Range_Public_set_Void_BlackboardParameterValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr, 100686593);
      SequenceEditorNode_WindMotor.NativeMethodInfoPtr_get_IconClass_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr, 100686594);
      SequenceEditorNode_WindMotor.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr, 100686595);
      SequenceEditorNode_WindMotor.NativeMethodInfoPtr_GetNodeStatus_Public_Virtual_NodeStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr, 100686596);
      SequenceEditorNode_WindMotor.NativeMethodInfoPtr_OnVersionChanged_Protected_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr, 100686597);
      SequenceEditorNode_WindMotor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorNode_WindMotor>.NativeClassPtr, 100686598);
    }

    public SequenceEditorNode_WindMotor(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WindMotorTypes _MotorType
    {
      get
      {
        return *(WindMotorTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_WindMotor.NativeFieldInfoPtr__MotorType));
      }
      [param: In] set
      {
        *(WindMotorTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_WindMotor.NativeFieldInfoPtr__MotorType)) = value;
      }
    }

    public BlackboardParameterValue _Position
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_WindMotor.NativeFieldInfoPtr__Position);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_WindMotor.NativeFieldInfoPtr__Position), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _Force
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_WindMotor.NativeFieldInfoPtr__Force);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_WindMotor.NativeFieldInfoPtr__Force), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterValue _Range
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_WindMotor.NativeFieldInfoPtr__Range);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorNode_WindMotor.NativeFieldInfoPtr__Range), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }
  }
}
