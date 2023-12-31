// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.ConditionCheckerFactory
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Debugging;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  public class ConditionCheckerFactory : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__System;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameplayEventDebuggingSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__MapZoneCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTimeAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__DayNightCycle;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__BalanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TilePolygons;
    private static readonly System.IntPtr NativeMethodInfoPtr_Build_Public_ConditionChecker_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

    [CallerCount(28)]
    [CachedScanResults(RefRangeStart = 800676, RefRangeEnd = 800704, XrefRangeStart = 800652, XrefRangeEnd = 800676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConditionChecker Build(bool includeCollisionWorldAndMapData = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &includeCollisionWorldAndMapData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionCheckerFactory.NativeMethodInfoPtr_Build_Public_ConditionChecker_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ConditionChecker*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(28)]
    [CachedScanResults(RefRangeStart = 800748, RefRangeEnd = 800776, XrefRangeStart = 800704, XrefRangeEnd = 800748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConditionCheckerFactory(SystemBase system)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionCheckerFactory>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConditionCheckerFactory.NativeMethodInfoPtr__ctor_Public_Void_SystemBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(28)]
    [CachedScanResults(RefRangeStart = 800789, RefRangeEnd = 800817, XrefRangeStart = 800776, XrefRangeEnd = 800789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConditionCheckerFactory.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ConditionCheckerFactory()
    {
      Il2CppClassPointerStore<ConditionCheckerFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (ConditionCheckerFactory));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionCheckerFactory>.NativeClassPtr);
      ConditionCheckerFactory.NativeFieldInfoPtr__System = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionCheckerFactory>.NativeClassPtr, nameof (_System));
      ConditionCheckerFactory.NativeFieldInfoPtr__GameplayEventDebuggingSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionCheckerFactory>.NativeClassPtr, nameof (_GameplayEventDebuggingSystem));
      ConditionCheckerFactory.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionCheckerFactory>.NativeClassPtr, nameof (_TileWorldSystem));
      ConditionCheckerFactory.NativeFieldInfoPtr__MapZoneCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionCheckerFactory>.NativeClassPtr, nameof (_MapZoneCollectionSystem));
      ConditionCheckerFactory.NativeFieldInfoPtr__ServerTimeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionCheckerFactory>.NativeClassPtr, nameof (_ServerTimeAccessor));
      ConditionCheckerFactory.NativeFieldInfoPtr__DayNightCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionCheckerFactory>.NativeClassPtr, nameof (_DayNightCycle));
      ConditionCheckerFactory.NativeFieldInfoPtr__ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionCheckerFactory>.NativeClassPtr, nameof (_ServerDebugSettings));
      ConditionCheckerFactory.NativeFieldInfoPtr__BalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionCheckerFactory>.NativeClassPtr, nameof (_BalanceSettings));
      ConditionCheckerFactory.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionCheckerFactory>.NativeClassPtr, nameof (_GameDataSystem));
      ConditionCheckerFactory.NativeFieldInfoPtr__CollisionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionCheckerFactory>.NativeClassPtr, nameof (_CollisionSystem));
      ConditionCheckerFactory.NativeFieldInfoPtr__TilePolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionCheckerFactory>.NativeClassPtr, nameof (_TilePolygons));
      ConditionCheckerFactory.NativeMethodInfoPtr_Build_Public_ConditionChecker_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionCheckerFactory>.NativeClassPtr, 100670629);
      ConditionCheckerFactory.NativeMethodInfoPtr__ctor_Public_Void_SystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionCheckerFactory>.NativeClassPtr, 100670630);
      ConditionCheckerFactory.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionCheckerFactory>.NativeClassPtr, 100670631);
    }

    public ConditionCheckerFactory(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SystemBase _System
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__System));
        return pointer == System.IntPtr.Zero ? (SystemBase) null : new SystemBase(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__System), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameplayEventDebuggingSystem _GameplayEventDebuggingSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__GameplayEventDebuggingSystem));
        return pointer == System.IntPtr.Zero ? (GameplayEventDebuggingSystem) null : new GameplayEventDebuggingSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__GameplayEventDebuggingSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapZoneCollectionSystem _MapZoneCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__MapZoneCollectionSystem));
        return pointer == System.IntPtr.Zero ? (MapZoneCollectionSystem) null : new MapZoneCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__MapZoneCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTimeAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__ServerTimeAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__ServerTimeAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<DayNightCycle> _DayNightCycle
    {
      get
      {
        return *(SingletonAccessor<DayNightCycle>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__DayNightCycle));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__DayNightCycle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<DayNightCycle>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _ServerDebugSettings
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__ServerDebugSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__ServerDebugSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerGameBalanceSettings> _BalanceSettings
    {
      get
      {
        return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__BalanceSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__BalanceSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CollisionSystem _CollisionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__CollisionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionSystem) null : new CollisionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__CollisionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileMapCollisionMath.TilePolygons _TilePolygons
    {
      get
      {
        return *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__TilePolygons));
      }
      [param: In] set
      {
        *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionCheckerFactory.NativeFieldInfoPtr__TilePolygons)) = value;
      }
    }
  }
}
