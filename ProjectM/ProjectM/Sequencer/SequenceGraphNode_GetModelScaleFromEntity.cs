// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceGraphNode_GetModelScaleFromEntity
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class SequenceGraphNode_GetModelScaleFromEntity : SequenceGraphNode
  {
    private static readonly IntPtr NativeFieldInfoPtr__Bone;
    private static readonly IntPtr NativeMethodInfoPtr_get_Bone_Public_get_HybridBoneEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Bone_Public_set_Void_HybridBoneEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_GraphFunction_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_0;
    private static readonly IntPtr NativeMethodInfoPtr_ValidSocketInTypes_Public_Virtual_Il2CppStructArray_1_BlackboardRegisterType_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_CalculateOutSocketTypes_Protected_Virtual_Boolean_Il2CppStructArray_1_BlackboardRegisterType_byref_List_1_String_0;

    public unsafe HybridBoneEnum Bone
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode_GetModelScaleFromEntity.NativeMethodInfoPtr_get_Bone_Public_get_HybridBoneEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(HybridBoneEnum*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode_GetModelScaleFromEntity.NativeMethodInfoPtr_set_Bone_Public_set_Void_HybridBoneEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public override unsafe GraphFunction NodeType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode_GetModelScaleFromEntity.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_GraphFunction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(GraphFunction*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096821, XrefRangeEnd = 1096830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceGraphNode_GetModelScaleFromEntity()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceGraphNode_GetModelScaleFromEntity>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode_GetModelScaleFromEntity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096830, XrefRangeEnd = 1096838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceGraphNode_GetModelScaleFromEntity(Vector2 position)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceGraphNode_GetModelScaleFromEntity>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &position;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGraphNode_GetModelScaleFromEntity.NativeMethodInfoPtr__ctor_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096838, XrefRangeEnd = 1096841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<BlackboardRegisterType> ValidSocketInTypes(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &index;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode_GetModelScaleFromEntity.NativeMethodInfoPtr_ValidSocketInTypes_Public_Virtual_Il2CppStructArray_1_BlackboardRegisterType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr nativeObject = num;
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<BlackboardRegisterType>) null : new Il2CppStructArray<BlackboardRegisterType>(nativeObject);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096841, XrefRangeEnd = 1096856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool CalculateOutSocketTypes(
      Il2CppStructArray<BlackboardRegisterType> socketTypes,
      out List<string> changedSockets)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr1 = stackalloc IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) socketTypes);
      IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
      IntPtr zero = IntPtr.Zero;
      IntPtr* numPtr2 = &zero;
      *(IntPtr*) num1 = (IntPtr) numPtr2;
      IntPtr exc;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceGraphNode_GetModelScaleFromEntity.NativeMethodInfoPtr_CalculateOutSocketTypes_Protected_Virtual_Boolean_Il2CppStructArray_1_BlackboardRegisterType_byref_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<string> local = ref changedSockets;
      IntPtr pointer = zero;
      List<> list = pointer == IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<string>) list;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    static SequenceGraphNode_GetModelScaleFromEntity()
    {
      Il2CppClassPointerStore<SequenceGraphNode_GetModelScaleFromEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceGraphNode_GetModelScaleFromEntity));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceGraphNode_GetModelScaleFromEntity>.NativeClassPtr);
      SequenceGraphNode_GetModelScaleFromEntity.NativeFieldInfoPtr__Bone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceGraphNode_GetModelScaleFromEntity>.NativeClassPtr, nameof (_Bone));
      SequenceGraphNode_GetModelScaleFromEntity.NativeMethodInfoPtr_get_Bone_Public_get_HybridBoneEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_GetModelScaleFromEntity>.NativeClassPtr, 100686988);
      SequenceGraphNode_GetModelScaleFromEntity.NativeMethodInfoPtr_set_Bone_Public_set_Void_HybridBoneEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_GetModelScaleFromEntity>.NativeClassPtr, 100686989);
      SequenceGraphNode_GetModelScaleFromEntity.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_GraphFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_GetModelScaleFromEntity>.NativeClassPtr, 100686990);
      SequenceGraphNode_GetModelScaleFromEntity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_GetModelScaleFromEntity>.NativeClassPtr, 100686991);
      SequenceGraphNode_GetModelScaleFromEntity.NativeMethodInfoPtr__ctor_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_GetModelScaleFromEntity>.NativeClassPtr, 100686992);
      SequenceGraphNode_GetModelScaleFromEntity.NativeMethodInfoPtr_ValidSocketInTypes_Public_Virtual_Il2CppStructArray_1_BlackboardRegisterType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_GetModelScaleFromEntity>.NativeClassPtr, 100686993);
      SequenceGraphNode_GetModelScaleFromEntity.NativeMethodInfoPtr_CalculateOutSocketTypes_Protected_Virtual_Boolean_Il2CppStructArray_1_BlackboardRegisterType_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphNode_GetModelScaleFromEntity>.NativeClassPtr, 100686994);
    }

    public SequenceGraphNode_GetModelScaleFromEntity(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HybridBoneEnum _Bone
    {
      get
      {
        return *(HybridBoneEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphNode_GetModelScaleFromEntity.NativeFieldInfoPtr__Bone));
      }
      [param: In] set
      {
        *(HybridBoneEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphNode_GetModelScaleFromEntity.NativeFieldInfoPtr__Bone)) = value;
      }
    }
  }
}
