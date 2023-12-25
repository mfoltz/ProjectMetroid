// Decompiled with JetBrains decompiler
// Type: ProjectM.TheMonsterGeneratorBuffSystem_Spawn
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class TheMonsterGeneratorBuffSystem_Spawn : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__BuffQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindGenerator_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindGenerator_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetGenerator_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetGenerator_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForFindGenerator_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSetGenerator_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TheMonsterGeneratorBuffSystem_Spawn.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383098, XrefRangeEnd = 1383133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TheMonsterGeneratorBuffSystem_Spawn.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TheMonsterGeneratorBuffSystem_Spawn()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383133, XrefRangeEnd = 1383200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TheMonsterGeneratorBuffSystem_Spawn.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383200, XrefRangeEnd = 1383216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForFindGenerator_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.NativeMethodInfoPtr___GetEntityQuery_ForFindGenerator_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383216, XrefRangeEnd = 1383235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSetGenerator_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.NativeMethodInfoPtr___GetEntityQuery_ForSetGenerator_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1383239, RefRangeEnd = 1383240, XrefRangeStart = 1383235, XrefRangeEnd = 1383239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1383244, RefRangeEnd = 1383245, XrefRangeStart = 1383240, XrefRangeEnd = 1383244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TheMonsterGeneratorBuffSystem_Spawn()
    {
      Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (TheMonsterGeneratorBuffSystem_Spawn));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn>.NativeClassPtr);
      TheMonsterGeneratorBuffSystem_Spawn.NativeFieldInfoPtr__BuffQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn>.NativeClassPtr, nameof (_BuffQuery));
      TheMonsterGeneratorBuffSystem_Spawn.NativeFieldInfoPtr___FindGenerator_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn>.NativeClassPtr, "<>FindGenerator_entityQuery");
      TheMonsterGeneratorBuffSystem_Spawn.NativeFieldInfoPtr___FindGenerator_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn>.NativeClassPtr, "<>FindGenerator_profilerMarker");
      TheMonsterGeneratorBuffSystem_Spawn.NativeFieldInfoPtr___SetGenerator_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn>.NativeClassPtr, "<>SetGenerator_entityQuery");
      TheMonsterGeneratorBuffSystem_Spawn.NativeFieldInfoPtr___SetGenerator_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn>.NativeClassPtr, "<>SetGenerator_profilerMarker");
      TheMonsterGeneratorBuffSystem_Spawn.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn>.NativeClassPtr, 100665651);
      TheMonsterGeneratorBuffSystem_Spawn.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn>.NativeClassPtr, 100665652);
      TheMonsterGeneratorBuffSystem_Spawn.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn>.NativeClassPtr, 100665653);
      TheMonsterGeneratorBuffSystem_Spawn.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn>.NativeClassPtr, 100665654);
      TheMonsterGeneratorBuffSystem_Spawn.NativeMethodInfoPtr___GetEntityQuery_ForFindGenerator_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn>.NativeClassPtr, 100665655);
      TheMonsterGeneratorBuffSystem_Spawn.NativeMethodInfoPtr___GetEntityQuery_ForSetGenerator_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn>.NativeClassPtr, 100665656);
      TheMonsterGeneratorBuffSystem_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn>.NativeClassPtr, 100665657);
      TheMonsterGeneratorBuffSystem_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn>.NativeClassPtr, 100665658);
    }

    public TheMonsterGeneratorBuffSystem_Spawn(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _BuffQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TheMonsterGeneratorBuffSystem_Spawn.NativeFieldInfoPtr__BuffQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TheMonsterGeneratorBuffSystem_Spawn.NativeFieldInfoPtr__BuffQuery)) = value;
      }
    }

    public unsafe EntityQuery __FindGenerator_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TheMonsterGeneratorBuffSystem_Spawn.NativeFieldInfoPtr___FindGenerator_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TheMonsterGeneratorBuffSystem_Spawn.NativeFieldInfoPtr___FindGenerator_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __FindGenerator_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TheMonsterGeneratorBuffSystem_Spawn.NativeFieldInfoPtr___FindGenerator_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TheMonsterGeneratorBuffSystem_Spawn.NativeFieldInfoPtr___FindGenerator_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __SetGenerator_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TheMonsterGeneratorBuffSystem_Spawn.NativeFieldInfoPtr___SetGenerator_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TheMonsterGeneratorBuffSystem_Spawn.NativeFieldInfoPtr___SetGenerator_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SetGenerator_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TheMonsterGeneratorBuffSystem_Spawn.NativeFieldInfoPtr___SetGenerator_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TheMonsterGeneratorBuffSystem_Spawn.NativeFieldInfoPtr___SetGenerator_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.TheMonsterGeneratorBuffSystem_Spawn/<>c__DisplayClass2_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass2_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_generatorEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_AiPointOfInterest_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_TheMonsterGeneratorActiveBuff_0;
      [FieldOffset(0)]
      public Entity generatorEntity;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, [In] ref AiPointOfInterest aiPointOfInterest)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiPointOfInterest;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_AiPointOfInterest_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        ref TheMonsterGeneratorActiveBuff generatorBuff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref generatorBuff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_TheMonsterGeneratorActiveBuff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0>.NativeClassPtr);
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0.NativeFieldInfoPtr_generatorEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0>.NativeClassPtr, nameof (generatorEntity));
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0>.NativeClassPtr, 100665659);
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_AiPointOfInterest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0>.NativeClassPtr, 100665660);
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_TheMonsterGeneratorActiveBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0>.NativeClassPtr, 100665661);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.TheMonsterGeneratorBuffSystem_Spawn/ProjectM.<>c__DisplayClass_FindGenerator")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_FindGenerator
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_generatorEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AiPointOfInterest_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TheMonsterGeneratorBuffSystem_Spawn_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public Entity generatorEntity;
      [FieldOffset(8)]
      public TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(48)]
      public unsafe TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1382968, RefRangeEnd = 1382969, XrefRangeStart = 1382968, XrefRangeEnd = 1382968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref AiPointOfInterest aiPointOfInterest)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiPointOfInterest;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AiPointOfInterest_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(46)]
      [CachedScanResults(RefRangeStart = 927059, RefRangeEnd = 927105, XrefRangeStart = 927059, XrefRangeEnd = 927105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(47)]
      [CachedScanResults(RefRangeStart = 927105, RefRangeEnd = 927152, XrefRangeStart = 927105, XrefRangeEnd = 927152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382969, XrefRangeEnd = 1382971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1382977, RefRangeEnd = 1382978, XrefRangeStart = 1382971, XrefRangeEnd = 1382977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1382980, RefRangeEnd = 1382981, XrefRangeStart = 1382978, XrefRangeEnd = 1382980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        TheMonsterGeneratorBuffSystem_Spawn componentSystem,
        ref TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TheMonsterGeneratorBuffSystem_Spawn_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382981, XrefRangeEnd = 1382985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382985, XrefRangeEnd = 1382991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_FindGenerator()
      {
        Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn>.NativeClassPtr, "<>c__DisplayClass_FindGenerator");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator>.NativeClassPtr);
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeFieldInfoPtr_generatorEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator>.NativeClassPtr, nameof (generatorEntity));
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator>.NativeClassPtr, nameof (_runtimes));
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AiPointOfInterest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator>.NativeClassPtr, 100665662);
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator>.NativeClassPtr, 100665663);
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator>.NativeClassPtr, 100665664);
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator>.NativeClassPtr, 100665665);
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator>.NativeClassPtr, 100665666);
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TheMonsterGeneratorBuffSystem_Spawn_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator>.NativeClassPtr, 100665667);
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator>.NativeClassPtr, 100665668);
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator>.NativeClassPtr, 100665669);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aiPointOfInterest;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TheMonsterGeneratorBuffSystem_Spawn_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<AiPointOfInterest> forParameter_aiPointOfInterest;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1382887, RefRangeEnd = 1382888, XrefRangeStart = 1382883, XrefRangeEnd = 1382887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          TheMonsterGeneratorBuffSystem_Spawn componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TheMonsterGeneratorBuffSystem_Spawn_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1382892, RefRangeEnd = 1382893, XrefRangeStart = 1382888, XrefRangeEnd = 1382892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aiPointOfInterest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aiPointOfInterest));
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TheMonsterGeneratorBuffSystem_Spawn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders>.NativeClassPtr, 100665670);
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders>.NativeClassPtr, 100665671);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aiPointOfInterest;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<AiPointOfInterest>.Runtime runtime_aiPointOfInterest;

          static Runtimes()
          {
            Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aiPointOfInterest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aiPointOfInterest));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.TheMonsterGeneratorBuffSystem_Spawn/ProjectM.<>c__DisplayClass_FindGenerator/ProjectM.RunWithoutJobSystem_00000576$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator>.NativeClassPtr, "RunWithoutJobSystem_00000576$PostfixBurstDelegate");
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665672);
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665673);
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665674);
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665675);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.TheMonsterGeneratorBuffSystem_Spawn/ProjectM.<>c__DisplayClass_FindGenerator/ProjectM.RunWithoutJobSystem_00000576$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382893, XrefRangeEnd = 1382907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382907, XrefRangeEnd = 1382925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382925, XrefRangeEnd = 1382940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1382967, RefRangeEnd = 1382968, XrefRangeStart = 1382940, XrefRangeEnd = 1382967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator>.NativeClassPtr, "RunWithoutJobSystem_00000576$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665676);
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665677);
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665678);
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665679);
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665681);
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
            IL2CPP.il2cpp_field_static_get_value(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_FindGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.TheMonsterGeneratorBuffSystem_Spawn/ProjectM.<>c__DisplayClass_SetGenerator")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SetGenerator
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_generatorEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_TheMonsterGeneratorActiveBuff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TheMonsterGeneratorBuffSystem_Spawn_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public Entity generatorEntity;
      [FieldOffset(8)]
      public TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(48)]
      public unsafe TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1310112, RefRangeEnd = 1310114, XrefRangeStart = 1310112, XrefRangeEnd = 1310114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref TheMonsterGeneratorActiveBuff generatorBuff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref generatorBuff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_TheMonsterGeneratorActiveBuff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(46)]
      [CachedScanResults(RefRangeStart = 927059, RefRangeEnd = 927105, XrefRangeStart = 927059, XrefRangeEnd = 927105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(47)]
      [CachedScanResults(RefRangeStart = 927105, RefRangeEnd = 927152, XrefRangeStart = 927105, XrefRangeEnd = 927152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383076, XrefRangeEnd = 1383078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1383084, RefRangeEnd = 1383085, XrefRangeStart = 1383078, XrefRangeEnd = 1383084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1383087, RefRangeEnd = 1383088, XrefRangeStart = 1383085, XrefRangeEnd = 1383087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        TheMonsterGeneratorBuffSystem_Spawn componentSystem,
        ref TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TheMonsterGeneratorBuffSystem_Spawn_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383088, XrefRangeEnd = 1383092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383092, XrefRangeEnd = 1383098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SetGenerator()
      {
        Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn>.NativeClassPtr, "<>c__DisplayClass_SetGenerator");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator>.NativeClassPtr);
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeFieldInfoPtr_generatorEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator>.NativeClassPtr, nameof (generatorEntity));
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator>.NativeClassPtr, nameof (_runtimes));
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_TheMonsterGeneratorActiveBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator>.NativeClassPtr, 100665682);
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator>.NativeClassPtr, 100665683);
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator>.NativeClassPtr, 100665684);
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator>.NativeClassPtr, 100665685);
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator>.NativeClassPtr, 100665686);
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TheMonsterGeneratorBuffSystem_Spawn_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator>.NativeClassPtr, 100665687);
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator>.NativeClassPtr, 100665688);
        TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator>.NativeClassPtr, 100665689);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_generatorBuff;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TheMonsterGeneratorBuffSystem_Spawn_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<TheMonsterGeneratorActiveBuff> forParameter_generatorBuff;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1382995, RefRangeEnd = 1382996, XrefRangeStart = 1382991, XrefRangeEnd = 1382995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          TheMonsterGeneratorBuffSystem_Spawn componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TheMonsterGeneratorBuffSystem_Spawn_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1383000, RefRangeEnd = 1383001, XrefRangeStart = 1382996, XrefRangeEnd = 1383000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_generatorBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_generatorBuff));
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TheMonsterGeneratorBuffSystem_Spawn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders>.NativeClassPtr, 100665690);
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders>.NativeClassPtr, 100665691);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_generatorBuff;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<TheMonsterGeneratorActiveBuff>.Runtime runtime_generatorBuff;

          static Runtimes()
          {
            Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_generatorBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_generatorBuff));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.TheMonsterGeneratorBuffSystem_Spawn/ProjectM.<>c__DisplayClass_SetGenerator/ProjectM.RunWithoutJobSystem_0000057F$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator>.NativeClassPtr, "RunWithoutJobSystem_0000057F$PostfixBurstDelegate");
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665692);
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665693);
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665694);
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665695);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.TheMonsterGeneratorBuffSystem_Spawn/ProjectM.<>c__DisplayClass_SetGenerator/ProjectM.RunWithoutJobSystem_0000057F$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383001, XrefRangeEnd = 1383015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383015, XrefRangeEnd = 1383033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383033, XrefRangeEnd = 1383048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1383075, RefRangeEnd = 1383076, XrefRangeStart = 1383048, XrefRangeEnd = 1383075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator>.NativeClassPtr, "RunWithoutJobSystem_0000057F$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665696);
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665697);
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665698);
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665699);
          TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665701);
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
            IL2CPP.il2cpp_field_static_get_value(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TheMonsterGeneratorBuffSystem_Spawn.__c__DisplayClass_SetGenerator.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
