// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.AdditionalMaterialEventBuilder
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
  public class AdditionalMaterialEventBuilder : SequencerEventBuilder
  {
    private static readonly IntPtr NativeFieldInfoPtr_TargetParameter;
    private static readonly IntPtr NativeFieldInfoPtr_OutputEntityParameter;
    private static readonly IntPtr NativeFieldInfoPtr_Material;
    private static readonly IntPtr NativeFieldInfoPtr_RendererMask;
    private static readonly IntPtr NativeFieldInfoPtr_Importance;
    private static readonly IntPtr NativeFieldInfoPtr_CopyNormalMap;
    private static readonly IntPtr NativeFieldInfoPtr_CopyBaseMap;
    private static readonly IntPtr NativeFieldInfoPtr_ShadowCastingMode;
    private static readonly IntPtr NativeFieldInfoPtr__AdditionalFakeEntity;
    private static readonly IntPtr NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(21)]
    [CachedScanResults(RefRangeStart = 31081, RefRangeEnd = 31102, XrefRangeStart = 31081, XrefRangeEnd = 31102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe NodeTypeEnum GetNodeType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AdditionalMaterialEventBuilder.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NodeTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089870, XrefRangeEnd = 1089873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AdditionalMaterialEventBuilder.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089873, XrefRangeEnd = 1089876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string GetDebugName()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AdditionalMaterialEventBuilder.NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AdditionalMaterialEventBuilder()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdditionalMaterialEventBuilder>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialEventBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AdditionalMaterialEventBuilder()
    {
      Il2CppClassPointerStore<AdditionalMaterialEventBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (AdditionalMaterialEventBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalMaterialEventBuilder>.NativeClassPtr);
      AdditionalMaterialEventBuilder.NativeFieldInfoPtr_TargetParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialEventBuilder>.NativeClassPtr, nameof (TargetParameter));
      AdditionalMaterialEventBuilder.NativeFieldInfoPtr_OutputEntityParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialEventBuilder>.NativeClassPtr, nameof (OutputEntityParameter));
      AdditionalMaterialEventBuilder.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialEventBuilder>.NativeClassPtr, nameof (Material));
      AdditionalMaterialEventBuilder.NativeFieldInfoPtr_RendererMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialEventBuilder>.NativeClassPtr, nameof (RendererMask));
      AdditionalMaterialEventBuilder.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialEventBuilder>.NativeClassPtr, nameof (Importance));
      AdditionalMaterialEventBuilder.NativeFieldInfoPtr_CopyNormalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialEventBuilder>.NativeClassPtr, nameof (CopyNormalMap));
      AdditionalMaterialEventBuilder.NativeFieldInfoPtr_CopyBaseMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialEventBuilder>.NativeClassPtr, nameof (CopyBaseMap));
      AdditionalMaterialEventBuilder.NativeFieldInfoPtr_ShadowCastingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialEventBuilder>.NativeClassPtr, nameof (ShadowCastingMode));
      AdditionalMaterialEventBuilder.NativeFieldInfoPtr__AdditionalFakeEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialEventBuilder>.NativeClassPtr, nameof (_AdditionalFakeEntity));
      AdditionalMaterialEventBuilder.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialEventBuilder>.NativeClassPtr, 100685830);
      AdditionalMaterialEventBuilder.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialEventBuilder>.NativeClassPtr, 100685831);
      AdditionalMaterialEventBuilder.NativeMethodInfoPtr_GetDebugName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialEventBuilder>.NativeClassPtr, 100685832);
      AdditionalMaterialEventBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialEventBuilder>.NativeClassPtr, 100685833);
    }

    public AdditionalMaterialEventBuilder(IntPtr pointer)
      : base(pointer)
    {
    }

    public BlackboardParameterBuilder TargetParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialEventBuilder.NativeFieldInfoPtr_TargetParameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialEventBuilder.NativeFieldInfoPtr_TargetParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public BlackboardParameterBuilder OutputEntityParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialEventBuilder.NativeFieldInfoPtr_OutputEntityParameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialEventBuilder.NativeFieldInfoPtr_OutputEntityParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe Material Material
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialEventBuilder.NativeFieldInfoPtr_Material));
        return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialEventBuilder.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int RendererMask
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialEventBuilder.NativeFieldInfoPtr_RendererMask));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialEventBuilder.NativeFieldInfoPtr_RendererMask)) = value;
      }
    }

    public unsafe int Importance
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialEventBuilder.NativeFieldInfoPtr_Importance));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialEventBuilder.NativeFieldInfoPtr_Importance)) = value;
      }
    }

    public unsafe bool CopyNormalMap
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialEventBuilder.NativeFieldInfoPtr_CopyNormalMap));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialEventBuilder.NativeFieldInfoPtr_CopyNormalMap)) = value;
      }
    }

    public unsafe bool CopyBaseMap
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialEventBuilder.NativeFieldInfoPtr_CopyBaseMap));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialEventBuilder.NativeFieldInfoPtr_CopyBaseMap)) = value;
      }
    }

    public unsafe ShadowCastingMode ShadowCastingMode
    {
      get
      {
        return *(ShadowCastingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialEventBuilder.NativeFieldInfoPtr_ShadowCastingMode));
      }
      [param: In] set
      {
        *(ShadowCastingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialEventBuilder.NativeFieldInfoPtr_ShadowCastingMode)) = value;
      }
    }

    public unsafe Entity _AdditionalFakeEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialEventBuilder.NativeFieldInfoPtr__AdditionalFakeEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialEventBuilder.NativeFieldInfoPtr__AdditionalFakeEntity)) = value;
      }
    }
  }
}
