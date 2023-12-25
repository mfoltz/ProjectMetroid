// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.HideMaterialSystem_Dots
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Sequencer
{
  public class HideMaterialSystem_Dots : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__HideMaterialEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastFrameChanges;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddHideMaterial_Public_Void_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RestoreVisibilityForEntity_Public_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101863, XrefRangeEnd = 1101875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HideMaterialSystem_Dots.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1101887, RefRangeEnd = 1101888, XrefRangeStart = 1101875, XrefRangeEnd = 1101887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddHideMaterial(Entity entity, int importance)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &importance;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HideMaterialSystem_Dots.NativeMethodInfoPtr_AddHideMaterial_Public_Void_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101888, XrefRangeEnd = 1101970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HideMaterialSystem_Dots.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101970, XrefRangeEnd = 1101990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RestoreVisibilityForEntity(EntityManager entityManager, Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HideMaterialSystem_Dots.NativeMethodInfoPtr_RestoreVisibilityForEntity_Public_Void_EntityManager_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HideMaterialSystem_Dots()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HideMaterialSystem_Dots>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HideMaterialSystem_Dots.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HideMaterialSystem_Dots.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HideMaterialSystem_Dots()
    {
      Il2CppClassPointerStore<HideMaterialSystem_Dots>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (HideMaterialSystem_Dots));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideMaterialSystem_Dots>.NativeClassPtr);
      HideMaterialSystem_Dots.NativeFieldInfoPtr__HideMaterialEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem_Dots>.NativeClassPtr, nameof (_HideMaterialEntries));
      HideMaterialSystem_Dots.NativeFieldInfoPtr__LastFrameChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem_Dots>.NativeClassPtr, nameof (_LastFrameChanges));
      HideMaterialSystem_Dots.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Dots>.NativeClassPtr, 100687450);
      HideMaterialSystem_Dots.NativeMethodInfoPtr_AddHideMaterial_Public_Void_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Dots>.NativeClassPtr, 100687451);
      HideMaterialSystem_Dots.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Dots>.NativeClassPtr, 100687452);
      HideMaterialSystem_Dots.NativeMethodInfoPtr_RestoreVisibilityForEntity_Public_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Dots>.NativeClassPtr, 100687453);
      HideMaterialSystem_Dots.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Dots>.NativeClassPtr, 100687454);
      HideMaterialSystem_Dots.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Dots>.NativeClassPtr, 100687455);
    }

    public HideMaterialSystem_Dots(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<HideMaterialSystem_Dots.HideMaterialEntry> _HideMaterialEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Dots.NativeFieldInfoPtr__HideMaterialEntries));
        return pointer == System.IntPtr.Zero ? (List<HideMaterialSystem_Dots.HideMaterialEntry>) null : new List<HideMaterialSystem_Dots.HideMaterialEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Dots.NativeFieldInfoPtr__HideMaterialEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<HideMaterialSystem_Dots.HideMaterialEntry> _LastFrameChanges
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Dots.NativeFieldInfoPtr__LastFrameChanges));
        return pointer == System.IntPtr.Zero ? (List<HideMaterialSystem_Dots.HideMaterialEntry>) null : new List<HideMaterialSystem_Dots.HideMaterialEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HideMaterialSystem_Dots.NativeFieldInfoPtr__LastFrameChanges), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HideMaterialEntry
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HideMaterialEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HideMaterialEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public Entity Entity;
      [FieldOffset(8)]
      public int Importance;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101857, XrefRangeEnd = 1101859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(HideMaterialSystem_Dots.HideMaterialEntry other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HideMaterialSystem_Dots.HideMaterialEntry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HideMaterialEntry_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(HideMaterialSystem_Dots.HideMaterialEntry other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HideMaterialSystem_Dots.HideMaterialEntry.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HideMaterialEntry_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101859, XrefRangeEnd = 1101863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HideMaterialSystem_Dots.HideMaterialEntry.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HideMaterialSystem_Dots.HideMaterialEntry.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static HideMaterialEntry()
      {
        Il2CppClassPointerStore<HideMaterialSystem_Dots.HideMaterialEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HideMaterialSystem_Dots>.NativeClassPtr, nameof (HideMaterialEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideMaterialSystem_Dots.HideMaterialEntry>.NativeClassPtr);
        HideMaterialSystem_Dots.HideMaterialEntry.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem_Dots.HideMaterialEntry>.NativeClassPtr, nameof (Entity));
        HideMaterialSystem_Dots.HideMaterialEntry.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialSystem_Dots.HideMaterialEntry>.NativeClassPtr, nameof (Importance));
        HideMaterialSystem_Dots.HideMaterialEntry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HideMaterialEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Dots.HideMaterialEntry>.NativeClassPtr, 100687456);
        HideMaterialSystem_Dots.HideMaterialEntry.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HideMaterialEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Dots.HideMaterialEntry>.NativeClassPtr, 100687457);
        HideMaterialSystem_Dots.HideMaterialEntry.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Dots.HideMaterialEntry>.NativeClassPtr, 100687458);
        HideMaterialSystem_Dots.HideMaterialEntry.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideMaterialSystem_Dots.HideMaterialEntry>.NativeClassPtr, 100687459);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HideMaterialSystem_Dots.HideMaterialEntry>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
