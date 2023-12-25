// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.AdditionalMaterialSystem
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
  public class AdditionalMaterialSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__MaterialEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalMaterialSystem_Hybrid;
    private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalMaterialSystem_Dots;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterialEntries_Public_NativeList_1_MaterialEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(54)]
    [CachedScanResults(RefRangeStart = 73358, RefRangeEnd = 73412, XrefRangeStart = 73358, XrefRangeEnd = 73412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeList<AdditionalMaterialSystem.MaterialEntry> GetMaterialEntries()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialSystem.NativeMethodInfoPtr_GetMaterialEntries_Public_NativeList_1_MaterialEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<AdditionalMaterialSystem.MaterialEntry>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099683, XrefRangeEnd = 1099696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AdditionalMaterialSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099696, XrefRangeEnd = 1099699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AdditionalMaterialSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099699, XrefRangeEnd = 1099733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AdditionalMaterialSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AdditionalMaterialSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdditionalMaterialSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AdditionalMaterialSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AdditionalMaterialSystem()
    {
      Il2CppClassPointerStore<AdditionalMaterialSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (AdditionalMaterialSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalMaterialSystem>.NativeClassPtr);
      AdditionalMaterialSystem.NativeFieldInfoPtr__MaterialEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem>.NativeClassPtr, nameof (_MaterialEntries));
      AdditionalMaterialSystem.NativeFieldInfoPtr__AdditionalMaterialSystem_Hybrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem>.NativeClassPtr, nameof (_AdditionalMaterialSystem_Hybrid));
      AdditionalMaterialSystem.NativeFieldInfoPtr__AdditionalMaterialSystem_Dots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem>.NativeClassPtr, nameof (_AdditionalMaterialSystem_Dots));
      AdditionalMaterialSystem.NativeMethodInfoPtr_GetMaterialEntries_Public_NativeList_1_MaterialEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem>.NativeClassPtr, 100687299);
      AdditionalMaterialSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem>.NativeClassPtr, 100687300);
      AdditionalMaterialSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem>.NativeClassPtr, 100687301);
      AdditionalMaterialSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem>.NativeClassPtr, 100687302);
      AdditionalMaterialSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem>.NativeClassPtr, 100687303);
      AdditionalMaterialSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem>.NativeClassPtr, 100687304);
    }

    public AdditionalMaterialSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeList<AdditionalMaterialSystem.MaterialEntry> _MaterialEntries
    {
      get
      {
        return *(NativeList<AdditionalMaterialSystem.MaterialEntry>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem.NativeFieldInfoPtr__MaterialEntries));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem.NativeFieldInfoPtr__MaterialEntries), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<AdditionalMaterialSystem.MaterialEntry>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe AdditionalMaterialSystem_Hybrid _AdditionalMaterialSystem_Hybrid
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem.NativeFieldInfoPtr__AdditionalMaterialSystem_Hybrid));
        return pointer == System.IntPtr.Zero ? (AdditionalMaterialSystem_Hybrid) null : new AdditionalMaterialSystem_Hybrid(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem.NativeFieldInfoPtr__AdditionalMaterialSystem_Hybrid), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AdditionalMaterialSystem_Dots _AdditionalMaterialSystem_Dots
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem.NativeFieldInfoPtr__AdditionalMaterialSystem_Dots));
        return pointer == System.IntPtr.Zero ? (AdditionalMaterialSystem_Dots) null : new AdditionalMaterialSystem_Dots(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem.NativeFieldInfoPtr__AdditionalMaterialSystem_Dots), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MaterialEntry
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalFakeEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_SequenceEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaterialAssetIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_ShadowCastingMode;
      private static readonly System.IntPtr NativeFieldInfoPtr_RendererMask;
      private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
      private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_CopyNormalMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_CopyBaseMap;
      [FieldOffset(0)]
      public Entity AdditionalFakeEntity;
      [FieldOffset(8)]
      public Entity Entity;
      [FieldOffset(16)]
      public Entity SequenceEntity;
      [FieldOffset(24)]
      public int MaterialAssetIndex;
      [FieldOffset(28)]
      public ShadowCastingMode ShadowCastingMode;
      [FieldOffset(32)]
      public int RendererMask;
      [FieldOffset(36)]
      public int Importance;
      [FieldOffset(40)]
      public float StartTime;
      [FieldOffset(44)]
      public bool CopyNormalMap;
      [FieldOffset(45)]
      public bool CopyBaseMap;

      static MaterialEntry()
      {
        Il2CppClassPointerStore<AdditionalMaterialSystem.MaterialEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdditionalMaterialSystem>.NativeClassPtr, nameof (MaterialEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalMaterialSystem.MaterialEntry>.NativeClassPtr);
        AdditionalMaterialSystem.MaterialEntry.NativeFieldInfoPtr_AdditionalFakeEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem.MaterialEntry>.NativeClassPtr, nameof (AdditionalFakeEntity));
        AdditionalMaterialSystem.MaterialEntry.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem.MaterialEntry>.NativeClassPtr, nameof (Entity));
        AdditionalMaterialSystem.MaterialEntry.NativeFieldInfoPtr_SequenceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem.MaterialEntry>.NativeClassPtr, nameof (SequenceEntity));
        AdditionalMaterialSystem.MaterialEntry.NativeFieldInfoPtr_MaterialAssetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem.MaterialEntry>.NativeClassPtr, nameof (MaterialAssetIndex));
        AdditionalMaterialSystem.MaterialEntry.NativeFieldInfoPtr_ShadowCastingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem.MaterialEntry>.NativeClassPtr, nameof (ShadowCastingMode));
        AdditionalMaterialSystem.MaterialEntry.NativeFieldInfoPtr_RendererMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem.MaterialEntry>.NativeClassPtr, nameof (RendererMask));
        AdditionalMaterialSystem.MaterialEntry.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem.MaterialEntry>.NativeClassPtr, nameof (Importance));
        AdditionalMaterialSystem.MaterialEntry.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem.MaterialEntry>.NativeClassPtr, nameof (StartTime));
        AdditionalMaterialSystem.MaterialEntry.NativeFieldInfoPtr_CopyNormalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem.MaterialEntry>.NativeClassPtr, nameof (CopyNormalMap));
        AdditionalMaterialSystem.MaterialEntry.NativeFieldInfoPtr_CopyBaseMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem.MaterialEntry>.NativeClassPtr, nameof (CopyBaseMap));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AdditionalMaterialSystem.MaterialEntry>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
