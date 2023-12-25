// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequencerEntityAssociationSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Sequencer
{
  public class SequencerEntityAssociationSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr_FakeEntityToRealEntityMap;
    private static readonly IntPtr NativeFieldInfoPtr_IdCounter;
    private static readonly IntPtr NativeMethodInfoPtr_CreateFakeEntity_Public_Static_Entity_NativeReference_1_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_RemoveEntity_Public_Void_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1099664, RefRangeEnd = 1099665, XrefRangeStart = 1099658, XrefRangeEnd = 1099664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateFakeEntity(NativeReference<int> idCounter)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &idCounter;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequencerEntityAssociationSystem.NativeMethodInfoPtr_CreateFakeEntity_Public_Static_Entity_NativeReference_1_Int32_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099665, XrefRangeEnd = 1099672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequencerEntityAssociationSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1099675, RefRangeEnd = 1099677, XrefRangeStart = 1099672, XrefRangeEnd = 1099675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveEntity(Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &entity;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequencerEntityAssociationSystem.NativeMethodInfoPtr_RemoveEntity_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099677, XrefRangeEnd = 1099683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequencerEntityAssociationSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequencerEntityAssociationSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequencerEntityAssociationSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequencerEntityAssociationSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequencerEntityAssociationSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequencerEntityAssociationSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequencerEntityAssociationSystem()
    {
      Il2CppClassPointerStore<SequencerEntityAssociationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequencerEntityAssociationSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerEntityAssociationSystem>.NativeClassPtr);
      SequencerEntityAssociationSystem.NativeFieldInfoPtr_FakeEntityToRealEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerEntityAssociationSystem>.NativeClassPtr, nameof (FakeEntityToRealEntityMap));
      SequencerEntityAssociationSystem.NativeFieldInfoPtr_IdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerEntityAssociationSystem>.NativeClassPtr, nameof (IdCounter));
      SequencerEntityAssociationSystem.NativeMethodInfoPtr_CreateFakeEntity_Public_Static_Entity_NativeReference_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerEntityAssociationSystem>.NativeClassPtr, 100687292);
      SequencerEntityAssociationSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerEntityAssociationSystem>.NativeClassPtr, 100687293);
      SequencerEntityAssociationSystem.NativeMethodInfoPtr_RemoveEntity_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerEntityAssociationSystem>.NativeClassPtr, 100687294);
      SequencerEntityAssociationSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerEntityAssociationSystem>.NativeClassPtr, 100687295);
      SequencerEntityAssociationSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerEntityAssociationSystem>.NativeClassPtr, 100687296);
      SequencerEntityAssociationSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerEntityAssociationSystem>.NativeClassPtr, 100687297);
      SequencerEntityAssociationSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerEntityAssociationSystem>.NativeClassPtr, 100687298);
    }

    public SequencerEntityAssociationSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeHashMap<Entity, Entity> FakeEntityToRealEntityMap
    {
      get
      {
        return *(NativeHashMap<Entity, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerEntityAssociationSystem.NativeFieldInfoPtr_FakeEntityToRealEntityMap));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerEntityAssociationSystem.NativeFieldInfoPtr_FakeEntityToRealEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<Entity, Entity>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe NativeReference<int> IdCounter
    {
      get
      {
        return *(NativeReference<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerEntityAssociationSystem.NativeFieldInfoPtr_IdCounter));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerEntityAssociationSystem.NativeFieldInfoPtr_IdCounter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeReference<int>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }
  }
}
