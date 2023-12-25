// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.HideMaterialSystem_Hybrid
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Hybrid;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  public class HideMaterialSystem_Hybrid : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__HybridModelSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__HideMaterialEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr__RenderersUsedThisFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__RendererUsedLastFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedRenderers;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddHideMaterial_Public_Void_Entity_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToggleVisibilityForRenderer_Private_Void_FrameMapData_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102002, XrefRangeEnd = 1102034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HideMaterialSystem_Hybrid.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1102065, RefRangeEnd = 1102066, XrefRangeStart = 1102034, XrefRangeEnd = 1102065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddHideMaterial(Entity entity, int rendererMask, int importance)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rendererMask;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &importance;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HideMaterialSystem_Hybrid.NativeMethodInfoPtr_AddHideMaterial_Public_Void_Entity_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102066, XrefRangeEnd = 1102152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HideMaterialSystem_Hybrid.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1102160, RefRangeEnd = 1102161, XrefRangeStart = 1102152, XrefRangeEnd = 1102160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ToggleVisibilityForRenderer(
      HideMaterialSystem_Hybrid.FrameMapData mappingData,
      bool visible)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) mappingData));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &visible;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HideMaterialSystem_Hybrid.NativeMethodInfoPtr_ToggleVisibilityForRenderer_Private_Void_FrameMapData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HideMaterialSystem_Hybrid()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HideMaterialSystem_Hybrid>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HideMaterialSystem_Hybrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HideMaterialSystem_Hybrid.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HideMaterialSystem_Hybrid()
    {
      Il2CppClassPointerStore<HideMaterialSystem_Hybrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (HideMaterialSystem_Hybrid));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideMaterialSystem_Hybrid>.NativeClassPtr);
      HideMaterialSystem_Hybrid.NativeFieldInfoPtr__HybridModelSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem_Hybrid>.NativeClassPtr, nameof (_HybridModelSystem));
      HideMaterialSystem_Hybrid.NativeFieldInfoPtr__HideMaterialEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem_Hybrid>.NativeClassPtr, nameof (_HideMaterialEntries));
      HideMaterialSystem_Hybrid.NativeFieldInfoPtr__RenderersUsedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem_Hybrid>.NativeClassPtr, nameof (_RenderersUsedThisFrame));
      HideMaterialSystem_Hybrid.NativeFieldInfoPtr__RendererUsedLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem_Hybrid>.NativeClassPtr, nameof (_RendererUsedLastFrame));
      HideMaterialSystem_Hybrid.NativeFieldInfoPtr__CachedRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem_Hybrid>.NativeClassPtr, nameof (_CachedRenderers));
      HideMaterialSystem_Hybrid.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Hybrid>.NativeClassPtr, 100687460);
      HideMaterialSystem_Hybrid.NativeMethodInfoPtr_AddHideMaterial_Public_Void_Entity_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Hybrid>.NativeClassPtr, 100687461);
      HideMaterialSystem_Hybrid.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Hybrid>.NativeClassPtr, 100687462);
      HideMaterialSystem_Hybrid.NativeMethodInfoPtr_ToggleVisibilityForRenderer_Private_Void_FrameMapData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Hybrid>.NativeClassPtr, 100687463);
      HideMaterialSystem_Hybrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Hybrid>.NativeClassPtr, 100687464);
      HideMaterialSystem_Hybrid.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Hybrid>.NativeClassPtr, 100687465);
    }

    public HideMaterialSystem_Hybrid(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HybridModelSystem _HybridModelSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.NativeFieldInfoPtr__HybridModelSystem));
        return pointer == System.IntPtr.Zero ? (HybridModelSystem) null : new HybridModelSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.NativeFieldInfoPtr__HybridModelSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<HideMaterialSystem_Hybrid.HideMaterialEntry> _HideMaterialEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.NativeFieldInfoPtr__HideMaterialEntries));
        return pointer == System.IntPtr.Zero ? (List<HideMaterialSystem_Hybrid.HideMaterialEntry>) null : new List<HideMaterialSystem_Hybrid.HideMaterialEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.NativeFieldInfoPtr__HideMaterialEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, HideMaterialSystem_Hybrid.FrameMapData> _RenderersUsedThisFrame
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.NativeFieldInfoPtr__RenderersUsedThisFrame));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, HideMaterialSystem_Hybrid.FrameMapData>) null : new Dictionary<int, HideMaterialSystem_Hybrid.FrameMapData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.NativeFieldInfoPtr__RenderersUsedThisFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, HideMaterialSystem_Hybrid.FrameMapData> _RendererUsedLastFrame
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.NativeFieldInfoPtr__RendererUsedLastFrame));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, HideMaterialSystem_Hybrid.FrameMapData>) null : new Dictionary<int, HideMaterialSystem_Hybrid.FrameMapData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.NativeFieldInfoPtr__RendererUsedLastFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Renderer> _CachedRenderers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.NativeFieldInfoPtr__CachedRenderers));
        return pointer == System.IntPtr.Zero ? (List<Renderer>) null : new List<Renderer>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.NativeFieldInfoPtr__CachedRenderers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class HideMaterialEntry : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_HybridRenderer;
      private static readonly System.IntPtr NativeFieldInfoPtr_RendererMask;
      private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HideMaterialEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HideMaterialEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101990, XrefRangeEnd = 1101992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(HideMaterialSystem_Hybrid.HideMaterialEntry other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HideMaterialSystem_Hybrid.HideMaterialEntry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HideMaterialEntry_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101992, XrefRangeEnd = 1101993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(HideMaterialSystem_Hybrid.HideMaterialEntry other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HideMaterialSystem_Hybrid.HideMaterialEntry.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HideMaterialEntry_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101993, XrefRangeEnd = 1101997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe bool Equals(Il2CppSystem.Object obj)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HideMaterialSystem_Hybrid.HideMaterialEntry.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101997, XrefRangeEnd = 1102002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HideMaterialSystem_Hybrid.HideMaterialEntry.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static HideMaterialEntry()
      {
        Il2CppClassPointerStore<HideMaterialSystem_Hybrid.HideMaterialEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HideMaterialSystem_Hybrid>.NativeClassPtr, nameof (HideMaterialEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideMaterialSystem_Hybrid.HideMaterialEntry>.NativeClassPtr);
        HideMaterialSystem_Hybrid.HideMaterialEntry.NativeFieldInfoPtr_HybridRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem_Hybrid.HideMaterialEntry>.NativeClassPtr, nameof (HybridRenderer));
        HideMaterialSystem_Hybrid.HideMaterialEntry.NativeFieldInfoPtr_RendererMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem_Hybrid.HideMaterialEntry>.NativeClassPtr, nameof (RendererMask));
        HideMaterialSystem_Hybrid.HideMaterialEntry.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem_Hybrid.HideMaterialEntry>.NativeClassPtr, nameof (Importance));
        HideMaterialSystem_Hybrid.HideMaterialEntry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HideMaterialEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Hybrid.HideMaterialEntry>.NativeClassPtr, 100687466);
        HideMaterialSystem_Hybrid.HideMaterialEntry.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HideMaterialEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Hybrid.HideMaterialEntry>.NativeClassPtr, 100687467);
        HideMaterialSystem_Hybrid.HideMaterialEntry.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Hybrid.HideMaterialEntry>.NativeClassPtr, 100687468);
        HideMaterialSystem_Hybrid.HideMaterialEntry.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Hybrid.HideMaterialEntry>.NativeClassPtr, 100687469);
      }

      public HideMaterialEntry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public HideMaterialEntry()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HideMaterialSystem_Hybrid.HideMaterialEntry>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HideMaterialSystem_Hybrid.HideMaterialEntry>.NativeClassPtr, data));
      }

      public unsafe HybridModelRendererComponent HybridRenderer
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.HideMaterialEntry.NativeFieldInfoPtr_HybridRenderer));
          return pointer == System.IntPtr.Zero ? (HybridModelRendererComponent) null : new HybridModelRendererComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.HideMaterialEntry.NativeFieldInfoPtr_HybridRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int RendererMask
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.HideMaterialEntry.NativeFieldInfoPtr_RendererMask));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.HideMaterialEntry.NativeFieldInfoPtr_RendererMask)) = value;
        }
      }

      public unsafe int Importance
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.HideMaterialEntry.NativeFieldInfoPtr_Importance));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.HideMaterialEntry.NativeFieldInfoPtr_Importance)) = value;
        }
      }
    }

    public sealed class FrameMapData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_HybridRenderer;
      private static readonly System.IntPtr NativeFieldInfoPtr_Renderer;

      static FrameMapData()
      {
        Il2CppClassPointerStore<HideMaterialSystem_Hybrid.FrameMapData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HideMaterialSystem_Hybrid>.NativeClassPtr, nameof (FrameMapData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideMaterialSystem_Hybrid.FrameMapData>.NativeClassPtr);
        HideMaterialSystem_Hybrid.FrameMapData.NativeFieldInfoPtr_HybridRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem_Hybrid.FrameMapData>.NativeClassPtr, nameof (HybridRenderer));
        HideMaterialSystem_Hybrid.FrameMapData.NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem_Hybrid.FrameMapData>.NativeClassPtr, nameof (Renderer));
      }

      public FrameMapData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public FrameMapData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HideMaterialSystem_Hybrid.FrameMapData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HideMaterialSystem_Hybrid.FrameMapData>.NativeClassPtr, data));
      }

      public unsafe HybridModelRendererComponent HybridRenderer
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.FrameMapData.NativeFieldInfoPtr_HybridRenderer));
          return pointer == System.IntPtr.Zero ? (HybridModelRendererComponent) null : new HybridModelRendererComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.FrameMapData.NativeFieldInfoPtr_HybridRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Renderer Renderer
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.FrameMapData.NativeFieldInfoPtr_Renderer));
          return pointer == System.IntPtr.Zero ? (Renderer) null : new Renderer(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Hybrid.FrameMapData.NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
