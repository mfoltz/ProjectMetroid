// Decompiled with JetBrains decompiler
// Type: ProjectM.BlueprintDestroySystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class BlueprintDestroySystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___BlueprintDismantleSequences_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___BlueprintDismantleSequences_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___BlueprintDestroySequences_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___BlueprintDestroySequences_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForBlueprintDismantleSequences_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForBlueprintDestroySequences_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989027, XrefRangeEnd = 989033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BlueprintDestroySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989033, XrefRangeEnd = 989102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BlueprintDestroySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlueprintDestroySystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlueprintDestroySystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989102, XrefRangeEnd = 989124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BlueprintDestroySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 989149, RefRangeEnd = 989150, XrefRangeStart = 989124, XrefRangeEnd = 989149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForBlueprintDismantleSequences_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.NativeMethodInfoPtr___GetEntityQuery_ForBlueprintDismantleSequences_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 989172, RefRangeEnd = 989173, XrefRangeStart = 989150, XrefRangeEnd = 989172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForBlueprintDestroySequences_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.NativeMethodInfoPtr___GetEntityQuery_ForBlueprintDestroySequences_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 989177, RefRangeEnd = 989178, XrefRangeStart = 989173, XrefRangeEnd = 989177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BlueprintDestroySystem()
    {
      Il2CppClassPointerStore<BlueprintDestroySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BlueprintDestroySystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlueprintDestroySystem>.NativeClassPtr);
      BlueprintDestroySystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      BlueprintDestroySystem.NativeFieldInfoPtr___BlueprintDismantleSequences_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem>.NativeClassPtr, "<>BlueprintDismantleSequences_entityQuery");
      BlueprintDestroySystem.NativeFieldInfoPtr___BlueprintDismantleSequences_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem>.NativeClassPtr, "<>BlueprintDismantleSequences_profilerMarker");
      BlueprintDestroySystem.NativeFieldInfoPtr___BlueprintDestroySequences_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem>.NativeClassPtr, "<>BlueprintDestroySequences_entityQuery");
      BlueprintDestroySystem.NativeFieldInfoPtr___BlueprintDestroySequences_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem>.NativeClassPtr, "<>BlueprintDestroySequences_profilerMarker");
      BlueprintDestroySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem>.NativeClassPtr, 100676286);
      BlueprintDestroySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem>.NativeClassPtr, 100676287);
      BlueprintDestroySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem>.NativeClassPtr, 100676288);
      BlueprintDestroySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem>.NativeClassPtr, 100676289);
      BlueprintDestroySystem.NativeMethodInfoPtr___GetEntityQuery_ForBlueprintDismantleSequences_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem>.NativeClassPtr, 100676290);
      BlueprintDestroySystem.NativeMethodInfoPtr___GetEntityQuery_ForBlueprintDestroySequences_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem>.NativeClassPtr, 100676291);
      BlueprintDestroySystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem>.NativeClassPtr, 100676292);
    }

    public BlueprintDestroySystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __BlueprintDismantleSequences_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.NativeFieldInfoPtr___BlueprintDismantleSequences_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.NativeFieldInfoPtr___BlueprintDismantleSequences_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __BlueprintDismantleSequences_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.NativeFieldInfoPtr___BlueprintDismantleSequences_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.NativeFieldInfoPtr___BlueprintDismantleSequences_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __BlueprintDestroySequences_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.NativeFieldInfoPtr___BlueprintDestroySequences_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.NativeFieldInfoPtr___BlueprintDestroySequences_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __BlueprintDestroySequences_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.NativeFieldInfoPtr___BlueprintDestroySequences_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.NativeFieldInfoPtr___BlueprintDestroySequences_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.BlueprintDestroySystem/<>c__DisplayClass2_0")]
    public sealed class __c__DisplayClass2_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_dismantleSequences;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DismantleDestroyData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_BlueprintData_byref_DismantleDestroyData_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass2_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, [In] ref DismantleDestroyData destroyData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref destroyData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DismantleDestroyData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        [In] ref BlueprintData blueprintData,
        [In] ref DismantleDestroyData destroyData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref blueprintData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref destroyData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_BlueprintData_byref_DismantleDestroyData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlueprintDestroySystem>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass2_0>.NativeClassPtr);
        BlueprintDestroySystem.__c__DisplayClass2_0.NativeFieldInfoPtr_dismantleSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (dismantleSequences));
        BlueprintDestroySystem.__c__DisplayClass2_0.NativeFieldInfoPtr_prefabMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (prefabMap));
        BlueprintDestroySystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
        BlueprintDestroySystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass2_0>.NativeClassPtr, 100676293);
        BlueprintDestroySystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DismantleDestroyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass2_0>.NativeClassPtr, 100676294);
        BlueprintDestroySystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_BlueprintData_byref_DismantleDestroyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass2_0>.NativeClassPtr, 100676295);
      }

      public __c__DisplayClass2_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass2_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass2_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass2_0>.NativeClassPtr, data));
      }

      public unsafe NativeList<Entity> dismantleSequences
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.__c__DisplayClass2_0.NativeFieldInfoPtr_dismantleSequences));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.__c__DisplayClass2_0.NativeFieldInfoPtr_dismantleSequences), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe PrefabLookupMap prefabMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.__c__DisplayClass2_0.NativeFieldInfoPtr_prefabMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.__c__DisplayClass2_0.NativeFieldInfoPtr_prefabMap)) = value;
        }
      }

      public unsafe BlueprintDestroySystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (BlueprintDestroySystem) null : new BlueprintDestroySystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.BlueprintDestroySystem/ProjectM.<>c__DisplayClass_BlueprintDismantleSequences")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_BlueprintDismantleSequences
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_dismantleSequences;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DismantleDestroyData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BlueprintDestroySystem_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeList<Entity> dismantleSequences;
      [FieldOffset(16)]
      public BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(56)]
      public unsafe BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988937, XrefRangeEnd = 988941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref DismantleDestroyData destroyData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref destroyData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DismantleDestroyData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref BlueprintDestroySystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref BlueprintDestroySystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988941, XrefRangeEnd = 988943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 988949, RefRangeEnd = 988950, XrefRangeStart = 988943, XrefRangeEnd = 988949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 988952, RefRangeEnd = 988953, XrefRangeStart = 988950, XrefRangeEnd = 988952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        BlueprintDestroySystem componentSystem,
        ref BlueprintDestroySystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BlueprintDestroySystem_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988953, XrefRangeEnd = 988957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988957, XrefRangeEnd = 988963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_BlueprintDismantleSequences()
      {
        Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlueprintDestroySystem>.NativeClassPtr, "<>c__DisplayClass_BlueprintDismantleSequences");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences>.NativeClassPtr);
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeFieldInfoPtr_dismantleSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences>.NativeClassPtr, nameof (dismantleSequences));
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences>.NativeClassPtr, nameof (_runtimes));
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DismantleDestroyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences>.NativeClassPtr, 100676296);
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences>.NativeClassPtr, 100676297);
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences>.NativeClassPtr, 100676298);
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences>.NativeClassPtr, 100676299);
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences>.NativeClassPtr, 100676300);
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BlueprintDestroySystem_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences>.NativeClassPtr, 100676301);
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences>.NativeClassPtr, 100676302);
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences>.NativeClassPtr, 100676303);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_destroyData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BlueprintDestroySystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<DismantleDestroyData> forParameter_destroyData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 988856, RefRangeEnd = 988857, XrefRangeStart = 988852, XrefRangeEnd = 988856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(BlueprintDestroySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BlueprintDestroySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 988861, RefRangeEnd = 988862, XrefRangeStart = 988857, XrefRangeEnd = 988861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_destroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_destroyData));
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BlueprintDestroySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders>.NativeClassPtr, 100676304);
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders>.NativeClassPtr, 100676305);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_destroyData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<DismantleDestroyData>.Runtime runtime_destroyData;

          static Runtimes()
          {
            Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_destroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_destroyData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.BlueprintDestroySystem/ProjectM.<>c__DisplayClass_BlueprintDismantleSequences/ProjectM.RunWithoutJobSystem_000031C5$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences>.NativeClassPtr, "RunWithoutJobSystem_000031C5$PostfixBurstDelegate");
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100676306);
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100676307);
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100676308);
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100676309);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.BlueprintDestroySystem/ProjectM.<>c__DisplayClass_BlueprintDismantleSequences/ProjectM.RunWithoutJobSystem_000031C5$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988862, XrefRangeEnd = 988876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988876, XrefRangeEnd = 988894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988894, XrefRangeEnd = 988909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 988936, RefRangeEnd = 988937, XrefRangeStart = 988909, XrefRangeEnd = 988936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences>.NativeClassPtr, "RunWithoutJobSystem_000031C5$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676310);
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676311);
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676312);
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676313);
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100676315);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BlueprintDestroySystem.__c__DisplayClass_BlueprintDismantleSequences.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.BlueprintDestroySystem/ProjectM.<>c__DisplayClass_BlueprintDestroySequences")]
    public sealed class __c__DisplayClass_BlueprintDestroySequences : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_BlueprintData_byref_DismantleDestroyData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BlueprintDestroySystem_byref___c__DisplayClass2_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 988991, RefRangeEnd = 988992, XrefRangeStart = 988979, XrefRangeEnd = 988991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref BlueprintData blueprintData,
        [In] ref DismantleDestroyData destroyData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref blueprintData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref destroyData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_BlueprintData_byref_DismantleDestroyData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988992, XrefRangeEnd = 988993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref BlueprintDestroySystem.__c__DisplayClass2_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 989003, RefRangeEnd = 989004, XrefRangeStart = 988993, XrefRangeEnd = 989003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref BlueprintDestroySystem.__c__DisplayClass2_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989004, XrefRangeEnd = 989018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 989024, RefRangeEnd = 989025, XrefRangeStart = 989018, XrefRangeEnd = 989024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 989026, RefRangeEnd = 989027, XrefRangeStart = 989025, XrefRangeEnd = 989026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        BlueprintDestroySystem componentSystem,
        ref BlueprintDestroySystem.__c__DisplayClass2_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BlueprintDestroySystem_byref___c__DisplayClass2_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_BlueprintDestroySequences()
      {
        Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlueprintDestroySystem>.NativeClassPtr, "<>c__DisplayClass_BlueprintDestroySequences");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences>.NativeClassPtr);
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeFieldInfoPtr_prefabMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences>.NativeClassPtr, nameof (prefabMap));
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences>.NativeClassPtr, "<>4__this");
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences>.NativeClassPtr, nameof (_runtimes));
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences>.NativeClassPtr, nameof (_performLambdaDelegate));
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_BlueprintData_byref_DismantleDestroyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences>.NativeClassPtr, 100676316);
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences>.NativeClassPtr, 100676317);
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences>.NativeClassPtr, 100676318);
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences>.NativeClassPtr, 100676320);
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences>.NativeClassPtr, 100676321);
        BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BlueprintDestroySystem_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences>.NativeClassPtr, 100676322);
      }

      public __c__DisplayClass_BlueprintDestroySequences(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_BlueprintDestroySequences()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences>.NativeClassPtr, data));
      }

      public unsafe PrefabLookupMap prefabMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeFieldInfoPtr_prefabMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeFieldInfoPtr_prefabMap)) = value;
        }
      }

      public unsafe BlueprintDestroySystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (BlueprintDestroySystem) null : new BlueprintDestroySystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_blueprintData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_destroyData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BlueprintDestroySystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<BlueprintData> forParameter_blueprintData;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<DismantleDestroyData> forParameter_destroyData;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988963, XrefRangeEnd = 988970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(BlueprintDestroySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BlueprintDestroySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 988978, RefRangeEnd = 988979, XrefRangeStart = 988970, XrefRangeEnd = 988978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_blueprintData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_blueprintData));
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_destroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_destroyData));
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BlueprintDestroySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders>.NativeClassPtr, 100676323);
          BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders>.NativeClassPtr, 100676324);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_blueprintData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_destroyData;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<BlueprintData>.StructuralChangeRuntime runtime_blueprintData;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<DismantleDestroyData>.StructuralChangeRuntime runtime_destroyData;

          static Runtimes()
          {
            Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_blueprintData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_blueprintData));
            BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_destroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_destroyData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlueprintDestroySystem.__c__DisplayClass_BlueprintDestroySequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
