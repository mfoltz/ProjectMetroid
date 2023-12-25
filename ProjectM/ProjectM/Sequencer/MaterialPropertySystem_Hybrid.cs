// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.MaterialPropertySystem_Hybrid
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM.Hybrid;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  public class MaterialPropertySystem_Hybrid : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__HybridModelSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__HybridRendererAndDataIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChangeData;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedBlocks;
    private static readonly System.IntPtr NativeFieldInfoPtr__UsedThisFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__UsedLastFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__Renderers;
    private static readonly System.IntPtr NativeFieldInfoPtr__Masks;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddChange_Public_Void_Entity_Int32_byref_ChangeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103093, XrefRangeEnd = 1103149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialPropertySystem_Hybrid.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1103182, RefRangeEnd = 1103183, XrefRangeStart = 1103149, XrefRangeEnd = 1103182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddChange(Entity entity, int importance, [In] ref ChangeData change)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &importance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref change;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialPropertySystem_Hybrid.NativeMethodInfoPtr_AddChange_Public_Void_Entity_Int32_byref_ChangeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103183, XrefRangeEnd = 1103353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialPropertySystem_Hybrid.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MaterialPropertySystem_Hybrid()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialPropertySystem_Hybrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialPropertySystem_Hybrid.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MaterialPropertySystem_Hybrid()
    {
      Il2CppClassPointerStore<MaterialPropertySystem_Hybrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (MaterialPropertySystem_Hybrid));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid>.NativeClassPtr);
      MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__HybridModelSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid>.NativeClassPtr, nameof (_HybridModelSystem));
      MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__HybridRendererAndDataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid>.NativeClassPtr, nameof (_HybridRendererAndDataIndex));
      MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__ChangeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid>.NativeClassPtr, nameof (_ChangeData));
      MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__CachedBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid>.NativeClassPtr, nameof (_CachedBlocks));
      MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__UsedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid>.NativeClassPtr, nameof (_UsedThisFrame));
      MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__UsedLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid>.NativeClassPtr, nameof (_UsedLastFrame));
      MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__Renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid>.NativeClassPtr, nameof (_Renderers));
      MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__Masks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid>.NativeClassPtr, nameof (_Masks));
      MaterialPropertySystem_Hybrid.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid>.NativeClassPtr, 100687510);
      MaterialPropertySystem_Hybrid.NativeMethodInfoPtr_AddChange_Public_Void_Entity_Int32_byref_ChangeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid>.NativeClassPtr, 100687511);
      MaterialPropertySystem_Hybrid.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid>.NativeClassPtr, 100687512);
      MaterialPropertySystem_Hybrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid>.NativeClassPtr, 100687513);
      MaterialPropertySystem_Hybrid.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid>.NativeClassPtr, 100687514);
    }

    public MaterialPropertySystem_Hybrid(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HybridModelSystem _HybridModelSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__HybridModelSystem));
        return pointer == System.IntPtr.Zero ? (HybridModelSystem) null : new HybridModelSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__HybridModelSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex> _HybridRendererAndDataIndex
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__HybridRendererAndDataIndex));
        return pointer == System.IntPtr.Zero ? (List<MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex>) null : new List<MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__HybridRendererAndDataIndex), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ChangeData> _ChangeData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__ChangeData));
        return pointer == System.IntPtr.Zero ? (List<ChangeData>) null : new List<ChangeData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__ChangeData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<MaterialPropertyBlock> _CachedBlocks
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__CachedBlocks));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<MaterialPropertyBlock>) null : new Il2CppReferenceArray<MaterialPropertyBlock>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__CachedBlocks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<HybridModelRendererComponent> _UsedThisFrame
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__UsedThisFrame));
        return pointer == System.IntPtr.Zero ? (List<HybridModelRendererComponent>) null : new List<HybridModelRendererComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__UsedThisFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<HybridModelRendererComponent> _UsedLastFrame
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__UsedLastFrame));
        return pointer == System.IntPtr.Zero ? (List<HybridModelRendererComponent>) null : new List<HybridModelRendererComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__UsedLastFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Renderer> _Renderers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__Renderers));
        return pointer == System.IntPtr.Zero ? (List<Renderer>) null : new List<Renderer>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__Renderers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<int> _Masks
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__Masks));
        return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.NativeFieldInfoPtr__Masks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class HybridRendererAndDataIndex : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_HybridRenderer;
      private static readonly System.IntPtr NativeFieldInfoPtr_DataIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HybridRendererAndDataIndex_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103081, XrefRangeEnd = 1103085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(
        MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HybridRendererAndDataIndex_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103085, XrefRangeEnd = 1103093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static HybridRendererAndDataIndex()
      {
        Il2CppClassPointerStore<MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid>.NativeClassPtr, nameof (HybridRendererAndDataIndex));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex>.NativeClassPtr);
        MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex.NativeFieldInfoPtr_HybridRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex>.NativeClassPtr, nameof (HybridRenderer));
        MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex.NativeFieldInfoPtr_DataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex>.NativeClassPtr, nameof (DataIndex));
        MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex>.NativeClassPtr, nameof (Importance));
        MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HybridRendererAndDataIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex>.NativeClassPtr, 100687515);
        MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex>.NativeClassPtr, 100687516);
      }

      public HybridRendererAndDataIndex(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public HybridRendererAndDataIndex()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex>.NativeClassPtr, data));
      }

      public unsafe HybridModelRendererComponent HybridRenderer
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex.NativeFieldInfoPtr_HybridRenderer));
          return pointer == System.IntPtr.Zero ? (HybridModelRendererComponent) null : new HybridModelRendererComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex.NativeFieldInfoPtr_HybridRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int DataIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex.NativeFieldInfoPtr_DataIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex.NativeFieldInfoPtr_DataIndex)) = value;
        }
      }

      public unsafe int Importance
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex.NativeFieldInfoPtr_Importance));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Hybrid.HybridRendererAndDataIndex.NativeFieldInfoPtr_Importance)) = value;
        }
      }
    }
  }
}
