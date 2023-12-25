// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.MaterialPropertySystem
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
  public class MaterialPropertySystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__MaterialPropertySystem_Hybrid;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaterialPropertySystem_Dots;
    private static readonly System.IntPtr NativeFieldInfoPtr__SequencerEntityAssociationSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__Entries;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntries_Public_NativeList_1_Entry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    public unsafe NativeList<MaterialPropertySystem.Entry> GetEntries()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MaterialPropertySystem.NativeMethodInfoPtr_GetEntries_Public_NativeList_1_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<MaterialPropertySystem.Entry>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102677, XrefRangeEnd = 1102695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialPropertySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102695, XrefRangeEnd = 1102698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialPropertySystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102698, XrefRangeEnd = 1102740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialPropertySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MaterialPropertySystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialPropertySystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialPropertySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialPropertySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MaterialPropertySystem()
    {
      Il2CppClassPointerStore<MaterialPropertySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (MaterialPropertySystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialPropertySystem>.NativeClassPtr);
      MaterialPropertySystem.NativeFieldInfoPtr__MaterialPropertySystem_Hybrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem>.NativeClassPtr, nameof (_MaterialPropertySystem_Hybrid));
      MaterialPropertySystem.NativeFieldInfoPtr__MaterialPropertySystem_Dots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem>.NativeClassPtr, nameof (_MaterialPropertySystem_Dots));
      MaterialPropertySystem.NativeFieldInfoPtr__SequencerEntityAssociationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem>.NativeClassPtr, nameof (_SequencerEntityAssociationSystem));
      MaterialPropertySystem.NativeFieldInfoPtr__Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem>.NativeClassPtr, nameof (_Entries));
      MaterialPropertySystem.NativeMethodInfoPtr_GetEntries_Public_NativeList_1_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem>.NativeClassPtr, 100687494);
      MaterialPropertySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem>.NativeClassPtr, 100687495);
      MaterialPropertySystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem>.NativeClassPtr, 100687496);
      MaterialPropertySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem>.NativeClassPtr, 100687497);
      MaterialPropertySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem>.NativeClassPtr, 100687498);
      MaterialPropertySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem>.NativeClassPtr, 100687499);
    }

    public MaterialPropertySystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe MaterialPropertySystem_Hybrid _MaterialPropertySystem_Hybrid
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem.NativeFieldInfoPtr__MaterialPropertySystem_Hybrid));
        return pointer == System.IntPtr.Zero ? (MaterialPropertySystem_Hybrid) null : new MaterialPropertySystem_Hybrid(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem.NativeFieldInfoPtr__MaterialPropertySystem_Hybrid), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MaterialPropertySystem_Dots _MaterialPropertySystem_Dots
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem.NativeFieldInfoPtr__MaterialPropertySystem_Dots));
        return pointer == System.IntPtr.Zero ? (MaterialPropertySystem_Dots) null : new MaterialPropertySystem_Dots(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem.NativeFieldInfoPtr__MaterialPropertySystem_Dots), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequencerEntityAssociationSystem _SequencerEntityAssociationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem.NativeFieldInfoPtr__SequencerEntityAssociationSystem));
        return pointer == System.IntPtr.Zero ? (SequencerEntityAssociationSystem) null : new SequencerEntityAssociationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem.NativeFieldInfoPtr__SequencerEntityAssociationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<MaterialPropertySystem.Entry> _Entries
    {
      get
      {
        return *(NativeList<MaterialPropertySystem.Entry>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem.NativeFieldInfoPtr__Entries));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem.NativeFieldInfoPtr__Entries), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<MaterialPropertySystem.Entry>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Entry
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChangeData;
      [FieldOffset(0)]
      public Entity Entity;
      [FieldOffset(8)]
      public int Importance;
      [FieldOffset(12)]
      public ChangeData ChangeData;

      static Entry()
      {
        Il2CppClassPointerStore<MaterialPropertySystem.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialPropertySystem>.NativeClassPtr, nameof (Entry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialPropertySystem.Entry>.NativeClassPtr);
        MaterialPropertySystem.Entry.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem.Entry>.NativeClassPtr, nameof (Entity));
        MaterialPropertySystem.Entry.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem.Entry>.NativeClassPtr, nameof (Importance));
        MaterialPropertySystem.Entry.NativeFieldInfoPtr_ChangeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem.Entry>.NativeClassPtr, nameof (ChangeData));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialPropertySystem.Entry>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
