// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CharacterHudProgressBarSystem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Entities.UniversalDelegates;
using Unity.Profiling;

#nullable disable
namespace ProjectM.UI
{
  public class CharacterHudProgressBarSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___ClearCharacterHudProgressBarData_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ClearCharacterHudProgressBarData_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateCharacterHudProgressBarData_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateCharacterHudProgressBarData_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PassesFilterRequirements_Private_Static_Boolean_EntityManager_byref_LocalUserData_byref_UseCharacterHudProgressBar_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForClearCharacterHudProgressBarData_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateCharacterHudProgressBarData_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219896, XrefRangeEnd = 1219902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterHudProgressBarSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219902, XrefRangeEnd = 1219933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterHudProgressBarSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1219946, RefRangeEnd = 1219947, XrefRangeStart = 1219933, XrefRangeEnd = 1219946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool PassesFilterRequirements(
      EntityManager entityManager,
      [In] ref CommonClientDataSystem.LocalUserData localUserData,
      [In] ref UseCharacterHudProgressBar useCharacterHudProgressBar)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref localUserData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref useCharacterHudProgressBar;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.NativeMethodInfoPtr_PassesFilterRequirements_Private_Static_Boolean_EntityManager_byref_LocalUserData_byref_UseCharacterHudProgressBar_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharacterHudProgressBarSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219947, XrefRangeEnd = 1219996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterHudProgressBarSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219996, XrefRangeEnd = 1220012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForClearCharacterHudProgressBarData_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.NativeMethodInfoPtr___GetEntityQuery_ForClearCharacterHudProgressBarData_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1220043, RefRangeEnd = 1220044, XrefRangeStart = 1220012, XrefRangeEnd = 1220043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateCharacterHudProgressBarData_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateCharacterHudProgressBarData_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1220048, RefRangeEnd = 1220049, XrefRangeStart = 1220044, XrefRangeEnd = 1220048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1220053, RefRangeEnd = 1220054, XrefRangeStart = 1220049, XrefRangeEnd = 1220053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharacterHudProgressBarSystem()
    {
      Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (CharacterHudProgressBarSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr);
      CharacterHudProgressBarSystem.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr, nameof (_CommonClientDataSystem));
      CharacterHudProgressBarSystem.NativeFieldInfoPtr___ClearCharacterHudProgressBarData_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr, "<>ClearCharacterHudProgressBarData_entityQuery");
      CharacterHudProgressBarSystem.NativeFieldInfoPtr___ClearCharacterHudProgressBarData_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr, "<>ClearCharacterHudProgressBarData_profilerMarker");
      CharacterHudProgressBarSystem.NativeFieldInfoPtr___UpdateCharacterHudProgressBarData_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr, "<>UpdateCharacterHudProgressBarData_entityQuery");
      CharacterHudProgressBarSystem.NativeFieldInfoPtr___UpdateCharacterHudProgressBarData_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr, "<>UpdateCharacterHudProgressBarData_profilerMarker");
      CharacterHudProgressBarSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr, 100664519);
      CharacterHudProgressBarSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr, 100664520);
      CharacterHudProgressBarSystem.NativeMethodInfoPtr_PassesFilterRequirements_Private_Static_Boolean_EntityManager_byref_LocalUserData_byref_UseCharacterHudProgressBar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr, 100664521);
      CharacterHudProgressBarSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr, 100664522);
      CharacterHudProgressBarSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr, 100664523);
      CharacterHudProgressBarSystem.NativeMethodInfoPtr___GetEntityQuery_ForClearCharacterHudProgressBarData_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr, 100664524);
      CharacterHudProgressBarSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateCharacterHudProgressBarData_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr, 100664525);
      CharacterHudProgressBarSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr, 100664526);
      CharacterHudProgressBarSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr, 100664527);
    }

    public CharacterHudProgressBarSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHudProgressBarSystem.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHudProgressBarSystem.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __ClearCharacterHudProgressBarData_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHudProgressBarSystem.NativeFieldInfoPtr___ClearCharacterHudProgressBarData_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHudProgressBarSystem.NativeFieldInfoPtr___ClearCharacterHudProgressBarData_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ClearCharacterHudProgressBarData_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHudProgressBarSystem.NativeFieldInfoPtr___ClearCharacterHudProgressBarData_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHudProgressBarSystem.NativeFieldInfoPtr___ClearCharacterHudProgressBarData_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateCharacterHudProgressBarData_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHudProgressBarSystem.NativeFieldInfoPtr___UpdateCharacterHudProgressBarData_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHudProgressBarSystem.NativeFieldInfoPtr___UpdateCharacterHudProgressBarData_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateCharacterHudProgressBarData_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHudProgressBarSystem.NativeFieldInfoPtr___UpdateCharacterHudProgressBarData_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHudProgressBarSystem.NativeFieldInfoPtr___UpdateCharacterHudProgressBarData_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.CharacterHudProgressBarSystem/<>c__DisplayClass2_0")]
    public sealed class __c__DisplayClass2_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserData;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_UseCharacterHudProgressBar_byref_LifeTime_byref_Age_byref_Buff_byref_EntityCreator_byref_EntityOwner_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass2_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        ref UseCharacterHudProgressBar useCharacterHudProgressBar,
        [In] ref LifeTime lifeTime,
        [In] ref Age age,
        [In] ref Buff buff,
        [In] ref EntityCreator entityCreator,
        [In] ref EntityOwner entityOwner)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) ref useCharacterHudProgressBar;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lifeTime;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref age;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityCreator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_UseCharacterHudProgressBar_byref_LifeTime_byref_Age_byref_Buff_byref_EntityCreator_byref_EntityOwner_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass2_0>.NativeClassPtr);
        CharacterHudProgressBarSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (entityManager));
        CharacterHudProgressBarSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_localUserData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (localUserData));
        CharacterHudProgressBarSystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
        CharacterHudProgressBarSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass2_0>.NativeClassPtr, 100664528);
        CharacterHudProgressBarSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_UseCharacterHudProgressBar_byref_LifeTime_byref_Age_byref_Buff_byref_EntityCreator_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass2_0>.NativeClassPtr, 100664529);
      }

      public __c__DisplayClass2_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass2_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass2_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass2_0>.NativeClassPtr, data));
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHudProgressBarSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHudProgressBarSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe CommonClientDataSystem.LocalUserData localUserData
      {
        get
        {
          return *(CommonClientDataSystem.LocalUserData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHudProgressBarSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_localUserData));
        }
        [param: In] set
        {
          *(CommonClientDataSystem.LocalUserData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHudProgressBarSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_localUserData)) = value;
        }
      }

      public unsafe CharacterHudProgressBarSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHudProgressBarSystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (CharacterHudProgressBarSystem) null : new CharacterHudProgressBarSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHudProgressBarSystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.CharacterHudProgressBarSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_0_Internal_Void_Entity_byref_CharacterHudProgressBar_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2_0(
        Entity entity,
        ref CharacterHudProgressBar characterHudProgressBar)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref characterHudProgressBar;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c.NativeMethodInfoPtr__OnUpdate_b__2_0_Internal_Void_Entity_byref_CharacterHudProgressBar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c>.NativeClassPtr);
        CharacterHudProgressBarSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c>.NativeClassPtr, "<>9");
        CharacterHudProgressBarSystem.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c>.NativeClassPtr, "<>9__2_0");
        CharacterHudProgressBarSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c>.NativeClassPtr, 100664531);
        CharacterHudProgressBarSystem.__c.NativeMethodInfoPtr__OnUpdate_b__2_0_Internal_Void_Entity_byref_CharacterHudProgressBar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c>.NativeClassPtr, 100664532);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe CharacterHudProgressBarSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CharacterHudProgressBarSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (CharacterHudProgressBarSystem.__c) null : new CharacterHudProgressBarSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CharacterHudProgressBarSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe VR<Entity, CharacterHudProgressBar> __9__2_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CharacterHudProgressBarSystem.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (VR<Entity, CharacterHudProgressBar>) null : new VR<Entity, CharacterHudProgressBar>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CharacterHudProgressBarSystem.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.CharacterHudProgressBarSystem/ProjectM.UI.<>c__DisplayClass_ClearCharacterHudProgressBarData")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ClearCharacterHudProgressBarData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CharacterHudProgressBar_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CharacterHudProgressBarSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(40)]
      public unsafe CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1219701, RefRangeEnd = 1219702, XrefRangeStart = 1219691, XrefRangeEnd = 1219701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref CharacterHudProgressBar characterHudProgressBar)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref characterHudProgressBar;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CharacterHudProgressBar_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219702, XrefRangeEnd = 1219704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1219710, RefRangeEnd = 1219711, XrefRangeStart = 1219704, XrefRangeEnd = 1219710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1219712, RefRangeEnd = 1219713, XrefRangeStart = 1219711, XrefRangeEnd = 1219712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(CharacterHudProgressBarSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CharacterHudProgressBarSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219713, XrefRangeEnd = 1219717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219717, XrefRangeEnd = 1219723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ClearCharacterHudProgressBarData()
      {
        Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr, "<>c__DisplayClass_ClearCharacterHudProgressBarData");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData>.NativeClassPtr);
        CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData>.NativeClassPtr, nameof (_runtimes));
        CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CharacterHudProgressBar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData>.NativeClassPtr, 100664533);
        CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData>.NativeClassPtr, 100664534);
        CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData>.NativeClassPtr, 100664535);
        CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CharacterHudProgressBarSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData>.NativeClassPtr, 100664536);
        CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData>.NativeClassPtr, 100664537);
        CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData>.NativeClassPtr, 100664538);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_characterHudProgressBar;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CharacterHudProgressBarSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<CharacterHudProgressBar> forParameter_characterHudProgressBar;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1219610, RefRangeEnd = 1219611, XrefRangeStart = 1219606, XrefRangeEnd = 1219610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CharacterHudProgressBarSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CharacterHudProgressBarSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1219615, RefRangeEnd = 1219616, XrefRangeStart = 1219611, XrefRangeEnd = 1219615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_characterHudProgressBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_characterHudProgressBar));
          CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CharacterHudProgressBarSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders>.NativeClassPtr, 100664539);
          CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders>.NativeClassPtr, 100664540);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_characterHudProgressBar;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<CharacterHudProgressBar>.Runtime runtime_characterHudProgressBar;

          static Runtimes()
          {
            Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_characterHudProgressBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_characterHudProgressBar));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UI.CharacterHudProgressBarSystem/ProjectM.UI.<>c__DisplayClass_ClearCharacterHudProgressBarData/ProjectM.UI.RunWithoutJobSystem_00000417$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData>.NativeClassPtr, "RunWithoutJobSystem_00000417$PostfixBurstDelegate");
          CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664541);
          CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664542);
          CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664543);
          CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664544);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.CharacterHudProgressBarSystem/ProjectM.UI.<>c__DisplayClass_ClearCharacterHudProgressBarData/ProjectM.UI.RunWithoutJobSystem_00000417$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219616, XrefRangeEnd = 1219630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219630, XrefRangeEnd = 1219648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219648, XrefRangeEnd = 1219663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1219690, RefRangeEnd = 1219691, XrefRangeStart = 1219663, XrefRangeEnd = 1219690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData>.NativeClassPtr, "RunWithoutJobSystem_00000417$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664545);
          CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664546);
          CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664547);
          CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664548);
          CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664550);
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
            IL2CPP.il2cpp_field_static_get_value(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CharacterHudProgressBarSystem.__c__DisplayClass_ClearCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.CharacterHudProgressBarSystem/ProjectM.UI.<>c__DisplayClass_UpdateCharacterHudProgressBarData")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateCharacterHudProgressBarData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserData;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_CharacterHudProgressBar_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_UseCharacterHudProgressBar_byref_LifeTime_byref_Age_byref_Buff_byref_EntityCreator_byref_EntityOwner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CharacterHudProgressBarSystem_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public CommonClientDataSystem.LocalUserData localUserData;
      [FieldOffset(264)]
      public ComponentDataFromEntity<CharacterHudProgressBar> _ComponentDataFromEntity_CharacterHudProgressBar_0;
      [FieldOffset(296)]
      public CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(488)]
      public unsafe CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219836, XrefRangeEnd = 1219855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref UseCharacterHudProgressBar useCharacterHudProgressBar,
        [In] ref LifeTime lifeTime,
        [In] ref Age age,
        [In] ref Buff buff,
        [In] ref EntityCreator entityCreator,
        [In] ref EntityOwner entityOwner)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) ref useCharacterHudProgressBar;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lifeTime;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref age;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityCreator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_UseCharacterHudProgressBar_byref_LifeTime_byref_Age_byref_Buff_byref_EntityCreator_byref_EntityOwner_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1219855, RefRangeEnd = 1219856, XrefRangeStart = 1219855, XrefRangeEnd = 1219855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CharacterHudProgressBarSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1219856, RefRangeEnd = 1219857, XrefRangeStart = 1219856, XrefRangeEnd = 1219856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CharacterHudProgressBarSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219857, XrefRangeEnd = 1219859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1219879, RefRangeEnd = 1219880, XrefRangeStart = 1219859, XrefRangeEnd = 1219879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1219885, RefRangeEnd = 1219886, XrefRangeStart = 1219880, XrefRangeEnd = 1219885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CharacterHudProgressBarSystem componentSystem,
        ref CharacterHudProgressBarSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CharacterHudProgressBarSystem_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219886, XrefRangeEnd = 1219890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219890, XrefRangeEnd = 1219896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateCharacterHudProgressBarData()
      {
        Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHudProgressBarSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateCharacterHudProgressBarData");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr);
        CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr, nameof (entityManager));
        CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeFieldInfoPtr_localUserData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr, nameof (localUserData));
        CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeFieldInfoPtr__ComponentDataFromEntity_CharacterHudProgressBar_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr, nameof (_ComponentDataFromEntity_CharacterHudProgressBar_0));
        CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr, nameof (_runtimes));
        CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_UseCharacterHudProgressBar_byref_LifeTime_byref_Age_byref_Buff_byref_EntityCreator_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr, 100664551);
        CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr, 100664552);
        CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr, 100664553);
        CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr, 100664554);
        CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr, 100664555);
        CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CharacterHudProgressBarSystem_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr, 100664556);
        CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr, 100664557);
        CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr, 100664558);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_useCharacterHudProgressBar;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_lifeTime;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_age;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entityCreator;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entityOwner;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CharacterHudProgressBarSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<UseCharacterHudProgressBar> forParameter_useCharacterHudProgressBar;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<LifeTime> forParameter_lifeTime;
        [FieldOffset(64)]
        public LambdaParameterValueProvider_IComponentData<Age> forParameter_age;
        [FieldOffset(96)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(128)]
        public LambdaParameterValueProvider_IComponentData<EntityCreator> forParameter_entityCreator;
        [FieldOffset(160)]
        public LambdaParameterValueProvider_IComponentData<EntityOwner> forParameter_entityOwner;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1219741, RefRangeEnd = 1219742, XrefRangeStart = 1219723, XrefRangeEnd = 1219741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CharacterHudProgressBarSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CharacterHudProgressBarSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1219760, RefRangeEnd = 1219761, XrefRangeStart = 1219742, XrefRangeEnd = 1219760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_useCharacterHudProgressBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_useCharacterHudProgressBar));
          CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_lifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_lifeTime));
          CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_age));
          CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entityCreator));
          CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entityOwner));
          CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CharacterHudProgressBarSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders>.NativeClassPtr, 100664559);
          CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders>.NativeClassPtr, 100664560);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_useCharacterHudProgressBar;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_lifeTime;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_age;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entityCreator;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entityOwner;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<UseCharacterHudProgressBar>.Runtime runtime_useCharacterHudProgressBar;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<LifeTime>.Runtime runtime_lifeTime;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Age>.Runtime runtime_age;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<EntityCreator>.Runtime runtime_entityCreator;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<EntityOwner>.Runtime runtime_entityOwner;

          static Runtimes()
          {
            Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_useCharacterHudProgressBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_useCharacterHudProgressBar));
            CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_lifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_lifeTime));
            CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_age));
            CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entityCreator));
            CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entityOwner));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UI.CharacterHudProgressBarSystem/ProjectM.UI.<>c__DisplayClass_UpdateCharacterHudProgressBarData/ProjectM.UI.RunWithoutJobSystem_00000420$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr, "RunWithoutJobSystem_00000420$PostfixBurstDelegate");
          CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664561);
          CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664562);
          CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664563);
          CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664564);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.CharacterHudProgressBarSystem/ProjectM.UI.<>c__DisplayClass_UpdateCharacterHudProgressBarData/ProjectM.UI.RunWithoutJobSystem_00000420$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219761, XrefRangeEnd = 1219775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219775, XrefRangeEnd = 1219793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219793, XrefRangeEnd = 1219808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1219835, RefRangeEnd = 1219836, XrefRangeStart = 1219808, XrefRangeEnd = 1219835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData>.NativeClassPtr, "RunWithoutJobSystem_00000420$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664565);
          CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664566);
          CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664567);
          CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664568);
          CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664570);
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
            IL2CPP.il2cpp_field_static_get_value(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CharacterHudProgressBarSystem.__c__DisplayClass_UpdateCharacterHudProgressBarData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
