// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.HideMaterialSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Sequencer
{
  public class HideMaterialSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__MaterialEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr__HideMaterialSystem_Hybrid;
    private static readonly System.IntPtr NativeFieldInfoPtr__HideMaterialSystem_Dots;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterialEntries_Public_NativeList_1_MaterialEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(54)]
    [CachedScanResults(RefRangeStart = 73358, RefRangeEnd = 73412, XrefRangeStart = 73358, XrefRangeEnd = 73412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeList<HideMaterialSystem.MaterialEntry> GetMaterialEntries()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HideMaterialSystem.NativeMethodInfoPtr_GetMaterialEntries_Public_NativeList_1_MaterialEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<HideMaterialSystem.MaterialEntry>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101817, XrefRangeEnd = 1101830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HideMaterialSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101830, XrefRangeEnd = 1101833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HideMaterialSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101833, XrefRangeEnd = 1101857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HideMaterialSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HideMaterialSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HideMaterialSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HideMaterialSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HideMaterialSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HideMaterialSystem()
    {
      Il2CppClassPointerStore<HideMaterialSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (HideMaterialSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideMaterialSystem>.NativeClassPtr);
      HideMaterialSystem.NativeFieldInfoPtr__MaterialEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem>.NativeClassPtr, nameof (_MaterialEntries));
      HideMaterialSystem.NativeFieldInfoPtr__HideMaterialSystem_Hybrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem>.NativeClassPtr, nameof (_HideMaterialSystem_Hybrid));
      HideMaterialSystem.NativeFieldInfoPtr__HideMaterialSystem_Dots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem>.NativeClassPtr, nameof (_HideMaterialSystem_Dots));
      HideMaterialSystem.NativeMethodInfoPtr_GetMaterialEntries_Public_NativeList_1_MaterialEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem>.NativeClassPtr, 100687444);
      HideMaterialSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem>.NativeClassPtr, 100687445);
      HideMaterialSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem>.NativeClassPtr, 100687446);
      HideMaterialSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem>.NativeClassPtr, 100687447);
      HideMaterialSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem>.NativeClassPtr, 100687448);
      HideMaterialSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem>.NativeClassPtr, 100687449);
    }

    public HideMaterialSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeList<HideMaterialSystem.MaterialEntry> _MaterialEntries
    {
      get
      {
        return *(NativeList<HideMaterialSystem.MaterialEntry>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem.NativeFieldInfoPtr__MaterialEntries));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem.NativeFieldInfoPtr__MaterialEntries), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<HideMaterialSystem.MaterialEntry>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe HideMaterialSystem_Hybrid _HideMaterialSystem_Hybrid
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem.NativeFieldInfoPtr__HideMaterialSystem_Hybrid));
        return pointer == System.IntPtr.Zero ? (HideMaterialSystem_Hybrid) null : new HideMaterialSystem_Hybrid(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem.NativeFieldInfoPtr__HideMaterialSystem_Hybrid), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HideMaterialSystem_Dots _HideMaterialSystem_Dots
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem.NativeFieldInfoPtr__HideMaterialSystem_Dots));
        return pointer == System.IntPtr.Zero ? (HideMaterialSystem_Dots) null : new HideMaterialSystem_Dots(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem.NativeFieldInfoPtr__HideMaterialSystem_Dots), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MaterialEntry
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_rendererMask;
      private static readonly System.IntPtr NativeFieldInfoPtr_importance;
      [FieldOffset(0)]
      public Entity entity;
      [FieldOffset(8)]
      public int rendererMask;
      [FieldOffset(12)]
      public int importance;

      static MaterialEntry()
      {
        Il2CppClassPointerStore<HideMaterialSystem.MaterialEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HideMaterialSystem>.NativeClassPtr, nameof (MaterialEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideMaterialSystem.MaterialEntry>.NativeClassPtr);
        HideMaterialSystem.MaterialEntry.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem.MaterialEntry>.NativeClassPtr, nameof (entity));
        HideMaterialSystem.MaterialEntry.NativeFieldInfoPtr_rendererMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem.MaterialEntry>.NativeClassPtr, nameof (rendererMask));
        HideMaterialSystem.MaterialEntry.NativeFieldInfoPtr_importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem.MaterialEntry>.NativeClassPtr, nameof (importance));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HideMaterialSystem.MaterialEntry>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
