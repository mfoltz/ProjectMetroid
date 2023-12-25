// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.MaterialChangeSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM.Sequencer
{
  public class MaterialChangeSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__MaterialEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaterialChangeSystem_Hybrid;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaterialChangeSystem_Dots;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterialEntries_Public_NativeList_1_MaterialEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(54)]
    [CachedScanResults(RefRangeStart = 73358, RefRangeEnd = 73412, XrefRangeStart = 73358, XrefRangeEnd = 73412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeList<MaterialChangeSystem.MaterialEntry> GetMaterialEntries()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MaterialChangeSystem.NativeMethodInfoPtr_GetMaterialEntries_Public_NativeList_1_MaterialEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<MaterialChangeSystem.MaterialEntry>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102161, XrefRangeEnd = 1102174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialChangeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102174, XrefRangeEnd = 1102177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialChangeSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102177, XrefRangeEnd = 1102211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialChangeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MaterialChangeSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialChangeSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialChangeSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialChangeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MaterialChangeSystem()
    {
      Il2CppClassPointerStore<MaterialChangeSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (MaterialChangeSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialChangeSystem>.NativeClassPtr);
      MaterialChangeSystem.NativeFieldInfoPtr__MaterialEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem>.NativeClassPtr, nameof (_MaterialEntries));
      MaterialChangeSystem.NativeFieldInfoPtr__MaterialChangeSystem_Hybrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem>.NativeClassPtr, nameof (_MaterialChangeSystem_Hybrid));
      MaterialChangeSystem.NativeFieldInfoPtr__MaterialChangeSystem_Dots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem>.NativeClassPtr, nameof (_MaterialChangeSystem_Dots));
      MaterialChangeSystem.NativeMethodInfoPtr_GetMaterialEntries_Public_NativeList_1_MaterialEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem>.NativeClassPtr, 100687470);
      MaterialChangeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem>.NativeClassPtr, 100687471);
      MaterialChangeSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem>.NativeClassPtr, 100687472);
      MaterialChangeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem>.NativeClassPtr, 100687473);
      MaterialChangeSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem>.NativeClassPtr, 100687474);
      MaterialChangeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem>.NativeClassPtr, 100687475);
    }

    public MaterialChangeSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeList<MaterialChangeSystem.MaterialEntry> _MaterialEntries
    {
      get
      {
        return *(NativeList<MaterialChangeSystem.MaterialEntry>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem.NativeFieldInfoPtr__MaterialEntries));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem.NativeFieldInfoPtr__MaterialEntries), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<MaterialChangeSystem.MaterialEntry>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe MaterialChangeSystem_Hybrid _MaterialChangeSystem_Hybrid
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem.NativeFieldInfoPtr__MaterialChangeSystem_Hybrid));
        return pointer == System.IntPtr.Zero ? (MaterialChangeSystem_Hybrid) null : new MaterialChangeSystem_Hybrid(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem.NativeFieldInfoPtr__MaterialChangeSystem_Hybrid), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MaterialChangeSystem_Dots _MaterialChangeSystem_Dots
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem.NativeFieldInfoPtr__MaterialChangeSystem_Dots));
        return pointer == System.IntPtr.Zero ? (MaterialChangeSystem_Dots) null : new MaterialChangeSystem_Dots(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem.NativeFieldInfoPtr__MaterialChangeSystem_Dots), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MaterialEntry
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_SequenceEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaterialAssetIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_ShadowCastingMode;
      private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_RendererMask;
      private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
      private static readonly System.IntPtr NativeFieldInfoPtr_CopyNormalMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_CopyBaseMap;
      [FieldOffset(0)]
      public Entity Entity;
      [FieldOffset(8)]
      public Entity SequenceEntity;
      [FieldOffset(16)]
      public int MaterialAssetIndex;
      [FieldOffset(20)]
      public ShadowCastingMode ShadowCastingMode;
      [FieldOffset(24)]
      public float StartTime;
      [FieldOffset(28)]
      public int RendererMask;
      [FieldOffset(32)]
      public int Importance;
      [FieldOffset(36)]
      public bool CopyNormalMap;
      [FieldOffset(37)]
      public bool CopyBaseMap;

      static MaterialEntry()
      {
        Il2CppClassPointerStore<MaterialChangeSystem.MaterialEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialChangeSystem>.NativeClassPtr, nameof (MaterialEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialChangeSystem.MaterialEntry>.NativeClassPtr);
        MaterialChangeSystem.MaterialEntry.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem.MaterialEntry>.NativeClassPtr, nameof (Entity));
        MaterialChangeSystem.MaterialEntry.NativeFieldInfoPtr_SequenceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem.MaterialEntry>.NativeClassPtr, nameof (SequenceEntity));
        MaterialChangeSystem.MaterialEntry.NativeFieldInfoPtr_MaterialAssetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem.MaterialEntry>.NativeClassPtr, nameof (MaterialAssetIndex));
        MaterialChangeSystem.MaterialEntry.NativeFieldInfoPtr_ShadowCastingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem.MaterialEntry>.NativeClassPtr, nameof (ShadowCastingMode));
        MaterialChangeSystem.MaterialEntry.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem.MaterialEntry>.NativeClassPtr, nameof (StartTime));
        MaterialChangeSystem.MaterialEntry.NativeFieldInfoPtr_RendererMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem.MaterialEntry>.NativeClassPtr, nameof (RendererMask));
        MaterialChangeSystem.MaterialEntry.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem.MaterialEntry>.NativeClassPtr, nameof (Importance));
        MaterialChangeSystem.MaterialEntry.NativeFieldInfoPtr_CopyNormalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem.MaterialEntry>.NativeClassPtr, nameof (CopyNormalMap));
        MaterialChangeSystem.MaterialEntry.NativeFieldInfoPtr_CopyBaseMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem.MaterialEntry>.NativeClassPtr, nameof (CopyBaseMap));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialChangeSystem.MaterialEntry>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
