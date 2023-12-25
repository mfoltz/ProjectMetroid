// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.MaterialChangeEventBuilder
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
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM.Sequencer
{
  public class MaterialChangeEventBuilder : SequencerEventBuilder
  {
    private static readonly IntPtr NativeFieldInfoPtr_TargetParameter;
    private static readonly IntPtr NativeFieldInfoPtr_Material;
    private static readonly IntPtr NativeFieldInfoPtr_RendererMask;
    private static readonly IntPtr NativeFieldInfoPtr_Importance;
    private static readonly IntPtr NativeFieldInfoPtr_CopyNormalMap;
    private static readonly IntPtr NativeFieldInfoPtr_CopyBaseMap;
    private static readonly IntPtr NativeFieldInfoPtr_ShadowCastingMode;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialChangeEventBuilder.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(26)]
    [CachedScanResults(RefRangeStart = 35341, RefRangeEnd = 35367, XrefRangeStart = 35341, XrefRangeEnd = 35367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe NodeTypeEnum GetNodeType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialChangeEventBuilder.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NodeTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089917, XrefRangeEnd = 1089920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string GetDebugName()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialChangeEventBuilder.NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MaterialChangeEventBuilder()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialChangeEventBuilder>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialChangeEventBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MaterialChangeEventBuilder()
    {
      Il2CppClassPointerStore<MaterialChangeEventBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (MaterialChangeEventBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialChangeEventBuilder>.NativeClassPtr);
      MaterialChangeEventBuilder.NativeFieldInfoPtr_TargetParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeEventBuilder>.NativeClassPtr, nameof (TargetParameter));
      MaterialChangeEventBuilder.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeEventBuilder>.NativeClassPtr, nameof (Material));
      MaterialChangeEventBuilder.NativeFieldInfoPtr_RendererMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeEventBuilder>.NativeClassPtr, nameof (RendererMask));
      MaterialChangeEventBuilder.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeEventBuilder>.NativeClassPtr, nameof (Importance));
      MaterialChangeEventBuilder.NativeFieldInfoPtr_CopyNormalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeEventBuilder>.NativeClassPtr, nameof (CopyNormalMap));
      MaterialChangeEventBuilder.NativeFieldInfoPtr_CopyBaseMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeEventBuilder>.NativeClassPtr, nameof (CopyBaseMap));
      MaterialChangeEventBuilder.NativeFieldInfoPtr_ShadowCastingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeEventBuilder>.NativeClassPtr, nameof (ShadowCastingMode));
      MaterialChangeEventBuilder.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeEventBuilder>.NativeClassPtr, 100685845);
      MaterialChangeEventBuilder.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeEventBuilder>.NativeClassPtr, 100685846);
      MaterialChangeEventBuilder.NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeEventBuilder>.NativeClassPtr, 100685847);
      MaterialChangeEventBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeEventBuilder>.NativeClassPtr, 100685848);
    }

    public MaterialChangeEventBuilder(IntPtr pointer)
      : base(pointer)
    {
    }

    public BlackboardParameterBuilder TargetParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeEventBuilder.NativeFieldInfoPtr_TargetParameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeEventBuilder.NativeFieldInfoPtr_TargetParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe Material Material
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeEventBuilder.NativeFieldInfoPtr_Material));
        return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeEventBuilder.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int RendererMask
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeEventBuilder.NativeFieldInfoPtr_RendererMask));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeEventBuilder.NativeFieldInfoPtr_RendererMask)) = value;
      }
    }

    public unsafe int Importance
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeEventBuilder.NativeFieldInfoPtr_Importance));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeEventBuilder.NativeFieldInfoPtr_Importance)) = value;
      }
    }

    public unsafe bool CopyNormalMap
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeEventBuilder.NativeFieldInfoPtr_CopyNormalMap));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeEventBuilder.NativeFieldInfoPtr_CopyNormalMap)) = value;
      }
    }

    public unsafe bool CopyBaseMap
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeEventBuilder.NativeFieldInfoPtr_CopyBaseMap));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeEventBuilder.NativeFieldInfoPtr_CopyBaseMap)) = value;
      }
    }

    public unsafe ShadowCastingMode ShadowCastingMode
    {
      get
      {
        return *(ShadowCastingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeEventBuilder.NativeFieldInfoPtr_ShadowCastingMode));
      }
      [param: In] set
      {
        *(ShadowCastingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeEventBuilder.NativeFieldInfoPtr_ShadowCastingMode)) = value;
      }
    }
  }
}
