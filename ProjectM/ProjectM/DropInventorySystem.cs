// Decompiled with JetBrains decompiler
// Type: ProjectM.DropInventorySystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class DropInventorySystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyedDropTableQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyInventoryOnDestroyQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurveCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__JewelSpawnSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpellModTierCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerGameSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnDestroy_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnDestroy_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnSalvageDestroy_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnSalvageDestroy_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateDropTableItemsJob_DestroyInventoryOnDestroy_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateDropTableItemsJob_DestroyInventoryOnDestroy_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_18;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DropItem_Public_Static_Void_EntityCommandBuffer_byref_Translation_PrefabGUID_Int32_Entity_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Single_Nullable_Unboxed_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCreateDropTableItemsJob_DropOnDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCreateDropTableItemsJob_DropOnSalvageDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCreateDropTableItemsJob_DestroyInventoryOnDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014241, XrefRangeEnd = 1014285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DropInventorySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014285, XrefRangeEnd = 1014363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DropInventorySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1014367, RefRangeEnd = 1014368, XrefRangeStart = 1014363, XrefRangeEnd = 1014367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DropItem(
      EntityCommandBuffer commandBuffer,
      [In] ref Translation translation,
      PrefabGUID itemHash,
      int amount,
      Entity itemEntity,
      Nullable_Unboxed<Entity> customDropArc,
      Nullable_Unboxed<float> minRange,
      Nullable_Unboxed<float> maxRange)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemHash;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &itemEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &customDropArc;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &minRange;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &maxRange;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.NativeMethodInfoPtr_DropItem_Public_Static_Void_EntityCommandBuffer_byref_Translation_PrefabGUID_Int32_Entity_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Single_Nullable_Unboxed_1_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DropInventorySystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014368, XrefRangeEnd = 1014425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DropInventorySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1014450, RefRangeEnd = 1014451, XrefRangeStart = 1014425, XrefRangeEnd = 1014450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCreateDropTableItemsJob_DropOnDestroy_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.NativeMethodInfoPtr___GetEntityQuery_ForCreateDropTableItemsJob_DropOnDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1014479, RefRangeEnd = 1014480, XrefRangeStart = 1014451, XrefRangeEnd = 1014479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCreateDropTableItemsJob_DropOnSalvageDestroy_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.NativeMethodInfoPtr___GetEntityQuery_ForCreateDropTableItemsJob_DropOnSalvageDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1014502, RefRangeEnd = 1014503, XrefRangeStart = 1014480, XrefRangeEnd = 1014502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCreateDropTableItemsJob_DestroyInventoryOnDestroy_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.NativeMethodInfoPtr___GetEntityQuery_ForCreateDropTableItemsJob_DestroyInventoryOnDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1014507, RefRangeEnd = 1014508, XrefRangeStart = 1014503, XrefRangeEnd = 1014507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1014512, RefRangeEnd = 1014513, XrefRangeStart = 1014508, XrefRangeEnd = 1014512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1014517, RefRangeEnd = 1014518, XrefRangeStart = 1014513, XrefRangeEnd = 1014517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DropInventorySystem()
    {
      Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DropInventorySystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr);
      DropInventorySystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      DropInventorySystem.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, nameof (_SpawnBarrier));
      DropInventorySystem.NativeFieldInfoPtr__DestroyedDropTableQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, nameof (_DestroyedDropTableQuery));
      DropInventorySystem.NativeFieldInfoPtr__DestroyInventoryOnDestroyQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, nameof (_DestroyInventoryOnDestroyQuery));
      DropInventorySystem.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, nameof (_GameDataSystem));
      DropInventorySystem.NativeFieldInfoPtr__CurveCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, nameof (_CurveCollectionSystem));
      DropInventorySystem.NativeFieldInfoPtr__JewelSpawnSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, nameof (_JewelSpawnSystem));
      DropInventorySystem.NativeFieldInfoPtr__SpellModTierCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, nameof (_SpellModTierCollectionSystem));
      DropInventorySystem.NativeFieldInfoPtr__ServerGameSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, nameof (_ServerGameSettings));
      DropInventorySystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnDestroy_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, "<>CreateDropTableItemsJob_DropOnDestroy_entityQuery");
      DropInventorySystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnDestroy_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, "<>CreateDropTableItemsJob_DropOnDestroy_profilerMarker");
      DropInventorySystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnSalvageDestroy_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, "<>CreateDropTableItemsJob_DropOnSalvageDestroy_entityQuery");
      DropInventorySystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnSalvageDestroy_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, "<>CreateDropTableItemsJob_DropOnSalvageDestroy_profilerMarker");
      DropInventorySystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DestroyInventoryOnDestroy_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, "<>CreateDropTableItemsJob_DestroyInventoryOnDestroy_entityQuery");
      DropInventorySystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DestroyInventoryOnDestroy_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, "<>CreateDropTableItemsJob_DestroyInventoryOnDestroy_profilerMarker");
      DropInventorySystem.NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, nameof (_SingletonEntityQuery_RelicDropped_18));
      DropInventorySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, 100679036);
      DropInventorySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, 100679037);
      DropInventorySystem.NativeMethodInfoPtr_DropItem_Public_Static_Void_EntityCommandBuffer_byref_Translation_PrefabGUID_Int32_Entity_Nullable_Unboxed_1_Entity_Nullable_Unboxed_1_Single_Nullable_Unboxed_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, 100679038);
      DropInventorySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, 100679039);
      DropInventorySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, 100679040);
      DropInventorySystem.NativeMethodInfoPtr___GetEntityQuery_ForCreateDropTableItemsJob_DropOnDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, 100679041);
      DropInventorySystem.NativeMethodInfoPtr___GetEntityQuery_ForCreateDropTableItemsJob_DropOnSalvageDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, 100679042);
      DropInventorySystem.NativeMethodInfoPtr___GetEntityQuery_ForCreateDropTableItemsJob_DestroyInventoryOnDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, 100679043);
      DropInventorySystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, 100679044);
      DropInventorySystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, 100679045);
      DropInventorySystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, 100679046);
    }

    public DropInventorySystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnBarrier _SpawnBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _DestroyedDropTableQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__DestroyedDropTableQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__DestroyedDropTableQuery)) = value;
      }
    }

    public unsafe EntityQuery _DestroyInventoryOnDestroyQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__DestroyInventoryOnDestroyQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__DestroyInventoryOnDestroyQuery)) = value;
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CurveCollectionSystem _CurveCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__CurveCollectionSystem));
        return pointer == System.IntPtr.Zero ? (CurveCollectionSystem) null : new CurveCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__CurveCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe JewelSpawnSystem _JewelSpawnSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__JewelSpawnSystem));
        return pointer == System.IntPtr.Zero ? (JewelSpawnSystem) null : new JewelSpawnSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__JewelSpawnSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellModTierCollectionSystem _SpellModTierCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__SpellModTierCollectionSystem));
        return pointer == System.IntPtr.Zero ? (SpellModTierCollectionSystem) null : new SpellModTierCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__SpellModTierCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<ServerGameBalanceSettings> _ServerGameSettings
    {
      get
      {
        return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__ServerGameSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__ServerGameSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __CreateDropTableItemsJob_DropOnDestroy_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnDestroy_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnDestroy_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CreateDropTableItemsJob_DropOnDestroy_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnDestroy_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnDestroy_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __CreateDropTableItemsJob_DropOnSalvageDestroy_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnSalvageDestroy_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnSalvageDestroy_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CreateDropTableItemsJob_DropOnSalvageDestroy_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnSalvageDestroy_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnSalvageDestroy_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __CreateDropTableItemsJob_DestroyInventoryOnDestroy_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DestroyInventoryOnDestroy_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DestroyInventoryOnDestroy_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CreateDropTableItemsJob_DestroyInventoryOnDestroy_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DestroyInventoryOnDestroy_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DestroyInventoryOnDestroy_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_RelicDropped_18
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_18));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventorySystem.NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_18)) = value;
      }
    }

    [ObfuscatedName("ProjectM.DropInventorySystem/<>c__DisplayClass10_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass10_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_createDropTableItemsJob;
      private static readonly System.IntPtr NativeFieldInfoPtr_relicsDroppedBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverGameSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_0;
      [FieldOffset(0)]
      public CreateDropTableItemsJob createDropTableItemsJob;
      [FieldOffset(304)]
      public DynamicBuffer<RelicDropped> relicsDroppedBuffer;
      [FieldOffset(320)]
      public ServerGameBalanceSettings serverGameSettings;
      [FieldOffset(1720)]
      public EntityManager entityManager;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass10_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        [In] ref DynamicBuffer<DropTableBuffer> dropItemsBuffer,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref dropItemsBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        [In] ref DynamicBuffer<DropTableBuffer> dropItemsBuffer,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref dropItemsBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass10_0()
      {
        Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, "<>c__DisplayClass10_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass10_0>.NativeClassPtr);
        DropInventorySystem.__c__DisplayClass10_0.NativeFieldInfoPtr_createDropTableItemsJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (createDropTableItemsJob));
        DropInventorySystem.__c__DisplayClass10_0.NativeFieldInfoPtr_relicsDroppedBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (relicsDroppedBuffer));
        DropInventorySystem.__c__DisplayClass10_0.NativeFieldInfoPtr_serverGameSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (serverGameSettings));
        DropInventorySystem.__c__DisplayClass10_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (entityManager));
        DropInventorySystem.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass10_0>.NativeClassPtr, 100679047);
        DropInventorySystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass10_0>.NativeClassPtr, 100679048);
        DropInventorySystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass10_0>.NativeClassPtr, 100679049);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass10_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DropInventorySystem/<>c__DisplayClass10_1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass10_1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getInventory;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_DynamicBuffer_1_InventoryInstanceElement_byref_DestroyData_0;
      [FieldOffset(0)]
      public BufferFromEntity<InventoryBuffer> getInventory;
      [FieldOffset(40)]
      public EntityCommandBuffer commandBuffer;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass10_1()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass10_1.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        Entity entity,
        [In] ref DynamicBuffer<InventoryInstanceElement> inventories,
        [In] ref DestroyData destroyData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventories;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref destroyData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass10_1.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_DynamicBuffer_1_InventoryInstanceElement_byref_DestroyData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass10_1()
      {
        Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass10_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, "<>c__DisplayClass10_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass10_1>.NativeClassPtr);
        DropInventorySystem.__c__DisplayClass10_1.NativeFieldInfoPtr_getInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass10_1>.NativeClassPtr, nameof (getInventory));
        DropInventorySystem.__c__DisplayClass10_1.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass10_1>.NativeClassPtr, nameof (commandBuffer));
        DropInventorySystem.__c__DisplayClass10_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass10_1>.NativeClassPtr, 100679050);
        DropInventorySystem.__c__DisplayClass10_1.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_DynamicBuffer_1_InventoryInstanceElement_byref_DestroyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass10_1>.NativeClassPtr, 100679051);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass10_1>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DropInventorySystem/ProjectM.<>c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_createDropTableItemsJob;
      private static readonly System.IntPtr NativeFieldInfoPtr_relicsDroppedBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverGameSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventorySystem_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public CreateDropTableItemsJob createDropTableItemsJob;
      [FieldOffset(304)]
      public DynamicBuffer<RelicDropped> relicsDroppedBuffer;
      [FieldOffset(320)]
      public ServerGameBalanceSettings serverGameSettings;
      [FieldOffset(1720)]
      public EntityManager entityManager;
      [FieldOffset(1728)]
      public DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(1800)]
      public unsafe DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1013948, RefRangeEnd = 1013949, XrefRangeStart = 1013947, XrefRangeEnd = 1013948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref DynamicBuffer<DropTableBuffer> dropItemsBuffer,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref dropItemsBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1013950, RefRangeEnd = 1013952, XrefRangeStart = 1013949, XrefRangeEnd = 1013950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DropInventorySystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1013953, RefRangeEnd = 1013955, XrefRangeStart = 1013952, XrefRangeEnd = 1013953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DropInventorySystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013955, XrefRangeEnd = 1013957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1013965, RefRangeEnd = 1013966, XrefRangeStart = 1013957, XrefRangeEnd = 1013965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1013968, RefRangeEnd = 1013969, XrefRangeStart = 1013966, XrefRangeEnd = 1013968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DropInventorySystem componentSystem,
        ref DropInventorySystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventorySystem_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013969, XrefRangeEnd = 1013973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013973, XrefRangeEnd = 1013979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy()
      {
        Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, "<>c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeFieldInfoPtr_createDropTableItemsJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, nameof (createDropTableItemsJob));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeFieldInfoPtr_relicsDroppedBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, nameof (relicsDroppedBuffer));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeFieldInfoPtr_serverGameSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, nameof (serverGameSettings));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, nameof (entityManager));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, nameof (_runtimes));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, 100679052);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, 100679053);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, 100679054);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, 100679055);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, 100679056);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventorySystem_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, 100679057);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, 100679058);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, 100679059);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_dropItemsBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventorySystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<DropTableBuffer> forParameter_dropItemsBuffer;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1013864, RefRangeEnd = 1013865, XrefRangeStart = 1013858, XrefRangeEnd = 1013864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DropInventorySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventorySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1013871, RefRangeEnd = 1013872, XrefRangeStart = 1013865, XrefRangeEnd = 1013871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_dropItemsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_dropItemsBuffer));
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventorySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, 100679060);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, 100679061);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_dropItemsBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<DropTableBuffer>.Runtime runtime_dropItemsBuffer;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_dropItemsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_dropItemsBuffer));
            DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.DropInventorySystem/ProjectM.<>c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy/ProjectM.RunWithoutJobSystem_00003A53$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, "RunWithoutJobSystem_00003A53$PostfixBurstDelegate");
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679062);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679063);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679064);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679065);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DropInventorySystem/ProjectM.<>c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy/ProjectM.RunWithoutJobSystem_00003A53$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013872, XrefRangeEnd = 1013886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013886, XrefRangeEnd = 1013904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013904, XrefRangeEnd = 1013919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1013946, RefRangeEnd = 1013947, XrefRangeStart = 1013919, XrefRangeEnd = 1013946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy>.NativeClassPtr, "RunWithoutJobSystem_00003A53$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679066);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679067);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679068);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679069);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679071);
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
            IL2CPP.il2cpp_field_static_get_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DropInventorySystem/ProjectM.<>c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_createDropTableItemsJob;
      private static readonly System.IntPtr NativeFieldInfoPtr_relicsDroppedBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverGameSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventorySystem_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public CreateDropTableItemsJob createDropTableItemsJob;
      [FieldOffset(304)]
      public DynamicBuffer<RelicDropped> relicsDroppedBuffer;
      [FieldOffset(320)]
      public ServerGameBalanceSettings serverGameSettings;
      [FieldOffset(1720)]
      public EntityManager entityManager;
      [FieldOffset(1728)]
      public DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(1800)]
      public unsafe DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1014069, RefRangeEnd = 1014070, XrefRangeStart = 1014068, XrefRangeEnd = 1014069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref DynamicBuffer<DropTableBuffer> dropItemsBuffer,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref dropItemsBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1013950, RefRangeEnd = 1013952, XrefRangeStart = 1013950, XrefRangeEnd = 1013952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DropInventorySystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1013953, RefRangeEnd = 1013955, XrefRangeStart = 1013953, XrefRangeEnd = 1013955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DropInventorySystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014070, XrefRangeEnd = 1014072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1014080, RefRangeEnd = 1014081, XrefRangeStart = 1014072, XrefRangeEnd = 1014080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1014083, RefRangeEnd = 1014084, XrefRangeStart = 1014081, XrefRangeEnd = 1014083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DropInventorySystem componentSystem,
        ref DropInventorySystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventorySystem_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014084, XrefRangeEnd = 1014088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014088, XrefRangeEnd = 1014094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy()
      {
        Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, "<>c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeFieldInfoPtr_createDropTableItemsJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, nameof (createDropTableItemsJob));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeFieldInfoPtr_relicsDroppedBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, nameof (relicsDroppedBuffer));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeFieldInfoPtr_serverGameSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, nameof (serverGameSettings));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, nameof (entityManager));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, nameof (_runtimes));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, 100679072);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, 100679073);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, 100679074);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, 100679075);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, 100679076);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventorySystem_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, 100679077);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, 100679078);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, 100679079);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_dropItemsBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventorySystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<DropTableBuffer> forParameter_dropItemsBuffer;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1013985, RefRangeEnd = 1013986, XrefRangeStart = 1013979, XrefRangeEnd = 1013985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DropInventorySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventorySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1013992, RefRangeEnd = 1013993, XrefRangeStart = 1013986, XrefRangeEnd = 1013992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_dropItemsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_dropItemsBuffer));
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventorySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders>.NativeClassPtr, 100679080);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders>.NativeClassPtr, 100679081);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_dropItemsBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<DropTableBuffer>.Runtime runtime_dropItemsBuffer;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_dropItemsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_dropItemsBuffer));
            DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.DropInventorySystem/ProjectM.<>c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy/ProjectM.RunWithoutJobSystem_00003A5C$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, "RunWithoutJobSystem_00003A5C$PostfixBurstDelegate");
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679082);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679083);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679084);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679085);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DropInventorySystem/ProjectM.<>c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy/ProjectM.RunWithoutJobSystem_00003A5C$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013993, XrefRangeEnd = 1014007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014007, XrefRangeEnd = 1014025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014025, XrefRangeEnd = 1014040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1014067, RefRangeEnd = 1014068, XrefRangeStart = 1014040, XrefRangeEnd = 1014067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy>.NativeClassPtr, "RunWithoutJobSystem_00003A5C$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679086);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679087);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679088);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679089);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679091);
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
            IL2CPP.il2cpp_field_static_get_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnSalvageDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DropInventorySystem/ProjectM.<>c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getInventory;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_InventoryInstanceElement_byref_DestroyData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventorySystem_byref___c__DisplayClass10_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public BufferFromEntity<InventoryBuffer> getInventory;
      [FieldOffset(40)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(56)]
      public DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(136)]
      public unsafe DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014185, XrefRangeEnd = 1014210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref DynamicBuffer<InventoryInstanceElement> inventories,
        [In] ref DestroyData destroyData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref inventories;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref destroyData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_InventoryInstanceElement_byref_DestroyData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1014210, RefRangeEnd = 1014213, XrefRangeStart = 1014210, XrefRangeEnd = 1014210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DropInventorySystem.__c__DisplayClass10_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1014213, RefRangeEnd = 1014216, XrefRangeStart = 1014213, XrefRangeEnd = 1014213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DropInventorySystem.__c__DisplayClass10_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014216, XrefRangeEnd = 1014218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1014227, RefRangeEnd = 1014228, XrefRangeStart = 1014218, XrefRangeEnd = 1014227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1014230, RefRangeEnd = 1014231, XrefRangeStart = 1014228, XrefRangeEnd = 1014230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DropInventorySystem componentSystem,
        ref DropInventorySystem.__c__DisplayClass10_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventorySystem_byref___c__DisplayClass10_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014231, XrefRangeEnd = 1014235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014235, XrefRangeEnd = 1014241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy()
      {
        Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventorySystem>.NativeClassPtr, "<>c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeFieldInfoPtr_getInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr, nameof (getInventory));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr, nameof (commandBuffer));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr, nameof (_runtimes));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_InventoryInstanceElement_byref_DestroyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr, 100679092);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr, 100679093);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr, 100679094);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr, 100679095);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr, 100679096);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventorySystem_byref___c__DisplayClass10_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr, 100679097);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr, 100679098);
        DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr, 100679099);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_inventories;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_destroyData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventorySystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<InventoryInstanceElement> forParameter_inventories;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_IComponentData<DestroyData> forParameter_destroyData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1014101, RefRangeEnd = 1014102, XrefRangeStart = 1014094, XrefRangeEnd = 1014101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DropInventorySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventorySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1014109, RefRangeEnd = 1014110, XrefRangeStart = 1014102, XrefRangeEnd = 1014109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_inventories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_inventories));
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_destroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_destroyData));
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventorySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, 100679100);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, 100679101);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_inventories;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_destroyData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<InventoryInstanceElement>.Runtime runtime_inventories;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<DestroyData>.Runtime runtime_destroyData;

          static Runtimes()
          {
            Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_inventories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_inventories));
            DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_destroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_destroyData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.DropInventorySystem/ProjectM.<>c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy/ProjectM.RunWithoutJobSystem_00003A65$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr, "RunWithoutJobSystem_00003A65$PostfixBurstDelegate");
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679102);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679103);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679104);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679105);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DropInventorySystem/ProjectM.<>c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy/ProjectM.RunWithoutJobSystem_00003A65$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014110, XrefRangeEnd = 1014124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014124, XrefRangeEnd = 1014142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014142, XrefRangeEnd = 1014157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1014184, RefRangeEnd = 1014185, XrefRangeStart = 1014157, XrefRangeEnd = 1014184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy>.NativeClassPtr, "RunWithoutJobSystem_00003A65$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679106);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679107);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679108);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679109);
          DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679111);
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
            IL2CPP.il2cpp_field_static_get_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DropInventorySystem.__c__DisplayClass_CreateDropTableItemsJob_DestroyInventoryOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
