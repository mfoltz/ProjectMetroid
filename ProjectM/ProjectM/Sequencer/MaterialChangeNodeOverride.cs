// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.MaterialChangeNodeOverride
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class MaterialChangeNodeOverride : SequenceNodeOverride
  {
    private static readonly IntPtr NativeFieldInfoPtr_GUID;
    private static readonly IntPtr NativeFieldInfoPtr_Material;
    private static readonly IntPtr NativeFieldInfoPtr_Use_RenderMaskTagOverride;
    private static readonly IntPtr NativeFieldInfoPtr_RenderMaskTagOverride;
    private static readonly IntPtr NativeFieldInfoPtr_Use_ImportanceOverride;
    private static readonly IntPtr NativeFieldInfoPtr_ImportanceOverride;
    private static readonly IntPtr NativeFieldInfoPtr_Use_AdditionalMaterialOverride;
    private static readonly IntPtr NativeFieldInfoPtr_AdditionalMaterialOverride;
    private static readonly IntPtr NativeFieldInfoPtr_MaterialOverrideType;
    private static readonly IntPtr NativeFieldInfoPtr_Use_CopyNormalMapOverride;
    private static readonly IntPtr NativeFieldInfoPtr_CopyNormalMapOverride;
    private static readonly IntPtr NativeFieldInfoPtr_Use_CopyBaseMapOverride;
    private static readonly IntPtr NativeFieldInfoPtr_CopyBaseMapOverride;
    private static readonly IntPtr NativeFieldInfoPtr_Use_ShadowCastingModeOverride;
    private static readonly IntPtr NativeFieldInfoPtr_ShadowCastingModeOverride;
    private static readonly IntPtr NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateNew_Public_Static_MaterialChangeNodeOverride_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateDefault_Public_Static_MaterialChangeNodeOverride_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe int CurrentVersion
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 29193, RefRangeEnd = 29196, XrefRangeStart = 29193, XrefRangeEnd = 29196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialChangeNodeOverride.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void AddGameObjectReferences(List<GameObject> references)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) references);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialChangeNodeOverride.NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093937, XrefRangeEnd = 1093943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe MaterialChangeNodeOverride CreateNew(string nodeGuid)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MaterialChangeNodeOverride.NativeMethodInfoPtr_CreateNew_Public_Static_MaterialChangeNodeOverride_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (MaterialChangeNodeOverride) null : new MaterialChangeNodeOverride(pointer);
    }

    [CallerCount(0)]
    public override unsafe bool HasNodeAnyOverride()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialChangeNodeOverride.NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093943, XrefRangeEnd = 1093951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetDeterministicHash(UnityEngine.Object sourceAsset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceAsset);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialChangeNodeOverride.NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093951, XrefRangeEnd = 1093959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe MaterialChangeNodeOverride CreateDefault()
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MaterialChangeNodeOverride.NativeMethodInfoPtr_CreateDefault_Public_Static_MaterialChangeNodeOverride_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (MaterialChangeNodeOverride) null : new MaterialChangeNodeOverride(pointer);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MaterialChangeNodeOverride()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialChangeNodeOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MaterialChangeNodeOverride()
    {
      Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (MaterialChangeNodeOverride));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr);
      MaterialChangeNodeOverride.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, nameof (GUID));
      MaterialChangeNodeOverride.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, nameof (Material));
      MaterialChangeNodeOverride.NativeFieldInfoPtr_Use_RenderMaskTagOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, nameof (Use_RenderMaskTagOverride));
      MaterialChangeNodeOverride.NativeFieldInfoPtr_RenderMaskTagOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, nameof (RenderMaskTagOverride));
      MaterialChangeNodeOverride.NativeFieldInfoPtr_Use_ImportanceOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, nameof (Use_ImportanceOverride));
      MaterialChangeNodeOverride.NativeFieldInfoPtr_ImportanceOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, nameof (ImportanceOverride));
      MaterialChangeNodeOverride.NativeFieldInfoPtr_Use_AdditionalMaterialOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, nameof (Use_AdditionalMaterialOverride));
      MaterialChangeNodeOverride.NativeFieldInfoPtr_AdditionalMaterialOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, nameof (AdditionalMaterialOverride));
      MaterialChangeNodeOverride.NativeFieldInfoPtr_MaterialOverrideType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, nameof (MaterialOverrideType));
      MaterialChangeNodeOverride.NativeFieldInfoPtr_Use_CopyNormalMapOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, nameof (Use_CopyNormalMapOverride));
      MaterialChangeNodeOverride.NativeFieldInfoPtr_CopyNormalMapOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, nameof (CopyNormalMapOverride));
      MaterialChangeNodeOverride.NativeFieldInfoPtr_Use_CopyBaseMapOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, nameof (Use_CopyBaseMapOverride));
      MaterialChangeNodeOverride.NativeFieldInfoPtr_CopyBaseMapOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, nameof (CopyBaseMapOverride));
      MaterialChangeNodeOverride.NativeFieldInfoPtr_Use_ShadowCastingModeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, nameof (Use_ShadowCastingModeOverride));
      MaterialChangeNodeOverride.NativeFieldInfoPtr_ShadowCastingModeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, nameof (ShadowCastingModeOverride));
      MaterialChangeNodeOverride.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, 100686641);
      MaterialChangeNodeOverride.NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, 100686642);
      MaterialChangeNodeOverride.NativeMethodInfoPtr_CreateNew_Public_Static_MaterialChangeNodeOverride_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, 100686643);
      MaterialChangeNodeOverride.NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, 100686644);
      MaterialChangeNodeOverride.NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, 100686645);
      MaterialChangeNodeOverride.NativeMethodInfoPtr_CreateDefault_Public_Static_MaterialChangeNodeOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, 100686646);
      MaterialChangeNodeOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeNodeOverride>.NativeClassPtr, 100686647);
    }

    public MaterialChangeNodeOverride(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string GUID
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_GUID)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Material Material
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_Material));
        return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool Use_RenderMaskTagOverride
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_Use_RenderMaskTagOverride));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_Use_RenderMaskTagOverride)) = value;
      }
    }

    public unsafe RendererTagMask RenderMaskTagOverride
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_RenderMaskTagOverride));
        return pointer == IntPtr.Zero ? (RendererTagMask) null : new RendererTagMask(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_RenderMaskTagOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool Use_ImportanceOverride
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_Use_ImportanceOverride));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_Use_ImportanceOverride)) = value;
      }
    }

    public unsafe int ImportanceOverride
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_ImportanceOverride));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_ImportanceOverride)) = value;
      }
    }

    public unsafe bool Use_AdditionalMaterialOverride
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_Use_AdditionalMaterialOverride));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_Use_AdditionalMaterialOverride)) = value;
      }
    }

    public unsafe bool AdditionalMaterialOverride
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_AdditionalMaterialOverride));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_AdditionalMaterialOverride)) = value;
      }
    }

    public unsafe MaterialChangeTypeEnum MaterialOverrideType
    {
      get
      {
        return *(MaterialChangeTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_MaterialOverrideType));
      }
      [param: In] set
      {
        *(MaterialChangeTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_MaterialOverrideType)) = value;
      }
    }

    public unsafe bool Use_CopyNormalMapOverride
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_Use_CopyNormalMapOverride));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_Use_CopyNormalMapOverride)) = value;
      }
    }

    public unsafe bool CopyNormalMapOverride
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_CopyNormalMapOverride));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_CopyNormalMapOverride)) = value;
      }
    }

    public unsafe bool Use_CopyBaseMapOverride
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_Use_CopyBaseMapOverride));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_Use_CopyBaseMapOverride)) = value;
      }
    }

    public unsafe bool CopyBaseMapOverride
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_CopyBaseMapOverride));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_CopyBaseMapOverride)) = value;
      }
    }

    public unsafe bool Use_ShadowCastingModeOverride
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_Use_ShadowCastingModeOverride));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_Use_ShadowCastingModeOverride)) = value;
      }
    }

    public unsafe ShadowCastingMode ShadowCastingModeOverride
    {
      get
      {
        return *(ShadowCastingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_ShadowCastingModeOverride));
      }
      [param: In] set
      {
        *(ShadowCastingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeNodeOverride.NativeFieldInfoPtr_ShadowCastingModeOverride)) = value;
      }
    }
  }
}
