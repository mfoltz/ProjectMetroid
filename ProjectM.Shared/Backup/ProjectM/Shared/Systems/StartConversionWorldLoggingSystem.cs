// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.Systems.StartConversionWorldLoggingSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine;

#nullable disable
namespace ProjectM.Shared.Systems
{
  public class StartConversionWorldLoggingSystem : GameObjectConversionSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__HasBeenRun;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803563, XrefRangeEnd = 803590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StartConversionWorldLoggingSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StartConversionWorldLoggingSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartConversionWorldLoggingSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartConversionWorldLoggingSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StartConversionWorldLoggingSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StartConversionWorldLoggingSystem()
    {
      Il2CppClassPointerStore<StartConversionWorldLoggingSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared.Systems", nameof (StartConversionWorldLoggingSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartConversionWorldLoggingSystem>.NativeClassPtr);
      StartConversionWorldLoggingSystem.NativeFieldInfoPtr__HasBeenRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartConversionWorldLoggingSystem>.NativeClassPtr, nameof (_HasBeenRun));
      StartConversionWorldLoggingSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartConversionWorldLoggingSystem>.NativeClassPtr, 100670885);
      StartConversionWorldLoggingSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartConversionWorldLoggingSystem>.NativeClassPtr, 100670886);
      StartConversionWorldLoggingSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartConversionWorldLoggingSystem>.NativeClassPtr, 100670887);
    }

    public StartConversionWorldLoggingSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool _HasBeenRun
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartConversionWorldLoggingSystem.NativeFieldInfoPtr__HasBeenRun));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartConversionWorldLoggingSystem.NativeFieldInfoPtr__HasBeenRun)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Shared.Systems.StartConversionWorldLoggingSystem/<>c__DisplayClass1_0")]
    public sealed class __c__DisplayClass1_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hasLogged;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabCollectionConversionSystem;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Transform_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass1_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartConversionWorldLoggingSystem.__c__DisplayClass1_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartConversionWorldLoggingSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803545, XrefRangeEnd = 803563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Transform transform)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartConversionWorldLoggingSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass1_0()
      {
        Il2CppClassPointerStore<StartConversionWorldLoggingSystem.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartConversionWorldLoggingSystem>.NativeClassPtr, "<>c__DisplayClass1_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartConversionWorldLoggingSystem.__c__DisplayClass1_0>.NativeClassPtr);
        StartConversionWorldLoggingSystem.__c__DisplayClass1_0.NativeFieldInfoPtr_hasLogged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartConversionWorldLoggingSystem.__c__DisplayClass1_0>.NativeClassPtr, nameof (hasLogged));
        StartConversionWorldLoggingSystem.__c__DisplayClass1_0.NativeFieldInfoPtr_prefabCollectionConversionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartConversionWorldLoggingSystem.__c__DisplayClass1_0>.NativeClassPtr, nameof (prefabCollectionConversionSystem));
        StartConversionWorldLoggingSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartConversionWorldLoggingSystem.__c__DisplayClass1_0>.NativeClassPtr, 100670888);
        StartConversionWorldLoggingSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartConversionWorldLoggingSystem.__c__DisplayClass1_0>.NativeClassPtr, 100670889);
      }

      public __c__DisplayClass1_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe NativeArray<bool> hasLogged
      {
        get
        {
          return *(NativeArray<bool>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartConversionWorldLoggingSystem.__c__DisplayClass1_0.NativeFieldInfoPtr_hasLogged));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartConversionWorldLoggingSystem.__c__DisplayClass1_0.NativeFieldInfoPtr_hasLogged), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe PrefabCollectionConversionSystem prefabCollectionConversionSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartConversionWorldLoggingSystem.__c__DisplayClass1_0.NativeFieldInfoPtr_prefabCollectionConversionSystem));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionConversionSystem) null : new PrefabCollectionConversionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartConversionWorldLoggingSystem.__c__DisplayClass1_0.NativeFieldInfoPtr_prefabCollectionConversionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
