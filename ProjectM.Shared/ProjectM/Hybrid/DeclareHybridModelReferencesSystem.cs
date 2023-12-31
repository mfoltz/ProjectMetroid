// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.DeclareHybridModelReferencesSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Hybrid
{
  public class DeclareHybridModelReferencesSystem : GameObjectConversionSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TempList;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeclareHybridModelConversionDependencies_Public_Static_Void_Object_GameObject_ConvertOnDemandConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796894, XrefRangeEnd = 796922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DeclareHybridModelReferencesSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 796956, RefRangeEnd = 796959, XrefRangeStart = 796922, XrefRangeEnd = 796956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DeclareHybridModelConversionDependencies(
      UnityEngine.Object referenceOwner,
      GameObject referencedHybridModel,
      ConvertOnDemandConversionSystem convertOnDemandSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) referenceOwner);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) referencedHybridModel);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) convertOnDemandSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeclareHybridModelReferencesSystem.NativeMethodInfoPtr_DeclareHybridModelConversionDependencies_Public_Static_Void_Object_GameObject_ConvertOnDemandConversionSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DeclareHybridModelReferencesSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeclareHybridModelReferencesSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeclareHybridModelReferencesSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DeclareHybridModelReferencesSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DeclareHybridModelReferencesSystem()
    {
      Il2CppClassPointerStore<DeclareHybridModelReferencesSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Hybrid", nameof (DeclareHybridModelReferencesSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeclareHybridModelReferencesSystem>.NativeClassPtr);
      DeclareHybridModelReferencesSystem.NativeFieldInfoPtr__TempList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeclareHybridModelReferencesSystem>.NativeClassPtr, nameof (_TempList));
      DeclareHybridModelReferencesSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeclareHybridModelReferencesSystem>.NativeClassPtr, 100670320);
      DeclareHybridModelReferencesSystem.NativeMethodInfoPtr_DeclareHybridModelConversionDependencies_Public_Static_Void_Object_GameObject_ConvertOnDemandConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeclareHybridModelReferencesSystem>.NativeClassPtr, 100670321);
      DeclareHybridModelReferencesSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeclareHybridModelReferencesSystem>.NativeClassPtr, 100670322);
      DeclareHybridModelReferencesSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeclareHybridModelReferencesSystem>.NativeClassPtr, 100670324);
    }

    public DeclareHybridModelReferencesSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe List<IDeclareHybridModelDependencies> _TempList
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(DeclareHybridModelReferencesSystem.NativeFieldInfoPtr__TempList, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<IDeclareHybridModelDependencies>) null : new List<IDeclareHybridModelDependencies>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DeclareHybridModelReferencesSystem.NativeFieldInfoPtr__TempList, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.Hybrid.DeclareHybridModelReferencesSystem/<>c__DisplayClass0_0")]
    public sealed class __c__DisplayClass0_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_convertOnDemandSystem;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_UseHybridModelComponent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_FeaturesCollection_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeclareHybridModelReferencesSystem.__c__DisplayClass0_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeclareHybridModelReferencesSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796866, XrefRangeEnd = 796884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(UseHybridModelComponent component)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) component);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeclareHybridModelReferencesSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_UseHybridModelComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796884, XrefRangeEnd = 796894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(FeaturesCollection featureCollection)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) featureCollection);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeclareHybridModelReferencesSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_FeaturesCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<DeclareHybridModelReferencesSystem.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeclareHybridModelReferencesSystem>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeclareHybridModelReferencesSystem.__c__DisplayClass0_0>.NativeClassPtr);
        DeclareHybridModelReferencesSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_convertOnDemandSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeclareHybridModelReferencesSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (convertOnDemandSystem));
        DeclareHybridModelReferencesSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeclareHybridModelReferencesSystem.__c__DisplayClass0_0>.NativeClassPtr, 100670325);
        DeclareHybridModelReferencesSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_UseHybridModelComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeclareHybridModelReferencesSystem.__c__DisplayClass0_0>.NativeClassPtr, 100670326);
        DeclareHybridModelReferencesSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_FeaturesCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeclareHybridModelReferencesSystem.__c__DisplayClass0_0>.NativeClassPtr, 100670327);
      }

      public __c__DisplayClass0_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe ConvertOnDemandConversionSystem convertOnDemandSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeclareHybridModelReferencesSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_convertOnDemandSystem));
          return pointer == System.IntPtr.Zero ? (ConvertOnDemandConversionSystem) null : new ConvertOnDemandConversionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeclareHybridModelReferencesSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_convertOnDemandSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
