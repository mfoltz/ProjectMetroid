// Decompiled with JetBrains decompiler
// Type: ProjectM.TeleportToWaypointEventSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class TeleportToWaypointEventSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TeleportToWaypointEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__TeleportToNetherEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__DebugTeleportToNetherEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__DebugTeleportToEntityEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TeleportationRequestPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__BalanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleTeleportToWaypointEvents_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleTeleportToWaypointEvents_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleTeleportToNetherEvents_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleTeleportToNetherEvents_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleDebugTeleportToEntityEvents_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleDebugTeleportToEntityEvents_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleDebugTeleportToNetherEvents_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleDebugTeleportToNetherEvents_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleTeleportToWaypointEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleTeleportToNetherEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleDebugTeleportToEntityEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleDebugTeleportToNetherEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421499, XrefRangeEnd = 1421533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TeleportToWaypointEventSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421533, XrefRangeEnd = 1421539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TeleportToWaypointEventSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421539, XrefRangeEnd = 1421615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TeleportToWaypointEventSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TeleportToWaypointEventSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421615, XrefRangeEnd = 1421749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TeleportToWaypointEventSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421749, XrefRangeEnd = 1421768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleTeleportToWaypointEvents_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleTeleportToWaypointEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421768, XrefRangeEnd = 1421787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleTeleportToNetherEvents_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleTeleportToNetherEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421787, XrefRangeEnd = 1421806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleDebugTeleportToEntityEvents_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleDebugTeleportToEntityEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421806, XrefRangeEnd = 1421825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleDebugTeleportToNetherEvents_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleDebugTeleportToNetherEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1421829, RefRangeEnd = 1421830, XrefRangeStart = 1421825, XrefRangeEnd = 1421829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1421834, RefRangeEnd = 1421835, XrefRangeStart = 1421830, XrefRangeEnd = 1421834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1421839, RefRangeEnd = 1421840, XrefRangeStart = 1421835, XrefRangeEnd = 1421839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TeleportToWaypointEventSystem()
    {
      Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (TeleportToWaypointEventSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr);
      TeleportToWaypointEventSystem.NativeFieldInfoPtr__TeleportToWaypointEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, nameof (_TeleportToWaypointEventQuery));
      TeleportToWaypointEventSystem.NativeFieldInfoPtr__TeleportToNetherEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, nameof (_TeleportToNetherEventQuery));
      TeleportToWaypointEventSystem.NativeFieldInfoPtr__DebugTeleportToNetherEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, nameof (_DebugTeleportToNetherEventQuery));
      TeleportToWaypointEventSystem.NativeFieldInfoPtr__DebugTeleportToEntityEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, nameof (_DebugTeleportToEntityEventQuery));
      TeleportToWaypointEventSystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      TeleportToWaypointEventSystem.NativeFieldInfoPtr__TeleportationRequestPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, nameof (_TeleportationRequestPrefab));
      TeleportToWaypointEventSystem.NativeFieldInfoPtr__BalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, nameof (_BalanceSettings));
      TeleportToWaypointEventSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, nameof (_SyncedServerDebugSettingsAccessor));
      TeleportToWaypointEventSystem.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, nameof (_GameDataSystem));
      TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleTeleportToWaypointEvents_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, "<>HandleTeleportToWaypointEvents_entityQuery");
      TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleTeleportToWaypointEvents_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, "<>HandleTeleportToWaypointEvents_profilerMarker");
      TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleTeleportToNetherEvents_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, "<>HandleTeleportToNetherEvents_entityQuery");
      TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleTeleportToNetherEvents_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, "<>HandleTeleportToNetherEvents_profilerMarker");
      TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleDebugTeleportToEntityEvents_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, "<>HandleDebugTeleportToEntityEvents_entityQuery");
      TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleDebugTeleportToEntityEvents_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, "<>HandleDebugTeleportToEntityEvents_profilerMarker");
      TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleDebugTeleportToNetherEvents_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, "<>HandleDebugTeleportToNetherEvents_entityQuery");
      TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleDebugTeleportToNetherEvents_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, "<>HandleDebugTeleportToNetherEvents_profilerMarker");
      TeleportToWaypointEventSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, 100669686);
      TeleportToWaypointEventSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, 100669687);
      TeleportToWaypointEventSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, 100669688);
      TeleportToWaypointEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, 100669689);
      TeleportToWaypointEventSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, 100669690);
      TeleportToWaypointEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleTeleportToWaypointEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, 100669691);
      TeleportToWaypointEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleTeleportToNetherEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, 100669692);
      TeleportToWaypointEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleDebugTeleportToEntityEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, 100669693);
      TeleportToWaypointEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleDebugTeleportToNetherEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, 100669694);
      TeleportToWaypointEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, 100669695);
      TeleportToWaypointEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, 100669696);
      TeleportToWaypointEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, 100669697);
    }

    public TeleportToWaypointEventSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _TeleportToWaypointEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr__TeleportToWaypointEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr__TeleportToWaypointEventQuery)) = value;
      }
    }

    public unsafe EntityQuery _TeleportToNetherEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr__TeleportToNetherEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr__TeleportToNetherEventQuery)) = value;
      }
    }

    public unsafe EntityQuery _DebugTeleportToNetherEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr__DebugTeleportToNetherEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr__DebugTeleportToNetherEventQuery)) = value;
      }
    }

    public unsafe EntityQuery _DebugTeleportToEntityEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr__DebugTeleportToEntityEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr__DebugTeleportToEntityEventQuery)) = value;
      }
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _TeleportationRequestPrefab
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr__TeleportationRequestPrefab));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr__TeleportationRequestPrefab)) = value;
      }
    }

    public unsafe SingletonAccessor<ServerGameBalanceSettings> _BalanceSettings
    {
      get
      {
        return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr__BalanceSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr__BalanceSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _SyncedServerDebugSettingsAccessor
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __HandleTeleportToWaypointEvents_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleTeleportToWaypointEvents_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleTeleportToWaypointEvents_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleTeleportToWaypointEvents_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleTeleportToWaypointEvents_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleTeleportToWaypointEvents_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __HandleTeleportToNetherEvents_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleTeleportToNetherEvents_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleTeleportToNetherEvents_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleTeleportToNetherEvents_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleTeleportToNetherEvents_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleTeleportToNetherEvents_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __HandleDebugTeleportToEntityEvents_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleDebugTeleportToEntityEvents_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleDebugTeleportToEntityEvents_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleDebugTeleportToEntityEvents_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleDebugTeleportToEntityEvents_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleDebugTeleportToEntityEvents_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __HandleDebugTeleportToNetherEvents_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleDebugTeleportToNetherEvents_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleDebugTeleportToNetherEvents_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleDebugTeleportToNetherEvents_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleDebugTeleportToNetherEvents_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.NativeFieldInfoPtr___HandleDebugTeleportToNetherEvents_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.TeleportToWaypointEventSystem/<>c__DisplayClass11_0")]
    public sealed class __c__DisplayClass11_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIds;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverDebugSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_balanceSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_itemLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_requestPrefab;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_TeleportToWaypointEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_TeleportToNetherEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_DebugTeleportToEntityEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_byref_DebugTeleportToNetherEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass11_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass11_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        [In] ref TeleportEvents_ToServer.TeleportToWaypointEvent eventData,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref eventData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_TeleportToWaypointEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        [In] ref TeleportEvents_ToServer.TeleportToNetherEvent eventData,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref eventData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_TeleportToNetherEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        [In] ref TeleportEvents_ToServer.DebugTeleportToEntityEvent eventData,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref eventData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_DebugTeleportToEntityEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__3(
        [In] ref TeleportEvents_ToServer.DebugTeleportToNetherEvent eventData,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref eventData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_byref_DebugTeleportToNetherEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass11_0()
      {
        Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, "<>c__DisplayClass11_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass11_0>.NativeClassPtr);
        TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_networkIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (networkIds));
        TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
        TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_serverDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (serverDebugSettings));
        TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_balanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (balanceSettings));
        TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_itemLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (itemLookupMap));
        TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_entityCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (entityCommandBuffer));
        TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_requestPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (requestPrefab));
        TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass11_0>.NativeClassPtr, 100669698);
        TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_TeleportToWaypointEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass11_0>.NativeClassPtr, 100669699);
        TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_TeleportToNetherEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass11_0>.NativeClassPtr, 100669700);
        TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_DebugTeleportToEntityEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass11_0>.NativeClassPtr, 100669701);
        TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_byref_DebugTeleportToNetherEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass11_0>.NativeClassPtr, 100669702);
      }

      public __c__DisplayClass11_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass11_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass11_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass11_0>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIds
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_networkIds));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_networkIds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe TeleportToWaypointEventSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (TeleportToWaypointEventSystem) null : new TeleportToWaypointEventSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SyncedServerDebugSettings serverDebugSettings
      {
        get
        {
          return *(SyncedServerDebugSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_serverDebugSettings));
        }
        [param: In] set
        {
          *(SyncedServerDebugSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_serverDebugSettings)) = value;
        }
      }

      public unsafe ServerGameBalanceSettings balanceSettings
      {
        get
        {
          return *(ServerGameBalanceSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_balanceSettings));
        }
        [param: In] set
        {
          *(ServerGameBalanceSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_balanceSettings)) = value;
        }
      }

      public unsafe NativeHashMap<PrefabGUID, ItemData> itemLookupMap
      {
        get
        {
          return *(NativeHashMap<PrefabGUID, ItemData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_itemLookupMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_itemLookupMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, ItemData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EntityCommandBuffer entityCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_entityCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_entityCommandBuffer)) = value;
        }
      }

      public unsafe Entity requestPrefab
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_requestPrefab));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_requestPrefab)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.TeleportToWaypointEventSystem/ProjectM.<>c__DisplayClass_HandleTeleportToWaypointEvents")]
    public sealed class __c__DisplayClass_HandleTeleportToWaypointEvents : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIds;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverDebugSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_balanceSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_itemLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_requestPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_TeleportToWaypointEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1421102, RefRangeEnd = 1421103, XrefRangeStart = 1421089, XrefRangeEnd = 1421102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref TeleportEvents_ToServer.TeleportToWaypointEvent eventData,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref eventData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_TeleportToWaypointEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1421105, RefRangeEnd = 1421106, XrefRangeStart = 1421103, XrefRangeEnd = 1421105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref TeleportToWaypointEventSystem.__c__DisplayClass11_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1421108, RefRangeEnd = 1421109, XrefRangeStart = 1421106, XrefRangeEnd = 1421108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref TeleportToWaypointEventSystem.__c__DisplayClass11_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421109, XrefRangeEnd = 1421111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1421119, RefRangeEnd = 1421120, XrefRangeStart = 1421111, XrefRangeEnd = 1421119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1421122, RefRangeEnd = 1421123, XrefRangeStart = 1421120, XrefRangeEnd = 1421122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        TeleportToWaypointEventSystem componentSystem,
        ref TeleportToWaypointEventSystem.__c__DisplayClass11_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_byref___c__DisplayClass11_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421123, XrefRangeEnd = 1421129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleTeleportToWaypointEvents()
      {
        Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, "<>c__DisplayClass_HandleTeleportToWaypointEvents");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_networkIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, nameof (networkIds));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, "<>4__this");
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_serverDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, nameof (serverDebugSettings));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_balanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, nameof (balanceSettings));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_itemLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, nameof (itemLookupMap));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_entityCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, nameof (entityCommandBuffer));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_requestPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, nameof (requestPrefab));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, nameof (_runtimes));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_TeleportToWaypointEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, 100669703);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, 100669704);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, 100669705);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, 100669706);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, 100669707);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, 100669708);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, 100669709);
      }

      public __c__DisplayClass_HandleTeleportToWaypointEvents(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_HandleTeleportToWaypointEvents()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIds
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_networkIds));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_networkIds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe TeleportToWaypointEventSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (TeleportToWaypointEventSystem) null : new TeleportToWaypointEventSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SyncedServerDebugSettings serverDebugSettings
      {
        get
        {
          return *(SyncedServerDebugSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_serverDebugSettings));
        }
        [param: In] set
        {
          *(SyncedServerDebugSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_serverDebugSettings)) = value;
        }
      }

      public unsafe ServerGameBalanceSettings balanceSettings
      {
        get
        {
          return *(ServerGameBalanceSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_balanceSettings));
        }
        [param: In] set
        {
          *(ServerGameBalanceSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_balanceSettings)) = value;
        }
      }

      public unsafe NativeHashMap<PrefabGUID, ItemData> itemLookupMap
      {
        get
        {
          return *(NativeHashMap<PrefabGUID, ItemData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_itemLookupMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_itemLookupMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, ItemData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EntityCommandBuffer entityCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_entityCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_entityCommandBuffer)) = value;
        }
      }

      public unsafe Entity requestPrefab
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_requestPrefab));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_requestPrefab)) = value;
        }
      }

      public unsafe TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_eventData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<TeleportEvents_ToServer.TeleportToWaypointEvent> forParameter_eventData;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1421081, RefRangeEnd = 1421082, XrefRangeStart = 1421075, XrefRangeEnd = 1421081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(TeleportToWaypointEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1421088, RefRangeEnd = 1421089, XrefRangeStart = 1421082, XrefRangeEnd = 1421088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_eventData));
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders>.NativeClassPtr, 100669710);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders>.NativeClassPtr, 100669711);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_eventData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<TeleportEvents_ToServer.TeleportToWaypointEvent>.Runtime runtime_eventData;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.Runtime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_eventData));
            TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToWaypointEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.TeleportToWaypointEventSystem/ProjectM.<>c__DisplayClass_HandleTeleportToNetherEvents")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_HandleTeleportToNetherEvents
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIds;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_requestPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_TeleportToNetherEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<NetworkId, Entity> networkIds;
      [FieldOffset(16)]
      public EntityCommandBuffer entityCommandBuffer;
      [FieldOffset(32)]
      public Entity requestPrefab;
      [FieldOffset(40)]
      public TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(104)]
      public unsafe TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421218, XrefRangeEnd = 1421227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref TeleportEvents_ToServer.TeleportToNetherEvent eventData,
        [In] ref FromCharacter fromCharacter)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref eventData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_TeleportToNetherEvent_byref_FromCharacter_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1421227, RefRangeEnd = 1421229, XrefRangeStart = 1421227, XrefRangeEnd = 1421227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref TeleportToWaypointEventSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1421229, RefRangeEnd = 1421231, XrefRangeStart = 1421229, XrefRangeEnd = 1421229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref TeleportToWaypointEventSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421231, XrefRangeEnd = 1421233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1421241, RefRangeEnd = 1421242, XrefRangeStart = 1421233, XrefRangeEnd = 1421241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1421244, RefRangeEnd = 1421245, XrefRangeStart = 1421242, XrefRangeEnd = 1421244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        TeleportToWaypointEventSystem componentSystem,
        ref TeleportToWaypointEventSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421245, XrefRangeEnd = 1421249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421249, XrefRangeEnd = 1421255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleTeleportToNetherEvents()
      {
        Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, "<>c__DisplayClass_HandleTeleportToNetherEvents");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeFieldInfoPtr_networkIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr, nameof (networkIds));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeFieldInfoPtr_entityCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr, nameof (entityCommandBuffer));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeFieldInfoPtr_requestPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr, nameof (requestPrefab));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr, nameof (_runtimes));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_TeleportToNetherEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr, 100669712);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr, 100669713);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr, 100669714);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr, 100669715);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr, 100669716);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr, 100669717);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr, 100669718);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr, 100669719);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_eventData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<TeleportEvents_ToServer.TeleportToNetherEvent> forParameter_eventData;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1421135, RefRangeEnd = 1421136, XrefRangeStart = 1421129, XrefRangeEnd = 1421135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(TeleportToWaypointEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1421142, RefRangeEnd = 1421143, XrefRangeStart = 1421136, XrefRangeEnd = 1421142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_eventData));
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders>.NativeClassPtr, 100669720);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders>.NativeClassPtr, 100669721);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_eventData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<TeleportEvents_ToServer.TeleportToNetherEvent>.Runtime runtime_eventData;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.Runtime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_eventData));
            TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.TeleportToWaypointEventSystem/ProjectM.<>c__DisplayClass_HandleTeleportToNetherEvents/ProjectM.RunWithoutJobSystem_00000F44$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr, "RunWithoutJobSystem_00000F44$PostfixBurstDelegate");
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669722);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669723);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669724);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669725);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.TeleportToWaypointEventSystem/ProjectM.<>c__DisplayClass_HandleTeleportToNetherEvents/ProjectM.RunWithoutJobSystem_00000F44$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421143, XrefRangeEnd = 1421157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421157, XrefRangeEnd = 1421175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421175, XrefRangeEnd = 1421190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1421217, RefRangeEnd = 1421218, XrefRangeStart = 1421190, XrefRangeEnd = 1421217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents>.NativeClassPtr, "RunWithoutJobSystem_00000F44$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669726);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669727);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669728);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669729);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669731);
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
            IL2CPP.il2cpp_field_static_get_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.TeleportToWaypointEventSystem/ProjectM.<>c__DisplayClass_HandleDebugTeleportToEntityEvents")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_HandleDebugTeleportToEntityEvents
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIds;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_requestPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DebugTeleportToEntityEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<NetworkId, Entity> networkIds;
      [FieldOffset(16)]
      public EntityCommandBuffer entityCommandBuffer;
      [FieldOffset(32)]
      public Entity requestPrefab;
      [FieldOffset(40)]
      public TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(104)]
      public unsafe TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421344, XrefRangeEnd = 1421353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref TeleportEvents_ToServer.DebugTeleportToEntityEvent eventData,
        [In] ref FromCharacter fromCharacter)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref eventData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DebugTeleportToEntityEvent_byref_FromCharacter_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1421227, RefRangeEnd = 1421229, XrefRangeStart = 1421227, XrefRangeEnd = 1421229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref TeleportToWaypointEventSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1421229, RefRangeEnd = 1421231, XrefRangeStart = 1421229, XrefRangeEnd = 1421231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref TeleportToWaypointEventSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421353, XrefRangeEnd = 1421355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1421363, RefRangeEnd = 1421364, XrefRangeStart = 1421355, XrefRangeEnd = 1421363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1421366, RefRangeEnd = 1421367, XrefRangeStart = 1421364, XrefRangeEnd = 1421366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        TeleportToWaypointEventSystem componentSystem,
        ref TeleportToWaypointEventSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421367, XrefRangeEnd = 1421371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421371, XrefRangeEnd = 1421377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleDebugTeleportToEntityEvents()
      {
        Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, "<>c__DisplayClass_HandleDebugTeleportToEntityEvents");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeFieldInfoPtr_networkIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr, nameof (networkIds));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeFieldInfoPtr_entityCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr, nameof (entityCommandBuffer));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeFieldInfoPtr_requestPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr, nameof (requestPrefab));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr, nameof (_runtimes));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DebugTeleportToEntityEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr, 100669732);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr, 100669733);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr, 100669734);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr, 100669735);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr, 100669736);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr, 100669737);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr, 100669738);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr, 100669739);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_eventData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<TeleportEvents_ToServer.DebugTeleportToEntityEvent> forParameter_eventData;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1421261, RefRangeEnd = 1421262, XrefRangeStart = 1421255, XrefRangeEnd = 1421261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(TeleportToWaypointEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1421268, RefRangeEnd = 1421269, XrefRangeStart = 1421262, XrefRangeEnd = 1421268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_eventData));
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders>.NativeClassPtr, 100669740);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders>.NativeClassPtr, 100669741);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_eventData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<TeleportEvents_ToServer.DebugTeleportToEntityEvent>.Runtime runtime_eventData;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.Runtime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_eventData));
            TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.TeleportToWaypointEventSystem/ProjectM.<>c__DisplayClass_HandleDebugTeleportToEntityEvents/ProjectM.RunWithoutJobSystem_00000F4D$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr, "RunWithoutJobSystem_00000F4D$PostfixBurstDelegate");
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669742);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669743);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669744);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669745);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.TeleportToWaypointEventSystem/ProjectM.<>c__DisplayClass_HandleDebugTeleportToEntityEvents/ProjectM.RunWithoutJobSystem_00000F4D$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421269, XrefRangeEnd = 1421283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421283, XrefRangeEnd = 1421301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421301, XrefRangeEnd = 1421316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1421343, RefRangeEnd = 1421344, XrefRangeStart = 1421316, XrefRangeEnd = 1421343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents>.NativeClassPtr, "RunWithoutJobSystem_00000F4D$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669746);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669747);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669748);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669749);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669751);
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
            IL2CPP.il2cpp_field_static_get_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToEntityEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.TeleportToWaypointEventSystem/ProjectM.<>c__DisplayClass_HandleDebugTeleportToNetherEvents")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_HandleDebugTeleportToNetherEvents
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_requestPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DebugTeleportToNetherEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityCommandBuffer entityCommandBuffer;
      [FieldOffset(16)]
      public Entity requestPrefab;
      [FieldOffset(24)]
      public TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(64)]
      public unsafe TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421466, XrefRangeEnd = 1421473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref TeleportEvents_ToServer.DebugTeleportToNetherEvent eventData,
        [In] ref FromCharacter fromCharacter)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref eventData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DebugTeleportToNetherEvent_byref_FromCharacter_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1421473, RefRangeEnd = 1421474, XrefRangeStart = 1421473, XrefRangeEnd = 1421473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref TeleportToWaypointEventSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1421474, RefRangeEnd = 1421475, XrefRangeStart = 1421474, XrefRangeEnd = 1421474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref TeleportToWaypointEventSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421475, XrefRangeEnd = 1421477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1421485, RefRangeEnd = 1421486, XrefRangeStart = 1421477, XrefRangeEnd = 1421485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1421488, RefRangeEnd = 1421489, XrefRangeStart = 1421486, XrefRangeEnd = 1421488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        TeleportToWaypointEventSystem componentSystem,
        ref TeleportToWaypointEventSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421489, XrefRangeEnd = 1421493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421493, XrefRangeEnd = 1421499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleDebugTeleportToNetherEvents()
      {
        Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportToWaypointEventSystem>.NativeClassPtr, "<>c__DisplayClass_HandleDebugTeleportToNetherEvents");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeFieldInfoPtr_entityCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr, nameof (entityCommandBuffer));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeFieldInfoPtr_requestPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr, nameof (requestPrefab));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr, nameof (_runtimes));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DebugTeleportToNetherEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr, 100669752);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr, 100669753);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr, 100669754);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr, 100669755);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr, 100669756);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr, 100669757);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr, 100669758);
        TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr, 100669759);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_eventData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData_Tag<TeleportEvents_ToServer.DebugTeleportToNetherEvent> forParameter_eventData;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1421383, RefRangeEnd = 1421384, XrefRangeStart = 1421377, XrefRangeEnd = 1421383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(TeleportToWaypointEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1421390, RefRangeEnd = 1421391, XrefRangeStart = 1421384, XrefRangeEnd = 1421390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_eventData));
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportToWaypointEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders>.NativeClassPtr, 100669760);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders>.NativeClassPtr, 100669761);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_eventData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData_Tag<TeleportEvents_ToServer.DebugTeleportToNetherEvent>.Runtime runtime_eventData;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.Runtime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_eventData));
            TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.TeleportToWaypointEventSystem/ProjectM.<>c__DisplayClass_HandleDebugTeleportToNetherEvents/ProjectM.RunWithoutJobSystem_00000F56$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr, "RunWithoutJobSystem_00000F56$PostfixBurstDelegate");
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669762);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669763);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669764);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669765);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.TeleportToWaypointEventSystem/ProjectM.<>c__DisplayClass_HandleDebugTeleportToNetherEvents/ProjectM.RunWithoutJobSystem_00000F56$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421391, XrefRangeEnd = 1421405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421405, XrefRangeEnd = 1421423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421423, XrefRangeEnd = 1421438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1421465, RefRangeEnd = 1421466, XrefRangeStart = 1421438, XrefRangeEnd = 1421465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents>.NativeClassPtr, "RunWithoutJobSystem_00000F56$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669766);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669767);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669768);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669769);
          TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669771);
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
            IL2CPP.il2cpp_field_static_get_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TeleportToWaypointEventSystem.__c__DisplayClass_HandleDebugTeleportToNetherEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
