// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.WorldLoadStartupTracker
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Terrain
{
  public class WorldLoadStartupTracker : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastStartupLogTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__SystemCreateTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__SceneLoadRequestQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_WorldTypeSingleton_10;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768129, XrefRangeEnd = 768146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorldLoadStartupTracker.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768146, XrefRangeEnd = 768205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorldLoadStartupTracker.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WorldLoadStartupTracker()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldLoadStartupTracker>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldLoadStartupTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768205, XrefRangeEnd = 768213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorldLoadStartupTracker.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WorldLoadStartupTracker()
    {
      Il2CppClassPointerStore<WorldLoadStartupTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (WorldLoadStartupTracker));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldLoadStartupTracker>.NativeClassPtr);
      WorldLoadStartupTracker.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldLoadStartupTracker>.NativeClassPtr, nameof (_TerrainManager));
      WorldLoadStartupTracker.NativeFieldInfoPtr__LastStartupLogTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldLoadStartupTracker>.NativeClassPtr, nameof (_LastStartupLogTime));
      WorldLoadStartupTracker.NativeFieldInfoPtr__SystemCreateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldLoadStartupTracker>.NativeClassPtr, nameof (_SystemCreateTime));
      WorldLoadStartupTracker.NativeFieldInfoPtr__SceneLoadRequestQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldLoadStartupTracker>.NativeClassPtr, nameof (_SceneLoadRequestQuery));
      WorldLoadStartupTracker.NativeFieldInfoPtr__SingletonEntityQuery_WorldTypeSingleton_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldLoadStartupTracker>.NativeClassPtr, nameof (_SingletonEntityQuery_WorldTypeSingleton_10));
      WorldLoadStartupTracker.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldLoadStartupTracker>.NativeClassPtr, 100667950);
      WorldLoadStartupTracker.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldLoadStartupTracker>.NativeClassPtr, 100667951);
      WorldLoadStartupTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldLoadStartupTracker>.NativeClassPtr, 100667952);
      WorldLoadStartupTracker.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldLoadStartupTracker>.NativeClassPtr, 100667953);
    }

    public WorldLoadStartupTracker(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldLoadStartupTracker.NativeFieldInfoPtr__TerrainManager));
        return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldLoadStartupTracker.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.DateTime _LastStartupLogTime
    {
      get
      {
        return *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldLoadStartupTracker.NativeFieldInfoPtr__LastStartupLogTime));
      }
      [param: In] set
      {
        *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldLoadStartupTracker.NativeFieldInfoPtr__LastStartupLogTime)) = value;
      }
    }

    public unsafe Il2CppSystem.DateTime _SystemCreateTime
    {
      get
      {
        return *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldLoadStartupTracker.NativeFieldInfoPtr__SystemCreateTime));
      }
      [param: In] set
      {
        *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldLoadStartupTracker.NativeFieldInfoPtr__SystemCreateTime)) = value;
      }
    }

    public unsafe EntityQuery _SceneLoadRequestQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldLoadStartupTracker.NativeFieldInfoPtr__SceneLoadRequestQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldLoadStartupTracker.NativeFieldInfoPtr__SceneLoadRequestQuery)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_WorldTypeSingleton_10
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldLoadStartupTracker.NativeFieldInfoPtr__SingletonEntityQuery_WorldTypeSingleton_10));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldLoadStartupTracker.NativeFieldInfoPtr__SingletonEntityQuery_WorldTypeSingleton_10)) = value;
      }
    }
  }
}
