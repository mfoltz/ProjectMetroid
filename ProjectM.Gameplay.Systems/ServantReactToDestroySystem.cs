// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantReactToDestroySystem
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
  public class ServantReactToDestroySystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___ManageServantInventory_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ManageServantInventory_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___KillServantWhenCoffinDestroyed_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___KillServantWhenCoffinDestroyed_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForManageServantInventory_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForKillServantWhenCoffinDestroyed_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417982, XrefRangeEnd = 1418020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantReactToDestroySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantReactToDestroySystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantReactToDestroySystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418020, XrefRangeEnd = 1418060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantReactToDestroySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1418082, RefRangeEnd = 1418083, XrefRangeStart = 1418060, XrefRangeEnd = 1418082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForManageServantInventory_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.NativeMethodInfoPtr___GetEntityQuery_ForManageServantInventory_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418083, XrefRangeEnd = 1418102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForKillServantWhenCoffinDestroyed_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.NativeMethodInfoPtr___GetEntityQuery_ForKillServantWhenCoffinDestroyed_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1418106, RefRangeEnd = 1418107, XrefRangeStart = 1418102, XrefRangeEnd = 1418106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantReactToDestroySystem()
    {
      Il2CppClassPointerStore<ServantReactToDestroySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (ServantReactToDestroySystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantReactToDestroySystem>.NativeClassPtr);
      ServantReactToDestroySystem.NativeFieldInfoPtr___ManageServantInventory_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem>.NativeClassPtr, "<>ManageServantInventory_entityQuery");
      ServantReactToDestroySystem.NativeFieldInfoPtr___ManageServantInventory_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem>.NativeClassPtr, "<>ManageServantInventory_profilerMarker");
      ServantReactToDestroySystem.NativeFieldInfoPtr___KillServantWhenCoffinDestroyed_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem>.NativeClassPtr, "<>KillServantWhenCoffinDestroyed_entityQuery");
      ServantReactToDestroySystem.NativeFieldInfoPtr___KillServantWhenCoffinDestroyed_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem>.NativeClassPtr, "<>KillServantWhenCoffinDestroyed_profilerMarker");
      ServantReactToDestroySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem>.NativeClassPtr, 100669354);
      ServantReactToDestroySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem>.NativeClassPtr, 100669355);
      ServantReactToDestroySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem>.NativeClassPtr, 100669356);
      ServantReactToDestroySystem.NativeMethodInfoPtr___GetEntityQuery_ForManageServantInventory_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem>.NativeClassPtr, 100669357);
      ServantReactToDestroySystem.NativeMethodInfoPtr___GetEntityQuery_ForKillServantWhenCoffinDestroyed_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem>.NativeClassPtr, 100669358);
      ServantReactToDestroySystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem>.NativeClassPtr, 100669359);
    }

    public ServantReactToDestroySystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __ManageServantInventory_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.NativeFieldInfoPtr___ManageServantInventory_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.NativeFieldInfoPtr___ManageServantInventory_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ManageServantInventory_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.NativeFieldInfoPtr___ManageServantInventory_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.NativeFieldInfoPtr___ManageServantInventory_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __KillServantWhenCoffinDestroyed_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.NativeFieldInfoPtr___KillServantWhenCoffinDestroyed_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.NativeFieldInfoPtr___KillServantWhenCoffinDestroyed_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __KillServantWhenCoffinDestroyed_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.NativeFieldInfoPtr___KillServantWhenCoffinDestroyed_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.NativeFieldInfoPtr___KillServantWhenCoffinDestroyed_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.ServantReactToDestroySystem/<>c__DisplayClass0_0")]
    public sealed class __c__DisplayClass0_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_weaponLevels;
      private static readonly System.IntPtr NativeFieldInfoPtr_armorLevels;
      private static readonly System.IntPtr NativeFieldInfoPtr_spellLevels;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ServantEquipment_byref_ServantConnectedCoffin_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_ServantCoffinstation_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass0_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref ServantEquipment servantEquipment,
        [In] ref ServantConnectedCoffin connectedCoffin)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref servantEquipment;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref connectedCoffin;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ServantEquipment_byref_ServantConnectedCoffin_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1([In] ref ServantCoffinstation station)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref station;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_ServantCoffinstation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantReactToDestroySystem>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass0_0>.NativeClassPtr);
        ServantReactToDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass0_0>.NativeClassPtr, "<>4__this");
        ServantReactToDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (commandBuffer));
        ServantReactToDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr_weaponLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (weaponLevels));
        ServantReactToDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr_armorLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (armorLevels));
        ServantReactToDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr_spellLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (spellLevels));
        ServantReactToDestroySystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass0_0>.NativeClassPtr, 100669360);
        ServantReactToDestroySystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ServantEquipment_byref_ServantConnectedCoffin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass0_0>.NativeClassPtr, 100669361);
        ServantReactToDestroySystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_ServantCoffinstation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass0_0>.NativeClassPtr, 100669362);
      }

      public __c__DisplayClass0_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass0_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass0_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass0_0>.NativeClassPtr, data));
      }

      public unsafe ServantReactToDestroySystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServantReactToDestroySystem) null : new ServantReactToDestroySystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public unsafe ComponentDataFromEntity<WeaponLevelSource> weaponLevels
      {
        get
        {
          return *(ComponentDataFromEntity<WeaponLevelSource>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr_weaponLevels));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr_weaponLevels), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<WeaponLevelSource>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<ArmorLevelSource> armorLevels
      {
        get
        {
          return *(ComponentDataFromEntity<ArmorLevelSource>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr_armorLevels));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr_armorLevels), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<ArmorLevelSource>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<SpellLevelSource> spellLevels
      {
        get
        {
          return *(ComponentDataFromEntity<SpellLevelSource>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr_spellLevels));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr_spellLevels), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<SpellLevelSource>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.ServantReactToDestroySystem/ProjectM.<>c__DisplayClass_ManageServantInventory")]
    public sealed class __c__DisplayClass_ManageServantInventory : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_weaponLevels;
      private static readonly System.IntPtr NativeFieldInfoPtr_armorLevels;
      private static readonly System.IntPtr NativeFieldInfoPtr_spellLevels;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ServantEquipment_byref_ServantConnectedCoffin_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantReactToDestroySystem_byref___c__DisplayClass0_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1417837, RefRangeEnd = 1417838, XrefRangeStart = 1417802, XrefRangeEnd = 1417837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref ServantEquipment servantEquipment,
        [In] ref ServantConnectedCoffin connectedCoffin)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref servantEquipment;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref connectedCoffin;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ServantEquipment_byref_ServantConnectedCoffin_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417838, XrefRangeEnd = 1417839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServantReactToDestroySystem.__c__DisplayClass0_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1417840, RefRangeEnd = 1417841, XrefRangeStart = 1417839, XrefRangeEnd = 1417840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServantReactToDestroySystem.__c__DisplayClass0_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417841, XrefRangeEnd = 1417855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1417861, RefRangeEnd = 1417862, XrefRangeStart = 1417855, XrefRangeEnd = 1417861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1417863, RefRangeEnd = 1417864, XrefRangeStart = 1417862, XrefRangeEnd = 1417863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServantReactToDestroySystem componentSystem,
        ref ServantReactToDestroySystem.__c__DisplayClass0_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantReactToDestroySystem_byref___c__DisplayClass0_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ManageServantInventory()
      {
        Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantReactToDestroySystem>.NativeClassPtr, "<>c__DisplayClass_ManageServantInventory");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory>.NativeClassPtr);
        ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory>.NativeClassPtr, "<>4__this");
        ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory>.NativeClassPtr, nameof (commandBuffer));
        ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr_weaponLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory>.NativeClassPtr, nameof (weaponLevels));
        ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr_armorLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory>.NativeClassPtr, nameof (armorLevels));
        ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr_spellLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory>.NativeClassPtr, nameof (spellLevels));
        ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory>.NativeClassPtr, nameof (_runtimes));
        ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory>.NativeClassPtr, nameof (_performLambdaDelegate));
        ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ServantEquipment_byref_ServantConnectedCoffin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory>.NativeClassPtr, 100669363);
        ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory>.NativeClassPtr, 100669364);
        ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory>.NativeClassPtr, 100669365);
        ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory>.NativeClassPtr, 100669367);
        ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory>.NativeClassPtr, 100669368);
        ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantReactToDestroySystem_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory>.NativeClassPtr, 100669369);
      }

      public __c__DisplayClass_ManageServantInventory(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_ManageServantInventory()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory>.NativeClassPtr, data));
      }

      public unsafe ServantReactToDestroySystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServantReactToDestroySystem) null : new ServantReactToDestroySystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public unsafe ComponentDataFromEntity<WeaponLevelSource> weaponLevels
      {
        get
        {
          return *(ComponentDataFromEntity<WeaponLevelSource>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr_weaponLevels));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr_weaponLevels), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<WeaponLevelSource>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<ArmorLevelSource> armorLevels
      {
        get
        {
          return *(ComponentDataFromEntity<ArmorLevelSource>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr_armorLevels));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr_armorLevels), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<ArmorLevelSource>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<SpellLevelSource> spellLevels
      {
        get
        {
          return *(ComponentDataFromEntity<SpellLevelSource>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr_spellLevels));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr_spellLevels), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<SpellLevelSource>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_servantEquipment;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_connectedCoffin;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantReactToDestroySystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ServantEquipment> forParameter_servantEquipment;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<ServantConnectedCoffin> forParameter_connectedCoffin;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417786, XrefRangeEnd = 1417793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServantReactToDestroySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantReactToDestroySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1417801, RefRangeEnd = 1417802, XrefRangeStart = 1417793, XrefRangeEnd = 1417801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_servantEquipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_servantEquipment));
          ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_connectedCoffin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_connectedCoffin));
          ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantReactToDestroySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders>.NativeClassPtr, 100669370);
          ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders>.NativeClassPtr, 100669371);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_servantEquipment;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_connectedCoffin;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<ServantEquipment>.StructuralChangeRuntime runtime_servantEquipment;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<ServantConnectedCoffin>.StructuralChangeRuntime runtime_connectedCoffin;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_servantEquipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_servantEquipment));
            ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_connectedCoffin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_connectedCoffin));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_ManageServantInventory.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServantReactToDestroySystem/ProjectM.<>c__DisplayClass_KillServantWhenCoffinDestroyed")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_KillServantWhenCoffinDestroyed
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ServantData_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ServantCoffinstation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantReactToDestroySystem_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(16)]
      public ComponentDataFromEntity<ServantData> _ComponentDataFromEntity_ServantData_0;
      [FieldOffset(48)]
      public ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417947, XrefRangeEnd = 1417958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref ServantCoffinstation station)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref station;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ServantCoffinstation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(34)]
      [CachedScanResults(RefRangeStart = 723251, RefRangeEnd = 723285, XrefRangeStart = 723251, XrefRangeEnd = 723285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServantReactToDestroySystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(34)]
      [CachedScanResults(RefRangeStart = 723285, RefRangeEnd = 723319, XrefRangeStart = 723285, XrefRangeEnd = 723319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServantReactToDestroySystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417958, XrefRangeEnd = 1417960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1417965, RefRangeEnd = 1417966, XrefRangeStart = 1417960, XrefRangeEnd = 1417965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1417971, RefRangeEnd = 1417972, XrefRangeStart = 1417966, XrefRangeEnd = 1417971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServantReactToDestroySystem componentSystem,
        ref ServantReactToDestroySystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantReactToDestroySystem_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417972, XrefRangeEnd = 1417976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417976, XrefRangeEnd = 1417982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_KillServantWhenCoffinDestroyed()
      {
        Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantReactToDestroySystem>.NativeClassPtr, "<>c__DisplayClass_KillServantWhenCoffinDestroyed");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr);
        ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr, nameof (commandBuffer));
        ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeFieldInfoPtr__ComponentDataFromEntity_ServantData_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr, nameof (_ComponentDataFromEntity_ServantData_0));
        ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr, nameof (_runtimes));
        ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ServantCoffinstation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr, 100669372);
        ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr, 100669373);
        ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr, 100669374);
        ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr, 100669375);
        ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr, 100669376);
        ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantReactToDestroySystem_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr, 100669377);
        ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr, 100669378);
        ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr, 100669379);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_station;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantReactToDestroySystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<ServantCoffinstation> forParameter_station;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1417867, RefRangeEnd = 1417868, XrefRangeStart = 1417864, XrefRangeEnd = 1417867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServantReactToDestroySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantReactToDestroySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1417871, RefRangeEnd = 1417872, XrefRangeStart = 1417868, XrefRangeEnd = 1417871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_station));
          ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantReactToDestroySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders>.NativeClassPtr, 100669380);
          ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders>.NativeClassPtr, 100669381);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_station;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<ServantCoffinstation>.Runtime runtime_station;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_station));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ServantReactToDestroySystem/ProjectM.<>c__DisplayClass_KillServantWhenCoffinDestroyed/ProjectM.RunWithoutJobSystem_00000E6A$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr, "RunWithoutJobSystem_00000E6A$PostfixBurstDelegate");
          ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669382);
          ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669383);
          ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669384);
          ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669385);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ServantReactToDestroySystem/ProjectM.<>c__DisplayClass_KillServantWhenCoffinDestroyed/ProjectM.RunWithoutJobSystem_00000E6A$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417872, XrefRangeEnd = 1417886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417886, XrefRangeEnd = 1417904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417904, XrefRangeEnd = 1417919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1417946, RefRangeEnd = 1417947, XrefRangeStart = 1417919, XrefRangeEnd = 1417946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed>.NativeClassPtr, "RunWithoutJobSystem_00000E6A$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669386);
          ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669387);
          ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669388);
          ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669389);
          ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669391);
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
            IL2CPP.il2cpp_field_static_get_value(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServantReactToDestroySystem.__c__DisplayClass_KillServantWhenCoffinDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
